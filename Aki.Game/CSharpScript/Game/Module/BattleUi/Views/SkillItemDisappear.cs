using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DC4 RID: 24004
	[NullableContext(2)]
	[Nullable(0)]
	public class SkillItemDisappear : UiPanelBase
	{
		// Token: 0x0603CFEF RID: 249839 RVA: 0x00EAA580 File Offset: 0x00EA8780
		[NullableContext(1)]
		public SkillItemDisappear(UUIItem parentItem, [Nullable(2)] string iconPath = null)
		{
			this.IconPath = iconPath;
			base.CreateByResourceIdAsync("UiItem_FightSkill_WaterBox", parentItem, false).Forget();
		}

		// Token: 0x0603CFF0 RID: 249840 RVA: 0x00EAA5A4 File Offset: 0x00EA87A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CFF1 RID: 249841 RVA: 0x00EAA5EC File Offset: 0x00EA87EC
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEnd));
			this.IsReady = true;
			this.SyncSkillIconFromPath();
			if (!this.IsIconLoading)
			{
				this.FlushPendingAfterIconLoaded();
			}
		}

		// Token: 0x0603CFF2 RID: 249842 RVA: 0x00EAA63C File Offset: 0x00EA883C
		protected override void OnBeforeDestroy()
		{
			if (this.LoadIconHandleId != null)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadIconHandleId.Value);
				this.LoadIconHandleId = null;
			}
			this.IsIconLoading = false;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.OnDisappearFinishedCallback = null;
			this.OnDisappearStartCallback = null;
			this.PendingDisappearing = null;
			base.OnBeforeDestroy();
		}

		// Token: 0x0603CFF3 RID: 249843 RVA: 0x00EAA6B8 File Offset: 0x00EA88B8
		private void SyncSkillIconFromPath()
		{
			if (string.IsNullOrEmpty(this.IconPath))
			{
				return;
			}
			string iconPath = this.IconPath;
			UUITexture skillIconTexture = base.GetTexture(0);
			if (skillIconTexture == null)
			{
				return;
			}
			skillIconTexture.SetUIActive(false);
			this.IsIconLoading = true;
			bool hasLoadCallbackRun = false;
			int num = ResourceSystem.Instance.LoadAsync<UTexture>(iconPath, delegate([Nullable(2)] UTexture texture, string _)
			{
				hasLoadCallbackRun = true;
				this.IsIconLoading = false;
				this.LoadIconHandleId = null;
				if (this.IsDestroyOrDestroying)
				{
					return;
				}
				if (skillIconTexture.IsValid())
				{
					if (texture != null && texture.IsValid())
					{
						skillIconTexture.SetTexture(texture);
					}
					skillIconTexture.SetUIActive(true);
				}
				this.FlushPendingAfterIconLoaded();
			}, ResourceSystem.EResourceLoadPriority.BattleUi, "js_undefined");
			if (!hasLoadCallbackRun && num != -1)
			{
				this.LoadIconHandleId = new int?(num);
			}
		}

		// Token: 0x0603CFF4 RID: 249844 RVA: 0x00EAA750 File Offset: 0x00EA8950
		private void FlushPendingAfterIconLoaded()
		{
			if (this.PendingDisappearing != null)
			{
				bool value = this.PendingDisappearing.Value;
				this.PendingDisappearing = null;
				this.ApplyDisappear(value);
			}
		}

		// Token: 0x0603CFF5 RID: 249845 RVA: 0x00EAA789 File Offset: 0x00EA8989
		public void SetOnDisappearFinishedCallback(Action callback)
		{
			this.OnDisappearFinishedCallback = callback;
		}

		// Token: 0x0603CFF6 RID: 249846 RVA: 0x00EAA792 File Offset: 0x00EA8992
		public void SetOnDisappearStartCallback(Action callback)
		{
			this.OnDisappearStartCallback = callback;
		}

		// Token: 0x0603CFF7 RID: 249847 RVA: 0x00EAA79B File Offset: 0x00EA899B
		[NullableContext(1)]
		private void OnSequenceEnd(string sequenceName)
		{
			if (sequenceName != "FadeOut")
			{
				return;
			}
			Action onDisappearFinishedCallback = this.OnDisappearFinishedCallback;
			if (onDisappearFinishedCallback == null)
			{
				return;
			}
			onDisappearFinishedCallback();
		}

		// Token: 0x0603CFF8 RID: 249848 RVA: 0x00EAA7BB File Offset: 0x00EA89BB
		public void SetDisappear(bool isDisappearing)
		{
			if (!this.IsReady || this.IsIconLoading)
			{
				this.PendingDisappearing = new bool?(isDisappearing);
				return;
			}
			this.ApplyDisappear(isDisappearing);
		}

		// Token: 0x0603CFF9 RID: 249849 RVA: 0x00EAA7E4 File Offset: 0x00EA89E4
		private void ApplyDisappear(bool isDisappearing)
		{
			if (!isDisappearing)
			{
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.StopSequenceByKey("FadeOut", false, false);
				}
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			Action onDisappearStartCallback = this.OnDisappearStartCallback;
			if (onDisappearStartCallback != null)
			{
				onDisappearStartCallback();
			}
			UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 == null)
			{
				return;
			}
			sequencePlayer2.PlayOrReplaySequenceByName("FadeOut", false, null);
		}

		// Token: 0x0401FC73 RID: 130163
		[Nullable(1)]
		private const string DISAPPEAR_ANIMATION_NAME = "FadeOut";

		// Token: 0x0401FC74 RID: 130164
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401FC75 RID: 130165
		private bool IsReady;

		// Token: 0x0401FC76 RID: 130166
		private bool? PendingDisappearing;

		// Token: 0x0401FC77 RID: 130167
		private Action OnDisappearFinishedCallback;

		// Token: 0x0401FC78 RID: 130168
		private Action OnDisappearStartCallback;

		// Token: 0x0401FC79 RID: 130169
		private readonly string IconPath;

		// Token: 0x0401FC7A RID: 130170
		private bool IsIconLoading;

		// Token: 0x0401FC7B RID: 130171
		private int? LoadIconHandleId;

		// Token: 0x0200C0C8 RID: 49352
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A2A3 RID: 238243
			SkillIcon
		}
	}
}

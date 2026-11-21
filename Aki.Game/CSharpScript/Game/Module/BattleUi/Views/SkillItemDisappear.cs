using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DA8 RID: 19880
	[NullableContext(2)]
	[Nullable(0)]
	public class SkillItemDisappear : UiPanelBase
	{
		// Token: 0x06031F66 RID: 204646 RVA: 0x00DFB45C File Offset: 0x00DF965C
		[NullableContext(1)]
		public SkillItemDisappear(UUIItem parentItem, [Nullable(2)] string iconPath = null)
		{
			this.IconPath = iconPath;
			base.CreateByResourceIdAsync("UiItem_FightSkill_WaterBox", parentItem, false).Forget();
		}

		// Token: 0x06031F67 RID: 204647 RVA: 0x00DFB480 File Offset: 0x00DF9680
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

		// Token: 0x06031F68 RID: 204648 RVA: 0x00DFB4C8 File Offset: 0x00DF96C8
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

		// Token: 0x06031F69 RID: 204649 RVA: 0x00DFB518 File Offset: 0x00DF9718
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

		// Token: 0x06031F6A RID: 204650 RVA: 0x00DFB594 File Offset: 0x00DF9794
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

		// Token: 0x06031F6B RID: 204651 RVA: 0x00DFB62C File Offset: 0x00DF982C
		private void FlushPendingAfterIconLoaded()
		{
			if (this.PendingDisappearing != null)
			{
				bool value = this.PendingDisappearing.Value;
				this.PendingDisappearing = null;
				this.ApplyDisappear(value);
			}
		}

		// Token: 0x06031F6C RID: 204652 RVA: 0x00DFB665 File Offset: 0x00DF9865
		public void SetOnDisappearFinishedCallback(Action callback)
		{
			this.OnDisappearFinishedCallback = callback;
		}

		// Token: 0x06031F6D RID: 204653 RVA: 0x00DFB66E File Offset: 0x00DF986E
		public void SetOnDisappearStartCallback(Action callback)
		{
			this.OnDisappearStartCallback = callback;
		}

		// Token: 0x06031F6E RID: 204654 RVA: 0x00DFB677 File Offset: 0x00DF9877
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

		// Token: 0x06031F6F RID: 204655 RVA: 0x00DFB697 File Offset: 0x00DF9897
		public void SetDisappear(bool isDisappearing)
		{
			if (!this.IsReady || this.IsIconLoading)
			{
				this.PendingDisappearing = new bool?(isDisappearing);
				return;
			}
			this.ApplyDisappear(isDisappearing);
		}

		// Token: 0x06031F70 RID: 204656 RVA: 0x00DFB6C0 File Offset: 0x00DF98C0
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

		// Token: 0x0401A730 RID: 108336
		[Nullable(1)]
		private const string DISAPPEAR_ANIMATION_NAME = "FadeOut";

		// Token: 0x0401A731 RID: 108337
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401A732 RID: 108338
		private bool IsReady;

		// Token: 0x0401A733 RID: 108339
		private bool? PendingDisappearing;

		// Token: 0x0401A734 RID: 108340
		private Action OnDisappearFinishedCallback;

		// Token: 0x0401A735 RID: 108341
		private Action OnDisappearStartCallback;

		// Token: 0x0401A736 RID: 108342
		private readonly string IconPath;

		// Token: 0x0401A737 RID: 108343
		private bool IsIconLoading;

		// Token: 0x0401A738 RID: 108344
		private int? LoadIconHandleId;

		// Token: 0x0200AAD1 RID: 43729
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034C75 RID: 216181
			SkillIcon
		}
	}
}

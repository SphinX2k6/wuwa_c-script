using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D2F RID: 23855
	[NullableContext(1)]
	[Nullable(0)]
	public class FullScreenPanel : BattleChildViewPanel
	{
		// Token: 0x0603C7F2 RID: 247794 RVA: 0x00E836EF File Offset: 0x00E818EF
		public override void InitializeTemp()
		{
			this.AddScreenEffectFightRoot();
		}

		// Token: 0x0603C7F3 RID: 247795 RVA: 0x00E836F7 File Offset: 0x00E818F7
		public override void Reset()
		{
			this.ClearFullScreenNiagaraItem();
			this.RemoveScreenEffectFightRoot();
			base.Reset();
		}

		// Token: 0x0603C7F4 RID: 247796 RVA: 0x00E8370C File Offset: 0x00E8190C
		protected override void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnAddFullScreenEffect, new Action<FullScreenEffectHandle>(this.OnAddFullScreenEffect));
			EventSystem.Instance.Add(EEventName.OnRemoveFullScreenEffect, new Action<FullScreenEffectHandle>(this.OnRemoveFullScreenEffect));
			EventSystem.Instance.Add(EEventName.OnClearFullScreenEffect, new Action(this.OnClearFullScreenEffect));
			EventSystem.Instance.Add(EEventName.OnChangeFullScreenNiagaraFloatParameter, new Action<long, string, float>(this.OnChangeFullScreenNiagaraFloatParameter));
		}

		// Token: 0x0603C7F5 RID: 247797 RVA: 0x00E8378C File Offset: 0x00E8198C
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnAddFullScreenEffect, new Action<FullScreenEffectHandle>(this.OnAddFullScreenEffect));
			EventSystem.Instance.Remove(EEventName.OnRemoveFullScreenEffect, new Action<FullScreenEffectHandle>(this.OnRemoveFullScreenEffect));
			EventSystem.Instance.Remove(EEventName.OnClearFullScreenEffect, new Action(this.OnClearFullScreenEffect));
			EventSystem.Instance.Remove(EEventName.OnChangeFullScreenNiagaraFloatParameter, new Action<long, string, float>(this.OnChangeFullScreenNiagaraFloatParameter));
		}

		// Token: 0x0603C7F6 RID: 247798 RVA: 0x00E8380C File Offset: 0x00E81A0C
		private void OnAddFullScreenEffect(FullScreenEffectHandle fullScreenEffectHandle)
		{
			long uniqueId = fullScreenEffectHandle.UniqueId;
			string niagaraPath = fullScreenEffectHandle.NiagaraPath;
			this.AddFullScreenNiagaraItem(uniqueId, niagaraPath).ContinueWith(delegate(FullScreenNiagaraItem fullScreenNiagaraItem)
			{
				if (fullScreenNiagaraItem == null)
				{
					return;
				}
				foreach (KeyValuePair<string, float> keyValuePair in fullScreenEffectHandle.GetFloatParameterMap())
				{
					string text;
					float num;
					keyValuePair.Deconstruct(out text, out num);
					string key = text;
					float value = num;
					fullScreenNiagaraItem.SetNiagaraFloatValue(key, value);
				}
			});
		}

		// Token: 0x0603C7F7 RID: 247799 RVA: 0x00E83858 File Offset: 0x00E81A58
		private void OnRemoveFullScreenEffect(FullScreenEffectHandle fullScreenEffectHandle)
		{
			long uniqueId = fullScreenEffectHandle.UniqueId;
			this.RemovePendingDisplay(uniqueId);
			this.RemoveFullScreenNiagaraItem(uniqueId);
		}

		// Token: 0x0603C7F8 RID: 247800 RVA: 0x00E8387B File Offset: 0x00E81A7B
		private void OnClearFullScreenEffect()
		{
			this.ClearFullScreenNiagaraItem();
		}

		// Token: 0x0603C7F9 RID: 247801 RVA: 0x00E83884 File Offset: 0x00E81A84
		private void OnChangeFullScreenNiagaraFloatParameter(long uniqueId, string key, float value)
		{
			FullScreenNiagaraItem fullScreenNiagaraItem = this.GetFullScreenNiagaraItem(uniqueId);
			if (fullScreenNiagaraItem == null)
			{
				return;
			}
			fullScreenNiagaraItem.SetNiagaraFloatValue(key, value);
		}

		// Token: 0x0603C7FA RID: 247802 RVA: 0x00E838A5 File Offset: 0x00E81AA5
		private void AddPendingDisplay(long uniqueId)
		{
			this.PendingDisplayUniqueIdSet.Add(uniqueId);
		}

		// Token: 0x0603C7FB RID: 247803 RVA: 0x00E838B4 File Offset: 0x00E81AB4
		private void RemovePendingDisplay(long uniqueId)
		{
			this.PendingDisplayUniqueIdSet.Remove(uniqueId);
		}

		// Token: 0x0603C7FC RID: 247804 RVA: 0x00E838C3 File Offset: 0x00E81AC3
		private bool IsPendingDisplay(long uniqueId)
		{
			return this.PendingDisplayUniqueIdSet.Contains(uniqueId);
		}

		// Token: 0x0603C7FD RID: 247805 RVA: 0x00E838D4 File Offset: 0x00E81AD4
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<FullScreenNiagaraItem> AddFullScreenNiagaraItem(long uniqueId, string niagaraPath)
		{
			FullScreenPanel.<AddFullScreenNiagaraItem>d__14 <AddFullScreenNiagaraItem>d__;
			<AddFullScreenNiagaraItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FullScreenNiagaraItem>.Create();
			<AddFullScreenNiagaraItem>d__.<>4__this = this;
			<AddFullScreenNiagaraItem>d__.uniqueId = uniqueId;
			<AddFullScreenNiagaraItem>d__.niagaraPath = niagaraPath;
			<AddFullScreenNiagaraItem>d__.<>1__state = -1;
			<AddFullScreenNiagaraItem>d__.<>t__builder.Start<FullScreenPanel.<AddFullScreenNiagaraItem>d__14>(ref <AddFullScreenNiagaraItem>d__);
			return <AddFullScreenNiagaraItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C7FE RID: 247806 RVA: 0x00E83928 File Offset: 0x00E81B28
		private bool RemoveFullScreenNiagaraItem(long uniqueId)
		{
			FullScreenNiagaraItem fullScreenNiagaraItem = this.GetFullScreenNiagaraItem(uniqueId);
			if (fullScreenNiagaraItem == null)
			{
				return false;
			}
			fullScreenNiagaraItem.Destroy(null);
			this.FullScreenNiagaraItemMap.Remove(uniqueId);
			return true;
		}

		// Token: 0x0603C7FF RID: 247807 RVA: 0x00E83958 File Offset: 0x00E81B58
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<FullScreenNiagaraItem> NewFullScreenNiagaraItem(long cueId)
		{
			FullScreenPanel.<NewFullScreenNiagaraItem>d__16 <NewFullScreenNiagaraItem>d__;
			<NewFullScreenNiagaraItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FullScreenNiagaraItem>.Create();
			<NewFullScreenNiagaraItem>d__.<>4__this = this;
			<NewFullScreenNiagaraItem>d__.<>1__state = -1;
			<NewFullScreenNiagaraItem>d__.<>t__builder.Start<FullScreenPanel.<NewFullScreenNiagaraItem>d__16>(ref <NewFullScreenNiagaraItem>d__);
			return <NewFullScreenNiagaraItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C800 RID: 247808 RVA: 0x00E8399B File Offset: 0x00E81B9B
		[NullableContext(2)]
		private FullScreenNiagaraItem GetFullScreenNiagaraItem(long cueId)
		{
			return this.FullScreenNiagaraItemMap.GetValueOrDefault(cueId);
		}

		// Token: 0x0603C801 RID: 247809 RVA: 0x00E839AC File Offset: 0x00E81BAC
		private void ClearFullScreenNiagaraItem()
		{
			if (this.FullScreenNiagaraItemMap.Count <= 0)
			{
				return;
			}
			foreach (FullScreenNiagaraItem fullScreenNiagaraItem in this.FullScreenNiagaraItemMap.Values)
			{
				fullScreenNiagaraItem.Reset();
			}
			this.FullScreenNiagaraItemMap.Clear();
			this.PendingDisplayUniqueIdSet.Clear();
		}

		// Token: 0x0603C802 RID: 247810 RVA: 0x00E83A28 File Offset: 0x00E81C28
		private void AddScreenEffectFightRoot()
		{
			BP_ScreenEffectSystem_C instance = ScreenEffectSystem.GetInstance();
			if (!instance.IsValid())
			{
				return;
			}
			instance.GetScreenEffectFightRoot(ref this.ScreenEffectFightRoot);
			AUIContainerActor screenEffectFightRoot = this.ScreenEffectFightRoot;
			if (screenEffectFightRoot != null)
			{
				screenEffectFightRoot.K2_AttachRootComponentTo(this.RootItem, default(FName), EAttachLocation.KeepRelativeOffset, true);
			}
			ScreenEffectModel.Instance.SetFightRootInited(true);
		}

		// Token: 0x0603C803 RID: 247811 RVA: 0x00E83A7D File Offset: 0x00E81C7D
		private void RemoveScreenEffectFightRoot()
		{
			AUIContainerActor screenEffectFightRoot = this.ScreenEffectFightRoot;
			if (screenEffectFightRoot != null && screenEffectFightRoot.IsValid())
			{
				this.ScreenEffectFightRoot.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
			}
			this.ScreenEffectFightRoot = null;
			ScreenEffectModel.Instance.SetFightRootInited(false);
		}

		// Token: 0x0401F85C RID: 129116
		private readonly Dictionary<long, FullScreenNiagaraItem> FullScreenNiagaraItemMap = new Dictionary<long, FullScreenNiagaraItem>();

		// Token: 0x0401F85D RID: 129117
		private readonly HashSet<long> PendingDisplayUniqueIdSet = new HashSet<long>();

		// Token: 0x0401F85E RID: 129118
		[Nullable(2)]
		private AUIContainerActor ScreenEffectFightRoot;
	}
}

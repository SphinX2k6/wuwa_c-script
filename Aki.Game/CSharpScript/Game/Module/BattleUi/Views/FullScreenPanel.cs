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
	// Token: 0x02004D11 RID: 19729
	[NullableContext(1)]
	[Nullable(0)]
	public class FullScreenPanel : BattleChildViewPanel
	{
		// Token: 0x0603174B RID: 202571 RVA: 0x00DD3E8F File Offset: 0x00DD208F
		public override void InitializeTemp()
		{
			this.AddScreenEffectFightRoot();
		}

		// Token: 0x0603174C RID: 202572 RVA: 0x00DD3E97 File Offset: 0x00DD2097
		public override void Reset()
		{
			this.ClearFullScreenNiagaraItem();
			this.RemoveScreenEffectFightRoot();
			base.Reset();
		}

		// Token: 0x0603174D RID: 202573 RVA: 0x00DD3EAC File Offset: 0x00DD20AC
		protected override void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnAddFullScreenEffect, new Action<FullScreenEffectHandle>(this.OnAddFullScreenEffect));
			EventSystem.Instance.Add(EEventName.OnRemoveFullScreenEffect, new Action<FullScreenEffectHandle>(this.OnRemoveFullScreenEffect));
			EventSystem.Instance.Add(EEventName.OnClearFullScreenEffect, new Action(this.OnClearFullScreenEffect));
			EventSystem.Instance.Add(EEventName.OnChangeFullScreenNiagaraFloatParameter, new Action<long, string, float>(this.OnChangeFullScreenNiagaraFloatParameter));
		}

		// Token: 0x0603174E RID: 202574 RVA: 0x00DD3F2C File Offset: 0x00DD212C
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnAddFullScreenEffect, new Action<FullScreenEffectHandle>(this.OnAddFullScreenEffect));
			EventSystem.Instance.Remove(EEventName.OnRemoveFullScreenEffect, new Action<FullScreenEffectHandle>(this.OnRemoveFullScreenEffect));
			EventSystem.Instance.Remove(EEventName.OnClearFullScreenEffect, new Action(this.OnClearFullScreenEffect));
			EventSystem.Instance.Remove(EEventName.OnChangeFullScreenNiagaraFloatParameter, new Action<long, string, float>(this.OnChangeFullScreenNiagaraFloatParameter));
		}

		// Token: 0x0603174F RID: 202575 RVA: 0x00DD3FAC File Offset: 0x00DD21AC
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

		// Token: 0x06031750 RID: 202576 RVA: 0x00DD3FF8 File Offset: 0x00DD21F8
		private void OnRemoveFullScreenEffect(FullScreenEffectHandle fullScreenEffectHandle)
		{
			long uniqueId = fullScreenEffectHandle.UniqueId;
			this.RemovePendingDisplay(uniqueId);
			this.RemoveFullScreenNiagaraItem(uniqueId);
		}

		// Token: 0x06031751 RID: 202577 RVA: 0x00DD401B File Offset: 0x00DD221B
		private void OnClearFullScreenEffect()
		{
			this.ClearFullScreenNiagaraItem();
		}

		// Token: 0x06031752 RID: 202578 RVA: 0x00DD4024 File Offset: 0x00DD2224
		private void OnChangeFullScreenNiagaraFloatParameter(long uniqueId, string key, float value)
		{
			FullScreenNiagaraItem fullScreenNiagaraItem = this.GetFullScreenNiagaraItem(uniqueId);
			if (fullScreenNiagaraItem == null)
			{
				return;
			}
			fullScreenNiagaraItem.SetNiagaraFloatValue(key, value);
		}

		// Token: 0x06031753 RID: 202579 RVA: 0x00DD4045 File Offset: 0x00DD2245
		private void AddPendingDisplay(long uniqueId)
		{
			this.PendingDisplayUniqueIdSet.Add(uniqueId);
		}

		// Token: 0x06031754 RID: 202580 RVA: 0x00DD4054 File Offset: 0x00DD2254
		private void RemovePendingDisplay(long uniqueId)
		{
			this.PendingDisplayUniqueIdSet.Remove(uniqueId);
		}

		// Token: 0x06031755 RID: 202581 RVA: 0x00DD4063 File Offset: 0x00DD2263
		private bool IsPendingDisplay(long uniqueId)
		{
			return this.PendingDisplayUniqueIdSet.Contains(uniqueId);
		}

		// Token: 0x06031756 RID: 202582 RVA: 0x00DD4074 File Offset: 0x00DD2274
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

		// Token: 0x06031757 RID: 202583 RVA: 0x00DD40C8 File Offset: 0x00DD22C8
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

		// Token: 0x06031758 RID: 202584 RVA: 0x00DD40F8 File Offset: 0x00DD22F8
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

		// Token: 0x06031759 RID: 202585 RVA: 0x00DD413B File Offset: 0x00DD233B
		[NullableContext(2)]
		private FullScreenNiagaraItem GetFullScreenNiagaraItem(long cueId)
		{
			return this.FullScreenNiagaraItemMap.GetValueOrDefault(cueId);
		}

		// Token: 0x0603175A RID: 202586 RVA: 0x00DD414C File Offset: 0x00DD234C
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

		// Token: 0x0603175B RID: 202587 RVA: 0x00DD41C8 File Offset: 0x00DD23C8
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

		// Token: 0x0603175C RID: 202588 RVA: 0x00DD421D File Offset: 0x00DD241D
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

		// Token: 0x0401A315 RID: 107285
		private readonly Dictionary<long, FullScreenNiagaraItem> FullScreenNiagaraItemMap = new Dictionary<long, FullScreenNiagaraItem>();

		// Token: 0x0401A316 RID: 107286
		private readonly HashSet<long> PendingDisplayUniqueIdSet = new HashSet<long>();

		// Token: 0x0401A317 RID: 107287
		[Nullable(2)]
		private AUIContainerActor ScreenEffectFightRoot;
	}
}

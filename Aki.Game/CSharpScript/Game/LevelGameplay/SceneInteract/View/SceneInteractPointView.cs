using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.View
{
	// Token: 0x02006A81 RID: 27265
	public class SceneInteractPointView : SceneInteractPointViewBase
	{
		// Token: 0x06043C35 RID: 277557 RVA: 0x0109606C File Offset: 0x0109426C
		protected override void OnRegisterComponent()
		{
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
			}
		}

		// Token: 0x06043C36 RID: 277558 RVA: 0x01096098 File Offset: 0x01094298
		protected override UniTask OnBeforeStartAsync()
		{
			SceneInteractPointView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SceneInteractPointView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043C37 RID: 277559 RVA: 0x010960DB File Offset: 0x010942DB
		protected override void OnStart()
		{
			this.AddEvents();
		}

		// Token: 0x06043C38 RID: 277560 RVA: 0x010960E3 File Offset: 0x010942E3
		protected void AddEvents()
		{
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x06043C39 RID: 277561 RVA: 0x01096101 File Offset: 0x01094301
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x06043C3A RID: 277562 RVA: 0x0109611F File Offset: 0x0109431F
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
		}

		// Token: 0x06043C3B RID: 277563 RVA: 0x01096127 File Offset: 0x01094327
		private void OnMotorcycleStateChanged(bool bDriving)
		{
			this.RefreshKeyAction();
		}

		// Token: 0x06043C3C RID: 277564 RVA: 0x0109612F File Offset: 0x0109432F
		private void RefreshKeyAction()
		{
			if (this.KeyItem != null)
			{
				this.KeyItem.RefreshAction("跳跃");
			}
		}

		// Token: 0x04023674 RID: 145012
		[Nullable(2)]
		private CombineKeyItem KeyItem;

		// Token: 0x0200CB89 RID: 52105
		private enum EChildType
		{
			// Token: 0x0403D724 RID: 251684
			CommonItem,
			// Token: 0x0403D725 RID: 251685
			InterruptItem,
			// Token: 0x0403D726 RID: 251686
			SkillIcon,
			// Token: 0x0403D727 RID: 251687
			EffectOnce,
			// Token: 0x0403D728 RID: 251688
			KeyItem
		}
	}
}

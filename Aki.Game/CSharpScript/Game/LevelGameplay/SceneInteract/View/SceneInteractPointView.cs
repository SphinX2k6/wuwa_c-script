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
	// Token: 0x02005BDE RID: 23518
	public class SceneInteractPointView : SceneInteractPointViewBase
	{
		// Token: 0x06039C83 RID: 236675 RVA: 0x0103A8AC File Offset: 0x01038AAC
		protected override void OnRegisterComponent()
		{
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
			}
		}

		// Token: 0x06039C84 RID: 236676 RVA: 0x0103A8D8 File Offset: 0x01038AD8
		protected override UniTask OnBeforeStartAsync()
		{
			SceneInteractPointView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SceneInteractPointView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039C85 RID: 236677 RVA: 0x0103A91B File Offset: 0x01038B1B
		protected override void OnStart()
		{
			this.AddEvents();
		}

		// Token: 0x06039C86 RID: 236678 RVA: 0x0103A923 File Offset: 0x01038B23
		protected void AddEvents()
		{
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x06039C87 RID: 236679 RVA: 0x0103A941 File Offset: 0x01038B41
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x06039C88 RID: 236680 RVA: 0x0103A95F File Offset: 0x01038B5F
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
		}

		// Token: 0x06039C89 RID: 236681 RVA: 0x0103A967 File Offset: 0x01038B67
		private void OnMotorcycleStateChanged(bool bDriving)
		{
			this.RefreshKeyAction();
		}

		// Token: 0x06039C8A RID: 236682 RVA: 0x0103A96F File Offset: 0x01038B6F
		private void RefreshKeyAction()
		{
			if (this.KeyItem != null)
			{
				this.KeyItem.RefreshAction("跳跃");
			}
		}

		// Token: 0x0401E866 RID: 125030
		[Nullable(2)]
		private CombineKeyItem KeyItem;

		// Token: 0x0200B768 RID: 46952
		private enum EChildType
		{
			// Token: 0x04038B06 RID: 232198
			CommonItem,
			// Token: 0x04038B07 RID: 232199
			InterruptItem,
			// Token: 0x04038B08 RID: 232200
			SkillIcon,
			// Token: 0x04038B09 RID: 232201
			EffectOnce,
			// Token: 0x04038B0A RID: 232202
			KeyItem
		}
	}
}

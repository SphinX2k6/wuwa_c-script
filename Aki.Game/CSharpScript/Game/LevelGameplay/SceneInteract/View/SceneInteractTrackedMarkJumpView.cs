using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.View
{
	// Token: 0x02005BE0 RID: 23520
	public class SceneInteractTrackedMarkJumpView : SceneInteractPointViewBase
	{
		// Token: 0x06039C8F RID: 236687 RVA: 0x0103AA04 File Offset: 0x01038C04
		protected unsafe override void OnRegisterComponent()
		{
			int num;
			Span<ValueTuple<int, Type>> span;
			int num2;
			if (Info.Instance.IsInTouch())
			{
				num = 2;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
				this.ComponentRegisterInfos = list;
				return;
			}
			num2 = 3;
			List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
			span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
			num = 0;
			*span[num] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list2;
		}

		// Token: 0x06039C90 RID: 236688 RVA: 0x0103AAF8 File Offset: 0x01038CF8
		protected override UniTask OnBeforeStartAsync()
		{
			SceneInteractTrackedMarkJumpView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SceneInteractTrackedMarkJumpView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039C91 RID: 236689 RVA: 0x0103AB3B File Offset: 0x01038D3B
		protected override void OnStart()
		{
			this.AddEvents();
		}

		// Token: 0x06039C92 RID: 236690 RVA: 0x0103AB43 File Offset: 0x01038D43
		protected void AddEvents()
		{
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x06039C93 RID: 236691 RVA: 0x0103AB61 File Offset: 0x01038D61
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x06039C94 RID: 236692 RVA: 0x0103AB7F File Offset: 0x01038D7F
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
			this.KeyItem = null;
		}

		// Token: 0x06039C95 RID: 236693 RVA: 0x0103AB8E File Offset: 0x01038D8E
		private void OnMotorcycleStateChanged(bool bDriving)
		{
			this.RefreshKeyAction();
		}

		// Token: 0x06039C96 RID: 236694 RVA: 0x0103AB96 File Offset: 0x01038D96
		private void RefreshKeyAction()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshByActionOrAxis(new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = "跳跃"
			}, false);
		}

		// Token: 0x0401E869 RID: 125033
		[Nullable(2)]
		private InputMultiKeyItem KeyItem;

		// Token: 0x0200B76A RID: 46954
		private enum EChildType
		{
			// Token: 0x04038B10 RID: 232208
			PnlPoint,
			// Token: 0x04038B11 RID: 232209
			SprArrow
		}

		// Token: 0x0200B76B RID: 46955
		private enum EChildTypePc
		{
			// Token: 0x04038B13 RID: 232211
			PnlPoint,
			// Token: 0x04038B14 RID: 232212
			SprArrow,
			// Token: 0x04038B15 RID: 232213
			HotKeyCombine
		}
	}
}

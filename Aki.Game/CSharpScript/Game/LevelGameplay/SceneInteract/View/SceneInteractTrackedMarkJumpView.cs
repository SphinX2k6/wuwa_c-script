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
	// Token: 0x02006A83 RID: 27267
	public class SceneInteractTrackedMarkJumpView : SceneInteractPointViewBase
	{
		// Token: 0x06043C41 RID: 277569 RVA: 0x010961C4 File Offset: 0x010943C4
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

		// Token: 0x06043C42 RID: 277570 RVA: 0x010962B8 File Offset: 0x010944B8
		protected override UniTask OnBeforeStartAsync()
		{
			SceneInteractTrackedMarkJumpView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SceneInteractTrackedMarkJumpView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043C43 RID: 277571 RVA: 0x010962FB File Offset: 0x010944FB
		protected override void OnStart()
		{
			this.AddEvents();
		}

		// Token: 0x06043C44 RID: 277572 RVA: 0x01096303 File Offset: 0x01094503
		protected void AddEvents()
		{
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x06043C45 RID: 277573 RVA: 0x01096321 File Offset: 0x01094521
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x06043C46 RID: 277574 RVA: 0x0109633F File Offset: 0x0109453F
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
			this.KeyItem = null;
		}

		// Token: 0x06043C47 RID: 277575 RVA: 0x0109634E File Offset: 0x0109454E
		private void OnMotorcycleStateChanged(bool bDriving)
		{
			this.RefreshKeyAction();
		}

		// Token: 0x06043C48 RID: 277576 RVA: 0x01096356 File Offset: 0x01094556
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

		// Token: 0x04023677 RID: 145015
		[Nullable(2)]
		private InputMultiKeyItem KeyItem;

		// Token: 0x0200CB8B RID: 52107
		private enum EChildType
		{
			// Token: 0x0403D72E RID: 251694
			PnlPoint,
			// Token: 0x0403D72F RID: 251695
			SprArrow
		}

		// Token: 0x0200CB8C RID: 52108
		private enum EChildTypePc
		{
			// Token: 0x0403D731 RID: 251697
			PnlPoint,
			// Token: 0x0403D732 RID: 251698
			SprArrow,
			// Token: 0x0403D733 RID: 251699
			HotKeyCombine
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006248 RID: 25160
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RhythmShipSetItemBtn : SyncGridProxyAbstract<RhythmShipSetData>
	{
		// Token: 0x0603F63E RID: 259646 RVA: 0x00F532B4 File Offset: 0x00F514B4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUIItem)));
			}
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtn))
			};
		}

		// Token: 0x0603F63F RID: 259647 RVA: 0x00F53358 File Offset: 0x00F51558
		public override void Refresh(RhythmShipSetData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Text, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RhythmShipSetItem_Btn", Array.Empty<object>());
			this.OnClickBtnCallBack = data.BtnCallBack;
		}

		// Token: 0x0603F640 RID: 259648 RVA: 0x00F533A8 File Offset: 0x00F515A8
		private void OnClickBtn()
		{
			Action onClickBtnCallBack = this.OnClickBtnCallBack;
			if (onClickBtnCallBack == null)
			{
				return;
			}
			onClickBtnCallBack();
		}

		// Token: 0x0603F641 RID: 259649 RVA: 0x00F533BC File Offset: 0x00F515BC
		public UUIItem GetBtnItem()
		{
			return base.GetButton(1).RootUIComp.Get();
		}

		// Token: 0x0603F642 RID: 259650 RVA: 0x00F533DD File Offset: 0x00F515DD
		[NullableContext(2)]
		public UUIItem GetNavigationItem()
		{
			if (!Info.Instance.IsInTouch())
			{
				return base.GetItem(7);
			}
			return null;
		}

		// Token: 0x040211B4 RID: 135604
		[Nullable(2)]
		private Action OnClickBtnCallBack;
	}
}

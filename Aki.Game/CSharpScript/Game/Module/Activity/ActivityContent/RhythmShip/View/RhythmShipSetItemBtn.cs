using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051C6 RID: 20934
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RhythmShipSetItemBtn : SyncGridProxyAbstract<RhythmShipSetData>
	{
		// Token: 0x060342FF RID: 213759 RVA: 0x00E9A210 File Offset: 0x00E98410
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

		// Token: 0x06034300 RID: 213760 RVA: 0x00E9A2B4 File Offset: 0x00E984B4
		public override void Refresh(RhythmShipSetData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Text, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RhythmShipSetItem_Btn", Array.Empty<object>());
			this.OnClickBtnCallBack = data.BtnCallBack;
		}

		// Token: 0x06034301 RID: 213761 RVA: 0x00E9A304 File Offset: 0x00E98504
		private void OnClickBtn()
		{
			Action onClickBtnCallBack = this.OnClickBtnCallBack;
			if (onClickBtnCallBack == null)
			{
				return;
			}
			onClickBtnCallBack();
		}

		// Token: 0x06034302 RID: 213762 RVA: 0x00E9A318 File Offset: 0x00E98518
		public UUIItem GetBtnItem()
		{
			return base.GetButton(1).RootUIComp.Get();
		}

		// Token: 0x06034303 RID: 213763 RVA: 0x00E9A339 File Offset: 0x00E98539
		[NullableContext(2)]
		public UUIItem GetNavigationItem()
		{
			if (!Info.Instance.IsInTouch())
			{
				return base.GetItem(7);
			}
			return null;
		}

		// Token: 0x0401BAE3 RID: 113379
		[Nullable(2)]
		private Action OnClickBtnCallBack;
	}
}

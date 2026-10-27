using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Role.Item
{
	// Token: 0x02004BF8 RID: 19448
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleSkinObtainItem : GridProxyAbstract<IGetWayItemData>
	{
		// Token: 0x060324AE RID: 205998 RVA: 0x00BAF724 File Offset: 0x00BAD924
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
			};
		}

		// Token: 0x060324AF RID: 205999 RVA: 0x00BAF7CD File Offset: 0x00BAD9CD
		private void OnClick()
		{
			if (this.Data.Type == EGetWayItemType.CanJump)
			{
				SkipTaskManager.RunByConfigId(this.Data.Id, this.Data.Id);
			}
		}

		// Token: 0x060324B0 RID: 206000 RVA: 0x00BAF800 File Offset: 0x00BADA00
		public override void Refresh(IGetWayItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			bool flag = this.Data.Type == EGetWayItemType.CanJump;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.Data.Text, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.Data.Text, Array.Empty<object>());
		}

		// Token: 0x0401ABF7 RID: 109559
		private IGetWayItemData Data;

		// Token: 0x0200ADF0 RID: 44528
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x04034D4F RID: 216399
			Button,
			// Token: 0x04034D50 RID: 216400
			UnlockItem,
			// Token: 0x04034D51 RID: 216401
			LockItem,
			// Token: 0x04034D52 RID: 216402
			Name,
			// Token: 0x04034D53 RID: 216403
			LockName
		}
	}
}

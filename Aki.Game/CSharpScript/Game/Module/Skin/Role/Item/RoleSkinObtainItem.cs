using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Role.Item
{
	// Token: 0x02003BA9 RID: 15273
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleSkinObtainItem : GridProxyAbstract<IGetWayItemData>
	{
		// Token: 0x06027254 RID: 160340 RVA: 0x00AF3D24 File Offset: 0x00AF1F24
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

		// Token: 0x06027255 RID: 160341 RVA: 0x00AF3DCD File Offset: 0x00AF1FCD
		private void OnClick()
		{
			if (this.Data.Type == EGetWayItemType.CanJump)
			{
				SkipTaskManager.RunByConfigId(this.Data.Id, this.Data.Id);
			}
		}

		// Token: 0x06027256 RID: 160342 RVA: 0x00AF3E00 File Offset: 0x00AF2000
		public override void Refresh(IGetWayItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			bool flag = this.Data.Type == EGetWayItemType.CanJump;
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(flag);
			}
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

		// Token: 0x04015551 RID: 87377
		private IGetWayItemData Data;

		// Token: 0x0200980F RID: 38927
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x0402F6F6 RID: 194294
			Button,
			// Token: 0x0402F6F7 RID: 194295
			UnlockItem,
			// Token: 0x0402F6F8 RID: 194296
			LockItem,
			// Token: 0x0402F6F9 RID: 194297
			Name,
			// Token: 0x0402F6FA RID: 194298
			LockName
		}
	}
}

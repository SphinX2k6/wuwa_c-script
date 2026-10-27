using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02005ADA RID: 23258
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DangoItem : GridProxyAbstract<DangoAbyssDefine.DangoListRoleData>
	{
		// Token: 0x0603AE71 RID: 241265 RVA: 0x00E0B2B0 File Offset: 0x00E094B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603AE72 RID: 241266 RVA: 0x00E0B3DA File Offset: 0x00E095DA
		private void OnToggleClick(EToggleState toggleState)
		{
			this.CurrentData.OnClickCallBack(this.CurrentData);
		}

		// Token: 0x0603AE73 RID: 241267 RVA: 0x00E0B3F4 File Offset: 0x00E095F4
		[NullableContext(1)]
		public override void Refresh(DangoAbyssDefine.DangoListRoleData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			bool flag = this.ViewModel.GetDangoId() == this.CurrentData.Id;
			bool ifLock = data.Data.GetIfLock();
			EToggleState state = flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
			base.GetItem(5).SetUIActive(ifLock);
			base.GetItem(4).SetUIActive(!ifLock);
			base.GetItem(2).SetUIActive(ifLock);
			UUITexture texture = base.GetTexture(1);
			base.SetTextureByPath(data.Data.GetTexture(), texture, null, null);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = ifLock;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			this.BindRedDot();
		}

		// Token: 0x0603AE74 RID: 241268 RVA: 0x00E0B4B0 File Offset: 0x00E096B0
		private void BindRedDot()
		{
			this.UnBindRedDot();
			if (!this.HasBindRedDot && this.CurrentData != null)
			{
				UUIItem item = base.GetItem(3);
				RedDotController.Instance.BindRedDot(ERedDotName.RedDotDangoRole, item, null, this.CurrentData.Id);
			}
		}

		// Token: 0x0603AE75 RID: 241269 RVA: 0x00E0B4F8 File Offset: 0x00E096F8
		private void UnBindRedDot()
		{
			this.HasBindRedDot = false;
			if (this.HasBindRedDot && this.CurrentData != null)
			{
				UUIItem item = base.GetItem(3);
				RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotDangoRole, item, this.CurrentData.Id);
			}
		}

		// Token: 0x0603AE76 RID: 241270 RVA: 0x00E0B53F File Offset: 0x00E0973F
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0401EBDC RID: 125916
		private DangoAbyssDefine.DangoListRoleData CurrentData;

		// Token: 0x0401EBDD RID: 125917
		public PluginEquipViewModel ViewModel;

		// Token: 0x0401EBDE RID: 125918
		private bool HasBindRedDot;

		// Token: 0x0200BD37 RID: 48439
		[NullableContext(0)]
		private class EDangoItemComponent
		{
			// Token: 0x0403910B RID: 233739
			public const int Toggle = 0;

			// Token: 0x0403910C RID: 233740
			public const int Texture = 1;

			// Token: 0x0403910D RID: 233741
			public const int LockItem = 2;

			// Token: 0x0403910E RID: 233742
			public const int ItemRedDot = 3;

			// Token: 0x0403910F RID: 233743
			public const int PanelUnlock = 4;

			// Token: 0x04039110 RID: 233744
			public const int PanelLock = 5;
		}
	}
}

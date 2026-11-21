using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02004AC1 RID: 19137
	[NullableContext(1)]
	[Nullable(0)]
	internal class BuffPanel : UiPanelBase
	{
		// Token: 0x0602FE05 RID: 196101 RVA: 0x00D5C958 File Offset: 0x00D5AB58
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.ButtonClick))
			};
		}

		// Token: 0x0602FE06 RID: 196102 RVA: 0x00D5C9EC File Offset: 0x00D5ABEC
		private void ButtonClick()
		{
			AttrListScrollData[] dangoShowAttributeList = DangoAbyssModel.Instance.GetDangoShowAttributeList(this.CurrentData.GetId());
			UiManager.Instance.OpenView(EUiViewName.DangoAbyssAttributeDetailView, new List<AttrListScrollData>(dangoShowAttributeList), null);
		}

		// Token: 0x0602FE07 RID: 196103 RVA: 0x00D5CA25 File Offset: 0x00D5AC25
		protected override void OnStart()
		{
			this.TagScroller = new GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData>(base.GetMultiTemplateLayout(1), new Func<DangoAbyssTagItem>(this.CreateTagItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0602FE08 RID: 196104 RVA: 0x00D5CA58 File Offset: 0x00D5AC58
		private DangoAbyssTagItem CreateTagItem()
		{
			return new DangoAbyssTagItem();
		}

		// Token: 0x0602FE09 RID: 196105 RVA: 0x00D5CA5F File Offset: 0x00D5AC5F
		public void Refresh(AbyssDangoRoleData data)
		{
			this.CurrentData = data;
			this.RefreshTag(data);
		}

		// Token: 0x0602FE0A RID: 196106 RVA: 0x00D5CA70 File Offset: 0x00D5AC70
		private void RefreshTag(AbyssDangoRoleData data)
		{
			int id = data.GetId();
			List<DangoAbyssDefine.DangoAbyssTagData> list = new List<DangoAbyssDefine.DangoAbyssTagData>(DangoAbyssModel.Instance.GetDangoTagData(id, DangoAbyssDefine.ETagDataGetType.Valid));
			list.Sort((DangoAbyssDefine.DangoAbyssTagData a, DangoAbyssDefine.DangoAbyssTagData b) => b.Value.CompareTo(a.Value));
			GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData> tagScroller = this.TagScroller;
			if (tagScroller == null)
			{
				return;
			}
			tagScroller.RefreshByData(list, null, false);
		}

		// Token: 0x040196B1 RID: 104113
		[Nullable(2)]
		private AbyssDangoRoleData CurrentData;

		// Token: 0x040196B2 RID: 104114
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData> TagScroller;
	}
}

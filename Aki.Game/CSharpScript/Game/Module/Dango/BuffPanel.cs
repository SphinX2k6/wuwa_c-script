using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02005AE0 RID: 23264
	[NullableContext(1)]
	[Nullable(0)]
	internal class BuffPanel : UiPanelBase
	{
		// Token: 0x0603AE93 RID: 241299 RVA: 0x00E0BC70 File Offset: 0x00E09E70
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

		// Token: 0x0603AE94 RID: 241300 RVA: 0x00E0BD04 File Offset: 0x00E09F04
		private void ButtonClick()
		{
			AttrListScrollData[] dangoShowAttributeList = DangoAbyssModel.Instance.GetDangoShowAttributeList(this.CurrentData.GetId());
			UiManager.Instance.OpenView(EUiViewName.DangoAbyssAttributeDetailView, dangoShowAttributeList.ToList<AttrListScrollData>(), null);
		}

		// Token: 0x0603AE95 RID: 241301 RVA: 0x00E0BD3D File Offset: 0x00E09F3D
		protected override void OnStart()
		{
			this.TagScroller = new GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData>(base.GetMultiTemplateLayout(1), new Func<DangoAbyssTagItem>(this.CreateTagItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603AE96 RID: 241302 RVA: 0x00E0BD70 File Offset: 0x00E09F70
		private DangoAbyssTagItem CreateTagItem()
		{
			return new DangoAbyssTagItem();
		}

		// Token: 0x0603AE97 RID: 241303 RVA: 0x00E0BD77 File Offset: 0x00E09F77
		public void Refresh(AbyssDangoRoleData data)
		{
			this.CurrentData = data;
			this.RefreshTag(data);
		}

		// Token: 0x0603AE98 RID: 241304 RVA: 0x00E0BD88 File Offset: 0x00E09F88
		private void RefreshTag(AbyssDangoRoleData data)
		{
			int id = data.GetId();
			List<DangoAbyssDefine.DangoAbyssTagData> list = DangoAbyssModel.Instance.GetDangoTagData(id, DangoAbyssDefine.ETagDataGetType.Valid).ToList<DangoAbyssDefine.DangoAbyssTagData>();
			list.Sort((DangoAbyssDefine.DangoAbyssTagData a, DangoAbyssDefine.DangoAbyssTagData b) => b.Value.CompareTo(a.Value));
			GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData> tagScroller = this.TagScroller;
			if (tagScroller == null)
			{
				return;
			}
			tagScroller.RefreshByData(list, null, false);
		}

		// Token: 0x0401EBF5 RID: 125941
		[Nullable(2)]
		private AbyssDangoRoleData CurrentData;

		// Token: 0x0401EBF6 RID: 125942
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData> TagScroller;
	}
}

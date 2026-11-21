using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059C5 RID: 22981
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolJumpAccessItem : GridProxyAbstract<SolarSchoolJumpAccessItemData>
	{
		// Token: 0x17006C43 RID: 27715
		// (get) Token: 0x06038A44 RID: 232004 RVA: 0x00FD9814 File Offset: 0x00FD7A14
		// (set) Token: 0x06038A45 RID: 232005 RVA: 0x00FD981C File Offset: 0x00FD7A1C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SolarSchoolJumpAccessItemData> ClickCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x06038A46 RID: 232006 RVA: 0x00FD9828 File Offset: 0x00FD7A28
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnJumpClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038A47 RID: 232007 RVA: 0x00FD9A1C File Offset: 0x00FD7C1C
		public override void Refresh(SolarSchoolJumpAccessItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetItem(0).SetUIActive(false);
			base.GetItem(1).SetUIActive(false);
			base.GetItem(2).SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
			base.GetText(6).SetUIActive(false);
			base.GetItem(11).SetUIActive(false);
			UUIText text = base.GetText(5);
			text.SetUIActive(true);
			if (StringUtils.IsEmpty(data.TextParam))
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.TextId, Array.Empty<object>());
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.TextId, new <>z__ReadOnlySingleElementList<object>(new TableTextArgNew(data.TextParam, Array.Empty<object>())));
			}
			base.GetButton(7).RootUIComp.Get().SetUIActive(true);
			base.GetButton(10).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06038A48 RID: 232008 RVA: 0x00FD9B29 File Offset: 0x00FD7D29
		public override void Clear()
		{
			this.Data = null;
		}

		// Token: 0x06038A49 RID: 232009 RVA: 0x00FD9B32 File Offset: 0x00FD7D32
		public override object GetKey(SolarSchoolJumpAccessItemData data, int displayIndex)
		{
			return (int)data.Info.Access;
		}

		// Token: 0x06038A4A RID: 232010 RVA: 0x00FD9B44 File Offset: 0x00FD7D44
		private void OnJumpClick()
		{
			if (this.Data == null)
			{
				return;
			}
			Action<SolarSchoolJumpAccessItemData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Data);
		}

		// Token: 0x0401DD38 RID: 122168
		[Nullable(2)]
		private SolarSchoolJumpAccessItemData Data;

		// Token: 0x0200B576 RID: 46454
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040381C0 RID: 229824
			public const int PnlDone = 0;

			// Token: 0x040381C1 RID: 229825
			public const int PnlPreQuest = 1;

			// Token: 0x040381C2 RID: 229826
			public const int PnlOther = 2;

			// Token: 0x040381C3 RID: 229827
			public const int SprFrame = 3;

			// Token: 0x040381C4 RID: 229828
			public const int TexIcon = 4;

			// Token: 0x040381C5 RID: 229829
			public const int TxtTitle = 5;

			// Token: 0x040381C6 RID: 229830
			public const int TxtContent = 6;

			// Token: 0x040381C7 RID: 229831
			public const int BtnGoto = 7;

			// Token: 0x040381C8 RID: 229832
			public const int SprDone = 8;

			// Token: 0x040381C9 RID: 229833
			public const int TxtUnDone = 9;

			// Token: 0x040381CA RID: 229834
			public const int BtnHelp = 10;

			// Token: 0x040381CB RID: 229835
			public const int PnlItem = 11;
		}
	}
}

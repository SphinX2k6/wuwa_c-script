using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004ABF RID: 19135
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMonsterDescPanel : UiPanelBase
	{
		// Token: 0x06031924 RID: 203044 RVA: 0x00B7EB24 File Offset: 0x00B7CD24
		public UniTask Init(UUIItem item)
		{
			TrapDefenseMonsterDescPanel.<Init>d__5 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseMonsterDescPanel.<Init>d__5>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06031925 RID: 203045 RVA: 0x00B7EB6F File Offset: 0x00B7CD6F
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x06031926 RID: 203046 RVA: 0x00B7EB74 File Offset: 0x00B7CD74
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031927 RID: 203047 RVA: 0x00B7ECC8 File Offset: 0x00B7CEC8
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMonsterDescPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMonsterDescPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031928 RID: 203048 RVA: 0x00B7ED0B File Offset: 0x00B7CF0B
		protected override void OnStart()
		{
		}

		// Token: 0x06031929 RID: 203049 RVA: 0x00B7ED0D File Offset: 0x00B7CF0D
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0603192A RID: 203050 RVA: 0x00B7ED0F File Offset: 0x00B7CF0F
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603192B RID: 203051 RVA: 0x00B7ED14 File Offset: 0x00B7CF14
		public void UpdateData(TrapDefenseMonsterData data)
		{
			this.ItemData = data;
			UUITexture texture = base.GetTexture(0);
			base.SetTextureByPath(data.IconPath, texture, null, null);
			UUITexture texture2 = base.GetTexture(1);
			base.SetTextureByPath(data.GetQualityPathDesc(), texture2, null, null);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.ShowTextNew(data.NameKey);
			}
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.ShowTextNew(data.GetRiskTypeNameKey());
			}
			UUIText text3 = base.GetText(4);
			if (text3 != null)
			{
				text3.ShowTextNew(data.GetBodyTypeNameKey());
			}
			this.UpdateAttrShow();
		}

		// Token: 0x0603192C RID: 203052 RVA: 0x00B7EDB4 File Offset: 0x00B7CFB4
		public void UpdateAttrShow()
		{
			List<ITrapDefenseAttrItemData> attrDataShowList = this.ItemData.GetAttrDataShowList();
			List<ITrapDefenseAttrItemData> tagDataShowList = this.ItemData.GetTagDataShowList();
			UUILayoutBase layoutBase = base.GetLayoutBase(5);
			if (layoutBase != null)
			{
				layoutBase.RootUIComp.Get().SetUIActive(attrDataShowList.Count > 0);
			}
			if (attrDataShowList.Count > 0)
			{
				this.LayoutAttr.RefreshByData(attrDataShowList, null, false);
			}
			UUILayoutBase layoutBase2 = base.GetLayoutBase(7);
			if (layoutBase2 != null)
			{
				layoutBase2.RootUIComp.Get().SetUIActive(tagDataShowList.Count > 0);
			}
			if (tagDataShowList.Count > 0)
			{
				this.LayoutTag.RefreshByData(tagDataShowList, null, false);
			}
		}

		// Token: 0x0603192D RID: 203053 RVA: 0x00B7EE57 File Offset: 0x00B7D057
		public TrapDefenseAttrItem CreateItemAttr()
		{
			return new TrapDefenseAttrItem();
		}

		// Token: 0x0603192E RID: 203054 RVA: 0x00B7EE5E File Offset: 0x00B7D05E
		public TrapDefenseTagAttrItem CreateItemTag()
		{
			return new TrapDefenseTagAttrItem();
		}

		// Token: 0x0401A7C8 RID: 108488
		public TrapDefenseMonsterData ItemData;

		// Token: 0x0401A7C9 RID: 108489
		public TrapDefenseMonsterViewModel ViewModel = TrapDefenseModel.Instance.ViewModelMonster;

		// Token: 0x0401A7CA RID: 108490
		public GenericLayout<TrapDefenseAttrItem, ITrapDefenseAttrItemData> LayoutAttr;

		// Token: 0x0401A7CB RID: 108491
		public GenericLayout<TrapDefenseTagAttrItem, ITrapDefenseAttrItemData> LayoutTag;

		// Token: 0x0200AC24 RID: 44068
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040344EC RID: 214252
			public const int TextureIcon = 0;

			// Token: 0x040344ED RID: 214253
			public const int TextureQuality = 1;

			// Token: 0x040344EE RID: 214254
			public const int TextName = 2;

			// Token: 0x040344EF RID: 214255
			public const int TextRiskType = 3;

			// Token: 0x040344F0 RID: 214256
			public const int TextBodyType = 4;

			// Token: 0x040344F1 RID: 214257
			public const int LayoutAttr = 5;

			// Token: 0x040344F2 RID: 214258
			public const int ItemAttr = 6;

			// Token: 0x040344F3 RID: 214259
			public const int LayoutTag = 7;

			// Token: 0x040344F4 RID: 214260
			public const int ItemTag = 8;
		}
	}
}

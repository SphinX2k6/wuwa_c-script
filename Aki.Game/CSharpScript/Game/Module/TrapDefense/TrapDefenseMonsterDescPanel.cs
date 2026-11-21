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
	// Token: 0x02003A67 RID: 14951
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMonsterDescPanel : UiPanelBase
	{
		// Token: 0x060266B4 RID: 157364 RVA: 0x00AC2AD8 File Offset: 0x00AC0CD8
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

		// Token: 0x060266B5 RID: 157365 RVA: 0x00AC2B23 File Offset: 0x00AC0D23
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x060266B6 RID: 157366 RVA: 0x00AC2B28 File Offset: 0x00AC0D28
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

		// Token: 0x060266B7 RID: 157367 RVA: 0x00AC2C7C File Offset: 0x00AC0E7C
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMonsterDescPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMonsterDescPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060266B8 RID: 157368 RVA: 0x00AC2CBF File Offset: 0x00AC0EBF
		protected override void OnStart()
		{
		}

		// Token: 0x060266B9 RID: 157369 RVA: 0x00AC2CC1 File Offset: 0x00AC0EC1
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x060266BA RID: 157370 RVA: 0x00AC2CC3 File Offset: 0x00AC0EC3
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060266BB RID: 157371 RVA: 0x00AC2CC8 File Offset: 0x00AC0EC8
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

		// Token: 0x060266BC RID: 157372 RVA: 0x00AC2D68 File Offset: 0x00AC0F68
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

		// Token: 0x060266BD RID: 157373 RVA: 0x00AC2E0B File Offset: 0x00AC100B
		public TrapDefenseAttrItem CreateItemAttr()
		{
			return new TrapDefenseAttrItem();
		}

		// Token: 0x060266BE RID: 157374 RVA: 0x00AC2E12 File Offset: 0x00AC1012
		public TrapDefenseTagAttrItem CreateItemTag()
		{
			return new TrapDefenseTagAttrItem();
		}

		// Token: 0x0401511A RID: 86298
		public TrapDefenseMonsterData ItemData;

		// Token: 0x0401511B RID: 86299
		public TrapDefenseMonsterViewModel ViewModel = TrapDefenseModel.Instance.ViewModelMonster;

		// Token: 0x0401511C RID: 86300
		public GenericLayout<TrapDefenseAttrItem, ITrapDefenseAttrItemData> LayoutAttr;

		// Token: 0x0401511D RID: 86301
		public GenericLayout<TrapDefenseTagAttrItem, ITrapDefenseAttrItemData> LayoutTag;

		// Token: 0x02009644 RID: 38468
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EE9D RID: 192157
			public const int TextureIcon = 0;

			// Token: 0x0402EE9E RID: 192158
			public const int TextureQuality = 1;

			// Token: 0x0402EE9F RID: 192159
			public const int TextName = 2;

			// Token: 0x0402EEA0 RID: 192160
			public const int TextRiskType = 3;

			// Token: 0x0402EEA1 RID: 192161
			public const int TextBodyType = 4;

			// Token: 0x0402EEA2 RID: 192162
			public const int LayoutAttr = 5;

			// Token: 0x0402EEA3 RID: 192163
			public const int ItemAttr = 6;

			// Token: 0x0402EEA4 RID: 192164
			public const int LayoutTag = 7;

			// Token: 0x0402EEA5 RID: 192165
			public const int ItemTag = 8;
		}
	}
}

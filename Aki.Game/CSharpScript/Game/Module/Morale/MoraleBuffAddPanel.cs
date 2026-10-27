using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053A9 RID: 21417
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffAddPanel : UiPanelBase
	{
		// Token: 0x06036B9F RID: 224159 RVA: 0x00CF3A74 File Offset: 0x00CF1C74
		public UniTask Init(UUIItem item)
		{
			MoraleBuffAddPanel.<Init>d__4 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleBuffAddPanel.<Init>d__4>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06036BA0 RID: 224160 RVA: 0x00CF3AC0 File Offset: 0x00CF1CC0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnMask))
			};
		}

		// Token: 0x06036BA1 RID: 224161 RVA: 0x00CF3BC4 File Offset: 0x00CF1DC4
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleBuffAddPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleBuffAddPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036BA2 RID: 224162 RVA: 0x00CF3C07 File Offset: 0x00CF1E07
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x06036BA3 RID: 224163 RVA: 0x00CF3C0F File Offset: 0x00CF1E0F
		protected override void OnBeforeDestroy()
		{
			if (base.GetActive())
			{
				Action closeCallback = this.CloseCallback;
				if (closeCallback == null)
				{
					return;
				}
				closeCallback();
			}
		}

		// Token: 0x06036BA4 RID: 224164 RVA: 0x00CF3C29 File Offset: 0x00CF1E29
		private void OnBtnMask()
		{
			this.SetActive(false);
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x06036BA5 RID: 224165 RVA: 0x00CF3C42 File Offset: 0x00CF1E42
		private MoraleBuffAddItem CreateItem()
		{
			return new MoraleBuffAddItem();
		}

		// Token: 0x06036BA6 RID: 224166 RVA: 0x00CF3C49 File Offset: 0x00CF1E49
		private MoraleBuffAddAreaItem CreateAreaItem()
		{
			return new MoraleBuffAddAreaItem();
		}

		// Token: 0x06036BA7 RID: 224167 RVA: 0x00CF3C50 File Offset: 0x00CF1E50
		public void UpdateData()
		{
			this.UpdateTitle();
			this.UpdateLvAddDesc();
			this.UpdateList();
			this.UpdateAreaList();
		}

		// Token: 0x06036BA8 RID: 224168 RVA: 0x00CF3C6C File Offset: 0x00CF1E6C
		public void UpdateTitle()
		{
			string key = "Morale_title_22";
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.ShowTextNew(key);
			}
			string key2 = "Morale_title_38";
			UUIText text2 = base.GetText(8);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew(key2);
		}

		// Token: 0x06036BA9 RID: 224169 RVA: 0x00CF3CAC File Offset: 0x00CF1EAC
		public void UpdateList()
		{
			List<IMoraleBuffAddItemData> allRoleAttrAddList = MoraleModel.Instance.GetAllRoleAttrAddList();
			this.ItemLayout.RefreshByData(allRoleAttrAddList, null, false);
		}

		// Token: 0x06036BAA RID: 224170 RVA: 0x00CF3CD4 File Offset: 0x00CF1ED4
		public void UpdateAreaList()
		{
			List<MoraleAreaData> areaDataList = MoraleModel.Instance.AreaDataList;
			this.AreaBuffLayout.RefreshByData(areaDataList, null, false);
		}

		// Token: 0x06036BAB RID: 224171 RVA: 0x00CF3CFC File Offset: 0x00CF1EFC
		public void UpdateLvAddDesc()
		{
			int moraleLevel = MoraleBattleModel.Instance.GetMoraleLevel();
			MoraleBattleConfig instance = MoraleBattleConfig.Instance;
			MoraleKeepLevel? moraleKeepLevel = (instance != null) ? instance.GetExpConfig(moraleLevel) : null;
			if (moraleKeepLevel == null)
			{
				return;
			}
			base.GetText(5).ShowTextNew(moraleKeepLevel.Value.LvAddDesc);
		}

		// Token: 0x0401CE57 RID: 118359
		public GenericLayout<MoraleBuffAddItem, IMoraleBuffAddItemData> ItemLayout;

		// Token: 0x0401CE58 RID: 118360
		public GenericLayout<MoraleBuffAddAreaItem, MoraleAreaData> AreaBuffLayout;

		// Token: 0x0401CE59 RID: 118361
		[Nullable(2)]
		public Action CloseCallback;

		// Token: 0x0200B639 RID: 46649
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04037330 RID: 226096
			public const int BtnMask = 0;

			// Token: 0x04037331 RID: 226097
			public const int LayoutContainer = 1;

			// Token: 0x04037332 RID: 226098
			public const int ItemInfoTemplate = 2;

			// Token: 0x04037333 RID: 226099
			public const int ItemRoot = 3;

			// Token: 0x04037334 RID: 226100
			public const int TextTitle = 4;

			// Token: 0x04037335 RID: 226101
			public const int TextSubTitle = 5;

			// Token: 0x04037336 RID: 226102
			public const int LayoutAreaBuffRoot = 6;

			// Token: 0x04037337 RID: 226103
			public const int ItemAreaBuffTemplate = 7;

			// Token: 0x04037338 RID: 226104
			public const int TextAreaTitle = 8;
		}
	}
}

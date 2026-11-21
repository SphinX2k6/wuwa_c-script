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
	// Token: 0x0200438C RID: 17292
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffAddPanel : UiPanelBase
	{
		// Token: 0x0602BAE5 RID: 178917 RVA: 0x00C42B1C File Offset: 0x00C40D1C
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

		// Token: 0x0602BAE6 RID: 178918 RVA: 0x00C42B68 File Offset: 0x00C40D68
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

		// Token: 0x0602BAE7 RID: 178919 RVA: 0x00C42C6C File Offset: 0x00C40E6C
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleBuffAddPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleBuffAddPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAE8 RID: 178920 RVA: 0x00C42CAF File Offset: 0x00C40EAF
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x0602BAE9 RID: 178921 RVA: 0x00C42CB7 File Offset: 0x00C40EB7
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

		// Token: 0x0602BAEA RID: 178922 RVA: 0x00C42CD1 File Offset: 0x00C40ED1
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

		// Token: 0x0602BAEB RID: 178923 RVA: 0x00C42CEA File Offset: 0x00C40EEA
		private MoraleBuffAddItem CreateItem()
		{
			return new MoraleBuffAddItem();
		}

		// Token: 0x0602BAEC RID: 178924 RVA: 0x00C42CF1 File Offset: 0x00C40EF1
		private MoraleBuffAddAreaItem CreateAreaItem()
		{
			return new MoraleBuffAddAreaItem();
		}

		// Token: 0x0602BAED RID: 178925 RVA: 0x00C42CF8 File Offset: 0x00C40EF8
		public void UpdateData()
		{
			this.UpdateTitle();
			this.UpdateLvAddDesc();
			this.UpdateList();
			this.UpdateAreaList();
		}

		// Token: 0x0602BAEE RID: 178926 RVA: 0x00C42D14 File Offset: 0x00C40F14
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

		// Token: 0x0602BAEF RID: 178927 RVA: 0x00C42D54 File Offset: 0x00C40F54
		public void UpdateList()
		{
			List<IMoraleBuffAddItemData> allRoleAttrAddList = MoraleModel.Instance.GetAllRoleAttrAddList();
			this.ItemLayout.RefreshByData(allRoleAttrAddList, null, false);
		}

		// Token: 0x0602BAF0 RID: 178928 RVA: 0x00C42D7C File Offset: 0x00C40F7C
		public void UpdateAreaList()
		{
			List<MoraleAreaData> areaDataList = MoraleModel.Instance.AreaDataList;
			this.AreaBuffLayout.RefreshByData(areaDataList, null, false);
		}

		// Token: 0x0602BAF1 RID: 178929 RVA: 0x00C42DA4 File Offset: 0x00C40FA4
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

		// Token: 0x040178EF RID: 96495
		public GenericLayout<MoraleBuffAddItem, IMoraleBuffAddItemData> ItemLayout;

		// Token: 0x040178F0 RID: 96496
		public GenericLayout<MoraleBuffAddAreaItem, MoraleAreaData> AreaBuffLayout;

		// Token: 0x040178F1 RID: 96497
		[Nullable(2)]
		public Action CloseCallback;

		// Token: 0x0200A071 RID: 41073
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031D85 RID: 204165
			public const int BtnMask = 0;

			// Token: 0x04031D86 RID: 204166
			public const int LayoutContainer = 1;

			// Token: 0x04031D87 RID: 204167
			public const int ItemInfoTemplate = 2;

			// Token: 0x04031D88 RID: 204168
			public const int ItemRoot = 3;

			// Token: 0x04031D89 RID: 204169
			public const int TextTitle = 4;

			// Token: 0x04031D8A RID: 204170
			public const int TextSubTitle = 5;

			// Token: 0x04031D8B RID: 204171
			public const int LayoutAreaBuffRoot = 6;

			// Token: 0x04031D8C RID: 204172
			public const int ItemAreaBuffTemplate = 7;

			// Token: 0x04031D8D RID: 204173
			public const int TextAreaTitle = 8;
		}
	}
}

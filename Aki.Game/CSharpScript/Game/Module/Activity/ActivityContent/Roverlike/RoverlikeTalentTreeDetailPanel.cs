using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020061A3 RID: 24995
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeTalentTreeDetailPanel : UiPanelBase
	{
		// Token: 0x17009206 RID: 37382
		// (get) Token: 0x0603F207 RID: 258567 RVA: 0x00F3F488 File Offset: 0x00F3D688
		private RoverlikeTalentTreeData TreeData
		{
			get
			{
				RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
				if (currentActivityData == null)
				{
					return null;
				}
				return currentActivityData.TalentTreeData;
			}
		}

		// Token: 0x0603F208 RID: 258568 RVA: 0x00F3F4A0 File Offset: 0x00F3D6A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickBtnUpgrade));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F209 RID: 258569 RVA: 0x00F3F740 File Offset: 0x00F3D940
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeTalentTreeDetailPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeTalentTreeDetailPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F20A RID: 258570 RVA: 0x00F3F784 File Offset: 0x00F3D984
		[NullableContext(1)]
		public void Refresh(RoverlikeTalentNodeData data)
		{
			this.Data = data;
			RoverlikeTalentTreeData treeData = this.TreeData;
			if (treeData == null)
			{
				return;
			}
			RoverRogueTalentTree headConfig = data.HeadConfig;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), headConfig.Name, Array.Empty<object>());
			UUIText text = base.GetText(14);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.CurLevel);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.MaxLevel);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			int column = headConfig.Column;
			string textStringId;
			string hexStr;
			if (column <= 2)
			{
				textStringId = "RoverRogue_TalentTree_TypeLeft";
				hexStr = "57a2b6";
			}
			else if (column <= 4)
			{
				textStringId = "RoverRogue_TalentTree_TypeMiddle";
				hexStr = "bd655c";
			}
			else
			{
				textStringId = "RoverRogue_TalentTree_TypeRight";
				hexStr = "5d4ac0";
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(16), textStringId, Array.Empty<object>());
			UUISprite sprite = base.GetSprite(15);
			if (sprite != null)
			{
				sprite.SetColor(FColor.FromHex(hexStr));
			}
			RoverRogueTalentTree? roverRogueTalentTree;
			string text2 = ((data.CurrentLevelConfig != null) ? roverRogueTalentTree.GetValueOrDefault().Icon : null) ?? headConfig.Icon;
			bool flag = text2.Contains("Atlas");
			UUITexture texture = base.GetTexture(13);
			texture.SetUIActive(!flag);
			UUISprite sprite2 = base.GetSprite(1);
			sprite2.SetUIActive(flag);
			if (flag)
			{
				this.SetSpriteByPath(text2, sprite2, false, null, null);
			}
			else
			{
				base.SetTextureByPath(text2, texture, null, null);
			}
			bool flag2 = data.CurLevel > 0;
			base.GetItem(2).SetUIActive(flag2);
			if (flag2)
			{
				RoverlikeTalentTreeLevelDescItem curLevelItem = this.CurLevelItem;
				if (curLevelItem != null)
				{
					curLevelItem.SetContent(data.CurLevel, data.CurrentDescTextId, data.CurrentDescParams);
				}
			}
			bool flag3 = !data.IsMaxLevel;
			base.GetItem(3).SetUIActive(flag3);
			if (flag3)
			{
				RoverlikeTalentTreeLevelDescItem nextLevelItem = this.NextLevelItem;
				if (nextLevelItem != null)
				{
					nextLevelItem.SetTitle((data.CurLevel > 0) ? "PrefabTextItem_124464148_Text" : "RoverRogue_TalentTreeUnlockShow");
				}
				RoverlikeTalentTreeLevelDescItem nextLevelItem2 = this.NextLevelItem;
				if (nextLevelItem2 != null)
				{
					nextLevelItem2.SetContent(data.CurLevel + 1, data.NextLevelDescTextId, data.NextLevelDescParams);
				}
			}
			int nextLevelCost = data.NextLevelCost;
			bool flag4 = treeData.GetTalentCoinNum() >= nextLevelCost;
			UUIText text3 = base.GetText(4);
			text3.SetText(nextLevelCost.ToString(), true);
			UUIItem uuiitem = text3;
			bool bUseChangeColor = !flag4;
			FColor? fcolor = new FColor?(text3.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.SetItemIcon(base.GetTexture(8), treeData.TalentPointItemId, null, null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), "RoverRogue_TalentTree_Activate", Array.Empty<object>());
			this.RefreshStatePanels(data, treeData);
		}

		// Token: 0x0603F20B RID: 258571 RVA: 0x00F3FA4C File Offset: 0x00F3DC4C
		[NullableContext(1)]
		private void RefreshStatePanels(RoverlikeTalentNodeData data, RoverlikeTalentTreeData treeData)
		{
			ERoverlikeTalentNodeState state = data.State;
			bool isServerUnlocked = data.IsServerUnlocked;
			if (state == ERoverlikeTalentNodeState.Lock && !isServerUnlocked)
			{
				this.SetCostActive(false);
				UUIItem uuiitem = base.GetButton(5).RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
				base.GetItem(10).SetUIActive(true);
				base.GetItem(9).SetUIActive(false);
				return;
			}
			if (state == ERoverlikeTalentNodeState.Lock)
			{
				this.SetCostActive(true);
				UUIItem uuiitem2 = base.GetButton(5).RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(true);
				}
				base.GetItem(10).SetUIActive(false);
				base.GetItem(9).SetUIActive(false);
				return;
			}
			if (state == ERoverlikeTalentNodeState.Unlock)
			{
				this.SetCostActive(true);
				UUIItem uuiitem3 = base.GetButton(5).RootUIComp.Get();
				if (uuiitem3 != null)
				{
					uuiitem3.SetUIActive(true);
				}
				base.GetItem(10).SetUIActive(false);
				base.GetItem(9).SetUIActive(false);
				return;
			}
			this.SetCostActive(false);
			UUIItem uuiitem4 = base.GetButton(5).RootUIComp.Get();
			if (uuiitem4 != null)
			{
				uuiitem4.SetUIActive(false);
			}
			base.GetItem(10).SetUIActive(false);
			base.GetItem(9).SetUIActive(true);
		}

		// Token: 0x0603F20C RID: 258572 RVA: 0x00F3FB83 File Offset: 0x00F3DD83
		private void SetCostActive(bool isActive)
		{
			base.GetItem(12).SetUIActive(isActive);
			base.GetItem(7).SetUIActive(isActive);
		}

		// Token: 0x0603F20D RID: 258573 RVA: 0x00F3FBA0 File Offset: 0x00F3DDA0
		private void OnClickBtnUpgrade()
		{
			RoverlikeTalentNodeData data = this.Data;
			RoverlikeTalentTreeData treeData = this.TreeData;
			if (data == null || treeData == null)
			{
				return;
			}
			if (!treeData.IsTalentCanUnlock(data))
			{
				if (data.IsServerUnlocked && !data.IsMaxLevel && treeData.GetTalentCoinNum() < data.NextLevelCost)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("RoverRogue_InsufficientTalent", Array.Empty<object>());
				}
				return;
			}
			string nextDescTextId = data.NextLevelDescTextId;
			List<string> nextDescParams = data.NextLevelDescParams;
			RoverlikeController.Instance.RequestUnlockTalentNode(data.HeadConfig.Id, delegate
			{
				this.Refresh(data);
				Action<RoverlikeTalentNodeData> onUnlockSuccess = this.OnUnlockSuccess;
				if (onUnlockSuccess != null)
				{
					onUnlockSuccess(data);
				}
				RoverlikeTalentUnlockViewParam param = new RoverlikeTalentUnlockViewParam
				{
					DescTextId = nextDescTextId,
					DescParams = new List<string>(nextDescParams)
				};
				UiManager.Instance.OpenView(EUiViewName.RoverlikeTalentTreeUnlockView, param, null);
			});
		}

		// Token: 0x04020E99 RID: 134809
		private RoverlikeTalentNodeData Data;

		// Token: 0x04020E9A RID: 134810
		private RoverlikeTalentTreeLevelDescItem CurLevelItem;

		// Token: 0x04020E9B RID: 134811
		private RoverlikeTalentTreeLevelDescItem NextLevelItem;

		// Token: 0x04020E9C RID: 134812
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoverlikeTalentNodeData> OnUnlockSuccess;

		// Token: 0x0200C3ED RID: 50157
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403B1F2 RID: 242162
			public const int TxtName = 0;

			// Token: 0x0403B1F3 RID: 242163
			public const int SprIcon = 1;

			// Token: 0x0403B1F4 RID: 242164
			public const int PnlCurLevel = 2;

			// Token: 0x0403B1F5 RID: 242165
			public const int PnlNextLevel = 3;

			// Token: 0x0403B1F6 RID: 242166
			public const int TxtCost = 4;

			// Token: 0x0403B1F7 RID: 242167
			public const int BtnUpgrade = 5;

			// Token: 0x0403B1F8 RID: 242168
			public const int TxtConfirm = 6;

			// Token: 0x0403B1F9 RID: 242169
			public const int PnlCostNor = 7;

			// Token: 0x0403B1FA RID: 242170
			public const int TexCostIcon = 8;

			// Token: 0x0403B1FB RID: 242171
			public const int PnlMaxLevel = 9;

			// Token: 0x0403B1FC RID: 242172
			public const int PnlActivateCondition = 10;

			// Token: 0x0403B1FD RID: 242173
			public const int TxtActivateCondition = 11;

			// Token: 0x0403B1FE RID: 242174
			public const int PnlCost = 12;

			// Token: 0x0403B1FF RID: 242175
			public const int TexIcon = 13;

			// Token: 0x0403B200 RID: 242176
			public const int TxtNameLevel = 14;

			// Token: 0x0403B201 RID: 242177
			public const int SprType = 15;

			// Token: 0x0403B202 RID: 242178
			public const int TxtType = 16;
		}
	}
}

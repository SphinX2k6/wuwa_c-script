using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x02005849 RID: 22601
	public class BossRushBuffSelectInGameItem : UiPanelBase
	{
		// Token: 0x06037BB1 RID: 228273 RVA: 0x00F94888 File Offset: 0x00F92A88
		public void SetClickCallBack([Nullable(new byte[]
		{
			1,
			2
		})] Action<BossRushBuffSelectInGameItem> callback)
		{
			this.ClickCallBack = callback;
		}

		// Token: 0x06037BB2 RID: 228274 RVA: 0x00F94894 File Offset: 0x00F92A94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.SelfToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06037BB3 RID: 228275 RVA: 0x00F94A68 File Offset: 0x00F92C68
		protected override void OnStart()
		{
			base.GetHorizontalLayout(3).RootUIComp.Get().SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetSprite(7).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
			base.GetItem(10).SetUIActive(false);
		}

		// Token: 0x06037BB4 RID: 228276 RVA: 0x00F94AD4 File Offset: 0x00F92CD4
		public void RefreshItem(int buffId)
		{
			BossRushConfig instance = BossRushConfig.Instance;
			BossRushBuff? bossRushBuff = (instance != null) ? instance.GetBossRushBuffConfigById(buffId) : null;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), bossRushBuff.Value.Name, Array.Empty<object>());
			List<string> list = new List<string>();
			foreach (string input in bossRushBuff.Value.DescriptionParamIter())
			{
				Match match = BossRushBuffSelectInGameItem.regex.Match(input);
				if (match.Success && match.Groups.Count > 1)
				{
					list.AddRange(match.Groups[1].Value.Split(',', StringSplitOptions.None));
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), bossRushBuff.Value.Description, list.ToArray());
			base.SetTextureByPath(bossRushBuff.Value.Texture, base.GetTexture(1), null, null);
		}

		// Token: 0x06037BB5 RID: 228277 RVA: 0x00F94C04 File Offset: 0x00F92E04
		private void SelfToggle(EToggleState state)
		{
			Action<BossRushBuffSelectInGameItem> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack((state == EToggleState.ETT_Checked) ? this : null);
		}

		// Token: 0x06037BB6 RID: 228278 RVA: 0x00F94C1E File Offset: 0x00F92E1E
		public void SetToggleUnCheck()
		{
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401D696 RID: 120470
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public Action<BossRushBuffSelectInGameItem> ClickCallBack;

		// Token: 0x0401D697 RID: 120471
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static Regex regex = new Regex("\\[(.*?)\\]");

		// Token: 0x0200B474 RID: 46196
		private class EComponent
		{
			// Token: 0x04037CE7 RID: 228583
			public const int QualityBgTexture = 0;

			// Token: 0x04037CE8 RID: 228584
			public const int IconTexture = 1;

			// Token: 0x04037CE9 RID: 228585
			public const int NameText = 2;

			// Token: 0x04037CEA RID: 228586
			public const int ElementLayout = 3;

			// Token: 0x04037CEB RID: 228587
			public const int DescText = 4;

			// Token: 0x04037CEC RID: 228588
			public const int SelfToggle = 5;

			// Token: 0x04037CED RID: 228589
			public const int NewItem = 6;

			// Token: 0x04037CEE RID: 228590
			public const int QualityLineSprite = 7;

			// Token: 0x04037CEF RID: 228591
			public const int GoldItem = 8;

			// Token: 0x04037CF0 RID: 228592
			public const int YellowItem = 9;

			// Token: 0x04037CF1 RID: 228593
			public const int ButtonItem = 10;
		}
	}
}

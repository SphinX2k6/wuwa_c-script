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
	// Token: 0x020068F9 RID: 26873
	public class BossRushBuffSelectInGameItem : UiPanelBase
	{
		// Token: 0x06043059 RID: 274521 RVA: 0x01053260 File Offset: 0x01051460
		public void SetClickCallBack([Nullable(new byte[]
		{
			1,
			2
		})] Action<BossRushBuffSelectInGameItem> callback)
		{
			this.ClickCallBack = callback;
		}

		// Token: 0x0604305A RID: 274522 RVA: 0x0105326C File Offset: 0x0105146C
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

		// Token: 0x0604305B RID: 274523 RVA: 0x01053440 File Offset: 0x01051640
		protected override void OnStart()
		{
			base.GetHorizontalLayout(3).RootUIComp.Get().SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetSprite(7).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
			base.GetItem(10).SetUIActive(false);
		}

		// Token: 0x0604305C RID: 274524 RVA: 0x010534AC File Offset: 0x010516AC
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

		// Token: 0x0604305D RID: 274525 RVA: 0x010535DC File Offset: 0x010517DC
		private void SelfToggle(EToggleState state)
		{
			Action<BossRushBuffSelectInGameItem> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack((state == EToggleState.ETT_Checked) ? this : null);
		}

		// Token: 0x0604305E RID: 274526 RVA: 0x010535F6 File Offset: 0x010517F6
		public void SetToggleUnCheck()
		{
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x04022E3A RID: 142906
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public Action<BossRushBuffSelectInGameItem> ClickCallBack;

		// Token: 0x04022E3B RID: 142907
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static Regex regex = new Regex("\\[(.*?)\\]");

		// Token: 0x0200CAAC RID: 51884
		private class EComponent
		{
			// Token: 0x0403D40D RID: 250893
			public const int QualityBgTexture = 0;

			// Token: 0x0403D40E RID: 250894
			public const int IconTexture = 1;

			// Token: 0x0403D40F RID: 250895
			public const int NameText = 2;

			// Token: 0x0403D410 RID: 250896
			public const int ElementLayout = 3;

			// Token: 0x0403D411 RID: 250897
			public const int DescText = 4;

			// Token: 0x0403D412 RID: 250898
			public const int SelfToggle = 5;

			// Token: 0x0403D413 RID: 250899
			public const int NewItem = 6;

			// Token: 0x0403D414 RID: 250900
			public const int QualityLineSprite = 7;

			// Token: 0x0403D415 RID: 250901
			public const int GoldItem = 8;

			// Token: 0x0403D416 RID: 250902
			public const int YellowItem = 9;

			// Token: 0x0403D417 RID: 250903
			public const int ButtonItem = 10;
		}
	}
}

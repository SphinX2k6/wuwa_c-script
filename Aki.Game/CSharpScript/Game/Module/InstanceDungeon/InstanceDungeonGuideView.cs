using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005878 RID: 22648
	public class InstanceDungeonGuideView : UiViewBase
	{
		// Token: 0x06039A04 RID: 236036 RVA: 0x00DB1A83 File Offset: 0x00DAFC83
		[NullableContext(1)]
		public InstanceDungeonGuideView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039A05 RID: 236037 RVA: 0x00DB1A8C File Offset: 0x00DAFC8C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickedCloseButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039A06 RID: 236038 RVA: 0x00DB1C1A File Offset: 0x00DAFE1A
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x06039A07 RID: 236039 RVA: 0x00DB1C24 File Offset: 0x00DAFE24
		protected override void OnStart()
		{
			base.GetButton(4).RootUIComp.Get().SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(2).SetUIActive(false);
			this.RefreshGuideView();
		}

		// Token: 0x06039A08 RID: 236040 RVA: 0x00DB1C88 File Offset: 0x00DAFE88
		private void RefreshGuideView()
		{
			int currentInstanceDungeonGuideValue = InstanceDungeonGuideModel.Instance.GetCurrentInstanceDungeonGuideValue();
			if (currentInstanceDungeonGuideValue == 0)
			{
				return;
			}
			IReadOnlyList<HelpText> helpContentInfoByGroupId = HelpConfig.Instance.GetHelpContentInfoByGroupId(currentInstanceDungeonGuideValue);
			if (helpContentInfoByGroupId == null || helpContentInfoByGroupId.Count < 1)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), helpContentInfoByGroupId[0].Title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), helpContentInfoByGroupId[0].Content, Array.Empty<object>());
			string picture = helpContentInfoByGroupId[0].Picture;
			if (string.IsNullOrEmpty(picture))
			{
				base.GetTexture(1).SetUIActive(false);
				return;
			}
			base.GetTexture(1).SetUIActive(true);
			base.SetTextureByPath(picture, base.GetTexture(1), null, null);
		}

		// Token: 0x0200BAD3 RID: 47827
		private static class EChildType
		{
			// Token: 0x0403874B RID: 231243
			public const int TextTitle = 0;

			// Token: 0x0403874C RID: 231244
			public const int DescriptionTexture = 1;

			// Token: 0x0403874D RID: 231245
			public const int EffectItem = 2;

			// Token: 0x0403874E RID: 231246
			public const int TextDescription = 3;

			// Token: 0x0403874F RID: 231247
			public const int DetailButton = 4;

			// Token: 0x04038750 RID: 231248
			public const int ItemElement = 5;

			// Token: 0x04038751 RID: 231249
			public const int CloseButton = 6;

			// Token: 0x04038752 RID: 231250
			public const int TrialPanel = 7;

			// Token: 0x04038753 RID: 231251
			public const int BigTitle = 8;
		}
	}
}

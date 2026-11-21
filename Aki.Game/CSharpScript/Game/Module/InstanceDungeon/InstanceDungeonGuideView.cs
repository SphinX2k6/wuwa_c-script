using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004850 RID: 18512
	public class InstanceDungeonGuideView : UiViewBase
	{
		// Token: 0x0602E925 RID: 190757 RVA: 0x00D00953 File Offset: 0x00CFEB53
		[NullableContext(1)]
		public InstanceDungeonGuideView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602E926 RID: 190758 RVA: 0x00D0095C File Offset: 0x00CFEB5C
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

		// Token: 0x0602E927 RID: 190759 RVA: 0x00D00AEA File Offset: 0x00CFECEA
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602E928 RID: 190760 RVA: 0x00D00AF3 File Offset: 0x00CFECF3
		protected override float OnGetTimeDilation()
		{
			if (!RoleTowerModel.Instance.IsInRoleTowerDungeon())
			{
				return base.OnGetTimeDilation();
			}
			return 1f;
		}

		// Token: 0x0602E929 RID: 190761 RVA: 0x00D00B10 File Offset: 0x00CFED10
		protected override void OnStart()
		{
			base.GetButton(4).RootUIComp.Get().SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(2).SetUIActive(false);
			this.RefreshGuideView();
		}

		// Token: 0x0602E92A RID: 190762 RVA: 0x00D00B74 File Offset: 0x00CFED74
		private void RefreshGuideView()
		{
			object openParam = this.OpenParam;
			int num2;
			if (openParam is int)
			{
				int num = (int)openParam;
				if (num > 0)
				{
					num2 = num;
					goto IL_2A;
				}
			}
			num2 = InstanceDungeonGuideModel.Instance.GetCurrentInstanceDungeonGuideValue();
			IL_2A:
			int num3 = num2;
			if (num3 == 0)
			{
				return;
			}
			IReadOnlyList<HelpText> helpContentInfoByGroupId = HelpConfig.Instance.GetHelpContentInfoByGroupId(num3);
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

		// Token: 0x0200A4EC RID: 42220
		private static class EChildType
		{
			// Token: 0x0403314C RID: 209228
			public const int TextTitle = 0;

			// Token: 0x0403314D RID: 209229
			public const int DescriptionTexture = 1;

			// Token: 0x0403314E RID: 209230
			public const int EffectItem = 2;

			// Token: 0x0403314F RID: 209231
			public const int TextDescription = 3;

			// Token: 0x04033150 RID: 209232
			public const int DetailButton = 4;

			// Token: 0x04033151 RID: 209233
			public const int ItemElement = 5;

			// Token: 0x04033152 RID: 209234
			public const int CloseButton = 6;

			// Token: 0x04033153 RID: 209235
			public const int TrialPanel = 7;

			// Token: 0x04033154 RID: 209236
			public const int BigTitle = 8;
		}
	}
}

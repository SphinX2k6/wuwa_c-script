using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041F2 RID: 16882
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailPassiveSkillItem : UiPanelBase
	{
		// Token: 0x0602AB1A RID: 174874 RVA: 0x00C0684C File Offset: 0x00C04A4C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
		}

		// Token: 0x0602AB1B RID: 174875 RVA: 0x00C06914 File Offset: 0x00C04B14
		private void RefreshCondition(ICardDetailConditionOutData outData)
		{
			if (outData == null || StringUtils.IsBlank(outData.ConditionDesc))
			{
				base.GetItem(1).SetUIActive(false);
				return;
			}
			base.GetItem(1).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), outData.ConditionDesc, new <>z__ReadOnlyArray<object>(new object[]
			{
				outData.CurrentProgress,
				outData.MaxProgress
			}));
			UUIText text = base.GetText(5);
			if (!StringUtils.IsBlank(outData.Title))
			{
				LguiUtil.Instance.SetLocalTextNew(text, outData.Title, Array.Empty<object>());
			}
			UUIItem uuiitem = text;
			bool valueOrDefault = outData.TitleChangeColor.GetValueOrDefault();
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(valueOrDefault, fcolor);
		}

		// Token: 0x0602AB1C RID: 174876 RVA: 0x00C069D8 File Offset: 0x00C04BD8
		private void RefreshProgress(ICardDetailConditionOutData outData)
		{
			UUIText text = base.GetText(3);
			if (outData == null || outData.MaxProgress == 0)
			{
				text.SetUIActive(false);
				return;
			}
			text.SetUIActive(true);
			if (!StringUtils.IsBlank(outData.Icon))
			{
				this.SetSpriteByPath(outData.Icon, base.GetSprite(4), true, null, null);
			}
			string textStringId = (outData.CurrentProgress >= outData.MaxProgress) ? "PhantomBattle_1163" : "PhantomBattle_1162";
			LguiUtil.Instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				outData.CurrentProgress,
				outData.MaxProgress
			}));
		}

		// Token: 0x0602AB1D RID: 174877 RVA: 0x00C06A88 File Offset: 0x00C04C88
		private void RefreshInData(ICardDetailConditionInData data)
		{
			if (data != null)
			{
				base.GetItem(1).SetUIActive(false);
				base.GetSprite(4).SetUIActive(false);
				base.GetText(3).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.TextArg.TextKey, data.TextArg.Params);
			}
		}

		// Token: 0x0602AB1E RID: 174878 RVA: 0x00C06AE6 File Offset: 0x00C04CE6
		private void RefreshOutData(ICardDetailConditionOutData outData)
		{
			this.RefreshCondition(outData);
			this.RefreshProgress(outData);
		}

		// Token: 0x0602AB1F RID: 174879 RVA: 0x00C06AF8 File Offset: 0x00C04CF8
		private void RefreshEffectCount(ICardDetailEffectCountData effectCountData)
		{
			base.GetItem(6).SetUIActive(effectCountData != null);
			if (effectCountData != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "PhantomBattle_1161", new <>z__ReadOnlyArray<object>(new object[]
				{
					effectCountData.CurrentEffectCount,
					effectCountData.TotalEffectCount
				}));
			}
		}

		// Token: 0x0602AB20 RID: 174880 RVA: 0x00C06B58 File Offset: 0x00C04D58
		public void Refresh(ICardDetailPassiveSkillData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, data.Params.ToArray());
			ICardDetailPassiveSkillFieldData fieldData = data.FieldData;
			this.RefreshOutData((fieldData != null) ? fieldData.OutData : null);
			ICardDetailPassiveSkillFieldData fieldData2 = data.FieldData;
			this.RefreshInData((fieldData2 != null) ? fieldData2.InData : null);
			this.RefreshEffectCount(data.EffectCountData);
		}

		// Token: 0x02009DF1 RID: 40433
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x040311DA RID: 201178
			public const int DescText = 0;

			// Token: 0x040311DB RID: 201179
			public const int ConditionItem = 1;

			// Token: 0x040311DC RID: 201180
			public const int ConditionText = 2;

			// Token: 0x040311DD RID: 201181
			public const int ProgressText = 3;

			// Token: 0x040311DE RID: 201182
			public const int ProgressIcon = 4;

			// Token: 0x040311DF RID: 201183
			public const int TitleText = 5;

			// Token: 0x040311E0 RID: 201184
			public const int EffectCountItem = 6;

			// Token: 0x040311E1 RID: 201185
			public const int EffectCountText = 7;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005222 RID: 21026
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailPassiveSkillItem : UiPanelBase
	{
		// Token: 0x06035C1F RID: 220191 RVA: 0x00CB9208 File Offset: 0x00CB7408
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

		// Token: 0x06035C20 RID: 220192 RVA: 0x00CB92D0 File Offset: 0x00CB74D0
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

		// Token: 0x06035C21 RID: 220193 RVA: 0x00CB9394 File Offset: 0x00CB7594
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

		// Token: 0x06035C22 RID: 220194 RVA: 0x00CB9444 File Offset: 0x00CB7644
		private void RefreshInData(ICardDetailConditionInData data)
		{
			if (data != null)
			{
				base.GetItem(1).SetUIActive(false);
				base.GetSprite(4).SetUIActive(false);
				base.GetText(3).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.TextArg.TextKey, data.TextArg.Params.ToArray<object>());
			}
		}

		// Token: 0x06035C23 RID: 220195 RVA: 0x00CB94A7 File Offset: 0x00CB76A7
		private void RefreshOutData(ICardDetailConditionOutData outData)
		{
			this.RefreshCondition(outData);
			this.RefreshProgress(outData);
		}

		// Token: 0x06035C24 RID: 220196 RVA: 0x00CB94B8 File Offset: 0x00CB76B8
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

		// Token: 0x06035C25 RID: 220197 RVA: 0x00CB9518 File Offset: 0x00CB7718
		public void Refresh(ICardDetailPassiveSkillData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, data.Params.ToArray());
			ICardDetailPassiveSkillFieldData fieldData = data.FieldData;
			this.RefreshOutData((fieldData != null) ? fieldData.OutData : null);
			ICardDetailPassiveSkillFieldData fieldData2 = data.FieldData;
			this.RefreshInData((fieldData2 != null) ? fieldData2.InData : null);
			this.RefreshEffectCount(data.EffectCountData);
		}

		// Token: 0x0200B3B9 RID: 46009
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04036787 RID: 223111
			public const int DescText = 0;

			// Token: 0x04036788 RID: 223112
			public const int ConditionItem = 1;

			// Token: 0x04036789 RID: 223113
			public const int ConditionText = 2;

			// Token: 0x0403678A RID: 223114
			public const int ProgressText = 3;

			// Token: 0x0403678B RID: 223115
			public const int ProgressIcon = 4;

			// Token: 0x0403678C RID: 223116
			public const int TitleText = 5;

			// Token: 0x0403678D RID: 223117
			public const int EffectCountItem = 6;

			// Token: 0x0403678E RID: 223118
			public const int EffectCountText = 7;
		}
	}
}

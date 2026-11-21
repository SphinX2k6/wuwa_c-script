using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Dialogue;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037B9 RID: 14265
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelOption
	{
		// Token: 0x17004C77 RID: 19575
		// (get) Token: 0x060251E9 RID: 152041 RVA: 0x00A7879C File Offset: 0x00A7699C
		public int SourceIndex { get; }

		// Token: 0x17004C78 RID: 19576
		// (get) Token: 0x060251EA RID: 152042 RVA: 0x00A787A4 File Offset: 0x00A769A4
		public string TextKey { get; }

		// Token: 0x17004C79 RID: 19577
		// (get) Token: 0x060251EB RID: 152043 RVA: 0x00A787AC File Offset: 0x00A769AC
		public int? TextId { get; }

		// Token: 0x17004C7A RID: 19578
		// (get) Token: 0x060251EC RID: 152044 RVA: 0x00A787B4 File Offset: 0x00A769B4
		public int? PlotOptionId { get; }

		// Token: 0x17004C7B RID: 19579
		// (get) Token: 0x060251ED RID: 152045 RVA: 0x00A787BC File Offset: 0x00A769BC
		public bool ReadMarkEnabled { get; }

		// Token: 0x17004C7C RID: 19580
		// (get) Token: 0x060251EE RID: 152046 RVA: 0x00A787C4 File Offset: 0x00A769C4
		public int? ConfirmBoxId { get; }

		// Token: 0x17004C7D RID: 19581
		// (get) Token: 0x060251EF RID: 152047 RVA: 0x00A787CC File Offset: 0x00A769CC
		public bool Hidden { get; }

		// Token: 0x17004C7E RID: 19582
		// (get) Token: 0x060251F0 RID: 152048 RVA: 0x00A787D4 File Offset: 0x00A769D4
		public bool HideWhenConditionUnmet { get; }

		// Token: 0x17004C7F RID: 19583
		// (get) Token: 0x060251F1 RID: 152049 RVA: 0x00A787DC File Offset: 0x00A769DC
		public bool HideConditionTextWhenUnmet { get; }

		// Token: 0x17004C80 RID: 19584
		// (get) Token: 0x060251F2 RID: 152050 RVA: 0x00A787E4 File Offset: 0x00A769E4
		public string TextKeyWhenConditionUnmet { get; }

		// Token: 0x17004C81 RID: 19585
		// (get) Token: 0x060251F3 RID: 152051 RVA: 0x00A787EC File Offset: 0x00A769EC
		public bool HasLockTip { get; }

		// Token: 0x17004C82 RID: 19586
		// (get) Token: 0x060251F4 RID: 152052 RVA: 0x00A787F4 File Offset: 0x00A769F4
		public string LockTipTextKey { get; }

		// Token: 0x17004C83 RID: 19587
		// (get) Token: 0x060251F5 RID: 152053 RVA: 0x00A787FC File Offset: 0x00A769FC
		[Nullable(2)]
		public ITalkOptionSystemCondition Condition { [NullableContext(2)] get; }

		// Token: 0x17004C84 RID: 19588
		// (get) Token: 0x060251F6 RID: 152054 RVA: 0x00A78804 File Offset: 0x00A76A04
		public IReadOnlyList<IVisualNovelPerformanceBase> Performances { get; }

		// Token: 0x060251F7 RID: 152055 RVA: 0x00A7880C File Offset: 0x00A76A0C
		private VisualNovelOption(DialogueOption option)
		{
			ITalkOption config = option.Config;
			ITalkOptionVisualNovel talkOptionVisualNovel = config.TypeParams as ITalkOptionVisualNovel;
			ITalkOptionSystemCondition talkOptionSystemCondition = config.PreCondition as ITalkOptionSystemCondition;
			this.SourceIndex = option.Index;
			this.TextKey = (config.TidTalkOption ?? string.Empty);
			this.TextId = config.TextId;
			this.PlotOptionId = ((talkOptionVisualNovel != null) ? talkOptionVisualNovel.PlotOptionId : null);
			this.ReadMarkEnabled = config.ReadMarkEnabled.GetValueOrDefault();
			int? num;
			if (talkOptionVisualNovel == null)
			{
				num = null;
			}
			else
			{
				ITalkOptionVisualNovelDoubleConfirm doubleConfirm = talkOptionVisualNovel.DoubleConfirm;
				num = ((doubleConfirm != null) ? new int?(doubleConfirm.ConfirmBoxId) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			this.ConfirmBoxId = ((valueOrDefault > 0) ? new int?(valueOrDefault) : null);
			this.Hidden = config.HiddenOption.GetValueOrDefault();
			this.HideWhenConditionUnmet = (talkOptionSystemCondition != null && talkOptionSystemCondition.HideWhenUnmet.GetValueOrDefault());
			this.HideConditionTextWhenUnmet = (talkOptionSystemCondition != null && talkOptionSystemCondition.HideConditionTextWhenUnmet.GetValueOrDefault());
			this.TextKeyWhenConditionUnmet = (((talkOptionSystemCondition != null) ? talkOptionSystemCondition.TidReplaceTextWhenUnmet : null) ?? string.Empty);
			this.HasLockTip = (config.OptionLockTip != null);
			this.LockTipTextKey = VisualNovelOption.GetLockTipTextKey(config.OptionLockTip);
			this.Condition = talkOptionSystemCondition;
			this.Performances = (((talkOptionVisualNovel != null) ? talkOptionVisualNovel.OptionPerformances : null) ?? new List<IVisualNovelPerformanceBase>());
		}

		// Token: 0x060251F8 RID: 152056 RVA: 0x00A78998 File Offset: 0x00A76B98
		public static VisualNovelOption Create(DialogueOption option)
		{
			return new VisualNovelOption(option);
		}

		// Token: 0x060251F9 RID: 152057 RVA: 0x00A789A0 File Offset: 0x00A76BA0
		private static string GetLockTipTextKey([Nullable(2)] IOptionLockTip lockTip)
		{
			if (!string.IsNullOrEmpty((lockTip != null) ? lockTip.TidHintText : null))
			{
				return lockTip.TidHintText;
			}
			if (lockTip == null || lockTip.HintTextId == null)
			{
				return string.Empty;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[TextId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(lockTip.HintTextId.Value);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}
}

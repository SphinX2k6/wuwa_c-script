using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Letter.View
{
	// Token: 0x020046A2 RID: 18082
	[NullableContext(1)]
	[Nullable(0)]
	public class LetterBackupDisplayView : UiViewBase
	{
		// Token: 0x0602D749 RID: 186185 RVA: 0x00CBAC04 File Offset: 0x00CB8E04
		public LetterBackupDisplayView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D74A RID: 186186 RVA: 0x00CBAC18 File Offset: 0x00CB8E18
		private static string BuildLetterTitleTid(int letterId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("WriteLetter_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(letterId);
			defaultInterpolatedStringHandler.AppendLiteral("_Title");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602D74B RID: 186187 RVA: 0x00CBAC58 File Offset: 0x00CB8E58
		private static List<ITalkItem> BuildSyntheticTalkItems([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlySet<string> keys)
		{
			if (keys == null || keys.Count == 0)
			{
				return new List<ITalkItem>();
			}
			List<ITalkItem> list = new List<ITalkItem>();
			int num = 0;
			foreach (string tidTalk in keys)
			{
				list.Add(new ITalkItem
				{
					Id = num,
					Name = "",
					TidTalk = tidTalk,
					Options = new List<ITalkOption>(),
					Actions = new List<ActionInfo>()
				});
				num++;
			}
			return list;
		}

		// Token: 0x0602D74C RID: 186188 RVA: 0x00CBACF4 File Offset: 0x00CB8EF4
		[NullableContext(2)]
		private static ILetterBackupDisplayViewOpenParam NormalizeOpenParam(object raw)
		{
			if (raw is int)
			{
				int letterId = (int)raw;
				return new LetterBackupDisplayViewOpenParam
				{
					LetterId = letterId
				};
			}
			ILetterBackupDisplayViewOpenParam letterBackupDisplayViewOpenParam = raw as ILetterBackupDisplayViewOpenParam;
			if (letterBackupDisplayViewOpenParam != null)
			{
				return new LetterBackupDisplayViewOpenParam
				{
					LetterId = letterBackupDisplayViewOpenParam.LetterId,
					Items = letterBackupDisplayViewOpenParam.Items,
					LetterStyle = letterBackupDisplayViewOpenParam.LetterStyle
				};
			}
			return null;
		}

		// Token: 0x0602D74D RID: 186189 RVA: 0x00CBAD54 File Offset: 0x00CB8F54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602D74E RID: 186190 RVA: 0x00CBADE0 File Offset: 0x00CB8FE0
		protected override UniTask OnBeforeStartAsync()
		{
			LetterBackupDisplayView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LetterBackupDisplayView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D74F RID: 186191 RVA: 0x00CBAE23 File Offset: 0x00CB9023
		private void OnClickClose()
		{
			this.CloseWithBlackScreen().Forget();
		}

		// Token: 0x0602D750 RID: 186192 RVA: 0x00CBAE30 File Offset: 0x00CB9030
		private UniTask CloseWithBlackScreen()
		{
			LetterBackupDisplayView.<CloseWithBlackScreen>d__12 <CloseWithBlackScreen>d__;
			<CloseWithBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseWithBlackScreen>d__.<>4__this = this;
			<CloseWithBlackScreen>d__.<>1__state = -1;
			<CloseWithBlackScreen>d__.<>t__builder.Start<LetterBackupDisplayView.<CloseWithBlackScreen>d__12>(ref <CloseWithBlackScreen>d__);
			return <CloseWithBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x0602D751 RID: 186193 RVA: 0x00CBAE73 File Offset: 0x00CB9073
		protected override void OnBeforeDestroy()
		{
			this.BlackScreenSuppressor.Restore().Forget();
		}

		// Token: 0x0401858F RID: 99727
		private const string LETTER_BACKUP_TITLE_TID = "Text_LetterBackupDisplay_Title";

		// Token: 0x04018590 RID: 99728
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04018591 RID: 99729
		[Nullable(2)]
		private LetterPanel InnerLetterPanel;

		// Token: 0x04018592 RID: 99730
		private readonly LetterBlackScreenSuppressor BlackScreenSuppressor = new LetterBlackScreenSuppressor();

		// Token: 0x0200A2C9 RID: 41673
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403280A RID: 206858
			public const int ItemTopBar = 0;

			// Token: 0x0403280B RID: 206859
			public const int TxtName = 1;

			// Token: 0x0403280C RID: 206860
			public const int ItemLetterPanel = 2;
		}
	}
}

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
	// Token: 0x020056CB RID: 22219
	[NullableContext(1)]
	[Nullable(0)]
	public class LetterBackupDisplayView : UiViewBase
	{
		// Token: 0x06038839 RID: 231481 RVA: 0x00D6C64C File Offset: 0x00D6A84C
		public LetterBackupDisplayView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603883A RID: 231482 RVA: 0x00D6C660 File Offset: 0x00D6A860
		private static string BuildLetterTitleTid(int letterId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("WriteLetter_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(letterId);
			defaultInterpolatedStringHandler.AppendLiteral("_Title");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0603883B RID: 231483 RVA: 0x00D6C6A0 File Offset: 0x00D6A8A0
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

		// Token: 0x0603883C RID: 231484 RVA: 0x00D6C73C File Offset: 0x00D6A93C
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

		// Token: 0x0603883D RID: 231485 RVA: 0x00D6C79C File Offset: 0x00D6A99C
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

		// Token: 0x0603883E RID: 231486 RVA: 0x00D6C828 File Offset: 0x00D6AA28
		protected override UniTask OnBeforeStartAsync()
		{
			LetterBackupDisplayView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LetterBackupDisplayView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603883F RID: 231487 RVA: 0x00D6C86B File Offset: 0x00D6AA6B
		private void OnClickClose()
		{
			this.CloseWithBlackScreen().Forget();
		}

		// Token: 0x06038840 RID: 231488 RVA: 0x00D6C878 File Offset: 0x00D6AA78
		private UniTask CloseWithBlackScreen()
		{
			LetterBackupDisplayView.<CloseWithBlackScreen>d__12 <CloseWithBlackScreen>d__;
			<CloseWithBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseWithBlackScreen>d__.<>4__this = this;
			<CloseWithBlackScreen>d__.<>1__state = -1;
			<CloseWithBlackScreen>d__.<>t__builder.Start<LetterBackupDisplayView.<CloseWithBlackScreen>d__12>(ref <CloseWithBlackScreen>d__);
			return <CloseWithBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x06038841 RID: 231489 RVA: 0x00D6C8BB File Offset: 0x00D6AABB
		protected override void OnBeforeDestroy()
		{
			this.BlackScreenSuppressor.Restore().Forget();
		}

		// Token: 0x0401DAF9 RID: 121593
		private const string LETTER_BACKUP_TITLE_TID = "Text_LetterBackupDisplay_Title";

		// Token: 0x0401DAFA RID: 121594
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401DAFB RID: 121595
		[Nullable(2)]
		private LetterPanel InnerLetterPanel;

		// Token: 0x0401DAFC RID: 121596
		private readonly LetterBlackScreenSuppressor BlackScreenSuppressor = new LetterBlackScreenSuppressor();

		// Token: 0x0200B8A2 RID: 47266
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04037DF0 RID: 228848
			public const int ItemTopBar = 0;

			// Token: 0x04037DF1 RID: 228849
			public const int TxtName = 1;

			// Token: 0x04037DF2 RID: 228850
			public const int ItemLetterPanel = 2;
		}
	}
}

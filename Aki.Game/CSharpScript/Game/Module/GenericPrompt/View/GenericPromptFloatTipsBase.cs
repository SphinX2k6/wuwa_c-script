using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x020059A9 RID: 22953
	[NullableContext(2)]
	[Nullable(0)]
	public class GenericPromptFloatTipsBase : UiTickViewBase
	{
		// Token: 0x0603A37E RID: 238462 RVA: 0x00DD60D7 File Offset: 0x00DD42D7
		[NullableContext(1)]
		public GenericPromptFloatTipsBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A37F RID: 238463 RVA: 0x00DD60E0 File Offset: 0x00DD42E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A380 RID: 238464 RVA: 0x00DD6149 File Offset: 0x00DD4349
		protected override void OnBeforeCreate()
		{
			this.Data = (this.OpenParam as IPromptParamHub);
			this.TypeConfig = GenericPromptConfig.Instance.GetPromptTypeInfo(this.Data.TypeId);
		}

		// Token: 0x0603A381 RID: 238465 RVA: 0x00DD6178 File Offset: 0x00DD4378
		protected override void OnStart()
		{
			IReadOnlyList<object> mainText = this.Data.MainTextParams ?? Array.Empty<object>();
			this.SetMainText(mainText);
			IReadOnlyList<object> extraText = this.Data.ExtraTextParams ?? Array.Empty<object>();
			this.SetExtraText(extraText);
			this.SetTickDuration();
			this.SetVerticalOffset();
		}

		// Token: 0x0603A382 RID: 238466 RVA: 0x00DD61CC File Offset: 0x00DD43CC
		protected virtual void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
			UUIText text = base.GetText(0);
			if (this.Data.MainTextObj == null && this.Data.PromptId == null && param.Count > 0 && !string.IsNullOrEmpty(param[0] as string))
			{
				string text2 = param[0] as string;
				if (!string.IsNullOrEmpty(text2))
				{
					text.SetText(text2, true);
					text.SetUIActive(true);
					return;
				}
				text.SetUIActive(false);
				return;
			}
			else
			{
				if (this.Data.MainTextObj != null)
				{
					LguiUtil.Instance.SetLocalTextNew(text, this.Data.MainTextObj.TextKey, param);
					text.SetUIActive(true);
					return;
				}
				if (!StringUtils.IsBlank(this.TypeConfig.Value.GeneralText))
				{
					LguiUtil.Instance.SetLocalTextNew(text, this.TypeConfig.Value.GeneralText, param);
					text.SetUIActive(true);
					return;
				}
				text.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0603A383 RID: 238467 RVA: 0x00DD62C8 File Offset: 0x00DD44C8
		protected virtual void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
			UUIText text = base.GetText(1);
			if (this.Data.ExtraTextObj == null && this.Data.PromptId == null && param.Count > 0 && !string.IsNullOrEmpty(param[0] as string))
			{
				string newText = param[0] as string;
				text.SetText(newText, true);
				text.SetUIActive(true);
				return;
			}
			if (this.Data.ExtraTextObj != null)
			{
				LguiUtil.Instance.SetLocalTextNew(text, this.Data.ExtraTextObj.TextKey, param);
				text.SetUIActive(true);
				return;
			}
			if (!StringUtils.IsBlank(this.TypeConfig.Value.GeneralExtraText))
			{
				LguiUtil.Instance.SetLocalTextNew(text, this.TypeConfig.Value.GeneralExtraText, param);
				text.SetUIActive(true);
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x0603A384 RID: 238468 RVA: 0x00DD63B4 File Offset: 0x00DD45B4
		private void SetTickDuration()
		{
			float? duration = this.Data.Duration;
			float num = 0f;
			if (duration.GetValueOrDefault() > num & duration != null)
			{
				this.TickDuration = (double)this.Data.Duration.Value;
				return;
			}
			if (this.Data.PromptId != null)
			{
				int? promptId = this.Data.PromptId;
				int num2 = 0;
				if (!(promptId.GetValueOrDefault() == num2 & promptId != null))
				{
					GenericPrompt? promptInfo = GenericPromptConfig.Instance.GetPromptInfo(this.Data.PromptId.GetValueOrDefault());
					this.TickDuration = (double)((promptInfo != null) ? promptInfo.GetValueOrDefault().Duration : 0);
				}
			}
			if (this.TickDuration == 0.0)
			{
				this.TickDuration = (double)((this.TypeConfig != null) ? this.TypeConfig.GetValueOrDefault().Duration : 0);
			}
			if (this.TickDuration == 0.0)
			{
				this.TickTime = -1.0;
			}
		}

		// Token: 0x0603A385 RID: 238469 RVA: 0x00DD64D4 File Offset: 0x00DD46D4
		private void SetVerticalOffset()
		{
			if (this.Data.TypeId == 0)
			{
				return;
			}
			GenericPromptTypes? promptTypeInfo = GenericPromptConfig.Instance.GetPromptTypeInfo(this.Data.TypeId);
			if (promptTypeInfo.Value.OffsetY == 0f)
			{
				return;
			}
			this.RootItem.SetAnchorOffsetY(promptTypeInfo.Value.OffsetY);
		}

		// Token: 0x0603A386 RID: 238470 RVA: 0x00DD6538 File Offset: 0x00DD4738
		protected override void OnTick(float delta)
		{
			if (this.ClosePromise != null)
			{
				this.TickTime = -1.0;
				return;
			}
			if (this.TickTime < 0.0)
			{
				return;
			}
			this.TickTime += (double)delta;
			if (this.TickTime > this.TickDuration * 1000.0)
			{
				base.CloseMe(delegate(bool success)
				{
					if (success)
					{
						Action closeCallback = this.Data.CloseCallback;
						if (closeCallback == null)
						{
							return;
						}
						closeCallback();
					}
				});
			}
		}

		// Token: 0x17008B8B RID: 35723
		// (get) Token: 0x0603A387 RID: 238471 RVA: 0x00DD65A8 File Offset: 0x00DD47A8
		protected UUIText MainText
		{
			get
			{
				return base.GetText(0);
			}
		}

		// Token: 0x17008B8C RID: 35724
		// (get) Token: 0x0603A388 RID: 238472 RVA: 0x00DD65B1 File Offset: 0x00DD47B1
		protected UUIText ExtraText
		{
			get
			{
				return base.GetText(1);
			}
		}

		// Token: 0x0401E5E9 RID: 124393
		protected double TickDuration;

		// Token: 0x0401E5EA RID: 124394
		protected double TickTime;

		// Token: 0x0401E5EB RID: 124395
		protected IPromptParamHub Data;

		// Token: 0x0401E5EC RID: 124396
		protected GenericPromptTypes? TypeConfig;

		// Token: 0x0200BC1A RID: 48154
		[NullableContext(0)]
		private class EGenericPromptFloatTipsBase
		{
			// Token: 0x04038C5C RID: 232540
			public const int MainTextItem = 0;

			// Token: 0x04038C5D RID: 232541
			public const int ExtraTextItem = 1;
		}
	}
}

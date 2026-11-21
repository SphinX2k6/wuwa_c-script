using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004982 RID: 18818
	[NullableContext(2)]
	[Nullable(0)]
	public class GenericPromptFloatTipsBase : UiTickViewBase
	{
		// Token: 0x0602F2A4 RID: 193188 RVA: 0x00D25567 File Offset: 0x00D23767
		[NullableContext(1)]
		public GenericPromptFloatTipsBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F2A5 RID: 193189 RVA: 0x00D25570 File Offset: 0x00D23770
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

		// Token: 0x0602F2A6 RID: 193190 RVA: 0x00D255D9 File Offset: 0x00D237D9
		protected override void OnBeforeCreate()
		{
			this.Data = (this.OpenParam as IPromptParamHub);
			this.TypeConfig = GenericPromptConfig.Instance.GetPromptTypeInfo(this.Data.TypeId);
		}

		// Token: 0x0602F2A7 RID: 193191 RVA: 0x00D25608 File Offset: 0x00D23808
		protected override void OnStart()
		{
			IReadOnlyList<object> mainText = this.Data.MainTextParams ?? Array.Empty<object>();
			this.SetMainText(mainText);
			IReadOnlyList<object> extraText = this.Data.ExtraTextParams ?? Array.Empty<object>();
			this.SetExtraText(extraText);
			this.SetTickDuration();
			this.SetVerticalOffset();
		}

		// Token: 0x0602F2A8 RID: 193192 RVA: 0x00D2565C File Offset: 0x00D2385C
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

		// Token: 0x0602F2A9 RID: 193193 RVA: 0x00D25758 File Offset: 0x00D23958
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

		// Token: 0x0602F2AA RID: 193194 RVA: 0x00D25844 File Offset: 0x00D23A44
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

		// Token: 0x0602F2AB RID: 193195 RVA: 0x00D25964 File Offset: 0x00D23B64
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

		// Token: 0x0602F2AC RID: 193196 RVA: 0x00D259C8 File Offset: 0x00D23BC8
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

		// Token: 0x17005F58 RID: 24408
		// (get) Token: 0x0602F2AD RID: 193197 RVA: 0x00D25A38 File Offset: 0x00D23C38
		protected UUIText MainText
		{
			get
			{
				return base.GetText(0);
			}
		}

		// Token: 0x17005F59 RID: 24409
		// (get) Token: 0x0602F2AE RID: 193198 RVA: 0x00D25A41 File Offset: 0x00D23C41
		protected UUIText ExtraText
		{
			get
			{
				return base.GetText(1);
			}
		}

		// Token: 0x04019087 RID: 102535
		protected double TickDuration;

		// Token: 0x04019088 RID: 102536
		protected double TickTime;

		// Token: 0x04019089 RID: 102537
		protected IPromptParamHub Data;

		// Token: 0x0401908A RID: 102538
		protected GenericPromptTypes? TypeConfig;

		// Token: 0x0200A625 RID: 42533
		[NullableContext(0)]
		private class EGenericPromptFloatTipsBase
		{
			// Token: 0x0403362B RID: 210475
			public const int MainTextItem = 0;

			// Token: 0x0403362C RID: 210476
			public const int ExtraTextItem = 1;
		}
	}
}

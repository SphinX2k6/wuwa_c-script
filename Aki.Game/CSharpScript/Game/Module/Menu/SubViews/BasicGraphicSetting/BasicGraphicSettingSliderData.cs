using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02005451 RID: 21585
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class BasicGraphicSettingSliderData
	{
		// Token: 0x060371C7 RID: 225735 RVA: 0x00D102A0 File Offset: 0x00D0E4A0
		public BasicGraphicSettingSliderData(MenuData metaData)
		{
			this.FunctionId = new EFunction?(metaData.FunctionId);
			this.MinValueInternal = metaData.SliderRange[0];
			this.MaxValueInternal = metaData.SliderRange[1];
			int? currentValue = GameSettingsManager.Instance.GetCurrentValue(metaData.FunctionId, true, true);
			this.CurValueInternal = ((currentValue != null) ? ((float)currentValue.GetValueOrDefault()) : metaData.SliderDefault);
			this.DefaultValueInternal = metaData.SliderDefault;
			this.TitleInternal = metaData.FunctionName;
			this.MetaData = metaData;
		}

		// Token: 0x1700844D RID: 33869
		// (get) Token: 0x060371C8 RID: 225736 RVA: 0x00D10361 File Offset: 0x00D0E561
		public MenuData MenuData
		{
			get
			{
				return this.MetaData;
			}
		}

		// Token: 0x1700844E RID: 33870
		// (get) Token: 0x060371C9 RID: 225737 RVA: 0x00D10369 File Offset: 0x00D0E569
		public float MinValue
		{
			get
			{
				return this.MinValueInternal;
			}
		}

		// Token: 0x1700844F RID: 33871
		// (get) Token: 0x060371CA RID: 225738 RVA: 0x00D10371 File Offset: 0x00D0E571
		public float MaxValue
		{
			get
			{
				return this.MaxValueInternal;
			}
		}

		// Token: 0x17008450 RID: 33872
		// (get) Token: 0x060371CB RID: 225739 RVA: 0x00D10379 File Offset: 0x00D0E579
		public float CurValue
		{
			get
			{
				return this.CurValueInternal;
			}
		}

		// Token: 0x17008451 RID: 33873
		// (get) Token: 0x060371CC RID: 225740 RVA: 0x00D10381 File Offset: 0x00D0E581
		public float DefaultCurValue
		{
			get
			{
				return this.DefaultValueInternal;
			}
		}

		// Token: 0x17008452 RID: 33874
		// (get) Token: 0x060371CD RID: 225741 RVA: 0x00D10389 File Offset: 0x00D0E589
		public string Title
		{
			get
			{
				return this.TitleInternal;
			}
		}

		// Token: 0x060371CE RID: 225742 RVA: 0x00D10391 File Offset: 0x00D0E591
		public void OnApplyValue()
		{
			GameSettingsManager.Instance.HandleValueChange(this.FunctionId.Value, (int)this.CurValueInternal, EGameSettingsApplyReason.WhenUi);
		}

		// Token: 0x0401D133 RID: 119091
		protected float MinValueInternal;

		// Token: 0x0401D134 RID: 119092
		protected float MaxValueInternal;

		// Token: 0x0401D135 RID: 119093
		protected float CurValueInternal;

		// Token: 0x0401D136 RID: 119094
		protected float DefaultValueInternal;

		// Token: 0x0401D137 RID: 119095
		protected string TitleInternal = "";

		// Token: 0x0401D138 RID: 119096
		protected EFunction? FunctionId;

		// Token: 0x0401D139 RID: 119097
		[Nullable(2)]
		protected MenuData MetaData;

		// Token: 0x0401D13A RID: 119098
		public Action<float> OnChangeValue = delegate(float value)
		{
		};
	}
}

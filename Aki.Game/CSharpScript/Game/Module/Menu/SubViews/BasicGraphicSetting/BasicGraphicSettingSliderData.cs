using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02004434 RID: 17460
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class BasicGraphicSettingSliderData
	{
		// Token: 0x0602C110 RID: 180496 RVA: 0x00C5F6B8 File Offset: 0x00C5D8B8
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

		// Token: 0x17005819 RID: 22553
		// (get) Token: 0x0602C111 RID: 180497 RVA: 0x00C5F779 File Offset: 0x00C5D979
		public MenuData MenuData
		{
			get
			{
				return this.MetaData;
			}
		}

		// Token: 0x1700581A RID: 22554
		// (get) Token: 0x0602C112 RID: 180498 RVA: 0x00C5F781 File Offset: 0x00C5D981
		public float MinValue
		{
			get
			{
				return this.MinValueInternal;
			}
		}

		// Token: 0x1700581B RID: 22555
		// (get) Token: 0x0602C113 RID: 180499 RVA: 0x00C5F789 File Offset: 0x00C5D989
		public float MaxValue
		{
			get
			{
				return this.MaxValueInternal;
			}
		}

		// Token: 0x1700581C RID: 22556
		// (get) Token: 0x0602C114 RID: 180500 RVA: 0x00C5F791 File Offset: 0x00C5D991
		public float CurValue
		{
			get
			{
				return this.CurValueInternal;
			}
		}

		// Token: 0x1700581D RID: 22557
		// (get) Token: 0x0602C115 RID: 180501 RVA: 0x00C5F799 File Offset: 0x00C5D999
		public float DefaultCurValue
		{
			get
			{
				return this.DefaultValueInternal;
			}
		}

		// Token: 0x1700581E RID: 22558
		// (get) Token: 0x0602C116 RID: 180502 RVA: 0x00C5F7A1 File Offset: 0x00C5D9A1
		public string Title
		{
			get
			{
				return this.TitleInternal;
			}
		}

		// Token: 0x0602C117 RID: 180503 RVA: 0x00C5F7A9 File Offset: 0x00C5D9A9
		public void OnApplyValue()
		{
			GameSettingsManager.Instance.HandleValueChange(this.FunctionId.Value, (int)this.CurValueInternal, EGameSettingsApplyReason.WhenUi);
		}

		// Token: 0x04017BCC RID: 97228
		protected float MinValueInternal;

		// Token: 0x04017BCD RID: 97229
		protected float MaxValueInternal;

		// Token: 0x04017BCE RID: 97230
		protected float CurValueInternal;

		// Token: 0x04017BCF RID: 97231
		protected float DefaultValueInternal;

		// Token: 0x04017BD0 RID: 97232
		protected string TitleInternal = "";

		// Token: 0x04017BD1 RID: 97233
		protected EFunction? FunctionId;

		// Token: 0x04017BD2 RID: 97234
		[Nullable(2)]
		protected MenuData MetaData;

		// Token: 0x04017BD3 RID: 97235
		public Action<float> OnChangeValue = delegate(float value)
		{
		};
	}
}

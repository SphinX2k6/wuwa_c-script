using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000E66 RID: 3686
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SmallItemGridModel : ModelBase
{
	// Token: 0x0600939B RID: 37787 RVA: 0x002BF04C File Offset: 0x002BD24C
	protected override bool OnInit()
	{
		this.ItemGridNameMaxLength = ConfigCommonParamById.GetIntConfig("ItemGridNameMaxLength").Value;
		this.DefaultQualitySpritePath = UiResourceConfig.Instance.GetResourcePath("SP_QualityVisionB");
		this.ItemGridCoolDownSecond = ConfigCommonParamById.GetIntConfig("ItemGridCoolDownSecond").Value;
		return true;
	}

	// Token: 0x17001030 RID: 4144
	// (get) Token: 0x0600939C RID: 37788 RVA: 0x002BF09F File Offset: 0x002BD29F
	public static SmallItemGridModel Instance
	{
		get
		{
			return SmallItemGridModel._Instance;
		}
	}

	// Token: 0x0600939D RID: 37789 RVA: 0x002BF0A6 File Offset: 0x002BD2A6
	public static SmallItemGridModel GetOrCreateInstance()
	{
		if (SmallItemGridModel._Instance == null)
		{
			SmallItemGridModel.CreateInstance();
		}
		return SmallItemGridModel._Instance;
	}

	// Token: 0x0600939E RID: 37790 RVA: 0x002BF0BA File Offset: 0x002BD2BA
	public static bool CreateInstance()
	{
		if (SmallItemGridModel._Instance != null)
		{
			return true;
		}
		SmallItemGridModel._Instance = new SmallItemGridModel();
		return true;
	}

	// Token: 0x0600939F RID: 37791 RVA: 0x002BF0D0 File Offset: 0x002BD2D0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060093A0 RID: 37792 RVA: 0x002BF0D2 File Offset: 0x002BD2D2
	public static void ResetStaticDefaultValue()
	{
		SmallItemGridModel._Instance = null;
	}

	// Token: 0x060093A1 RID: 37793 RVA: 0x002BF0DA File Offset: 0x002BD2DA
	static SmallItemGridModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SmallItemGridModel.CreateStaticDefaultValue), new Action(SmallItemGridModel.ResetStaticDefaultValue));
	}

	// Token: 0x040056DD RID: 22237
	public int ItemGridCoolDownSecond;

	// Token: 0x040056DE RID: 22238
	public int ItemGridNameMaxLength;

	// Token: 0x040056DF RID: 22239
	public string DefaultQualitySpritePath;

	// Token: 0x040056E0 RID: 22240
	[Nullable(2)]
	private static SmallItemGridModel _Instance;
}

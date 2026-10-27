using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020019A8 RID: 6568
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SmallItemGridModel : ModelBase
{
	// Token: 0x0600BF91 RID: 49041 RVA: 0x002B40BC File Offset: 0x002B22BC
	protected override bool OnInit()
	{
		this.ItemGridNameMaxLength = ConfigCommonParamById.GetIntConfig("ItemGridNameMaxLength").Value;
		this.DefaultQualitySpritePath = UiResourceConfig.Instance.GetResourcePath("SP_QualityVisionB");
		this.ItemGridCoolDownSecond = ConfigCommonParamById.GetIntConfig("ItemGridCoolDownSecond").Value;
		return true;
	}

	// Token: 0x1700100B RID: 4107
	// (get) Token: 0x0600BF92 RID: 49042 RVA: 0x002B410F File Offset: 0x002B230F
	public static SmallItemGridModel Instance
	{
		get
		{
			return SmallItemGridModel._Instance;
		}
	}

	// Token: 0x0600BF93 RID: 49043 RVA: 0x002B4116 File Offset: 0x002B2316
	public static SmallItemGridModel GetOrCreateInstance()
	{
		if (SmallItemGridModel._Instance == null)
		{
			SmallItemGridModel.CreateInstance();
		}
		return SmallItemGridModel._Instance;
	}

	// Token: 0x0600BF94 RID: 49044 RVA: 0x002B412A File Offset: 0x002B232A
	public static bool CreateInstance()
	{
		if (SmallItemGridModel._Instance != null)
		{
			return true;
		}
		SmallItemGridModel._Instance = new SmallItemGridModel();
		return true;
	}

	// Token: 0x0600BF95 RID: 49045 RVA: 0x002B4140 File Offset: 0x002B2340
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BF96 RID: 49046 RVA: 0x002B4142 File Offset: 0x002B2342
	public static void ResetStaticDefaultValue()
	{
		SmallItemGridModel._Instance = null;
	}

	// Token: 0x0600BF97 RID: 49047 RVA: 0x002B414A File Offset: 0x002B234A
	static SmallItemGridModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SmallItemGridModel.CreateStaticDefaultValue), new Action(SmallItemGridModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400562B RID: 22059
	public int ItemGridCoolDownSecond;

	// Token: 0x0400562C RID: 22060
	public int ItemGridNameMaxLength;

	// Token: 0x0400562D RID: 22061
	public string DefaultQualitySpritePath;

	// Token: 0x0400562E RID: 22062
	[Nullable(2)]
	private static SmallItemGridModel _Instance;
}

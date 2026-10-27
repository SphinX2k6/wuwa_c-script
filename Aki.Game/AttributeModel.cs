using System;
using System.Runtime.CompilerServices;

// Token: 0x020016EF RID: 5871
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AttributeModel : ModelBase
{
	// Token: 0x0600A853 RID: 43091 RVA: 0x0025D70C File Offset: 0x0025B90C
	public string GetFormatAttributeValueString(int id, double value, bool isRatio = false)
	{
		if (PropertyIndexConfig.Instance.GetPropertyIndexInfo(id).Value.IsPercent)
		{
			int num = 100;
			return MathUtils.Instance.GetFloatPointFloorString(value / (double)num, 1) + "%";
		}
		if (isRatio)
		{
			int num2 = 100;
			return MathUtils.Instance.GetFloatPointFloorString(value * (double)num2, 1) + "%";
		}
		return Math.Floor(value).ToString();
	}

	// Token: 0x0600A854 RID: 43092 RVA: 0x0025D788 File Offset: 0x0025B988
	public string GetFormatAttributeValueByAddType(double value, int addType)
	{
		if (addType == 1)
		{
			return TipsDataTool.GetPropRatioValue(value, false).ToString() ?? "";
		}
		if (addType == 2)
		{
			return TipsDataTool.GetPropRatioValue(value, true).ToString() + "%";
		}
		if (addType == 3)
		{
			return value.ToString() + "s";
		}
		return value.ToString();
	}

	// Token: 0x17000DF2 RID: 3570
	// (get) Token: 0x0600A855 RID: 43093 RVA: 0x0025D7ED File Offset: 0x0025B9ED
	public static AttributeModel Instance
	{
		get
		{
			return AttributeModel._Instance;
		}
	}

	// Token: 0x0600A856 RID: 43094 RVA: 0x0025D7F4 File Offset: 0x0025B9F4
	public static AttributeModel GetOrCreateInstance()
	{
		if (AttributeModel._Instance == null)
		{
			AttributeModel.CreateInstance();
		}
		return AttributeModel._Instance;
	}

	// Token: 0x0600A857 RID: 43095 RVA: 0x0025D808 File Offset: 0x0025BA08
	public static bool CreateInstance()
	{
		if (AttributeModel._Instance != null)
		{
			return true;
		}
		AttributeModel._Instance = new AttributeModel();
		return true;
	}

	// Token: 0x0600A858 RID: 43096 RVA: 0x0025D81E File Offset: 0x0025BA1E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A859 RID: 43097 RVA: 0x0025D820 File Offset: 0x0025BA20
	public static void ResetStaticDefaultValue()
	{
		AttributeModel._Instance = null;
	}

	// Token: 0x0600A85A RID: 43098 RVA: 0x0025D828 File Offset: 0x0025BA28
	static AttributeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AttributeModel.CreateStaticDefaultValue), new Action(AttributeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004CC7 RID: 19655
	[Nullable(2)]
	private static AttributeModel _Instance;
}

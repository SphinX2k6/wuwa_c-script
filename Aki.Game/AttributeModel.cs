using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BA7 RID: 2983
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AttributeModel : ModelBase
{
	// Token: 0x06007C33 RID: 31795 RVA: 0x00267B2C File Offset: 0x00265D2C
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

	// Token: 0x06007C34 RID: 31796 RVA: 0x00267BA8 File Offset: 0x00265DA8
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

	// Token: 0x17000E13 RID: 3603
	// (get) Token: 0x06007C35 RID: 31797 RVA: 0x00267C0D File Offset: 0x00265E0D
	public static AttributeModel Instance
	{
		get
		{
			return AttributeModel._Instance;
		}
	}

	// Token: 0x06007C36 RID: 31798 RVA: 0x00267C14 File Offset: 0x00265E14
	public static AttributeModel GetOrCreateInstance()
	{
		if (AttributeModel._Instance == null)
		{
			AttributeModel.CreateInstance();
		}
		return AttributeModel._Instance;
	}

	// Token: 0x06007C37 RID: 31799 RVA: 0x00267C28 File Offset: 0x00265E28
	public static bool CreateInstance()
	{
		if (AttributeModel._Instance != null)
		{
			return true;
		}
		AttributeModel._Instance = new AttributeModel();
		return true;
	}

	// Token: 0x06007C38 RID: 31800 RVA: 0x00267C3E File Offset: 0x00265E3E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007C39 RID: 31801 RVA: 0x00267C40 File Offset: 0x00265E40
	public static void ResetStaticDefaultValue()
	{
		AttributeModel._Instance = null;
	}

	// Token: 0x06007C3A RID: 31802 RVA: 0x00267C48 File Offset: 0x00265E48
	static AttributeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AttributeModel.CreateStaticDefaultValue), new Action(AttributeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004D6E RID: 19822
	[Nullable(2)]
	private static AttributeModel _Instance;
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02002890 RID: 10384
[NullableContext(1)]
[Nullable(0)]
public class RoleLevelUpSuccessController : UiControllerBase
{
	// Token: 0x060155FF RID: 87551 RVA: 0x00563608 File Offset: 0x00561808
	public void OpenSuccessAttributeView(ILevelUpSuccessAttributeData data, [Nullable(2)] Action finishCallback = null)
	{
		TOpenViewCallBack finishCallback2 = delegate(bool success, int viewId)
		{
			Action finishCallback3 = finishCallback;
			if (finishCallback3 == null)
			{
				return;
			}
			finishCallback3();
		};
		UiManager.Instance.OpenView(EUiViewName.RoleLevelUpSuccessAttributeView, data, finishCallback2);
	}

	// Token: 0x06015600 RID: 87552 RVA: 0x00563640 File Offset: 0x00561840
	[NullableContext(2)]
	public void OpenSuccessEffectView(ILevelUpSuccessEffectData data = null, Action finishCallback = null)
	{
		ILevelUpSuccessEffectData param = data ?? new LevelUpSuccessEffectData();
		TOpenViewCallBack finishCallback2 = delegate(bool success, int viewId)
		{
			Action finishCallback3 = finishCallback;
			if (finishCallback3 == null)
			{
				return;
			}
			finishCallback3();
		};
		UiManager.Instance.OpenView(EUiViewName.RoleLevelUpSuccessEffectView, param, finishCallback2);
	}

	// Token: 0x06015601 RID: 87553 RVA: 0x00563684 File Offset: 0x00561884
	public static IAttributeInfo ConvertsAttrListScrollDataToAttributeInfo(AttrListScrollData attrData)
	{
		AttributeInfo attributeInfo = new AttributeInfo();
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attrData.Id);
		attributeInfo.Name = propertyIndexInfo.Value.Name;
		attributeInfo.IconPath = propertyIndexInfo.Value.Icon;
		attributeInfo.ShowArrow = new bool?(true);
		attributeInfo.PreText = AttributeModel.Instance.GetFormatAttributeValueString(attrData.Id, attrData.BaseValue, attrData.IsRatio);
		attributeInfo.CurText = AttributeModel.Instance.GetFormatAttributeValueString(attrData.Id, attrData.AddValue, attrData.IsRatio);
		return attributeInfo;
	}

	// Token: 0x17001CBD RID: 7357
	// (get) Token: 0x06015602 RID: 87554 RVA: 0x00563721 File Offset: 0x00561921
	public static RoleLevelUpSuccessController Instance
	{
		get
		{
			return RoleLevelUpSuccessController._Instance;
		}
	}

	// Token: 0x06015603 RID: 87555 RVA: 0x00563728 File Offset: 0x00561928
	public static RoleLevelUpSuccessController GetOrCreateInstance()
	{
		if (RoleLevelUpSuccessController._Instance == null)
		{
			RoleLevelUpSuccessController.CreateInstance();
		}
		return RoleLevelUpSuccessController._Instance;
	}

	// Token: 0x06015604 RID: 87556 RVA: 0x0056373C File Offset: 0x0056193C
	public static bool CreateInstance()
	{
		if (RoleLevelUpSuccessController._Instance != null)
		{
			return true;
		}
		RoleLevelUpSuccessController._Instance = new RoleLevelUpSuccessController();
		return true;
	}

	// Token: 0x06015605 RID: 87557 RVA: 0x00563752 File Offset: 0x00561952
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015606 RID: 87558 RVA: 0x00563754 File Offset: 0x00561954
	public static void ResetStaticDefaultValue()
	{
		RoleLevelUpSuccessController._Instance = null;
	}

	// Token: 0x06015607 RID: 87559 RVA: 0x0056375C File Offset: 0x0056195C
	static RoleLevelUpSuccessController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleLevelUpSuccessController.CreateStaticDefaultValue), new Action(RoleLevelUpSuccessController.ResetStaticDefaultValue));
	}

	// Token: 0x04009FB7 RID: 40887
	[Nullable(2)]
	private static RoleLevelUpSuccessController _Instance;
}

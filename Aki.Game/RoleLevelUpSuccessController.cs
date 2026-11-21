using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02001E0B RID: 7691
[NullableContext(1)]
[Nullable(0)]
public class RoleLevelUpSuccessController : UiControllerBase
{
	// Token: 0x06012FFD RID: 77821 RVA: 0x0058E364 File Offset: 0x0058C564
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

	// Token: 0x06012FFE RID: 77822 RVA: 0x0058E39C File Offset: 0x0058C59C
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

	// Token: 0x06012FFF RID: 77823 RVA: 0x0058E3E0 File Offset: 0x0058C5E0
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

	// Token: 0x17001D15 RID: 7445
	// (get) Token: 0x06013000 RID: 77824 RVA: 0x0058E47D File Offset: 0x0058C67D
	public static RoleLevelUpSuccessController Instance
	{
		get
		{
			return RoleLevelUpSuccessController._Instance;
		}
	}

	// Token: 0x06013001 RID: 77825 RVA: 0x0058E484 File Offset: 0x0058C684
	public static RoleLevelUpSuccessController GetOrCreateInstance()
	{
		if (RoleLevelUpSuccessController._Instance == null)
		{
			RoleLevelUpSuccessController.CreateInstance();
		}
		return RoleLevelUpSuccessController._Instance;
	}

	// Token: 0x06013002 RID: 77826 RVA: 0x0058E498 File Offset: 0x0058C698
	public static bool CreateInstance()
	{
		if (RoleLevelUpSuccessController._Instance != null)
		{
			return true;
		}
		RoleLevelUpSuccessController._Instance = new RoleLevelUpSuccessController();
		return true;
	}

	// Token: 0x06013003 RID: 77827 RVA: 0x0058E4AE File Offset: 0x0058C6AE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013004 RID: 77828 RVA: 0x0058E4B0 File Offset: 0x0058C6B0
	public static void ResetStaticDefaultValue()
	{
		RoleLevelUpSuccessController._Instance = null;
	}

	// Token: 0x06013005 RID: 77829 RVA: 0x0058E4B8 File Offset: 0x0058C6B8
	static RoleLevelUpSuccessController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleLevelUpSuccessController.CreateStaticDefaultValue), new Action(RoleLevelUpSuccessController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A3A0 RID: 41888
	[Nullable(2)]
	private static RoleLevelUpSuccessController _Instance;
}

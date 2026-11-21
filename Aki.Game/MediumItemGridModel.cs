using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000E07 RID: 3591
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MediumItemGridModel : ModelBase
{
	// Token: 0x06009117 RID: 37143 RVA: 0x002B75B4 File Offset: 0x002B57B4
	protected override bool OnInit()
	{
		this.ItemGridCoolDownSecond = ConfigCommonParamById.GetIntConfig("ItemGridCoolDownSecond").Value;
		this.AttackBuffSpritePath = UiResourceConfig.Instance.GetResourcePath("SP_ItemIconAttack");
		this.DefenseBuffSpritePath = UiResourceConfig.Instance.GetResourcePath("SP_ItemIconShield");
		this.RestoreHealthBuffSpritePath = UiResourceConfig.Instance.GetResourcePath("SP_ItemIconHeart");
		this.RechargeBuffSpritePath = UiResourceConfig.Instance.GetResourcePath("SP_ItemIconPhysical");
		this.ResurrectionBuffSpritePath = UiResourceConfig.Instance.GetResourcePath("SP_ItemIconRecover");
		this.ExploreBuffSpritePath = UiResourceConfig.Instance.GetResourcePath("T_Iconpropertyabsorbup_UI");
		return true;
	}

	// Token: 0x06009118 RID: 37144 RVA: 0x002B7658 File Offset: 0x002B5858
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x17000FE6 RID: 4070
	// (get) Token: 0x06009119 RID: 37145 RVA: 0x002B765B File Offset: 0x002B585B
	public static MediumItemGridModel Instance
	{
		get
		{
			return MediumItemGridModel._Instance;
		}
	}

	// Token: 0x0600911A RID: 37146 RVA: 0x002B7662 File Offset: 0x002B5862
	public static MediumItemGridModel GetOrCreateInstance()
	{
		if (MediumItemGridModel._Instance == null)
		{
			MediumItemGridModel.CreateInstance();
		}
		return MediumItemGridModel._Instance;
	}

	// Token: 0x0600911B RID: 37147 RVA: 0x002B7676 File Offset: 0x002B5876
	public static bool CreateInstance()
	{
		if (MediumItemGridModel._Instance != null)
		{
			return true;
		}
		MediumItemGridModel._Instance = new MediumItemGridModel();
		return true;
	}

	// Token: 0x0600911C RID: 37148 RVA: 0x002B768C File Offset: 0x002B588C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600911D RID: 37149 RVA: 0x002B768E File Offset: 0x002B588E
	public static void ResetStaticDefaultValue()
	{
		MediumItemGridModel._Instance = null;
	}

	// Token: 0x0600911E RID: 37150 RVA: 0x002B7696 File Offset: 0x002B5896
	static MediumItemGridModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MediumItemGridModel.CreateStaticDefaultValue), new Action(MediumItemGridModel.ResetStaticDefaultValue));
	}

	// Token: 0x040055FE RID: 22014
	public int ItemGridCoolDownSecond;

	// Token: 0x040055FF RID: 22015
	public string AttackBuffSpritePath;

	// Token: 0x04005600 RID: 22016
	public string DefenseBuffSpritePath;

	// Token: 0x04005601 RID: 22017
	public string RestoreHealthBuffSpritePath;

	// Token: 0x04005602 RID: 22018
	public string RechargeBuffSpritePath;

	// Token: 0x04005603 RID: 22019
	public string ResurrectionBuffSpritePath;

	// Token: 0x04005604 RID: 22020
	public string ExploreBuffSpritePath;

	// Token: 0x04005605 RID: 22021
	[Nullable(2)]
	private static MediumItemGridModel _Instance;
}

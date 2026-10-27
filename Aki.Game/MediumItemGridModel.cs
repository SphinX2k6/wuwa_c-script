using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200194A RID: 6474
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MediumItemGridModel : ModelBase
{
	// Token: 0x0600BD14 RID: 48404 RVA: 0x002AC770 File Offset: 0x002AA970
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

	// Token: 0x0600BD15 RID: 48405 RVA: 0x002AC814 File Offset: 0x002AAA14
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x17000FC2 RID: 4034
	// (get) Token: 0x0600BD16 RID: 48406 RVA: 0x002AC817 File Offset: 0x002AAA17
	public static MediumItemGridModel Instance
	{
		get
		{
			return MediumItemGridModel._Instance;
		}
	}

	// Token: 0x0600BD17 RID: 48407 RVA: 0x002AC81E File Offset: 0x002AAA1E
	public static MediumItemGridModel GetOrCreateInstance()
	{
		if (MediumItemGridModel._Instance == null)
		{
			MediumItemGridModel.CreateInstance();
		}
		return MediumItemGridModel._Instance;
	}

	// Token: 0x0600BD18 RID: 48408 RVA: 0x002AC832 File Offset: 0x002AAA32
	public static bool CreateInstance()
	{
		if (MediumItemGridModel._Instance != null)
		{
			return true;
		}
		MediumItemGridModel._Instance = new MediumItemGridModel();
		return true;
	}

	// Token: 0x0600BD19 RID: 48409 RVA: 0x002AC848 File Offset: 0x002AAA48
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BD1A RID: 48410 RVA: 0x002AC84A File Offset: 0x002AAA4A
	public static void ResetStaticDefaultValue()
	{
		MediumItemGridModel._Instance = null;
	}

	// Token: 0x0600BD1B RID: 48411 RVA: 0x002AC852 File Offset: 0x002AAA52
	static MediumItemGridModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MediumItemGridModel.CreateStaticDefaultValue), new Action(MediumItemGridModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005551 RID: 21841
	public int ItemGridCoolDownSecond;

	// Token: 0x04005552 RID: 21842
	public string AttackBuffSpritePath;

	// Token: 0x04005553 RID: 21843
	public string DefenseBuffSpritePath;

	// Token: 0x04005554 RID: 21844
	public string RestoreHealthBuffSpritePath;

	// Token: 0x04005555 RID: 21845
	public string RechargeBuffSpritePath;

	// Token: 0x04005556 RID: 21846
	public string ResurrectionBuffSpritePath;

	// Token: 0x04005557 RID: 21847
	public string ExploreBuffSpritePath;

	// Token: 0x04005558 RID: 21848
	[Nullable(2)]
	private static MediumItemGridModel _Instance;
}

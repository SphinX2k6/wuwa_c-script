using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x02002C65 RID: 11365
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class UiModelEffectController : ControllerBase
{
	// Token: 0x06017C07 RID: 97287 RVA: 0x00609CC0 File Offset: 0x00607EC0
	public void SetEffectAdditionTimeScaleEnable(bool bEnable, int modelId)
	{
		if (bEnable)
		{
			this.EnabledAdditionTimeScaleModelIdSet.Add(modelId);
		}
		else
		{
			this.EnabledAdditionTimeScaleModelIdSet.Remove(modelId);
		}
		bool enable = this.EnabledAdditionTimeScaleModelIdSet.Count > 0;
		EffectSystem.Instance.SetAdditionTimeScaleEnable(ETimeScaleSourceType.UiModel, enable);
	}

	// Token: 0x17001FDB RID: 8155
	// (get) Token: 0x06017C08 RID: 97288 RVA: 0x00609D08 File Offset: 0x00607F08
	public static UiModelEffectController Instance
	{
		get
		{
			return UiModelEffectController._Instance;
		}
	}

	// Token: 0x06017C09 RID: 97289 RVA: 0x00609D0F File Offset: 0x00607F0F
	public static UiModelEffectController GetOrCreateInstance()
	{
		if (UiModelEffectController._Instance == null)
		{
			UiModelEffectController.CreateInstance();
		}
		return UiModelEffectController._Instance;
	}

	// Token: 0x06017C0A RID: 97290 RVA: 0x00609D23 File Offset: 0x00607F23
	public static bool CreateInstance()
	{
		if (UiModelEffectController._Instance != null)
		{
			return true;
		}
		UiModelEffectController._Instance = new UiModelEffectController();
		return true;
	}

	// Token: 0x06017C0B RID: 97291 RVA: 0x00609D39 File Offset: 0x00607F39
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017C0C RID: 97292 RVA: 0x00609D3B File Offset: 0x00607F3B
	public static void ResetStaticDefaultValue()
	{
		UiModelEffectController._Instance = null;
	}

	// Token: 0x06017C0D RID: 97293 RVA: 0x00609D43 File Offset: 0x00607F43
	static UiModelEffectController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModelEffectController.CreateStaticDefaultValue), new Action(UiModelEffectController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B0D7 RID: 45271
	private readonly HashSet<int> EnabledAdditionTimeScaleModelIdSet = new HashSet<int>();

	// Token: 0x0400B0D8 RID: 45272
	[Nullable(2)]
	private static UiModelEffectController _Instance;
}

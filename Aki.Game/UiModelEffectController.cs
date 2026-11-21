using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x020021BE RID: 8638
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class UiModelEffectController : ControllerBase
{
	// Token: 0x06015479 RID: 87161 RVA: 0x0062F768 File Offset: 0x0062D968
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

	// Token: 0x1700202C RID: 8236
	// (get) Token: 0x0601547A RID: 87162 RVA: 0x0062F7B0 File Offset: 0x0062D9B0
	public static UiModelEffectController Instance
	{
		get
		{
			return UiModelEffectController._Instance;
		}
	}

	// Token: 0x0601547B RID: 87163 RVA: 0x0062F7B7 File Offset: 0x0062D9B7
	public static UiModelEffectController GetOrCreateInstance()
	{
		if (UiModelEffectController._Instance == null)
		{
			UiModelEffectController.CreateInstance();
		}
		return UiModelEffectController._Instance;
	}

	// Token: 0x0601547C RID: 87164 RVA: 0x0062F7CB File Offset: 0x0062D9CB
	public static bool CreateInstance()
	{
		if (UiModelEffectController._Instance != null)
		{
			return true;
		}
		UiModelEffectController._Instance = new UiModelEffectController();
		return true;
	}

	// Token: 0x0601547D RID: 87165 RVA: 0x0062F7E1 File Offset: 0x0062D9E1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601547E RID: 87166 RVA: 0x0062F7E3 File Offset: 0x0062D9E3
	public static void ResetStaticDefaultValue()
	{
		UiModelEffectController._Instance = null;
	}

	// Token: 0x0601547F RID: 87167 RVA: 0x0062F7EB File Offset: 0x0062D9EB
	static UiModelEffectController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModelEffectController.CreateStaticDefaultValue), new Action(UiModelEffectController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B442 RID: 46146
	private readonly HashSet<int> EnabledAdditionTimeScaleModelIdSet = new HashSet<int>();

	// Token: 0x0400B443 RID: 46147
	[Nullable(2)]
	private static UiModelEffectController _Instance;
}

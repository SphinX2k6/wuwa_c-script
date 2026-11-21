using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200153C RID: 5436
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LevelUpModel : ModelBase
{
	// Token: 0x0600D9B7 RID: 55735 RVA: 0x0040846C File Offset: 0x0040666C
	public void SetExpChange(int currentLevel, int currentExp, int lastExp, int maxExp, int differenceExp)
	{
		ILevelUpViewViedData data = new LevelUpViewViedData
		{
			AddExp = true,
			PreLevel = currentLevel,
			PreExp = lastExp,
			CurLevel = currentLevel,
			CurExp = currentExp
		};
		this.TryOpenLevelUpView(data);
	}

	// Token: 0x0600D9B8 RID: 55736 RVA: 0x004084AC File Offset: 0x004066AC
	public void SetLevelUp(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp, int differenceExp)
	{
		ILevelUpViewViedData data = new LevelUpViewViedData
		{
			AddExp = (differenceExp > 0),
			PreLevel = lastLevel,
			PreExp = lastExp,
			CurLevel = currentLevel,
			CurExp = currentExp
		};
		this.TryOpenLevelUpView(data);
	}

	// Token: 0x0600D9B9 RID: 55737 RVA: 0x004084F0 File Offset: 0x004066F0
	public void SetShowLevelOnly(int currentLevel)
	{
		int valueOrDefault = FunctionModel.Instance.GetPlayerExp().GetValueOrDefault();
		ILevelUpViewViedData data = new LevelUpViewViedData
		{
			AddExp = false,
			PreLevel = currentLevel,
			PreExp = valueOrDefault,
			CurLevel = currentLevel,
			CurExp = valueOrDefault
		};
		this.TryOpenLevelUpView(data);
	}

	// Token: 0x0600D9BA RID: 55738 RVA: 0x00408540 File Offset: 0x00406740
	private void RefreshCacheData(ILevelUpViewViedData data)
	{
		if (this.CacheData == null)
		{
			return;
		}
		if (data.AddExp)
		{
			this.CacheData.AddExp = data.AddExp;
		}
		if (data.PreLevel < this.CacheData.PreLevel)
		{
			this.CacheData.PreLevel = data.PreLevel;
			this.CacheData.PreExp = data.PreExp;
		}
		else if (data.PreLevel == this.CacheData.PreLevel && data.PreExp <= this.CacheData.PreExp)
		{
			this.CacheData.PreExp = data.PreExp;
		}
		if (data.CurLevel > this.CacheData.CurLevel)
		{
			this.CacheData.CurLevel = data.CurLevel;
			this.CacheData.CurExp = data.CurExp;
			return;
		}
		if (data.CurLevel == this.CacheData.CurLevel && data.CurExp >= this.CacheData.CurExp)
		{
			this.CacheData.CurExp = data.CurExp;
		}
	}

	// Token: 0x0600D9BB RID: 55739 RVA: 0x0040864C File Offset: 0x0040684C
	private void TryOpenLevelUpView(ILevelUpViewViedData data)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.LevelUpView) && this.CacheData != null)
		{
			this.RefreshCacheData(data);
			return;
		}
		this.CacheData = data;
		if (UiManager.Instance.GetViewByName(EUiViewName.LevelUpView) == null)
		{
			UiManager.Instance.OpenView(EUiViewName.LevelUpView, this.CacheData, null);
		}
	}

	// Token: 0x0600D9BC RID: 55740 RVA: 0x004086A8 File Offset: 0x004068A8
	public ILevelUpViewViedData GetCacheData()
	{
		return this.CacheData;
	}

	// Token: 0x0600D9BD RID: 55741 RVA: 0x004086B0 File Offset: 0x004068B0
	public void ClearCacheData()
	{
		this.CacheData = null;
	}

	// Token: 0x17001455 RID: 5205
	// (get) Token: 0x0600D9BE RID: 55742 RVA: 0x004086B9 File Offset: 0x004068B9
	public static LevelUpModel Instance
	{
		get
		{
			return LevelUpModel._Instance;
		}
	}

	// Token: 0x0600D9BF RID: 55743 RVA: 0x004086C0 File Offset: 0x004068C0
	public static LevelUpModel GetOrCreateInstance()
	{
		if (LevelUpModel._Instance == null)
		{
			LevelUpModel.CreateInstance();
		}
		return LevelUpModel._Instance;
	}

	// Token: 0x0600D9C0 RID: 55744 RVA: 0x004086D4 File Offset: 0x004068D4
	public static bool CreateInstance()
	{
		if (LevelUpModel._Instance != null)
		{
			return true;
		}
		LevelUpModel._Instance = new LevelUpModel();
		return true;
	}

	// Token: 0x0600D9C1 RID: 55745 RVA: 0x004086EA File Offset: 0x004068EA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D9C2 RID: 55746 RVA: 0x004086EC File Offset: 0x004068EC
	public static void ResetStaticDefaultValue()
	{
		LevelUpModel._Instance = null;
	}

	// Token: 0x0600D9C3 RID: 55747 RVA: 0x004086F4 File Offset: 0x004068F4
	static LevelUpModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelUpModel.CreateStaticDefaultValue), new Action(LevelUpModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400798F RID: 31119
	public bool CanBreakTipsShowFlag = true;

	// Token: 0x04007990 RID: 31120
	[Nullable(2)]
	private ILevelUpViewViedData CacheData;

	// Token: 0x04007991 RID: 31121
	[Nullable(2)]
	private static LevelUpModel _Instance;
}

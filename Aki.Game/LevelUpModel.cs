using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002069 RID: 8297
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LevelUpModel : ModelBase
{
	// Token: 0x0601054F RID: 66895 RVA: 0x003FC024 File Offset: 0x003FA224
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

	// Token: 0x06010550 RID: 66896 RVA: 0x003FC064 File Offset: 0x003FA264
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

	// Token: 0x06010551 RID: 66897 RVA: 0x003FC0A8 File Offset: 0x003FA2A8
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

	// Token: 0x06010552 RID: 66898 RVA: 0x003FC0F8 File Offset: 0x003FA2F8
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

	// Token: 0x06010553 RID: 66899 RVA: 0x003FC204 File Offset: 0x003FA404
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

	// Token: 0x06010554 RID: 66900 RVA: 0x003FC260 File Offset: 0x003FA460
	public ILevelUpViewViedData GetCacheData()
	{
		return this.CacheData;
	}

	// Token: 0x06010555 RID: 66901 RVA: 0x003FC268 File Offset: 0x003FA468
	public void ClearCacheData()
	{
		this.CacheData = null;
	}

	// Token: 0x17001428 RID: 5160
	// (get) Token: 0x06010556 RID: 66902 RVA: 0x003FC271 File Offset: 0x003FA471
	public static LevelUpModel Instance
	{
		get
		{
			return LevelUpModel._Instance;
		}
	}

	// Token: 0x06010557 RID: 66903 RVA: 0x003FC278 File Offset: 0x003FA478
	public static LevelUpModel GetOrCreateInstance()
	{
		if (LevelUpModel._Instance == null)
		{
			LevelUpModel.CreateInstance();
		}
		return LevelUpModel._Instance;
	}

	// Token: 0x06010558 RID: 66904 RVA: 0x003FC28C File Offset: 0x003FA48C
	public static bool CreateInstance()
	{
		if (LevelUpModel._Instance != null)
		{
			return true;
		}
		LevelUpModel._Instance = new LevelUpModel();
		return true;
	}

	// Token: 0x06010559 RID: 66905 RVA: 0x003FC2A2 File Offset: 0x003FA4A2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601055A RID: 66906 RVA: 0x003FC2A4 File Offset: 0x003FA4A4
	public static void ResetStaticDefaultValue()
	{
		LevelUpModel._Instance = null;
	}

	// Token: 0x0601055B RID: 66907 RVA: 0x003FC2AC File Offset: 0x003FA4AC
	static LevelUpModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelUpModel.CreateStaticDefaultValue), new Action(LevelUpModel.ResetStaticDefaultValue));
	}

	// Token: 0x040078A6 RID: 30886
	public bool CanBreakTipsShowFlag = true;

	// Token: 0x040078A7 RID: 30887
	[Nullable(2)]
	private ILevelUpViewViedData CacheData;

	// Token: 0x040078A8 RID: 30888
	[Nullable(2)]
	private static LevelUpModel _Instance;
}

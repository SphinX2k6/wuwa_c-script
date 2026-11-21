using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x02001FBC RID: 8124
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class CalabashSkinModel : ModelBase
{
	// Token: 0x0601428B RID: 82571 RVA: 0x005E2251 File Offset: 0x005E0451
	protected override bool OnClear()
	{
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.CalabashSkinRedDot);
		return true;
	}

	// Token: 0x0601428C RID: 82572 RVA: 0x005E2264 File Offset: 0x005E0464
	private bool TryAddCalabashSkinRedDot(int configId)
	{
		if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.CalabashSkinRedDot, configId))
		{
			return false;
		}
		NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.CalabashSkinRedDot, configId);
		int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
		if (curSelectMainRoleId != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.RoleSkinRedDotRefresh, curSelectMainRoleId.Value);
			EventSystem.Instance.Emit(EEventName.HuluSkinRedDotRefresh);
		}
		return true;
	}

	// Token: 0x0601428D RID: 82573 RVA: 0x005E22CC File Offset: 0x005E04CC
	private void SetCurrentEquippedSkinId(int skinId)
	{
		this.CurrentEquippedSkinId = skinId;
	}

	// Token: 0x0601428E RID: 82574 RVA: 0x005E22D8 File Offset: 0x005E04D8
	private void SetUnLockSkinData(int[] skinIdList)
	{
		this.UnLockSkinSet.Clear();
		foreach (int item in skinIdList)
		{
			this.UnLockSkinSet.Add(item);
		}
	}

	// Token: 0x0601428F RID: 82575 RVA: 0x005E2314 File Offset: 0x005E0514
	public void RemoveCalabashSkinRedDot(int configId)
	{
		NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.CalabashSkinRedDot, configId);
		int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
		if (curSelectMainRoleId != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.RoleSkinRedDotRefresh, curSelectMainRoleId.Value);
			EventSystem.Instance.Emit(EEventName.HuluSkinRedDotRefresh);
		}
	}

	// Token: 0x06014290 RID: 82576 RVA: 0x005E236A File Offset: 0x005E056A
	public int GetCurrentEquipSkinId()
	{
		return this.CurrentEquippedSkinId;
	}

	// Token: 0x06014291 RID: 82577 RVA: 0x005E2372 File Offset: 0x005E0572
	public int GetSkinCountById(int skinId)
	{
		return (this.UnLockSkinSet.Contains(skinId) > false) ? 1 : 0;
	}

	// Token: 0x06014292 RID: 82578 RVA: 0x005E2384 File Offset: 0x005E0584
	public unsafe void NotifyCalabashSkinData(int equipSkinId, int[] skinIdList)
	{
		this.SetCurrentEquippedSkinId(equipSkinId);
		this.SetUnLockSkinData(skinIdList);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CalabashSkin;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "葫芦皮肤全量推送";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("equipSkinId", equipSkinId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skinIdList", skinIdList);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06014293 RID: 82579 RVA: 0x005E23FC File Offset: 0x005E05FC
	public void NotifyAddUnlockSkinData(int[] skinIdList)
	{
		foreach (int num in skinIdList)
		{
			this.UnLockSkinSet.Add(num);
			this.TryAddCalabashSkinRedDot(num);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CalabashSkin;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "葫芦皮肤增量推送";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skinIdList", skinIdList);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06014294 RID: 82580 RVA: 0x005E245C File Offset: 0x005E065C
	public void NotifyCurrentEquippedSkinId(int skinId)
	{
		this.SetCurrentEquippedSkinId(skinId);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CalabashSkin;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "葫芦皮肤装备";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skinId", skinId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06014295 RID: 82581 RVA: 0x005E24A0 File Offset: 0x005E06A0
	public bool CheckCalabashSkinHasRedDotByRoleId(int roleId)
	{
		int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
		return (roleId == curSelectMainRoleId.GetValueOrDefault() & curSelectMainRoleId != null) && this.CheckCalabashSkinHasRedDot();
	}

	// Token: 0x06014296 RID: 82582 RVA: 0x005E24D4 File Offset: 0x005E06D4
	public bool CheckCalabashSkinHasRedDot()
	{
		foreach (int value in this.UnLockSkinSet)
		{
			if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.CalabashSkinRedDot, value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x17001E39 RID: 7737
	// (get) Token: 0x06014297 RID: 82583 RVA: 0x005E2538 File Offset: 0x005E0738
	public static CalabashSkinModel Instance
	{
		get
		{
			return CalabashSkinModel._Instance;
		}
	}

	// Token: 0x06014298 RID: 82584 RVA: 0x005E253F File Offset: 0x005E073F
	public static CalabashSkinModel GetOrCreateInstance()
	{
		if (CalabashSkinModel._Instance == null)
		{
			CalabashSkinModel.CreateInstance();
		}
		return CalabashSkinModel._Instance;
	}

	// Token: 0x06014299 RID: 82585 RVA: 0x005E2553 File Offset: 0x005E0753
	public static bool CreateInstance()
	{
		if (CalabashSkinModel._Instance != null)
		{
			return true;
		}
		CalabashSkinModel._Instance = new CalabashSkinModel();
		return true;
	}

	// Token: 0x0601429A RID: 82586 RVA: 0x005E2569 File Offset: 0x005E0769
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601429B RID: 82587 RVA: 0x005E256B File Offset: 0x005E076B
	public static void ResetStaticDefaultValue()
	{
		CalabashSkinModel._Instance = null;
	}

	// Token: 0x0601429C RID: 82588 RVA: 0x005E2573 File Offset: 0x005E0773
	static CalabashSkinModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CalabashSkinModel.CreateStaticDefaultValue), new Action(CalabashSkinModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400AB4D RID: 43853
	private readonly HashSet<int> UnLockSkinSet = new HashSet<int>();

	// Token: 0x0400AB4E RID: 43854
	private int CurrentEquippedSkinId;

	// Token: 0x0400AB4F RID: 43855
	[Nullable(2)]
	private static CalabashSkinModel _Instance;
}

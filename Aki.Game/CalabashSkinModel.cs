using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x02002A41 RID: 10817
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class CalabashSkinModel : ModelBase
{
	// Token: 0x0601686A RID: 92266 RVA: 0x005B60E9 File Offset: 0x005B42E9
	protected override bool OnClear()
	{
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.CalabashSkinRedDot);
		return true;
	}

	// Token: 0x0601686B RID: 92267 RVA: 0x005B60FC File Offset: 0x005B42FC
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

	// Token: 0x0601686C RID: 92268 RVA: 0x005B6164 File Offset: 0x005B4364
	private void SetCurrentEquippedSkinId(int skinId)
	{
		this.CurrentEquippedSkinId = skinId;
	}

	// Token: 0x0601686D RID: 92269 RVA: 0x005B6170 File Offset: 0x005B4370
	private void SetUnLockSkinData(int[] skinIdList)
	{
		this.UnLockSkinSet.Clear();
		foreach (int item in skinIdList)
		{
			this.UnLockSkinSet.Add(item);
		}
	}

	// Token: 0x0601686E RID: 92270 RVA: 0x005B61AC File Offset: 0x005B43AC
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

	// Token: 0x0601686F RID: 92271 RVA: 0x005B6202 File Offset: 0x005B4402
	public int GetCurrentEquipSkinId()
	{
		return this.CurrentEquippedSkinId;
	}

	// Token: 0x06016870 RID: 92272 RVA: 0x005B620A File Offset: 0x005B440A
	public int GetSkinCountById(int skinId)
	{
		return (this.UnLockSkinSet.Contains(skinId) > false) ? 1 : 0;
	}

	// Token: 0x06016871 RID: 92273 RVA: 0x005B621C File Offset: 0x005B441C
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

	// Token: 0x06016872 RID: 92274 RVA: 0x005B6294 File Offset: 0x005B4494
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

	// Token: 0x06016873 RID: 92275 RVA: 0x005B62F4 File Offset: 0x005B44F4
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

	// Token: 0x06016874 RID: 92276 RVA: 0x005B6338 File Offset: 0x005B4538
	public bool CheckCalabashSkinHasRedDotByRoleId(int roleId)
	{
		int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
		return (roleId == curSelectMainRoleId.GetValueOrDefault() & curSelectMainRoleId != null) && this.CheckCalabashSkinHasRedDot();
	}

	// Token: 0x06016875 RID: 92277 RVA: 0x005B636C File Offset: 0x005B456C
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

	// Token: 0x17001DE1 RID: 7649
	// (get) Token: 0x06016876 RID: 92278 RVA: 0x005B63D0 File Offset: 0x005B45D0
	public static CalabashSkinModel Instance
	{
		get
		{
			return CalabashSkinModel._Instance;
		}
	}

	// Token: 0x06016877 RID: 92279 RVA: 0x005B63D7 File Offset: 0x005B45D7
	public static CalabashSkinModel GetOrCreateInstance()
	{
		if (CalabashSkinModel._Instance == null)
		{
			CalabashSkinModel.CreateInstance();
		}
		return CalabashSkinModel._Instance;
	}

	// Token: 0x06016878 RID: 92280 RVA: 0x005B63EB File Offset: 0x005B45EB
	public static bool CreateInstance()
	{
		if (CalabashSkinModel._Instance != null)
		{
			return true;
		}
		CalabashSkinModel._Instance = new CalabashSkinModel();
		return true;
	}

	// Token: 0x06016879 RID: 92281 RVA: 0x005B6401 File Offset: 0x005B4601
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601687A RID: 92282 RVA: 0x005B6403 File Offset: 0x005B4603
	public static void ResetStaticDefaultValue()
	{
		CalabashSkinModel._Instance = null;
	}

	// Token: 0x0601687B RID: 92283 RVA: 0x005B640B File Offset: 0x005B460B
	static CalabashSkinModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CalabashSkinModel.CreateStaticDefaultValue), new Action(CalabashSkinModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A749 RID: 42825
	private readonly HashSet<int> UnLockSkinSet = new HashSet<int>();

	// Token: 0x0400A74A RID: 42826
	private int CurrentEquippedSkinId;

	// Token: 0x0400A74B RID: 42827
	[Nullable(2)]
	private static CalabashSkinModel _Instance;
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001521 RID: 5409
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class KuroFastCollisionController : ControllerBase
{
	// Token: 0x0600D86B RID: 55403 RVA: 0x00402DC8 File Offset: 0x00400FC8
	[return: Nullable(2)]
	public unsafe UKuroFastCollisionAlgorithm CreateAlgorithm(UClass algorithmClass, bool tickEnabled)
	{
		UKuroFastCollisionSubsystem kfcSubsystem = this.GetKfcSubsystem();
		UKuroFastCollisionAlgorithm ukuroFastCollisionAlgorithm = (kfcSubsystem != null) ? kfcSubsystem.CreateAlgorithm(algorithmClass, tickEnabled) : null;
		if (ukuroFastCollisionAlgorithm != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CombatInfo;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "KFC算法创建成功";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("algorithmClass", algorithmClass);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tickEnabled", tickEnabled);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return ukuroFastCollisionAlgorithm;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.CombatInfo;
		ELogAuthor author2 = ELogAuthor.HXY;
		string message2 = "KFC算法创建失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("algorithmClass", algorithmClass);
		instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return ukuroFastCollisionAlgorithm;
	}

	// Token: 0x0600D86C RID: 55404 RVA: 0x00402E78 File Offset: 0x00401078
	[NullableContext(2)]
	public void DestroyAlgorithm(UKuroFastCollisionAlgorithm algorithm)
	{
		UKuroFastCollisionSubsystem kfcSubsystem = this.GetKfcSubsystem();
		if (kfcSubsystem != null)
		{
			kfcSubsystem.DestroyAlgorithm(algorithm);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CombatInfo;
		ELogAuthor author = ELogAuthor.HXY;
		string message = "KFC算法已销毁";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("algorithmClass", algorithm);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600D86D RID: 55405 RVA: 0x00402EC1 File Offset: 0x004010C1
	[NullableContext(2)]
	private UKuroFastCollisionSubsystem GetKfcSubsystem()
	{
		return UKuroFastCollisionSubsystem.Get(GlobalData.World);
	}

	// Token: 0x1700141F RID: 5151
	// (get) Token: 0x0600D86E RID: 55406 RVA: 0x00402ECD File Offset: 0x004010CD
	public static KuroFastCollisionController Instance
	{
		get
		{
			return KuroFastCollisionController._Instance;
		}
	}

	// Token: 0x0600D86F RID: 55407 RVA: 0x00402ED4 File Offset: 0x004010D4
	public static KuroFastCollisionController GetOrCreateInstance()
	{
		if (KuroFastCollisionController._Instance == null)
		{
			KuroFastCollisionController.CreateInstance();
		}
		return KuroFastCollisionController._Instance;
	}

	// Token: 0x0600D870 RID: 55408 RVA: 0x00402EE8 File Offset: 0x004010E8
	public static bool CreateInstance()
	{
		if (KuroFastCollisionController._Instance != null)
		{
			return true;
		}
		KuroFastCollisionController._Instance = new KuroFastCollisionController();
		return true;
	}

	// Token: 0x0600D871 RID: 55409 RVA: 0x00402EFE File Offset: 0x004010FE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D872 RID: 55410 RVA: 0x00402F00 File Offset: 0x00401100
	public static void ResetStaticDefaultValue()
	{
		KuroFastCollisionController._Instance = null;
	}

	// Token: 0x0600D873 RID: 55411 RVA: 0x00402F08 File Offset: 0x00401108
	static KuroFastCollisionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroFastCollisionController.CreateStaticDefaultValue), new Action(KuroFastCollisionController.ResetStaticDefaultValue));
	}

	// Token: 0x04007917 RID: 30999
	[Nullable(2)]
	private static KuroFastCollisionController _Instance;
}

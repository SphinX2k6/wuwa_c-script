using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200204E RID: 8270
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class KuroFastCollisionController : ControllerBase
{
	// Token: 0x06010403 RID: 66563 RVA: 0x003F67FC File Offset: 0x003F49FC
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

	// Token: 0x06010404 RID: 66564 RVA: 0x003F68AC File Offset: 0x003F4AAC
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

	// Token: 0x06010405 RID: 66565 RVA: 0x003F68F5 File Offset: 0x003F4AF5
	[NullableContext(2)]
	private UKuroFastCollisionSubsystem GetKfcSubsystem()
	{
		return UKuroFastCollisionSubsystem.Get(GlobalData.World);
	}

	// Token: 0x170013F2 RID: 5106
	// (get) Token: 0x06010406 RID: 66566 RVA: 0x003F6901 File Offset: 0x003F4B01
	public static KuroFastCollisionController Instance
	{
		get
		{
			return KuroFastCollisionController._Instance;
		}
	}

	// Token: 0x06010407 RID: 66567 RVA: 0x003F6908 File Offset: 0x003F4B08
	public static KuroFastCollisionController GetOrCreateInstance()
	{
		if (KuroFastCollisionController._Instance == null)
		{
			KuroFastCollisionController.CreateInstance();
		}
		return KuroFastCollisionController._Instance;
	}

	// Token: 0x06010408 RID: 66568 RVA: 0x003F691C File Offset: 0x003F4B1C
	public static bool CreateInstance()
	{
		if (KuroFastCollisionController._Instance != null)
		{
			return true;
		}
		KuroFastCollisionController._Instance = new KuroFastCollisionController();
		return true;
	}

	// Token: 0x06010409 RID: 66569 RVA: 0x003F6932 File Offset: 0x003F4B32
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601040A RID: 66570 RVA: 0x003F6934 File Offset: 0x003F4B34
	public static void ResetStaticDefaultValue()
	{
		KuroFastCollisionController._Instance = null;
	}

	// Token: 0x0601040B RID: 66571 RVA: 0x003F693C File Offset: 0x003F4B3C
	static KuroFastCollisionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroFastCollisionController.CreateStaticDefaultValue), new Action(KuroFastCollisionController.ResetStaticDefaultValue));
	}

	// Token: 0x0400782E RID: 30766
	[Nullable(2)]
	private static KuroFastCollisionController _Instance;
}

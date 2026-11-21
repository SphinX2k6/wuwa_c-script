using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity
{
	// Token: 0x0200588B RID: 22667
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityGameplayEntitySystem
	{
		// Token: 0x06037DA7 RID: 228775 RVA: 0x00F9F658 File Offset: 0x00F9D858
		public static ActivityGameplayEntity CreateEntity<TData>(EActivityEntityKind kind, TData data = default(TData))
		{
			IActivityEntityComposition activityEntityComposition;
			if (!ActivityGameplayEntityDefine.GetActivityEntityComposeMap().TryGetValue(kind, out activityEntityComposition))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "创建Entity失败：未注册的实体种类";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("kind", kind);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			ActivityGameplayEntity activityGameplayEntity = new ActivityGameplayEntity();
			foreach (Type ctor in activityEntityComposition.Components)
			{
				activityGameplayEntity.AddComponent(ctor, data);
			}
			activityGameplayEntity.Init();
			return activityGameplayEntity;
		}

		// Token: 0x06037DA8 RID: 228776 RVA: 0x00F9F700 File Offset: 0x00F9D900
		public static void DestroyEntity(ActivityGameplayEntity entity)
		{
			if (entity == null)
			{
				return;
			}
			entity.End();
		}

		// Token: 0x06037DA9 RID: 228777 RVA: 0x00F9F70C File Offset: 0x00F9D90C
		[NullableContext(1)]
		public unsafe static void CreateEntityReadyPromise(string reason)
		{
			if (ActivityGameplayEntitySystem.EntityReadyPromise != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[ActivityGameplayEntitySystem] 重复调用 CreateEntityReadyPromise";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("新Reason", reason);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("旧Reason", ActivityGameplayEntitySystem.EntityReadyReason);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			ActivityGameplayEntitySystem.EntityReadyPromise = new CustomPromise<bool>();
			ActivityGameplayEntitySystem.EntityReadyReason = reason;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.WHJ;
			string message2 = "[ActivityGameplayEntitySystem] 创建 EntityReadyPromise";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06037DAA RID: 228778 RVA: 0x00F9F7AF File Offset: 0x00F9D9AF
		public static CustomPromise<bool> WaitEntityReady()
		{
			return ActivityGameplayEntitySystem.EntityReadyPromise;
		}

		// Token: 0x06037DAB RID: 228779 RVA: 0x00F9F7B8 File Offset: 0x00F9D9B8
		public unsafe static void FinishEntityReadyPromise(bool result = true)
		{
			if (ActivityGameplayEntitySystem.EntityReadyPromise == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "[ActivityGameplayEntitySystem] 完成 EntityReadyPromise";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", ActivityGameplayEntitySystem.EntityReadyReason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Result", result);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			ActivityGameplayEntitySystem.EntityReadyPromise.SetResult(result);
			ActivityGameplayEntitySystem.EntityReadyPromise = null;
			ActivityGameplayEntitySystem.EntityReadyReason = null;
		}

		// Token: 0x0401D7B7 RID: 120759
		[StaticVariableRuleIgnore]
		private static CustomPromise<bool> EntityReadyPromise;

		// Token: 0x0401D7B8 RID: 120760
		[StaticVariableRuleIgnore]
		private static string EntityReadyReason;
	}
}

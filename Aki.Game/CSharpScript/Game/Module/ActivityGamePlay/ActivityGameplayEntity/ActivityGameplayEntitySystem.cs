using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity
{
	// Token: 0x0200693A RID: 26938
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityGameplayEntitySystem
	{
		// Token: 0x0604324A RID: 275018 RVA: 0x0105DFE8 File Offset: 0x0105C1E8
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

		// Token: 0x0604324B RID: 275019 RVA: 0x0105E090 File Offset: 0x0105C290
		public static void DestroyEntity(ActivityGameplayEntity entity)
		{
			if (entity == null)
			{
				return;
			}
			entity.End();
		}

		// Token: 0x0604324C RID: 275020 RVA: 0x0105E09C File Offset: 0x0105C29C
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

		// Token: 0x0604324D RID: 275021 RVA: 0x0105E13F File Offset: 0x0105C33F
		public static CustomPromise<bool> WaitEntityReady()
		{
			return ActivityGameplayEntitySystem.EntityReadyPromise;
		}

		// Token: 0x0604324E RID: 275022 RVA: 0x0105E148 File Offset: 0x0105C348
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

		// Token: 0x04022F5A RID: 143194
		[StaticVariableRuleIgnore]
		private static CustomPromise<bool> EntityReadyPromise;

		// Token: 0x04022F5B RID: 143195
		[StaticVariableRuleIgnore]
		private static string EntityReadyReason;
	}
}

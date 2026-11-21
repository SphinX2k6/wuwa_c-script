using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity
{
	// Token: 0x02005886 RID: 22662
	public class ActivityGameplayEntity
	{
		// Token: 0x06037D98 RID: 228760 RVA: 0x00F9F038 File Offset: 0x00F9D238
		public void Init()
		{
			if (this.IsInit)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "Entity重复执行Init";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entity", base.GetType().Name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.IsInit = true;
			foreach (ActivityGameplayComponentBase activityGameplayComponentBase in this.Components)
			{
				activityGameplayComponentBase.Init();
			}
		}

		// Token: 0x06037D99 RID: 228761 RVA: 0x00F9F0CC File Offset: 0x00F9D2CC
		public void Tick(float deltaTime)
		{
			if (!this.IsInit || this.IsEnd)
			{
				return;
			}
			foreach (ActivityGameplayComponentBase activityGameplayComponentBase in this.Components)
			{
				activityGameplayComponentBase.Tick(deltaTime);
			}
		}

		// Token: 0x06037D9A RID: 228762 RVA: 0x00F9F130 File Offset: 0x00F9D330
		public void End()
		{
			if (this.IsEnd)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "Entity重复执行End";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entity", base.GetType().Name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.IsEnd = true;
			for (int i = this.Components.Count - 1; i >= 0; i--)
			{
				this.Components[i].End();
			}
			this.Components.Clear();
			this.ComponentMap.Clear();
		}

		// Token: 0x06037D9B RID: 228763 RVA: 0x00F9F1C0 File Offset: 0x00F9D3C0
		[NullableContext(1)]
		public unsafe void AddComponent(Type ctor, [Nullable(2)] object args = null)
		{
			if (this.IsInit)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "实体已 Init，不能再添加组件";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("component", ctor.Name);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			Type[] componentDependencies = ActivityGameplayComponentConstant.GetComponentDependencies(ctor);
			if (componentDependencies != null)
			{
				foreach (Type type in componentDependencies)
				{
					if (!this.ComponentMap.ContainsKey(type))
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Entity;
						ELogAuthor author2 = ELogAuthor.WHJ;
						string message2 = "添加组件检查依赖失败";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("component", ctor.Name);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("dependence", type.Name);
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
						return;
					}
				}
			}
			Type type2 = ctor;
			while (type2 != null && type2 != typeof(ActivityGameplayComponentBase) && (!type2.IsGenericType || !(type2.GetGenericTypeDefinition() == typeof(ActivityGameplayComponentBase<>))))
			{
				ActivityGameplayComponentBase activityGameplayComponentBase;
				if (this.ComponentMap.TryGetValue(type2, out activityGameplayComponentBase))
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Entity;
					ELogAuthor author3 = ELogAuthor.WHJ;
					string message3 = "添加组件失败：与已有组件在同一继承链上冲突";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("AddComponent", ctor.Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("ExistComponent", activityGameplayComponentBase.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("ConflictSlot", type2.Name);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
					return;
				}
				type2 = type2.BaseType;
			}
			ActivityGameplayComponentBase activityGameplayComponentBase2 = (ActivityGameplayComponentBase)Activator.CreateInstance(ctor);
			activityGameplayComponentBase2.Create(this, args);
			this.Components.Add(activityGameplayComponentBase2);
			type2 = ctor;
			while (type2 != null && type2 != typeof(ActivityGameplayComponentBase) && (!type2.IsGenericType || !(type2.GetGenericTypeDefinition() == typeof(ActivityGameplayComponentBase<>))))
			{
				this.ComponentMap[type2] = activityGameplayComponentBase2;
				type2 = type2.BaseType;
			}
		}

		// Token: 0x06037D9C RID: 228764 RVA: 0x00F9F474 File Offset: 0x00F9D674
		[return: Nullable(2)]
		public T GetComponent<T>() where T : ActivityGameplayComponentBase
		{
			ActivityGameplayComponentBase activityGameplayComponentBase;
			if (!this.ComponentMap.TryGetValue(typeof(T), out activityGameplayComponentBase))
			{
				return default(T);
			}
			return (T)((object)activityGameplayComponentBase);
		}

		// Token: 0x06037D9D RID: 228765 RVA: 0x00F9F4AC File Offset: 0x00F9D6AC
		[return: Nullable(2)]
		public unsafe T CheckGetComponent<T>() where T : ActivityGameplayComponentBase
		{
			T component = this.GetComponent<T>();
			if (component == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "获取组件失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entity", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("component", typeof(T).Name);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return component;
		}

		// Token: 0x17006B30 RID: 27440
		// (get) Token: 0x06037D9E RID: 228766 RVA: 0x00F9F534 File Offset: 0x00F9D734
		public bool NeedTick
		{
			get
			{
				using (List<ActivityGameplayComponentBase>.Enumerator enumerator = this.Components.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.NeedTick)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x0401D7AF RID: 120751
		[Nullable(1)]
		private readonly List<ActivityGameplayComponentBase> Components = new List<ActivityGameplayComponentBase>();

		// Token: 0x0401D7B0 RID: 120752
		[Nullable(1)]
		private readonly Dictionary<Type, ActivityGameplayComponentBase> ComponentMap = new Dictionary<Type, ActivityGameplayComponentBase>();

		// Token: 0x0401D7B1 RID: 120753
		private bool IsInit;

		// Token: 0x0401D7B2 RID: 120754
		private bool IsEnd;
	}
}

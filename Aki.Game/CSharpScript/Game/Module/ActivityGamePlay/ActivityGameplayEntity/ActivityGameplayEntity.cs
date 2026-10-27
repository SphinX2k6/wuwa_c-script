using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity
{
	// Token: 0x02006935 RID: 26933
	public class ActivityGameplayEntity
	{
		// Token: 0x0604323B RID: 275003 RVA: 0x0105D98C File Offset: 0x0105BB8C
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

		// Token: 0x0604323C RID: 275004 RVA: 0x0105DA20 File Offset: 0x0105BC20
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

		// Token: 0x0604323D RID: 275005 RVA: 0x0105DA84 File Offset: 0x0105BC84
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

		// Token: 0x0604323E RID: 275006 RVA: 0x0105DB14 File Offset: 0x0105BD14
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
			PropertyInfo property = ctor.GetProperty("Dependencies", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
			List<Type> list = ((property != null) ? property.GetValue(null) : null) as List<Type>;
			if (list != null)
			{
				foreach (Type type in list)
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

		// Token: 0x0604323F RID: 275007 RVA: 0x0105DE04 File Offset: 0x0105C004
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

		// Token: 0x06043240 RID: 275008 RVA: 0x0105DE3C File Offset: 0x0105C03C
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

		// Token: 0x170097F0 RID: 38896
		// (get) Token: 0x06043241 RID: 275009 RVA: 0x0105DEC4 File Offset: 0x0105C0C4
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

		// Token: 0x04022F52 RID: 143186
		[Nullable(1)]
		private readonly List<ActivityGameplayComponentBase> Components = new List<ActivityGameplayComponentBase>();

		// Token: 0x04022F53 RID: 143187
		[Nullable(1)]
		private readonly Dictionary<Type, ActivityGameplayComponentBase> ComponentMap = new Dictionary<Type, ActivityGameplayComponentBase>();

		// Token: 0x04022F54 RID: 143188
		private bool IsInit;

		// Token: 0x04022F55 RID: 143189
		private bool IsEnd;
	}
}

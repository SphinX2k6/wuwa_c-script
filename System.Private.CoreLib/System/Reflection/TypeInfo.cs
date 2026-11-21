using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000788 RID: 1928
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TypeInfo : Type, IReflectableType
	{
		// Token: 0x06007B58 RID: 31576 RVA: 0x00007B62 File Offset: 0x00005D62
		TypeInfo IReflectableType.GetTypeInfo()
		{
			return this;
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x00007B62 File Offset: 0x00005D62
		public virtual Type AsType()
		{
			return this;
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06007B5A RID: 31578 RVA: 0x0012252E File Offset: 0x0012072E
		public virtual Type[] GenericTypeParameters
		{
			get
			{
				if (!this.IsGenericTypeDefinition)
				{
					return Type.EmptyTypes;
				}
				return this.GetGenericArguments();
			}
		}

		// Token: 0x06007B5B RID: 31579 RVA: 0x00122544 File Offset: 0x00120744
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
		[return: Nullable(2)]
		public virtual EventInfo GetDeclaredEvent(string name)
		{
			return this.GetEvent(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06007B5C RID: 31580 RVA: 0x0012254F File Offset: 0x0012074F
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
		[return: Nullable(2)]
		public virtual FieldInfo GetDeclaredField(string name)
		{
			return this.GetField(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06007B5D RID: 31581 RVA: 0x0012255A File Offset: 0x0012075A
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		[return: Nullable(2)]
		public virtual MethodInfo GetDeclaredMethod(string name)
		{
			return base.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06007B5E RID: 31582 RVA: 0x00122565 File Offset: 0x00120765
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
		[return: Nullable(2)]
		public virtual TypeInfo GetDeclaredNestedType(string name)
		{
			Type nestedType = this.GetNestedType(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (nestedType == null)
			{
				return null;
			}
			return nestedType.GetTypeInfo();
		}

		// Token: 0x06007B5F RID: 31583 RVA: 0x0012257B File Offset: 0x0012077B
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		[return: Nullable(2)]
		public virtual PropertyInfo GetDeclaredProperty(string name)
		{
			return base.GetProperty(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06007B60 RID: 31584 RVA: 0x00122586 File Offset: 0x00120786
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
		public virtual IEnumerable<MethodInfo> GetDeclaredMethods(string name)
		{
			foreach (MethodInfo methodInfo in TypeInfo.<GetDeclaredMethods>g__GetDeclaredOnlyMethods|10_0(this))
			{
				if (methodInfo.Name == name)
				{
					yield return methodInfo;
				}
			}
			MethodInfo[] array = null;
			yield break;
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06007B61 RID: 31585 RVA: 0x0012259D File Offset: 0x0012079D
		public virtual IEnumerable<ConstructorInfo> DeclaredConstructors
		{
			[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
			get
			{
				return this.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06007B62 RID: 31586 RVA: 0x001225A7 File Offset: 0x001207A7
		public virtual IEnumerable<EventInfo> DeclaredEvents
		{
			[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
			get
			{
				return this.GetEvents(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06007B63 RID: 31587 RVA: 0x001225B1 File Offset: 0x001207B1
		public virtual IEnumerable<FieldInfo> DeclaredFields
		{
			[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
			get
			{
				return this.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06007B64 RID: 31588 RVA: 0x001225BB File Offset: 0x001207BB
		public virtual IEnumerable<MemberInfo> DeclaredMembers
		{
			[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
			get
			{
				return this.GetMembers(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06007B65 RID: 31589 RVA: 0x001225C5 File Offset: 0x001207C5
		public virtual IEnumerable<MethodInfo> DeclaredMethods
		{
			[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
			get
			{
				return this.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06007B66 RID: 31590 RVA: 0x001225CF File Offset: 0x001207CF
		public virtual IEnumerable<TypeInfo> DeclaredNestedTypes
		{
			[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)]
			get
			{
				foreach (Type type in TypeInfo.<get_DeclaredNestedTypes>g__GetDeclaredOnlyNestedTypes|22_0(this))
				{
					yield return type.GetTypeInfo();
				}
				Type[] array = null;
				yield break;
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06007B67 RID: 31591 RVA: 0x001225DF File Offset: 0x001207DF
		public virtual IEnumerable<PropertyInfo> DeclaredProperties
		{
			[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
			get
			{
				return this.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06007B68 RID: 31592 RVA: 0x001225E9 File Offset: 0x001207E9
		public virtual IEnumerable<Type> ImplementedInterfaces
		{
			[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)]
			get
			{
				return this.GetInterfaces();
			}
		}

		// Token: 0x06007B69 RID: 31593 RVA: 0x001225F4 File Offset: 0x001207F4
		[NullableContext(2)]
		public virtual bool IsAssignableFrom([NotNullWhen(true)] TypeInfo typeInfo)
		{
			if (typeInfo == null)
			{
				return false;
			}
			if (this == typeInfo)
			{
				return true;
			}
			if (typeInfo.IsSubclassOf(this))
			{
				return true;
			}
			if (base.IsInterface)
			{
				return typeInfo.ImplementInterface(this);
			}
			if (this.IsGenericParameter)
			{
				Type[] genericParameterConstraints = this.GetGenericParameterConstraints();
				for (int i = 0; i < genericParameterConstraints.Length; i++)
				{
					if (!genericParameterConstraints[i].IsAssignableFrom(typeInfo))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06007B6A RID: 31594 RVA: 0x0012265F File Offset: 0x0012085F
		internal static string GetRankString(int rank)
		{
			if (rank <= 0)
			{
				throw new IndexOutOfRangeException();
			}
			if (rank != 1)
			{
				return "[" + new string(',', rank - 1) + "]";
			}
			return "[*]";
		}

		// Token: 0x06007B6B RID: 31595 RVA: 0x001225C5 File Offset: 0x001207C5
		[CompilerGenerated]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "The yield return state machine doesn't propagate annotations")]
		internal static MethodInfo[] <GetDeclaredMethods>g__GetDeclaredOnlyMethods|10_0(Type type)
		{
			return type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06007B6C RID: 31596 RVA: 0x0012268E File Offset: 0x0012088E
		[CompilerGenerated]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "The yield return state machine doesn't propagate annotations")]
		internal static Type[] <get_DeclaredNestedTypes>g__GetDeclaredOnlyNestedTypes|22_0(Type type)
		{
			return type.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}
	}
}

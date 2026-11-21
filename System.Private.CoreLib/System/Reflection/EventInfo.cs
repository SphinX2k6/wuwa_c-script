using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000740 RID: 1856
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class EventInfo : MemberInfo
	{
		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x060078EC RID: 30956 RVA: 0x000201B4 File Offset: 0x0001E3B4
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Event;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x060078ED RID: 30957
		public abstract EventAttributes Attributes { get; }

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x060078EE RID: 30958 RVA: 0x0011F34A File Offset: 0x0011D54A
		public bool IsSpecialName
		{
			get
			{
				return (this.Attributes & EventAttributes.SpecialName) > EventAttributes.None;
			}
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x0011F35B File Offset: 0x0011D55B
		[NullableContext(1)]
		public MethodInfo[] GetOtherMethods()
		{
			return this.GetOtherMethods(false);
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x0001A4BD File Offset: 0x000186BD
		[NullableContext(1)]
		public virtual MethodInfo[] GetOtherMethods(bool nonPublic)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x060078F1 RID: 30961 RVA: 0x0011F364 File Offset: 0x0011D564
		public virtual MethodInfo AddMethod
		{
			get
			{
				return this.GetAddMethod(true);
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x060078F2 RID: 30962 RVA: 0x0011F36D File Offset: 0x0011D56D
		public virtual MethodInfo RemoveMethod
		{
			get
			{
				return this.GetRemoveMethod(true);
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x060078F3 RID: 30963 RVA: 0x0011F376 File Offset: 0x0011D576
		public virtual MethodInfo RaiseMethod
		{
			get
			{
				return this.GetRaiseMethod(true);
			}
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x0011F37F File Offset: 0x0011D57F
		public MethodInfo GetAddMethod()
		{
			return this.GetAddMethod(false);
		}

		// Token: 0x060078F5 RID: 30965 RVA: 0x0011F388 File Offset: 0x0011D588
		public MethodInfo GetRemoveMethod()
		{
			return this.GetRemoveMethod(false);
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x0011F391 File Offset: 0x0011D591
		public MethodInfo GetRaiseMethod()
		{
			return this.GetRaiseMethod(false);
		}

		// Token: 0x060078F7 RID: 30967
		public abstract MethodInfo GetAddMethod(bool nonPublic);

		// Token: 0x060078F8 RID: 30968
		public abstract MethodInfo GetRemoveMethod(bool nonPublic);

		// Token: 0x060078F9 RID: 30969
		public abstract MethodInfo GetRaiseMethod(bool nonPublic);

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x060078FA RID: 30970 RVA: 0x0011F39C File Offset: 0x0011D59C
		public virtual bool IsMulticast
		{
			get
			{
				Type eventHandlerType = this.EventHandlerType;
				return typeof(MulticastDelegate).IsAssignableFrom(eventHandlerType);
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x060078FB RID: 30971 RVA: 0x0011F3C0 File Offset: 0x0011D5C0
		public unsafe virtual Type EventHandlerType
		{
			get
			{
				ReadOnlySpan<ParameterInfo> parametersAsSpan = this.GetAddMethod(true).GetParametersAsSpan();
				Type typeFromHandle = typeof(Delegate);
				for (int i = 0; i < parametersAsSpan.Length; i++)
				{
					Type parameterType = parametersAsSpan[i]->ParameterType;
					if (parameterType.IsSubclassOf(typeFromHandle))
					{
						return parameterType;
					}
				}
				return null;
			}
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x0011F412 File Offset: 0x0011D612
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual void AddEventHandler(object target, Delegate handler)
		{
			MethodInfo addMethod = this.GetAddMethod(false);
			if (addMethod == null)
			{
				throw new InvalidOperationException(SR.InvalidOperation_NoPublicAddMethod);
			}
			addMethod.Invoke(target, new object[]
			{
				handler
			});
		}

		// Token: 0x060078FD RID: 30973 RVA: 0x0011F43B File Offset: 0x0011D63B
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual void RemoveEventHandler(object target, Delegate handler)
		{
			MethodInfo removeMethod = this.GetRemoveMethod(false);
			if (removeMethod == null)
			{
				throw new InvalidOperationException(SR.InvalidOperation_NoPublicRemoveMethod);
			}
			removeMethod.Invoke(target, new object[]
			{
				handler
			});
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x001191DA File Offset: 0x001173DA
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x001191E3 File Offset: 0x001173E3
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x0011699B File Offset: 0x00114B9B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(EventInfo left, EventInfo right)
		{
			if (right == null)
			{
				return left == null;
			}
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x0011F464 File Offset: 0x0011D664
		public static bool operator !=(EventInfo left, EventInfo right)
		{
			return !(left == right);
		}
	}
}

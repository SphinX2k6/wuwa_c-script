using System;

namespace System.Reflection
{
	// Token: 0x0200077D RID: 1917
	internal abstract class SignatureHasElementType : SignatureType
	{
		// Token: 0x06007A79 RID: 31353 RVA: 0x00121C40 File Offset: 0x0011FE40
		protected SignatureHasElementType(SignatureType elementType)
		{
			this._elementType = elementType;
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06007A7A RID: 31354 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06007A7B RID: 31355 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007A7C RID: 31356 RVA: 0x000070DD File Offset: 0x000052DD
		protected sealed override bool HasElementTypeImpl()
		{
			return true;
		}

		// Token: 0x06007A7D RID: 31357
		protected abstract override bool IsArrayImpl();

		// Token: 0x06007A7E RID: 31358
		protected abstract override bool IsByRefImpl();

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06007A7F RID: 31359 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsByRefLike
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007A80 RID: 31360
		protected abstract override bool IsPointerImpl();

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06007A81 RID: 31361
		public abstract override bool IsSZArray { get; }

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06007A82 RID: 31362
		public abstract override bool IsVariableBoundArray { get; }

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06007A83 RID: 31363 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsConstructedGenericType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06007A84 RID: 31364 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06007A85 RID: 31365 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsGenericTypeParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06007A86 RID: 31366 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsGenericMethodParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06007A87 RID: 31367 RVA: 0x00121C4F File Offset: 0x0011FE4F
		public sealed override bool ContainsGenericParameters
		{
			get
			{
				return this._elementType.ContainsGenericParameters;
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06007A88 RID: 31368 RVA: 0x00121C5C File Offset: 0x0011FE5C
		internal sealed override SignatureType ElementType
		{
			get
			{
				return this._elementType;
			}
		}

		// Token: 0x06007A89 RID: 31369
		public abstract override int GetArrayRank();

		// Token: 0x06007A8A RID: 31370 RVA: 0x0001A485 File Offset: 0x00018685
		public sealed override Type GetGenericTypeDefinition()
		{
			throw new InvalidOperationException(SR.InvalidOperation_NotGenericType);
		}

		// Token: 0x06007A8B RID: 31371 RVA: 0x0001A550 File Offset: 0x00018750
		public sealed override Type[] GetGenericArguments()
		{
			return Type.EmptyTypes;
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06007A8C RID: 31372 RVA: 0x0001A550 File Offset: 0x00018750
		public sealed override Type[] GenericTypeArguments
		{
			get
			{
				return Type.EmptyTypes;
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06007A8D RID: 31373 RVA: 0x0001A557 File Offset: 0x00018757
		public sealed override int GenericParameterPosition
		{
			get
			{
				throw new InvalidOperationException(SR.Arg_NotGenericParameter);
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06007A8E RID: 31374 RVA: 0x00121C64 File Offset: 0x0011FE64
		public sealed override string Name
		{
			get
			{
				return this._elementType.Name + this.Suffix;
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06007A8F RID: 31375 RVA: 0x00121C7C File Offset: 0x0011FE7C
		public sealed override string Namespace
		{
			get
			{
				return this._elementType.Namespace;
			}
		}

		// Token: 0x06007A90 RID: 31376 RVA: 0x00121C89 File Offset: 0x0011FE89
		public sealed override string ToString()
		{
			return this._elementType.ToString() + this.Suffix;
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06007A91 RID: 31377
		protected abstract string Suffix { get; }

		// Token: 0x04001728 RID: 5928
		private readonly SignatureType _elementType;
	}
}

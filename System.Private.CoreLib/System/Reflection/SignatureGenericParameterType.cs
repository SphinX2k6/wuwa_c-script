using System;

namespace System.Reflection
{
	// Token: 0x0200077C RID: 1916
	internal abstract class SignatureGenericParameterType : SignatureType
	{
		// Token: 0x06007A62 RID: 31330 RVA: 0x00121C21 File Offset: 0x0011FE21
		protected SignatureGenericParameterType(int position)
		{
			this._position = position;
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06007A63 RID: 31331 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06007A64 RID: 31332 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool HasElementTypeImpl()
		{
			return false;
		}

		// Token: 0x06007A66 RID: 31334 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06007A68 RID: 31336 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsByRefLike
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06007A6A RID: 31338 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsSZArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06007A6B RID: 31339 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsVariableBoundArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06007A6C RID: 31340 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsConstructedGenericType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06007A6D RID: 31341 RVA: 0x000070DD File Offset: 0x000052DD
		public sealed override bool IsGenericParameter
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06007A6E RID: 31342
		public abstract override bool IsGenericMethodParameter { get; }

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06007A6F RID: 31343 RVA: 0x000070DD File Offset: 0x000052DD
		public sealed override bool ContainsGenericParameters
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06007A70 RID: 31344 RVA: 0x0001A4BA File Offset: 0x000186BA
		internal sealed override SignatureType ElementType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06007A71 RID: 31345 RVA: 0x00121A91 File Offset: 0x0011FC91
		public sealed override int GetArrayRank()
		{
			throw new ArgumentException(SR.Argument_HasToBeArrayClass);
		}

		// Token: 0x06007A72 RID: 31346 RVA: 0x0001A485 File Offset: 0x00018685
		public sealed override Type GetGenericTypeDefinition()
		{
			throw new InvalidOperationException(SR.InvalidOperation_NotGenericType);
		}

		// Token: 0x06007A73 RID: 31347 RVA: 0x0001A550 File Offset: 0x00018750
		public sealed override Type[] GetGenericArguments()
		{
			return Type.EmptyTypes;
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06007A74 RID: 31348 RVA: 0x0001A550 File Offset: 0x00018750
		public sealed override Type[] GenericTypeArguments
		{
			get
			{
				return Type.EmptyTypes;
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06007A75 RID: 31349 RVA: 0x00121C30 File Offset: 0x0011FE30
		public sealed override int GenericParameterPosition
		{
			get
			{
				return this._position;
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06007A76 RID: 31350
		public abstract override string Name { get; }

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06007A77 RID: 31351 RVA: 0x0001A4BA File Offset: 0x000186BA
		public sealed override string Namespace
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06007A78 RID: 31352 RVA: 0x00121C38 File Offset: 0x0011FE38
		public sealed override string ToString()
		{
			return this.Name;
		}

		// Token: 0x04001727 RID: 5927
		private readonly int _position;
	}
}

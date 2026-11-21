using System;
using System.Text;

namespace System.Reflection
{
	// Token: 0x0200077A RID: 1914
	internal sealed class SignatureConstructedGenericType : SignatureType
	{
		// Token: 0x06007A46 RID: 31302 RVA: 0x00121AA4 File Offset: 0x0011FCA4
		internal SignatureConstructedGenericType(Type genericTypeDefinition, Type[] typeArguments)
		{
			ArgumentNullException.ThrowIfNull(genericTypeDefinition, "genericTypeDefinition");
			ArgumentNullException.ThrowIfNull(typeArguments, "typeArguments");
			typeArguments = (Type[])typeArguments.Clone();
			for (int i = 0; i < typeArguments.Length; i++)
			{
				ArgumentNullException.ThrowIfNull(typeArguments[i], "typeArguments");
			}
			this._genericTypeDefinition = genericTypeDefinition;
			this._genericTypeArguments = typeArguments;
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06007A47 RID: 31303 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06007A48 RID: 31304 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool HasElementTypeImpl()
		{
			return false;
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06007A4C RID: 31308 RVA: 0x00121B03 File Offset: 0x0011FD03
		public sealed override bool IsByRefLike
		{
			get
			{
				return this._genericTypeDefinition.IsByRefLike;
			}
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06007A4E RID: 31310 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsSZArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06007A4F RID: 31311 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsVariableBoundArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06007A50 RID: 31312 RVA: 0x000070DD File Offset: 0x000052DD
		public sealed override bool IsConstructedGenericType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06007A51 RID: 31313 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06007A52 RID: 31314 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsGenericTypeParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06007A53 RID: 31315 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsGenericMethodParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06007A54 RID: 31316 RVA: 0x00121B10 File Offset: 0x0011FD10
		public sealed override bool ContainsGenericParameters
		{
			get
			{
				for (int i = 0; i < this._genericTypeArguments.Length; i++)
				{
					if (this._genericTypeArguments[i].ContainsGenericParameters)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06007A55 RID: 31317 RVA: 0x0001A4BA File Offset: 0x000186BA
		internal sealed override SignatureType ElementType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x00121A91 File Offset: 0x0011FC91
		public sealed override int GetArrayRank()
		{
			throw new ArgumentException(SR.Argument_HasToBeArrayClass);
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x00121B42 File Offset: 0x0011FD42
		public sealed override Type GetGenericTypeDefinition()
		{
			return this._genericTypeDefinition;
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x00121B4A File Offset: 0x0011FD4A
		public sealed override Type[] GetGenericArguments()
		{
			return this.GenericTypeArguments;
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06007A59 RID: 31321 RVA: 0x00121B52 File Offset: 0x0011FD52
		public sealed override Type[] GenericTypeArguments
		{
			get
			{
				return (Type[])this._genericTypeArguments.Clone();
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06007A5A RID: 31322 RVA: 0x0001A557 File Offset: 0x00018757
		public sealed override int GenericParameterPosition
		{
			get
			{
				throw new InvalidOperationException(SR.Arg_NotGenericParameter);
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06007A5B RID: 31323 RVA: 0x00121B64 File Offset: 0x0011FD64
		public sealed override string Name
		{
			get
			{
				return this._genericTypeDefinition.Name;
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06007A5C RID: 31324 RVA: 0x00121B71 File Offset: 0x0011FD71
		public sealed override string Namespace
		{
			get
			{
				return this._genericTypeDefinition.Namespace;
			}
		}

		// Token: 0x06007A5D RID: 31325 RVA: 0x00121B80 File Offset: 0x0011FD80
		public sealed override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this._genericTypeDefinition.ToString());
			stringBuilder.Append('[');
			for (int i = 0; i < this._genericTypeArguments.Length; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append(this._genericTypeArguments[i].ToString());
			}
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x04001725 RID: 5925
		private readonly Type _genericTypeDefinition;

		// Token: 0x04001726 RID: 5926
		private readonly Type[] _genericTypeArguments;
	}
}

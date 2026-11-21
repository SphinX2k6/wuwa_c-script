using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020006F4 RID: 1780
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MemberInfo : ICustomAttributeProvider
	{
		// Token: 0x060075F6 RID: 30198 RVA: 0x00119274 File Offset: 0x00117474
		internal bool HasSameMetadataDefinitionAsCore<TOther>(MemberInfo other) where TOther : MemberInfo
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			return other is TOther && this.MetadataToken == other.MetadataToken && this.Module.Equals(other.Module);
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x060075F8 RID: 30200
		public abstract MemberTypes MemberType { get; }

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x060075F9 RID: 30201
		public abstract string Name { get; }

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x060075FA RID: 30202
		[Nullable(2)]
		public abstract Type DeclaringType { [NullableContext(2)] get; }

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x060075FB RID: 30203
		[Nullable(2)]
		public abstract Type ReflectedType { [NullableContext(2)] get; }

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x060075FC RID: 30204 RVA: 0x001192B4 File Offset: 0x001174B4
		public virtual Module Module
		{
			get
			{
				Type type = this as Type;
				if (type != null)
				{
					return type.Module;
				}
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x060075FD RID: 30205 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool HasSameMetadataDefinitionAs(MemberInfo other)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x060075FE RID: 30206
		public abstract bool IsDefined(Type attributeType, bool inherit);

		// Token: 0x060075FF RID: 30207
		public abstract object[] GetCustomAttributes(bool inherit);

		// Token: 0x06007600 RID: 30208
		public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06007601 RID: 30209 RVA: 0x001192D7 File Offset: 0x001174D7
		public virtual IEnumerable<CustomAttributeData> CustomAttributes
		{
			get
			{
				return this.GetCustomAttributesData();
			}
		}

		// Token: 0x06007602 RID: 30210 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual IList<CustomAttributeData> GetCustomAttributesData()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06007603 RID: 30211 RVA: 0x000070DD File Offset: 0x000052DD
		public virtual bool IsCollectible
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06007604 RID: 30212 RVA: 0x00066B61 File Offset: 0x00064D61
		public virtual int MetadataToken
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x00092631 File Offset: 0x00090831
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x0009264E File Offset: 0x0009084E
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x0011699B File Offset: 0x00114B9B
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(MemberInfo left, MemberInfo right)
		{
			if (right == null)
			{
				return left == null;
			}
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06007608 RID: 30216 RVA: 0x001192DF File Offset: 0x001174DF
		[NullableContext(2)]
		public static bool operator !=(MemberInfo left, MemberInfo right)
		{
			return !(left == right);
		}
	}
}

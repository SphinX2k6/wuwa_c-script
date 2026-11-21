using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security
{
	// Token: 0x0200025C RID: 604
	[NullableContext(2)]
	[Nullable(0)]
	[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public class PermissionSet : ICollection, IEnumerable, IDeserializationCallback, ISecurityEncodable, IStackWalk
	{
		// Token: 0x06002D5B RID: 11611 RVA: 0x00005ACC File Offset: 0x00003CCC
		public PermissionSet(PermissionState state)
		{
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x00005ACC File Offset: 0x00003CCC
		public PermissionSet(PermissionSet permSet)
		{
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06002D5E RID: 11614 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06002D60 RID: 11616 RVA: 0x00007B62 File Offset: 0x00005D62
		[Nullable(1)]
		public virtual object SyncRoot
		{
			[NullableContext(1)]
			get
			{
				return this;
			}
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x00092620 File Offset: 0x00090820
		public IPermission AddPermission(IPermission perm)
		{
			return this.AddPermissionImpl(perm);
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x0001A4BA File Offset: 0x000186BA
		protected virtual IPermission AddPermissionImpl(IPermission perm)
		{
			return null;
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public void Assert()
		{
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool ContainsNonCodeAccessPermissions()
		{
			return false;
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x0001DC8E File Offset: 0x0001BE8E
		[NullableContext(1)]
		[Obsolete]
		public static byte[] ConvertPermissionSet(string inFormat, byte[] inData, string outFormat)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_CAS);
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00092629 File Offset: 0x00090829
		[NullableContext(1)]
		public virtual PermissionSet Copy()
		{
			return new PermissionSet(this);
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NullableContext(1)]
		public virtual void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public void Demand()
		{
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x0001DC8E File Offset: 0x0001BE8E
		[Obsolete]
		public void Deny()
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_CAS);
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x00092631 File Offset: 0x00090831
		public override bool Equals(object o)
		{
			return base.Equals(o);
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NullableContext(1)]
		public virtual void FromXml(SecurityElement et)
		{
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x0009263A File Offset: 0x0009083A
		[NullableContext(1)]
		public IEnumerator GetEnumerator()
		{
			return this.GetEnumeratorImpl();
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00092642 File Offset: 0x00090842
		[NullableContext(1)]
		protected virtual IEnumerator GetEnumeratorImpl()
		{
			return Array.Empty<object>().GetEnumerator();
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x0009264E File Offset: 0x0009084E
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00092656 File Offset: 0x00090856
		public IPermission GetPermission(Type permClass)
		{
			return this.GetPermissionImpl(permClass);
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x0001A4BA File Offset: 0x000186BA
		protected virtual IPermission GetPermissionImpl(Type permClass)
		{
			return null;
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x0001A4BA File Offset: 0x000186BA
		public PermissionSet Intersect(PermissionSet other)
		{
			return null;
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool IsEmpty()
		{
			return false;
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool IsSubsetOf(PermissionSet target)
		{
			return false;
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool IsUnrestricted()
		{
			return false;
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x0001DC8E File Offset: 0x0001BE8E
		public void PermitOnly()
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_CAS);
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x0009265F File Offset: 0x0009085F
		public IPermission RemovePermission(Type permClass)
		{
			return this.RemovePermissionImpl(permClass);
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x0001A4BA File Offset: 0x000186BA
		protected virtual IPermission RemovePermissionImpl(Type permClass)
		{
			return null;
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public static void RevertAssert()
		{
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00092668 File Offset: 0x00090868
		public IPermission SetPermission(IPermission perm)
		{
			return this.SetPermissionImpl(perm);
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x0001A4BA File Offset: 0x000186BA
		protected virtual IPermission SetPermissionImpl(IPermission perm)
		{
			return null;
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x00092671 File Offset: 0x00090871
		[NullableContext(1)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x0001A4BA File Offset: 0x000186BA
		public virtual SecurityElement ToXml()
		{
			return null;
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x0001A4BA File Offset: 0x000186BA
		public PermissionSet Union(PermissionSet other)
		{
			return null;
		}
	}
}

using System;

namespace System.Runtime.Serialization
{
	// Token: 0x02000524 RID: 1316
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class OptionalFieldAttribute : Attribute
	{
		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x000F133D File Offset: 0x000EF53D
		// (set) Token: 0x06004895 RID: 18581 RVA: 0x000F1345 File Offset: 0x000EF545
		public int VersionAdded
		{
			get
			{
				return this._versionAdded;
			}
			set
			{
				if (value < 1)
				{
					throw new ArgumentException(SR.Serialization_OptionalFieldVersionValue);
				}
				this._versionAdded = value;
			}
		}

		// Token: 0x0400115A RID: 4442
		private int _versionAdded = 1;
	}
}

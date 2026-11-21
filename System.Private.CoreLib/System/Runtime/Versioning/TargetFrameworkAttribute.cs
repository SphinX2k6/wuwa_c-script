using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{
	// Token: 0x02000515 RID: 1301
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public sealed class TargetFrameworkAttribute : Attribute
	{
		// Token: 0x0600486E RID: 18542 RVA: 0x000F1039 File Offset: 0x000EF239
		public TargetFrameworkAttribute(string frameworkName)
		{
			ArgumentNullException.ThrowIfNull(frameworkName, "frameworkName");
			this._frameworkName = frameworkName;
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x000F1053 File Offset: 0x000EF253
		public string FrameworkName
		{
			get
			{
				return this._frameworkName;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x000F105B File Offset: 0x000EF25B
		// (set) Token: 0x06004871 RID: 18545 RVA: 0x000F1063 File Offset: 0x000EF263
		[Nullable(2)]
		public string FrameworkDisplayName
		{
			[NullableContext(2)]
			get
			{
				return this._frameworkDisplayName;
			}
			[NullableContext(2)]
			set
			{
				this._frameworkDisplayName = value;
			}
		}

		// Token: 0x0400114F RID: 4431
		private readonly string _frameworkName;

		// Token: 0x04001150 RID: 4432
		private string _frameworkDisplayName;
	}
}

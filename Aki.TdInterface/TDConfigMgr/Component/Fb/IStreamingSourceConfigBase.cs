using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E35 RID: 3637
	public class IStreamingSourceConfigBase
	{
		// Token: 0x06005236 RID: 21046 RVA: 0x000CA8C9 File Offset: 0x000C8AC9
		[NullableContext(1)]
		public static IStreamingSourceConfigBase Create(IStreamingSourceConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingSourceConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06005237 RID: 21047 RVA: 0x000CA8E8 File Offset: 0x000C8AE8
		public virtual EStreamingSourceMode Type
		{
			get
			{
				return (EStreamingSourceMode)this.Instance.Type;
			}
		}

		// Token: 0x04002F60 RID: 12128
		private IStreamingSourceConfigBase Instance;
	}
}

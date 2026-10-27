using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D36 RID: 3382
	public class IEntityMatchConfig
	{
		// Token: 0x06004D2B RID: 19755 RVA: 0x000C0116 File Offset: 0x000BE316
		[NullableContext(1)]
		public static IEntityMatchConfig Create(IEntityMatchConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatchConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06004D2C RID: 19756 RVA: 0x000C0135 File Offset: 0x000BE335
		public virtual EEntityMatchType Type
		{
			get
			{
				return (EEntityMatchType)this.Instance.Type;
			}
		}

		// Token: 0x04002C3D RID: 11325
		private IEntityMatchConfig Instance;
	}
}

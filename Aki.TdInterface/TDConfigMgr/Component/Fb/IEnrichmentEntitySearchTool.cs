using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D52 RID: 3410
	public class IEnrichmentEntitySearchTool
	{
		// Token: 0x06004DB7 RID: 19895 RVA: 0x000C1363 File Offset: 0x000BF563
		[NullableContext(1)]
		public static IEnrichmentEntitySearchTool Create(IEnrichmentEntitySearchTool? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnrichmentEntitySearchTool
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x06004DB8 RID: 19896 RVA: 0x000C1382 File Offset: 0x000BF582
		public virtual int TargetType
		{
			get
			{
				return this.Instance.TargetType;
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x06004DB9 RID: 19897 RVA: 0x000C138F File Offset: 0x000BF58F
		public virtual float Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x06004DBA RID: 19898 RVA: 0x000C139C File Offset: 0x000BF59C
		public virtual float Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x04002C8F RID: 11407
		private IEnrichmentEntitySearchTool Instance;
	}
}

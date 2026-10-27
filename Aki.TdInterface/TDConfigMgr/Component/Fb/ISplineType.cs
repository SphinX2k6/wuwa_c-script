using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C37 RID: 3127
	public class ISplineType
	{
		// Token: 0x0600479B RID: 18331 RVA: 0x000B4509 File Offset: 0x000B2709
		[NullableContext(1)]
		public static ISplineType Create(ISplineType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x000B4528 File Offset: 0x000B2728
		public virtual ESplineType Type
		{
			get
			{
				return (ESplineType)this.Instance.Type;
			}
		}

		// Token: 0x040028B4 RID: 10420
		private ISplineType Instance;
	}
}

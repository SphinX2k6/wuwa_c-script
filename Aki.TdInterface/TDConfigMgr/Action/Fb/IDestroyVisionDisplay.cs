using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002599 RID: 9625
	public class IDestroyVisionDisplay : IDestroyDynamicEntitiesType
	{
		// Token: 0x0600D8AC RID: 55468 RVA: 0x00205902 File Offset: 0x00203B02
		[NullableContext(1)]
		public static IDestroyVisionDisplay Create(IDestroyVisionDisplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyVisionDisplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F3C RID: 16188
		// (get) Token: 0x0600D8AD RID: 55469 RVA: 0x00205921 File Offset: 0x00203B21
		public override EDynamicEntityType Type
		{
			get
			{
				return (EDynamicEntityType)this.Instance.Type;
			}
		}

		// Token: 0x0400786D RID: 30829
		private IDestroyVisionDisplay Instance;
	}
}

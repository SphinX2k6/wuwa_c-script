using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DEF RID: 3567
	public class ILowViewDistance : IViewDistanceMode
	{
		// Token: 0x060050E0 RID: 20704 RVA: 0x000C88EC File Offset: 0x000C6AEC
		public static ILowViewDistance Create(ILowViewDistance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILowViewDistance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x060050E1 RID: 20705 RVA: 0x000C890B File Offset: 0x000C6B0B
		public override EViewDistanceType Type
		{
			get
			{
				return (EViewDistanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002E14 RID: 11796
		private ILowViewDistance Instance;
	}
}

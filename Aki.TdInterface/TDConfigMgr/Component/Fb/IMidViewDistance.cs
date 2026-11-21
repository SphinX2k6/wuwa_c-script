using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF0 RID: 3568
	public class IMidViewDistance : IViewDistanceMode
	{
		// Token: 0x060050E3 RID: 20707 RVA: 0x000C8920 File Offset: 0x000C6B20
		public static IMidViewDistance Create(IMidViewDistance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMidViewDistance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x060050E4 RID: 20708 RVA: 0x000C893F File Offset: 0x000C6B3F
		public override EViewDistanceType Type
		{
			get
			{
				return (EViewDistanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002E15 RID: 11797
		private IMidViewDistance Instance;
	}
}

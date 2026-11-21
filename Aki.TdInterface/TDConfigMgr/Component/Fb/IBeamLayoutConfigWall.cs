using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE8 RID: 3560
	public class IBeamLayoutConfigWall : IBeamLayoutConfig
	{
		// Token: 0x060050B1 RID: 20657 RVA: 0x000C81E6 File Offset: 0x000C63E6
		public static IBeamLayoutConfigWall Create(IBeamLayoutConfigWall? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBeamLayoutConfigWall
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x060050B2 RID: 20658 RVA: 0x000C8205 File Offset: 0x000C6405
		public override EBeamLayoutType Type
		{
			get
			{
				return (EBeamLayoutType)this.Instance.Type;
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x060050B3 RID: 20659 RVA: 0x000C8212 File Offset: 0x000C6412
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x060050B4 RID: 20660 RVA: 0x000C821F File Offset: 0x000C641F
		public virtual float Distance
		{
			get
			{
				return this.Instance.Distance;
			}
		}

		// Token: 0x04002DF5 RID: 11765
		private IBeamLayoutConfigWall Instance;
	}
}

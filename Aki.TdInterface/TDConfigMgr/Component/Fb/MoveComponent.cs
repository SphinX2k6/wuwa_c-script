using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B22 RID: 2850
	public class MoveComponent : IComponentBase
	{
		// Token: 0x06004123 RID: 16675 RVA: 0x000A62FD File Offset: 0x000A44FD
		public static MoveComponent Create(IMoveComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MoveComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06004124 RID: 16676 RVA: 0x000A631C File Offset: 0x000A451C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x000A6354 File Offset: 0x000A4554
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06004126 RID: 16678 RVA: 0x000A636A File Offset: 0x000A456A
		public virtual float InitSpeed
		{
			get
			{
				return this.Instance.InitSpeed;
			}
		}

		// Token: 0x04002417 RID: 9239
		private IMoveComponent Instance;
	}
}

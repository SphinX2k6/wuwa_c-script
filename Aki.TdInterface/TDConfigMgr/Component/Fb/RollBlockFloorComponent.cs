using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D9A RID: 3482
	public class RollBlockFloorComponent : IComponentBase
	{
		// Token: 0x06004F2E RID: 20270 RVA: 0x000C454E File Offset: 0x000C274E
		[NullableContext(1)]
		public static RollBlockFloorComponent Create(IRollBlockFloorComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockFloorComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06004F2F RID: 20271 RVA: 0x000C4570 File Offset: 0x000C2770
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

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06004F30 RID: 20272 RVA: 0x000C45A8 File Offset: 0x000C27A8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002D7B RID: 11643
		private IRollBlockFloorComponent Instance;
	}
}

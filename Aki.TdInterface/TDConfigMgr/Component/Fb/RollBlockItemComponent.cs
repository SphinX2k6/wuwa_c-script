using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E97 RID: 3735
	public class RollBlockItemComponent : IComponentBase
	{
		// Token: 0x06005457 RID: 21591 RVA: 0x000CFE16 File Offset: 0x000CE016
		public static RollBlockItemComponent Create(IRollBlockItemComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockItemComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x06005458 RID: 21592 RVA: 0x000CFE38 File Offset: 0x000CE038
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

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x06005459 RID: 21593 RVA: 0x000CFE70 File Offset: 0x000CE070
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04003042 RID: 12354
		private IRollBlockItemComponent Instance;
	}
}

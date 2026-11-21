using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE1 RID: 3297
	public class AdviseItemComponent : IComponentBase
	{
		// Token: 0x06004B44 RID: 19268 RVA: 0x000BCE12 File Offset: 0x000BB012
		public static AdviseItemComponent Create(IAdviseItemComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdviseItemComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06004B45 RID: 19269 RVA: 0x000BCE34 File Offset: 0x000BB034
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

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06004B46 RID: 19270 RVA: 0x000BCE6C File Offset: 0x000BB06C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002A92 RID: 10898
		private IAdviseItemComponent Instance;
	}
}

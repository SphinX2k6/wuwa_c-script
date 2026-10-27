using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D99 RID: 3481
	public class RollBlockComponent : IComponentBase
	{
		// Token: 0x06004F2A RID: 20266 RVA: 0x000C44D6 File Offset: 0x000C26D6
		[NullableContext(1)]
		public static RollBlockComponent Create(IRollBlockComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06004F2B RID: 20267 RVA: 0x000C44F8 File Offset: 0x000C26F8
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

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06004F2C RID: 20268 RVA: 0x000C4530 File Offset: 0x000C2730
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002D7A RID: 11642
		private IRollBlockComponent Instance;
	}
}

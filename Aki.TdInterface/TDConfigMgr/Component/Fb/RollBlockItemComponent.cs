using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D9B RID: 3483
	public class RollBlockItemComponent : IComponentBase
	{
		// Token: 0x06004F32 RID: 20274 RVA: 0x000C45C6 File Offset: 0x000C27C6
		[NullableContext(1)]
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

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06004F33 RID: 20275 RVA: 0x000C45E8 File Offset: 0x000C27E8
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

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06004F34 RID: 20276 RVA: 0x000C4620 File Offset: 0x000C2820
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002D7C RID: 11644
		private IRollBlockItemComponent Instance;
	}
}

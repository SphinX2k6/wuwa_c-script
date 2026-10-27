using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D68 RID: 3432
	public class AirPassageComponent : IComponentBase
	{
		// Token: 0x06004E1F RID: 19999 RVA: 0x000C1FE9 File Offset: 0x000C01E9
		[NullableContext(1)]
		public static AirPassageComponent Create(IAirPassageComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AirPassageComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x06004E20 RID: 20000 RVA: 0x000C2008 File Offset: 0x000C0208
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

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x06004E21 RID: 20001 RVA: 0x000C2040 File Offset: 0x000C0240
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002CC7 RID: 11463
		private IAirPassageComponent Instance;
	}
}

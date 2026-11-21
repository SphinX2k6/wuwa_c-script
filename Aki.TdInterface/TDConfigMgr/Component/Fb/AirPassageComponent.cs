using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E62 RID: 3682
	public class AirPassageComponent : IComponentBase
	{
		// Token: 0x0600533B RID: 21307 RVA: 0x000CD72D File Offset: 0x000CB92D
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

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x0600533C RID: 21308 RVA: 0x000CD74C File Offset: 0x000CB94C
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

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x0600533D RID: 21309 RVA: 0x000CD784 File Offset: 0x000CB984
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002F87 RID: 12167
		private IAirPassageComponent Instance;
	}
}

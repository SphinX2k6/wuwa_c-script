using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C3E RID: 3134
	public class LevelPlayComponent : IComponentBase
	{
		// Token: 0x060047D1 RID: 18385 RVA: 0x000B613E File Offset: 0x000B433E
		public static LevelPlayComponent Create(ILevelPlayComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevelPlayComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x000B6160 File Offset: 0x000B4360
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

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x060047D3 RID: 18387 RVA: 0x000B6198 File Offset: 0x000B4398
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x060047D4 RID: 18388 RVA: 0x000B61AE File Offset: 0x000B43AE
		public virtual int LevelPlayId
		{
			get
			{
				return this.Instance.LevelPlayId;
			}
		}

		// Token: 0x0400285F RID: 10335
		private ILevelPlayComponent Instance;
	}
}

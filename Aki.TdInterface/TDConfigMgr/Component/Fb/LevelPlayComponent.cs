using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B70 RID: 2928
	public class LevelPlayComponent : IComponentBase
	{
		// Token: 0x06004378 RID: 17272 RVA: 0x000AC07A File Offset: 0x000AA27A
		[NullableContext(1)]
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

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06004379 RID: 17273 RVA: 0x000AC09C File Offset: 0x000AA29C
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

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x000AC0D4 File Offset: 0x000AA2D4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x000AC0EA File Offset: 0x000AA2EA
		public virtual int LevelPlayId
		{
			get
			{
				return this.Instance.LevelPlayId;
			}
		}

		// Token: 0x04002617 RID: 9751
		private ILevelPlayComponent Instance;
	}
}

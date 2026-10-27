using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001469 RID: 5225
	public class ITetrisPlayModeEndless : ITetrisPlayModeBase
	{
		// Token: 0x060076E6 RID: 30438 RVA: 0x0011C3A5 File Offset: 0x0011A5A5
		[NullableContext(1)]
		public static ITetrisPlayModeEndless Create(ITetrisPlayModeEndless? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeEndless
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x060076E7 RID: 30439 RVA: 0x0011C3C4 File Offset: 0x0011A5C4
		public override ETetrisPlayMode Type
		{
			get
			{
				return (ETetrisPlayMode)this.Instance.Type;
			}
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x060076E8 RID: 30440 RVA: 0x0011C3D4 File Offset: 0x0011A5D4
		public virtual int? SpeedLevel
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SpeedLevel);
			}
		}

		// Token: 0x0400451F RID: 17695
		private ITetrisPlayModeEndless Instance;
	}
}

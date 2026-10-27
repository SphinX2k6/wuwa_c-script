using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002690 RID: 9872
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithEffect : ITeleportTransitionType
	{
		// Token: 0x0600DD09 RID: 56585 RVA: 0x0020DB02 File Offset: 0x0020BD02
		public static ITeleportTransitionWithEffect Create(ITeleportTransitionWithEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041AB RID: 16811
		// (get) Token: 0x0600DD0A RID: 56586 RVA: 0x0020DB21 File Offset: 0x0020BD21
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170041AC RID: 16812
		// (get) Token: 0x0600DD0B RID: 56587 RVA: 0x0020DB2E File Offset: 0x0020BD2E
		public virtual string EffectDaPath
		{
			get
			{
				return this.Instance.EffectDaPath;
			}
		}

		// Token: 0x04007AC8 RID: 31432
		private ITeleportTransitionWithEffect Instance;
	}
}

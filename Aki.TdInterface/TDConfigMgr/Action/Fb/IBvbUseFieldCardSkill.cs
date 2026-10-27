using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A2A RID: 10794
	public class IBvbUseFieldCardSkill : IBvbPlayerOperationType
	{
		// Token: 0x0600EDDC RID: 60892 RVA: 0x0022A9AD File Offset: 0x00228BAD
		[NullableContext(1)]
		public static IBvbUseFieldCardSkill Create(IBvbUseFieldCardSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbUseFieldCardSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B4A RID: 19274
		// (get) Token: 0x0600EDDD RID: 60893 RVA: 0x0022A9CC File Offset: 0x00228BCC
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040082EC RID: 33516
		private IBvbUseFieldCardSkill Instance;
	}
}

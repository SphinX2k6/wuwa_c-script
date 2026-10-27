using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE6 RID: 10982
	public class IResetPosByPosEntity : IResetPosType
	{
		// Token: 0x0600F0B5 RID: 61621 RVA: 0x0022F0CC File Offset: 0x0022D2CC
		[NullableContext(1)]
		public static IResetPosByPosEntity Create(IResetPosByPosEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPosByPosEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CAB RID: 19627
		// (get) Token: 0x0600F0B6 RID: 61622 RVA: 0x0022F0EB File Offset: 0x0022D2EB
		public override EResetPosType Type
		{
			get
			{
				return (EResetPosType)this.Instance.Type;
			}
		}

		// Token: 0x17004CAC RID: 19628
		// (get) Token: 0x0600F0B7 RID: 61623 RVA: 0x0022F0F8 File Offset: 0x0022D2F8
		public virtual int Entity
		{
			get
			{
				return this.Instance.Entity;
			}
		}

		// Token: 0x0400846E RID: 33902
		private IResetPosByPosEntity Instance;
	}
}

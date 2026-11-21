using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200208B RID: 8331
	public class ISheriffStartTrack : ICommonTipType
	{
		// Token: 0x0600B0E3 RID: 45283 RVA: 0x0018DE78 File Offset: 0x0018C078
		private ISheriffStartTrack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISheriffStartTrack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISheriffStartTrack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISheriffStartTrack_SetValue());
			}
			return result;
		}

		// Token: 0x0600B0E4 RID: 45284 RVA: 0x0018DEB0 File Offset: 0x0018C0B0
		public static ISheriffStartTrack Create([Nullable(2)] ISheriffStartTrack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffStartTrack
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B0E5 RID: 45285 RVA: 0x0018DEC3 File Offset: 0x0018C0C3
		public static ISheriffStartTrack CreateFromSetValue([Nullable(2)] ISheriffStartTrack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISheriffStartTrack
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B0E6 RID: 45286 RVA: 0x0018DED6 File Offset: 0x0018C0D6
		public new ISheriffStartTrack_SetValue ToSetValue()
		{
			return new ISheriffStartTrack_SetValue
			{
				Type = this.Type,
				AnomalyId = this.AnomalyId
			};
		}

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x0600B0E7 RID: 45287 RVA: 0x0018DEF5 File Offset: 0x0018C0F5
		// (set) Token: 0x0600B0E8 RID: 45288 RVA: 0x0018DF20 File Offset: 0x0018C120
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x0600B0E9 RID: 45289 RVA: 0x0018DF2E File Offset: 0x0018C12E
		// (set) Token: 0x0600B0EA RID: 45290 RVA: 0x0018DF59 File Offset: 0x0018C159
		public virtual int AnomalyId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnomalyId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AnomalyId;
			}
			set
			{
				this.GetOrCreatePoco().AnomalyId = value;
			}
		}

		// Token: 0x0400692A RID: 26922
		[Nullable(2)]
		protected new ISheriffStartTrack FbInstance;

		// Token: 0x0400692B RID: 26923
		[Nullable(2)]
		protected new ISheriffStartTrack_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200206F RID: 8303
	public class ISetNpcTwoPersonPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600B043 RID: 45123 RVA: 0x0018CC94 File Offset: 0x0018AE94
		private ISetNpcTwoPersonPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetNpcTwoPersonPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetNpcTwoPersonPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetNpcTwoPersonPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600B044 RID: 45124 RVA: 0x0018CCCC File Offset: 0x0018AECC
		public static ISetNpcTwoPersonPerform Create([Nullable(2)] ISetNpcTwoPersonPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcTwoPersonPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B045 RID: 45125 RVA: 0x0018CCDF File Offset: 0x0018AEDF
		public static ISetNpcTwoPersonPerform CreateFromSetValue([Nullable(2)] ISetNpcTwoPersonPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetNpcTwoPersonPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x0018CCF4 File Offset: 0x0018AEF4
		public new ISetNpcTwoPersonPerform_SetValue ToSetValue()
		{
			return new ISetNpcTwoPersonPerform_SetValue
			{
				Type = this.Type,
				Initiator = this.Initiator,
				Target = this.Target,
				GroupPerformMark = this.GroupPerformMark,
				NpcType = this.NpcType,
				WaitInteractNpcType = this.WaitInteractNpcType
			};
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x0600B047 RID: 45127 RVA: 0x0018CD4E File Offset: 0x0018AF4E
		// (set) Token: 0x0600B048 RID: 45128 RVA: 0x0018CD79 File Offset: 0x0018AF79
		public override ENpcGroupPerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x0600B049 RID: 45129 RVA: 0x0018CD88 File Offset: 0x0018AF88
		// (set) Token: 0x0600B04A RID: 45130 RVA: 0x0018CDE9 File Offset: 0x0018AFE9
		public virtual IPlayerInitiator Initiator
		{
			get
			{
				if (this._InitiatorInited)
				{
					return this._InitiatorCache;
				}
				this._InitiatorInited = true;
				if (this.FbInstance != null)
				{
					this._InitiatorCache = IPlayerInitiator.Create(this.FbInstance.Initiator);
				}
				else
				{
					ISetNpcTwoPersonPerform_SetValue pocoInterface = this.PocoInterface;
					this._InitiatorCache = ((pocoInterface != null) ? pocoInterface.Initiator : null);
				}
				return this._InitiatorCache;
			}
			set
			{
				this.GetOrCreatePoco().Initiator = value;
				this._InitiatorInited = false;
			}
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0600B04B RID: 45131 RVA: 0x0018CDFE File Offset: 0x0018AFFE
		// (set) Token: 0x0600B04C RID: 45132 RVA: 0x0018CE29 File Offset: 0x0018B029
		public virtual int Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0600B04D RID: 45133 RVA: 0x0018CE37 File Offset: 0x0018B037
		// (set) Token: 0x0600B04E RID: 45134 RVA: 0x0018CE62 File Offset: 0x0018B062
		public virtual string GroupPerformMark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupPerformMark;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.GroupPerformMark;
			}
			set
			{
				this.GetOrCreatePoco().GroupPerformMark = value;
			}
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0600B04F RID: 45135 RVA: 0x0018CE70 File Offset: 0x0018B070
		// (set) Token: 0x0600B050 RID: 45136 RVA: 0x0018CE9B File Offset: 0x0018B09B
		public virtual ENpcGroupPerformNpcType NpcType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NpcType;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformNpcType.LevelBCommonMale;
				}
				return this.PocoInterface.NpcType;
			}
			set
			{
				this.GetOrCreatePoco().NpcType = value;
			}
		}

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x0600B051 RID: 45137 RVA: 0x0018CEAC File Offset: 0x0018B0AC
		// (set) Token: 0x0600B052 RID: 45138 RVA: 0x0018CEE6 File Offset: 0x0018B0E6
		public virtual EWaitInteractNpcMontageWaitType? WaitInteractNpcType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WaitInteractNpcType;
				}
				ISetNpcTwoPersonPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WaitInteractNpcType;
			}
			set
			{
				this.GetOrCreatePoco().WaitInteractNpcType = value;
			}
		}

		// Token: 0x040068E0 RID: 26848
		[Nullable(2)]
		protected new ISetNpcTwoPersonPerform FbInstance;

		// Token: 0x040068E1 RID: 26849
		[Nullable(2)]
		protected new ISetNpcTwoPersonPerform_SetValue PocoInterface;

		// Token: 0x040068E2 RID: 26850
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x040068E3 RID: 26851
		private bool _InitiatorInited;
	}
}

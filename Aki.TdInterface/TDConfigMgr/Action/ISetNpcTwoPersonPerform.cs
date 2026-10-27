using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E3A RID: 7738
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcTwoPersonPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600A58B RID: 42379 RVA: 0x00176F94 File Offset: 0x00175194
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

		// Token: 0x0600A58C RID: 42380 RVA: 0x00176FCC File Offset: 0x001751CC
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

		// Token: 0x0600A58D RID: 42381 RVA: 0x00176FDF File Offset: 0x001751DF
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

		// Token: 0x0600A58E RID: 42382 RVA: 0x00176FF4 File Offset: 0x001751F4
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

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600A58F RID: 42383 RVA: 0x0017704E File Offset: 0x0017524E
		// (set) Token: 0x0600A590 RID: 42384 RVA: 0x00177079 File Offset: 0x00175279
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

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600A591 RID: 42385 RVA: 0x00177088 File Offset: 0x00175288
		// (set) Token: 0x0600A592 RID: 42386 RVA: 0x001770E9 File Offset: 0x001752E9
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

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600A593 RID: 42387 RVA: 0x001770FE File Offset: 0x001752FE
		// (set) Token: 0x0600A594 RID: 42388 RVA: 0x00177129 File Offset: 0x00175329
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

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600A595 RID: 42389 RVA: 0x00177137 File Offset: 0x00175337
		// (set) Token: 0x0600A596 RID: 42390 RVA: 0x00177162 File Offset: 0x00175362
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

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600A597 RID: 42391 RVA: 0x00177170 File Offset: 0x00175370
		// (set) Token: 0x0600A598 RID: 42392 RVA: 0x0017719B File Offset: 0x0017539B
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

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600A599 RID: 42393 RVA: 0x001771AC File Offset: 0x001753AC
		// (set) Token: 0x0600A59A RID: 42394 RVA: 0x001771E6 File Offset: 0x001753E6
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

		// Token: 0x040062FC RID: 25340
		[Nullable(2)]
		protected new ISetNpcTwoPersonPerform FbInstance;

		// Token: 0x040062FD RID: 25341
		[Nullable(2)]
		protected new ISetNpcTwoPersonPerform_SetValue PocoInterface;

		// Token: 0x040062FE RID: 25342
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x040062FF RID: 25343
		private bool _InitiatorInited;
	}
}

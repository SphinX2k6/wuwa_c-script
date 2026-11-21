using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002067 RID: 8295
	public class ISetNpcHighFivePerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600B00B RID: 45067 RVA: 0x0018C488 File Offset: 0x0018A688
		private ISetNpcHighFivePerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetNpcHighFivePerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetNpcHighFivePerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetNpcHighFivePerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600B00C RID: 45068 RVA: 0x0018C4C0 File Offset: 0x0018A6C0
		public static ISetNpcHighFivePerform Create([Nullable(2)] ISetNpcHighFivePerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcHighFivePerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B00D RID: 45069 RVA: 0x0018C4D3 File Offset: 0x0018A6D3
		public static ISetNpcHighFivePerform CreateFromSetValue([Nullable(2)] ISetNpcHighFivePerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetNpcHighFivePerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B00E RID: 45070 RVA: 0x0018C4E6 File Offset: 0x0018A6E6
		public new ISetNpcHighFivePerform_SetValue ToSetValue()
		{
			return new ISetNpcHighFivePerform_SetValue
			{
				Type = this.Type,
				Initiator = this.Initiator,
				Target = this.Target,
				NpcType = this.NpcType
			};
		}

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0600B00F RID: 45071 RVA: 0x0018C51D File Offset: 0x0018A71D
		// (set) Token: 0x0600B010 RID: 45072 RVA: 0x0018C548 File Offset: 0x0018A748
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

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0600B011 RID: 45073 RVA: 0x0018C558 File Offset: 0x0018A758
		// (set) Token: 0x0600B012 RID: 45074 RVA: 0x0018C5B9 File Offset: 0x0018A7B9
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
					ISetNpcHighFivePerform_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600B013 RID: 45075 RVA: 0x0018C5CE File Offset: 0x0018A7CE
		// (set) Token: 0x0600B014 RID: 45076 RVA: 0x0018C5F9 File Offset: 0x0018A7F9
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

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0600B015 RID: 45077 RVA: 0x0018C607 File Offset: 0x0018A807
		// (set) Token: 0x0600B016 RID: 45078 RVA: 0x0018C632 File Offset: 0x0018A832
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

		// Token: 0x040068BC RID: 26812
		[Nullable(2)]
		protected new ISetNpcHighFivePerform FbInstance;

		// Token: 0x040068BD RID: 26813
		[Nullable(2)]
		protected new ISetNpcHighFivePerform_SetValue PocoInterface;

		// Token: 0x040068BE RID: 26814
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x040068BF RID: 26815
		private bool _InitiatorInited;
	}
}

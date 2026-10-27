using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E34 RID: 7732
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcHighFivePerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600A563 RID: 42339 RVA: 0x00176A80 File Offset: 0x00174C80
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

		// Token: 0x0600A564 RID: 42340 RVA: 0x00176AB8 File Offset: 0x00174CB8
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

		// Token: 0x0600A565 RID: 42341 RVA: 0x00176ACB File Offset: 0x00174CCB
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

		// Token: 0x0600A566 RID: 42342 RVA: 0x00176ADE File Offset: 0x00174CDE
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

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600A567 RID: 42343 RVA: 0x00176B15 File Offset: 0x00174D15
		// (set) Token: 0x0600A568 RID: 42344 RVA: 0x00176B40 File Offset: 0x00174D40
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

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600A569 RID: 42345 RVA: 0x00176B50 File Offset: 0x00174D50
		// (set) Token: 0x0600A56A RID: 42346 RVA: 0x00176BB1 File Offset: 0x00174DB1
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

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600A56B RID: 42347 RVA: 0x00176BC6 File Offset: 0x00174DC6
		// (set) Token: 0x0600A56C RID: 42348 RVA: 0x00176BF1 File Offset: 0x00174DF1
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

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600A56D RID: 42349 RVA: 0x00176BFF File Offset: 0x00174DFF
		// (set) Token: 0x0600A56E RID: 42350 RVA: 0x00176C2A File Offset: 0x00174E2A
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

		// Token: 0x040062E5 RID: 25317
		[Nullable(2)]
		protected new ISetNpcHighFivePerform FbInstance;

		// Token: 0x040062E6 RID: 25318
		[Nullable(2)]
		protected new ISetNpcHighFivePerform_SetValue PocoInterface;

		// Token: 0x040062E7 RID: 25319
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x040062E8 RID: 25320
		private bool _InitiatorInited;
	}
}

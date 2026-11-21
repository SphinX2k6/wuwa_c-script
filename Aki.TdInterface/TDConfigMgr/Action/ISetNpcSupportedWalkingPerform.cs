using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200206D RID: 8301
	public class ISetNpcSupportedWalkingPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600B037 RID: 45111 RVA: 0x0018CB10 File Offset: 0x0018AD10
		private ISetNpcSupportedWalkingPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetNpcSupportedWalkingPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetNpcSupportedWalkingPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetNpcSupportedWalkingPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600B038 RID: 45112 RVA: 0x0018CB48 File Offset: 0x0018AD48
		public static ISetNpcSupportedWalkingPerform Create([Nullable(2)] ISetNpcSupportedWalkingPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcSupportedWalkingPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B039 RID: 45113 RVA: 0x0018CB5B File Offset: 0x0018AD5B
		public static ISetNpcSupportedWalkingPerform CreateFromSetValue([Nullable(2)] ISetNpcSupportedWalkingPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetNpcSupportedWalkingPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B03A RID: 45114 RVA: 0x0018CB6E File Offset: 0x0018AD6E
		public new ISetNpcSupportedWalkingPerform_SetValue ToSetValue()
		{
			return new ISetNpcSupportedWalkingPerform_SetValue
			{
				Type = this.Type,
				Initiator = this.Initiator,
				Target = this.Target
			};
		}

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x0600B03B RID: 45115 RVA: 0x0018CB99 File Offset: 0x0018AD99
		// (set) Token: 0x0600B03C RID: 45116 RVA: 0x0018CBC4 File Offset: 0x0018ADC4
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

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x0600B03D RID: 45117 RVA: 0x0018CBD4 File Offset: 0x0018ADD4
		// (set) Token: 0x0600B03E RID: 45118 RVA: 0x0018CC35 File Offset: 0x0018AE35
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
					ISetNpcSupportedWalkingPerform_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0600B03F RID: 45119 RVA: 0x0018CC4A File Offset: 0x0018AE4A
		// (set) Token: 0x0600B040 RID: 45120 RVA: 0x0018CC75 File Offset: 0x0018AE75
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

		// Token: 0x040068D9 RID: 26841
		[Nullable(2)]
		protected new ISetNpcSupportedWalkingPerform FbInstance;

		// Token: 0x040068DA RID: 26842
		[Nullable(2)]
		protected new ISetNpcSupportedWalkingPerform_SetValue PocoInterface;

		// Token: 0x040068DB RID: 26843
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x040068DC RID: 26844
		private bool _InitiatorInited;
	}
}

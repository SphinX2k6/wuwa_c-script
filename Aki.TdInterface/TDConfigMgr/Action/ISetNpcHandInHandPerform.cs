using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E32 RID: 7730
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcHandInHandPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600A557 RID: 42327 RVA: 0x001768FC File Offset: 0x00174AFC
		private ISetNpcHandInHandPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetNpcHandInHandPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetNpcHandInHandPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetNpcHandInHandPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600A558 RID: 42328 RVA: 0x00176934 File Offset: 0x00174B34
		public static ISetNpcHandInHandPerform Create([Nullable(2)] ISetNpcHandInHandPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcHandInHandPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A559 RID: 42329 RVA: 0x00176947 File Offset: 0x00174B47
		public static ISetNpcHandInHandPerform CreateFromSetValue([Nullable(2)] ISetNpcHandInHandPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetNpcHandInHandPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A55A RID: 42330 RVA: 0x0017695A File Offset: 0x00174B5A
		public new ISetNpcHandInHandPerform_SetValue ToSetValue()
		{
			return new ISetNpcHandInHandPerform_SetValue
			{
				Type = this.Type,
				Initiator = this.Initiator,
				Follower = this.Follower
			};
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600A55B RID: 42331 RVA: 0x00176985 File Offset: 0x00174B85
		// (set) Token: 0x0600A55C RID: 42332 RVA: 0x001769B0 File Offset: 0x00174BB0
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

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600A55D RID: 42333 RVA: 0x001769C0 File Offset: 0x00174BC0
		// (set) Token: 0x0600A55E RID: 42334 RVA: 0x00176A21 File Offset: 0x00174C21
		public virtual IHandInHandInitiator Initiator
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
					this._InitiatorCache = IHandInHandInitiator.Create(this.FbInstance.Initiator);
				}
				else
				{
					ISetNpcHandInHandPerform_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600A55F RID: 42335 RVA: 0x00176A36 File Offset: 0x00174C36
		// (set) Token: 0x0600A560 RID: 42336 RVA: 0x00176A61 File Offset: 0x00174C61
		public virtual int Follower
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Follower;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Follower;
			}
			set
			{
				this.GetOrCreatePoco().Follower = value;
			}
		}

		// Token: 0x040062DE RID: 25310
		[Nullable(2)]
		protected new ISetNpcHandInHandPerform FbInstance;

		// Token: 0x040062DF RID: 25311
		[Nullable(2)]
		protected new ISetNpcHandInHandPerform_SetValue PocoInterface;

		// Token: 0x040062E0 RID: 25312
		private IHandInHandInitiator _InitiatorCache;

		// Token: 0x040062E1 RID: 25313
		private bool _InitiatorInited;
	}
}

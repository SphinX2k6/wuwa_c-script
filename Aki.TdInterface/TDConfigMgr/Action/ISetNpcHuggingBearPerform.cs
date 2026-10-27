using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E36 RID: 7734
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcHuggingBearPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600A571 RID: 42353 RVA: 0x00176C48 File Offset: 0x00174E48
		private ISetNpcHuggingBearPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetNpcHuggingBearPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetNpcHuggingBearPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetNpcHuggingBearPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600A572 RID: 42354 RVA: 0x00176C80 File Offset: 0x00174E80
		public static ISetNpcHuggingBearPerform Create([Nullable(2)] ISetNpcHuggingBearPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcHuggingBearPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x00176C93 File Offset: 0x00174E93
		public static ISetNpcHuggingBearPerform CreateFromSetValue([Nullable(2)] ISetNpcHuggingBearPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetNpcHuggingBearPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x00176CA6 File Offset: 0x00174EA6
		public new ISetNpcHuggingBearPerform_SetValue ToSetValue()
		{
			return new ISetNpcHuggingBearPerform_SetValue
			{
				Type = this.Type,
				Initiator = this.Initiator,
				Target = this.Target,
				NpcType = this.NpcType
			};
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600A575 RID: 42357 RVA: 0x00176CDD File Offset: 0x00174EDD
		// (set) Token: 0x0600A576 RID: 42358 RVA: 0x00176D08 File Offset: 0x00174F08
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

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600A577 RID: 42359 RVA: 0x00176D18 File Offset: 0x00174F18
		// (set) Token: 0x0600A578 RID: 42360 RVA: 0x00176D79 File Offset: 0x00174F79
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
					ISetNpcHuggingBearPerform_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600A579 RID: 42361 RVA: 0x00176D8E File Offset: 0x00174F8E
		// (set) Token: 0x0600A57A RID: 42362 RVA: 0x00176DB9 File Offset: 0x00174FB9
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

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600A57B RID: 42363 RVA: 0x00176DC7 File Offset: 0x00174FC7
		// (set) Token: 0x0600A57C RID: 42364 RVA: 0x00176DF2 File Offset: 0x00174FF2
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

		// Token: 0x040062ED RID: 25325
		[Nullable(2)]
		protected new ISetNpcHuggingBearPerform FbInstance;

		// Token: 0x040062EE RID: 25326
		[Nullable(2)]
		protected new ISetNpcHuggingBearPerform_SetValue PocoInterface;

		// Token: 0x040062EF RID: 25327
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x040062F0 RID: 25328
		private bool _InitiatorInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017A2 RID: 6050
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorVisibility
	{
		// Token: 0x06008009 RID: 32777 RVA: 0x00131B60 File Offset: 0x0012FD60
		private IActorVisibility_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorVisibility 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorVisibility_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorVisibility_SetValue());
			}
			return result;
		}

		// Token: 0x0600800A RID: 32778 RVA: 0x00131B98 File Offset: 0x0012FD98
		public static IActorVisibility Create([Nullable(2)] IActorVisibility instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorVisibility
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600800B RID: 32779 RVA: 0x00131BAB File Offset: 0x0012FDAB
		public static IActorVisibility CreateFromSetValue([Nullable(2)] IActorVisibility_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorVisibility
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600800C RID: 32780 RVA: 0x00131BC0 File Offset: 0x0012FDC0
		public IActorVisibility_SetValue ToSetValue()
		{
			return new IActorVisibility_SetValue
			{
				ActorIndex = this.ActorIndex,
				PlayMode = this.PlayMode,
				Effect = this.Effect,
				FadeDuration = this.FadeDuration,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x0600800D RID: 32781 RVA: 0x00131C0E File Offset: 0x0012FE0E
		// (set) Token: 0x0600800E RID: 32782 RVA: 0x00131C39 File Offset: 0x0012FE39
		public virtual int ActorIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActorIndex;
			}
			set
			{
				this.GetOrCreatePoco().ActorIndex = value;
			}
		}

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x0600800F RID: 32783 RVA: 0x00131C47 File Offset: 0x0012FE47
		// (set) Token: 0x06008010 RID: 32784 RVA: 0x00131C72 File Offset: 0x0012FE72
		public virtual EActorVisibilityPlayMode PlayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayMode;
				}
				if (this.PocoInterface == null)
				{
					return EActorVisibilityPlayMode.FadeIn;
				}
				return this.PocoInterface.PlayMode;
			}
			set
			{
				this.GetOrCreatePoco().PlayMode = value;
			}
		}

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x06008011 RID: 32785 RVA: 0x00131C80 File Offset: 0x0012FE80
		// (set) Token: 0x06008012 RID: 32786 RVA: 0x00131CE1 File Offset: 0x0012FEE1
		public virtual IActorVisibilityEffectDefault Effect
		{
			get
			{
				if (this._EffectInited)
				{
					return this._EffectCache;
				}
				this._EffectInited = true;
				if (this.FbInstance != null)
				{
					this._EffectCache = IActorVisibilityEffectDefault.Create(this.FbInstance.Effect);
				}
				else
				{
					IActorVisibility_SetValue pocoInterface = this.PocoInterface;
					this._EffectCache = ((pocoInterface != null) ? pocoInterface.Effect : null);
				}
				return this._EffectCache;
			}
			set
			{
				this.GetOrCreatePoco().Effect = value;
				this._EffectInited = false;
			}
		}

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x06008013 RID: 32787 RVA: 0x00131CF8 File Offset: 0x0012FEF8
		// (set) Token: 0x06008014 RID: 32788 RVA: 0x00131D32 File Offset: 0x0012FF32
		public virtual float? FadeDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeDuration;
				}
				IActorVisibility_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeDuration;
			}
			set
			{
				this.GetOrCreatePoco().FadeDuration = value;
			}
		}

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x06008015 RID: 32789 RVA: 0x00131D40 File Offset: 0x0012FF40
		// (set) Token: 0x06008016 RID: 32790 RVA: 0x00131D7A File Offset: 0x0012FF7A
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IActorVisibility_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x04005149 RID: 20809
		[Nullable(2)]
		protected IActorVisibility FbInstance;

		// Token: 0x0400514A RID: 20810
		[Nullable(2)]
		protected IActorVisibility_SetValue PocoInterface;

		// Token: 0x0400514B RID: 20811
		private IActorVisibilityEffectDefault _EffectCache;

		// Token: 0x0400514C RID: 20812
		private bool _EffectInited;
	}
}

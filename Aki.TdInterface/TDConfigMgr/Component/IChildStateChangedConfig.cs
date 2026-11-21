using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000266 RID: 614
	public class IChildStateChangedConfig
	{
		// Token: 0x06000AB6 RID: 2742 RVA: 0x0002C868 File Offset: 0x0002AA68
		private IChildStateChangedConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChildStateChangedConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChildStateChangedConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChildStateChangedConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0002C8A0 File Offset: 0x0002AAA0
		public static IChildStateChangedConfig Create([Nullable(2)] IChildStateChangedConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChildStateChangedConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0002C8B3 File Offset: 0x0002AAB3
		public static IChildStateChangedConfig CreateFromSetValue([Nullable(2)] IChildStateChangedConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChildStateChangedConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0002C8C6 File Offset: 0x0002AAC6
		public IChildStateChangedConfig_SetValue ToSetValue()
		{
			return new IChildStateChangedConfig_SetValue
			{
				State = this.State,
				DelayChangeState = this.DelayChangeState
			};
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0002C8E5 File Offset: 0x0002AAE5
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x0002C910 File Offset: 0x0002AB10
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0002C920 File Offset: 0x0002AB20
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x0002C981 File Offset: 0x0002AB81
		[Nullable(2)]
		public virtual IDelayChangeState DelayChangeState
		{
			[NullableContext(2)]
			get
			{
				if (this._DelayChangeStateInited)
				{
					return this._DelayChangeStateCache;
				}
				this._DelayChangeStateInited = true;
				if (this.FbInstance != null)
				{
					this._DelayChangeStateCache = IDelayChangeState.Create(this.FbInstance.DelayChangeState);
				}
				else
				{
					IChildStateChangedConfig_SetValue pocoInterface = this.PocoInterface;
					this._DelayChangeStateCache = ((pocoInterface != null) ? pocoInterface.DelayChangeState : null);
				}
				return this._DelayChangeStateCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DelayChangeState = value;
				this._DelayChangeStateInited = false;
			}
		}

		// Token: 0x04000AD6 RID: 2774
		[Nullable(2)]
		protected IChildStateChangedConfig FbInstance;

		// Token: 0x04000AD7 RID: 2775
		[Nullable(2)]
		protected IChildStateChangedConfig_SetValue PocoInterface;

		// Token: 0x04000AD8 RID: 2776
		private IDelayChangeState _DelayChangeStateCache;

		// Token: 0x04000AD9 RID: 2777
		private bool _DelayChangeStateInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AC7 RID: 6855
	[NullableContext(1)]
	[Nullable(0)]
	public class IGamepadShakeInTalk
	{
		// Token: 0x06009300 RID: 37632 RVA: 0x00155704 File Offset: 0x00153904
		private IGamepadShakeInTalk_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGamepadShakeInTalk 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGamepadShakeInTalk_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGamepadShakeInTalk_SetValue());
			}
			return result;
		}

		// Token: 0x06009301 RID: 37633 RVA: 0x0015573C File Offset: 0x0015393C
		public static IGamepadShakeInTalk Create([Nullable(2)] IGamepadShakeInTalk instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGamepadShakeInTalk
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009302 RID: 37634 RVA: 0x0015574F File Offset: 0x0015394F
		public static IGamepadShakeInTalk CreateFromSetValue([Nullable(2)] IGamepadShakeInTalk_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGamepadShakeInTalk
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009303 RID: 37635 RVA: 0x00155762 File Offset: 0x00153962
		public IGamepadShakeInTalk_SetValue ToSetValue()
		{
			return new IGamepadShakeInTalk_SetValue
			{
				DelayTime = this.DelayTime,
				Options = this.Options
			};
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x06009304 RID: 37636 RVA: 0x00155781 File Offset: 0x00153981
		// (set) Token: 0x06009305 RID: 37637 RVA: 0x001557B0 File Offset: 0x001539B0
		public virtual float DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x06009306 RID: 37638 RVA: 0x001557C0 File Offset: 0x001539C0
		// (set) Token: 0x06009307 RID: 37639 RVA: 0x00155821 File Offset: 0x00153A21
		public virtual IGamepadShakeOptions Options
		{
			get
			{
				if (this._OptionsInited)
				{
					return this._OptionsCache;
				}
				this._OptionsInited = true;
				if (this.FbInstance != null)
				{
					this._OptionsCache = IGamepadShakeOptions.Create(this.FbInstance.Options);
				}
				else
				{
					IGamepadShakeInTalk_SetValue pocoInterface = this.PocoInterface;
					this._OptionsCache = ((pocoInterface != null) ? pocoInterface.Options : null);
				}
				return this._OptionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Options = value;
				this._OptionsInited = false;
			}
		}

		// Token: 0x04005A6C RID: 23148
		[Nullable(2)]
		protected IGamepadShakeInTalk FbInstance;

		// Token: 0x04005A6D RID: 23149
		[Nullable(2)]
		protected IGamepadShakeInTalk_SetValue PocoInterface;

		// Token: 0x04005A6E RID: 23150
		private IGamepadShakeOptions _OptionsCache;

		// Token: 0x04005A6F RID: 23151
		private bool _OptionsInited;
	}
}

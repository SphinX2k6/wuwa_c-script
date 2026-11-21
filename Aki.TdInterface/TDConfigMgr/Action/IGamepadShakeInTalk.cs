using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C6E RID: 7278
	public class IGamepadShakeInTalk
	{
		// Token: 0x06009ABE RID: 39614 RVA: 0x00165F24 File Offset: 0x00164124
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

		// Token: 0x06009ABF RID: 39615 RVA: 0x00165F5C File Offset: 0x0016415C
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

		// Token: 0x06009AC0 RID: 39616 RVA: 0x00165F6F File Offset: 0x0016416F
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

		// Token: 0x06009AC1 RID: 39617 RVA: 0x00165F82 File Offset: 0x00164182
		public IGamepadShakeInTalk_SetValue ToSetValue()
		{
			return new IGamepadShakeInTalk_SetValue
			{
				DelayTime = this.DelayTime,
				Options = this.Options
			};
		}

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x06009AC2 RID: 39618 RVA: 0x00165FA1 File Offset: 0x001641A1
		// (set) Token: 0x06009AC3 RID: 39619 RVA: 0x00165FD0 File Offset: 0x001641D0
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

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x06009AC4 RID: 39620 RVA: 0x00165FE0 File Offset: 0x001641E0
		// (set) Token: 0x06009AC5 RID: 39621 RVA: 0x00166041 File Offset: 0x00164241
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

		// Token: 0x04005EF6 RID: 24310
		[Nullable(2)]
		protected IGamepadShakeInTalk FbInstance;

		// Token: 0x04005EF7 RID: 24311
		[Nullable(2)]
		protected IGamepadShakeInTalk_SetValue PocoInterface;

		// Token: 0x04005EF8 RID: 24312
		private IGamepadShakeOptions _OptionsCache;

		// Token: 0x04005EF9 RID: 24313
		private bool _OptionsInited;
	}
}

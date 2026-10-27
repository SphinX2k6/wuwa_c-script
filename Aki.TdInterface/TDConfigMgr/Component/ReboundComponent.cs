using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000867 RID: 2151
	[NullableContext(1)]
	[Nullable(0)]
	public class ReboundComponent : IComponentBase
	{
		// Token: 0x06002F9D RID: 12189 RVA: 0x0007ADAC File Offset: 0x00078FAC
		private ReboundComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReboundComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReboundComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReboundComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x0007ADE4 File Offset: 0x00078FE4
		public static ReboundComponent Create([Nullable(2)] ReboundComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReboundComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x0007ADF7 File Offset: 0x00078FF7
		public static ReboundComponent CreateFromSetValue([Nullable(2)] ReboundComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReboundComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x0007AE0A File Offset: 0x0007900A
		public new ReboundComponent_SetValue ToSetValue()
		{
			return new ReboundComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				BulletId = this.BulletId,
				Option = this.Option
			};
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x0007AE44 File Offset: 0x00079044
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x0007AE7E File Offset: 0x0007907E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ReboundComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x0007AE8C File Offset: 0x0007908C
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x0007AEB6 File Offset: 0x000790B6
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x0007AEC4 File Offset: 0x000790C4
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x0007AEF0 File Offset: 0x000790F0
		public virtual long BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x0007AF00 File Offset: 0x00079100
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x0007AF61 File Offset: 0x00079161
		public virtual IForwardFrontRebound Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				if (this.FbInstance != null)
				{
					this._OptionCache = IForwardFrontRebound.Create(this.FbInstance.Option);
				}
				else
				{
					ReboundComponent_SetValue pocoInterface = this.PocoInterface;
					this._OptionCache = ((pocoInterface != null) ? pocoInterface.Option : null);
				}
				return this._OptionCache;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
				this._OptionInited = false;
			}
		}

		// Token: 0x04001F69 RID: 8041
		[Nullable(2)]
		protected new ReboundComponent FbInstance;

		// Token: 0x04001F6A RID: 8042
		[Nullable(2)]
		protected new ReboundComponent_SetValue PocoInterface;

		// Token: 0x04001F6B RID: 8043
		private IForwardFrontRebound _OptionCache;

		// Token: 0x04001F6C RID: 8044
		private bool _OptionInited;
	}
}

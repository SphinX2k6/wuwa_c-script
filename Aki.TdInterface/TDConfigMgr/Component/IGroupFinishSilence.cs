using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000402 RID: 1026
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupFinishSilence : IGroupFinishConfig
	{
		// Token: 0x060014B1 RID: 5297 RVA: 0x00041D28 File Offset: 0x0003FF28
		private IGroupFinishSilence_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupFinishSilence 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupFinishSilence_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupFinishSilence_SetValue());
			}
			return result;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00041D60 File Offset: 0x0003FF60
		public static IGroupFinishSilence Create([Nullable(2)] IGroupFinishSilence instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupFinishSilence
			{
				FbInstance = instance
			};
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00041D73 File Offset: 0x0003FF73
		public static IGroupFinishSilence CreateFromSetValue([Nullable(2)] IGroupFinishSilence_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupFinishSilence
			{
				PocoInterface = value
			};
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00041D86 File Offset: 0x0003FF86
		public new IGroupFinishSilence_SetValue ToSetValue()
		{
			return new IGroupFinishSilence_SetValue
			{
				Type = this.Type,
				SwitchSpecifiedStatus = this.SwitchSpecifiedStatus
			};
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x00041DA5 File Offset: 0x0003FFA5
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x00041DD0 File Offset: 0x0003FFD0
		public override EGroupFinishConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupFinishConfig.Silence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00041DE0 File Offset: 0x0003FFE0
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x00041E41 File Offset: 0x00040041
		[Nullable(2)]
		public virtual IEntityState SwitchSpecifiedStatus
		{
			[NullableContext(2)]
			get
			{
				if (this._SwitchSpecifiedStatusInited)
				{
					return this._SwitchSpecifiedStatusCache;
				}
				this._SwitchSpecifiedStatusInited = true;
				if (this.FbInstance != null)
				{
					this._SwitchSpecifiedStatusCache = IEntityState.Create(this.FbInstance.SwitchSpecifiedStatus);
				}
				else
				{
					IGroupFinishSilence_SetValue pocoInterface = this.PocoInterface;
					this._SwitchSpecifiedStatusCache = ((pocoInterface != null) ? pocoInterface.SwitchSpecifiedStatus : null);
				}
				return this._SwitchSpecifiedStatusCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SwitchSpecifiedStatus = value;
				this._SwitchSpecifiedStatusInited = false;
			}
		}

		// Token: 0x04001036 RID: 4150
		[Nullable(2)]
		protected new IGroupFinishSilence FbInstance;

		// Token: 0x04001037 RID: 4151
		[Nullable(2)]
		protected new IGroupFinishSilence_SetValue PocoInterface;

		// Token: 0x04001038 RID: 4152
		private IEntityState _SwitchSpecifiedStatusCache;

		// Token: 0x04001039 RID: 4153
		private bool _SwitchSpecifiedStatusInited;
	}
}

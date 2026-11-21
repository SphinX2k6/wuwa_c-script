using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C04 RID: 7172
	public class IFixedPos : ITeleportConfig
	{
		// Token: 0x06009854 RID: 38996 RVA: 0x001618E4 File Offset: 0x0015FAE4
		private IFixedPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixedPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixedPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixedPos_SetValue());
			}
			return result;
		}

		// Token: 0x06009855 RID: 38997 RVA: 0x0016191C File Offset: 0x0015FB1C
		public static IFixedPos Create([Nullable(2)] IFixedPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009856 RID: 38998 RVA: 0x0016192F File Offset: 0x0015FB2F
		public static IFixedPos CreateFromSetValue([Nullable(2)] IFixedPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixedPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009857 RID: 38999 RVA: 0x00161942 File Offset: 0x0015FB42
		public new IFixedPos_SetValue ToSetValue()
		{
			return new IFixedPos_SetValue
			{
				Type = this.Type,
				TargetPos = this.TargetPos
			};
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x06009858 RID: 39000 RVA: 0x00161961 File Offset: 0x0015FB61
		// (set) Token: 0x06009859 RID: 39001 RVA: 0x0016198C File Offset: 0x0015FB8C
		public override ETeleportType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportType.FixedPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x0600985A RID: 39002 RVA: 0x0016199C File Offset: 0x0015FB9C
		// (set) Token: 0x0600985B RID: 39003 RVA: 0x001619FD File Offset: 0x0015FBFD
		public virtual PosA TargetPos
		{
			get
			{
				if (this._TargetPosInited)
				{
					return this._TargetPosCache;
				}
				this._TargetPosInited = true;
				if (this.FbInstance != null)
				{
					this._TargetPosCache = PosA.Create(this.FbInstance.TargetPos);
				}
				else
				{
					IFixedPos_SetValue pocoInterface = this.PocoInterface;
					this._TargetPosCache = ((pocoInterface != null) ? pocoInterface.TargetPos : null);
				}
				return this._TargetPosCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetPos = value;
				this._TargetPosInited = false;
			}
		}

		// Token: 0x04005DD6 RID: 24022
		[Nullable(2)]
		protected new IFixedPos FbInstance;

		// Token: 0x04005DD7 RID: 24023
		[Nullable(2)]
		protected new IFixedPos_SetValue PocoInterface;

		// Token: 0x04005DD8 RID: 24024
		private PosA _TargetPosCache;

		// Token: 0x04005DD9 RID: 24025
		private bool _TargetPosInited;
	}
}

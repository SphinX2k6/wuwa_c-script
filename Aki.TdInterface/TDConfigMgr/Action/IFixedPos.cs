using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A6F RID: 6767
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedPos : ITeleportConfig
	{
		// Token: 0x060090EA RID: 37098 RVA: 0x001519B8 File Offset: 0x0014FBB8
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

		// Token: 0x060090EB RID: 37099 RVA: 0x001519F0 File Offset: 0x0014FBF0
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

		// Token: 0x060090EC RID: 37100 RVA: 0x00151A03 File Offset: 0x0014FC03
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

		// Token: 0x060090ED RID: 37101 RVA: 0x00151A16 File Offset: 0x0014FC16
		public new IFixedPos_SetValue ToSetValue()
		{
			return new IFixedPos_SetValue
			{
				Type = this.Type,
				TargetPos = this.TargetPos
			};
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x060090EE RID: 37102 RVA: 0x00151A35 File Offset: 0x0014FC35
		// (set) Token: 0x060090EF RID: 37103 RVA: 0x00151A60 File Offset: 0x0014FC60
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

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x060090F0 RID: 37104 RVA: 0x00151A70 File Offset: 0x0014FC70
		// (set) Token: 0x060090F1 RID: 37105 RVA: 0x00151AD1 File Offset: 0x0014FCD1
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

		// Token: 0x04005971 RID: 22897
		[Nullable(2)]
		protected new IFixedPos FbInstance;

		// Token: 0x04005972 RID: 22898
		[Nullable(2)]
		protected new IFixedPos_SetValue PocoInterface;

		// Token: 0x04005973 RID: 22899
		private PosA _TargetPosCache;

		// Token: 0x04005974 RID: 22900
		private bool _TargetPosInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A73 RID: 6771
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixTeleControllerResetPos : ActionParams
	{
		// Token: 0x060090FE RID: 37118 RVA: 0x00151BF8 File Offset: 0x0014FDF8
		private IFixTeleControllerResetPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixTeleControllerResetPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixTeleControllerResetPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixTeleControllerResetPos_SetValue());
			}
			return result;
		}

		// Token: 0x060090FF RID: 37119 RVA: 0x00151C30 File Offset: 0x0014FE30
		public static IFixTeleControllerResetPos Create([Nullable(2)] IFixTeleControllerResetPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixTeleControllerResetPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009100 RID: 37120 RVA: 0x00151C43 File Offset: 0x0014FE43
		public static IFixTeleControllerResetPos CreateFromSetValue([Nullable(2)] IFixTeleControllerResetPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixTeleControllerResetPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009101 RID: 37121 RVA: 0x00151C56 File Offset: 0x0014FE56
		public IFixTeleControllerResetPos_SetValue ToSetValue()
		{
			return new IFixTeleControllerResetPos_SetValue
			{
				PositionEntityId = this.PositionEntityId
			};
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x06009102 RID: 37122 RVA: 0x00151C69 File Offset: 0x0014FE69
		// (set) Token: 0x06009103 RID: 37123 RVA: 0x00151C94 File Offset: 0x0014FE94
		public virtual int PositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PositionEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PositionEntityId = value;
			}
		}

		// Token: 0x0400597B RID: 22907
		[Nullable(2)]
		protected new IFixTeleControllerResetPos FbInstance;

		// Token: 0x0400597C RID: 22908
		[Nullable(2)]
		protected IFixTeleControllerResetPos_SetValue PocoInterface;
	}
}

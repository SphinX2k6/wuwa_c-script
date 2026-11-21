using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C08 RID: 7176
	public class IFixTeleControllerResetPos : ActionParams
	{
		// Token: 0x06009868 RID: 39016 RVA: 0x00161B24 File Offset: 0x0015FD24
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

		// Token: 0x06009869 RID: 39017 RVA: 0x00161B5C File Offset: 0x0015FD5C
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

		// Token: 0x0600986A RID: 39018 RVA: 0x00161B6F File Offset: 0x0015FD6F
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

		// Token: 0x0600986B RID: 39019 RVA: 0x00161B82 File Offset: 0x0015FD82
		public IFixTeleControllerResetPos_SetValue ToSetValue()
		{
			return new IFixTeleControllerResetPos_SetValue
			{
				PositionEntityId = this.PositionEntityId
			};
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x0600986C RID: 39020 RVA: 0x00161B95 File Offset: 0x0015FD95
		// (set) Token: 0x0600986D RID: 39021 RVA: 0x00161BC0 File Offset: 0x0015FDC0
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

		// Token: 0x04005DE0 RID: 24032
		[Nullable(2)]
		protected new IFixTeleControllerResetPos FbInstance;

		// Token: 0x04005DE1 RID: 24033
		[Nullable(2)]
		protected IFixTeleControllerResetPos_SetValue PocoInterface;
	}
}

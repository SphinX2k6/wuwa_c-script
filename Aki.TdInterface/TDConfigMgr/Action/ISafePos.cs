using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FE9 RID: 8169
	public class ISafePos : ITeleportConfig
	{
		// Token: 0x0600AD83 RID: 44419 RVA: 0x001879CC File Offset: 0x00185BCC
		private ISafePos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISafePos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISafePos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISafePos_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD84 RID: 44420 RVA: 0x00187A04 File Offset: 0x00185C04
		public static ISafePos Create([Nullable(2)] ISafePos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISafePos
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD85 RID: 44421 RVA: 0x00187A17 File Offset: 0x00185C17
		public static ISafePos CreateFromSetValue([Nullable(2)] ISafePos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISafePos
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD86 RID: 44422 RVA: 0x00187A2A File Offset: 0x00185C2A
		public new ISafePos_SetValue ToSetValue()
		{
			return new ISafePos_SetValue
			{
				Type = this.Type,
				FinalSafePosEntityId = this.FinalSafePosEntityId
			};
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0600AD87 RID: 44423 RVA: 0x00187A49 File Offset: 0x00185C49
		// (set) Token: 0x0600AD88 RID: 44424 RVA: 0x00187A74 File Offset: 0x00185C74
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

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0600AD89 RID: 44425 RVA: 0x00187A84 File Offset: 0x00185C84
		// (set) Token: 0x0600AD8A RID: 44426 RVA: 0x00187ABE File Offset: 0x00185CBE
		public virtual int? FinalSafePosEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FinalSafePosEntityId;
				}
				ISafePos_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FinalSafePosEntityId;
			}
			set
			{
				this.GetOrCreatePoco().FinalSafePosEntityId = value;
			}
		}

		// Token: 0x04006789 RID: 26505
		[Nullable(2)]
		protected new ISafePos FbInstance;

		// Token: 0x0400678A RID: 26506
		[Nullable(2)]
		protected new ISafePos_SetValue PocoInterface;
	}
}

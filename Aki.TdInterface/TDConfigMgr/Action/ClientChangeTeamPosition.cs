using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014FB RID: 5371
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientChangeTeamPosition : ActionParams
	{
		// Token: 0x06007A1C RID: 31260 RVA: 0x00123C60 File Offset: 0x00121E60
		private ClientChangeTeamPosition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientChangeTeamPosition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientChangeTeamPosition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientChangeTeamPosition_SetValue());
			}
			return result;
		}

		// Token: 0x06007A1D RID: 31261 RVA: 0x00123C98 File Offset: 0x00121E98
		public static ClientChangeTeamPosition Create([Nullable(2)] ClientChangeTeamPosition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientChangeTeamPosition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007A1E RID: 31262 RVA: 0x00123CAB File Offset: 0x00121EAB
		public static ClientChangeTeamPosition CreateFromSetValue([Nullable(2)] ClientChangeTeamPosition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientChangeTeamPosition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x00123CBE File Offset: 0x00121EBE
		public ClientChangeTeamPosition_SetValue ToSetValue()
		{
			return new ClientChangeTeamPosition_SetValue
			{
				PositionId = this.PositionId,
				RestoreToPrevious = this.RestoreToPrevious
			};
		}

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x06007A20 RID: 31264 RVA: 0x00123CDD File Offset: 0x00121EDD
		// (set) Token: 0x06007A21 RID: 31265 RVA: 0x00123D08 File Offset: 0x00121F08
		public virtual int PositionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PositionId;
			}
			set
			{
				this.GetOrCreatePoco().PositionId = value;
			}
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x06007A22 RID: 31266 RVA: 0x00123D18 File Offset: 0x00121F18
		// (set) Token: 0x06007A23 RID: 31267 RVA: 0x00123D52 File Offset: 0x00121F52
		public virtual bool? RestoreToPrevious
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RestoreToPrevious;
				}
				ClientChangeTeamPosition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RestoreToPrevious;
			}
			set
			{
				this.GetOrCreatePoco().RestoreToPrevious = value;
			}
		}

		// Token: 0x040046C5 RID: 18117
		[Nullable(2)]
		protected new ClientChangeTeamPosition FbInstance;

		// Token: 0x040046C6 RID: 18118
		[Nullable(2)]
		protected ClientChangeTeamPosition_SetValue PocoInterface;
	}
}

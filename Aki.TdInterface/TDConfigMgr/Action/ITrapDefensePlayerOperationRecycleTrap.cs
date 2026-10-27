using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FF0 RID: 8176
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefensePlayerOperationRecycleTrap : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600B3DA RID: 46042 RVA: 0x001A280C File Offset: 0x001A0A0C
		private ITrapDefensePlayerOperationRecycleTrap_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefensePlayerOperationRecycleTrap 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefensePlayerOperationRecycleTrap_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefensePlayerOperationRecycleTrap_SetValue());
			}
			return result;
		}

		// Token: 0x0600B3DB RID: 46043 RVA: 0x001A2844 File Offset: 0x001A0A44
		public static ITrapDefensePlayerOperationRecycleTrap Create([Nullable(2)] ITrapDefensePlayerOperationRecycleTrap instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationRecycleTrap
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B3DC RID: 46044 RVA: 0x001A2857 File Offset: 0x001A0A57
		public static ITrapDefensePlayerOperationRecycleTrap CreateFromSetValue([Nullable(2)] ITrapDefensePlayerOperationRecycleTrap_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationRecycleTrap
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x001A286A File Offset: 0x001A0A6A
		public new ITrapDefensePlayerOperationRecycleTrap_SetValue ToSetValue()
		{
			return new ITrapDefensePlayerOperationRecycleTrap_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x0600B3DE RID: 46046 RVA: 0x001A287D File Offset: 0x001A0A7D
		// (set) Token: 0x0600B3DF RID: 46047 RVA: 0x001A28A8 File Offset: 0x001A0AA8
		public override ETrapDefensePlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrapDefensePlayerOperationType.SpawnMonster;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006C76 RID: 27766
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationRecycleTrap FbInstance;

		// Token: 0x04006C77 RID: 27767
		[Nullable(2)]
		protected new ITrapDefensePlayerOperationRecycleTrap_SetValue PocoInterface;
	}
}

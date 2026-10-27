using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018CC RID: 6348
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientTpRelativeEntityPos : IClientTeleportConfig
	{
		// Token: 0x06008823 RID: 34851 RVA: 0x00142328 File Offset: 0x00140528
		private IClientTpRelativeEntityPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientTpRelativeEntityPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientTpRelativeEntityPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientTpRelativeEntityPos_SetValue());
			}
			return result;
		}

		// Token: 0x06008824 RID: 34852 RVA: 0x00142360 File Offset: 0x00140560
		public static IClientTpRelativeEntityPos Create([Nullable(2)] IClientTpRelativeEntityPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientTpRelativeEntityPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008825 RID: 34853 RVA: 0x00142373 File Offset: 0x00140573
		public static IClientTpRelativeEntityPos CreateFromSetValue([Nullable(2)] IClientTpRelativeEntityPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientTpRelativeEntityPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008826 RID: 34854 RVA: 0x00142386 File Offset: 0x00140586
		public new IClientTpRelativeEntityPos_SetValue ToSetValue()
		{
			return new IClientTpRelativeEntityPos_SetValue
			{
				Type = this.Type,
				SourcePosEntityId = this.SourcePosEntityId,
				TargetPosEntityId = this.TargetPosEntityId
			};
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x06008827 RID: 34855 RVA: 0x001423B1 File Offset: 0x001405B1
		// (set) Token: 0x06008828 RID: 34856 RVA: 0x001423DC File Offset: 0x001405DC
		public override EClientTeleportType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientTeleportType.RelativeEntityPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x06008829 RID: 34857 RVA: 0x001423EA File Offset: 0x001405EA
		// (set) Token: 0x0600882A RID: 34858 RVA: 0x00142415 File Offset: 0x00140615
		public virtual int SourcePosEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SourcePosEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SourcePosEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SourcePosEntityId = value;
			}
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x0600882B RID: 34859 RVA: 0x00142423 File Offset: 0x00140623
		// (set) Token: 0x0600882C RID: 34860 RVA: 0x0014244E File Offset: 0x0014064E
		public virtual int TargetPosEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetPosEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetPosEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TargetPosEntityId = value;
			}
		}

		// Token: 0x04005589 RID: 21897
		[Nullable(2)]
		protected new IClientTpRelativeEntityPos FbInstance;

		// Token: 0x0400558A RID: 21898
		[Nullable(2)]
		protected new IClientTpRelativeEntityPos_SetValue PocoInterface;
	}
}

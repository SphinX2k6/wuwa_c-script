using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A5D RID: 6749
	public class IClientTpRelativeEntityPos : IClientTeleportConfig
	{
		// Token: 0x06008F6B RID: 36715 RVA: 0x00151EA0 File Offset: 0x001500A0
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

		// Token: 0x06008F6C RID: 36716 RVA: 0x00151ED8 File Offset: 0x001500D8
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

		// Token: 0x06008F6D RID: 36717 RVA: 0x00151EEB File Offset: 0x001500EB
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

		// Token: 0x06008F6E RID: 36718 RVA: 0x00151EFE File Offset: 0x001500FE
		public new IClientTpRelativeEntityPos_SetValue ToSetValue()
		{
			return new IClientTpRelativeEntityPos_SetValue
			{
				Type = this.Type,
				SourcePosEntityId = this.SourcePosEntityId,
				TargetPosEntityId = this.TargetPosEntityId
			};
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x06008F6F RID: 36719 RVA: 0x00151F29 File Offset: 0x00150129
		// (set) Token: 0x06008F70 RID: 36720 RVA: 0x00151F54 File Offset: 0x00150154
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

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x06008F71 RID: 36721 RVA: 0x00151F62 File Offset: 0x00150162
		// (set) Token: 0x06008F72 RID: 36722 RVA: 0x00151F8D File Offset: 0x0015018D
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

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x06008F73 RID: 36723 RVA: 0x00151F9B File Offset: 0x0015019B
		// (set) Token: 0x06008F74 RID: 36724 RVA: 0x00151FC6 File Offset: 0x001501C6
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

		// Token: 0x040059E3 RID: 23011
		[Nullable(2)]
		protected new IClientTpRelativeEntityPos FbInstance;

		// Token: 0x040059E4 RID: 23012
		[Nullable(2)]
		protected new IClientTpRelativeEntityPos_SetValue PocoInterface;
	}
}

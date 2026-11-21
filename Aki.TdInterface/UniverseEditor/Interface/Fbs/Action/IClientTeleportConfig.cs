using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A77 RID: 27255
	public struct IClientTeleportConfig : IFlatbufferObject
	{
		// Token: 0x1700C82D RID: 51245
		// (get) Token: 0x0602EC2B RID: 191531 RVA: 0x0065F674 File Offset: 0x0065D874
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EC2C RID: 191532 RVA: 0x0065F681 File Offset: 0x0065D881
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EC2D RID: 191533 RVA: 0x0065F688 File Offset: 0x0065D888
		public static IClientTeleportConfig GetRootAsIClientTeleportConfig(ByteBuffer _bb)
		{
			return IClientTeleportConfig.GetRootAsIClientTeleportConfig(_bb, default(IClientTeleportConfig));
		}

		// Token: 0x0602EC2E RID: 191534 RVA: 0x0065F6A4 File Offset: 0x0065D8A4
		public static IClientTeleportConfig GetRootAsIClientTeleportConfig(ByteBuffer _bb, IClientTeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EC2F RID: 191535 RVA: 0x0065F6C1 File Offset: 0x0065D8C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EC30 RID: 191536 RVA: 0x0065F6D0 File Offset: 0x0065D8D0
		public IClientTeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C82E RID: 51246
		// (get) Token: 0x0602EC31 RID: 191537 RVA: 0x0065F6E0 File Offset: 0x0065D8E0
		public EClientTeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientTeleportType.RelativeEntityPos;
				}
				return (EClientTeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EC32 RID: 191538 RVA: 0x0065F71C File Offset: 0x0065D91C
		public static Offset<IClientTeleportConfig> CreateIClientTeleportConfig(FlatBufferBuilder builder, EClientTeleportType Type = EClientTeleportType.RelativeEntityPos)
		{
			builder.StartTable(1);
			IClientTeleportConfig.AddType(builder, Type);
			return IClientTeleportConfig.EndIClientTeleportConfig(builder);
		}

		// Token: 0x0602EC33 RID: 191539 RVA: 0x0065F732 File Offset: 0x0065D932
		public static void StartIClientTeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EC34 RID: 191540 RVA: 0x0065F73B File Offset: 0x0065D93B
		public static void AddType(FlatBufferBuilder builder, EClientTeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EC35 RID: 191541 RVA: 0x0065F746 File Offset: 0x0065D946
		public static Offset<IClientTeleportConfig> EndIClientTeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<IClientTeleportConfig>(builder.EndTable());
		}

		// Token: 0x0602EC36 RID: 191542 RVA: 0x0065F754 File Offset: 0x0065D954
		public IClientTeleportConfigT UnPack()
		{
			IClientTeleportConfigT clientTeleportConfigT = new IClientTeleportConfigT();
			this.UnPackTo(clientTeleportConfigT);
			return clientTeleportConfigT;
		}

		// Token: 0x0602EC37 RID: 191543 RVA: 0x0065F76F File Offset: 0x0065D96F
		public void UnPackTo(IClientTeleportConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EC38 RID: 191544 RVA: 0x0065F780 File Offset: 0x0065D980
		public static Offset<IClientTeleportConfig> Pack(FlatBufferBuilder builder, IClientTeleportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientTeleportConfig>);
			}
			return IClientTeleportConfig.CreateIClientTeleportConfig(builder, _o.Type);
		}

		// Token: 0x04011805 RID: 71685
		private Table __p;
	}
}

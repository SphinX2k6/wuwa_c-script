using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063F7 RID: 25591
	public struct IClientTeleportConfig : IFlatbufferObject
	{
		// Token: 0x1700BE93 RID: 48787
		// (get) Token: 0x0602C455 RID: 181333 RVA: 0x006137E8 File Offset: 0x006119E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C456 RID: 181334 RVA: 0x006137F5 File Offset: 0x006119F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C457 RID: 181335 RVA: 0x006137FC File Offset: 0x006119FC
		public static IClientTeleportConfig GetRootAsIClientTeleportConfig(ByteBuffer _bb)
		{
			return IClientTeleportConfig.GetRootAsIClientTeleportConfig(_bb, default(IClientTeleportConfig));
		}

		// Token: 0x0602C458 RID: 181336 RVA: 0x00613818 File Offset: 0x00611A18
		public static IClientTeleportConfig GetRootAsIClientTeleportConfig(ByteBuffer _bb, IClientTeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C459 RID: 181337 RVA: 0x00613835 File Offset: 0x00611A35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C45A RID: 181338 RVA: 0x00613844 File Offset: 0x00611A44
		public IClientTeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE94 RID: 48788
		// (get) Token: 0x0602C45B RID: 181339 RVA: 0x00613854 File Offset: 0x00611A54
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

		// Token: 0x0602C45C RID: 181340 RVA: 0x00613890 File Offset: 0x00611A90
		public static Offset<IClientTeleportConfig> CreateIClientTeleportConfig(FlatBufferBuilder builder, EClientTeleportType Type = EClientTeleportType.RelativeEntityPos)
		{
			builder.StartTable(1);
			IClientTeleportConfig.AddType(builder, Type);
			return IClientTeleportConfig.EndIClientTeleportConfig(builder);
		}

		// Token: 0x0602C45D RID: 181341 RVA: 0x006138A6 File Offset: 0x00611AA6
		public static void StartIClientTeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C45E RID: 181342 RVA: 0x006138AF File Offset: 0x00611AAF
		public static void AddType(FlatBufferBuilder builder, EClientTeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C45F RID: 181343 RVA: 0x006138BA File Offset: 0x00611ABA
		public static Offset<IClientTeleportConfig> EndIClientTeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<IClientTeleportConfig>(builder.EndTable());
		}

		// Token: 0x0602C460 RID: 181344 RVA: 0x006138C8 File Offset: 0x00611AC8
		public IClientTeleportConfigT UnPack()
		{
			IClientTeleportConfigT clientTeleportConfigT = new IClientTeleportConfigT();
			this.UnPackTo(clientTeleportConfigT);
			return clientTeleportConfigT;
		}

		// Token: 0x0602C461 RID: 181345 RVA: 0x006138E3 File Offset: 0x00611AE3
		public void UnPackTo(IClientTeleportConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C462 RID: 181346 RVA: 0x006138F4 File Offset: 0x00611AF4
		public static Offset<IClientTeleportConfig> Pack(FlatBufferBuilder builder, IClientTeleportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientTeleportConfig>);
			}
			return IClientTeleportConfig.CreateIClientTeleportConfig(builder, _o.Type);
		}

		// Token: 0x040109DF RID: 68063
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007139 RID: 28985
	public struct ILiveUiConfig : IFlatbufferObject
	{
		// Token: 0x1700D433 RID: 54323
		// (get) Token: 0x060325AE RID: 206254 RVA: 0x006CEF52 File Offset: 0x006CD152
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060325AF RID: 206255 RVA: 0x006CEF5F File Offset: 0x006CD15F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060325B0 RID: 206256 RVA: 0x006CEF68 File Offset: 0x006CD168
		public static ILiveUiConfig GetRootAsILiveUiConfig(ByteBuffer _bb)
		{
			return ILiveUiConfig.GetRootAsILiveUiConfig(_bb, default(ILiveUiConfig));
		}

		// Token: 0x060325B1 RID: 206257 RVA: 0x006CEF84 File Offset: 0x006CD184
		public static ILiveUiConfig GetRootAsILiveUiConfig(ByteBuffer _bb, ILiveUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060325B2 RID: 206258 RVA: 0x006CEFA1 File Offset: 0x006CD1A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060325B3 RID: 206259 RVA: 0x006CEFB0 File Offset: 0x006CD1B0
		public ILiveUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D434 RID: 54324
		// (get) Token: 0x060325B4 RID: 206260 RVA: 0x006CEFC0 File Offset: 0x006CD1C0
		public ELiveUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveUiType.Start;
				}
				return (ELiveUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060325B5 RID: 206261 RVA: 0x006CEFFC File Offset: 0x006CD1FC
		public static Offset<ILiveUiConfig> CreateILiveUiConfig(FlatBufferBuilder builder, ELiveUiType Type = ELiveUiType.Start)
		{
			builder.StartTable(1);
			ILiveUiConfig.AddType(builder, Type);
			return ILiveUiConfig.EndILiveUiConfig(builder);
		}

		// Token: 0x060325B6 RID: 206262 RVA: 0x006CF012 File Offset: 0x006CD212
		public static void StartILiveUiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060325B7 RID: 206263 RVA: 0x006CF01B File Offset: 0x006CD21B
		public static void AddType(FlatBufferBuilder builder, ELiveUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060325B8 RID: 206264 RVA: 0x006CF026 File Offset: 0x006CD226
		public static Offset<ILiveUiConfig> EndILiveUiConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveUiConfig>(builder.EndTable());
		}

		// Token: 0x060325B9 RID: 206265 RVA: 0x006CF034 File Offset: 0x006CD234
		public ILiveUiConfigT UnPack()
		{
			ILiveUiConfigT liveUiConfigT = new ILiveUiConfigT();
			this.UnPackTo(liveUiConfigT);
			return liveUiConfigT;
		}

		// Token: 0x060325BA RID: 206266 RVA: 0x006CF04F File Offset: 0x006CD24F
		public void UnPackTo(ILiveUiConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060325BB RID: 206267 RVA: 0x006CF060 File Offset: 0x006CD260
		public static Offset<ILiveUiConfig> Pack(FlatBufferBuilder builder, ILiveUiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveUiConfig>);
			}
			return ILiveUiConfig.CreateILiveUiConfig(builder, _o.Type);
		}

		// Token: 0x0401211D RID: 74013
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F04 RID: 20228
	public struct IBeamLayoutConfig : IFlatbufferObject
	{
		// Token: 0x170091A0 RID: 37280
		// (get) Token: 0x0601FF82 RID: 130946 RVA: 0x00473147 File Offset: 0x00471347
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FF83 RID: 130947 RVA: 0x00473154 File Offset: 0x00471354
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FF84 RID: 130948 RVA: 0x0047315C File Offset: 0x0047135C
		public static IBeamLayoutConfig GetRootAsIBeamLayoutConfig(ByteBuffer _bb)
		{
			return IBeamLayoutConfig.GetRootAsIBeamLayoutConfig(_bb, default(IBeamLayoutConfig));
		}

		// Token: 0x0601FF85 RID: 130949 RVA: 0x00473178 File Offset: 0x00471378
		public static IBeamLayoutConfig GetRootAsIBeamLayoutConfig(ByteBuffer _bb, IBeamLayoutConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FF86 RID: 130950 RVA: 0x00473195 File Offset: 0x00471395
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FF87 RID: 130951 RVA: 0x004731A4 File Offset: 0x004713A4
		public IBeamLayoutConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091A1 RID: 37281
		// (get) Token: 0x0601FF88 RID: 130952 RVA: 0x004731B4 File Offset: 0x004713B4
		public EBeamLayoutType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBeamLayoutType.BeamWall;
				}
				return (EBeamLayoutType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FF89 RID: 130953 RVA: 0x004731F0 File Offset: 0x004713F0
		public static Offset<IBeamLayoutConfig> CreateIBeamLayoutConfig(FlatBufferBuilder builder, EBeamLayoutType Type = EBeamLayoutType.BeamWall)
		{
			builder.StartTable(1);
			IBeamLayoutConfig.AddType(builder, Type);
			return IBeamLayoutConfig.EndIBeamLayoutConfig(builder);
		}

		// Token: 0x0601FF8A RID: 130954 RVA: 0x00473206 File Offset: 0x00471406
		public static void StartIBeamLayoutConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FF8B RID: 130955 RVA: 0x0047320F File Offset: 0x0047140F
		public static void AddType(FlatBufferBuilder builder, EBeamLayoutType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FF8C RID: 130956 RVA: 0x0047321A File Offset: 0x0047141A
		public static Offset<IBeamLayoutConfig> EndIBeamLayoutConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBeamLayoutConfig>(builder.EndTable());
		}

		// Token: 0x0601FF8D RID: 130957 RVA: 0x00473228 File Offset: 0x00471428
		public IBeamLayoutConfigT UnPack()
		{
			IBeamLayoutConfigT beamLayoutConfigT = new IBeamLayoutConfigT();
			this.UnPackTo(beamLayoutConfigT);
			return beamLayoutConfigT;
		}

		// Token: 0x0601FF8E RID: 130958 RVA: 0x00473243 File Offset: 0x00471443
		public void UnPackTo(IBeamLayoutConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FF8F RID: 130959 RVA: 0x00473254 File Offset: 0x00471454
		public static Offset<IBeamLayoutConfig> Pack(FlatBufferBuilder builder, IBeamLayoutConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeamLayoutConfig>);
			}
			return IBeamLayoutConfig.CreateIBeamLayoutConfig(builder, _o.Type);
		}

		// Token: 0x0400DD47 RID: 56647
		private Table __p;
	}
}

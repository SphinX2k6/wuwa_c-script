using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200739D RID: 29597
	public struct ITeleportTransitionInDigitalScreen : IFlatbufferObject
	{
		// Token: 0x1700E09F RID: 57503
		// (get) Token: 0x06035B6D RID: 220013 RVA: 0x0074FE36 File Offset: 0x0074E036
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B6E RID: 220014 RVA: 0x0074FE43 File Offset: 0x0074E043
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B6F RID: 220015 RVA: 0x0074FE4C File Offset: 0x0074E04C
		public static ITeleportTransitionInDigitalScreen GetRootAsITeleportTransitionInDigitalScreen(ByteBuffer _bb)
		{
			return ITeleportTransitionInDigitalScreen.GetRootAsITeleportTransitionInDigitalScreen(_bb, default(ITeleportTransitionInDigitalScreen));
		}

		// Token: 0x06035B70 RID: 220016 RVA: 0x0074FE68 File Offset: 0x0074E068
		public static ITeleportTransitionInDigitalScreen GetRootAsITeleportTransitionInDigitalScreen(ByteBuffer _bb, ITeleportTransitionInDigitalScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B71 RID: 220017 RVA: 0x0074FE85 File Offset: 0x0074E085
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B72 RID: 220018 RVA: 0x0074FE94 File Offset: 0x0074E094
		public ITeleportTransitionInDigitalScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0A0 RID: 57504
		// (get) Token: 0x06035B73 RID: 220019 RVA: 0x0074FEA4 File Offset: 0x0074E0A4
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E0A1 RID: 57505
		// (get) Token: 0x06035B74 RID: 220020 RVA: 0x0074FEE0 File Offset: 0x0074E0E0
		public int ConfigId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035B75 RID: 220021 RVA: 0x0074FF1C File Offset: 0x0074E11C
		public static Offset<ITeleportTransitionInDigitalScreen> CreateITeleportTransitionInDigitalScreen(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, int ConfigId = 0)
		{
			builder.StartTable(2);
			ITeleportTransitionInDigitalScreen.AddConfigId(builder, ConfigId);
			ITeleportTransitionInDigitalScreen.AddType(builder, Type);
			return ITeleportTransitionInDigitalScreen.EndITeleportTransitionInDigitalScreen(builder);
		}

		// Token: 0x06035B76 RID: 220022 RVA: 0x0074FF39 File Offset: 0x0074E139
		public static void StartITeleportTransitionInDigitalScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035B77 RID: 220023 RVA: 0x0074FF42 File Offset: 0x0074E142
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035B78 RID: 220024 RVA: 0x0074FF4D File Offset: 0x0074E14D
		public static void AddConfigId(FlatBufferBuilder builder, int configId)
		{
			builder.AddInt(1, configId, 0);
		}

		// Token: 0x06035B79 RID: 220025 RVA: 0x0074FF58 File Offset: 0x0074E158
		public static Offset<ITeleportTransitionInDigitalScreen> EndITeleportTransitionInDigitalScreen(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionInDigitalScreen>(builder.EndTable());
		}

		// Token: 0x06035B7A RID: 220026 RVA: 0x0074FF68 File Offset: 0x0074E168
		public ITeleportTransitionInDigitalScreenT UnPack()
		{
			ITeleportTransitionInDigitalScreenT teleportTransitionInDigitalScreenT = new ITeleportTransitionInDigitalScreenT();
			this.UnPackTo(teleportTransitionInDigitalScreenT);
			return teleportTransitionInDigitalScreenT;
		}

		// Token: 0x06035B7B RID: 220027 RVA: 0x0074FF83 File Offset: 0x0074E183
		public void UnPackTo(ITeleportTransitionInDigitalScreenT _o)
		{
			_o.Type = this.Type;
			_o.ConfigId = this.ConfigId;
		}

		// Token: 0x06035B7C RID: 220028 RVA: 0x0074FFA0 File Offset: 0x0074E1A0
		public static Offset<ITeleportTransitionInDigitalScreen> Pack(FlatBufferBuilder builder, ITeleportTransitionInDigitalScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionInDigitalScreen>);
			}
			return ITeleportTransitionInDigitalScreen.CreateITeleportTransitionInDigitalScreen(builder, _o.Type, _o.ConfigId);
		}

		// Token: 0x040121BA RID: 74170
		private Table __p;
	}
}

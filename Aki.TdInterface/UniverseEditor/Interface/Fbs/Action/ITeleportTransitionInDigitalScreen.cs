using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B84 RID: 31620
	public struct ITeleportTransitionInDigitalScreen : IFlatbufferObject
	{
		// Token: 0x1700ECAF RID: 60591
		// (get) Token: 0x06038F08 RID: 233224 RVA: 0x007B2376 File Offset: 0x007B0576
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038F09 RID: 233225 RVA: 0x007B2383 File Offset: 0x007B0583
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038F0A RID: 233226 RVA: 0x007B238C File Offset: 0x007B058C
		public static ITeleportTransitionInDigitalScreen GetRootAsITeleportTransitionInDigitalScreen(ByteBuffer _bb)
		{
			return ITeleportTransitionInDigitalScreen.GetRootAsITeleportTransitionInDigitalScreen(_bb, default(ITeleportTransitionInDigitalScreen));
		}

		// Token: 0x06038F0B RID: 233227 RVA: 0x007B23A8 File Offset: 0x007B05A8
		public static ITeleportTransitionInDigitalScreen GetRootAsITeleportTransitionInDigitalScreen(ByteBuffer _bb, ITeleportTransitionInDigitalScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038F0C RID: 233228 RVA: 0x007B23C5 File Offset: 0x007B05C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038F0D RID: 233229 RVA: 0x007B23D4 File Offset: 0x007B05D4
		public ITeleportTransitionInDigitalScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECB0 RID: 60592
		// (get) Token: 0x06038F0E RID: 233230 RVA: 0x007B23E4 File Offset: 0x007B05E4
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

		// Token: 0x1700ECB1 RID: 60593
		// (get) Token: 0x06038F0F RID: 233231 RVA: 0x007B2420 File Offset: 0x007B0620
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

		// Token: 0x06038F10 RID: 233232 RVA: 0x007B245C File Offset: 0x007B065C
		public static Offset<ITeleportTransitionInDigitalScreen> CreateITeleportTransitionInDigitalScreen(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, int ConfigId = 0)
		{
			builder.StartTable(2);
			ITeleportTransitionInDigitalScreen.AddConfigId(builder, ConfigId);
			ITeleportTransitionInDigitalScreen.AddType(builder, Type);
			return ITeleportTransitionInDigitalScreen.EndITeleportTransitionInDigitalScreen(builder);
		}

		// Token: 0x06038F11 RID: 233233 RVA: 0x007B2479 File Offset: 0x007B0679
		public static void StartITeleportTransitionInDigitalScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038F12 RID: 233234 RVA: 0x007B2482 File Offset: 0x007B0682
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038F13 RID: 233235 RVA: 0x007B248D File Offset: 0x007B068D
		public static void AddConfigId(FlatBufferBuilder builder, int configId)
		{
			builder.AddInt(1, configId, 0);
		}

		// Token: 0x06038F14 RID: 233236 RVA: 0x007B2498 File Offset: 0x007B0698
		public static Offset<ITeleportTransitionInDigitalScreen> EndITeleportTransitionInDigitalScreen(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionInDigitalScreen>(builder.EndTable());
		}

		// Token: 0x06038F15 RID: 233237 RVA: 0x007B24A8 File Offset: 0x007B06A8
		public ITeleportTransitionInDigitalScreenT UnPack()
		{
			ITeleportTransitionInDigitalScreenT teleportTransitionInDigitalScreenT = new ITeleportTransitionInDigitalScreenT();
			this.UnPackTo(teleportTransitionInDigitalScreenT);
			return teleportTransitionInDigitalScreenT;
		}

		// Token: 0x06038F16 RID: 233238 RVA: 0x007B24C3 File Offset: 0x007B06C3
		public void UnPackTo(ITeleportTransitionInDigitalScreenT _o)
		{
			_o.Type = this.Type;
			_o.ConfigId = this.ConfigId;
		}

		// Token: 0x06038F17 RID: 233239 RVA: 0x007B24E0 File Offset: 0x007B06E0
		public static Offset<ITeleportTransitionInDigitalScreen> Pack(FlatBufferBuilder builder, ITeleportTransitionInDigitalScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionInDigitalScreen>);
			}
			return ITeleportTransitionInDigitalScreen.CreateITeleportTransitionInDigitalScreen(builder, _o.Type, _o.ConfigId);
		}

		// Token: 0x040131D3 RID: 78291
		private Table __p;
	}
}

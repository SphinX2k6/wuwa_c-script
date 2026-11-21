using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BA2 RID: 31650
	public struct ITeleportTransitionWithMp4 : IFlatbufferObject
	{
		// Token: 0x1700ED00 RID: 60672
		// (get) Token: 0x06039049 RID: 233545 RVA: 0x007B4A98 File Offset: 0x007B2C98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603904A RID: 233546 RVA: 0x007B4AA5 File Offset: 0x007B2CA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603904B RID: 233547 RVA: 0x007B4AAC File Offset: 0x007B2CAC
		public static ITeleportTransitionWithMp4 GetRootAsITeleportTransitionWithMp4(ByteBuffer _bb)
		{
			return ITeleportTransitionWithMp4.GetRootAsITeleportTransitionWithMp4(_bb, default(ITeleportTransitionWithMp4));
		}

		// Token: 0x0603904C RID: 233548 RVA: 0x007B4AC8 File Offset: 0x007B2CC8
		public static ITeleportTransitionWithMp4 GetRootAsITeleportTransitionWithMp4(ByteBuffer _bb, ITeleportTransitionWithMp4 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603904D RID: 233549 RVA: 0x007B4AE5 File Offset: 0x007B2CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603904E RID: 233550 RVA: 0x007B4AF4 File Offset: 0x007B2CF4
		public ITeleportTransitionWithMp4 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED01 RID: 60673
		// (get) Token: 0x0603904F RID: 233551 RVA: 0x007B4B04 File Offset: 0x007B2D04
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

		// Token: 0x1700ED02 RID: 60674
		// (get) Token: 0x06039050 RID: 233552 RVA: 0x007B4B40 File Offset: 0x007B2D40
		public string Mp4Path
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039051 RID: 233553 RVA: 0x007B4B77 File Offset: 0x007B2D77
		public Span<byte> GetMp4PathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06039052 RID: 233554 RVA: 0x007B4B86 File Offset: 0x007B2D86
		public byte[] GetMp4PathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700ED03 RID: 60675
		// (get) Token: 0x06039053 RID: 233555 RVA: 0x007B4B94 File Offset: 0x007B2D94
		public bool IsFadeInScreenAfterTeleport
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ED04 RID: 60676
		// (get) Token: 0x06039054 RID: 233556 RVA: 0x007B4BD4 File Offset: 0x007B2DD4
		public bool ReplayWhenReLogin
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ED05 RID: 60677
		// (get) Token: 0x06039055 RID: 233557 RVA: 0x007B4C14 File Offset: 0x007B2E14
		public IMp4BackgroundColor? BackgroundColor
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IMp4BackgroundColor?(default(IMp4BackgroundColor).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x1700ED06 RID: 60678
		// (get) Token: 0x06039056 RID: 233558 RVA: 0x007B4C68 File Offset: 0x007B2E68
		public EAfterTeleportScreenColor AfterTeleportScreenColor
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EAfterTeleportScreenColor.Black;
				}
				return (EAfterTeleportScreenColor)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ED07 RID: 60679
		// (get) Token: 0x06039057 RID: 233559 RVA: 0x007B4CA8 File Offset: 0x007B2EA8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039058 RID: 233560 RVA: 0x007B4CE8 File Offset: 0x007B2EE8
		public static Offset<ITeleportTransitionWithMp4> CreateITeleportTransitionWithMp4(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, StringOffset Mp4PathOffset = default(StringOffset), bool IsFadeInScreenAfterTeleport = false, bool ReplayWhenReLogin = false, IMp4BackgroundColorT BackgroundColor = null, EAfterTeleportScreenColor AfterTeleportScreenColor = EAfterTeleportScreenColor.Black, byte NullMask = 0)
		{
			builder.StartTable(7);
			ITeleportTransitionWithMp4.AddBackgroundColor(builder, IMp4BackgroundColor.Pack(builder, BackgroundColor));
			ITeleportTransitionWithMp4.AddMp4Path(builder, Mp4PathOffset);
			ITeleportTransitionWithMp4.AddNullMask(builder, NullMask);
			ITeleportTransitionWithMp4.AddAfterTeleportScreenColor(builder, AfterTeleportScreenColor);
			ITeleportTransitionWithMp4.AddReplayWhenReLogin(builder, ReplayWhenReLogin);
			ITeleportTransitionWithMp4.AddIsFadeInScreenAfterTeleport(builder, IsFadeInScreenAfterTeleport);
			ITeleportTransitionWithMp4.AddType(builder, Type);
			return ITeleportTransitionWithMp4.EndITeleportTransitionWithMp4(builder);
		}

		// Token: 0x06039059 RID: 233561 RVA: 0x007B4D3D File Offset: 0x007B2F3D
		public static void StartITeleportTransitionWithMp4(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603905A RID: 233562 RVA: 0x007B4D46 File Offset: 0x007B2F46
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603905B RID: 233563 RVA: 0x007B4D51 File Offset: 0x007B2F51
		public static void AddMp4Path(FlatBufferBuilder builder, StringOffset mp4PathOffset)
		{
			builder.AddOffset(1, mp4PathOffset.Value, 0);
		}

		// Token: 0x0603905C RID: 233564 RVA: 0x007B4D61 File Offset: 0x007B2F61
		public static void AddIsFadeInScreenAfterTeleport(FlatBufferBuilder builder, bool isFadeInScreenAfterTeleport)
		{
			builder.AddBool(2, isFadeInScreenAfterTeleport, false);
		}

		// Token: 0x0603905D RID: 233565 RVA: 0x007B4D6C File Offset: 0x007B2F6C
		public static void AddReplayWhenReLogin(FlatBufferBuilder builder, bool replayWhenReLogin)
		{
			builder.AddBool(3, replayWhenReLogin, false);
		}

		// Token: 0x0603905E RID: 233566 RVA: 0x007B4D77 File Offset: 0x007B2F77
		public static void AddBackgroundColor(FlatBufferBuilder builder, Offset<IMp4BackgroundColor> backgroundColorOffset)
		{
			builder.AddStruct(4, backgroundColorOffset.Value, 0);
		}

		// Token: 0x0603905F RID: 233567 RVA: 0x007B4D87 File Offset: 0x007B2F87
		public static void AddAfterTeleportScreenColor(FlatBufferBuilder builder, EAfterTeleportScreenColor afterTeleportScreenColor)
		{
			builder.AddByte(5, (byte)afterTeleportScreenColor, 0);
		}

		// Token: 0x06039060 RID: 233568 RVA: 0x007B4D92 File Offset: 0x007B2F92
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06039061 RID: 233569 RVA: 0x007B4D9D File Offset: 0x007B2F9D
		public static Offset<ITeleportTransitionWithMp4> EndITeleportTransitionWithMp4(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithMp4>(builder.EndTable());
		}

		// Token: 0x06039062 RID: 233570 RVA: 0x007B4DAC File Offset: 0x007B2FAC
		public ITeleportTransitionWithMp4T UnPack()
		{
			ITeleportTransitionWithMp4T teleportTransitionWithMp4T = new ITeleportTransitionWithMp4T();
			this.UnPackTo(teleportTransitionWithMp4T);
			return teleportTransitionWithMp4T;
		}

		// Token: 0x06039063 RID: 233571 RVA: 0x007B4DC8 File Offset: 0x007B2FC8
		public void UnPackTo(ITeleportTransitionWithMp4T _o)
		{
			_o.Type = this.Type;
			_o.Mp4Path = this.Mp4Path;
			_o.IsFadeInScreenAfterTeleport = this.IsFadeInScreenAfterTeleport;
			_o.ReplayWhenReLogin = this.ReplayWhenReLogin;
			_o.BackgroundColor = ((this.BackgroundColor != null) ? this.BackgroundColor.Value.UnPack() : null);
			_o.AfterTeleportScreenColor = this.AfterTeleportScreenColor;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039064 RID: 233572 RVA: 0x007B4E4C File Offset: 0x007B304C
		public static Offset<ITeleportTransitionWithMp4> Pack(FlatBufferBuilder builder, ITeleportTransitionWithMp4T _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithMp4>);
			}
			StringOffset mp4PathOffset = (_o.Mp4Path == null) ? default(StringOffset) : builder.CreateString(_o.Mp4Path);
			return ITeleportTransitionWithMp4.CreateITeleportTransitionWithMp4(builder, _o.Type, mp4PathOffset, _o.IsFadeInScreenAfterTeleport, _o.ReplayWhenReLogin, _o.BackgroundColor, _o.AfterTeleportScreenColor, _o.NullMask);
		}

		// Token: 0x0401320F RID: 78351
		private Table __p;
	}
}

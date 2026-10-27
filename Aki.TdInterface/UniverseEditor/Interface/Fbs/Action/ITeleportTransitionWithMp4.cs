using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073BB RID: 29627
	public struct ITeleportTransitionWithMp4 : IFlatbufferObject
	{
		// Token: 0x1700E0F0 RID: 57584
		// (get) Token: 0x06035CAE RID: 220334 RVA: 0x00752558 File Offset: 0x00750758
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035CAF RID: 220335 RVA: 0x00752565 File Offset: 0x00750765
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035CB0 RID: 220336 RVA: 0x0075256C File Offset: 0x0075076C
		public static ITeleportTransitionWithMp4 GetRootAsITeleportTransitionWithMp4(ByteBuffer _bb)
		{
			return ITeleportTransitionWithMp4.GetRootAsITeleportTransitionWithMp4(_bb, default(ITeleportTransitionWithMp4));
		}

		// Token: 0x06035CB1 RID: 220337 RVA: 0x00752588 File Offset: 0x00750788
		public static ITeleportTransitionWithMp4 GetRootAsITeleportTransitionWithMp4(ByteBuffer _bb, ITeleportTransitionWithMp4 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035CB2 RID: 220338 RVA: 0x007525A5 File Offset: 0x007507A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035CB3 RID: 220339 RVA: 0x007525B4 File Offset: 0x007507B4
		public ITeleportTransitionWithMp4 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0F1 RID: 57585
		// (get) Token: 0x06035CB4 RID: 220340 RVA: 0x007525C4 File Offset: 0x007507C4
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

		// Token: 0x1700E0F2 RID: 57586
		// (get) Token: 0x06035CB5 RID: 220341 RVA: 0x00752600 File Offset: 0x00750800
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

		// Token: 0x06035CB6 RID: 220342 RVA: 0x00752637 File Offset: 0x00750837
		public Span<byte> GetMp4PathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06035CB7 RID: 220343 RVA: 0x00752646 File Offset: 0x00750846
		public byte[] GetMp4PathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E0F3 RID: 57587
		// (get) Token: 0x06035CB8 RID: 220344 RVA: 0x00752654 File Offset: 0x00750854
		public bool IsFadeInScreenAfterTeleport
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E0F4 RID: 57588
		// (get) Token: 0x06035CB9 RID: 220345 RVA: 0x00752694 File Offset: 0x00750894
		public bool ReplayWhenReLogin
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E0F5 RID: 57589
		// (get) Token: 0x06035CBA RID: 220346 RVA: 0x007526D4 File Offset: 0x007508D4
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

		// Token: 0x1700E0F6 RID: 57590
		// (get) Token: 0x06035CBB RID: 220347 RVA: 0x00752728 File Offset: 0x00750928
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

		// Token: 0x1700E0F7 RID: 57591
		// (get) Token: 0x06035CBC RID: 220348 RVA: 0x00752768 File Offset: 0x00750968
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

		// Token: 0x06035CBD RID: 220349 RVA: 0x007527A8 File Offset: 0x007509A8
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

		// Token: 0x06035CBE RID: 220350 RVA: 0x007527FD File Offset: 0x007509FD
		public static void StartITeleportTransitionWithMp4(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06035CBF RID: 220351 RVA: 0x00752806 File Offset: 0x00750A06
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035CC0 RID: 220352 RVA: 0x00752811 File Offset: 0x00750A11
		public static void AddMp4Path(FlatBufferBuilder builder, StringOffset mp4PathOffset)
		{
			builder.AddOffset(1, mp4PathOffset.Value, 0);
		}

		// Token: 0x06035CC1 RID: 220353 RVA: 0x00752821 File Offset: 0x00750A21
		public static void AddIsFadeInScreenAfterTeleport(FlatBufferBuilder builder, bool isFadeInScreenAfterTeleport)
		{
			builder.AddBool(2, isFadeInScreenAfterTeleport, false);
		}

		// Token: 0x06035CC2 RID: 220354 RVA: 0x0075282C File Offset: 0x00750A2C
		public static void AddReplayWhenReLogin(FlatBufferBuilder builder, bool replayWhenReLogin)
		{
			builder.AddBool(3, replayWhenReLogin, false);
		}

		// Token: 0x06035CC3 RID: 220355 RVA: 0x00752837 File Offset: 0x00750A37
		public static void AddBackgroundColor(FlatBufferBuilder builder, Offset<IMp4BackgroundColor> backgroundColorOffset)
		{
			builder.AddStruct(4, backgroundColorOffset.Value, 0);
		}

		// Token: 0x06035CC4 RID: 220356 RVA: 0x00752847 File Offset: 0x00750A47
		public static void AddAfterTeleportScreenColor(FlatBufferBuilder builder, EAfterTeleportScreenColor afterTeleportScreenColor)
		{
			builder.AddByte(5, (byte)afterTeleportScreenColor, 0);
		}

		// Token: 0x06035CC5 RID: 220357 RVA: 0x00752852 File Offset: 0x00750A52
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06035CC6 RID: 220358 RVA: 0x0075285D File Offset: 0x00750A5D
		public static Offset<ITeleportTransitionWithMp4> EndITeleportTransitionWithMp4(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithMp4>(builder.EndTable());
		}

		// Token: 0x06035CC7 RID: 220359 RVA: 0x0075286C File Offset: 0x00750A6C
		public ITeleportTransitionWithMp4T UnPack()
		{
			ITeleportTransitionWithMp4T teleportTransitionWithMp4T = new ITeleportTransitionWithMp4T();
			this.UnPackTo(teleportTransitionWithMp4T);
			return teleportTransitionWithMp4T;
		}

		// Token: 0x06035CC8 RID: 220360 RVA: 0x00752888 File Offset: 0x00750A88
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

		// Token: 0x06035CC9 RID: 220361 RVA: 0x0075290C File Offset: 0x00750B0C
		public static Offset<ITeleportTransitionWithMp4> Pack(FlatBufferBuilder builder, ITeleportTransitionWithMp4T _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithMp4>);
			}
			StringOffset mp4PathOffset = (_o.Mp4Path == null) ? default(StringOffset) : builder.CreateString(_o.Mp4Path);
			return ITeleportTransitionWithMp4.CreateITeleportTransitionWithMp4(builder, _o.Type, mp4PathOffset, _o.IsFadeInScreenAfterTeleport, _o.ReplayWhenReLogin, _o.BackgroundColor, _o.AfterTeleportScreenColor, _o.NullMask);
		}

		// Token: 0x040121F6 RID: 74230
		private Table __p;
	}
}

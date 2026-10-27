using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F0 RID: 27120
	public struct ILevelSequenceTransitionType : IFlatbufferObject
	{
		// Token: 0x1700C933 RID: 51507
		// (get) Token: 0x0602F723 RID: 194339 RVA: 0x00676542 File Offset: 0x00674742
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F724 RID: 194340 RVA: 0x0067654F File Offset: 0x0067474F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F725 RID: 194341 RVA: 0x00676558 File Offset: 0x00674758
		public static ILevelSequenceTransitionType GetRootAsILevelSequenceTransitionType(ByteBuffer _bb)
		{
			return ILevelSequenceTransitionType.GetRootAsILevelSequenceTransitionType(_bb, default(ILevelSequenceTransitionType));
		}

		// Token: 0x0602F726 RID: 194342 RVA: 0x00676574 File Offset: 0x00674774
		public static ILevelSequenceTransitionType GetRootAsILevelSequenceTransitionType(ByteBuffer _bb, ILevelSequenceTransitionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F727 RID: 194343 RVA: 0x00676591 File Offset: 0x00674791
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F728 RID: 194344 RVA: 0x006765A0 File Offset: 0x006747A0
		public ILevelSequenceTransitionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C934 RID: 51508
		// (get) Token: 0x0602F729 RID: 194345 RVA: 0x006765B0 File Offset: 0x006747B0
		public ELevelSequenceTransition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelSequenceTransition.Camera;
				}
				return (ELevelSequenceTransition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C935 RID: 51509
		// (get) Token: 0x0602F72A RID: 194346 RVA: 0x006765EC File Offset: 0x006747EC
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C936 RID: 51510
		// (get) Token: 0x0602F72B RID: 194347 RVA: 0x0067662C File Offset: 0x0067482C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F72C RID: 194348 RVA: 0x00676668 File Offset: 0x00674868
		public static Offset<ILevelSequenceTransitionType> CreateILevelSequenceTransitionType(FlatBufferBuilder builder, ELevelSequenceTransition Type = ELevelSequenceTransition.Camera, float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelSequenceTransitionType.AddDuration(builder, Duration);
			ILevelSequenceTransitionType.AddNullMask(builder, NullMask);
			ILevelSequenceTransitionType.AddType(builder, Type);
			return ILevelSequenceTransitionType.EndILevelSequenceTransitionType(builder);
		}

		// Token: 0x0602F72D RID: 194349 RVA: 0x0067668C File Offset: 0x0067488C
		public static void StartILevelSequenceTransitionType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F72E RID: 194350 RVA: 0x00676695 File Offset: 0x00674895
		public static void AddType(FlatBufferBuilder builder, ELevelSequenceTransition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F72F RID: 194351 RVA: 0x006766A0 File Offset: 0x006748A0
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x0602F730 RID: 194352 RVA: 0x006766B3 File Offset: 0x006748B3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602F731 RID: 194353 RVA: 0x006766BE File Offset: 0x006748BE
		public static Offset<ILevelSequenceTransitionType> EndILevelSequenceTransitionType(FlatBufferBuilder builder)
		{
			return new Offset<ILevelSequenceTransitionType>(builder.EndTable());
		}

		// Token: 0x0602F732 RID: 194354 RVA: 0x006766CC File Offset: 0x006748CC
		public ILevelSequenceTransitionTypeT UnPack()
		{
			ILevelSequenceTransitionTypeT levelSequenceTransitionTypeT = new ILevelSequenceTransitionTypeT();
			this.UnPackTo(levelSequenceTransitionTypeT);
			return levelSequenceTransitionTypeT;
		}

		// Token: 0x0602F733 RID: 194355 RVA: 0x006766E7 File Offset: 0x006748E7
		public void UnPackTo(ILevelSequenceTransitionTypeT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F734 RID: 194356 RVA: 0x00676710 File Offset: 0x00674910
		public static Offset<ILevelSequenceTransitionType> Pack(FlatBufferBuilder builder, ILevelSequenceTransitionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelSequenceTransitionType>);
			}
			return ILevelSequenceTransitionType.CreateILevelSequenceTransitionType(builder, _o.Type, _o.Duration, _o.NullMask);
		}

		// Token: 0x040111E6 RID: 70118
		private Table __p;
	}
}

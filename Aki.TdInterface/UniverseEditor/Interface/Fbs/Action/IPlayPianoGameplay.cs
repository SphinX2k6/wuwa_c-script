using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D32 RID: 27954
	public struct IPlayPianoGameplay : IFlatbufferObject
	{
		// Token: 0x1700D047 RID: 53319
		// (get) Token: 0x06031529 RID: 202025 RVA: 0x006B09FA File Offset: 0x006AEBFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603152A RID: 202026 RVA: 0x006B0A07 File Offset: 0x006AEC07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603152B RID: 202027 RVA: 0x006B0A10 File Offset: 0x006AEC10
		public static IPlayPianoGameplay GetRootAsIPlayPianoGameplay(ByteBuffer _bb)
		{
			return IPlayPianoGameplay.GetRootAsIPlayPianoGameplay(_bb, default(IPlayPianoGameplay));
		}

		// Token: 0x0603152C RID: 202028 RVA: 0x006B0A2C File Offset: 0x006AEC2C
		public static IPlayPianoGameplay GetRootAsIPlayPianoGameplay(ByteBuffer _bb, IPlayPianoGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603152D RID: 202029 RVA: 0x006B0A49 File Offset: 0x006AEC49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603152E RID: 202030 RVA: 0x006B0A58 File Offset: 0x006AEC58
		public IPlayPianoGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D048 RID: 53320
		// (get) Token: 0x0603152F RID: 202031 RVA: 0x006B0A68 File Offset: 0x006AEC68
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D049 RID: 53321
		// (get) Token: 0x06031530 RID: 202032 RVA: 0x006B0AA4 File Offset: 0x006AECA4
		public int SplineEntityId
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

		// Token: 0x1700D04A RID: 53322
		// (get) Token: 0x06031531 RID: 202033 RVA: 0x006B0AE0 File Offset: 0x006AECE0
		public int RangeEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031532 RID: 202034 RVA: 0x006B0B1C File Offset: 0x006AED1C
		public static Offset<IPlayPianoGameplay> CreateIPlayPianoGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int SplineEntityId = 0, int RangeEntityId = 0)
		{
			builder.StartTable(3);
			IPlayPianoGameplay.AddRangeEntityId(builder, RangeEntityId);
			IPlayPianoGameplay.AddSplineEntityId(builder, SplineEntityId);
			IPlayPianoGameplay.AddType(builder, Type);
			return IPlayPianoGameplay.EndIPlayPianoGameplay(builder);
		}

		// Token: 0x06031533 RID: 202035 RVA: 0x006B0B40 File Offset: 0x006AED40
		public static void StartIPlayPianoGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031534 RID: 202036 RVA: 0x006B0B49 File Offset: 0x006AED49
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031535 RID: 202037 RVA: 0x006B0B54 File Offset: 0x006AED54
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x06031536 RID: 202038 RVA: 0x006B0B5F File Offset: 0x006AED5F
		public static void AddRangeEntityId(FlatBufferBuilder builder, int rangeEntityId)
		{
			builder.AddInt(2, rangeEntityId, 0);
		}

		// Token: 0x06031537 RID: 202039 RVA: 0x006B0B6A File Offset: 0x006AED6A
		public static Offset<IPlayPianoGameplay> EndIPlayPianoGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IPlayPianoGameplay>(builder.EndTable());
		}

		// Token: 0x06031538 RID: 202040 RVA: 0x006B0B78 File Offset: 0x006AED78
		public IPlayPianoGameplayT UnPack()
		{
			IPlayPianoGameplayT playPianoGameplayT = new IPlayPianoGameplayT();
			this.UnPackTo(playPianoGameplayT);
			return playPianoGameplayT;
		}

		// Token: 0x06031539 RID: 202041 RVA: 0x006B0B93 File Offset: 0x006AED93
		public void UnPackTo(IPlayPianoGameplayT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
			_o.RangeEntityId = this.RangeEntityId;
		}

		// Token: 0x0603153A RID: 202042 RVA: 0x006B0BBC File Offset: 0x006AEDBC
		public static Offset<IPlayPianoGameplay> Pack(FlatBufferBuilder builder, IPlayPianoGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayPianoGameplay>);
			}
			return IPlayPianoGameplay.CreateIPlayPianoGameplay(builder, _o.Type, _o.SplineEntityId, _o.RangeEntityId);
		}

		// Token: 0x040116C6 RID: 71366
		private Table __p;
	}
}

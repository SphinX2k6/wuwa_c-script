using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074AD RID: 29869
	public struct IPlayPianoGameplay : IFlatbufferObject
	{
		// Token: 0x1700DB8F RID: 56207
		// (get) Token: 0x06034525 RID: 214309 RVA: 0x0070C0E2 File Offset: 0x0070A2E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034526 RID: 214310 RVA: 0x0070C0EF File Offset: 0x0070A2EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034527 RID: 214311 RVA: 0x0070C0F8 File Offset: 0x0070A2F8
		public static IPlayPianoGameplay GetRootAsIPlayPianoGameplay(ByteBuffer _bb)
		{
			return IPlayPianoGameplay.GetRootAsIPlayPianoGameplay(_bb, default(IPlayPianoGameplay));
		}

		// Token: 0x06034528 RID: 214312 RVA: 0x0070C114 File Offset: 0x0070A314
		public static IPlayPianoGameplay GetRootAsIPlayPianoGameplay(ByteBuffer _bb, IPlayPianoGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034529 RID: 214313 RVA: 0x0070C131 File Offset: 0x0070A331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603452A RID: 214314 RVA: 0x0070C140 File Offset: 0x0070A340
		public IPlayPianoGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB90 RID: 56208
		// (get) Token: 0x0603452B RID: 214315 RVA: 0x0070C150 File Offset: 0x0070A350
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

		// Token: 0x1700DB91 RID: 56209
		// (get) Token: 0x0603452C RID: 214316 RVA: 0x0070C18C File Offset: 0x0070A38C
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

		// Token: 0x1700DB92 RID: 56210
		// (get) Token: 0x0603452D RID: 214317 RVA: 0x0070C1C8 File Offset: 0x0070A3C8
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

		// Token: 0x0603452E RID: 214318 RVA: 0x0070C204 File Offset: 0x0070A404
		public static Offset<IPlayPianoGameplay> CreateIPlayPianoGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int SplineEntityId = 0, int RangeEntityId = 0)
		{
			builder.StartTable(3);
			IPlayPianoGameplay.AddRangeEntityId(builder, RangeEntityId);
			IPlayPianoGameplay.AddSplineEntityId(builder, SplineEntityId);
			IPlayPianoGameplay.AddType(builder, Type);
			return IPlayPianoGameplay.EndIPlayPianoGameplay(builder);
		}

		// Token: 0x0603452F RID: 214319 RVA: 0x0070C228 File Offset: 0x0070A428
		public static void StartIPlayPianoGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034530 RID: 214320 RVA: 0x0070C231 File Offset: 0x0070A431
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034531 RID: 214321 RVA: 0x0070C23C File Offset: 0x0070A43C
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x06034532 RID: 214322 RVA: 0x0070C247 File Offset: 0x0070A447
		public static void AddRangeEntityId(FlatBufferBuilder builder, int rangeEntityId)
		{
			builder.AddInt(2, rangeEntityId, 0);
		}

		// Token: 0x06034533 RID: 214323 RVA: 0x0070C252 File Offset: 0x0070A452
		public static Offset<IPlayPianoGameplay> EndIPlayPianoGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IPlayPianoGameplay>(builder.EndTable());
		}

		// Token: 0x06034534 RID: 214324 RVA: 0x0070C260 File Offset: 0x0070A460
		public IPlayPianoGameplayT UnPack()
		{
			IPlayPianoGameplayT playPianoGameplayT = new IPlayPianoGameplayT();
			this.UnPackTo(playPianoGameplayT);
			return playPianoGameplayT;
		}

		// Token: 0x06034535 RID: 214325 RVA: 0x0070C27B File Offset: 0x0070A47B
		public void UnPackTo(IPlayPianoGameplayT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
			_o.RangeEntityId = this.RangeEntityId;
		}

		// Token: 0x06034536 RID: 214326 RVA: 0x0070C2A4 File Offset: 0x0070A4A4
		public static Offset<IPlayPianoGameplay> Pack(FlatBufferBuilder builder, IPlayPianoGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayPianoGameplay>);
			}
			return IPlayPianoGameplay.CreateIPlayPianoGameplay(builder, _o.Type, _o.SplineEntityId, _o.RangeEntityId);
		}

		// Token: 0x04012642 RID: 75330
		private Table __p;
	}
}

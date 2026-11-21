using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007893 RID: 30867
	public struct ISheriffStartTrack : IFlatbufferObject
	{
		// Token: 0x1700E25B RID: 57947
		// (get) Token: 0x060364CC RID: 222412 RVA: 0x007458FA File Offset: 0x00743AFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060364CD RID: 222413 RVA: 0x00745907 File Offset: 0x00743B07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060364CE RID: 222414 RVA: 0x00745910 File Offset: 0x00743B10
		public static ISheriffStartTrack GetRootAsISheriffStartTrack(ByteBuffer _bb)
		{
			return ISheriffStartTrack.GetRootAsISheriffStartTrack(_bb, default(ISheriffStartTrack));
		}

		// Token: 0x060364CF RID: 222415 RVA: 0x0074592C File Offset: 0x00743B2C
		public static ISheriffStartTrack GetRootAsISheriffStartTrack(ByteBuffer _bb, ISheriffStartTrack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060364D0 RID: 222416 RVA: 0x00745949 File Offset: 0x00743B49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060364D1 RID: 222417 RVA: 0x00745958 File Offset: 0x00743B58
		public ISheriffStartTrack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E25C RID: 57948
		// (get) Token: 0x060364D2 RID: 222418 RVA: 0x00745968 File Offset: 0x00743B68
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E25D RID: 57949
		// (get) Token: 0x060364D3 RID: 222419 RVA: 0x007459A4 File Offset: 0x00743BA4
		public int AnomalyId
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

		// Token: 0x060364D4 RID: 222420 RVA: 0x007459E0 File Offset: 0x00743BE0
		public static Offset<ISheriffStartTrack> CreateISheriffStartTrack(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, int AnomalyId = 0)
		{
			builder.StartTable(2);
			ISheriffStartTrack.AddAnomalyId(builder, AnomalyId);
			ISheriffStartTrack.AddType(builder, Type);
			return ISheriffStartTrack.EndISheriffStartTrack(builder);
		}

		// Token: 0x060364D5 RID: 222421 RVA: 0x007459FD File Offset: 0x00743BFD
		public static void StartISheriffStartTrack(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060364D6 RID: 222422 RVA: 0x00745A06 File Offset: 0x00743C06
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060364D7 RID: 222423 RVA: 0x00745A11 File Offset: 0x00743C11
		public static void AddAnomalyId(FlatBufferBuilder builder, int anomalyId)
		{
			builder.AddInt(1, anomalyId, 0);
		}

		// Token: 0x060364D8 RID: 222424 RVA: 0x00745A1C File Offset: 0x00743C1C
		public static Offset<ISheriffStartTrack> EndISheriffStartTrack(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffStartTrack>(builder.EndTable());
		}

		// Token: 0x060364D9 RID: 222425 RVA: 0x00745A2C File Offset: 0x00743C2C
		public ISheriffStartTrackT UnPack()
		{
			ISheriffStartTrackT sheriffStartTrackT = new ISheriffStartTrackT();
			this.UnPackTo(sheriffStartTrackT);
			return sheriffStartTrackT;
		}

		// Token: 0x060364DA RID: 222426 RVA: 0x00745A47 File Offset: 0x00743C47
		public void UnPackTo(ISheriffStartTrackT _o)
		{
			_o.Type = this.Type;
			_o.AnomalyId = this.AnomalyId;
		}

		// Token: 0x060364DB RID: 222427 RVA: 0x00745A64 File Offset: 0x00743C64
		public static Offset<ISheriffStartTrack> Pack(FlatBufferBuilder builder, ISheriffStartTrackT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffStartTrack>);
			}
			return ISheriffStartTrack.CreateISheriffStartTrack(builder, _o.Type, _o.AnomalyId);
		}

		// Token: 0x04012B24 RID: 76580
		private Table __p;
	}
}

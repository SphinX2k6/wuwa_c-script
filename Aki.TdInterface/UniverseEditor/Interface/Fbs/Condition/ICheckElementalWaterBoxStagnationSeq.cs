using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049E5 RID: 18917
	public struct ICheckElementalWaterBoxStagnationSeq : IFlatbufferObject
	{
		// Token: 0x170088CE RID: 35022
		// (get) Token: 0x0601D8D0 RID: 121040 RVA: 0x00428FC2 File Offset: 0x004271C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D8D1 RID: 121041 RVA: 0x00428FCF File Offset: 0x004271CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D8D2 RID: 121042 RVA: 0x00428FD8 File Offset: 0x004271D8
		public static ICheckElementalWaterBoxStagnationSeq GetRootAsICheckElementalWaterBoxStagnationSeq(ByteBuffer _bb)
		{
			return ICheckElementalWaterBoxStagnationSeq.GetRootAsICheckElementalWaterBoxStagnationSeq(_bb, default(ICheckElementalWaterBoxStagnationSeq));
		}

		// Token: 0x0601D8D3 RID: 121043 RVA: 0x00428FF4 File Offset: 0x004271F4
		public static ICheckElementalWaterBoxStagnationSeq GetRootAsICheckElementalWaterBoxStagnationSeq(ByteBuffer _bb, ICheckElementalWaterBoxStagnationSeq obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D8D4 RID: 121044 RVA: 0x00429011 File Offset: 0x00427211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D8D5 RID: 121045 RVA: 0x00429020 File Offset: 0x00427220
		public ICheckElementalWaterBoxStagnationSeq __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088CF RID: 35023
		// (get) Token: 0x0601D8D6 RID: 121046 RVA: 0x00429030 File Offset: 0x00427230
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170088D0 RID: 35024
		// (get) Token: 0x0601D8D7 RID: 121047 RVA: 0x0042906C File Offset: 0x0042726C
		public int EntityId
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

		// Token: 0x170088D1 RID: 35025
		// (get) Token: 0x0601D8D8 RID: 121048 RVA: 0x004290A8 File Offset: 0x004272A8
		public string StartMark
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D8D9 RID: 121049 RVA: 0x004290DF File Offset: 0x004272DF
		public Span<byte> GetStartMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601D8DA RID: 121050 RVA: 0x004290EE File Offset: 0x004272EE
		public byte[] GetStartMarkArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170088D2 RID: 35026
		// (get) Token: 0x0601D8DB RID: 121051 RVA: 0x004290FC File Offset: 0x004272FC
		public string EndMark
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D8DC RID: 121052 RVA: 0x00429134 File Offset: 0x00427334
		public Span<byte> GetEndMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601D8DD RID: 121053 RVA: 0x00429144 File Offset: 0x00427344
		public byte[] GetEndMarkArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601D8DE RID: 121054 RVA: 0x00429153 File Offset: 0x00427353
		public static Offset<ICheckElementalWaterBoxStagnationSeq> CreateICheckElementalWaterBoxStagnationSeq(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, StringOffset StartMarkOffset = default(StringOffset), StringOffset EndMarkOffset = default(StringOffset))
		{
			builder.StartTable(4);
			ICheckElementalWaterBoxStagnationSeq.AddEndMark(builder, EndMarkOffset);
			ICheckElementalWaterBoxStagnationSeq.AddStartMark(builder, StartMarkOffset);
			ICheckElementalWaterBoxStagnationSeq.AddEntityId(builder, EntityId);
			ICheckElementalWaterBoxStagnationSeq.AddType(builder, Type);
			return ICheckElementalWaterBoxStagnationSeq.EndICheckElementalWaterBoxStagnationSeq(builder);
		}

		// Token: 0x0601D8DF RID: 121055 RVA: 0x0042917F File Offset: 0x0042737F
		public static void StartICheckElementalWaterBoxStagnationSeq(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D8E0 RID: 121056 RVA: 0x00429188 File Offset: 0x00427388
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D8E1 RID: 121057 RVA: 0x00429193 File Offset: 0x00427393
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601D8E2 RID: 121058 RVA: 0x0042919E File Offset: 0x0042739E
		public static void AddStartMark(FlatBufferBuilder builder, StringOffset startMarkOffset)
		{
			builder.AddOffset(2, startMarkOffset.Value, 0);
		}

		// Token: 0x0601D8E3 RID: 121059 RVA: 0x004291AE File Offset: 0x004273AE
		public static void AddEndMark(FlatBufferBuilder builder, StringOffset endMarkOffset)
		{
			builder.AddOffset(3, endMarkOffset.Value, 0);
		}

		// Token: 0x0601D8E4 RID: 121060 RVA: 0x004291BE File Offset: 0x004273BE
		public static Offset<ICheckElementalWaterBoxStagnationSeq> EndICheckElementalWaterBoxStagnationSeq(FlatBufferBuilder builder)
		{
			return new Offset<ICheckElementalWaterBoxStagnationSeq>(builder.EndTable());
		}

		// Token: 0x0601D8E5 RID: 121061 RVA: 0x004291CC File Offset: 0x004273CC
		public ICheckElementalWaterBoxStagnationSeqT UnPack()
		{
			ICheckElementalWaterBoxStagnationSeqT checkElementalWaterBoxStagnationSeqT = new ICheckElementalWaterBoxStagnationSeqT();
			this.UnPackTo(checkElementalWaterBoxStagnationSeqT);
			return checkElementalWaterBoxStagnationSeqT;
		}

		// Token: 0x0601D8E6 RID: 121062 RVA: 0x004291E7 File Offset: 0x004273E7
		public void UnPackTo(ICheckElementalWaterBoxStagnationSeqT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.StartMark = this.StartMark;
			_o.EndMark = this.EndMark;
		}

		// Token: 0x0601D8E7 RID: 121063 RVA: 0x0042921C File Offset: 0x0042741C
		public static Offset<ICheckElementalWaterBoxStagnationSeq> Pack(FlatBufferBuilder builder, ICheckElementalWaterBoxStagnationSeqT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckElementalWaterBoxStagnationSeq>);
			}
			StringOffset startMarkOffset = (_o.StartMark == null) ? default(StringOffset) : builder.CreateString(_o.StartMark);
			StringOffset endMarkOffset = (_o.EndMark == null) ? default(StringOffset) : builder.CreateString(_o.EndMark);
			return ICheckElementalWaterBoxStagnationSeq.CreateICheckElementalWaterBoxStagnationSeq(builder, _o.Type, _o.EntityId, startMarkOffset, endMarkOffset);
		}

		// Token: 0x0400D215 RID: 53781
		private Table __p;
	}
}

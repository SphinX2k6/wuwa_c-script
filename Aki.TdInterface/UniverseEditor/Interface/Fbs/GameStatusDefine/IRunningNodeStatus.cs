using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004706 RID: 18182
	public struct IRunningNodeStatus : IFlatbufferObject
	{
		// Token: 0x17008216 RID: 33302
		// (get) Token: 0x0601BDF5 RID: 114165 RVA: 0x003F35F0 File Offset: 0x003F17F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BDF6 RID: 114166 RVA: 0x003F35FD File Offset: 0x003F17FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BDF7 RID: 114167 RVA: 0x003F3604 File Offset: 0x003F1804
		public static IRunningNodeStatus GetRootAsIRunningNodeStatus(ByteBuffer _bb)
		{
			return IRunningNodeStatus.GetRootAsIRunningNodeStatus(_bb, default(IRunningNodeStatus));
		}

		// Token: 0x0601BDF8 RID: 114168 RVA: 0x003F3620 File Offset: 0x003F1820
		public static IRunningNodeStatus GetRootAsIRunningNodeStatus(ByteBuffer _bb, IRunningNodeStatus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BDF9 RID: 114169 RVA: 0x003F363D File Offset: 0x003F183D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BDFA RID: 114170 RVA: 0x003F364C File Offset: 0x003F184C
		public IRunningNodeStatus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008217 RID: 33303
		// (get) Token: 0x0601BDFB RID: 114171 RVA: 0x003F365C File Offset: 0x003F185C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008218 RID: 33304
		// (get) Token: 0x0601BDFC RID: 114172 RVA: 0x003F3698 File Offset: 0x003F1898
		public int InstId
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

		// Token: 0x17008219 RID: 33305
		// (get) Token: 0x0601BDFD RID: 114173 RVA: 0x003F36D4 File Offset: 0x003F18D4
		public int Status
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

		// Token: 0x1700821A RID: 33306
		// (get) Token: 0x0601BDFE RID: 114174 RVA: 0x003F3710 File Offset: 0x003F1910
		public int ChildQuestStatus
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700821B RID: 33307
		// (get) Token: 0x0601BDFF RID: 114175 RVA: 0x003F3750 File Offset: 0x003F1950
		public int CurActionIdx
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700821C RID: 33308
		// (get) Token: 0x0601BE00 RID: 114176 RVA: 0x003F3790 File Offset: 0x003F1990
		public int EndActionIdx
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BE01 RID: 114177 RVA: 0x003F37D0 File Offset: 0x003F19D0
		public string OptionGuids(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700821D RID: 33309
		// (get) Token: 0x0601BE02 RID: 114178 RVA: 0x003F380C File Offset: 0x003F1A0C
		public int OptionGuidsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700821E RID: 33310
		// (get) Token: 0x0601BE03 RID: 114179 RVA: 0x003F3838 File Offset: 0x003F1A38
		public int ErrActionIdx
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700821F RID: 33311
		// (get) Token: 0x0601BE04 RID: 114180 RVA: 0x003F3878 File Offset: 0x003F1A78
		public string CurActionGuid
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BE05 RID: 114181 RVA: 0x003F38B0 File Offset: 0x003F1AB0
		public Span<byte> GetCurActionGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0601BE06 RID: 114182 RVA: 0x003F38C0 File Offset: 0x003F1AC0
		public byte[] GetCurActionGuidArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x17008220 RID: 33312
		// (get) Token: 0x0601BE07 RID: 114183 RVA: 0x003F38D0 File Offset: 0x003F1AD0
		public string EndActionGuid
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BE08 RID: 114184 RVA: 0x003F3908 File Offset: 0x003F1B08
		public Span<byte> GetEndActionGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0601BE09 RID: 114185 RVA: 0x003F3918 File Offset: 0x003F1B18
		public byte[] GetEndActionGuidArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17008221 RID: 33313
		// (get) Token: 0x0601BE0A RID: 114186 RVA: 0x003F3928 File Offset: 0x003F1B28
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BE0B RID: 114187 RVA: 0x003F3968 File Offset: 0x003F1B68
		public static Offset<IRunningNodeStatus> CreateIRunningNodeStatus(FlatBufferBuilder builder, int Id = 0, int InstId = 0, int Status = 0, int ChildQuestStatus = 0, int CurActionIdx = 0, int EndActionIdx = 0, VectorOffset OptionGuidsOffset = default(VectorOffset), int ErrActionIdx = 0, StringOffset CurActionGuidOffset = default(StringOffset), StringOffset EndActionGuidOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(11);
			IRunningNodeStatus.AddEndActionGuid(builder, EndActionGuidOffset);
			IRunningNodeStatus.AddCurActionGuid(builder, CurActionGuidOffset);
			IRunningNodeStatus.AddErrActionIdx(builder, ErrActionIdx);
			IRunningNodeStatus.AddOptionGuids(builder, OptionGuidsOffset);
			IRunningNodeStatus.AddEndActionIdx(builder, EndActionIdx);
			IRunningNodeStatus.AddCurActionIdx(builder, CurActionIdx);
			IRunningNodeStatus.AddChildQuestStatus(builder, ChildQuestStatus);
			IRunningNodeStatus.AddStatus(builder, Status);
			IRunningNodeStatus.AddInstId(builder, InstId);
			IRunningNodeStatus.AddId(builder, Id);
			IRunningNodeStatus.AddNullMask(builder, NullMask);
			return IRunningNodeStatus.EndIRunningNodeStatus(builder);
		}

		// Token: 0x0601BE0C RID: 114188 RVA: 0x003F39D8 File Offset: 0x003F1BD8
		public static void StartIRunningNodeStatus(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0601BE0D RID: 114189 RVA: 0x003F39E2 File Offset: 0x003F1BE2
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601BE0E RID: 114190 RVA: 0x003F39ED File Offset: 0x003F1BED
		public static void AddInstId(FlatBufferBuilder builder, int instId)
		{
			builder.AddInt(1, instId, 0);
		}

		// Token: 0x0601BE0F RID: 114191 RVA: 0x003F39F8 File Offset: 0x003F1BF8
		public static void AddStatus(FlatBufferBuilder builder, int status)
		{
			builder.AddInt(2, status, 0);
		}

		// Token: 0x0601BE10 RID: 114192 RVA: 0x003F3A03 File Offset: 0x003F1C03
		public static void AddChildQuestStatus(FlatBufferBuilder builder, int childQuestStatus)
		{
			builder.AddInt(3, childQuestStatus, 0);
		}

		// Token: 0x0601BE11 RID: 114193 RVA: 0x003F3A0E File Offset: 0x003F1C0E
		public static void AddCurActionIdx(FlatBufferBuilder builder, int curActionIdx)
		{
			builder.AddInt(4, curActionIdx, 0);
		}

		// Token: 0x0601BE12 RID: 114194 RVA: 0x003F3A19 File Offset: 0x003F1C19
		public static void AddEndActionIdx(FlatBufferBuilder builder, int endActionIdx)
		{
			builder.AddInt(5, endActionIdx, 0);
		}

		// Token: 0x0601BE13 RID: 114195 RVA: 0x003F3A24 File Offset: 0x003F1C24
		public static void AddOptionGuids(FlatBufferBuilder builder, VectorOffset optionGuidsOffset)
		{
			builder.AddOffset(6, optionGuidsOffset.Value, 0);
		}

		// Token: 0x0601BE14 RID: 114196 RVA: 0x003F3A34 File Offset: 0x003F1C34
		public static VectorOffset CreateOptionGuidsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BE15 RID: 114197 RVA: 0x003F3A74 File Offset: 0x003F1C74
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE16 RID: 114198 RVA: 0x003F3A8E File Offset: 0x003F1C8E
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE17 RID: 114199 RVA: 0x003F3AAC File Offset: 0x003F1CAC
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BE18 RID: 114200 RVA: 0x003F3AC5 File Offset: 0x003F1CC5
		public static void StartOptionGuidsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BE19 RID: 114201 RVA: 0x003F3AD0 File Offset: 0x003F1CD0
		public static void AddErrActionIdx(FlatBufferBuilder builder, int errActionIdx)
		{
			builder.AddInt(7, errActionIdx, 0);
		}

		// Token: 0x0601BE1A RID: 114202 RVA: 0x003F3ADB File Offset: 0x003F1CDB
		public static void AddCurActionGuid(FlatBufferBuilder builder, StringOffset curActionGuidOffset)
		{
			builder.AddOffset(8, curActionGuidOffset.Value, 0);
		}

		// Token: 0x0601BE1B RID: 114203 RVA: 0x003F3AEB File Offset: 0x003F1CEB
		public static void AddEndActionGuid(FlatBufferBuilder builder, StringOffset endActionGuidOffset)
		{
			builder.AddOffset(9, endActionGuidOffset.Value, 0);
		}

		// Token: 0x0601BE1C RID: 114204 RVA: 0x003F3AFC File Offset: 0x003F1CFC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x0601BE1D RID: 114205 RVA: 0x003F3B08 File Offset: 0x003F1D08
		public static Offset<IRunningNodeStatus> EndIRunningNodeStatus(FlatBufferBuilder builder)
		{
			return new Offset<IRunningNodeStatus>(builder.EndTable());
		}

		// Token: 0x0601BE1E RID: 114206 RVA: 0x003F3B18 File Offset: 0x003F1D18
		public IRunningNodeStatusT UnPack()
		{
			IRunningNodeStatusT runningNodeStatusT = new IRunningNodeStatusT();
			this.UnPackTo(runningNodeStatusT);
			return runningNodeStatusT;
		}

		// Token: 0x0601BE1F RID: 114207 RVA: 0x003F3B34 File Offset: 0x003F1D34
		public void UnPackTo(IRunningNodeStatusT _o)
		{
			_o.Id = this.Id;
			_o.InstId = this.InstId;
			_o.Status = this.Status;
			_o.ChildQuestStatus = this.ChildQuestStatus;
			_o.CurActionIdx = this.CurActionIdx;
			_o.EndActionIdx = this.EndActionIdx;
			_o.OptionGuids = new List<string>();
			for (int i = 0; i < this.OptionGuidsLength; i++)
			{
				_o.OptionGuids.Add(this.OptionGuids(i));
			}
			_o.ErrActionIdx = this.ErrActionIdx;
			_o.CurActionGuid = this.CurActionGuid;
			_o.EndActionGuid = this.EndActionGuid;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BE20 RID: 114208 RVA: 0x003F3BE8 File Offset: 0x003F1DE8
		public static Offset<IRunningNodeStatus> Pack(FlatBufferBuilder builder, IRunningNodeStatusT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunningNodeStatus>);
			}
			VectorOffset optionGuidsOffset = default(VectorOffset);
			if (_o.OptionGuids != null)
			{
				StringOffset[] array = new StringOffset[_o.OptionGuids.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.OptionGuids[i]);
				}
				optionGuidsOffset = IRunningNodeStatus.CreateOptionGuidsVector(builder, array);
			}
			StringOffset curActionGuidOffset = (_o.CurActionGuid == null) ? default(StringOffset) : builder.CreateString(_o.CurActionGuid);
			StringOffset endActionGuidOffset = (_o.EndActionGuid == null) ? default(StringOffset) : builder.CreateString(_o.EndActionGuid);
			return IRunningNodeStatus.CreateIRunningNodeStatus(builder, _o.Id, _o.InstId, _o.Status, _o.ChildQuestStatus, _o.CurActionIdx, _o.EndActionIdx, optionGuidsOffset, _o.ErrActionIdx, curActionGuidOffset, endActionGuidOffset, _o.NullMask);
		}

		// Token: 0x0400C9BF RID: 51647
		private Table __p;
	}
}

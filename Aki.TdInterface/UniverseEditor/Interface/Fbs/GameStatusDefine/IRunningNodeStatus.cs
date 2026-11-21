using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B6E RID: 19310
	public struct IRunningNodeStatus : IFlatbufferObject
	{
		// Token: 0x17008857 RID: 34903
		// (get) Token: 0x0601D5CA RID: 120266 RVA: 0x0041F88C File Offset: 0x0041DA8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D5CB RID: 120267 RVA: 0x0041F899 File Offset: 0x0041DA99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D5CC RID: 120268 RVA: 0x0041F8A0 File Offset: 0x0041DAA0
		public static IRunningNodeStatus GetRootAsIRunningNodeStatus(ByteBuffer _bb)
		{
			return IRunningNodeStatus.GetRootAsIRunningNodeStatus(_bb, default(IRunningNodeStatus));
		}

		// Token: 0x0601D5CD RID: 120269 RVA: 0x0041F8BC File Offset: 0x0041DABC
		public static IRunningNodeStatus GetRootAsIRunningNodeStatus(ByteBuffer _bb, IRunningNodeStatus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D5CE RID: 120270 RVA: 0x0041F8D9 File Offset: 0x0041DAD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D5CF RID: 120271 RVA: 0x0041F8E8 File Offset: 0x0041DAE8
		public IRunningNodeStatus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008858 RID: 34904
		// (get) Token: 0x0601D5D0 RID: 120272 RVA: 0x0041F8F8 File Offset: 0x0041DAF8
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

		// Token: 0x17008859 RID: 34905
		// (get) Token: 0x0601D5D1 RID: 120273 RVA: 0x0041F934 File Offset: 0x0041DB34
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

		// Token: 0x1700885A RID: 34906
		// (get) Token: 0x0601D5D2 RID: 120274 RVA: 0x0041F970 File Offset: 0x0041DB70
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

		// Token: 0x1700885B RID: 34907
		// (get) Token: 0x0601D5D3 RID: 120275 RVA: 0x0041F9AC File Offset: 0x0041DBAC
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

		// Token: 0x1700885C RID: 34908
		// (get) Token: 0x0601D5D4 RID: 120276 RVA: 0x0041F9EC File Offset: 0x0041DBEC
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

		// Token: 0x1700885D RID: 34909
		// (get) Token: 0x0601D5D5 RID: 120277 RVA: 0x0041FA2C File Offset: 0x0041DC2C
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

		// Token: 0x0601D5D6 RID: 120278 RVA: 0x0041FA6C File Offset: 0x0041DC6C
		public string OptionGuids(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700885E RID: 34910
		// (get) Token: 0x0601D5D7 RID: 120279 RVA: 0x0041FAA8 File Offset: 0x0041DCA8
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

		// Token: 0x1700885F RID: 34911
		// (get) Token: 0x0601D5D8 RID: 120280 RVA: 0x0041FAD4 File Offset: 0x0041DCD4
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

		// Token: 0x17008860 RID: 34912
		// (get) Token: 0x0601D5D9 RID: 120281 RVA: 0x0041FB14 File Offset: 0x0041DD14
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

		// Token: 0x0601D5DA RID: 120282 RVA: 0x0041FB4C File Offset: 0x0041DD4C
		public Span<byte> GetCurActionGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0601D5DB RID: 120283 RVA: 0x0041FB5C File Offset: 0x0041DD5C
		public byte[] GetCurActionGuidArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x17008861 RID: 34913
		// (get) Token: 0x0601D5DC RID: 120284 RVA: 0x0041FB6C File Offset: 0x0041DD6C
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

		// Token: 0x0601D5DD RID: 120285 RVA: 0x0041FBA4 File Offset: 0x0041DDA4
		public Span<byte> GetEndActionGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0601D5DE RID: 120286 RVA: 0x0041FBB4 File Offset: 0x0041DDB4
		public byte[] GetEndActionGuidArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17008862 RID: 34914
		// (get) Token: 0x0601D5DF RID: 120287 RVA: 0x0041FBC4 File Offset: 0x0041DDC4
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

		// Token: 0x0601D5E0 RID: 120288 RVA: 0x0041FC04 File Offset: 0x0041DE04
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

		// Token: 0x0601D5E1 RID: 120289 RVA: 0x0041FC74 File Offset: 0x0041DE74
		public static void StartIRunningNodeStatus(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0601D5E2 RID: 120290 RVA: 0x0041FC7E File Offset: 0x0041DE7E
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601D5E3 RID: 120291 RVA: 0x0041FC89 File Offset: 0x0041DE89
		public static void AddInstId(FlatBufferBuilder builder, int instId)
		{
			builder.AddInt(1, instId, 0);
		}

		// Token: 0x0601D5E4 RID: 120292 RVA: 0x0041FC94 File Offset: 0x0041DE94
		public static void AddStatus(FlatBufferBuilder builder, int status)
		{
			builder.AddInt(2, status, 0);
		}

		// Token: 0x0601D5E5 RID: 120293 RVA: 0x0041FC9F File Offset: 0x0041DE9F
		public static void AddChildQuestStatus(FlatBufferBuilder builder, int childQuestStatus)
		{
			builder.AddInt(3, childQuestStatus, 0);
		}

		// Token: 0x0601D5E6 RID: 120294 RVA: 0x0041FCAA File Offset: 0x0041DEAA
		public static void AddCurActionIdx(FlatBufferBuilder builder, int curActionIdx)
		{
			builder.AddInt(4, curActionIdx, 0);
		}

		// Token: 0x0601D5E7 RID: 120295 RVA: 0x0041FCB5 File Offset: 0x0041DEB5
		public static void AddEndActionIdx(FlatBufferBuilder builder, int endActionIdx)
		{
			builder.AddInt(5, endActionIdx, 0);
		}

		// Token: 0x0601D5E8 RID: 120296 RVA: 0x0041FCC0 File Offset: 0x0041DEC0
		public static void AddOptionGuids(FlatBufferBuilder builder, VectorOffset optionGuidsOffset)
		{
			builder.AddOffset(6, optionGuidsOffset.Value, 0);
		}

		// Token: 0x0601D5E9 RID: 120297 RVA: 0x0041FCD0 File Offset: 0x0041DED0
		public static VectorOffset CreateOptionGuidsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D5EA RID: 120298 RVA: 0x0041FD10 File Offset: 0x0041DF10
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D5EB RID: 120299 RVA: 0x0041FD2A File Offset: 0x0041DF2A
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D5EC RID: 120300 RVA: 0x0041FD48 File Offset: 0x0041DF48
		public static VectorOffset CreateOptionGuidsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D5ED RID: 120301 RVA: 0x0041FD61 File Offset: 0x0041DF61
		public static void StartOptionGuidsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D5EE RID: 120302 RVA: 0x0041FD6C File Offset: 0x0041DF6C
		public static void AddErrActionIdx(FlatBufferBuilder builder, int errActionIdx)
		{
			builder.AddInt(7, errActionIdx, 0);
		}

		// Token: 0x0601D5EF RID: 120303 RVA: 0x0041FD77 File Offset: 0x0041DF77
		public static void AddCurActionGuid(FlatBufferBuilder builder, StringOffset curActionGuidOffset)
		{
			builder.AddOffset(8, curActionGuidOffset.Value, 0);
		}

		// Token: 0x0601D5F0 RID: 120304 RVA: 0x0041FD87 File Offset: 0x0041DF87
		public static void AddEndActionGuid(FlatBufferBuilder builder, StringOffset endActionGuidOffset)
		{
			builder.AddOffset(9, endActionGuidOffset.Value, 0);
		}

		// Token: 0x0601D5F1 RID: 120305 RVA: 0x0041FD98 File Offset: 0x0041DF98
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x0601D5F2 RID: 120306 RVA: 0x0041FDA4 File Offset: 0x0041DFA4
		public static Offset<IRunningNodeStatus> EndIRunningNodeStatus(FlatBufferBuilder builder)
		{
			return new Offset<IRunningNodeStatus>(builder.EndTable());
		}

		// Token: 0x0601D5F3 RID: 120307 RVA: 0x0041FDB4 File Offset: 0x0041DFB4
		public IRunningNodeStatusT UnPack()
		{
			IRunningNodeStatusT runningNodeStatusT = new IRunningNodeStatusT();
			this.UnPackTo(runningNodeStatusT);
			return runningNodeStatusT;
		}

		// Token: 0x0601D5F4 RID: 120308 RVA: 0x0041FDD0 File Offset: 0x0041DFD0
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

		// Token: 0x0601D5F5 RID: 120309 RVA: 0x0041FE84 File Offset: 0x0041E084
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

		// Token: 0x0400D3EE RID: 54254
		private Table __p;
	}
}

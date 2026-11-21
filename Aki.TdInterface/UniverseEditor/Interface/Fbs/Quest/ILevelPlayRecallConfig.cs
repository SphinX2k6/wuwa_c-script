using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200433D RID: 17213
	public struct ILevelPlayRecallConfig : IFlatbufferObject
	{
		// Token: 0x170075CC RID: 30156
		// (get) Token: 0x0601838B RID: 99211 RVA: 0x00373E44 File Offset: 0x00372044
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601838C RID: 99212 RVA: 0x00373E51 File Offset: 0x00372051
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601838D RID: 99213 RVA: 0x00373E58 File Offset: 0x00372058
		public static ILevelPlayRecallConfig GetRootAsILevelPlayRecallConfig(ByteBuffer _bb)
		{
			return ILevelPlayRecallConfig.GetRootAsILevelPlayRecallConfig(_bb, default(ILevelPlayRecallConfig));
		}

		// Token: 0x0601838E RID: 99214 RVA: 0x00373E74 File Offset: 0x00372074
		public static ILevelPlayRecallConfig GetRootAsILevelPlayRecallConfig(ByteBuffer _bb, ILevelPlayRecallConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601838F RID: 99215 RVA: 0x00373E91 File Offset: 0x00372091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018390 RID: 99216 RVA: 0x00373EA0 File Offset: 0x003720A0
		public ILevelPlayRecallConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075CD RID: 30157
		// (get) Token: 0x06018391 RID: 99217 RVA: 0x00373EB0 File Offset: 0x003720B0
		public int RecallId
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

		// Token: 0x06018392 RID: 99218 RVA: 0x00373EEC File Offset: 0x003720EC
		public int RecallEntityList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170075CE RID: 30158
		// (get) Token: 0x06018393 RID: 99219 RVA: 0x00373F2C File Offset: 0x0037212C
		public int RecallEntityListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06018394 RID: 99220 RVA: 0x00373F57 File Offset: 0x00372157
		public Span<int> GetRecallEntityListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06018395 RID: 99221 RVA: 0x00373F66 File Offset: 0x00372166
		public int[] GetRecallEntityListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06018396 RID: 99222 RVA: 0x00373F74 File Offset: 0x00372174
		public static Offset<ILevelPlayRecallConfig> CreateILevelPlayRecallConfig(FlatBufferBuilder builder, int RecallId = 0, VectorOffset RecallEntityListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelPlayRecallConfig.AddRecallEntityList(builder, RecallEntityListOffset);
			ILevelPlayRecallConfig.AddRecallId(builder, RecallId);
			return ILevelPlayRecallConfig.EndILevelPlayRecallConfig(builder);
		}

		// Token: 0x06018397 RID: 99223 RVA: 0x00373F91 File Offset: 0x00372191
		public static void StartILevelPlayRecallConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018398 RID: 99224 RVA: 0x00373F9A File Offset: 0x0037219A
		public static void AddRecallId(FlatBufferBuilder builder, int recallId)
		{
			builder.AddInt(0, recallId, 0);
		}

		// Token: 0x06018399 RID: 99225 RVA: 0x00373FA5 File Offset: 0x003721A5
		public static void AddRecallEntityList(FlatBufferBuilder builder, VectorOffset recallEntityListOffset)
		{
			builder.AddOffset(1, recallEntityListOffset.Value, 0);
		}

		// Token: 0x0601839A RID: 99226 RVA: 0x00373FB8 File Offset: 0x003721B8
		public static VectorOffset CreateRecallEntityListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601839B RID: 99227 RVA: 0x00373FEF File Offset: 0x003721EF
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601839C RID: 99228 RVA: 0x00374009 File Offset: 0x00372209
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601839D RID: 99229 RVA: 0x00374027 File Offset: 0x00372227
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601839E RID: 99230 RVA: 0x00374040 File Offset: 0x00372240
		public static void StartRecallEntityListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601839F RID: 99231 RVA: 0x0037404B File Offset: 0x0037224B
		public static Offset<ILevelPlayRecallConfig> EndILevelPlayRecallConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayRecallConfig>(builder.EndTable());
		}

		// Token: 0x060183A0 RID: 99232 RVA: 0x00374058 File Offset: 0x00372258
		public ILevelPlayRecallConfigT UnPack()
		{
			ILevelPlayRecallConfigT levelPlayRecallConfigT = new ILevelPlayRecallConfigT();
			this.UnPackTo(levelPlayRecallConfigT);
			return levelPlayRecallConfigT;
		}

		// Token: 0x060183A1 RID: 99233 RVA: 0x00374074 File Offset: 0x00372274
		public void UnPackTo(ILevelPlayRecallConfigT _o)
		{
			_o.RecallId = this.RecallId;
			_o.RecallEntityList = new List<int>();
			for (int i = 0; i < this.RecallEntityListLength; i++)
			{
				_o.RecallEntityList.Add(this.RecallEntityList(i));
			}
		}

		// Token: 0x060183A2 RID: 99234 RVA: 0x003740BC File Offset: 0x003722BC
		public static Offset<ILevelPlayRecallConfig> Pack(FlatBufferBuilder builder, ILevelPlayRecallConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayRecallConfig>);
			}
			VectorOffset recallEntityListOffset = default(VectorOffset);
			if (_o.RecallEntityList != null)
			{
				int[] data = _o.RecallEntityList.ToArray();
				recallEntityListOffset = ILevelPlayRecallConfig.CreateRecallEntityListVector(builder, data);
			}
			return ILevelPlayRecallConfig.CreateILevelPlayRecallConfig(builder, _o.RecallId, recallEntityListOffset);
		}

		// Token: 0x0400C2B9 RID: 49849
		private Table __p;
	}
}

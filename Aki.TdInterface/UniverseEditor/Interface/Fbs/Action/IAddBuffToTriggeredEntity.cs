using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006125 RID: 24869
	public struct IAddBuffToTriggeredEntity : IFlatbufferObject
	{
		// Token: 0x1700B749 RID: 46921
		// (get) Token: 0x0602A81B RID: 174107 RVA: 0x005DA917 File Offset: 0x005D8B17
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A81C RID: 174108 RVA: 0x005DA924 File Offset: 0x005D8B24
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A81D RID: 174109 RVA: 0x005DA92C File Offset: 0x005D8B2C
		public static IAddBuffToTriggeredEntity GetRootAsIAddBuffToTriggeredEntity(ByteBuffer _bb)
		{
			return IAddBuffToTriggeredEntity.GetRootAsIAddBuffToTriggeredEntity(_bb, default(IAddBuffToTriggeredEntity));
		}

		// Token: 0x0602A81E RID: 174110 RVA: 0x005DA948 File Offset: 0x005D8B48
		public static IAddBuffToTriggeredEntity GetRootAsIAddBuffToTriggeredEntity(ByteBuffer _bb, IAddBuffToTriggeredEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A81F RID: 174111 RVA: 0x005DA965 File Offset: 0x005D8B65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A820 RID: 174112 RVA: 0x005DA974 File Offset: 0x005D8B74
		public IAddBuffToTriggeredEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602A821 RID: 174113 RVA: 0x005DA984 File Offset: 0x005D8B84
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700B74A RID: 46922
		// (get) Token: 0x0602A822 RID: 174114 RVA: 0x005DA9C4 File Offset: 0x005D8BC4
		public int BuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602A823 RID: 174115 RVA: 0x005DA9EF File Offset: 0x005D8BEF
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x0602A824 RID: 174116 RVA: 0x005DA9FE File Offset: 0x005D8BFE
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x0602A825 RID: 174117 RVA: 0x005DAA0C File Offset: 0x005D8C0C
		public static Offset<IAddBuffToTriggeredEntity> CreateIAddBuffToTriggeredEntity(FlatBufferBuilder builder, VectorOffset BuffIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IAddBuffToTriggeredEntity.AddBuffIds(builder, BuffIdsOffset);
			return IAddBuffToTriggeredEntity.EndIAddBuffToTriggeredEntity(builder);
		}

		// Token: 0x0602A826 RID: 174118 RVA: 0x005DAA22 File Offset: 0x005D8C22
		public static void StartIAddBuffToTriggeredEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A827 RID: 174119 RVA: 0x005DAA2B File Offset: 0x005D8C2B
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(0, buffIdsOffset.Value, 0);
		}

		// Token: 0x0602A828 RID: 174120 RVA: 0x005DAA3C File Offset: 0x005D8C3C
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A829 RID: 174121 RVA: 0x005DAA73 File Offset: 0x005D8C73
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A82A RID: 174122 RVA: 0x005DAA8D File Offset: 0x005D8C8D
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A82B RID: 174123 RVA: 0x005DAAAB File Offset: 0x005D8CAB
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A82C RID: 174124 RVA: 0x005DAAC4 File Offset: 0x005D8CC4
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602A82D RID: 174125 RVA: 0x005DAACF File Offset: 0x005D8CCF
		public static Offset<IAddBuffToTriggeredEntity> EndIAddBuffToTriggeredEntity(FlatBufferBuilder builder)
		{
			return new Offset<IAddBuffToTriggeredEntity>(builder.EndTable());
		}

		// Token: 0x0602A82E RID: 174126 RVA: 0x005DAADC File Offset: 0x005D8CDC
		public IAddBuffToTriggeredEntityT UnPack()
		{
			IAddBuffToTriggeredEntityT addBuffToTriggeredEntityT = new IAddBuffToTriggeredEntityT();
			this.UnPackTo(addBuffToTriggeredEntityT);
			return addBuffToTriggeredEntityT;
		}

		// Token: 0x0602A82F RID: 174127 RVA: 0x005DAAF8 File Offset: 0x005D8CF8
		public void UnPackTo(IAddBuffToTriggeredEntityT _o)
		{
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
		}

		// Token: 0x0602A830 RID: 174128 RVA: 0x005DAB34 File Offset: 0x005D8D34
		public static Offset<IAddBuffToTriggeredEntity> Pack(FlatBufferBuilder builder, IAddBuffToTriggeredEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddBuffToTriggeredEntity>);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IAddBuffToTriggeredEntity.CreateBuffIdsVector(builder, data);
			}
			return IAddBuffToTriggeredEntity.CreateIAddBuffToTriggeredEntity(builder, buffIdsOffset);
		}

		// Token: 0x040104F8 RID: 66808
		private Table __p;
	}
}

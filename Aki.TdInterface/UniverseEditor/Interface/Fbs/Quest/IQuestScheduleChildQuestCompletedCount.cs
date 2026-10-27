using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004019 RID: 16409
	public struct IQuestScheduleChildQuestCompletedCount : IFlatbufferObject
	{
		// Token: 0x17007361 RID: 29537
		// (get) Token: 0x06017B39 RID: 97081 RVA: 0x0036B43E File Offset: 0x0036963E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017B3A RID: 97082 RVA: 0x0036B44B File Offset: 0x0036964B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017B3B RID: 97083 RVA: 0x0036B454 File Offset: 0x00369654
		public static IQuestScheduleChildQuestCompletedCount GetRootAsIQuestScheduleChildQuestCompletedCount(ByteBuffer _bb)
		{
			return IQuestScheduleChildQuestCompletedCount.GetRootAsIQuestScheduleChildQuestCompletedCount(_bb, default(IQuestScheduleChildQuestCompletedCount));
		}

		// Token: 0x06017B3C RID: 97084 RVA: 0x0036B470 File Offset: 0x00369670
		public static IQuestScheduleChildQuestCompletedCount GetRootAsIQuestScheduleChildQuestCompletedCount(ByteBuffer _bb, IQuestScheduleChildQuestCompletedCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017B3D RID: 97085 RVA: 0x0036B48D File Offset: 0x0036968D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017B3E RID: 97086 RVA: 0x0036B49C File Offset: 0x0036969C
		public IQuestScheduleChildQuestCompletedCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007362 RID: 29538
		// (get) Token: 0x06017B3F RID: 97087 RVA: 0x0036B4AC File Offset: 0x003696AC
		public EQuestScheduleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestScheduleType.None;
				}
				return (EQuestScheduleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017B40 RID: 97088 RVA: 0x0036B4E8 File Offset: 0x003696E8
		public int AssociatedChildQuestIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007363 RID: 29539
		// (get) Token: 0x06017B41 RID: 97089 RVA: 0x0036B528 File Offset: 0x00369728
		public int AssociatedChildQuestIdsLength
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

		// Token: 0x06017B42 RID: 97090 RVA: 0x0036B553 File Offset: 0x00369753
		public Span<int> GetAssociatedChildQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06017B43 RID: 97091 RVA: 0x0036B562 File Offset: 0x00369762
		public int[] GetAssociatedChildQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06017B44 RID: 97092 RVA: 0x0036B570 File Offset: 0x00369770
		public static Offset<IQuestScheduleChildQuestCompletedCount> CreateIQuestScheduleChildQuestCompletedCount(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, VectorOffset AssociatedChildQuestIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IQuestScheduleChildQuestCompletedCount.AddAssociatedChildQuestIds(builder, AssociatedChildQuestIdsOffset);
			IQuestScheduleChildQuestCompletedCount.AddType(builder, Type);
			return IQuestScheduleChildQuestCompletedCount.EndIQuestScheduleChildQuestCompletedCount(builder);
		}

		// Token: 0x06017B45 RID: 97093 RVA: 0x0036B58D File Offset: 0x0036978D
		public static void StartIQuestScheduleChildQuestCompletedCount(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017B46 RID: 97094 RVA: 0x0036B596 File Offset: 0x00369796
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017B47 RID: 97095 RVA: 0x0036B5A1 File Offset: 0x003697A1
		public static void AddAssociatedChildQuestIds(FlatBufferBuilder builder, VectorOffset associatedChildQuestIdsOffset)
		{
			builder.AddOffset(1, associatedChildQuestIdsOffset.Value, 0);
		}

		// Token: 0x06017B48 RID: 97096 RVA: 0x0036B5B4 File Offset: 0x003697B4
		public static VectorOffset CreateAssociatedChildQuestIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017B49 RID: 97097 RVA: 0x0036B5EB File Offset: 0x003697EB
		public static VectorOffset CreateAssociatedChildQuestIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017B4A RID: 97098 RVA: 0x0036B605 File Offset: 0x00369805
		public static VectorOffset CreateAssociatedChildQuestIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017B4B RID: 97099 RVA: 0x0036B623 File Offset: 0x00369823
		public static VectorOffset CreateAssociatedChildQuestIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017B4C RID: 97100 RVA: 0x0036B63C File Offset: 0x0036983C
		public static void StartAssociatedChildQuestIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017B4D RID: 97101 RVA: 0x0036B647 File Offset: 0x00369847
		public static Offset<IQuestScheduleChildQuestCompletedCount> EndIQuestScheduleChildQuestCompletedCount(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleChildQuestCompletedCount>(builder.EndTable());
		}

		// Token: 0x06017B4E RID: 97102 RVA: 0x0036B654 File Offset: 0x00369854
		public IQuestScheduleChildQuestCompletedCountT UnPack()
		{
			IQuestScheduleChildQuestCompletedCountT questScheduleChildQuestCompletedCountT = new IQuestScheduleChildQuestCompletedCountT();
			this.UnPackTo(questScheduleChildQuestCompletedCountT);
			return questScheduleChildQuestCompletedCountT;
		}

		// Token: 0x06017B4F RID: 97103 RVA: 0x0036B670 File Offset: 0x00369870
		public void UnPackTo(IQuestScheduleChildQuestCompletedCountT _o)
		{
			_o.Type = this.Type;
			_o.AssociatedChildQuestIds = new List<int>();
			for (int i = 0; i < this.AssociatedChildQuestIdsLength; i++)
			{
				_o.AssociatedChildQuestIds.Add(this.AssociatedChildQuestIds(i));
			}
		}

		// Token: 0x06017B50 RID: 97104 RVA: 0x0036B6B8 File Offset: 0x003698B8
		public static Offset<IQuestScheduleChildQuestCompletedCount> Pack(FlatBufferBuilder builder, IQuestScheduleChildQuestCompletedCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleChildQuestCompletedCount>);
			}
			VectorOffset associatedChildQuestIdsOffset = default(VectorOffset);
			if (_o.AssociatedChildQuestIds != null)
			{
				int[] data = _o.AssociatedChildQuestIds.ToArray();
				associatedChildQuestIdsOffset = IQuestScheduleChildQuestCompletedCount.CreateAssociatedChildQuestIdsVector(builder, data);
			}
			return IQuestScheduleChildQuestCompletedCount.CreateIQuestScheduleChildQuestCompletedCount(builder, _o.Type, associatedChildQuestIdsOffset);
		}

		// Token: 0x0400BB3E RID: 47934
		private Table __p;
	}
}

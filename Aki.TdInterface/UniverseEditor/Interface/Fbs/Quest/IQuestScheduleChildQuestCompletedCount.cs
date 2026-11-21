using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200445A RID: 17498
	public struct IQuestScheduleChildQuestCompletedCount : IFlatbufferObject
	{
		// Token: 0x17007963 RID: 31075
		// (get) Token: 0x060191D2 RID: 102866 RVA: 0x00395232 File Offset: 0x00393432
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060191D3 RID: 102867 RVA: 0x0039523F File Offset: 0x0039343F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060191D4 RID: 102868 RVA: 0x00395248 File Offset: 0x00393448
		public static IQuestScheduleChildQuestCompletedCount GetRootAsIQuestScheduleChildQuestCompletedCount(ByteBuffer _bb)
		{
			return IQuestScheduleChildQuestCompletedCount.GetRootAsIQuestScheduleChildQuestCompletedCount(_bb, default(IQuestScheduleChildQuestCompletedCount));
		}

		// Token: 0x060191D5 RID: 102869 RVA: 0x00395264 File Offset: 0x00393464
		public static IQuestScheduleChildQuestCompletedCount GetRootAsIQuestScheduleChildQuestCompletedCount(ByteBuffer _bb, IQuestScheduleChildQuestCompletedCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060191D6 RID: 102870 RVA: 0x00395281 File Offset: 0x00393481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060191D7 RID: 102871 RVA: 0x00395290 File Offset: 0x00393490
		public IQuestScheduleChildQuestCompletedCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007964 RID: 31076
		// (get) Token: 0x060191D8 RID: 102872 RVA: 0x003952A0 File Offset: 0x003934A0
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

		// Token: 0x060191D9 RID: 102873 RVA: 0x003952DC File Offset: 0x003934DC
		public int AssociatedChildQuestIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007965 RID: 31077
		// (get) Token: 0x060191DA RID: 102874 RVA: 0x0039531C File Offset: 0x0039351C
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

		// Token: 0x060191DB RID: 102875 RVA: 0x00395347 File Offset: 0x00393547
		public Span<int> GetAssociatedChildQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060191DC RID: 102876 RVA: 0x00395356 File Offset: 0x00393556
		public int[] GetAssociatedChildQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060191DD RID: 102877 RVA: 0x00395364 File Offset: 0x00393564
		public static Offset<IQuestScheduleChildQuestCompletedCount> CreateIQuestScheduleChildQuestCompletedCount(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, VectorOffset AssociatedChildQuestIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IQuestScheduleChildQuestCompletedCount.AddAssociatedChildQuestIds(builder, AssociatedChildQuestIdsOffset);
			IQuestScheduleChildQuestCompletedCount.AddType(builder, Type);
			return IQuestScheduleChildQuestCompletedCount.EndIQuestScheduleChildQuestCompletedCount(builder);
		}

		// Token: 0x060191DE RID: 102878 RVA: 0x00395381 File Offset: 0x00393581
		public static void StartIQuestScheduleChildQuestCompletedCount(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060191DF RID: 102879 RVA: 0x0039538A File Offset: 0x0039358A
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060191E0 RID: 102880 RVA: 0x00395395 File Offset: 0x00393595
		public static void AddAssociatedChildQuestIds(FlatBufferBuilder builder, VectorOffset associatedChildQuestIdsOffset)
		{
			builder.AddOffset(1, associatedChildQuestIdsOffset.Value, 0);
		}

		// Token: 0x060191E1 RID: 102881 RVA: 0x003953A8 File Offset: 0x003935A8
		public static VectorOffset CreateAssociatedChildQuestIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060191E2 RID: 102882 RVA: 0x003953DF File Offset: 0x003935DF
		public static VectorOffset CreateAssociatedChildQuestIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060191E3 RID: 102883 RVA: 0x003953F9 File Offset: 0x003935F9
		public static VectorOffset CreateAssociatedChildQuestIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060191E4 RID: 102884 RVA: 0x00395417 File Offset: 0x00393617
		public static VectorOffset CreateAssociatedChildQuestIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060191E5 RID: 102885 RVA: 0x00395430 File Offset: 0x00393630
		public static void StartAssociatedChildQuestIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060191E6 RID: 102886 RVA: 0x0039543B File Offset: 0x0039363B
		public static Offset<IQuestScheduleChildQuestCompletedCount> EndIQuestScheduleChildQuestCompletedCount(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleChildQuestCompletedCount>(builder.EndTable());
		}

		// Token: 0x060191E7 RID: 102887 RVA: 0x00395448 File Offset: 0x00393648
		public IQuestScheduleChildQuestCompletedCountT UnPack()
		{
			IQuestScheduleChildQuestCompletedCountT questScheduleChildQuestCompletedCountT = new IQuestScheduleChildQuestCompletedCountT();
			this.UnPackTo(questScheduleChildQuestCompletedCountT);
			return questScheduleChildQuestCompletedCountT;
		}

		// Token: 0x060191E8 RID: 102888 RVA: 0x00395464 File Offset: 0x00393664
		public void UnPackTo(IQuestScheduleChildQuestCompletedCountT _o)
		{
			_o.Type = this.Type;
			_o.AssociatedChildQuestIds = new List<int>();
			for (int i = 0; i < this.AssociatedChildQuestIdsLength; i++)
			{
				_o.AssociatedChildQuestIds.Add(this.AssociatedChildQuestIds(i));
			}
		}

		// Token: 0x060191E9 RID: 102889 RVA: 0x003954AC File Offset: 0x003936AC
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

		// Token: 0x0400C525 RID: 50469
		private Table __p;
	}
}

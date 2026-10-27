using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FFE RID: 16382
	public struct IQuestPlayerHitCount : IFlatbufferObject
	{
		// Token: 0x1700731A RID: 29466
		// (get) Token: 0x06017A0B RID: 96779 RVA: 0x003689BA File Offset: 0x00366BBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017A0C RID: 96780 RVA: 0x003689C7 File Offset: 0x00366BC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017A0D RID: 96781 RVA: 0x003689D0 File Offset: 0x00366BD0
		public static IQuestPlayerHitCount GetRootAsIQuestPlayerHitCount(ByteBuffer _bb)
		{
			return IQuestPlayerHitCount.GetRootAsIQuestPlayerHitCount(_bb, default(IQuestPlayerHitCount));
		}

		// Token: 0x06017A0E RID: 96782 RVA: 0x003689EC File Offset: 0x00366BEC
		public static IQuestPlayerHitCount GetRootAsIQuestPlayerHitCount(ByteBuffer _bb, IQuestPlayerHitCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017A0F RID: 96783 RVA: 0x00368A09 File Offset: 0x00366C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017A10 RID: 96784 RVA: 0x00368A18 File Offset: 0x00366C18
		public IQuestPlayerHitCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700731B RID: 29467
		// (get) Token: 0x06017A11 RID: 96785 RVA: 0x00368A28 File Offset: 0x00366C28
		public EPlayerHitStatisticsType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerHitStatisticsType.HitCount;
				}
				return (EPlayerHitStatisticsType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700731C RID: 29468
		// (get) Token: 0x06017A12 RID: 96786 RVA: 0x00368A64 File Offset: 0x00366C64
		public float Cd
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017A13 RID: 96787 RVA: 0x00368AA4 File Offset: 0x00366CA4
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700731D RID: 29469
		// (get) Token: 0x06017A14 RID: 96788 RVA: 0x00368AE4 File Offset: 0x00366CE4
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017A15 RID: 96789 RVA: 0x00368B0F File Offset: 0x00366D0F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06017A16 RID: 96790 RVA: 0x00368B1E File Offset: 0x00366D1E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06017A17 RID: 96791 RVA: 0x00368B2C File Offset: 0x00366D2C
		public int SkillIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700731E RID: 29470
		// (get) Token: 0x06017A18 RID: 96792 RVA: 0x00368B6C File Offset: 0x00366D6C
		public int SkillIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017A19 RID: 96793 RVA: 0x00368B98 File Offset: 0x00366D98
		public Span<int> GetSkillIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06017A1A RID: 96794 RVA: 0x00368BA8 File Offset: 0x00366DA8
		public int[] GetSkillIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700731F RID: 29471
		// (get) Token: 0x06017A1B RID: 96795 RVA: 0x00368BB8 File Offset: 0x00366DB8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017A1C RID: 96796 RVA: 0x00368BF5 File Offset: 0x00366DF5
		public static Offset<IQuestPlayerHitCount> CreateIQuestPlayerHitCount(FlatBufferBuilder builder, EPlayerHitStatisticsType Type = EPlayerHitStatisticsType.HitCount, float Cd = 0f, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset SkillIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IQuestPlayerHitCount.AddSkillIds(builder, SkillIdsOffset);
			IQuestPlayerHitCount.AddEntityIds(builder, EntityIdsOffset);
			IQuestPlayerHitCount.AddCd(builder, Cd);
			IQuestPlayerHitCount.AddNullMask(builder, NullMask);
			IQuestPlayerHitCount.AddType(builder, Type);
			return IQuestPlayerHitCount.EndIQuestPlayerHitCount(builder);
		}

		// Token: 0x06017A1D RID: 96797 RVA: 0x00368C29 File Offset: 0x00366E29
		public static void StartIQuestPlayerHitCount(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017A1E RID: 96798 RVA: 0x00368C32 File Offset: 0x00366E32
		public static void AddType(FlatBufferBuilder builder, EPlayerHitStatisticsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017A1F RID: 96799 RVA: 0x00368C3D File Offset: 0x00366E3D
		public static void AddCd(FlatBufferBuilder builder, float cd)
		{
			builder.AddFloat(1, cd, 0.0);
		}

		// Token: 0x06017A20 RID: 96800 RVA: 0x00368C50 File Offset: 0x00366E50
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x06017A21 RID: 96801 RVA: 0x00368C60 File Offset: 0x00366E60
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017A22 RID: 96802 RVA: 0x00368C97 File Offset: 0x00366E97
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017A23 RID: 96803 RVA: 0x00368CB1 File Offset: 0x00366EB1
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017A24 RID: 96804 RVA: 0x00368CCF File Offset: 0x00366ECF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017A25 RID: 96805 RVA: 0x00368CE8 File Offset: 0x00366EE8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017A26 RID: 96806 RVA: 0x00368CF3 File Offset: 0x00366EF3
		public static void AddSkillIds(FlatBufferBuilder builder, VectorOffset skillIdsOffset)
		{
			builder.AddOffset(3, skillIdsOffset.Value, 0);
		}

		// Token: 0x06017A27 RID: 96807 RVA: 0x00368D04 File Offset: 0x00366F04
		public static VectorOffset CreateSkillIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017A28 RID: 96808 RVA: 0x00368D3B File Offset: 0x00366F3B
		public static VectorOffset CreateSkillIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017A29 RID: 96809 RVA: 0x00368D55 File Offset: 0x00366F55
		public static VectorOffset CreateSkillIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017A2A RID: 96810 RVA: 0x00368D73 File Offset: 0x00366F73
		public static VectorOffset CreateSkillIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017A2B RID: 96811 RVA: 0x00368D8C File Offset: 0x00366F8C
		public static void StartSkillIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017A2C RID: 96812 RVA: 0x00368D97 File Offset: 0x00366F97
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06017A2D RID: 96813 RVA: 0x00368DA2 File Offset: 0x00366FA2
		public static Offset<IQuestPlayerHitCount> EndIQuestPlayerHitCount(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPlayerHitCount>(builder.EndTable());
		}

		// Token: 0x06017A2E RID: 96814 RVA: 0x00368DB0 File Offset: 0x00366FB0
		public IQuestPlayerHitCountT UnPack()
		{
			IQuestPlayerHitCountT questPlayerHitCountT = new IQuestPlayerHitCountT();
			this.UnPackTo(questPlayerHitCountT);
			return questPlayerHitCountT;
		}

		// Token: 0x06017A2F RID: 96815 RVA: 0x00368DCC File Offset: 0x00366FCC
		public void UnPackTo(IQuestPlayerHitCountT _o)
		{
			_o.Type = this.Type;
			_o.Cd = this.Cd;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.SkillIds = new List<int>();
			for (int j = 0; j < this.SkillIdsLength; j++)
			{
				_o.SkillIds.Add(this.SkillIds(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017A30 RID: 96816 RVA: 0x00368E5C File Offset: 0x0036705C
		public static Offset<IQuestPlayerHitCount> Pack(FlatBufferBuilder builder, IQuestPlayerHitCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestPlayerHitCount>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IQuestPlayerHitCount.CreateEntityIdsVector(builder, data);
			}
			VectorOffset skillIdsOffset = default(VectorOffset);
			if (_o.SkillIds != null)
			{
				int[] data2 = _o.SkillIds.ToArray();
				skillIdsOffset = IQuestPlayerHitCount.CreateSkillIdsVector(builder, data2);
			}
			return IQuestPlayerHitCount.CreateIQuestPlayerHitCount(builder, _o.Type, _o.Cd, entityIdsOffset, skillIdsOffset, _o.NullMask);
		}

		// Token: 0x0400BB11 RID: 47889
		private Table __p;
	}
}

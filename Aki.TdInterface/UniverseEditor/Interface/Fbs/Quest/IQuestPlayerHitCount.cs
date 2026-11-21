using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200443F RID: 17471
	public struct IQuestPlayerHitCount : IFlatbufferObject
	{
		// Token: 0x1700791C RID: 31004
		// (get) Token: 0x060190A4 RID: 102564 RVA: 0x003927AE File Offset: 0x003909AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060190A5 RID: 102565 RVA: 0x003927BB File Offset: 0x003909BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060190A6 RID: 102566 RVA: 0x003927C4 File Offset: 0x003909C4
		public static IQuestPlayerHitCount GetRootAsIQuestPlayerHitCount(ByteBuffer _bb)
		{
			return IQuestPlayerHitCount.GetRootAsIQuestPlayerHitCount(_bb, default(IQuestPlayerHitCount));
		}

		// Token: 0x060190A7 RID: 102567 RVA: 0x003927E0 File Offset: 0x003909E0
		public static IQuestPlayerHitCount GetRootAsIQuestPlayerHitCount(ByteBuffer _bb, IQuestPlayerHitCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060190A8 RID: 102568 RVA: 0x003927FD File Offset: 0x003909FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060190A9 RID: 102569 RVA: 0x0039280C File Offset: 0x00390A0C
		public IQuestPlayerHitCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700791D RID: 31005
		// (get) Token: 0x060190AA RID: 102570 RVA: 0x0039281C File Offset: 0x00390A1C
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

		// Token: 0x1700791E RID: 31006
		// (get) Token: 0x060190AB RID: 102571 RVA: 0x00392858 File Offset: 0x00390A58
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

		// Token: 0x060190AC RID: 102572 RVA: 0x00392898 File Offset: 0x00390A98
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700791F RID: 31007
		// (get) Token: 0x060190AD RID: 102573 RVA: 0x003928D8 File Offset: 0x00390AD8
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

		// Token: 0x060190AE RID: 102574 RVA: 0x00392903 File Offset: 0x00390B03
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060190AF RID: 102575 RVA: 0x00392912 File Offset: 0x00390B12
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x060190B0 RID: 102576 RVA: 0x00392920 File Offset: 0x00390B20
		public int SkillIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007920 RID: 31008
		// (get) Token: 0x060190B1 RID: 102577 RVA: 0x00392960 File Offset: 0x00390B60
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

		// Token: 0x060190B2 RID: 102578 RVA: 0x0039298C File Offset: 0x00390B8C
		public Span<int> GetSkillIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060190B3 RID: 102579 RVA: 0x0039299C File Offset: 0x00390B9C
		public int[] GetSkillIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17007921 RID: 31009
		// (get) Token: 0x060190B4 RID: 102580 RVA: 0x003929AC File Offset: 0x00390BAC
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

		// Token: 0x060190B5 RID: 102581 RVA: 0x003929E9 File Offset: 0x00390BE9
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

		// Token: 0x060190B6 RID: 102582 RVA: 0x00392A1D File Offset: 0x00390C1D
		public static void StartIQuestPlayerHitCount(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060190B7 RID: 102583 RVA: 0x00392A26 File Offset: 0x00390C26
		public static void AddType(FlatBufferBuilder builder, EPlayerHitStatisticsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060190B8 RID: 102584 RVA: 0x00392A31 File Offset: 0x00390C31
		public static void AddCd(FlatBufferBuilder builder, float cd)
		{
			builder.AddFloat(1, cd, 0.0);
		}

		// Token: 0x060190B9 RID: 102585 RVA: 0x00392A44 File Offset: 0x00390C44
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x060190BA RID: 102586 RVA: 0x00392A54 File Offset: 0x00390C54
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060190BB RID: 102587 RVA: 0x00392A8B File Offset: 0x00390C8B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060190BC RID: 102588 RVA: 0x00392AA5 File Offset: 0x00390CA5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060190BD RID: 102589 RVA: 0x00392AC3 File Offset: 0x00390CC3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060190BE RID: 102590 RVA: 0x00392ADC File Offset: 0x00390CDC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060190BF RID: 102591 RVA: 0x00392AE7 File Offset: 0x00390CE7
		public static void AddSkillIds(FlatBufferBuilder builder, VectorOffset skillIdsOffset)
		{
			builder.AddOffset(3, skillIdsOffset.Value, 0);
		}

		// Token: 0x060190C0 RID: 102592 RVA: 0x00392AF8 File Offset: 0x00390CF8
		public static VectorOffset CreateSkillIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060190C1 RID: 102593 RVA: 0x00392B2F File Offset: 0x00390D2F
		public static VectorOffset CreateSkillIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060190C2 RID: 102594 RVA: 0x00392B49 File Offset: 0x00390D49
		public static VectorOffset CreateSkillIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060190C3 RID: 102595 RVA: 0x00392B67 File Offset: 0x00390D67
		public static VectorOffset CreateSkillIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060190C4 RID: 102596 RVA: 0x00392B80 File Offset: 0x00390D80
		public static void StartSkillIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060190C5 RID: 102597 RVA: 0x00392B8B File Offset: 0x00390D8B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060190C6 RID: 102598 RVA: 0x00392B96 File Offset: 0x00390D96
		public static Offset<IQuestPlayerHitCount> EndIQuestPlayerHitCount(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPlayerHitCount>(builder.EndTable());
		}

		// Token: 0x060190C7 RID: 102599 RVA: 0x00392BA4 File Offset: 0x00390DA4
		public IQuestPlayerHitCountT UnPack()
		{
			IQuestPlayerHitCountT questPlayerHitCountT = new IQuestPlayerHitCountT();
			this.UnPackTo(questPlayerHitCountT);
			return questPlayerHitCountT;
		}

		// Token: 0x060190C8 RID: 102600 RVA: 0x00392BC0 File Offset: 0x00390DC0
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

		// Token: 0x060190C9 RID: 102601 RVA: 0x00392C50 File Offset: 0x00390E50
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

		// Token: 0x0400C4F8 RID: 50424
		private Table __p;
	}
}

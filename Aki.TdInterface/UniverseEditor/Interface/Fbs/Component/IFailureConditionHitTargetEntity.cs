using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005222 RID: 21026
	public struct IFailureConditionHitTargetEntity : IFlatbufferObject
	{
		// Token: 0x170099FE RID: 39422
		// (get) Token: 0x060222C1 RID: 139969 RVA: 0x004BDA81 File Offset: 0x004BBC81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060222C2 RID: 139970 RVA: 0x004BDA8E File Offset: 0x004BBC8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060222C3 RID: 139971 RVA: 0x004BDA98 File Offset: 0x004BBC98
		public static IFailureConditionHitTargetEntity GetRootAsIFailureConditionHitTargetEntity(ByteBuffer _bb)
		{
			return IFailureConditionHitTargetEntity.GetRootAsIFailureConditionHitTargetEntity(_bb, default(IFailureConditionHitTargetEntity));
		}

		// Token: 0x060222C4 RID: 139972 RVA: 0x004BDAB4 File Offset: 0x004BBCB4
		public static IFailureConditionHitTargetEntity GetRootAsIFailureConditionHitTargetEntity(ByteBuffer _bb, IFailureConditionHitTargetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060222C5 RID: 139973 RVA: 0x004BDAD1 File Offset: 0x004BBCD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060222C6 RID: 139974 RVA: 0x004BDAE0 File Offset: 0x004BBCE0
		public IFailureConditionHitTargetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099FF RID: 39423
		// (get) Token: 0x060222C7 RID: 139975 RVA: 0x004BDAF0 File Offset: 0x004BBCF0
		public ETargetGearGroupFailureCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetGearGroupFailureCondition.ArbitraryState;
				}
				return (ETargetGearGroupFailureCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060222C8 RID: 139976 RVA: 0x004BDB2C File Offset: 0x004BBD2C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009A00 RID: 39424
		// (get) Token: 0x060222C9 RID: 139977 RVA: 0x004BDB6C File Offset: 0x004BBD6C
		public int EntityIdsLength
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

		// Token: 0x060222CA RID: 139978 RVA: 0x004BDB97 File Offset: 0x004BBD97
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060222CB RID: 139979 RVA: 0x004BDBA6 File Offset: 0x004BBDA6
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060222CC RID: 139980 RVA: 0x004BDBB4 File Offset: 0x004BBDB4
		public static Offset<IFailureConditionHitTargetEntity> CreateIFailureConditionHitTargetEntity(FlatBufferBuilder builder, ETargetGearGroupFailureCondition Type = ETargetGearGroupFailureCondition.ArbitraryState, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFailureConditionHitTargetEntity.AddEntityIds(builder, EntityIdsOffset);
			IFailureConditionHitTargetEntity.AddType(builder, Type);
			return IFailureConditionHitTargetEntity.EndIFailureConditionHitTargetEntity(builder);
		}

		// Token: 0x060222CD RID: 139981 RVA: 0x004BDBD1 File Offset: 0x004BBDD1
		public static void StartIFailureConditionHitTargetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060222CE RID: 139982 RVA: 0x004BDBDA File Offset: 0x004BBDDA
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060222CF RID: 139983 RVA: 0x004BDBE5 File Offset: 0x004BBDE5
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x060222D0 RID: 139984 RVA: 0x004BDBF8 File Offset: 0x004BBDF8
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060222D1 RID: 139985 RVA: 0x004BDC2F File Offset: 0x004BBE2F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060222D2 RID: 139986 RVA: 0x004BDC49 File Offset: 0x004BBE49
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060222D3 RID: 139987 RVA: 0x004BDC67 File Offset: 0x004BBE67
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060222D4 RID: 139988 RVA: 0x004BDC80 File Offset: 0x004BBE80
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060222D5 RID: 139989 RVA: 0x004BDC8B File Offset: 0x004BBE8B
		public static Offset<IFailureConditionHitTargetEntity> EndIFailureConditionHitTargetEntity(FlatBufferBuilder builder)
		{
			return new Offset<IFailureConditionHitTargetEntity>(builder.EndTable());
		}

		// Token: 0x060222D6 RID: 139990 RVA: 0x004BDC98 File Offset: 0x004BBE98
		public IFailureConditionHitTargetEntityT UnPack()
		{
			IFailureConditionHitTargetEntityT failureConditionHitTargetEntityT = new IFailureConditionHitTargetEntityT();
			this.UnPackTo(failureConditionHitTargetEntityT);
			return failureConditionHitTargetEntityT;
		}

		// Token: 0x060222D7 RID: 139991 RVA: 0x004BDCB4 File Offset: 0x004BBEB4
		public void UnPackTo(IFailureConditionHitTargetEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x060222D8 RID: 139992 RVA: 0x004BDCFC File Offset: 0x004BBEFC
		public static Offset<IFailureConditionHitTargetEntity> Pack(FlatBufferBuilder builder, IFailureConditionHitTargetEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFailureConditionHitTargetEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IFailureConditionHitTargetEntity.CreateEntityIdsVector(builder, data);
			}
			return IFailureConditionHitTargetEntity.CreateIFailureConditionHitTargetEntity(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x0400E35D RID: 58205
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200578A RID: 22410
	public struct IFailureConditionHitTargetEntity : IFlatbufferObject
	{
		// Token: 0x1700A1FA RID: 41466
		// (get) Token: 0x06024257 RID: 148055 RVA: 0x004F8545 File Offset: 0x004F6745
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024258 RID: 148056 RVA: 0x004F8552 File Offset: 0x004F6752
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024259 RID: 148057 RVA: 0x004F855C File Offset: 0x004F675C
		public static IFailureConditionHitTargetEntity GetRootAsIFailureConditionHitTargetEntity(ByteBuffer _bb)
		{
			return IFailureConditionHitTargetEntity.GetRootAsIFailureConditionHitTargetEntity(_bb, default(IFailureConditionHitTargetEntity));
		}

		// Token: 0x0602425A RID: 148058 RVA: 0x004F8578 File Offset: 0x004F6778
		public static IFailureConditionHitTargetEntity GetRootAsIFailureConditionHitTargetEntity(ByteBuffer _bb, IFailureConditionHitTargetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602425B RID: 148059 RVA: 0x004F8595 File Offset: 0x004F6795
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602425C RID: 148060 RVA: 0x004F85A4 File Offset: 0x004F67A4
		public IFailureConditionHitTargetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1FB RID: 41467
		// (get) Token: 0x0602425D RID: 148061 RVA: 0x004F85B4 File Offset: 0x004F67B4
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

		// Token: 0x0602425E RID: 148062 RVA: 0x004F85F0 File Offset: 0x004F67F0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A1FC RID: 41468
		// (get) Token: 0x0602425F RID: 148063 RVA: 0x004F8630 File Offset: 0x004F6830
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

		// Token: 0x06024260 RID: 148064 RVA: 0x004F865B File Offset: 0x004F685B
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06024261 RID: 148065 RVA: 0x004F866A File Offset: 0x004F686A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06024262 RID: 148066 RVA: 0x004F8678 File Offset: 0x004F6878
		public static Offset<IFailureConditionHitTargetEntity> CreateIFailureConditionHitTargetEntity(FlatBufferBuilder builder, ETargetGearGroupFailureCondition Type = ETargetGearGroupFailureCondition.ArbitraryState, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFailureConditionHitTargetEntity.AddEntityIds(builder, EntityIdsOffset);
			IFailureConditionHitTargetEntity.AddType(builder, Type);
			return IFailureConditionHitTargetEntity.EndIFailureConditionHitTargetEntity(builder);
		}

		// Token: 0x06024263 RID: 148067 RVA: 0x004F8695 File Offset: 0x004F6895
		public static void StartIFailureConditionHitTargetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024264 RID: 148068 RVA: 0x004F869E File Offset: 0x004F689E
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024265 RID: 148069 RVA: 0x004F86A9 File Offset: 0x004F68A9
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06024266 RID: 148070 RVA: 0x004F86BC File Offset: 0x004F68BC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024267 RID: 148071 RVA: 0x004F86F3 File Offset: 0x004F68F3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024268 RID: 148072 RVA: 0x004F870D File Offset: 0x004F690D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024269 RID: 148073 RVA: 0x004F872B File Offset: 0x004F692B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602426A RID: 148074 RVA: 0x004F8744 File Offset: 0x004F6944
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602426B RID: 148075 RVA: 0x004F874F File Offset: 0x004F694F
		public static Offset<IFailureConditionHitTargetEntity> EndIFailureConditionHitTargetEntity(FlatBufferBuilder builder)
		{
			return new Offset<IFailureConditionHitTargetEntity>(builder.EndTable());
		}

		// Token: 0x0602426C RID: 148076 RVA: 0x004F875C File Offset: 0x004F695C
		public IFailureConditionHitTargetEntityT UnPack()
		{
			IFailureConditionHitTargetEntityT failureConditionHitTargetEntityT = new IFailureConditionHitTargetEntityT();
			this.UnPackTo(failureConditionHitTargetEntityT);
			return failureConditionHitTargetEntityT;
		}

		// Token: 0x0602426D RID: 148077 RVA: 0x004F8778 File Offset: 0x004F6978
		public void UnPackTo(IFailureConditionHitTargetEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0602426E RID: 148078 RVA: 0x004F87C0 File Offset: 0x004F69C0
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

		// Token: 0x0400EF63 RID: 61283
		private Table __p;
	}
}

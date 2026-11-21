using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007633 RID: 30259
	public struct IResetTeleControlEntity : IFlatbufferObject
	{
		// Token: 0x1700DE48 RID: 56904
		// (get) Token: 0x06035185 RID: 217477 RVA: 0x00721710 File Offset: 0x0071F910
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035186 RID: 217478 RVA: 0x0072171D File Offset: 0x0071F91D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035187 RID: 217479 RVA: 0x00721724 File Offset: 0x0071F924
		public static IResetTeleControlEntity GetRootAsIResetTeleControlEntity(ByteBuffer _bb)
		{
			return IResetTeleControlEntity.GetRootAsIResetTeleControlEntity(_bb, default(IResetTeleControlEntity));
		}

		// Token: 0x06035188 RID: 217480 RVA: 0x00721740 File Offset: 0x0071F940
		public static IResetTeleControlEntity GetRootAsIResetTeleControlEntity(ByteBuffer _bb, IResetTeleControlEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035189 RID: 217481 RVA: 0x0072175D File Offset: 0x0071F95D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603518A RID: 217482 RVA: 0x0072176C File Offset: 0x0071F96C
		public IResetTeleControlEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE49 RID: 56905
		// (get) Token: 0x0603518B RID: 217483 RVA: 0x0072177C File Offset: 0x0071F97C
		public EResetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetEntityType.TeleControl;
				}
				return (EResetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603518C RID: 217484 RVA: 0x007217B8 File Offset: 0x0071F9B8
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DE4A RID: 56906
		// (get) Token: 0x0603518D RID: 217485 RVA: 0x007217F8 File Offset: 0x0071F9F8
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

		// Token: 0x0603518E RID: 217486 RVA: 0x00721823 File Offset: 0x0071FA23
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0603518F RID: 217487 RVA: 0x00721832 File Offset: 0x0071FA32
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06035190 RID: 217488 RVA: 0x00721840 File Offset: 0x0071FA40
		public static Offset<IResetTeleControlEntity> CreateIResetTeleControlEntity(FlatBufferBuilder builder, EResetEntityType Type = EResetEntityType.TeleControl, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IResetTeleControlEntity.AddEntityIds(builder, EntityIdsOffset);
			IResetTeleControlEntity.AddType(builder, Type);
			return IResetTeleControlEntity.EndIResetTeleControlEntity(builder);
		}

		// Token: 0x06035191 RID: 217489 RVA: 0x0072185D File Offset: 0x0071FA5D
		public static void StartIResetTeleControlEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035192 RID: 217490 RVA: 0x00721866 File Offset: 0x0071FA66
		public static void AddType(FlatBufferBuilder builder, EResetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035193 RID: 217491 RVA: 0x00721871 File Offset: 0x0071FA71
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06035194 RID: 217492 RVA: 0x00721884 File Offset: 0x0071FA84
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035195 RID: 217493 RVA: 0x007218BB File Offset: 0x0071FABB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035196 RID: 217494 RVA: 0x007218D5 File Offset: 0x0071FAD5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035197 RID: 217495 RVA: 0x007218F3 File Offset: 0x0071FAF3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035198 RID: 217496 RVA: 0x0072190C File Offset: 0x0071FB0C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035199 RID: 217497 RVA: 0x00721917 File Offset: 0x0071FB17
		public static Offset<IResetTeleControlEntity> EndIResetTeleControlEntity(FlatBufferBuilder builder)
		{
			return new Offset<IResetTeleControlEntity>(builder.EndTable());
		}

		// Token: 0x0603519A RID: 217498 RVA: 0x00721924 File Offset: 0x0071FB24
		public IResetTeleControlEntityT UnPack()
		{
			IResetTeleControlEntityT resetTeleControlEntityT = new IResetTeleControlEntityT();
			this.UnPackTo(resetTeleControlEntityT);
			return resetTeleControlEntityT;
		}

		// Token: 0x0603519B RID: 217499 RVA: 0x00721940 File Offset: 0x0071FB40
		public void UnPackTo(IResetTeleControlEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0603519C RID: 217500 RVA: 0x00721988 File Offset: 0x0071FB88
		public static Offset<IResetTeleControlEntity> Pack(FlatBufferBuilder builder, IResetTeleControlEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetTeleControlEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IResetTeleControlEntity.CreateEntityIdsVector(builder, data);
			}
			return IResetTeleControlEntity.CreateIResetTeleControlEntity(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x0401282A RID: 75818
		private Table __p;
	}
}

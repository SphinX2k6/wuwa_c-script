using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046EB RID: 18155
	public struct IWarningPreformActivateStateRecordEntity : IFlatbufferObject
	{
		// Token: 0x17007F31 RID: 32561
		// (get) Token: 0x0601AB51 RID: 109393 RVA: 0x003CBD8D File Offset: 0x003C9F8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AB52 RID: 109394 RVA: 0x003CBD9A File Offset: 0x003C9F9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AB53 RID: 109395 RVA: 0x003CBDA4 File Offset: 0x003C9FA4
		public static IWarningPreformActivateStateRecordEntity GetRootAsIWarningPreformActivateStateRecordEntity(ByteBuffer _bb)
		{
			return IWarningPreformActivateStateRecordEntity.GetRootAsIWarningPreformActivateStateRecordEntity(_bb, default(IWarningPreformActivateStateRecordEntity));
		}

		// Token: 0x0601AB54 RID: 109396 RVA: 0x003CBDC0 File Offset: 0x003C9FC0
		public static IWarningPreformActivateStateRecordEntity GetRootAsIWarningPreformActivateStateRecordEntity(ByteBuffer _bb, IWarningPreformActivateStateRecordEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AB55 RID: 109397 RVA: 0x003CBDDD File Offset: 0x003C9FDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AB56 RID: 109398 RVA: 0x003CBDEC File Offset: 0x003C9FEC
		public IWarningPreformActivateStateRecordEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F32 RID: 32562
		// (get) Token: 0x0601AB57 RID: 109399 RVA: 0x003CBDFC File Offset: 0x003C9FFC
		public EWarningPreformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWarningPreformType.FadeInScreen;
				}
				return (EWarningPreformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AB58 RID: 109400 RVA: 0x003CBE38 File Offset: 0x003CA038
		public int TargetEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007F33 RID: 32563
		// (get) Token: 0x0601AB59 RID: 109401 RVA: 0x003CBE78 File Offset: 0x003CA078
		public int TargetEntityIdsLength
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

		// Token: 0x0601AB5A RID: 109402 RVA: 0x003CBEA3 File Offset: 0x003CA0A3
		public Span<int> GetTargetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601AB5B RID: 109403 RVA: 0x003CBEB2 File Offset: 0x003CA0B2
		public int[] GetTargetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601AB5C RID: 109404 RVA: 0x003CBEC0 File Offset: 0x003CA0C0
		public static Offset<IWarningPreformActivateStateRecordEntity> CreateIWarningPreformActivateStateRecordEntity(FlatBufferBuilder builder, EWarningPreformType Type = EWarningPreformType.FadeInScreen, VectorOffset TargetEntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IWarningPreformActivateStateRecordEntity.AddTargetEntityIds(builder, TargetEntityIdsOffset);
			IWarningPreformActivateStateRecordEntity.AddType(builder, Type);
			return IWarningPreformActivateStateRecordEntity.EndIWarningPreformActivateStateRecordEntity(builder);
		}

		// Token: 0x0601AB5D RID: 109405 RVA: 0x003CBEDD File Offset: 0x003CA0DD
		public static void StartIWarningPreformActivateStateRecordEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AB5E RID: 109406 RVA: 0x003CBEE6 File Offset: 0x003CA0E6
		public static void AddType(FlatBufferBuilder builder, EWarningPreformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AB5F RID: 109407 RVA: 0x003CBEF1 File Offset: 0x003CA0F1
		public static void AddTargetEntityIds(FlatBufferBuilder builder, VectorOffset targetEntityIdsOffset)
		{
			builder.AddOffset(1, targetEntityIdsOffset.Value, 0);
		}

		// Token: 0x0601AB60 RID: 109408 RVA: 0x003CBF04 File Offset: 0x003CA104
		public static VectorOffset CreateTargetEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AB61 RID: 109409 RVA: 0x003CBF3B File Offset: 0x003CA13B
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AB62 RID: 109410 RVA: 0x003CBF55 File Offset: 0x003CA155
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AB63 RID: 109411 RVA: 0x003CBF73 File Offset: 0x003CA173
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AB64 RID: 109412 RVA: 0x003CBF8C File Offset: 0x003CA18C
		public static void StartTargetEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AB65 RID: 109413 RVA: 0x003CBF97 File Offset: 0x003CA197
		public static Offset<IWarningPreformActivateStateRecordEntity> EndIWarningPreformActivateStateRecordEntity(FlatBufferBuilder builder)
		{
			return new Offset<IWarningPreformActivateStateRecordEntity>(builder.EndTable());
		}

		// Token: 0x0601AB66 RID: 109414 RVA: 0x003CBFA4 File Offset: 0x003CA1A4
		public IWarningPreformActivateStateRecordEntityT UnPack()
		{
			IWarningPreformActivateStateRecordEntityT warningPreformActivateStateRecordEntityT = new IWarningPreformActivateStateRecordEntityT();
			this.UnPackTo(warningPreformActivateStateRecordEntityT);
			return warningPreformActivateStateRecordEntityT;
		}

		// Token: 0x0601AB67 RID: 109415 RVA: 0x003CBFC0 File Offset: 0x003CA1C0
		public void UnPackTo(IWarningPreformActivateStateRecordEntityT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntityIds = new List<int>();
			for (int i = 0; i < this.TargetEntityIdsLength; i++)
			{
				_o.TargetEntityIds.Add(this.TargetEntityIds(i));
			}
		}

		// Token: 0x0601AB68 RID: 109416 RVA: 0x003CC008 File Offset: 0x003CA208
		public static Offset<IWarningPreformActivateStateRecordEntity> Pack(FlatBufferBuilder builder, IWarningPreformActivateStateRecordEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWarningPreformActivateStateRecordEntity>);
			}
			VectorOffset targetEntityIdsOffset = default(VectorOffset);
			if (_o.TargetEntityIds != null)
			{
				int[] data = _o.TargetEntityIds.ToArray();
				targetEntityIdsOffset = IWarningPreformActivateStateRecordEntity.CreateTargetEntityIdsVector(builder, data);
			}
			return IWarningPreformActivateStateRecordEntity.CreateIWarningPreformActivateStateRecordEntity(builder, _o.Type, targetEntityIdsOffset);
		}

		// Token: 0x0400C93C RID: 51516
		private Table __p;
	}
}

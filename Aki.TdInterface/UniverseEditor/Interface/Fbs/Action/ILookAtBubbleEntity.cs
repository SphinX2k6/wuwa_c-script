using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A56 RID: 27222
	public struct ILookAtBubbleEntity : IFlatbufferObject
	{
		// Token: 0x1700C9F1 RID: 51697
		// (get) Token: 0x0602FA9E RID: 195230 RVA: 0x0067CAFC File Offset: 0x0067ACFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA9F RID: 195231 RVA: 0x0067CB09 File Offset: 0x0067AD09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FAA0 RID: 195232 RVA: 0x0067CB10 File Offset: 0x0067AD10
		public static ILookAtBubbleEntity GetRootAsILookAtBubbleEntity(ByteBuffer _bb)
		{
			return ILookAtBubbleEntity.GetRootAsILookAtBubbleEntity(_bb, default(ILookAtBubbleEntity));
		}

		// Token: 0x0602FAA1 RID: 195233 RVA: 0x0067CB2C File Offset: 0x0067AD2C
		public static ILookAtBubbleEntity GetRootAsILookAtBubbleEntity(ByteBuffer _bb, ILookAtBubbleEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FAA2 RID: 195234 RVA: 0x0067CB49 File Offset: 0x0067AD49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FAA3 RID: 195235 RVA: 0x0067CB58 File Offset: 0x0067AD58
		public ILookAtBubbleEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9F2 RID: 51698
		// (get) Token: 0x0602FAA4 RID: 195236 RVA: 0x0067CB68 File Offset: 0x0067AD68
		public EDefaultLookAtType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDefaultLookAtType.LookAtBubbleEntity;
				}
				return (EDefaultLookAtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FAA5 RID: 195237 RVA: 0x0067CBA4 File Offset: 0x0067ADA4
		public ILookAtBubbleEntityConfig? BubbleEntityConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILookAtBubbleEntityConfig?(default(ILookAtBubbleEntityConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C9F3 RID: 51699
		// (get) Token: 0x0602FAA6 RID: 195238 RVA: 0x0067CC04 File Offset: 0x0067AE04
		public int BubbleEntityConfigLength
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

		// Token: 0x0602FAA7 RID: 195239 RVA: 0x0067CC2F File Offset: 0x0067AE2F
		public static Offset<ILookAtBubbleEntity> CreateILookAtBubbleEntity(FlatBufferBuilder builder, EDefaultLookAtType Type = EDefaultLookAtType.LookAtBubbleEntity, VectorOffset BubbleEntityConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILookAtBubbleEntity.AddBubbleEntityConfig(builder, BubbleEntityConfigOffset);
			ILookAtBubbleEntity.AddType(builder, Type);
			return ILookAtBubbleEntity.EndILookAtBubbleEntity(builder);
		}

		// Token: 0x0602FAA8 RID: 195240 RVA: 0x0067CC4C File Offset: 0x0067AE4C
		public static void StartILookAtBubbleEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FAA9 RID: 195241 RVA: 0x0067CC55 File Offset: 0x0067AE55
		public static void AddType(FlatBufferBuilder builder, EDefaultLookAtType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FAAA RID: 195242 RVA: 0x0067CC60 File Offset: 0x0067AE60
		public static void AddBubbleEntityConfig(FlatBufferBuilder builder, VectorOffset bubbleEntityConfigOffset)
		{
			builder.AddOffset(1, bubbleEntityConfigOffset.Value, 0);
		}

		// Token: 0x0602FAAB RID: 195243 RVA: 0x0067CC70 File Offset: 0x0067AE70
		public static VectorOffset CreateBubbleEntityConfigVector(FlatBufferBuilder builder, Offset<ILookAtBubbleEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FAAC RID: 195244 RVA: 0x0067CCB0 File Offset: 0x0067AEB0
		public static VectorOffset CreateBubbleEntityConfigVectorBlock(FlatBufferBuilder builder, Offset<ILookAtBubbleEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILookAtBubbleEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FAAD RID: 195245 RVA: 0x0067CCCA File Offset: 0x0067AECA
		public static VectorOffset CreateBubbleEntityConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILookAtBubbleEntityConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILookAtBubbleEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FAAE RID: 195246 RVA: 0x0067CCE8 File Offset: 0x0067AEE8
		public static VectorOffset CreateBubbleEntityConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILookAtBubbleEntityConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FAAF RID: 195247 RVA: 0x0067CD01 File Offset: 0x0067AF01
		public static void StartBubbleEntityConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FAB0 RID: 195248 RVA: 0x0067CD0C File Offset: 0x0067AF0C
		public static Offset<ILookAtBubbleEntity> EndILookAtBubbleEntity(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtBubbleEntity>(builder.EndTable());
		}

		// Token: 0x0602FAB1 RID: 195249 RVA: 0x0067CD1C File Offset: 0x0067AF1C
		public ILookAtBubbleEntityT UnPack()
		{
			ILookAtBubbleEntityT lookAtBubbleEntityT = new ILookAtBubbleEntityT();
			this.UnPackTo(lookAtBubbleEntityT);
			return lookAtBubbleEntityT;
		}

		// Token: 0x0602FAB2 RID: 195250 RVA: 0x0067CD38 File Offset: 0x0067AF38
		public void UnPackTo(ILookAtBubbleEntityT _o)
		{
			_o.Type = this.Type;
			_o.BubbleEntityConfig = new List<ILookAtBubbleEntityConfigT>();
			for (int i = 0; i < this.BubbleEntityConfigLength; i++)
			{
				_o.BubbleEntityConfig.Add((this.BubbleEntityConfig(i) != null) ? this.BubbleEntityConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602FAB3 RID: 195251 RVA: 0x0067CDA4 File Offset: 0x0067AFA4
		public static Offset<ILookAtBubbleEntity> Pack(FlatBufferBuilder builder, ILookAtBubbleEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtBubbleEntity>);
			}
			VectorOffset bubbleEntityConfigOffset = default(VectorOffset);
			if (_o.BubbleEntityConfig != null)
			{
				Offset<ILookAtBubbleEntityConfig>[] array = new Offset<ILookAtBubbleEntityConfig>[_o.BubbleEntityConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILookAtBubbleEntityConfig.Pack(builder, _o.BubbleEntityConfig[i]);
				}
				bubbleEntityConfigOffset = ILookAtBubbleEntity.CreateBubbleEntityConfigVector(builder, array);
			}
			return ILookAtBubbleEntity.CreateILookAtBubbleEntity(builder, _o.Type, bubbleEntityConfigOffset);
		}

		// Token: 0x04011275 RID: 70261
		private Table __p;
	}
}

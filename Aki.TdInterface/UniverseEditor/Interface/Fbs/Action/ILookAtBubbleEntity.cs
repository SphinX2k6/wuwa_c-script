using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007178 RID: 29048
	public struct ILookAtBubbleEntity : IFlatbufferObject
	{
		// Token: 0x1700D49C RID: 54428
		// (get) Token: 0x060327C4 RID: 206788 RVA: 0x006D2BBC File Offset: 0x006D0DBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060327C5 RID: 206789 RVA: 0x006D2BC9 File Offset: 0x006D0DC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060327C6 RID: 206790 RVA: 0x006D2BD0 File Offset: 0x006D0DD0
		public static ILookAtBubbleEntity GetRootAsILookAtBubbleEntity(ByteBuffer _bb)
		{
			return ILookAtBubbleEntity.GetRootAsILookAtBubbleEntity(_bb, default(ILookAtBubbleEntity));
		}

		// Token: 0x060327C7 RID: 206791 RVA: 0x006D2BEC File Offset: 0x006D0DEC
		public static ILookAtBubbleEntity GetRootAsILookAtBubbleEntity(ByteBuffer _bb, ILookAtBubbleEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060327C8 RID: 206792 RVA: 0x006D2C09 File Offset: 0x006D0E09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060327C9 RID: 206793 RVA: 0x006D2C18 File Offset: 0x006D0E18
		public ILookAtBubbleEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D49D RID: 54429
		// (get) Token: 0x060327CA RID: 206794 RVA: 0x006D2C28 File Offset: 0x006D0E28
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

		// Token: 0x060327CB RID: 206795 RVA: 0x006D2C64 File Offset: 0x006D0E64
		public ILookAtBubbleEntityConfig? BubbleEntityConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILookAtBubbleEntityConfig?(default(ILookAtBubbleEntityConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D49E RID: 54430
		// (get) Token: 0x060327CC RID: 206796 RVA: 0x006D2CC4 File Offset: 0x006D0EC4
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

		// Token: 0x060327CD RID: 206797 RVA: 0x006D2CEF File Offset: 0x006D0EEF
		public static Offset<ILookAtBubbleEntity> CreateILookAtBubbleEntity(FlatBufferBuilder builder, EDefaultLookAtType Type = EDefaultLookAtType.LookAtBubbleEntity, VectorOffset BubbleEntityConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILookAtBubbleEntity.AddBubbleEntityConfig(builder, BubbleEntityConfigOffset);
			ILookAtBubbleEntity.AddType(builder, Type);
			return ILookAtBubbleEntity.EndILookAtBubbleEntity(builder);
		}

		// Token: 0x060327CE RID: 206798 RVA: 0x006D2D0C File Offset: 0x006D0F0C
		public static void StartILookAtBubbleEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060327CF RID: 206799 RVA: 0x006D2D15 File Offset: 0x006D0F15
		public static void AddType(FlatBufferBuilder builder, EDefaultLookAtType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060327D0 RID: 206800 RVA: 0x006D2D20 File Offset: 0x006D0F20
		public static void AddBubbleEntityConfig(FlatBufferBuilder builder, VectorOffset bubbleEntityConfigOffset)
		{
			builder.AddOffset(1, bubbleEntityConfigOffset.Value, 0);
		}

		// Token: 0x060327D1 RID: 206801 RVA: 0x006D2D30 File Offset: 0x006D0F30
		public static VectorOffset CreateBubbleEntityConfigVector(FlatBufferBuilder builder, Offset<ILookAtBubbleEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060327D2 RID: 206802 RVA: 0x006D2D70 File Offset: 0x006D0F70
		public static VectorOffset CreateBubbleEntityConfigVectorBlock(FlatBufferBuilder builder, Offset<ILookAtBubbleEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILookAtBubbleEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060327D3 RID: 206803 RVA: 0x006D2D8A File Offset: 0x006D0F8A
		public static VectorOffset CreateBubbleEntityConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILookAtBubbleEntityConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILookAtBubbleEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060327D4 RID: 206804 RVA: 0x006D2DA8 File Offset: 0x006D0FA8
		public static VectorOffset CreateBubbleEntityConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILookAtBubbleEntityConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060327D5 RID: 206805 RVA: 0x006D2DC1 File Offset: 0x006D0FC1
		public static void StartBubbleEntityConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060327D6 RID: 206806 RVA: 0x006D2DCC File Offset: 0x006D0FCC
		public static Offset<ILookAtBubbleEntity> EndILookAtBubbleEntity(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtBubbleEntity>(builder.EndTable());
		}

		// Token: 0x060327D7 RID: 206807 RVA: 0x006D2DDC File Offset: 0x006D0FDC
		public ILookAtBubbleEntityT UnPack()
		{
			ILookAtBubbleEntityT lookAtBubbleEntityT = new ILookAtBubbleEntityT();
			this.UnPackTo(lookAtBubbleEntityT);
			return lookAtBubbleEntityT;
		}

		// Token: 0x060327D8 RID: 206808 RVA: 0x006D2DF8 File Offset: 0x006D0FF8
		public void UnPackTo(ILookAtBubbleEntityT _o)
		{
			_o.Type = this.Type;
			_o.BubbleEntityConfig = new List<ILookAtBubbleEntityConfigT>();
			for (int i = 0; i < this.BubbleEntityConfigLength; i++)
			{
				_o.BubbleEntityConfig.Add((this.BubbleEntityConfig(i) != null) ? this.BubbleEntityConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060327D9 RID: 206809 RVA: 0x006D2E64 File Offset: 0x006D1064
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

		// Token: 0x0401216D RID: 74093
		private Table __p;
	}
}

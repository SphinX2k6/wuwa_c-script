using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005267 RID: 21095
	public struct IFixedAngleTurntable : IFlatbufferObject
	{
		// Token: 0x17009A7F RID: 39551
		// (get) Token: 0x0602250F RID: 140559 RVA: 0x004C1D90 File Offset: 0x004BFF90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022510 RID: 140560 RVA: 0x004C1D9D File Offset: 0x004BFF9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022511 RID: 140561 RVA: 0x004C1DA4 File Offset: 0x004BFFA4
		public static IFixedAngleTurntable GetRootAsIFixedAngleTurntable(ByteBuffer _bb)
		{
			return IFixedAngleTurntable.GetRootAsIFixedAngleTurntable(_bb, default(IFixedAngleTurntable));
		}

		// Token: 0x06022512 RID: 140562 RVA: 0x004C1DC0 File Offset: 0x004BFFC0
		public static IFixedAngleTurntable GetRootAsIFixedAngleTurntable(ByteBuffer _bb, IFixedAngleTurntable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022513 RID: 140563 RVA: 0x004C1DDD File Offset: 0x004BFFDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022514 RID: 140564 RVA: 0x004C1DEC File Offset: 0x004BFFEC
		public IFixedAngleTurntable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A80 RID: 39552
		// (get) Token: 0x06022515 RID: 140565 RVA: 0x004C1DFC File Offset: 0x004BFFFC
		public EControllerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControllerType.FreeAngle;
				}
				return (EControllerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009A81 RID: 39553
		// (get) Token: 0x06022516 RID: 140566 RVA: 0x004C1E38 File Offset: 0x004C0038
		public int RotationSpeed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022517 RID: 140567 RVA: 0x004C1E74 File Offset: 0x004C0074
		public IFixedAngleItem? ItemConfig(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IFixedAngleItem?(default(IFixedAngleItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009A82 RID: 39554
		// (get) Token: 0x06022518 RID: 140568 RVA: 0x004C1ED4 File Offset: 0x004C00D4
		public int ItemConfigLength
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

		// Token: 0x06022519 RID: 140569 RVA: 0x004C1EFF File Offset: 0x004C00FF
		public static Offset<IFixedAngleTurntable> CreateIFixedAngleTurntable(FlatBufferBuilder builder, EControllerType Type = EControllerType.FreeAngle, int RotationSpeed = 0, VectorOffset ItemConfigOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IFixedAngleTurntable.AddItemConfig(builder, ItemConfigOffset);
			IFixedAngleTurntable.AddRotationSpeed(builder, RotationSpeed);
			IFixedAngleTurntable.AddType(builder, Type);
			return IFixedAngleTurntable.EndIFixedAngleTurntable(builder);
		}

		// Token: 0x0602251A RID: 140570 RVA: 0x004C1F23 File Offset: 0x004C0123
		public static void StartIFixedAngleTurntable(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602251B RID: 140571 RVA: 0x004C1F2C File Offset: 0x004C012C
		public static void AddType(FlatBufferBuilder builder, EControllerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602251C RID: 140572 RVA: 0x004C1F37 File Offset: 0x004C0137
		public static void AddRotationSpeed(FlatBufferBuilder builder, int rotationSpeed)
		{
			builder.AddInt(1, rotationSpeed, 0);
		}

		// Token: 0x0602251D RID: 140573 RVA: 0x004C1F42 File Offset: 0x004C0142
		public static void AddItemConfig(FlatBufferBuilder builder, VectorOffset itemConfigOffset)
		{
			builder.AddOffset(2, itemConfigOffset.Value, 0);
		}

		// Token: 0x0602251E RID: 140574 RVA: 0x004C1F54 File Offset: 0x004C0154
		public static VectorOffset CreateItemConfigVector(FlatBufferBuilder builder, Offset<IFixedAngleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602251F RID: 140575 RVA: 0x004C1F94 File Offset: 0x004C0194
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, Offset<IFixedAngleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFixedAngleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022520 RID: 140576 RVA: 0x004C1FAE File Offset: 0x004C01AE
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFixedAngleItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFixedAngleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022521 RID: 140577 RVA: 0x004C1FCC File Offset: 0x004C01CC
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFixedAngleItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022522 RID: 140578 RVA: 0x004C1FE5 File Offset: 0x004C01E5
		public static void StartItemConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022523 RID: 140579 RVA: 0x004C1FF0 File Offset: 0x004C01F0
		public static Offset<IFixedAngleTurntable> EndIFixedAngleTurntable(FlatBufferBuilder builder)
		{
			return new Offset<IFixedAngleTurntable>(builder.EndTable());
		}

		// Token: 0x06022524 RID: 140580 RVA: 0x004C2000 File Offset: 0x004C0200
		public IFixedAngleTurntableT UnPack()
		{
			IFixedAngleTurntableT fixedAngleTurntableT = new IFixedAngleTurntableT();
			this.UnPackTo(fixedAngleTurntableT);
			return fixedAngleTurntableT;
		}

		// Token: 0x06022525 RID: 140581 RVA: 0x004C201C File Offset: 0x004C021C
		public void UnPackTo(IFixedAngleTurntableT _o)
		{
			_o.Type = this.Type;
			_o.RotationSpeed = this.RotationSpeed;
			_o.ItemConfig = new List<IFixedAngleItemT>();
			for (int i = 0; i < this.ItemConfigLength; i++)
			{
				_o.ItemConfig.Add((this.ItemConfig(i) != null) ? this.ItemConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06022526 RID: 140582 RVA: 0x004C2094 File Offset: 0x004C0294
		public static Offset<IFixedAngleTurntable> Pack(FlatBufferBuilder builder, IFixedAngleTurntableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedAngleTurntable>);
			}
			VectorOffset itemConfigOffset = default(VectorOffset);
			if (_o.ItemConfig != null)
			{
				Offset<IFixedAngleItem>[] array = new Offset<IFixedAngleItem>[_o.ItemConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFixedAngleItem.Pack(builder, _o.ItemConfig[i]);
				}
				itemConfigOffset = IFixedAngleTurntable.CreateItemConfigVector(builder, array);
			}
			return IFixedAngleTurntable.CreateIFixedAngleTurntable(builder, _o.Type, _o.RotationSpeed, itemConfigOffset);
		}

		// Token: 0x0400E3B8 RID: 58296
		private Table __p;
	}
}

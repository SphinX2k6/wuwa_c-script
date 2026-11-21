using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057CF RID: 22479
	public struct IFixedAngleTurntable : IFlatbufferObject
	{
		// Token: 0x1700A27B RID: 41595
		// (get) Token: 0x060244A5 RID: 148645 RVA: 0x004FC854 File Offset: 0x004FAA54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060244A6 RID: 148646 RVA: 0x004FC861 File Offset: 0x004FAA61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060244A7 RID: 148647 RVA: 0x004FC868 File Offset: 0x004FAA68
		public static IFixedAngleTurntable GetRootAsIFixedAngleTurntable(ByteBuffer _bb)
		{
			return IFixedAngleTurntable.GetRootAsIFixedAngleTurntable(_bb, default(IFixedAngleTurntable));
		}

		// Token: 0x060244A8 RID: 148648 RVA: 0x004FC884 File Offset: 0x004FAA84
		public static IFixedAngleTurntable GetRootAsIFixedAngleTurntable(ByteBuffer _bb, IFixedAngleTurntable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060244A9 RID: 148649 RVA: 0x004FC8A1 File Offset: 0x004FAAA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060244AA RID: 148650 RVA: 0x004FC8B0 File Offset: 0x004FAAB0
		public IFixedAngleTurntable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A27C RID: 41596
		// (get) Token: 0x060244AB RID: 148651 RVA: 0x004FC8C0 File Offset: 0x004FAAC0
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

		// Token: 0x1700A27D RID: 41597
		// (get) Token: 0x060244AC RID: 148652 RVA: 0x004FC8FC File Offset: 0x004FAAFC
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

		// Token: 0x060244AD RID: 148653 RVA: 0x004FC938 File Offset: 0x004FAB38
		public IFixedAngleItem? ItemConfig(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IFixedAngleItem?(default(IFixedAngleItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A27E RID: 41598
		// (get) Token: 0x060244AE RID: 148654 RVA: 0x004FC998 File Offset: 0x004FAB98
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

		// Token: 0x060244AF RID: 148655 RVA: 0x004FC9C3 File Offset: 0x004FABC3
		public static Offset<IFixedAngleTurntable> CreateIFixedAngleTurntable(FlatBufferBuilder builder, EControllerType Type = EControllerType.FreeAngle, int RotationSpeed = 0, VectorOffset ItemConfigOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IFixedAngleTurntable.AddItemConfig(builder, ItemConfigOffset);
			IFixedAngleTurntable.AddRotationSpeed(builder, RotationSpeed);
			IFixedAngleTurntable.AddType(builder, Type);
			return IFixedAngleTurntable.EndIFixedAngleTurntable(builder);
		}

		// Token: 0x060244B0 RID: 148656 RVA: 0x004FC9E7 File Offset: 0x004FABE7
		public static void StartIFixedAngleTurntable(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060244B1 RID: 148657 RVA: 0x004FC9F0 File Offset: 0x004FABF0
		public static void AddType(FlatBufferBuilder builder, EControllerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060244B2 RID: 148658 RVA: 0x004FC9FB File Offset: 0x004FABFB
		public static void AddRotationSpeed(FlatBufferBuilder builder, int rotationSpeed)
		{
			builder.AddInt(1, rotationSpeed, 0);
		}

		// Token: 0x060244B3 RID: 148659 RVA: 0x004FCA06 File Offset: 0x004FAC06
		public static void AddItemConfig(FlatBufferBuilder builder, VectorOffset itemConfigOffset)
		{
			builder.AddOffset(2, itemConfigOffset.Value, 0);
		}

		// Token: 0x060244B4 RID: 148660 RVA: 0x004FCA18 File Offset: 0x004FAC18
		public static VectorOffset CreateItemConfigVector(FlatBufferBuilder builder, Offset<IFixedAngleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060244B5 RID: 148661 RVA: 0x004FCA58 File Offset: 0x004FAC58
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, Offset<IFixedAngleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFixedAngleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x060244B6 RID: 148662 RVA: 0x004FCA72 File Offset: 0x004FAC72
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFixedAngleItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFixedAngleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x060244B7 RID: 148663 RVA: 0x004FCA90 File Offset: 0x004FAC90
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFixedAngleItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060244B8 RID: 148664 RVA: 0x004FCAA9 File Offset: 0x004FACA9
		public static void StartItemConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060244B9 RID: 148665 RVA: 0x004FCAB4 File Offset: 0x004FACB4
		public static Offset<IFixedAngleTurntable> EndIFixedAngleTurntable(FlatBufferBuilder builder)
		{
			return new Offset<IFixedAngleTurntable>(builder.EndTable());
		}

		// Token: 0x060244BA RID: 148666 RVA: 0x004FCAC4 File Offset: 0x004FACC4
		public IFixedAngleTurntableT UnPack()
		{
			IFixedAngleTurntableT fixedAngleTurntableT = new IFixedAngleTurntableT();
			this.UnPackTo(fixedAngleTurntableT);
			return fixedAngleTurntableT;
		}

		// Token: 0x060244BB RID: 148667 RVA: 0x004FCAE0 File Offset: 0x004FACE0
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

		// Token: 0x060244BC RID: 148668 RVA: 0x004FCB58 File Offset: 0x004FAD58
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

		// Token: 0x0400EFBE RID: 61374
		private Table __p;
	}
}

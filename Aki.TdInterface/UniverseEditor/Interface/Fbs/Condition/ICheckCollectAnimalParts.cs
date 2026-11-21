using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E5A RID: 20058
	public struct ICheckCollectAnimalParts : IFlatbufferObject
	{
		// Token: 0x17008EF6 RID: 36598
		// (get) Token: 0x0601F0AF RID: 127151 RVA: 0x0045544F File Offset: 0x0045364F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F0B0 RID: 127152 RVA: 0x0045545C File Offset: 0x0045365C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F0B1 RID: 127153 RVA: 0x00455464 File Offset: 0x00453664
		public static ICheckCollectAnimalParts GetRootAsICheckCollectAnimalParts(ByteBuffer _bb)
		{
			return ICheckCollectAnimalParts.GetRootAsICheckCollectAnimalParts(_bb, default(ICheckCollectAnimalParts));
		}

		// Token: 0x0601F0B2 RID: 127154 RVA: 0x00455480 File Offset: 0x00453680
		public static ICheckCollectAnimalParts GetRootAsICheckCollectAnimalParts(ByteBuffer _bb, ICheckCollectAnimalParts obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F0B3 RID: 127155 RVA: 0x0045549D File Offset: 0x0045369D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F0B4 RID: 127156 RVA: 0x004554AC File Offset: 0x004536AC
		public ICheckCollectAnimalParts __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EF7 RID: 36599
		// (get) Token: 0x0601F0B5 RID: 127157 RVA: 0x004554BC File Offset: 0x004536BC
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EF8 RID: 36600
		// (get) Token: 0x0601F0B6 RID: 127158 RVA: 0x004554F8 File Offset: 0x004536F8
		public int TargetAnimal
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

		// Token: 0x17008EF9 RID: 36601
		// (get) Token: 0x0601F0B7 RID: 127159 RVA: 0x00455534 File Offset: 0x00453734
		public ECheckEntityPerformanceAttributeType CheckType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECheckEntityPerformanceAttributeType.MatchAll;
				}
				return (ECheckEntityPerformanceAttributeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F0B8 RID: 127160 RVA: 0x00455570 File Offset: 0x00453770
		public ECollectAnimalPartSlot Slots(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return ECollectAnimalPartSlot.Slot0;
			}
			return (ECollectAnimalPartSlot)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008EFA RID: 36602
		// (get) Token: 0x0601F0B9 RID: 127161 RVA: 0x004555B0 File Offset: 0x004537B0
		public int SlotsLength
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

		// Token: 0x0601F0BA RID: 127162 RVA: 0x004555DC File Offset: 0x004537DC
		public Span<ECollectAnimalPartSlot> GetSlotsBytes()
		{
			return this.__p.__vector_as_span<ECollectAnimalPartSlot>(10, 1);
		}

		// Token: 0x0601F0BB RID: 127163 RVA: 0x004555EC File Offset: 0x004537EC
		public ECollectAnimalPartSlot[] GetSlotsArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			ECollectAnimalPartSlot[] array = new ECollectAnimalPartSlot[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (ECollectAnimalPartSlot)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x17008EFB RID: 36603
		// (get) Token: 0x0601F0BC RID: 127164 RVA: 0x00455658 File Offset: 0x00453858
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

		// Token: 0x0601F0BD RID: 127165 RVA: 0x00455695 File Offset: 0x00453895
		public static Offset<ICheckCollectAnimalParts> CreateICheckCollectAnimalParts(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int TargetAnimal = 0, ECheckEntityPerformanceAttributeType CheckType = ECheckEntityPerformanceAttributeType.MatchAll, VectorOffset SlotsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ICheckCollectAnimalParts.AddSlots(builder, SlotsOffset);
			ICheckCollectAnimalParts.AddTargetAnimal(builder, TargetAnimal);
			ICheckCollectAnimalParts.AddNullMask(builder, NullMask);
			ICheckCollectAnimalParts.AddCheckType(builder, CheckType);
			ICheckCollectAnimalParts.AddType(builder, Type);
			return ICheckCollectAnimalParts.EndICheckCollectAnimalParts(builder);
		}

		// Token: 0x0601F0BE RID: 127166 RVA: 0x004556C9 File Offset: 0x004538C9
		public static void StartICheckCollectAnimalParts(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F0BF RID: 127167 RVA: 0x004556D2 File Offset: 0x004538D2
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F0C0 RID: 127168 RVA: 0x004556DD File Offset: 0x004538DD
		public static void AddTargetAnimal(FlatBufferBuilder builder, int targetAnimal)
		{
			builder.AddInt(1, targetAnimal, 0);
		}

		// Token: 0x0601F0C1 RID: 127169 RVA: 0x004556E8 File Offset: 0x004538E8
		public static void AddCheckType(FlatBufferBuilder builder, ECheckEntityPerformanceAttributeType checkType)
		{
			builder.AddByte(2, (byte)checkType, 0);
		}

		// Token: 0x0601F0C2 RID: 127170 RVA: 0x004556F3 File Offset: 0x004538F3
		public static void AddSlots(FlatBufferBuilder builder, VectorOffset slotsOffset)
		{
			builder.AddOffset(3, slotsOffset.Value, 0);
		}

		// Token: 0x0601F0C3 RID: 127171 RVA: 0x00455704 File Offset: 0x00453904
		public static VectorOffset CreateSlotsVector(FlatBufferBuilder builder, ECollectAnimalPartSlot[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F0C4 RID: 127172 RVA: 0x0045573B File Offset: 0x0045393B
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, ECollectAnimalPartSlot[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ECollectAnimalPartSlot>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F0C5 RID: 127173 RVA: 0x00455755 File Offset: 0x00453955
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, ArraySegment<ECollectAnimalPartSlot> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ECollectAnimalPartSlot>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F0C6 RID: 127174 RVA: 0x00455773 File Offset: 0x00453973
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ECollectAnimalPartSlot>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F0C7 RID: 127175 RVA: 0x0045578C File Offset: 0x0045398C
		public static void StartSlotsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601F0C8 RID: 127176 RVA: 0x00455797 File Offset: 0x00453997
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601F0C9 RID: 127177 RVA: 0x004557A2 File Offset: 0x004539A2
		public static Offset<ICheckCollectAnimalParts> EndICheckCollectAnimalParts(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCollectAnimalParts>(builder.EndTable());
		}

		// Token: 0x0601F0CA RID: 127178 RVA: 0x004557B0 File Offset: 0x004539B0
		public ICheckCollectAnimalPartsT UnPack()
		{
			ICheckCollectAnimalPartsT checkCollectAnimalPartsT = new ICheckCollectAnimalPartsT();
			this.UnPackTo(checkCollectAnimalPartsT);
			return checkCollectAnimalPartsT;
		}

		// Token: 0x0601F0CB RID: 127179 RVA: 0x004557CC File Offset: 0x004539CC
		public void UnPackTo(ICheckCollectAnimalPartsT _o)
		{
			_o.Type = this.Type;
			_o.TargetAnimal = this.TargetAnimal;
			_o.CheckType = this.CheckType;
			_o.Slots = new List<ECollectAnimalPartSlot>();
			for (int i = 0; i < this.SlotsLength; i++)
			{
				_o.Slots.Add(this.Slots(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F0CC RID: 127180 RVA: 0x00455838 File Offset: 0x00453A38
		public static Offset<ICheckCollectAnimalParts> Pack(FlatBufferBuilder builder, ICheckCollectAnimalPartsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCollectAnimalParts>);
			}
			VectorOffset slotsOffset = default(VectorOffset);
			if (_o.Slots != null)
			{
				ECollectAnimalPartSlot[] data = _o.Slots.ToArray();
				slotsOffset = ICheckCollectAnimalParts.CreateSlotsVector(builder, data);
			}
			return ICheckCollectAnimalParts.CreateICheckCollectAnimalParts(builder, _o.Type, _o.TargetAnimal, _o.CheckType, slotsOffset, _o.NullMask);
		}

		// Token: 0x0400DC84 RID: 56452
		private Table __p;
	}
}

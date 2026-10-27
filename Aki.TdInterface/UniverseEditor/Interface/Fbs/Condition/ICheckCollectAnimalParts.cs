using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049A3 RID: 18851
	public struct ICheckCollectAnimalParts : IFlatbufferObject
	{
		// Token: 0x1700883B RID: 34875
		// (get) Token: 0x0601D68A RID: 120458 RVA: 0x00424F9B File Offset: 0x0042319B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D68B RID: 120459 RVA: 0x00424FA8 File Offset: 0x004231A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D68C RID: 120460 RVA: 0x00424FB0 File Offset: 0x004231B0
		public static ICheckCollectAnimalParts GetRootAsICheckCollectAnimalParts(ByteBuffer _bb)
		{
			return ICheckCollectAnimalParts.GetRootAsICheckCollectAnimalParts(_bb, default(ICheckCollectAnimalParts));
		}

		// Token: 0x0601D68D RID: 120461 RVA: 0x00424FCC File Offset: 0x004231CC
		public static ICheckCollectAnimalParts GetRootAsICheckCollectAnimalParts(ByteBuffer _bb, ICheckCollectAnimalParts obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D68E RID: 120462 RVA: 0x00424FE9 File Offset: 0x004231E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D68F RID: 120463 RVA: 0x00424FF8 File Offset: 0x004231F8
		public ICheckCollectAnimalParts __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700883C RID: 34876
		// (get) Token: 0x0601D690 RID: 120464 RVA: 0x00425008 File Offset: 0x00423208
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

		// Token: 0x1700883D RID: 34877
		// (get) Token: 0x0601D691 RID: 120465 RVA: 0x00425044 File Offset: 0x00423244
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

		// Token: 0x1700883E RID: 34878
		// (get) Token: 0x0601D692 RID: 120466 RVA: 0x00425080 File Offset: 0x00423280
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

		// Token: 0x0601D693 RID: 120467 RVA: 0x004250BC File Offset: 0x004232BC
		public ECollectAnimalPartSlot Slots(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return ECollectAnimalPartSlot.Slot0;
			}
			return (ECollectAnimalPartSlot)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700883F RID: 34879
		// (get) Token: 0x0601D694 RID: 120468 RVA: 0x004250FC File Offset: 0x004232FC
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

		// Token: 0x0601D695 RID: 120469 RVA: 0x00425128 File Offset: 0x00423328
		public Span<ECollectAnimalPartSlot> GetSlotsBytes()
		{
			return this.__p.__vector_as_span<ECollectAnimalPartSlot>(10, 1);
		}

		// Token: 0x0601D696 RID: 120470 RVA: 0x00425138 File Offset: 0x00423338
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

		// Token: 0x17008840 RID: 34880
		// (get) Token: 0x0601D697 RID: 120471 RVA: 0x004251A4 File Offset: 0x004233A4
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

		// Token: 0x0601D698 RID: 120472 RVA: 0x004251E1 File Offset: 0x004233E1
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

		// Token: 0x0601D699 RID: 120473 RVA: 0x00425215 File Offset: 0x00423415
		public static void StartICheckCollectAnimalParts(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601D69A RID: 120474 RVA: 0x0042521E File Offset: 0x0042341E
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D69B RID: 120475 RVA: 0x00425229 File Offset: 0x00423429
		public static void AddTargetAnimal(FlatBufferBuilder builder, int targetAnimal)
		{
			builder.AddInt(1, targetAnimal, 0);
		}

		// Token: 0x0601D69C RID: 120476 RVA: 0x00425234 File Offset: 0x00423434
		public static void AddCheckType(FlatBufferBuilder builder, ECheckEntityPerformanceAttributeType checkType)
		{
			builder.AddByte(2, (byte)checkType, 0);
		}

		// Token: 0x0601D69D RID: 120477 RVA: 0x0042523F File Offset: 0x0042343F
		public static void AddSlots(FlatBufferBuilder builder, VectorOffset slotsOffset)
		{
			builder.AddOffset(3, slotsOffset.Value, 0);
		}

		// Token: 0x0601D69E RID: 120478 RVA: 0x00425250 File Offset: 0x00423450
		public static VectorOffset CreateSlotsVector(FlatBufferBuilder builder, ECollectAnimalPartSlot[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D69F RID: 120479 RVA: 0x00425287 File Offset: 0x00423487
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, ECollectAnimalPartSlot[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ECollectAnimalPartSlot>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D6A0 RID: 120480 RVA: 0x004252A1 File Offset: 0x004234A1
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, ArraySegment<ECollectAnimalPartSlot> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ECollectAnimalPartSlot>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D6A1 RID: 120481 RVA: 0x004252BF File Offset: 0x004234BF
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ECollectAnimalPartSlot>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D6A2 RID: 120482 RVA: 0x004252D8 File Offset: 0x004234D8
		public static void StartSlotsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601D6A3 RID: 120483 RVA: 0x004252E3 File Offset: 0x004234E3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601D6A4 RID: 120484 RVA: 0x004252EE File Offset: 0x004234EE
		public static Offset<ICheckCollectAnimalParts> EndICheckCollectAnimalParts(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCollectAnimalParts>(builder.EndTable());
		}

		// Token: 0x0601D6A5 RID: 120485 RVA: 0x004252FC File Offset: 0x004234FC
		public ICheckCollectAnimalPartsT UnPack()
		{
			ICheckCollectAnimalPartsT checkCollectAnimalPartsT = new ICheckCollectAnimalPartsT();
			this.UnPackTo(checkCollectAnimalPartsT);
			return checkCollectAnimalPartsT;
		}

		// Token: 0x0601D6A6 RID: 120486 RVA: 0x00425318 File Offset: 0x00423518
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

		// Token: 0x0601D6A7 RID: 120487 RVA: 0x00425384 File Offset: 0x00423584
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

		// Token: 0x0400D1BC RID: 53692
		private Table __p;
	}
}

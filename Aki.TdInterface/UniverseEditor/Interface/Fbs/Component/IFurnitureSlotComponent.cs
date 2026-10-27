using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052DF RID: 21215
	public struct IFurnitureSlotComponent : IFlatbufferObject
	{
		// Token: 0x17009BB5 RID: 39861
		// (get) Token: 0x06022A0F RID: 141839 RVA: 0x004CCCF7 File Offset: 0x004CAEF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022A10 RID: 141840 RVA: 0x004CCD04 File Offset: 0x004CAF04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022A11 RID: 141841 RVA: 0x004CCD0C File Offset: 0x004CAF0C
		public static IFurnitureSlotComponent GetRootAsIFurnitureSlotComponent(ByteBuffer _bb)
		{
			return IFurnitureSlotComponent.GetRootAsIFurnitureSlotComponent(_bb, default(IFurnitureSlotComponent));
		}

		// Token: 0x06022A12 RID: 141842 RVA: 0x004CCD28 File Offset: 0x004CAF28
		public static IFurnitureSlotComponent GetRootAsIFurnitureSlotComponent(ByteBuffer _bb, IFurnitureSlotComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022A13 RID: 141843 RVA: 0x004CCD45 File Offset: 0x004CAF45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022A14 RID: 141844 RVA: 0x004CCD54 File Offset: 0x004CAF54
		public IFurnitureSlotComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BB6 RID: 39862
		// (get) Token: 0x06022A15 RID: 141845 RVA: 0x004CCD64 File Offset: 0x004CAF64
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022A16 RID: 141846 RVA: 0x004CCDA4 File Offset: 0x004CAFA4
		public IFurnitureSlot? Slots(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFurnitureSlot?(default(IFurnitureSlot).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009BB7 RID: 39863
		// (get) Token: 0x06022A17 RID: 141847 RVA: 0x004CCE04 File Offset: 0x004CB004
		public int SlotsLength
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

		// Token: 0x17009BB8 RID: 39864
		// (get) Token: 0x06022A18 RID: 141848 RVA: 0x004CCE30 File Offset: 0x004CB030
		public IFurnitureCamera? FurnitureCamera
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFurnitureCamera?(default(IFurnitureCamera).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009BB9 RID: 39865
		// (get) Token: 0x06022A19 RID: 141849 RVA: 0x004CCE90 File Offset: 0x004CB090
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022A1A RID: 141850 RVA: 0x004CCECD File Offset: 0x004CB0CD
		public static Offset<IFurnitureSlotComponent> CreateIFurnitureSlotComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset SlotsOffset = default(VectorOffset), Offset<IFurnitureCamera> FurnitureCameraOffset = default(Offset<IFurnitureCamera>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IFurnitureSlotComponent.AddFurnitureCamera(builder, FurnitureCameraOffset);
			IFurnitureSlotComponent.AddSlots(builder, SlotsOffset);
			IFurnitureSlotComponent.AddNullMask(builder, NullMask);
			IFurnitureSlotComponent.AddDisabled(builder, Disabled);
			return IFurnitureSlotComponent.EndIFurnitureSlotComponent(builder);
		}

		// Token: 0x06022A1B RID: 141851 RVA: 0x004CCEF9 File Offset: 0x004CB0F9
		public static void StartIFurnitureSlotComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022A1C RID: 141852 RVA: 0x004CCF02 File Offset: 0x004CB102
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022A1D RID: 141853 RVA: 0x004CCF0D File Offset: 0x004CB10D
		public static void AddSlots(FlatBufferBuilder builder, VectorOffset slotsOffset)
		{
			builder.AddOffset(1, slotsOffset.Value, 0);
		}

		// Token: 0x06022A1E RID: 141854 RVA: 0x004CCF20 File Offset: 0x004CB120
		public static VectorOffset CreateSlotsVector(FlatBufferBuilder builder, Offset<IFurnitureSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022A1F RID: 141855 RVA: 0x004CCF60 File Offset: 0x004CB160
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, Offset<IFurnitureSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFurnitureSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022A20 RID: 141856 RVA: 0x004CCF7A File Offset: 0x004CB17A
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFurnitureSlot>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFurnitureSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022A21 RID: 141857 RVA: 0x004CCF98 File Offset: 0x004CB198
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFurnitureSlot>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022A22 RID: 141858 RVA: 0x004CCFB1 File Offset: 0x004CB1B1
		public static void StartSlotsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022A23 RID: 141859 RVA: 0x004CCFBC File Offset: 0x004CB1BC
		public static void AddFurnitureCamera(FlatBufferBuilder builder, Offset<IFurnitureCamera> furnitureCameraOffset)
		{
			builder.AddOffset(2, furnitureCameraOffset.Value, 0);
		}

		// Token: 0x06022A24 RID: 141860 RVA: 0x004CCFCC File Offset: 0x004CB1CC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06022A25 RID: 141861 RVA: 0x004CCFD7 File Offset: 0x004CB1D7
		public static Offset<IFurnitureSlotComponent> EndIFurnitureSlotComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFurnitureSlotComponent>(builder.EndTable());
		}

		// Token: 0x06022A26 RID: 141862 RVA: 0x004CCFE4 File Offset: 0x004CB1E4
		public IFurnitureSlotComponentT UnPack()
		{
			IFurnitureSlotComponentT furnitureSlotComponentT = new IFurnitureSlotComponentT();
			this.UnPackTo(furnitureSlotComponentT);
			return furnitureSlotComponentT;
		}

		// Token: 0x06022A27 RID: 141863 RVA: 0x004CD000 File Offset: 0x004CB200
		public void UnPackTo(IFurnitureSlotComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Slots = new List<IFurnitureSlotT>();
			for (int i = 0; i < this.SlotsLength; i++)
			{
				_o.Slots.Add((this.Slots(i) != null) ? this.Slots(i).Value.UnPack() : null);
			}
			_o.FurnitureCamera = ((this.FurnitureCamera != null) ? this.FurnitureCamera.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022A28 RID: 141864 RVA: 0x004CD0A8 File Offset: 0x004CB2A8
		public static Offset<IFurnitureSlotComponent> Pack(FlatBufferBuilder builder, IFurnitureSlotComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFurnitureSlotComponent>);
			}
			VectorOffset slotsOffset = default(VectorOffset);
			if (_o.Slots != null)
			{
				Offset<IFurnitureSlot>[] array = new Offset<IFurnitureSlot>[_o.Slots.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFurnitureSlot.Pack(builder, _o.Slots[i]);
				}
				slotsOffset = IFurnitureSlotComponent.CreateSlotsVector(builder, array);
			}
			Offset<IFurnitureCamera> furnitureCameraOffset = (_o.FurnitureCamera == null) ? default(Offset<IFurnitureCamera>) : IFurnitureCamera.Pack(builder, _o.FurnitureCamera);
			return IFurnitureSlotComponent.CreateIFurnitureSlotComponent(builder, _o.Disabled, slotsOffset, furnitureCameraOffset, _o.NullMask);
		}

		// Token: 0x0400E47C RID: 58492
		private Table __p;
	}
}

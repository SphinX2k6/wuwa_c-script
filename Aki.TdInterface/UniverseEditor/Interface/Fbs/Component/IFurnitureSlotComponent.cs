using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005862 RID: 22626
	public struct IFurnitureSlotComponent : IFlatbufferObject
	{
		// Token: 0x1700A3E6 RID: 41958
		// (get) Token: 0x06024AA9 RID: 150185 RVA: 0x00509823 File Offset: 0x00507A23
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024AAA RID: 150186 RVA: 0x00509830 File Offset: 0x00507A30
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024AAB RID: 150187 RVA: 0x00509838 File Offset: 0x00507A38
		public static IFurnitureSlotComponent GetRootAsIFurnitureSlotComponent(ByteBuffer _bb)
		{
			return IFurnitureSlotComponent.GetRootAsIFurnitureSlotComponent(_bb, default(IFurnitureSlotComponent));
		}

		// Token: 0x06024AAC RID: 150188 RVA: 0x00509854 File Offset: 0x00507A54
		public static IFurnitureSlotComponent GetRootAsIFurnitureSlotComponent(ByteBuffer _bb, IFurnitureSlotComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024AAD RID: 150189 RVA: 0x00509871 File Offset: 0x00507A71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024AAE RID: 150190 RVA: 0x00509880 File Offset: 0x00507A80
		public IFurnitureSlotComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3E7 RID: 41959
		// (get) Token: 0x06024AAF RID: 150191 RVA: 0x00509890 File Offset: 0x00507A90
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06024AB0 RID: 150192 RVA: 0x005098D0 File Offset: 0x00507AD0
		public IFurnitureSlot? Slots(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFurnitureSlot?(default(IFurnitureSlot).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A3E8 RID: 41960
		// (get) Token: 0x06024AB1 RID: 150193 RVA: 0x00509930 File Offset: 0x00507B30
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

		// Token: 0x1700A3E9 RID: 41961
		// (get) Token: 0x06024AB2 RID: 150194 RVA: 0x0050995C File Offset: 0x00507B5C
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

		// Token: 0x1700A3EA RID: 41962
		// (get) Token: 0x06024AB3 RID: 150195 RVA: 0x005099BC File Offset: 0x00507BBC
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

		// Token: 0x06024AB4 RID: 150196 RVA: 0x005099F9 File Offset: 0x00507BF9
		public static Offset<IFurnitureSlotComponent> CreateIFurnitureSlotComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset SlotsOffset = default(VectorOffset), Offset<IFurnitureCamera> FurnitureCameraOffset = default(Offset<IFurnitureCamera>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IFurnitureSlotComponent.AddFurnitureCamera(builder, FurnitureCameraOffset);
			IFurnitureSlotComponent.AddSlots(builder, SlotsOffset);
			IFurnitureSlotComponent.AddNullMask(builder, NullMask);
			IFurnitureSlotComponent.AddDisabled(builder, Disabled);
			return IFurnitureSlotComponent.EndIFurnitureSlotComponent(builder);
		}

		// Token: 0x06024AB5 RID: 150197 RVA: 0x00509A25 File Offset: 0x00507C25
		public static void StartIFurnitureSlotComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06024AB6 RID: 150198 RVA: 0x00509A2E File Offset: 0x00507C2E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024AB7 RID: 150199 RVA: 0x00509A39 File Offset: 0x00507C39
		public static void AddSlots(FlatBufferBuilder builder, VectorOffset slotsOffset)
		{
			builder.AddOffset(1, slotsOffset.Value, 0);
		}

		// Token: 0x06024AB8 RID: 150200 RVA: 0x00509A4C File Offset: 0x00507C4C
		public static VectorOffset CreateSlotsVector(FlatBufferBuilder builder, Offset<IFurnitureSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024AB9 RID: 150201 RVA: 0x00509A8C File Offset: 0x00507C8C
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, Offset<IFurnitureSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFurnitureSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024ABA RID: 150202 RVA: 0x00509AA6 File Offset: 0x00507CA6
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFurnitureSlot>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFurnitureSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024ABB RID: 150203 RVA: 0x00509AC4 File Offset: 0x00507CC4
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFurnitureSlot>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024ABC RID: 150204 RVA: 0x00509ADD File Offset: 0x00507CDD
		public static void StartSlotsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024ABD RID: 150205 RVA: 0x00509AE8 File Offset: 0x00507CE8
		public static void AddFurnitureCamera(FlatBufferBuilder builder, Offset<IFurnitureCamera> furnitureCameraOffset)
		{
			builder.AddOffset(2, furnitureCameraOffset.Value, 0);
		}

		// Token: 0x06024ABE RID: 150206 RVA: 0x00509AF8 File Offset: 0x00507CF8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06024ABF RID: 150207 RVA: 0x00509B03 File Offset: 0x00507D03
		public static Offset<IFurnitureSlotComponent> EndIFurnitureSlotComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFurnitureSlotComponent>(builder.EndTable());
		}

		// Token: 0x06024AC0 RID: 150208 RVA: 0x00509B10 File Offset: 0x00507D10
		public IFurnitureSlotComponentT UnPack()
		{
			IFurnitureSlotComponentT furnitureSlotComponentT = new IFurnitureSlotComponentT();
			this.UnPackTo(furnitureSlotComponentT);
			return furnitureSlotComponentT;
		}

		// Token: 0x06024AC1 RID: 150209 RVA: 0x00509B2C File Offset: 0x00507D2C
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

		// Token: 0x06024AC2 RID: 150210 RVA: 0x00509BD4 File Offset: 0x00507DD4
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

		// Token: 0x0400F0A8 RID: 61608
		private Table __p;
	}
}

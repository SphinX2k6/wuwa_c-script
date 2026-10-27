using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052DC RID: 21212
	public struct IFurnitureSlot : IFlatbufferObject
	{
		// Token: 0x17009BAA RID: 39850
		// (get) Token: 0x060229E5 RID: 141797 RVA: 0x004CC717 File Offset: 0x004CA917
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060229E6 RID: 141798 RVA: 0x004CC724 File Offset: 0x004CA924
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060229E7 RID: 141799 RVA: 0x004CC72C File Offset: 0x004CA92C
		public static IFurnitureSlot GetRootAsIFurnitureSlot(ByteBuffer _bb)
		{
			return IFurnitureSlot.GetRootAsIFurnitureSlot(_bb, default(IFurnitureSlot));
		}

		// Token: 0x060229E8 RID: 141800 RVA: 0x004CC748 File Offset: 0x004CA948
		public static IFurnitureSlot GetRootAsIFurnitureSlot(ByteBuffer _bb, IFurnitureSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060229E9 RID: 141801 RVA: 0x004CC765 File Offset: 0x004CA965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060229EA RID: 141802 RVA: 0x004CC774 File Offset: 0x004CA974
		public IFurnitureSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BAB RID: 39851
		// (get) Token: 0x060229EB RID: 141803 RVA: 0x004CC784 File Offset: 0x004CA984
		public IFurnitureCamera? SlotCamera
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IFurnitureCamera?(default(IFurnitureCamera).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009BAC RID: 39852
		// (get) Token: 0x060229EC RID: 141804 RVA: 0x004CC7E4 File Offset: 0x004CA9E4
		public ISlotShape? SlotShape
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISlotShape?(default(ISlotShape).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009BAD RID: 39853
		// (get) Token: 0x060229ED RID: 141805 RVA: 0x004CC844 File Offset: 0x004CAA44
		public int FurnitureTag
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060229EE RID: 141806 RVA: 0x004CC880 File Offset: 0x004CAA80
		public int ExcludedFurnitureIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009BAE RID: 39854
		// (get) Token: 0x060229EF RID: 141807 RVA: 0x004CC8C0 File Offset: 0x004CAAC0
		public int ExcludedFurnitureIdsLength
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

		// Token: 0x060229F0 RID: 141808 RVA: 0x004CC8EC File Offset: 0x004CAAEC
		public Span<int> GetExcludedFurnitureIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060229F1 RID: 141809 RVA: 0x004CC8FC File Offset: 0x004CAAFC
		public int[] GetExcludedFurnitureIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17009BAF RID: 39855
		// (get) Token: 0x060229F2 RID: 141810 RVA: 0x004CC90C File Offset: 0x004CAB0C
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

		// Token: 0x060229F3 RID: 141811 RVA: 0x004CC949 File Offset: 0x004CAB49
		public static Offset<IFurnitureSlot> CreateIFurnitureSlot(FlatBufferBuilder builder, Offset<IFurnitureCamera> SlotCameraOffset = default(Offset<IFurnitureCamera>), Offset<ISlotShape> SlotShapeOffset = default(Offset<ISlotShape>), int FurnitureTag = 0, VectorOffset ExcludedFurnitureIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IFurnitureSlot.AddExcludedFurnitureIds(builder, ExcludedFurnitureIdsOffset);
			IFurnitureSlot.AddFurnitureTag(builder, FurnitureTag);
			IFurnitureSlot.AddSlotShape(builder, SlotShapeOffset);
			IFurnitureSlot.AddSlotCamera(builder, SlotCameraOffset);
			IFurnitureSlot.AddNullMask(builder, NullMask);
			return IFurnitureSlot.EndIFurnitureSlot(builder);
		}

		// Token: 0x060229F4 RID: 141812 RVA: 0x004CC97D File Offset: 0x004CAB7D
		public static void StartIFurnitureSlot(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060229F5 RID: 141813 RVA: 0x004CC986 File Offset: 0x004CAB86
		public static void AddSlotCamera(FlatBufferBuilder builder, Offset<IFurnitureCamera> slotCameraOffset)
		{
			builder.AddOffset(0, slotCameraOffset.Value, 0);
		}

		// Token: 0x060229F6 RID: 141814 RVA: 0x004CC996 File Offset: 0x004CAB96
		public static void AddSlotShape(FlatBufferBuilder builder, Offset<ISlotShape> slotShapeOffset)
		{
			builder.AddOffset(1, slotShapeOffset.Value, 0);
		}

		// Token: 0x060229F7 RID: 141815 RVA: 0x004CC9A6 File Offset: 0x004CABA6
		public static void AddFurnitureTag(FlatBufferBuilder builder, int furnitureTag)
		{
			builder.AddInt(2, furnitureTag, 0);
		}

		// Token: 0x060229F8 RID: 141816 RVA: 0x004CC9B1 File Offset: 0x004CABB1
		public static void AddExcludedFurnitureIds(FlatBufferBuilder builder, VectorOffset excludedFurnitureIdsOffset)
		{
			builder.AddOffset(3, excludedFurnitureIdsOffset.Value, 0);
		}

		// Token: 0x060229F9 RID: 141817 RVA: 0x004CC9C4 File Offset: 0x004CABC4
		public static VectorOffset CreateExcludedFurnitureIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060229FA RID: 141818 RVA: 0x004CC9FB File Offset: 0x004CABFB
		public static VectorOffset CreateExcludedFurnitureIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060229FB RID: 141819 RVA: 0x004CCA15 File Offset: 0x004CAC15
		public static VectorOffset CreateExcludedFurnitureIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060229FC RID: 141820 RVA: 0x004CCA33 File Offset: 0x004CAC33
		public static VectorOffset CreateExcludedFurnitureIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060229FD RID: 141821 RVA: 0x004CCA4C File Offset: 0x004CAC4C
		public static void StartExcludedFurnitureIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060229FE RID: 141822 RVA: 0x004CCA57 File Offset: 0x004CAC57
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060229FF RID: 141823 RVA: 0x004CCA62 File Offset: 0x004CAC62
		public static Offset<IFurnitureSlot> EndIFurnitureSlot(FlatBufferBuilder builder)
		{
			return new Offset<IFurnitureSlot>(builder.EndTable());
		}

		// Token: 0x06022A00 RID: 141824 RVA: 0x004CCA70 File Offset: 0x004CAC70
		public IFurnitureSlotT UnPack()
		{
			IFurnitureSlotT furnitureSlotT = new IFurnitureSlotT();
			this.UnPackTo(furnitureSlotT);
			return furnitureSlotT;
		}

		// Token: 0x06022A01 RID: 141825 RVA: 0x004CCA8C File Offset: 0x004CAC8C
		public void UnPackTo(IFurnitureSlotT _o)
		{
			_o.SlotCamera = ((this.SlotCamera != null) ? this.SlotCamera.Value.UnPack() : null);
			_o.SlotShape = ((this.SlotShape != null) ? this.SlotShape.Value.UnPack() : null);
			_o.FurnitureTag = this.FurnitureTag;
			_o.ExcludedFurnitureIds = new List<int>();
			for (int i = 0; i < this.ExcludedFurnitureIdsLength; i++)
			{
				_o.ExcludedFurnitureIds.Add(this.ExcludedFurnitureIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022A02 RID: 141826 RVA: 0x004CCB44 File Offset: 0x004CAD44
		public static Offset<IFurnitureSlot> Pack(FlatBufferBuilder builder, IFurnitureSlotT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFurnitureSlot>);
			}
			Offset<IFurnitureCamera> slotCameraOffset = (_o.SlotCamera == null) ? default(Offset<IFurnitureCamera>) : IFurnitureCamera.Pack(builder, _o.SlotCamera);
			Offset<ISlotShape> slotShapeOffset = (_o.SlotShape == null) ? default(Offset<ISlotShape>) : ISlotShape.Pack(builder, _o.SlotShape);
			VectorOffset excludedFurnitureIdsOffset = default(VectorOffset);
			if (_o.ExcludedFurnitureIds != null)
			{
				int[] data = _o.ExcludedFurnitureIds.ToArray();
				excludedFurnitureIdsOffset = IFurnitureSlot.CreateExcludedFurnitureIdsVector(builder, data);
			}
			return IFurnitureSlot.CreateIFurnitureSlot(builder, slotCameraOffset, slotShapeOffset, _o.FurnitureTag, excludedFurnitureIdsOffset, _o.NullMask);
		}

		// Token: 0x0400E476 RID: 58486
		private Table __p;
	}
}

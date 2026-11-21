using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585F RID: 22623
	public struct IFurnitureSlot : IFlatbufferObject
	{
		// Token: 0x1700A3DB RID: 41947
		// (get) Token: 0x06024A7F RID: 150143 RVA: 0x00509243 File Offset: 0x00507443
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024A80 RID: 150144 RVA: 0x00509250 File Offset: 0x00507450
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024A81 RID: 150145 RVA: 0x00509258 File Offset: 0x00507458
		public static IFurnitureSlot GetRootAsIFurnitureSlot(ByteBuffer _bb)
		{
			return IFurnitureSlot.GetRootAsIFurnitureSlot(_bb, default(IFurnitureSlot));
		}

		// Token: 0x06024A82 RID: 150146 RVA: 0x00509274 File Offset: 0x00507474
		public static IFurnitureSlot GetRootAsIFurnitureSlot(ByteBuffer _bb, IFurnitureSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024A83 RID: 150147 RVA: 0x00509291 File Offset: 0x00507491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024A84 RID: 150148 RVA: 0x005092A0 File Offset: 0x005074A0
		public IFurnitureSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3DC RID: 41948
		// (get) Token: 0x06024A85 RID: 150149 RVA: 0x005092B0 File Offset: 0x005074B0
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

		// Token: 0x1700A3DD RID: 41949
		// (get) Token: 0x06024A86 RID: 150150 RVA: 0x00509310 File Offset: 0x00507510
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

		// Token: 0x1700A3DE RID: 41950
		// (get) Token: 0x06024A87 RID: 150151 RVA: 0x00509370 File Offset: 0x00507570
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

		// Token: 0x06024A88 RID: 150152 RVA: 0x005093AC File Offset: 0x005075AC
		public int ExcludedFurnitureIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A3DF RID: 41951
		// (get) Token: 0x06024A89 RID: 150153 RVA: 0x005093EC File Offset: 0x005075EC
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

		// Token: 0x06024A8A RID: 150154 RVA: 0x00509418 File Offset: 0x00507618
		public Span<int> GetExcludedFurnitureIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06024A8B RID: 150155 RVA: 0x00509428 File Offset: 0x00507628
		public int[] GetExcludedFurnitureIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700A3E0 RID: 41952
		// (get) Token: 0x06024A8C RID: 150156 RVA: 0x00509438 File Offset: 0x00507638
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

		// Token: 0x06024A8D RID: 150157 RVA: 0x00509475 File Offset: 0x00507675
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

		// Token: 0x06024A8E RID: 150158 RVA: 0x005094A9 File Offset: 0x005076A9
		public static void StartIFurnitureSlot(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024A8F RID: 150159 RVA: 0x005094B2 File Offset: 0x005076B2
		public static void AddSlotCamera(FlatBufferBuilder builder, Offset<IFurnitureCamera> slotCameraOffset)
		{
			builder.AddOffset(0, slotCameraOffset.Value, 0);
		}

		// Token: 0x06024A90 RID: 150160 RVA: 0x005094C2 File Offset: 0x005076C2
		public static void AddSlotShape(FlatBufferBuilder builder, Offset<ISlotShape> slotShapeOffset)
		{
			builder.AddOffset(1, slotShapeOffset.Value, 0);
		}

		// Token: 0x06024A91 RID: 150161 RVA: 0x005094D2 File Offset: 0x005076D2
		public static void AddFurnitureTag(FlatBufferBuilder builder, int furnitureTag)
		{
			builder.AddInt(2, furnitureTag, 0);
		}

		// Token: 0x06024A92 RID: 150162 RVA: 0x005094DD File Offset: 0x005076DD
		public static void AddExcludedFurnitureIds(FlatBufferBuilder builder, VectorOffset excludedFurnitureIdsOffset)
		{
			builder.AddOffset(3, excludedFurnitureIdsOffset.Value, 0);
		}

		// Token: 0x06024A93 RID: 150163 RVA: 0x005094F0 File Offset: 0x005076F0
		public static VectorOffset CreateExcludedFurnitureIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024A94 RID: 150164 RVA: 0x00509527 File Offset: 0x00507727
		public static VectorOffset CreateExcludedFurnitureIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A95 RID: 150165 RVA: 0x00509541 File Offset: 0x00507741
		public static VectorOffset CreateExcludedFurnitureIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024A96 RID: 150166 RVA: 0x0050955F File Offset: 0x0050775F
		public static VectorOffset CreateExcludedFurnitureIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024A97 RID: 150167 RVA: 0x00509578 File Offset: 0x00507778
		public static void StartExcludedFurnitureIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024A98 RID: 150168 RVA: 0x00509583 File Offset: 0x00507783
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06024A99 RID: 150169 RVA: 0x0050958E File Offset: 0x0050778E
		public static Offset<IFurnitureSlot> EndIFurnitureSlot(FlatBufferBuilder builder)
		{
			return new Offset<IFurnitureSlot>(builder.EndTable());
		}

		// Token: 0x06024A9A RID: 150170 RVA: 0x0050959C File Offset: 0x0050779C
		public IFurnitureSlotT UnPack()
		{
			IFurnitureSlotT furnitureSlotT = new IFurnitureSlotT();
			this.UnPackTo(furnitureSlotT);
			return furnitureSlotT;
		}

		// Token: 0x06024A9B RID: 150171 RVA: 0x005095B8 File Offset: 0x005077B8
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

		// Token: 0x06024A9C RID: 150172 RVA: 0x00509670 File Offset: 0x00507870
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

		// Token: 0x0400F0A2 RID: 61602
		private Table __p;
	}
}

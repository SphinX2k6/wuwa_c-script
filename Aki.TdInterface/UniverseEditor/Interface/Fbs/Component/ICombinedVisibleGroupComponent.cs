using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005526 RID: 21798
	public struct ICombinedVisibleGroupComponent : IFlatbufferObject
	{
		// Token: 0x17009BC8 RID: 39880
		// (get) Token: 0x0602274D RID: 141133 RVA: 0x004BF33C File Offset: 0x004BD53C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602274E RID: 141134 RVA: 0x004BF349 File Offset: 0x004BD549
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602274F RID: 141135 RVA: 0x004BF350 File Offset: 0x004BD550
		public static ICombinedVisibleGroupComponent GetRootAsICombinedVisibleGroupComponent(ByteBuffer _bb)
		{
			return ICombinedVisibleGroupComponent.GetRootAsICombinedVisibleGroupComponent(_bb, default(ICombinedVisibleGroupComponent));
		}

		// Token: 0x06022750 RID: 141136 RVA: 0x004BF36C File Offset: 0x004BD56C
		public static ICombinedVisibleGroupComponent GetRootAsICombinedVisibleGroupComponent(ByteBuffer _bb, ICombinedVisibleGroupComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022751 RID: 141137 RVA: 0x004BF389 File Offset: 0x004BD589
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022752 RID: 141138 RVA: 0x004BF398 File Offset: 0x004BD598
		public ICombinedVisibleGroupComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BC9 RID: 39881
		// (get) Token: 0x06022753 RID: 141139 RVA: 0x004BF3A8 File Offset: 0x004BD5A8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022754 RID: 141140 RVA: 0x004BF3E8 File Offset: 0x004BD5E8
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009BCA RID: 39882
		// (get) Token: 0x06022755 RID: 141141 RVA: 0x004BF428 File Offset: 0x004BD628
		public int AreaIdsLength
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

		// Token: 0x06022756 RID: 141142 RVA: 0x004BF453 File Offset: 0x004BD653
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06022757 RID: 141143 RVA: 0x004BF462 File Offset: 0x004BD662
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009BCB RID: 39883
		// (get) Token: 0x06022758 RID: 141144 RVA: 0x004BF470 File Offset: 0x004BD670
		public bool IncludeSubArea
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022759 RID: 141145 RVA: 0x004BF4B0 File Offset: 0x004BD6B0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009BCC RID: 39884
		// (get) Token: 0x0602275A RID: 141146 RVA: 0x004BF4F0 File Offset: 0x004BD6F0
		public int EntityIdsLength
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

		// Token: 0x0602275B RID: 141147 RVA: 0x004BF51C File Offset: 0x004BD71C
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602275C RID: 141148 RVA: 0x004BF52C File Offset: 0x004BD72C
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17009BCD RID: 39885
		// (get) Token: 0x0602275D RID: 141149 RVA: 0x004BF53C File Offset: 0x004BD73C
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

		// Token: 0x0602275E RID: 141150 RVA: 0x004BF579 File Offset: 0x004BD779
		public static Offset<ICombinedVisibleGroupComponent> CreateICombinedVisibleGroupComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset AreaIdsOffset = default(VectorOffset), bool IncludeSubArea = false, VectorOffset EntityIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ICombinedVisibleGroupComponent.AddEntityIds(builder, EntityIdsOffset);
			ICombinedVisibleGroupComponent.AddAreaIds(builder, AreaIdsOffset);
			ICombinedVisibleGroupComponent.AddNullMask(builder, NullMask);
			ICombinedVisibleGroupComponent.AddIncludeSubArea(builder, IncludeSubArea);
			ICombinedVisibleGroupComponent.AddDisabled(builder, Disabled);
			return ICombinedVisibleGroupComponent.EndICombinedVisibleGroupComponent(builder);
		}

		// Token: 0x0602275F RID: 141151 RVA: 0x004BF5AD File Offset: 0x004BD7AD
		public static void StartICombinedVisibleGroupComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06022760 RID: 141152 RVA: 0x004BF5B6 File Offset: 0x004BD7B6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022761 RID: 141153 RVA: 0x004BF5C1 File Offset: 0x004BD7C1
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(1, areaIdsOffset.Value, 0);
		}

		// Token: 0x06022762 RID: 141154 RVA: 0x004BF5D4 File Offset: 0x004BD7D4
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022763 RID: 141155 RVA: 0x004BF60B File Offset: 0x004BD80B
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022764 RID: 141156 RVA: 0x004BF625 File Offset: 0x004BD825
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022765 RID: 141157 RVA: 0x004BF643 File Offset: 0x004BD843
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022766 RID: 141158 RVA: 0x004BF65C File Offset: 0x004BD85C
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022767 RID: 141159 RVA: 0x004BF667 File Offset: 0x004BD867
		public static void AddIncludeSubArea(FlatBufferBuilder builder, bool includeSubArea)
		{
			builder.AddBool(2, includeSubArea, false);
		}

		// Token: 0x06022768 RID: 141160 RVA: 0x004BF672 File Offset: 0x004BD872
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x06022769 RID: 141161 RVA: 0x004BF684 File Offset: 0x004BD884
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602276A RID: 141162 RVA: 0x004BF6BB File Offset: 0x004BD8BB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602276B RID: 141163 RVA: 0x004BF6D5 File Offset: 0x004BD8D5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602276C RID: 141164 RVA: 0x004BF6F3 File Offset: 0x004BD8F3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602276D RID: 141165 RVA: 0x004BF70C File Offset: 0x004BD90C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602276E RID: 141166 RVA: 0x004BF717 File Offset: 0x004BD917
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602276F RID: 141167 RVA: 0x004BF722 File Offset: 0x004BD922
		public static Offset<ICombinedVisibleGroupComponent> EndICombinedVisibleGroupComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICombinedVisibleGroupComponent>(builder.EndTable());
		}

		// Token: 0x06022770 RID: 141168 RVA: 0x004BF730 File Offset: 0x004BD930
		public ICombinedVisibleGroupComponentT UnPack()
		{
			ICombinedVisibleGroupComponentT combinedVisibleGroupComponentT = new ICombinedVisibleGroupComponentT();
			this.UnPackTo(combinedVisibleGroupComponentT);
			return combinedVisibleGroupComponentT;
		}

		// Token: 0x06022771 RID: 141169 RVA: 0x004BF74C File Offset: 0x004BD94C
		public void UnPackTo(ICombinedVisibleGroupComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AreaIds = new List<int>();
			for (int i = 0; i < this.AreaIdsLength; i++)
			{
				_o.AreaIds.Add(this.AreaIds(i));
			}
			_o.IncludeSubArea = this.IncludeSubArea;
			_o.EntityIds = new List<int>();
			for (int j = 0; j < this.EntityIdsLength; j++)
			{
				_o.EntityIds.Add(this.EntityIds(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022772 RID: 141170 RVA: 0x004BF7DC File Offset: 0x004BD9DC
		public static Offset<ICombinedVisibleGroupComponent> Pack(FlatBufferBuilder builder, ICombinedVisibleGroupComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICombinedVisibleGroupComponent>);
			}
			VectorOffset areaIdsOffset = default(VectorOffset);
			if (_o.AreaIds != null)
			{
				int[] data = _o.AreaIds.ToArray();
				areaIdsOffset = ICombinedVisibleGroupComponent.CreateAreaIdsVector(builder, data);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data2 = _o.EntityIds.ToArray();
				entityIdsOffset = ICombinedVisibleGroupComponent.CreateEntityIdsVector(builder, data2);
			}
			return ICombinedVisibleGroupComponent.CreateICombinedVisibleGroupComponent(builder, _o.Disabled, areaIdsOffset, _o.IncludeSubArea, entityIdsOffset, _o.NullMask);
		}

		// Token: 0x0400EA98 RID: 60056
		private Table __p;
	}
}

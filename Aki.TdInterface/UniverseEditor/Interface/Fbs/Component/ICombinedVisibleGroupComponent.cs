using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FC7 RID: 20423
	public struct ICombinedVisibleGroupComponent : IFlatbufferObject
	{
		// Token: 0x170093E7 RID: 37863
		// (get) Token: 0x06020833 RID: 133171 RVA: 0x004859BE File Offset: 0x00483BBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020834 RID: 133172 RVA: 0x004859CB File Offset: 0x00483BCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020835 RID: 133173 RVA: 0x004859D4 File Offset: 0x00483BD4
		public static ICombinedVisibleGroupComponent GetRootAsICombinedVisibleGroupComponent(ByteBuffer _bb)
		{
			return ICombinedVisibleGroupComponent.GetRootAsICombinedVisibleGroupComponent(_bb, default(ICombinedVisibleGroupComponent));
		}

		// Token: 0x06020836 RID: 133174 RVA: 0x004859F0 File Offset: 0x00483BF0
		public static ICombinedVisibleGroupComponent GetRootAsICombinedVisibleGroupComponent(ByteBuffer _bb, ICombinedVisibleGroupComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020837 RID: 133175 RVA: 0x00485A0D File Offset: 0x00483C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020838 RID: 133176 RVA: 0x00485A1C File Offset: 0x00483C1C
		public ICombinedVisibleGroupComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093E8 RID: 37864
		// (get) Token: 0x06020839 RID: 133177 RVA: 0x00485A2C File Offset: 0x00483C2C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602083A RID: 133178 RVA: 0x00485A6C File Offset: 0x00483C6C
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170093E9 RID: 37865
		// (get) Token: 0x0602083B RID: 133179 RVA: 0x00485AAC File Offset: 0x00483CAC
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

		// Token: 0x0602083C RID: 133180 RVA: 0x00485AD7 File Offset: 0x00483CD7
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602083D RID: 133181 RVA: 0x00485AE6 File Offset: 0x00483CE6
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x170093EA RID: 37866
		// (get) Token: 0x0602083E RID: 133182 RVA: 0x00485AF4 File Offset: 0x00483CF4
		public bool IncludeSubArea
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602083F RID: 133183 RVA: 0x00485B34 File Offset: 0x00483D34
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170093EB RID: 37867
		// (get) Token: 0x06020840 RID: 133184 RVA: 0x00485B74 File Offset: 0x00483D74
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

		// Token: 0x06020841 RID: 133185 RVA: 0x00485BA0 File Offset: 0x00483DA0
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06020842 RID: 133186 RVA: 0x00485BB0 File Offset: 0x00483DB0
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x170093EC RID: 37868
		// (get) Token: 0x06020843 RID: 133187 RVA: 0x00485BC0 File Offset: 0x00483DC0
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

		// Token: 0x06020844 RID: 133188 RVA: 0x00485BFD File Offset: 0x00483DFD
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

		// Token: 0x06020845 RID: 133189 RVA: 0x00485C31 File Offset: 0x00483E31
		public static void StartICombinedVisibleGroupComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020846 RID: 133190 RVA: 0x00485C3A File Offset: 0x00483E3A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06020847 RID: 133191 RVA: 0x00485C45 File Offset: 0x00483E45
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(1, areaIdsOffset.Value, 0);
		}

		// Token: 0x06020848 RID: 133192 RVA: 0x00485C58 File Offset: 0x00483E58
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06020849 RID: 133193 RVA: 0x00485C8F File Offset: 0x00483E8F
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602084A RID: 133194 RVA: 0x00485CA9 File Offset: 0x00483EA9
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602084B RID: 133195 RVA: 0x00485CC7 File Offset: 0x00483EC7
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602084C RID: 133196 RVA: 0x00485CE0 File Offset: 0x00483EE0
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602084D RID: 133197 RVA: 0x00485CEB File Offset: 0x00483EEB
		public static void AddIncludeSubArea(FlatBufferBuilder builder, bool includeSubArea)
		{
			builder.AddBool(2, includeSubArea, false);
		}

		// Token: 0x0602084E RID: 133198 RVA: 0x00485CF6 File Offset: 0x00483EF6
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602084F RID: 133199 RVA: 0x00485D08 File Offset: 0x00483F08
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06020850 RID: 133200 RVA: 0x00485D3F File Offset: 0x00483F3F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020851 RID: 133201 RVA: 0x00485D59 File Offset: 0x00483F59
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020852 RID: 133202 RVA: 0x00485D77 File Offset: 0x00483F77
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020853 RID: 133203 RVA: 0x00485D90 File Offset: 0x00483F90
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020854 RID: 133204 RVA: 0x00485D9B File Offset: 0x00483F9B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06020855 RID: 133205 RVA: 0x00485DA6 File Offset: 0x00483FA6
		public static Offset<ICombinedVisibleGroupComponent> EndICombinedVisibleGroupComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICombinedVisibleGroupComponent>(builder.EndTable());
		}

		// Token: 0x06020856 RID: 133206 RVA: 0x00485DB4 File Offset: 0x00483FB4
		public ICombinedVisibleGroupComponentT UnPack()
		{
			ICombinedVisibleGroupComponentT combinedVisibleGroupComponentT = new ICombinedVisibleGroupComponentT();
			this.UnPackTo(combinedVisibleGroupComponentT);
			return combinedVisibleGroupComponentT;
		}

		// Token: 0x06020857 RID: 133207 RVA: 0x00485DD0 File Offset: 0x00483FD0
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

		// Token: 0x06020858 RID: 133208 RVA: 0x00485E60 File Offset: 0x00484060
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

		// Token: 0x0400DEA5 RID: 56997
		private Table __p;
	}
}

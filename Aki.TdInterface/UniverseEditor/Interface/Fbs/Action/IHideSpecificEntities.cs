using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FA RID: 26874
	public struct IHideSpecificEntities : IFlatbufferObject
	{
		// Token: 0x1700C75E RID: 51038
		// (get) Token: 0x0602EE15 RID: 192021 RVA: 0x00665146 File Offset: 0x00663346
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE16 RID: 192022 RVA: 0x00665153 File Offset: 0x00663353
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE17 RID: 192023 RVA: 0x0066515C File Offset: 0x0066335C
		public static IHideSpecificEntities GetRootAsIHideSpecificEntities(ByteBuffer _bb)
		{
			return IHideSpecificEntities.GetRootAsIHideSpecificEntities(_bb, default(IHideSpecificEntities));
		}

		// Token: 0x0602EE18 RID: 192024 RVA: 0x00665178 File Offset: 0x00663378
		public static IHideSpecificEntities GetRootAsIHideSpecificEntities(ByteBuffer _bb, IHideSpecificEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EE19 RID: 192025 RVA: 0x00665195 File Offset: 0x00663395
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EE1A RID: 192026 RVA: 0x006651A4 File Offset: 0x006633A4
		public IHideSpecificEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602EE1B RID: 192027 RVA: 0x006651B4 File Offset: 0x006633B4
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C75F RID: 51039
		// (get) Token: 0x0602EE1C RID: 192028 RVA: 0x006651F4 File Offset: 0x006633F4
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602EE1D RID: 192029 RVA: 0x0066521F File Offset: 0x0066341F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602EE1E RID: 192030 RVA: 0x0066522E File Offset: 0x0066342E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602EE1F RID: 192031 RVA: 0x0066523C File Offset: 0x0066343C
		public static Offset<IHideSpecificEntities> CreateIHideSpecificEntities(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IHideSpecificEntities.AddEntityIds(builder, EntityIdsOffset);
			return IHideSpecificEntities.EndIHideSpecificEntities(builder);
		}

		// Token: 0x0602EE20 RID: 192032 RVA: 0x00665252 File Offset: 0x00663452
		public static void StartIHideSpecificEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EE21 RID: 192033 RVA: 0x0066525B File Offset: 0x0066345B
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602EE22 RID: 192034 RVA: 0x0066526C File Offset: 0x0066346C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EE23 RID: 192035 RVA: 0x006652A3 File Offset: 0x006634A3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EE24 RID: 192036 RVA: 0x006652BD File Offset: 0x006634BD
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EE25 RID: 192037 RVA: 0x006652DB File Offset: 0x006634DB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EE26 RID: 192038 RVA: 0x006652F4 File Offset: 0x006634F4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EE27 RID: 192039 RVA: 0x006652FF File Offset: 0x006634FF
		public static Offset<IHideSpecificEntities> EndIHideSpecificEntities(FlatBufferBuilder builder)
		{
			return new Offset<IHideSpecificEntities>(builder.EndTable());
		}

		// Token: 0x0602EE28 RID: 192040 RVA: 0x0066530C File Offset: 0x0066350C
		public IHideSpecificEntitiesT UnPack()
		{
			IHideSpecificEntitiesT hideSpecificEntitiesT = new IHideSpecificEntitiesT();
			this.UnPackTo(hideSpecificEntitiesT);
			return hideSpecificEntitiesT;
		}

		// Token: 0x0602EE29 RID: 192041 RVA: 0x00665328 File Offset: 0x00663528
		public void UnPackTo(IHideSpecificEntitiesT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0602EE2A RID: 192042 RVA: 0x00665364 File Offset: 0x00663564
		public static Offset<IHideSpecificEntities> Pack(FlatBufferBuilder builder, IHideSpecificEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideSpecificEntities>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IHideSpecificEntities.CreateEntityIdsVector(builder, data);
			}
			return IHideSpecificEntities.CreateIHideSpecificEntities(builder, entityIdsOffset);
		}

		// Token: 0x0401106E RID: 69742
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200663F RID: 26175
	public struct IEnableAI : IFlatbufferObject
	{
		// Token: 0x1700C27A RID: 49786
		// (get) Token: 0x0602D75D RID: 186205 RVA: 0x0063A1AE File Offset: 0x006383AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D75E RID: 186206 RVA: 0x0063A1BB File Offset: 0x006383BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D75F RID: 186207 RVA: 0x0063A1C4 File Offset: 0x006383C4
		public static IEnableAI GetRootAsIEnableAI(ByteBuffer _bb)
		{
			return IEnableAI.GetRootAsIEnableAI(_bb, default(IEnableAI));
		}

		// Token: 0x0602D760 RID: 186208 RVA: 0x0063A1E0 File Offset: 0x006383E0
		public static IEnableAI GetRootAsIEnableAI(ByteBuffer _bb, IEnableAI obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D761 RID: 186209 RVA: 0x0063A1FD File Offset: 0x006383FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D762 RID: 186210 RVA: 0x0063A20C File Offset: 0x0063840C
		public IEnableAI __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602D763 RID: 186211 RVA: 0x0063A21C File Offset: 0x0063841C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C27B RID: 49787
		// (get) Token: 0x0602D764 RID: 186212 RVA: 0x0063A25C File Offset: 0x0063845C
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

		// Token: 0x0602D765 RID: 186213 RVA: 0x0063A287 File Offset: 0x00638487
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602D766 RID: 186214 RVA: 0x0063A296 File Offset: 0x00638496
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700C27C RID: 49788
		// (get) Token: 0x0602D767 RID: 186215 RVA: 0x0063A2A4 File Offset: 0x006384A4
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D768 RID: 186216 RVA: 0x0063A2E3 File Offset: 0x006384E3
		public static Offset<IEnableAI> CreateIEnableAI(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool IsEnable = false)
		{
			builder.StartTable(2);
			IEnableAI.AddEntityIds(builder, EntityIdsOffset);
			IEnableAI.AddIsEnable(builder, IsEnable);
			return IEnableAI.EndIEnableAI(builder);
		}

		// Token: 0x0602D769 RID: 186217 RVA: 0x0063A300 File Offset: 0x00638500
		public static void StartIEnableAI(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D76A RID: 186218 RVA: 0x0063A309 File Offset: 0x00638509
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602D76B RID: 186219 RVA: 0x0063A31C File Offset: 0x0063851C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D76C RID: 186220 RVA: 0x0063A353 File Offset: 0x00638553
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D76D RID: 186221 RVA: 0x0063A36D File Offset: 0x0063856D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D76E RID: 186222 RVA: 0x0063A38B File Offset: 0x0063858B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D76F RID: 186223 RVA: 0x0063A3A4 File Offset: 0x006385A4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D770 RID: 186224 RVA: 0x0063A3AF File Offset: 0x006385AF
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(1, isEnable, false);
		}

		// Token: 0x0602D771 RID: 186225 RVA: 0x0063A3BA File Offset: 0x006385BA
		public static Offset<IEnableAI> EndIEnableAI(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAI>(builder.EndTable());
		}

		// Token: 0x0602D772 RID: 186226 RVA: 0x0063A3C8 File Offset: 0x006385C8
		public IEnableAIT UnPack()
		{
			IEnableAIT enableAIT = new IEnableAIT();
			this.UnPackTo(enableAIT);
			return enableAIT;
		}

		// Token: 0x0602D773 RID: 186227 RVA: 0x0063A3E4 File Offset: 0x006385E4
		public void UnPackTo(IEnableAIT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.IsEnable = this.IsEnable;
		}

		// Token: 0x0602D774 RID: 186228 RVA: 0x0063A42C File Offset: 0x0063862C
		public static Offset<IEnableAI> Pack(FlatBufferBuilder builder, IEnableAIT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableAI>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IEnableAI.CreateEntityIdsVector(builder, data);
			}
			return IEnableAI.CreateIEnableAI(builder, entityIdsOffset, _o.IsEnable);
		}

		// Token: 0x04010CDA RID: 68826
		private Table __p;
	}
}

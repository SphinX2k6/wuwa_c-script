using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE0 RID: 28640
	public struct ISetEntityClientVisibleSave : IFlatbufferObject
	{
		// Token: 0x1700D4A1 RID: 54433
		// (get) Token: 0x06032A16 RID: 207382 RVA: 0x006D4BB3 File Offset: 0x006D2DB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A17 RID: 207383 RVA: 0x006D4BC0 File Offset: 0x006D2DC0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A18 RID: 207384 RVA: 0x006D4BC8 File Offset: 0x006D2DC8
		public static ISetEntityClientVisibleSave GetRootAsISetEntityClientVisibleSave(ByteBuffer _bb)
		{
			return ISetEntityClientVisibleSave.GetRootAsISetEntityClientVisibleSave(_bb, default(ISetEntityClientVisibleSave));
		}

		// Token: 0x06032A19 RID: 207385 RVA: 0x006D4BE4 File Offset: 0x006D2DE4
		public static ISetEntityClientVisibleSave GetRootAsISetEntityClientVisibleSave(ByteBuffer _bb, ISetEntityClientVisibleSave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032A1A RID: 207386 RVA: 0x006D4C01 File Offset: 0x006D2E01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032A1B RID: 207387 RVA: 0x006D4C10 File Offset: 0x006D2E10
		public ISetEntityClientVisibleSave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032A1C RID: 207388 RVA: 0x006D4C20 File Offset: 0x006D2E20
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D4A2 RID: 54434
		// (get) Token: 0x06032A1D RID: 207389 RVA: 0x006D4C60 File Offset: 0x006D2E60
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

		// Token: 0x06032A1E RID: 207390 RVA: 0x006D4C8B File Offset: 0x006D2E8B
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06032A1F RID: 207391 RVA: 0x006D4C9A File Offset: 0x006D2E9A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700D4A3 RID: 54435
		// (get) Token: 0x06032A20 RID: 207392 RVA: 0x006D4CA8 File Offset: 0x006D2EA8
		public bool Visible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06032A21 RID: 207393 RVA: 0x006D4CE7 File Offset: 0x006D2EE7
		public static Offset<ISetEntityClientVisibleSave> CreateISetEntityClientVisibleSave(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool Visible = false)
		{
			builder.StartTable(2);
			ISetEntityClientVisibleSave.AddEntityIds(builder, EntityIdsOffset);
			ISetEntityClientVisibleSave.AddVisible(builder, Visible);
			return ISetEntityClientVisibleSave.EndISetEntityClientVisibleSave(builder);
		}

		// Token: 0x06032A22 RID: 207394 RVA: 0x006D4D04 File Offset: 0x006D2F04
		public static void StartISetEntityClientVisibleSave(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032A23 RID: 207395 RVA: 0x006D4D0D File Offset: 0x006D2F0D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06032A24 RID: 207396 RVA: 0x006D4D20 File Offset: 0x006D2F20
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032A25 RID: 207397 RVA: 0x006D4D57 File Offset: 0x006D2F57
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032A26 RID: 207398 RVA: 0x006D4D71 File Offset: 0x006D2F71
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032A27 RID: 207399 RVA: 0x006D4D8F File Offset: 0x006D2F8F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032A28 RID: 207400 RVA: 0x006D4DA8 File Offset: 0x006D2FA8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032A29 RID: 207401 RVA: 0x006D4DB3 File Offset: 0x006D2FB3
		public static void AddVisible(FlatBufferBuilder builder, bool visible)
		{
			builder.AddBool(1, visible, false);
		}

		// Token: 0x06032A2A RID: 207402 RVA: 0x006D4DBE File Offset: 0x006D2FBE
		public static Offset<ISetEntityClientVisibleSave> EndISetEntityClientVisibleSave(FlatBufferBuilder builder)
		{
			return new Offset<ISetEntityClientVisibleSave>(builder.EndTable());
		}

		// Token: 0x06032A2B RID: 207403 RVA: 0x006D4DCC File Offset: 0x006D2FCC
		public ISetEntityClientVisibleSaveT UnPack()
		{
			ISetEntityClientVisibleSaveT setEntityClientVisibleSaveT = new ISetEntityClientVisibleSaveT();
			this.UnPackTo(setEntityClientVisibleSaveT);
			return setEntityClientVisibleSaveT;
		}

		// Token: 0x06032A2C RID: 207404 RVA: 0x006D4DE8 File Offset: 0x006D2FE8
		public void UnPackTo(ISetEntityClientVisibleSaveT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.Visible = this.Visible;
		}

		// Token: 0x06032A2D RID: 207405 RVA: 0x006D4E30 File Offset: 0x006D3030
		public static Offset<ISetEntityClientVisibleSave> Pack(FlatBufferBuilder builder, ISetEntityClientVisibleSaveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetEntityClientVisibleSave>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ISetEntityClientVisibleSave.CreateEntityIdsVector(builder, data);
			}
			return ISetEntityClientVisibleSave.CreateISetEntityClientVisibleSave(builder, entityIdsOffset, _o.Visible);
		}

		// Token: 0x040119EE RID: 72174
		private Table __p;
	}
}

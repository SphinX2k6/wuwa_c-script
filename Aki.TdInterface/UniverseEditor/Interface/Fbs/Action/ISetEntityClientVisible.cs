using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A6 RID: 30630
	public struct ISetEntityClientVisible : IFlatbufferObject
	{
		// Token: 0x1700E070 RID: 57456
		// (get) Token: 0x06035C5E RID: 220254 RVA: 0x007344C8 File Offset: 0x007326C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C5F RID: 220255 RVA: 0x007344D5 File Offset: 0x007326D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C60 RID: 220256 RVA: 0x007344DC File Offset: 0x007326DC
		public static ISetEntityClientVisible GetRootAsISetEntityClientVisible(ByteBuffer _bb)
		{
			return ISetEntityClientVisible.GetRootAsISetEntityClientVisible(_bb, default(ISetEntityClientVisible));
		}

		// Token: 0x06035C61 RID: 220257 RVA: 0x007344F8 File Offset: 0x007326F8
		public static ISetEntityClientVisible GetRootAsISetEntityClientVisible(ByteBuffer _bb, ISetEntityClientVisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C62 RID: 220258 RVA: 0x00734515 File Offset: 0x00732715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C63 RID: 220259 RVA: 0x00734524 File Offset: 0x00732724
		public ISetEntityClientVisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06035C64 RID: 220260 RVA: 0x00734534 File Offset: 0x00732734
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E071 RID: 57457
		// (get) Token: 0x06035C65 RID: 220261 RVA: 0x00734574 File Offset: 0x00732774
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

		// Token: 0x06035C66 RID: 220262 RVA: 0x0073459F File Offset: 0x0073279F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06035C67 RID: 220263 RVA: 0x007345AE File Offset: 0x007327AE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700E072 RID: 57458
		// (get) Token: 0x06035C68 RID: 220264 RVA: 0x007345BC File Offset: 0x007327BC
		public bool Visible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06035C69 RID: 220265 RVA: 0x007345FB File Offset: 0x007327FB
		public static Offset<ISetEntityClientVisible> CreateISetEntityClientVisible(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool Visible = false)
		{
			builder.StartTable(2);
			ISetEntityClientVisible.AddEntityIds(builder, EntityIdsOffset);
			ISetEntityClientVisible.AddVisible(builder, Visible);
			return ISetEntityClientVisible.EndISetEntityClientVisible(builder);
		}

		// Token: 0x06035C6A RID: 220266 RVA: 0x00734618 File Offset: 0x00732818
		public static void StartISetEntityClientVisible(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035C6B RID: 220267 RVA: 0x00734621 File Offset: 0x00732821
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06035C6C RID: 220268 RVA: 0x00734634 File Offset: 0x00732834
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035C6D RID: 220269 RVA: 0x0073466B File Offset: 0x0073286B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035C6E RID: 220270 RVA: 0x00734685 File Offset: 0x00732885
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035C6F RID: 220271 RVA: 0x007346A3 File Offset: 0x007328A3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035C70 RID: 220272 RVA: 0x007346BC File Offset: 0x007328BC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035C71 RID: 220273 RVA: 0x007346C7 File Offset: 0x007328C7
		public static void AddVisible(FlatBufferBuilder builder, bool visible)
		{
			builder.AddBool(1, visible, false);
		}

		// Token: 0x06035C72 RID: 220274 RVA: 0x007346D2 File Offset: 0x007328D2
		public static Offset<ISetEntityClientVisible> EndISetEntityClientVisible(FlatBufferBuilder builder)
		{
			return new Offset<ISetEntityClientVisible>(builder.EndTable());
		}

		// Token: 0x06035C73 RID: 220275 RVA: 0x007346E0 File Offset: 0x007328E0
		public ISetEntityClientVisibleT UnPack()
		{
			ISetEntityClientVisibleT setEntityClientVisibleT = new ISetEntityClientVisibleT();
			this.UnPackTo(setEntityClientVisibleT);
			return setEntityClientVisibleT;
		}

		// Token: 0x06035C74 RID: 220276 RVA: 0x007346FC File Offset: 0x007328FC
		public void UnPackTo(ISetEntityClientVisibleT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.Visible = this.Visible;
		}

		// Token: 0x06035C75 RID: 220277 RVA: 0x00734744 File Offset: 0x00732944
		public static Offset<ISetEntityClientVisible> Pack(FlatBufferBuilder builder, ISetEntityClientVisibleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetEntityClientVisible>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ISetEntityClientVisible.CreateEntityIdsVector(builder, data);
			}
			return ISetEntityClientVisible.CreateISetEntityClientVisible(builder, entityIdsOffset, _o.Visible);
		}

		// Token: 0x040129D0 RID: 76240
		private Table __p;
	}
}

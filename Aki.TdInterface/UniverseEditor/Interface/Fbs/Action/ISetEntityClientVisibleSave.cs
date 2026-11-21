using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A9 RID: 30633
	public struct ISetEntityClientVisibleSave : IFlatbufferObject
	{
		// Token: 0x1700E075 RID: 57461
		// (get) Token: 0x06035C7C RID: 220284 RVA: 0x007347F7 File Offset: 0x007329F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C7D RID: 220285 RVA: 0x00734804 File Offset: 0x00732A04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C7E RID: 220286 RVA: 0x0073480C File Offset: 0x00732A0C
		public static ISetEntityClientVisibleSave GetRootAsISetEntityClientVisibleSave(ByteBuffer _bb)
		{
			return ISetEntityClientVisibleSave.GetRootAsISetEntityClientVisibleSave(_bb, default(ISetEntityClientVisibleSave));
		}

		// Token: 0x06035C7F RID: 220287 RVA: 0x00734828 File Offset: 0x00732A28
		public static ISetEntityClientVisibleSave GetRootAsISetEntityClientVisibleSave(ByteBuffer _bb, ISetEntityClientVisibleSave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C80 RID: 220288 RVA: 0x00734845 File Offset: 0x00732A45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C81 RID: 220289 RVA: 0x00734854 File Offset: 0x00732A54
		public ISetEntityClientVisibleSave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06035C82 RID: 220290 RVA: 0x00734864 File Offset: 0x00732A64
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E076 RID: 57462
		// (get) Token: 0x06035C83 RID: 220291 RVA: 0x007348A4 File Offset: 0x00732AA4
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

		// Token: 0x06035C84 RID: 220292 RVA: 0x007348CF File Offset: 0x00732ACF
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06035C85 RID: 220293 RVA: 0x007348DE File Offset: 0x00732ADE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700E077 RID: 57463
		// (get) Token: 0x06035C86 RID: 220294 RVA: 0x007348EC File Offset: 0x00732AEC
		public bool Visible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06035C87 RID: 220295 RVA: 0x0073492B File Offset: 0x00732B2B
		public static Offset<ISetEntityClientVisibleSave> CreateISetEntityClientVisibleSave(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool Visible = false)
		{
			builder.StartTable(2);
			ISetEntityClientVisibleSave.AddEntityIds(builder, EntityIdsOffset);
			ISetEntityClientVisibleSave.AddVisible(builder, Visible);
			return ISetEntityClientVisibleSave.EndISetEntityClientVisibleSave(builder);
		}

		// Token: 0x06035C88 RID: 220296 RVA: 0x00734948 File Offset: 0x00732B48
		public static void StartISetEntityClientVisibleSave(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035C89 RID: 220297 RVA: 0x00734951 File Offset: 0x00732B51
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06035C8A RID: 220298 RVA: 0x00734964 File Offset: 0x00732B64
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035C8B RID: 220299 RVA: 0x0073499B File Offset: 0x00732B9B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035C8C RID: 220300 RVA: 0x007349B5 File Offset: 0x00732BB5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035C8D RID: 220301 RVA: 0x007349D3 File Offset: 0x00732BD3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035C8E RID: 220302 RVA: 0x007349EC File Offset: 0x00732BEC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035C8F RID: 220303 RVA: 0x007349F7 File Offset: 0x00732BF7
		public static void AddVisible(FlatBufferBuilder builder, bool visible)
		{
			builder.AddBool(1, visible, false);
		}

		// Token: 0x06035C90 RID: 220304 RVA: 0x00734A02 File Offset: 0x00732C02
		public static Offset<ISetEntityClientVisibleSave> EndISetEntityClientVisibleSave(FlatBufferBuilder builder)
		{
			return new Offset<ISetEntityClientVisibleSave>(builder.EndTable());
		}

		// Token: 0x06035C91 RID: 220305 RVA: 0x00734A10 File Offset: 0x00732C10
		public ISetEntityClientVisibleSaveT UnPack()
		{
			ISetEntityClientVisibleSaveT setEntityClientVisibleSaveT = new ISetEntityClientVisibleSaveT();
			this.UnPackTo(setEntityClientVisibleSaveT);
			return setEntityClientVisibleSaveT;
		}

		// Token: 0x06035C92 RID: 220306 RVA: 0x00734A2C File Offset: 0x00732C2C
		public void UnPackTo(ISetEntityClientVisibleSaveT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.Visible = this.Visible;
		}

		// Token: 0x06035C93 RID: 220307 RVA: 0x00734A74 File Offset: 0x00732C74
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

		// Token: 0x040129D3 RID: 76243
		private Table __p;
	}
}

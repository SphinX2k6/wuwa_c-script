using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CDA RID: 27866
	public struct IEnableHostility : IFlatbufferObject
	{
		// Token: 0x1700CC60 RID: 52320
		// (get) Token: 0x0603007C RID: 196732 RVA: 0x006890B2 File Offset: 0x006872B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603007D RID: 196733 RVA: 0x006890BF File Offset: 0x006872BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603007E RID: 196734 RVA: 0x006890C8 File Offset: 0x006872C8
		public static IEnableHostility GetRootAsIEnableHostility(ByteBuffer _bb)
		{
			return IEnableHostility.GetRootAsIEnableHostility(_bb, default(IEnableHostility));
		}

		// Token: 0x0603007F RID: 196735 RVA: 0x006890E4 File Offset: 0x006872E4
		public static IEnableHostility GetRootAsIEnableHostility(ByteBuffer _bb, IEnableHostility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030080 RID: 196736 RVA: 0x00689101 File Offset: 0x00687301
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030081 RID: 196737 RVA: 0x00689110 File Offset: 0x00687310
		public IEnableHostility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC61 RID: 52321
		// (get) Token: 0x06030082 RID: 196738 RVA: 0x00689120 File Offset: 0x00687320
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06030083 RID: 196739 RVA: 0x00689160 File Offset: 0x00687360
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CC62 RID: 52322
		// (get) Token: 0x06030084 RID: 196740 RVA: 0x006891A0 File Offset: 0x006873A0
		public int EntityIdsLength
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

		// Token: 0x06030085 RID: 196741 RVA: 0x006891CB File Offset: 0x006873CB
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06030086 RID: 196742 RVA: 0x006891DA File Offset: 0x006873DA
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06030087 RID: 196743 RVA: 0x006891E8 File Offset: 0x006873E8
		public static Offset<IEnableHostility> CreateIEnableHostility(FlatBufferBuilder builder, bool IsEnable = false, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEnableHostility.AddEntityIds(builder, EntityIdsOffset);
			IEnableHostility.AddIsEnable(builder, IsEnable);
			return IEnableHostility.EndIEnableHostility(builder);
		}

		// Token: 0x06030088 RID: 196744 RVA: 0x00689205 File Offset: 0x00687405
		public static void StartIEnableHostility(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030089 RID: 196745 RVA: 0x0068920E File Offset: 0x0068740E
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x0603008A RID: 196746 RVA: 0x00689219 File Offset: 0x00687419
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0603008B RID: 196747 RVA: 0x0068922C File Offset: 0x0068742C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603008C RID: 196748 RVA: 0x00689263 File Offset: 0x00687463
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603008D RID: 196749 RVA: 0x0068927D File Offset: 0x0068747D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603008E RID: 196750 RVA: 0x0068929B File Offset: 0x0068749B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603008F RID: 196751 RVA: 0x006892B4 File Offset: 0x006874B4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030090 RID: 196752 RVA: 0x006892BF File Offset: 0x006874BF
		public static Offset<IEnableHostility> EndIEnableHostility(FlatBufferBuilder builder)
		{
			return new Offset<IEnableHostility>(builder.EndTable());
		}

		// Token: 0x06030091 RID: 196753 RVA: 0x006892CC File Offset: 0x006874CC
		public IEnableHostilityT UnPack()
		{
			IEnableHostilityT enableHostilityT = new IEnableHostilityT();
			this.UnPackTo(enableHostilityT);
			return enableHostilityT;
		}

		// Token: 0x06030092 RID: 196754 RVA: 0x006892E8 File Offset: 0x006874E8
		public void UnPackTo(IEnableHostilityT _o)
		{
			_o.IsEnable = this.IsEnable;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06030093 RID: 196755 RVA: 0x00689330 File Offset: 0x00687530
		public static Offset<IEnableHostility> Pack(FlatBufferBuilder builder, IEnableHostilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableHostility>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IEnableHostility.CreateEntityIdsVector(builder, data);
			}
			return IEnableHostility.CreateIEnableHostility(builder, _o.IsEnable, entityIdsOffset);
		}

		// Token: 0x04011B2B RID: 72491
		private Table __p;
	}
}

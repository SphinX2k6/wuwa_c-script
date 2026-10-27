using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006669 RID: 26217
	public struct IEnableHostility : IFlatbufferObject
	{
		// Token: 0x1700C2C2 RID: 49858
		// (get) Token: 0x0602D8AB RID: 186539 RVA: 0x0063C54A File Offset: 0x0063A74A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D8AC RID: 186540 RVA: 0x0063C557 File Offset: 0x0063A757
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D8AD RID: 186541 RVA: 0x0063C560 File Offset: 0x0063A760
		public static IEnableHostility GetRootAsIEnableHostility(ByteBuffer _bb)
		{
			return IEnableHostility.GetRootAsIEnableHostility(_bb, default(IEnableHostility));
		}

		// Token: 0x0602D8AE RID: 186542 RVA: 0x0063C57C File Offset: 0x0063A77C
		public static IEnableHostility GetRootAsIEnableHostility(ByteBuffer _bb, IEnableHostility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D8AF RID: 186543 RVA: 0x0063C599 File Offset: 0x0063A799
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D8B0 RID: 186544 RVA: 0x0063C5A8 File Offset: 0x0063A7A8
		public IEnableHostility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2C3 RID: 49859
		// (get) Token: 0x0602D8B1 RID: 186545 RVA: 0x0063C5B8 File Offset: 0x0063A7B8
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D8B2 RID: 186546 RVA: 0x0063C5F8 File Offset: 0x0063A7F8
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C2C4 RID: 49860
		// (get) Token: 0x0602D8B3 RID: 186547 RVA: 0x0063C638 File Offset: 0x0063A838
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

		// Token: 0x0602D8B4 RID: 186548 RVA: 0x0063C663 File Offset: 0x0063A863
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602D8B5 RID: 186549 RVA: 0x0063C672 File Offset: 0x0063A872
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602D8B6 RID: 186550 RVA: 0x0063C680 File Offset: 0x0063A880
		public static Offset<IEnableHostility> CreateIEnableHostility(FlatBufferBuilder builder, bool IsEnable = false, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEnableHostility.AddEntityIds(builder, EntityIdsOffset);
			IEnableHostility.AddIsEnable(builder, IsEnable);
			return IEnableHostility.EndIEnableHostility(builder);
		}

		// Token: 0x0602D8B7 RID: 186551 RVA: 0x0063C69D File Offset: 0x0063A89D
		public static void StartIEnableHostility(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D8B8 RID: 186552 RVA: 0x0063C6A6 File Offset: 0x0063A8A6
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x0602D8B9 RID: 186553 RVA: 0x0063C6B1 File Offset: 0x0063A8B1
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602D8BA RID: 186554 RVA: 0x0063C6C4 File Offset: 0x0063A8C4
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D8BB RID: 186555 RVA: 0x0063C6FB File Offset: 0x0063A8FB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D8BC RID: 186556 RVA: 0x0063C715 File Offset: 0x0063A915
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D8BD RID: 186557 RVA: 0x0063C733 File Offset: 0x0063A933
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D8BE RID: 186558 RVA: 0x0063C74C File Offset: 0x0063A94C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D8BF RID: 186559 RVA: 0x0063C757 File Offset: 0x0063A957
		public static Offset<IEnableHostility> EndIEnableHostility(FlatBufferBuilder builder)
		{
			return new Offset<IEnableHostility>(builder.EndTable());
		}

		// Token: 0x0602D8C0 RID: 186560 RVA: 0x0063C764 File Offset: 0x0063A964
		public IEnableHostilityT UnPack()
		{
			IEnableHostilityT enableHostilityT = new IEnableHostilityT();
			this.UnPackTo(enableHostilityT);
			return enableHostilityT;
		}

		// Token: 0x0602D8C1 RID: 186561 RVA: 0x0063C780 File Offset: 0x0063A980
		public void UnPackTo(IEnableHostilityT _o)
		{
			_o.IsEnable = this.IsEnable;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0602D8C2 RID: 186562 RVA: 0x0063C7C8 File Offset: 0x0063A9C8
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

		// Token: 0x04010D10 RID: 68880
		private Table __p;
	}
}

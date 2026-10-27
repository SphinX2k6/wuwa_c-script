using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061C4 RID: 25028
	public struct IAvgPlayRoleAction : IFlatbufferObject
	{
		// Token: 0x1700BA99 RID: 47769
		// (get) Token: 0x0602B208 RID: 176648 RVA: 0x005F210F File Offset: 0x005F030F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B209 RID: 176649 RVA: 0x005F211C File Offset: 0x005F031C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B20A RID: 176650 RVA: 0x005F2124 File Offset: 0x005F0324
		public static IAvgPlayRoleAction GetRootAsIAvgPlayRoleAction(ByteBuffer _bb)
		{
			return IAvgPlayRoleAction.GetRootAsIAvgPlayRoleAction(_bb, default(IAvgPlayRoleAction));
		}

		// Token: 0x0602B20B RID: 176651 RVA: 0x005F2140 File Offset: 0x005F0340
		public static IAvgPlayRoleAction GetRootAsIAvgPlayRoleAction(ByteBuffer _bb, IAvgPlayRoleAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B20C RID: 176652 RVA: 0x005F215D File Offset: 0x005F035D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B20D RID: 176653 RVA: 0x005F216C File Offset: 0x005F036C
		public IAvgPlayRoleAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602B20E RID: 176654 RVA: 0x005F217C File Offset: 0x005F037C
		public IAvgPlayRoleActionItem? RoleActionList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IAvgPlayRoleActionItem?(default(IAvgPlayRoleActionItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BA9A RID: 47770
		// (get) Token: 0x0602B20F RID: 176655 RVA: 0x005F21DC File Offset: 0x005F03DC
		public int RoleActionListLength
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

		// Token: 0x0602B210 RID: 176656 RVA: 0x005F2207 File Offset: 0x005F0407
		public static Offset<IAvgPlayRoleAction> CreateIAvgPlayRoleAction(FlatBufferBuilder builder, VectorOffset RoleActionListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IAvgPlayRoleAction.AddRoleActionList(builder, RoleActionListOffset);
			return IAvgPlayRoleAction.EndIAvgPlayRoleAction(builder);
		}

		// Token: 0x0602B211 RID: 176657 RVA: 0x005F221D File Offset: 0x005F041D
		public static void StartIAvgPlayRoleAction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B212 RID: 176658 RVA: 0x005F2226 File Offset: 0x005F0426
		public static void AddRoleActionList(FlatBufferBuilder builder, VectorOffset roleActionListOffset)
		{
			builder.AddOffset(0, roleActionListOffset.Value, 0);
		}

		// Token: 0x0602B213 RID: 176659 RVA: 0x005F2238 File Offset: 0x005F0438
		public static VectorOffset CreateRoleActionListVector(FlatBufferBuilder builder, Offset<IAvgPlayRoleActionItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B214 RID: 176660 RVA: 0x005F2278 File Offset: 0x005F0478
		public static VectorOffset CreateRoleActionListVectorBlock(FlatBufferBuilder builder, Offset<IAvgPlayRoleActionItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAvgPlayRoleActionItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B215 RID: 176661 RVA: 0x005F2292 File Offset: 0x005F0492
		public static VectorOffset CreateRoleActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAvgPlayRoleActionItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAvgPlayRoleActionItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B216 RID: 176662 RVA: 0x005F22B0 File Offset: 0x005F04B0
		public static VectorOffset CreateRoleActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAvgPlayRoleActionItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B217 RID: 176663 RVA: 0x005F22C9 File Offset: 0x005F04C9
		public static void StartRoleActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B218 RID: 176664 RVA: 0x005F22D4 File Offset: 0x005F04D4
		public static Offset<IAvgPlayRoleAction> EndIAvgPlayRoleAction(FlatBufferBuilder builder)
		{
			return new Offset<IAvgPlayRoleAction>(builder.EndTable());
		}

		// Token: 0x0602B219 RID: 176665 RVA: 0x005F22E4 File Offset: 0x005F04E4
		public IAvgPlayRoleActionT UnPack()
		{
			IAvgPlayRoleActionT avgPlayRoleActionT = new IAvgPlayRoleActionT();
			this.UnPackTo(avgPlayRoleActionT);
			return avgPlayRoleActionT;
		}

		// Token: 0x0602B21A RID: 176666 RVA: 0x005F2300 File Offset: 0x005F0500
		public void UnPackTo(IAvgPlayRoleActionT _o)
		{
			_o.RoleActionList = new List<IAvgPlayRoleActionItemT>();
			for (int i = 0; i < this.RoleActionListLength; i++)
			{
				_o.RoleActionList.Add((this.RoleActionList(i) != null) ? this.RoleActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602B21B RID: 176667 RVA: 0x005F2360 File Offset: 0x005F0560
		public static Offset<IAvgPlayRoleAction> Pack(FlatBufferBuilder builder, IAvgPlayRoleActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgPlayRoleAction>);
			}
			VectorOffset roleActionListOffset = default(VectorOffset);
			if (_o.RoleActionList != null)
			{
				Offset<IAvgPlayRoleActionItem>[] array = new Offset<IAvgPlayRoleActionItem>[_o.RoleActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IAvgPlayRoleActionItem.Pack(builder, _o.RoleActionList[i]);
				}
				roleActionListOffset = IAvgPlayRoleAction.CreateRoleActionListVector(builder, array);
			}
			return IAvgPlayRoleAction.CreateIAvgPlayRoleAction(builder, roleActionListOffset);
		}

		// Token: 0x040106E7 RID: 67303
		private Table __p;
	}
}

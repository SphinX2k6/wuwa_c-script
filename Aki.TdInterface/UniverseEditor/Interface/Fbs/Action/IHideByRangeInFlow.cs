using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E2 RID: 26850
	public struct IHideByRangeInFlow : IFlatbufferObject
	{
		// Token: 0x1700C730 RID: 50992
		// (get) Token: 0x0602ED44 RID: 191812 RVA: 0x006639C0 File Offset: 0x00661BC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ED45 RID: 191813 RVA: 0x006639CD File Offset: 0x00661BCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ED46 RID: 191814 RVA: 0x006639D4 File Offset: 0x00661BD4
		public static IHideByRangeInFlow GetRootAsIHideByRangeInFlow(ByteBuffer _bb)
		{
			return IHideByRangeInFlow.GetRootAsIHideByRangeInFlow(_bb, default(IHideByRangeInFlow));
		}

		// Token: 0x0602ED47 RID: 191815 RVA: 0x006639F0 File Offset: 0x00661BF0
		public static IHideByRangeInFlow GetRootAsIHideByRangeInFlow(ByteBuffer _bb, IHideByRangeInFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ED48 RID: 191816 RVA: 0x00663A0D File Offset: 0x00661C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ED49 RID: 191817 RVA: 0x00663A1C File Offset: 0x00661C1C
		public IHideByRangeInFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C731 RID: 50993
		// (get) Token: 0x0602ED4A RID: 191818 RVA: 0x00663A2C File Offset: 0x00661C2C
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C732 RID: 50994
		// (get) Token: 0x0602ED4B RID: 191819 RVA: 0x00663A68 File Offset: 0x00661C68
		public IVectorInfo? Center
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C733 RID: 50995
		// (get) Token: 0x0602ED4C RID: 191820 RVA: 0x00663AC8 File Offset: 0x00661CC8
		public int Radius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602ED4D RID: 191821 RVA: 0x00663B04 File Offset: 0x00661D04
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C734 RID: 50996
		// (get) Token: 0x0602ED4E RID: 191822 RVA: 0x00663B44 File Offset: 0x00661D44
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

		// Token: 0x0602ED4F RID: 191823 RVA: 0x00663B70 File Offset: 0x00661D70
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602ED50 RID: 191824 RVA: 0x00663B80 File Offset: 0x00661D80
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700C735 RID: 50997
		// (get) Token: 0x0602ED51 RID: 191825 RVA: 0x00663B90 File Offset: 0x00661D90
		public bool IsCleanSimpleNpc
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C736 RID: 50998
		// (get) Token: 0x0602ED52 RID: 191826 RVA: 0x00663BD0 File Offset: 0x00661DD0
		public bool IsCleanPasserByNpc
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C737 RID: 50999
		// (get) Token: 0x0602ED53 RID: 191827 RVA: 0x00663C10 File Offset: 0x00661E10
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602ED54 RID: 191828 RVA: 0x00663C50 File Offset: 0x00661E50
		public static Offset<IHideByRangeInFlow> CreateIHideByRangeInFlow(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, VectorOffset EntityIdsOffset = default(VectorOffset), bool IsCleanSimpleNpc = false, bool IsCleanPasserByNpc = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IHideByRangeInFlow.AddEntityIds(builder, EntityIdsOffset);
			IHideByRangeInFlow.AddRadius(builder, Radius);
			IHideByRangeInFlow.AddCenter(builder, CenterOffset);
			IHideByRangeInFlow.AddNullMask(builder, NullMask);
			IHideByRangeInFlow.AddIsCleanPasserByNpc(builder, IsCleanPasserByNpc);
			IHideByRangeInFlow.AddIsCleanSimpleNpc(builder, IsCleanSimpleNpc);
			IHideByRangeInFlow.AddType(builder, Type);
			return IHideByRangeInFlow.EndIHideByRangeInFlow(builder);
		}

		// Token: 0x0602ED55 RID: 191829 RVA: 0x00663C9F File Offset: 0x00661E9F
		public static void StartIHideByRangeInFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602ED56 RID: 191830 RVA: 0x00663CA8 File Offset: 0x00661EA8
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ED57 RID: 191831 RVA: 0x00663CB3 File Offset: 0x00661EB3
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x0602ED58 RID: 191832 RVA: 0x00663CC3 File Offset: 0x00661EC3
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x0602ED59 RID: 191833 RVA: 0x00663CCE File Offset: 0x00661ECE
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602ED5A RID: 191834 RVA: 0x00663CE0 File Offset: 0x00661EE0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602ED5B RID: 191835 RVA: 0x00663D17 File Offset: 0x00661F17
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602ED5C RID: 191836 RVA: 0x00663D31 File Offset: 0x00661F31
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602ED5D RID: 191837 RVA: 0x00663D4F File Offset: 0x00661F4F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602ED5E RID: 191838 RVA: 0x00663D68 File Offset: 0x00661F68
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602ED5F RID: 191839 RVA: 0x00663D73 File Offset: 0x00661F73
		public static void AddIsCleanSimpleNpc(FlatBufferBuilder builder, bool isCleanSimpleNpc)
		{
			builder.AddBool(4, isCleanSimpleNpc, false);
		}

		// Token: 0x0602ED60 RID: 191840 RVA: 0x00663D7E File Offset: 0x00661F7E
		public static void AddIsCleanPasserByNpc(FlatBufferBuilder builder, bool isCleanPasserByNpc)
		{
			builder.AddBool(5, isCleanPasserByNpc, false);
		}

		// Token: 0x0602ED61 RID: 191841 RVA: 0x00663D89 File Offset: 0x00661F89
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602ED62 RID: 191842 RVA: 0x00663D94 File Offset: 0x00661F94
		public static Offset<IHideByRangeInFlow> EndIHideByRangeInFlow(FlatBufferBuilder builder)
		{
			return new Offset<IHideByRangeInFlow>(builder.EndTable());
		}

		// Token: 0x0602ED63 RID: 191843 RVA: 0x00663DA4 File Offset: 0x00661FA4
		public IHideByRangeInFlowT UnPack()
		{
			IHideByRangeInFlowT hideByRangeInFlowT = new IHideByRangeInFlowT();
			this.UnPackTo(hideByRangeInFlowT);
			return hideByRangeInFlowT;
		}

		// Token: 0x0602ED64 RID: 191844 RVA: 0x00663DC0 File Offset: 0x00661FC0
		public void UnPackTo(IHideByRangeInFlowT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.IsCleanSimpleNpc = this.IsCleanSimpleNpc;
			_o.IsCleanPasserByNpc = this.IsCleanPasserByNpc;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602ED65 RID: 191845 RVA: 0x00663E68 File Offset: 0x00662068
		public static Offset<IHideByRangeInFlow> Pack(FlatBufferBuilder builder, IHideByRangeInFlowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideByRangeInFlow>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IHideByRangeInFlow.CreateEntityIdsVector(builder, data);
			}
			return IHideByRangeInFlow.CreateIHideByRangeInFlow(builder, _o.Type, centerOffset, _o.Radius, entityIdsOffset, _o.IsCleanSimpleNpc, _o.IsCleanPasserByNpc, _o.NullMask);
		}

		// Token: 0x04011044 RID: 69700
		private Table __p;
	}
}

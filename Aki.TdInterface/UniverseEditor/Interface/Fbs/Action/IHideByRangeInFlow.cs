using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F92 RID: 28562
	public struct IHideByRangeInFlow : IFlatbufferObject
	{
		// Token: 0x1700D12A RID: 53546
		// (get) Token: 0x060316F6 RID: 202486 RVA: 0x006B3B08 File Offset: 0x006B1D08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060316F7 RID: 202487 RVA: 0x006B3B15 File Offset: 0x006B1D15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060316F8 RID: 202488 RVA: 0x006B3B1C File Offset: 0x006B1D1C
		public static IHideByRangeInFlow GetRootAsIHideByRangeInFlow(ByteBuffer _bb)
		{
			return IHideByRangeInFlow.GetRootAsIHideByRangeInFlow(_bb, default(IHideByRangeInFlow));
		}

		// Token: 0x060316F9 RID: 202489 RVA: 0x006B3B38 File Offset: 0x006B1D38
		public static IHideByRangeInFlow GetRootAsIHideByRangeInFlow(ByteBuffer _bb, IHideByRangeInFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060316FA RID: 202490 RVA: 0x006B3B55 File Offset: 0x006B1D55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060316FB RID: 202491 RVA: 0x006B3B64 File Offset: 0x006B1D64
		public IHideByRangeInFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D12B RID: 53547
		// (get) Token: 0x060316FC RID: 202492 RVA: 0x006B3B74 File Offset: 0x006B1D74
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

		// Token: 0x1700D12C RID: 53548
		// (get) Token: 0x060316FD RID: 202493 RVA: 0x006B3BB0 File Offset: 0x006B1DB0
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

		// Token: 0x1700D12D RID: 53549
		// (get) Token: 0x060316FE RID: 202494 RVA: 0x006B3C10 File Offset: 0x006B1E10
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

		// Token: 0x060316FF RID: 202495 RVA: 0x006B3C4C File Offset: 0x006B1E4C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D12E RID: 53550
		// (get) Token: 0x06031700 RID: 202496 RVA: 0x006B3C8C File Offset: 0x006B1E8C
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

		// Token: 0x06031701 RID: 202497 RVA: 0x006B3CB8 File Offset: 0x006B1EB8
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06031702 RID: 202498 RVA: 0x006B3CC8 File Offset: 0x006B1EC8
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700D12F RID: 53551
		// (get) Token: 0x06031703 RID: 202499 RVA: 0x006B3CD8 File Offset: 0x006B1ED8
		public bool IsCleanSimpleNpc
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D130 RID: 53552
		// (get) Token: 0x06031704 RID: 202500 RVA: 0x006B3D18 File Offset: 0x006B1F18
		public bool IsCleanPasserByNpc
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D131 RID: 53553
		// (get) Token: 0x06031705 RID: 202501 RVA: 0x006B3D58 File Offset: 0x006B1F58
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

		// Token: 0x06031706 RID: 202502 RVA: 0x006B3D98 File Offset: 0x006B1F98
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

		// Token: 0x06031707 RID: 202503 RVA: 0x006B3DE7 File Offset: 0x006B1FE7
		public static void StartIHideByRangeInFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06031708 RID: 202504 RVA: 0x006B3DF0 File Offset: 0x006B1FF0
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031709 RID: 202505 RVA: 0x006B3DFB File Offset: 0x006B1FFB
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x0603170A RID: 202506 RVA: 0x006B3E0B File Offset: 0x006B200B
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x0603170B RID: 202507 RVA: 0x006B3E16 File Offset: 0x006B2016
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x0603170C RID: 202508 RVA: 0x006B3E28 File Offset: 0x006B2028
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603170D RID: 202509 RVA: 0x006B3E5F File Offset: 0x006B205F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603170E RID: 202510 RVA: 0x006B3E79 File Offset: 0x006B2079
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603170F RID: 202511 RVA: 0x006B3E97 File Offset: 0x006B2097
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031710 RID: 202512 RVA: 0x006B3EB0 File Offset: 0x006B20B0
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031711 RID: 202513 RVA: 0x006B3EBB File Offset: 0x006B20BB
		public static void AddIsCleanSimpleNpc(FlatBufferBuilder builder, bool isCleanSimpleNpc)
		{
			builder.AddBool(4, isCleanSimpleNpc, false);
		}

		// Token: 0x06031712 RID: 202514 RVA: 0x006B3EC6 File Offset: 0x006B20C6
		public static void AddIsCleanPasserByNpc(FlatBufferBuilder builder, bool isCleanPasserByNpc)
		{
			builder.AddBool(5, isCleanPasserByNpc, false);
		}

		// Token: 0x06031713 RID: 202515 RVA: 0x006B3ED1 File Offset: 0x006B20D1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06031714 RID: 202516 RVA: 0x006B3EDC File Offset: 0x006B20DC
		public static Offset<IHideByRangeInFlow> EndIHideByRangeInFlow(FlatBufferBuilder builder)
		{
			return new Offset<IHideByRangeInFlow>(builder.EndTable());
		}

		// Token: 0x06031715 RID: 202517 RVA: 0x006B3EEC File Offset: 0x006B20EC
		public IHideByRangeInFlowT UnPack()
		{
			IHideByRangeInFlowT hideByRangeInFlowT = new IHideByRangeInFlowT();
			this.UnPackTo(hideByRangeInFlowT);
			return hideByRangeInFlowT;
		}

		// Token: 0x06031716 RID: 202518 RVA: 0x006B3F08 File Offset: 0x006B2108
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

		// Token: 0x06031717 RID: 202519 RVA: 0x006B3FB0 File Offset: 0x006B21B0
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

		// Token: 0x04011EAB RID: 73387
		private Table __p;
	}
}

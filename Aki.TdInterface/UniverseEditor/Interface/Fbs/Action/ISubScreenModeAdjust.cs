using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200720E RID: 29198
	public struct ISubScreenModeAdjust : IFlatbufferObject
	{
		// Token: 0x1700D8C6 RID: 55494
		// (get) Token: 0x06033C9C RID: 212124 RVA: 0x006F8514 File Offset: 0x006F6714
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033C9D RID: 212125 RVA: 0x006F8521 File Offset: 0x006F6721
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033C9E RID: 212126 RVA: 0x006F8528 File Offset: 0x006F6728
		public static ISubScreenModeAdjust GetRootAsISubScreenModeAdjust(ByteBuffer _bb)
		{
			return ISubScreenModeAdjust.GetRootAsISubScreenModeAdjust(_bb, default(ISubScreenModeAdjust));
		}

		// Token: 0x06033C9F RID: 212127 RVA: 0x006F8544 File Offset: 0x006F6744
		public static ISubScreenModeAdjust GetRootAsISubScreenModeAdjust(ByteBuffer _bb, ISubScreenModeAdjust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033CA0 RID: 212128 RVA: 0x006F8561 File Offset: 0x006F6761
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033CA1 RID: 212129 RVA: 0x006F8570 File Offset: 0x006F6770
		public ISubScreenModeAdjust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8C7 RID: 55495
		// (get) Token: 0x06033CA2 RID: 212130 RVA: 0x006F8580 File Offset: 0x006F6780
		public ESubScreenOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESubScreenOperationType.Init;
				}
				return (ESubScreenOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033CA3 RID: 212131 RVA: 0x006F85BC File Offset: 0x006F67BC
		public ISetSubScreenData? AdjustConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetSubScreenData?(default(ISetSubScreenData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D8C8 RID: 55496
		// (get) Token: 0x06033CA4 RID: 212132 RVA: 0x006F861C File Offset: 0x006F681C
		public int AdjustConfigsLength
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

		// Token: 0x06033CA5 RID: 212133 RVA: 0x006F8647 File Offset: 0x006F6847
		public static Offset<ISubScreenModeAdjust> CreateISubScreenModeAdjust(FlatBufferBuilder builder, ESubScreenOperationType Type = ESubScreenOperationType.Init, VectorOffset AdjustConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISubScreenModeAdjust.AddAdjustConfigs(builder, AdjustConfigsOffset);
			ISubScreenModeAdjust.AddType(builder, Type);
			return ISubScreenModeAdjust.EndISubScreenModeAdjust(builder);
		}

		// Token: 0x06033CA6 RID: 212134 RVA: 0x006F8664 File Offset: 0x006F6864
		public static void StartISubScreenModeAdjust(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033CA7 RID: 212135 RVA: 0x006F866D File Offset: 0x006F686D
		public static void AddType(FlatBufferBuilder builder, ESubScreenOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033CA8 RID: 212136 RVA: 0x006F8678 File Offset: 0x006F6878
		public static void AddAdjustConfigs(FlatBufferBuilder builder, VectorOffset adjustConfigsOffset)
		{
			builder.AddOffset(1, adjustConfigsOffset.Value, 0);
		}

		// Token: 0x06033CA9 RID: 212137 RVA: 0x006F8688 File Offset: 0x006F6888
		public static VectorOffset CreateAdjustConfigsVector(FlatBufferBuilder builder, Offset<ISetSubScreenData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033CAA RID: 212138 RVA: 0x006F86C8 File Offset: 0x006F68C8
		public static VectorOffset CreateAdjustConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISetSubScreenData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetSubScreenData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033CAB RID: 212139 RVA: 0x006F86E2 File Offset: 0x006F68E2
		public static VectorOffset CreateAdjustConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetSubScreenData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetSubScreenData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033CAC RID: 212140 RVA: 0x006F8700 File Offset: 0x006F6900
		public static VectorOffset CreateAdjustConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetSubScreenData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033CAD RID: 212141 RVA: 0x006F8719 File Offset: 0x006F6919
		public static void StartAdjustConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033CAE RID: 212142 RVA: 0x006F8724 File Offset: 0x006F6924
		public static Offset<ISubScreenModeAdjust> EndISubScreenModeAdjust(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenModeAdjust>(builder.EndTable());
		}

		// Token: 0x06033CAF RID: 212143 RVA: 0x006F8734 File Offset: 0x006F6934
		public ISubScreenModeAdjustT UnPack()
		{
			ISubScreenModeAdjustT subScreenModeAdjustT = new ISubScreenModeAdjustT();
			this.UnPackTo(subScreenModeAdjustT);
			return subScreenModeAdjustT;
		}

		// Token: 0x06033CB0 RID: 212144 RVA: 0x006F8750 File Offset: 0x006F6950
		public void UnPackTo(ISubScreenModeAdjustT _o)
		{
			_o.Type = this.Type;
			_o.AdjustConfigs = new List<ISetSubScreenDataT>();
			for (int i = 0; i < this.AdjustConfigsLength; i++)
			{
				_o.AdjustConfigs.Add((this.AdjustConfigs(i) != null) ? this.AdjustConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06033CB1 RID: 212145 RVA: 0x006F87BC File Offset: 0x006F69BC
		public static Offset<ISubScreenModeAdjust> Pack(FlatBufferBuilder builder, ISubScreenModeAdjustT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenModeAdjust>);
			}
			VectorOffset adjustConfigsOffset = default(VectorOffset);
			if (_o.AdjustConfigs != null)
			{
				Offset<ISetSubScreenData>[] array = new Offset<ISetSubScreenData>[_o.AdjustConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISetSubScreenData.Pack(builder, _o.AdjustConfigs[i]);
				}
				adjustConfigsOffset = ISubScreenModeAdjust.CreateAdjustConfigsVector(builder, array);
			}
			return ISubScreenModeAdjust.CreateISubScreenModeAdjust(builder, _o.Type, adjustConfigsOffset);
		}

		// Token: 0x04011CF9 RID: 72953
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067FE RID: 26622
	public struct IFlowDefineNpcGroupPerform : IFlatbufferObject
	{
		// Token: 0x1700C59B RID: 50587
		// (get) Token: 0x0602E5B3 RID: 189875 RVA: 0x00653C7D File Offset: 0x00651E7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E5B4 RID: 189876 RVA: 0x00653C8A File Offset: 0x00651E8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E5B5 RID: 189877 RVA: 0x00653C94 File Offset: 0x00651E94
		public static IFlowDefineNpcGroupPerform GetRootAsIFlowDefineNpcGroupPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcGroupPerform.GetRootAsIFlowDefineNpcGroupPerform(_bb, default(IFlowDefineNpcGroupPerform));
		}

		// Token: 0x0602E5B6 RID: 189878 RVA: 0x00653CB0 File Offset: 0x00651EB0
		public static IFlowDefineNpcGroupPerform GetRootAsIFlowDefineNpcGroupPerform(ByteBuffer _bb, IFlowDefineNpcGroupPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E5B7 RID: 189879 RVA: 0x00653CCD File Offset: 0x00651ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E5B8 RID: 189880 RVA: 0x00653CDC File Offset: 0x00651EDC
		public IFlowDefineNpcGroupPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C59C RID: 50588
		// (get) Token: 0x0602E5B9 RID: 189881 RVA: 0x00653CEC File Offset: 0x00651EEC
		public TFlowDefineNpcGroupPerformType PerformTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TFlowDefineNpcGroupPerformType.NONE;
				}
				return (TFlowDefineNpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E5BA RID: 189882 RVA: 0x00653D28 File Offset: 0x00651F28
		public TTable? PerformType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E5BB RID: 189883 RVA: 0x00653D6C File Offset: 0x00651F6C
		public IFlowDefineNpcCancelMotorcycleSharingPerform PerformTypeAsIFlowDefineNpcCancelMotorcycleSharingPerform()
		{
			return this.PerformType<IFlowDefineNpcCancelMotorcycleSharingPerform>().Value;
		}

		// Token: 0x0602E5BC RID: 189884 RVA: 0x00653D88 File Offset: 0x00651F88
		public IFlowDefineNpcCancelSupportedWalkingPerform PerformTypeAsIFlowDefineNpcCancelSupportedWalkingPerform()
		{
			return this.PerformType<IFlowDefineNpcCancelSupportedWalkingPerform>().Value;
		}

		// Token: 0x0602E5BD RID: 189885 RVA: 0x00653DA4 File Offset: 0x00651FA4
		public IFlowDefineNpcHandInHandPerform PerformTypeAsIFlowDefineNpcHandInHandPerform()
		{
			return this.PerformType<IFlowDefineNpcHandInHandPerform>().Value;
		}

		// Token: 0x0602E5BE RID: 189886 RVA: 0x00653DC0 File Offset: 0x00651FC0
		public IFlowDefineNpcMotorcycleSharingPerform PerformTypeAsIFlowDefineNpcMotorcycleSharingPerform()
		{
			return this.PerformType<IFlowDefineNpcMotorcycleSharingPerform>().Value;
		}

		// Token: 0x0602E5BF RID: 189887 RVA: 0x00653DDC File Offset: 0x00651FDC
		public IFlowDefineNpcSupportedWalkingPerform PerformTypeAsIFlowDefineNpcSupportedWalkingPerform()
		{
			return this.PerformType<IFlowDefineNpcSupportedWalkingPerform>().Value;
		}

		// Token: 0x0602E5C0 RID: 189888 RVA: 0x00653DF7 File Offset: 0x00651FF7
		public static Offset<IFlowDefineNpcGroupPerform> CreateIFlowDefineNpcGroupPerform(FlatBufferBuilder builder, TFlowDefineNpcGroupPerformType PerformType_type = TFlowDefineNpcGroupPerformType.NONE, int PerformTypeOffset = 0)
		{
			builder.StartTable(2);
			IFlowDefineNpcGroupPerform.AddPerformType(builder, PerformTypeOffset);
			IFlowDefineNpcGroupPerform.AddPerformTypeType(builder, PerformType_type);
			return IFlowDefineNpcGroupPerform.EndIFlowDefineNpcGroupPerform(builder);
		}

		// Token: 0x0602E5C1 RID: 189889 RVA: 0x00653E14 File Offset: 0x00652014
		public static void StartIFlowDefineNpcGroupPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E5C2 RID: 189890 RVA: 0x00653E1D File Offset: 0x0065201D
		public static void AddPerformTypeType(FlatBufferBuilder builder, TFlowDefineNpcGroupPerformType performTypeType)
		{
			builder.AddByte(0, (byte)performTypeType, 0);
		}

		// Token: 0x0602E5C3 RID: 189891 RVA: 0x00653E28 File Offset: 0x00652028
		public static void AddPerformType(FlatBufferBuilder builder, int performTypeOffset)
		{
			builder.AddOffset(1, performTypeOffset, 0);
		}

		// Token: 0x0602E5C4 RID: 189892 RVA: 0x00653E33 File Offset: 0x00652033
		public static Offset<IFlowDefineNpcGroupPerform> EndIFlowDefineNpcGroupPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcGroupPerform>(builder.EndTable());
		}

		// Token: 0x0602E5C5 RID: 189893 RVA: 0x00653E40 File Offset: 0x00652040
		public IFlowDefineNpcGroupPerformT UnPack()
		{
			IFlowDefineNpcGroupPerformT flowDefineNpcGroupPerformT = new IFlowDefineNpcGroupPerformT();
			this.UnPackTo(flowDefineNpcGroupPerformT);
			return flowDefineNpcGroupPerformT;
		}

		// Token: 0x0602E5C6 RID: 189894 RVA: 0x00653E5C File Offset: 0x0065205C
		public void UnPackTo(IFlowDefineNpcGroupPerformT _o)
		{
			_o.PerformType = new TFlowDefineNpcGroupPerformTypeUnion();
			_o.PerformType.Type = this.PerformTypeType;
			switch (this.PerformTypeType)
			{
			case TFlowDefineNpcGroupPerformType.IFlowDefineNpcCancelMotorcycleSharingPerform:
				_o.PerformType.Value = ((this.PerformType<IFlowDefineNpcCancelMotorcycleSharingPerform>() != null) ? this.PerformType<IFlowDefineNpcCancelMotorcycleSharingPerform>().Value.UnPack() : null);
				return;
			case TFlowDefineNpcGroupPerformType.IFlowDefineNpcCancelSupportedWalkingPerform:
				_o.PerformType.Value = ((this.PerformType<IFlowDefineNpcCancelSupportedWalkingPerform>() != null) ? this.PerformType<IFlowDefineNpcCancelSupportedWalkingPerform>().Value.UnPack() : null);
				return;
			case TFlowDefineNpcGroupPerformType.IFlowDefineNpcHandInHandPerform:
				_o.PerformType.Value = ((this.PerformType<IFlowDefineNpcHandInHandPerform>() != null) ? this.PerformType<IFlowDefineNpcHandInHandPerform>().Value.UnPack() : null);
				return;
			case TFlowDefineNpcGroupPerformType.IFlowDefineNpcMotorcycleSharingPerform:
				_o.PerformType.Value = ((this.PerformType<IFlowDefineNpcMotorcycleSharingPerform>() != null) ? this.PerformType<IFlowDefineNpcMotorcycleSharingPerform>().Value.UnPack() : null);
				return;
			case TFlowDefineNpcGroupPerformType.IFlowDefineNpcSupportedWalkingPerform:
				_o.PerformType.Value = ((this.PerformType<IFlowDefineNpcSupportedWalkingPerform>() != null) ? this.PerformType<IFlowDefineNpcSupportedWalkingPerform>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602E5C7 RID: 189895 RVA: 0x00653FBC File Offset: 0x006521BC
		public static Offset<IFlowDefineNpcGroupPerform> Pack(FlatBufferBuilder builder, IFlowDefineNpcGroupPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcGroupPerform>);
			}
			TFlowDefineNpcGroupPerformType performType_type = (_o.PerformType == null) ? TFlowDefineNpcGroupPerformType.NONE : _o.PerformType.Type;
			int performTypeOffset = (_o.PerformType == null) ? 0 : TFlowDefineNpcGroupPerformTypeUnion.Pack(builder, _o.PerformType);
			return IFlowDefineNpcGroupPerform.CreateIFlowDefineNpcGroupPerform(builder, performType_type, performTypeOffset);
		}

		// Token: 0x04010F1D RID: 69405
		private Table __p;
	}
}

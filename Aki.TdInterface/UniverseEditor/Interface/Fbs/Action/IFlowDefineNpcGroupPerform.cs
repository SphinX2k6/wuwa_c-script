using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7E RID: 28286
	public struct IFlowDefineNpcGroupPerform : IFlatbufferObject
	{
		// Token: 0x1700CF51 RID: 53073
		// (get) Token: 0x06030DF9 RID: 200185 RVA: 0x006A13C1 File Offset: 0x0069F5C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030DFA RID: 200186 RVA: 0x006A13CE File Offset: 0x0069F5CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030DFB RID: 200187 RVA: 0x006A13D8 File Offset: 0x0069F5D8
		public static IFlowDefineNpcGroupPerform GetRootAsIFlowDefineNpcGroupPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcGroupPerform.GetRootAsIFlowDefineNpcGroupPerform(_bb, default(IFlowDefineNpcGroupPerform));
		}

		// Token: 0x06030DFC RID: 200188 RVA: 0x006A13F4 File Offset: 0x0069F5F4
		public static IFlowDefineNpcGroupPerform GetRootAsIFlowDefineNpcGroupPerform(ByteBuffer _bb, IFlowDefineNpcGroupPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030DFD RID: 200189 RVA: 0x006A1411 File Offset: 0x0069F611
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030DFE RID: 200190 RVA: 0x006A1420 File Offset: 0x0069F620
		public IFlowDefineNpcGroupPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF52 RID: 53074
		// (get) Token: 0x06030DFF RID: 200191 RVA: 0x006A1430 File Offset: 0x0069F630
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

		// Token: 0x06030E00 RID: 200192 RVA: 0x006A146C File Offset: 0x0069F66C
		public TTable? PerformType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030E01 RID: 200193 RVA: 0x006A14B0 File Offset: 0x0069F6B0
		public IFlowDefineNpcCancelMotorcycleSharingPerform PerformTypeAsIFlowDefineNpcCancelMotorcycleSharingPerform()
		{
			return this.PerformType<IFlowDefineNpcCancelMotorcycleSharingPerform>().Value;
		}

		// Token: 0x06030E02 RID: 200194 RVA: 0x006A14CC File Offset: 0x0069F6CC
		public IFlowDefineNpcCancelSupportedWalkingPerform PerformTypeAsIFlowDefineNpcCancelSupportedWalkingPerform()
		{
			return this.PerformType<IFlowDefineNpcCancelSupportedWalkingPerform>().Value;
		}

		// Token: 0x06030E03 RID: 200195 RVA: 0x006A14E8 File Offset: 0x0069F6E8
		public IFlowDefineNpcHandInHandPerform PerformTypeAsIFlowDefineNpcHandInHandPerform()
		{
			return this.PerformType<IFlowDefineNpcHandInHandPerform>().Value;
		}

		// Token: 0x06030E04 RID: 200196 RVA: 0x006A1504 File Offset: 0x0069F704
		public IFlowDefineNpcMotorcycleSharingPerform PerformTypeAsIFlowDefineNpcMotorcycleSharingPerform()
		{
			return this.PerformType<IFlowDefineNpcMotorcycleSharingPerform>().Value;
		}

		// Token: 0x06030E05 RID: 200197 RVA: 0x006A1520 File Offset: 0x0069F720
		public IFlowDefineNpcSupportedWalkingPerform PerformTypeAsIFlowDefineNpcSupportedWalkingPerform()
		{
			return this.PerformType<IFlowDefineNpcSupportedWalkingPerform>().Value;
		}

		// Token: 0x06030E06 RID: 200198 RVA: 0x006A153B File Offset: 0x0069F73B
		public static Offset<IFlowDefineNpcGroupPerform> CreateIFlowDefineNpcGroupPerform(FlatBufferBuilder builder, TFlowDefineNpcGroupPerformType PerformType_type = TFlowDefineNpcGroupPerformType.NONE, int PerformTypeOffset = 0)
		{
			builder.StartTable(2);
			IFlowDefineNpcGroupPerform.AddPerformType(builder, PerformTypeOffset);
			IFlowDefineNpcGroupPerform.AddPerformTypeType(builder, PerformType_type);
			return IFlowDefineNpcGroupPerform.EndIFlowDefineNpcGroupPerform(builder);
		}

		// Token: 0x06030E07 RID: 200199 RVA: 0x006A1558 File Offset: 0x0069F758
		public static void StartIFlowDefineNpcGroupPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030E08 RID: 200200 RVA: 0x006A1561 File Offset: 0x0069F761
		public static void AddPerformTypeType(FlatBufferBuilder builder, TFlowDefineNpcGroupPerformType performTypeType)
		{
			builder.AddByte(0, (byte)performTypeType, 0);
		}

		// Token: 0x06030E09 RID: 200201 RVA: 0x006A156C File Offset: 0x0069F76C
		public static void AddPerformType(FlatBufferBuilder builder, int performTypeOffset)
		{
			builder.AddOffset(1, performTypeOffset, 0);
		}

		// Token: 0x06030E0A RID: 200202 RVA: 0x006A1577 File Offset: 0x0069F777
		public static Offset<IFlowDefineNpcGroupPerform> EndIFlowDefineNpcGroupPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcGroupPerform>(builder.EndTable());
		}

		// Token: 0x06030E0B RID: 200203 RVA: 0x006A1584 File Offset: 0x0069F784
		public IFlowDefineNpcGroupPerformT UnPack()
		{
			IFlowDefineNpcGroupPerformT flowDefineNpcGroupPerformT = new IFlowDefineNpcGroupPerformT();
			this.UnPackTo(flowDefineNpcGroupPerformT);
			return flowDefineNpcGroupPerformT;
		}

		// Token: 0x06030E0C RID: 200204 RVA: 0x006A15A0 File Offset: 0x0069F7A0
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

		// Token: 0x06030E0D RID: 200205 RVA: 0x006A1700 File Offset: 0x0069F900
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

		// Token: 0x04011D4F RID: 73039
		private Table __p;
	}
}

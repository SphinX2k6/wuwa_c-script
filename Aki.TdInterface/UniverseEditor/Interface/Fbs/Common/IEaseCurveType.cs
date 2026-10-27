using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D9A RID: 23962
	public struct IEaseCurveType : IFlatbufferObject
	{
		// Token: 0x1700B376 RID: 45942
		// (get) Token: 0x06029022 RID: 167970 RVA: 0x005A1D2A File Offset: 0x0059FF2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029023 RID: 167971 RVA: 0x005A1D37 File Offset: 0x0059FF37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029024 RID: 167972 RVA: 0x005A1D40 File Offset: 0x0059FF40
		public static IEaseCurveType GetRootAsIEaseCurveType(ByteBuffer _bb)
		{
			return IEaseCurveType.GetRootAsIEaseCurveType(_bb, default(IEaseCurveType));
		}

		// Token: 0x06029025 RID: 167973 RVA: 0x005A1D5C File Offset: 0x0059FF5C
		public static IEaseCurveType GetRootAsIEaseCurveType(ByteBuffer _bb, IEaseCurveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029026 RID: 167974 RVA: 0x005A1D79 File Offset: 0x0059FF79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029027 RID: 167975 RVA: 0x005A1D88 File Offset: 0x0059FF88
		public IEaseCurveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B377 RID: 45943
		// (get) Token: 0x06029028 RID: 167976 RVA: 0x005A1D98 File Offset: 0x0059FF98
		public EEaseCurveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEaseCurveType.Preset;
				}
				return (EEaseCurveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029029 RID: 167977 RVA: 0x005A1DD4 File Offset: 0x0059FFD4
		public static Offset<IEaseCurveType> CreateIEaseCurveType(FlatBufferBuilder builder, EEaseCurveType Type = EEaseCurveType.Preset)
		{
			builder.StartTable(1);
			IEaseCurveType.AddType(builder, Type);
			return IEaseCurveType.EndIEaseCurveType(builder);
		}

		// Token: 0x0602902A RID: 167978 RVA: 0x005A1DEA File Offset: 0x0059FFEA
		public static void StartIEaseCurveType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602902B RID: 167979 RVA: 0x005A1DF3 File Offset: 0x0059FFF3
		public static void AddType(FlatBufferBuilder builder, EEaseCurveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602902C RID: 167980 RVA: 0x005A1DFE File Offset: 0x0059FFFE
		public static Offset<IEaseCurveType> EndIEaseCurveType(FlatBufferBuilder builder)
		{
			return new Offset<IEaseCurveType>(builder.EndTable());
		}

		// Token: 0x0602902D RID: 167981 RVA: 0x005A1E0C File Offset: 0x005A000C
		public IEaseCurveTypeT UnPack()
		{
			IEaseCurveTypeT easeCurveTypeT = new IEaseCurveTypeT();
			this.UnPackTo(easeCurveTypeT);
			return easeCurveTypeT;
		}

		// Token: 0x0602902E RID: 167982 RVA: 0x005A1E27 File Offset: 0x005A0027
		public void UnPackTo(IEaseCurveTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602902F RID: 167983 RVA: 0x005A1E38 File Offset: 0x005A0038
		public static Offset<IEaseCurveType> Pack(FlatBufferBuilder builder, IEaseCurveTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEaseCurveType>);
			}
			return IEaseCurveType.CreateIEaseCurveType(builder, _o.Type);
		}

		// Token: 0x0400F76E RID: 63342
		private Table __p;
	}
}

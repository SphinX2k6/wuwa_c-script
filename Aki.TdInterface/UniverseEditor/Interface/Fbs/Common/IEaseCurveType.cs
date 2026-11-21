using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063D7 RID: 25559
	public struct IEaseCurveType : IFlatbufferObject
	{
		// Token: 0x1700BCDC RID: 48348
		// (get) Token: 0x0602B6AC RID: 177836 RVA: 0x005EAA5A File Offset: 0x005E8C5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B6AD RID: 177837 RVA: 0x005EAA67 File Offset: 0x005E8C67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B6AE RID: 177838 RVA: 0x005EAA70 File Offset: 0x005E8C70
		public static IEaseCurveType GetRootAsIEaseCurveType(ByteBuffer _bb)
		{
			return IEaseCurveType.GetRootAsIEaseCurveType(_bb, default(IEaseCurveType));
		}

		// Token: 0x0602B6AF RID: 177839 RVA: 0x005EAA8C File Offset: 0x005E8C8C
		public static IEaseCurveType GetRootAsIEaseCurveType(ByteBuffer _bb, IEaseCurveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B6B0 RID: 177840 RVA: 0x005EAAA9 File Offset: 0x005E8CA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B6B1 RID: 177841 RVA: 0x005EAAB8 File Offset: 0x005E8CB8
		public IEaseCurveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCDD RID: 48349
		// (get) Token: 0x0602B6B2 RID: 177842 RVA: 0x005EAAC8 File Offset: 0x005E8CC8
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

		// Token: 0x0602B6B3 RID: 177843 RVA: 0x005EAB04 File Offset: 0x005E8D04
		public static Offset<IEaseCurveType> CreateIEaseCurveType(FlatBufferBuilder builder, EEaseCurveType Type = EEaseCurveType.Preset)
		{
			builder.StartTable(1);
			IEaseCurveType.AddType(builder, Type);
			return IEaseCurveType.EndIEaseCurveType(builder);
		}

		// Token: 0x0602B6B4 RID: 177844 RVA: 0x005EAB1A File Offset: 0x005E8D1A
		public static void StartIEaseCurveType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B6B5 RID: 177845 RVA: 0x005EAB23 File Offset: 0x005E8D23
		public static void AddType(FlatBufferBuilder builder, EEaseCurveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B6B6 RID: 177846 RVA: 0x005EAB2E File Offset: 0x005E8D2E
		public static Offset<IEaseCurveType> EndIEaseCurveType(FlatBufferBuilder builder)
		{
			return new Offset<IEaseCurveType>(builder.EndTable());
		}

		// Token: 0x0602B6B7 RID: 177847 RVA: 0x005EAB3C File Offset: 0x005E8D3C
		public IEaseCurveTypeT UnPack()
		{
			IEaseCurveTypeT easeCurveTypeT = new IEaseCurveTypeT();
			this.UnPackTo(easeCurveTypeT);
			return easeCurveTypeT;
		}

		// Token: 0x0602B6B8 RID: 177848 RVA: 0x005EAB57 File Offset: 0x005E8D57
		public void UnPackTo(IEaseCurveTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B6B9 RID: 177849 RVA: 0x005EAB68 File Offset: 0x005E8D68
		public static Offset<IEaseCurveType> Pack(FlatBufferBuilder builder, IEaseCurveTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEaseCurveType>);
			}
			return IEaseCurveType.CreateIEaseCurveType(builder, _o.Type);
		}

		// Token: 0x040104C9 RID: 66761
		private Table __p;
	}
}

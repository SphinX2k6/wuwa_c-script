using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063D1 RID: 25553
	public struct IEaseCurveCustom : IFlatbufferObject
	{
		// Token: 0x1700BCD2 RID: 48338
		// (get) Token: 0x0602B67E RID: 177790 RVA: 0x005EA626 File Offset: 0x005E8826
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B67F RID: 177791 RVA: 0x005EA633 File Offset: 0x005E8833
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B680 RID: 177792 RVA: 0x005EA63C File Offset: 0x005E883C
		public static IEaseCurveCustom GetRootAsIEaseCurveCustom(ByteBuffer _bb)
		{
			return IEaseCurveCustom.GetRootAsIEaseCurveCustom(_bb, default(IEaseCurveCustom));
		}

		// Token: 0x0602B681 RID: 177793 RVA: 0x005EA658 File Offset: 0x005E8858
		public static IEaseCurveCustom GetRootAsIEaseCurveCustom(ByteBuffer _bb, IEaseCurveCustom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B682 RID: 177794 RVA: 0x005EA675 File Offset: 0x005E8875
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B683 RID: 177795 RVA: 0x005EA684 File Offset: 0x005E8884
		public IEaseCurveCustom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCD3 RID: 48339
		// (get) Token: 0x0602B684 RID: 177796 RVA: 0x005EA694 File Offset: 0x005E8894
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

		// Token: 0x1700BCD4 RID: 48340
		// (get) Token: 0x0602B685 RID: 177797 RVA: 0x005EA6D0 File Offset: 0x005E88D0
		public string CustomCurve
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B686 RID: 177798 RVA: 0x005EA707 File Offset: 0x005E8907
		public Span<byte> GetCustomCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B687 RID: 177799 RVA: 0x005EA716 File Offset: 0x005E8916
		public byte[] GetCustomCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602B688 RID: 177800 RVA: 0x005EA724 File Offset: 0x005E8924
		public static Offset<IEaseCurveCustom> CreateIEaseCurveCustom(FlatBufferBuilder builder, EEaseCurveType Type = EEaseCurveType.Preset, StringOffset CustomCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEaseCurveCustom.AddCustomCurve(builder, CustomCurveOffset);
			IEaseCurveCustom.AddType(builder, Type);
			return IEaseCurveCustom.EndIEaseCurveCustom(builder);
		}

		// Token: 0x0602B689 RID: 177801 RVA: 0x005EA741 File Offset: 0x005E8941
		public static void StartIEaseCurveCustom(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B68A RID: 177802 RVA: 0x005EA74A File Offset: 0x005E894A
		public static void AddType(FlatBufferBuilder builder, EEaseCurveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B68B RID: 177803 RVA: 0x005EA755 File Offset: 0x005E8955
		public static void AddCustomCurve(FlatBufferBuilder builder, StringOffset customCurveOffset)
		{
			builder.AddOffset(1, customCurveOffset.Value, 0);
		}

		// Token: 0x0602B68C RID: 177804 RVA: 0x005EA765 File Offset: 0x005E8965
		public static Offset<IEaseCurveCustom> EndIEaseCurveCustom(FlatBufferBuilder builder)
		{
			return new Offset<IEaseCurveCustom>(builder.EndTable());
		}

		// Token: 0x0602B68D RID: 177805 RVA: 0x005EA774 File Offset: 0x005E8974
		public IEaseCurveCustomT UnPack()
		{
			IEaseCurveCustomT easeCurveCustomT = new IEaseCurveCustomT();
			this.UnPackTo(easeCurveCustomT);
			return easeCurveCustomT;
		}

		// Token: 0x0602B68E RID: 177806 RVA: 0x005EA78F File Offset: 0x005E898F
		public void UnPackTo(IEaseCurveCustomT _o)
		{
			_o.Type = this.Type;
			_o.CustomCurve = this.CustomCurve;
		}

		// Token: 0x0602B68F RID: 177807 RVA: 0x005EA7AC File Offset: 0x005E89AC
		public static Offset<IEaseCurveCustom> Pack(FlatBufferBuilder builder, IEaseCurveCustomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEaseCurveCustom>);
			}
			StringOffset customCurveOffset = (_o.CustomCurve == null) ? default(StringOffset) : builder.CreateString(_o.CustomCurve);
			return IEaseCurveCustom.CreateIEaseCurveCustom(builder, _o.Type, customCurveOffset);
		}

		// Token: 0x040104C3 RID: 66755
		private Table __p;
	}
}

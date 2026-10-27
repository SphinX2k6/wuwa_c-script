using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D7C RID: 23932
	public struct IConstraintValueMin : IFlatbufferObject
	{
		// Token: 0x1700B33F RID: 45887
		// (get) Token: 0x06028F10 RID: 167696 RVA: 0x0059F852 File Offset: 0x0059DA52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028F11 RID: 167697 RVA: 0x0059F85F File Offset: 0x0059DA5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028F12 RID: 167698 RVA: 0x0059F868 File Offset: 0x0059DA68
		public static IConstraintValueMin GetRootAsIConstraintValueMin(ByteBuffer _bb)
		{
			return IConstraintValueMin.GetRootAsIConstraintValueMin(_bb, default(IConstraintValueMin));
		}

		// Token: 0x06028F13 RID: 167699 RVA: 0x0059F884 File Offset: 0x0059DA84
		public static IConstraintValueMin GetRootAsIConstraintValueMin(ByteBuffer _bb, IConstraintValueMin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028F14 RID: 167700 RVA: 0x0059F8A1 File Offset: 0x0059DAA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028F15 RID: 167701 RVA: 0x0059F8B0 File Offset: 0x0059DAB0
		public IConstraintValueMin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B340 RID: 45888
		// (get) Token: 0x06028F16 RID: 167702 RVA: 0x0059F8C0 File Offset: 0x0059DAC0
		public EConstraintValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConstraintValueType.Max;
				}
				return (EConstraintValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B341 RID: 45889
		// (get) Token: 0x06028F17 RID: 167703 RVA: 0x0059F8FC File Offset: 0x0059DAFC
		public float MinValue
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028F18 RID: 167704 RVA: 0x0059F93C File Offset: 0x0059DB3C
		public static Offset<IConstraintValueMin> CreateIConstraintValueMin(FlatBufferBuilder builder, EConstraintValueType Type = EConstraintValueType.Max, float MinValue = 0f)
		{
			builder.StartTable(2);
			IConstraintValueMin.AddMinValue(builder, MinValue);
			IConstraintValueMin.AddType(builder, Type);
			return IConstraintValueMin.EndIConstraintValueMin(builder);
		}

		// Token: 0x06028F19 RID: 167705 RVA: 0x0059F959 File Offset: 0x0059DB59
		public static void StartIConstraintValueMin(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028F1A RID: 167706 RVA: 0x0059F962 File Offset: 0x0059DB62
		public static void AddType(FlatBufferBuilder builder, EConstraintValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028F1B RID: 167707 RVA: 0x0059F96D File Offset: 0x0059DB6D
		public static void AddMinValue(FlatBufferBuilder builder, float minValue)
		{
			builder.AddFloat(1, minValue, 0.0);
		}

		// Token: 0x06028F1C RID: 167708 RVA: 0x0059F980 File Offset: 0x0059DB80
		public static Offset<IConstraintValueMin> EndIConstraintValueMin(FlatBufferBuilder builder)
		{
			return new Offset<IConstraintValueMin>(builder.EndTable());
		}

		// Token: 0x06028F1D RID: 167709 RVA: 0x0059F990 File Offset: 0x0059DB90
		public IConstraintValueMinT UnPack()
		{
			IConstraintValueMinT constraintValueMinT = new IConstraintValueMinT();
			this.UnPackTo(constraintValueMinT);
			return constraintValueMinT;
		}

		// Token: 0x06028F1E RID: 167710 RVA: 0x0059F9AB File Offset: 0x0059DBAB
		public void UnPackTo(IConstraintValueMinT _o)
		{
			_o.Type = this.Type;
			_o.MinValue = this.MinValue;
		}

		// Token: 0x06028F1F RID: 167711 RVA: 0x0059F9C8 File Offset: 0x0059DBC8
		public static Offset<IConstraintValueMin> Pack(FlatBufferBuilder builder, IConstraintValueMinT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstraintValueMin>);
			}
			return IConstraintValueMin.CreateIConstraintValueMin(builder, _o.Type, _o.MinValue);
		}

		// Token: 0x0400F747 RID: 63303
		private Table __p;
	}
}

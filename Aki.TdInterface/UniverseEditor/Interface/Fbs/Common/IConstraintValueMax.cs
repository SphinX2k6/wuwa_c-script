using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063B6 RID: 25526
	public struct IConstraintValueMax : IFlatbufferObject
	{
		// Token: 0x1700BCA0 RID: 48288
		// (get) Token: 0x0602B584 RID: 177540 RVA: 0x005E8374 File Offset: 0x005E6574
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B585 RID: 177541 RVA: 0x005E8381 File Offset: 0x005E6581
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B586 RID: 177542 RVA: 0x005E8388 File Offset: 0x005E6588
		public static IConstraintValueMax GetRootAsIConstraintValueMax(ByteBuffer _bb)
		{
			return IConstraintValueMax.GetRootAsIConstraintValueMax(_bb, default(IConstraintValueMax));
		}

		// Token: 0x0602B587 RID: 177543 RVA: 0x005E83A4 File Offset: 0x005E65A4
		public static IConstraintValueMax GetRootAsIConstraintValueMax(ByteBuffer _bb, IConstraintValueMax obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B588 RID: 177544 RVA: 0x005E83C1 File Offset: 0x005E65C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B589 RID: 177545 RVA: 0x005E83D0 File Offset: 0x005E65D0
		public IConstraintValueMax __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCA1 RID: 48289
		// (get) Token: 0x0602B58A RID: 177546 RVA: 0x005E83E0 File Offset: 0x005E65E0
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

		// Token: 0x1700BCA2 RID: 48290
		// (get) Token: 0x0602B58B RID: 177547 RVA: 0x005E841C File Offset: 0x005E661C
		public float MaxValue
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

		// Token: 0x0602B58C RID: 177548 RVA: 0x005E845C File Offset: 0x005E665C
		public static Offset<IConstraintValueMax> CreateIConstraintValueMax(FlatBufferBuilder builder, EConstraintValueType Type = EConstraintValueType.Max, float MaxValue = 0f)
		{
			builder.StartTable(2);
			IConstraintValueMax.AddMaxValue(builder, MaxValue);
			IConstraintValueMax.AddType(builder, Type);
			return IConstraintValueMax.EndIConstraintValueMax(builder);
		}

		// Token: 0x0602B58D RID: 177549 RVA: 0x005E8479 File Offset: 0x005E6679
		public static void StartIConstraintValueMax(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B58E RID: 177550 RVA: 0x005E8482 File Offset: 0x005E6682
		public static void AddType(FlatBufferBuilder builder, EConstraintValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B58F RID: 177551 RVA: 0x005E848D File Offset: 0x005E668D
		public static void AddMaxValue(FlatBufferBuilder builder, float maxValue)
		{
			builder.AddFloat(1, maxValue, 0.0);
		}

		// Token: 0x0602B590 RID: 177552 RVA: 0x005E84A0 File Offset: 0x005E66A0
		public static Offset<IConstraintValueMax> EndIConstraintValueMax(FlatBufferBuilder builder)
		{
			return new Offset<IConstraintValueMax>(builder.EndTable());
		}

		// Token: 0x0602B591 RID: 177553 RVA: 0x005E84B0 File Offset: 0x005E66B0
		public IConstraintValueMaxT UnPack()
		{
			IConstraintValueMaxT constraintValueMaxT = new IConstraintValueMaxT();
			this.UnPackTo(constraintValueMaxT);
			return constraintValueMaxT;
		}

		// Token: 0x0602B592 RID: 177554 RVA: 0x005E84CB File Offset: 0x005E66CB
		public void UnPackTo(IConstraintValueMaxT _o)
		{
			_o.Type = this.Type;
			_o.MaxValue = this.MaxValue;
		}

		// Token: 0x0602B593 RID: 177555 RVA: 0x005E84E8 File Offset: 0x005E66E8
		public static Offset<IConstraintValueMax> Pack(FlatBufferBuilder builder, IConstraintValueMaxT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstraintValueMax>);
			}
			return IConstraintValueMax.CreateIConstraintValueMax(builder, _o.Type, _o.MaxValue);
		}

		// Token: 0x0401049F RID: 66719
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D76 RID: 23926
	public struct IConstraintValueClamp : IFlatbufferObject
	{
		// Token: 0x1700B333 RID: 45875
		// (get) Token: 0x06028EE0 RID: 167648 RVA: 0x0059F394 File Offset: 0x0059D594
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028EE1 RID: 167649 RVA: 0x0059F3A1 File Offset: 0x0059D5A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028EE2 RID: 167650 RVA: 0x0059F3A8 File Offset: 0x0059D5A8
		public static IConstraintValueClamp GetRootAsIConstraintValueClamp(ByteBuffer _bb)
		{
			return IConstraintValueClamp.GetRootAsIConstraintValueClamp(_bb, default(IConstraintValueClamp));
		}

		// Token: 0x06028EE3 RID: 167651 RVA: 0x0059F3C4 File Offset: 0x0059D5C4
		public static IConstraintValueClamp GetRootAsIConstraintValueClamp(ByteBuffer _bb, IConstraintValueClamp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028EE4 RID: 167652 RVA: 0x0059F3E1 File Offset: 0x0059D5E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028EE5 RID: 167653 RVA: 0x0059F3F0 File Offset: 0x0059D5F0
		public IConstraintValueClamp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B334 RID: 45876
		// (get) Token: 0x06028EE6 RID: 167654 RVA: 0x0059F400 File Offset: 0x0059D600
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

		// Token: 0x1700B335 RID: 45877
		// (get) Token: 0x06028EE7 RID: 167655 RVA: 0x0059F43C File Offset: 0x0059D63C
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

		// Token: 0x1700B336 RID: 45878
		// (get) Token: 0x06028EE8 RID: 167656 RVA: 0x0059F47C File Offset: 0x0059D67C
		public float MaxValue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028EE9 RID: 167657 RVA: 0x0059F4BC File Offset: 0x0059D6BC
		public static Offset<IConstraintValueClamp> CreateIConstraintValueClamp(FlatBufferBuilder builder, EConstraintValueType Type = EConstraintValueType.Max, float MinValue = 0f, float MaxValue = 0f)
		{
			builder.StartTable(3);
			IConstraintValueClamp.AddMaxValue(builder, MaxValue);
			IConstraintValueClamp.AddMinValue(builder, MinValue);
			IConstraintValueClamp.AddType(builder, Type);
			return IConstraintValueClamp.EndIConstraintValueClamp(builder);
		}

		// Token: 0x06028EEA RID: 167658 RVA: 0x0059F4E0 File Offset: 0x0059D6E0
		public static void StartIConstraintValueClamp(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028EEB RID: 167659 RVA: 0x0059F4E9 File Offset: 0x0059D6E9
		public static void AddType(FlatBufferBuilder builder, EConstraintValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028EEC RID: 167660 RVA: 0x0059F4F4 File Offset: 0x0059D6F4
		public static void AddMinValue(FlatBufferBuilder builder, float minValue)
		{
			builder.AddFloat(1, minValue, 0.0);
		}

		// Token: 0x06028EED RID: 167661 RVA: 0x0059F507 File Offset: 0x0059D707
		public static void AddMaxValue(FlatBufferBuilder builder, float maxValue)
		{
			builder.AddFloat(2, maxValue, 0.0);
		}

		// Token: 0x06028EEE RID: 167662 RVA: 0x0059F51A File Offset: 0x0059D71A
		public static Offset<IConstraintValueClamp> EndIConstraintValueClamp(FlatBufferBuilder builder)
		{
			return new Offset<IConstraintValueClamp>(builder.EndTable());
		}

		// Token: 0x06028EEF RID: 167663 RVA: 0x0059F528 File Offset: 0x0059D728
		public IConstraintValueClampT UnPack()
		{
			IConstraintValueClampT constraintValueClampT = new IConstraintValueClampT();
			this.UnPackTo(constraintValueClampT);
			return constraintValueClampT;
		}

		// Token: 0x06028EF0 RID: 167664 RVA: 0x0059F543 File Offset: 0x0059D743
		public void UnPackTo(IConstraintValueClampT _o)
		{
			_o.Type = this.Type;
			_o.MinValue = this.MinValue;
			_o.MaxValue = this.MaxValue;
		}

		// Token: 0x06028EF1 RID: 167665 RVA: 0x0059F56C File Offset: 0x0059D76C
		public static Offset<IConstraintValueClamp> Pack(FlatBufferBuilder builder, IConstraintValueClampT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstraintValueClamp>);
			}
			return IConstraintValueClamp.CreateIConstraintValueClamp(builder, _o.Type, _o.MinValue, _o.MaxValue);
		}

		// Token: 0x0400F740 RID: 63296
		private Table __p;
	}
}

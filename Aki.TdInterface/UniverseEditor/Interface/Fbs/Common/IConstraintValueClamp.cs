using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063B3 RID: 25523
	public struct IConstraintValueClamp : IFlatbufferObject
	{
		// Token: 0x1700BC99 RID: 48281
		// (get) Token: 0x0602B56A RID: 177514 RVA: 0x005E80C4 File Offset: 0x005E62C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B56B RID: 177515 RVA: 0x005E80D1 File Offset: 0x005E62D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B56C RID: 177516 RVA: 0x005E80D8 File Offset: 0x005E62D8
		public static IConstraintValueClamp GetRootAsIConstraintValueClamp(ByteBuffer _bb)
		{
			return IConstraintValueClamp.GetRootAsIConstraintValueClamp(_bb, default(IConstraintValueClamp));
		}

		// Token: 0x0602B56D RID: 177517 RVA: 0x005E80F4 File Offset: 0x005E62F4
		public static IConstraintValueClamp GetRootAsIConstraintValueClamp(ByteBuffer _bb, IConstraintValueClamp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B56E RID: 177518 RVA: 0x005E8111 File Offset: 0x005E6311
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B56F RID: 177519 RVA: 0x005E8120 File Offset: 0x005E6320
		public IConstraintValueClamp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC9A RID: 48282
		// (get) Token: 0x0602B570 RID: 177520 RVA: 0x005E8130 File Offset: 0x005E6330
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

		// Token: 0x1700BC9B RID: 48283
		// (get) Token: 0x0602B571 RID: 177521 RVA: 0x005E816C File Offset: 0x005E636C
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

		// Token: 0x1700BC9C RID: 48284
		// (get) Token: 0x0602B572 RID: 177522 RVA: 0x005E81AC File Offset: 0x005E63AC
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

		// Token: 0x0602B573 RID: 177523 RVA: 0x005E81EC File Offset: 0x005E63EC
		public static Offset<IConstraintValueClamp> CreateIConstraintValueClamp(FlatBufferBuilder builder, EConstraintValueType Type = EConstraintValueType.Max, float MinValue = 0f, float MaxValue = 0f)
		{
			builder.StartTable(3);
			IConstraintValueClamp.AddMaxValue(builder, MaxValue);
			IConstraintValueClamp.AddMinValue(builder, MinValue);
			IConstraintValueClamp.AddType(builder, Type);
			return IConstraintValueClamp.EndIConstraintValueClamp(builder);
		}

		// Token: 0x0602B574 RID: 177524 RVA: 0x005E8210 File Offset: 0x005E6410
		public static void StartIConstraintValueClamp(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B575 RID: 177525 RVA: 0x005E8219 File Offset: 0x005E6419
		public static void AddType(FlatBufferBuilder builder, EConstraintValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B576 RID: 177526 RVA: 0x005E8224 File Offset: 0x005E6424
		public static void AddMinValue(FlatBufferBuilder builder, float minValue)
		{
			builder.AddFloat(1, minValue, 0.0);
		}

		// Token: 0x0602B577 RID: 177527 RVA: 0x005E8237 File Offset: 0x005E6437
		public static void AddMaxValue(FlatBufferBuilder builder, float maxValue)
		{
			builder.AddFloat(2, maxValue, 0.0);
		}

		// Token: 0x0602B578 RID: 177528 RVA: 0x005E824A File Offset: 0x005E644A
		public static Offset<IConstraintValueClamp> EndIConstraintValueClamp(FlatBufferBuilder builder)
		{
			return new Offset<IConstraintValueClamp>(builder.EndTable());
		}

		// Token: 0x0602B579 RID: 177529 RVA: 0x005E8258 File Offset: 0x005E6458
		public IConstraintValueClampT UnPack()
		{
			IConstraintValueClampT constraintValueClampT = new IConstraintValueClampT();
			this.UnPackTo(constraintValueClampT);
			return constraintValueClampT;
		}

		// Token: 0x0602B57A RID: 177530 RVA: 0x005E8273 File Offset: 0x005E6473
		public void UnPackTo(IConstraintValueClampT _o)
		{
			_o.Type = this.Type;
			_o.MinValue = this.MinValue;
			_o.MaxValue = this.MaxValue;
		}

		// Token: 0x0602B57B RID: 177531 RVA: 0x005E829C File Offset: 0x005E649C
		public static Offset<IConstraintValueClamp> Pack(FlatBufferBuilder builder, IConstraintValueClampT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstraintValueClamp>);
			}
			return IConstraintValueClamp.CreateIConstraintValueClamp(builder, _o.Type, _o.MinValue, _o.MaxValue);
		}

		// Token: 0x0401049B RID: 66715
		private Table __p;
	}
}

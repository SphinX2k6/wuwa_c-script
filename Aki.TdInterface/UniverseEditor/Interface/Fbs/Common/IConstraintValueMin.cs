using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063B9 RID: 25529
	public struct IConstraintValueMin : IFlatbufferObject
	{
		// Token: 0x1700BCA5 RID: 48293
		// (get) Token: 0x0602B59A RID: 177562 RVA: 0x005E8582 File Offset: 0x005E6782
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B59B RID: 177563 RVA: 0x005E858F File Offset: 0x005E678F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B59C RID: 177564 RVA: 0x005E8598 File Offset: 0x005E6798
		public static IConstraintValueMin GetRootAsIConstraintValueMin(ByteBuffer _bb)
		{
			return IConstraintValueMin.GetRootAsIConstraintValueMin(_bb, default(IConstraintValueMin));
		}

		// Token: 0x0602B59D RID: 177565 RVA: 0x005E85B4 File Offset: 0x005E67B4
		public static IConstraintValueMin GetRootAsIConstraintValueMin(ByteBuffer _bb, IConstraintValueMin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B59E RID: 177566 RVA: 0x005E85D1 File Offset: 0x005E67D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B59F RID: 177567 RVA: 0x005E85E0 File Offset: 0x005E67E0
		public IConstraintValueMin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCA6 RID: 48294
		// (get) Token: 0x0602B5A0 RID: 177568 RVA: 0x005E85F0 File Offset: 0x005E67F0
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

		// Token: 0x1700BCA7 RID: 48295
		// (get) Token: 0x0602B5A1 RID: 177569 RVA: 0x005E862C File Offset: 0x005E682C
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

		// Token: 0x0602B5A2 RID: 177570 RVA: 0x005E866C File Offset: 0x005E686C
		public static Offset<IConstraintValueMin> CreateIConstraintValueMin(FlatBufferBuilder builder, EConstraintValueType Type = EConstraintValueType.Max, float MinValue = 0f)
		{
			builder.StartTable(2);
			IConstraintValueMin.AddMinValue(builder, MinValue);
			IConstraintValueMin.AddType(builder, Type);
			return IConstraintValueMin.EndIConstraintValueMin(builder);
		}

		// Token: 0x0602B5A3 RID: 177571 RVA: 0x005E8689 File Offset: 0x005E6889
		public static void StartIConstraintValueMin(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B5A4 RID: 177572 RVA: 0x005E8692 File Offset: 0x005E6892
		public static void AddType(FlatBufferBuilder builder, EConstraintValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B5A5 RID: 177573 RVA: 0x005E869D File Offset: 0x005E689D
		public static void AddMinValue(FlatBufferBuilder builder, float minValue)
		{
			builder.AddFloat(1, minValue, 0.0);
		}

		// Token: 0x0602B5A6 RID: 177574 RVA: 0x005E86B0 File Offset: 0x005E68B0
		public static Offset<IConstraintValueMin> EndIConstraintValueMin(FlatBufferBuilder builder)
		{
			return new Offset<IConstraintValueMin>(builder.EndTable());
		}

		// Token: 0x0602B5A7 RID: 177575 RVA: 0x005E86C0 File Offset: 0x005E68C0
		public IConstraintValueMinT UnPack()
		{
			IConstraintValueMinT constraintValueMinT = new IConstraintValueMinT();
			this.UnPackTo(constraintValueMinT);
			return constraintValueMinT;
		}

		// Token: 0x0602B5A8 RID: 177576 RVA: 0x005E86DB File Offset: 0x005E68DB
		public void UnPackTo(IConstraintValueMinT _o)
		{
			_o.Type = this.Type;
			_o.MinValue = this.MinValue;
		}

		// Token: 0x0602B5A9 RID: 177577 RVA: 0x005E86F8 File Offset: 0x005E68F8
		public static Offset<IConstraintValueMin> Pack(FlatBufferBuilder builder, IConstraintValueMinT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstraintValueMin>);
			}
			return IConstraintValueMin.CreateIConstraintValueMin(builder, _o.Type, _o.MinValue);
		}

		// Token: 0x040104A2 RID: 66722
		private Table __p;
	}
}

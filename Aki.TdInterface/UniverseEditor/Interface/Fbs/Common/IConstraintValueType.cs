using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063BC RID: 25532
	public struct IConstraintValueType : IFlatbufferObject
	{
		// Token: 0x1700BCAA RID: 48298
		// (get) Token: 0x0602B5B0 RID: 177584 RVA: 0x005E8792 File Offset: 0x005E6992
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B5B1 RID: 177585 RVA: 0x005E879F File Offset: 0x005E699F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B5B2 RID: 177586 RVA: 0x005E87A8 File Offset: 0x005E69A8
		public static IConstraintValueType GetRootAsIConstraintValueType(ByteBuffer _bb)
		{
			return IConstraintValueType.GetRootAsIConstraintValueType(_bb, default(IConstraintValueType));
		}

		// Token: 0x0602B5B3 RID: 177587 RVA: 0x005E87C4 File Offset: 0x005E69C4
		public static IConstraintValueType GetRootAsIConstraintValueType(ByteBuffer _bb, IConstraintValueType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B5B4 RID: 177588 RVA: 0x005E87E1 File Offset: 0x005E69E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B5B5 RID: 177589 RVA: 0x005E87F0 File Offset: 0x005E69F0
		public IConstraintValueType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCAB RID: 48299
		// (get) Token: 0x0602B5B6 RID: 177590 RVA: 0x005E8800 File Offset: 0x005E6A00
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

		// Token: 0x0602B5B7 RID: 177591 RVA: 0x005E883C File Offset: 0x005E6A3C
		public static Offset<IConstraintValueType> CreateIConstraintValueType(FlatBufferBuilder builder, EConstraintValueType Type = EConstraintValueType.Max)
		{
			builder.StartTable(1);
			IConstraintValueType.AddType(builder, Type);
			return IConstraintValueType.EndIConstraintValueType(builder);
		}

		// Token: 0x0602B5B8 RID: 177592 RVA: 0x005E8852 File Offset: 0x005E6A52
		public static void StartIConstraintValueType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B5B9 RID: 177593 RVA: 0x005E885B File Offset: 0x005E6A5B
		public static void AddType(FlatBufferBuilder builder, EConstraintValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B5BA RID: 177594 RVA: 0x005E8866 File Offset: 0x005E6A66
		public static Offset<IConstraintValueType> EndIConstraintValueType(FlatBufferBuilder builder)
		{
			return new Offset<IConstraintValueType>(builder.EndTable());
		}

		// Token: 0x0602B5BB RID: 177595 RVA: 0x005E8874 File Offset: 0x005E6A74
		public IConstraintValueTypeT UnPack()
		{
			IConstraintValueTypeT constraintValueTypeT = new IConstraintValueTypeT();
			this.UnPackTo(constraintValueTypeT);
			return constraintValueTypeT;
		}

		// Token: 0x0602B5BC RID: 177596 RVA: 0x005E888F File Offset: 0x005E6A8F
		public void UnPackTo(IConstraintValueTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B5BD RID: 177597 RVA: 0x005E88A0 File Offset: 0x005E6AA0
		public static Offset<IConstraintValueType> Pack(FlatBufferBuilder builder, IConstraintValueTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstraintValueType>);
			}
			return IConstraintValueType.CreateIConstraintValueType(builder, _o.Type);
		}

		// Token: 0x040104A5 RID: 66725
		private Table __p;
	}
}

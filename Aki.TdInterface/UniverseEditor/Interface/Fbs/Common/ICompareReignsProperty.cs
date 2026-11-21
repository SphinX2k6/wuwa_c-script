using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063B0 RID: 25520
	public struct ICompareReignsProperty : IFlatbufferObject
	{
		// Token: 0x1700BC92 RID: 48274
		// (get) Token: 0x0602B550 RID: 177488 RVA: 0x005E7E34 File Offset: 0x005E6034
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B551 RID: 177489 RVA: 0x005E7E41 File Offset: 0x005E6041
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B552 RID: 177490 RVA: 0x005E7E48 File Offset: 0x005E6048
		public static ICompareReignsProperty GetRootAsICompareReignsProperty(ByteBuffer _bb)
		{
			return ICompareReignsProperty.GetRootAsICompareReignsProperty(_bb, default(ICompareReignsProperty));
		}

		// Token: 0x0602B553 RID: 177491 RVA: 0x005E7E64 File Offset: 0x005E6064
		public static ICompareReignsProperty GetRootAsICompareReignsProperty(ByteBuffer _bb, ICompareReignsProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B554 RID: 177492 RVA: 0x005E7E81 File Offset: 0x005E6081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B555 RID: 177493 RVA: 0x005E7E90 File Offset: 0x005E6090
		public ICompareReignsProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC93 RID: 48275
		// (get) Token: 0x0602B556 RID: 177494 RVA: 0x005E7EA0 File Offset: 0x005E60A0
		public int PropertyId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC94 RID: 48276
		// (get) Token: 0x0602B557 RID: 177495 RVA: 0x005E7EDC File Offset: 0x005E60DC
		public EReignsPropertyCompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EReignsPropertyCompare.Eq;
				}
				return (EReignsPropertyCompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC95 RID: 48277
		// (get) Token: 0x0602B558 RID: 177496 RVA: 0x005E7F18 File Offset: 0x005E6118
		public int Target
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B559 RID: 177497 RVA: 0x005E7F54 File Offset: 0x005E6154
		public static Offset<ICompareReignsProperty> CreateICompareReignsProperty(FlatBufferBuilder builder, int PropertyId = 0, EReignsPropertyCompare Compare = EReignsPropertyCompare.Eq, int Target = 0)
		{
			builder.StartTable(3);
			ICompareReignsProperty.AddTarget(builder, Target);
			ICompareReignsProperty.AddPropertyId(builder, PropertyId);
			ICompareReignsProperty.AddCompare(builder, Compare);
			return ICompareReignsProperty.EndICompareReignsProperty(builder);
		}

		// Token: 0x0602B55A RID: 177498 RVA: 0x005E7F78 File Offset: 0x005E6178
		public static void StartICompareReignsProperty(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B55B RID: 177499 RVA: 0x005E7F81 File Offset: 0x005E6181
		public static void AddPropertyId(FlatBufferBuilder builder, int propertyId)
		{
			builder.AddInt(0, propertyId, 0);
		}

		// Token: 0x0602B55C RID: 177500 RVA: 0x005E7F8C File Offset: 0x005E618C
		public static void AddCompare(FlatBufferBuilder builder, EReignsPropertyCompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0602B55D RID: 177501 RVA: 0x005E7F97 File Offset: 0x005E6197
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(2, target, 0);
		}

		// Token: 0x0602B55E RID: 177502 RVA: 0x005E7FA2 File Offset: 0x005E61A2
		public static Offset<ICompareReignsProperty> EndICompareReignsProperty(FlatBufferBuilder builder)
		{
			return new Offset<ICompareReignsProperty>(builder.EndTable());
		}

		// Token: 0x0602B55F RID: 177503 RVA: 0x005E7FB0 File Offset: 0x005E61B0
		public ICompareReignsPropertyT UnPack()
		{
			ICompareReignsPropertyT compareReignsPropertyT = new ICompareReignsPropertyT();
			this.UnPackTo(compareReignsPropertyT);
			return compareReignsPropertyT;
		}

		// Token: 0x0602B560 RID: 177504 RVA: 0x005E7FCB File Offset: 0x005E61CB
		public void UnPackTo(ICompareReignsPropertyT _o)
		{
			_o.PropertyId = this.PropertyId;
			_o.Compare = this.Compare;
			_o.Target = this.Target;
		}

		// Token: 0x0602B561 RID: 177505 RVA: 0x005E7FF4 File Offset: 0x005E61F4
		public static Offset<ICompareReignsProperty> Pack(FlatBufferBuilder builder, ICompareReignsPropertyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareReignsProperty>);
			}
			return ICompareReignsProperty.CreateICompareReignsProperty(builder, _o.PropertyId, _o.Compare, _o.Target);
		}

		// Token: 0x04010497 RID: 66711
		private Table __p;
	}
}

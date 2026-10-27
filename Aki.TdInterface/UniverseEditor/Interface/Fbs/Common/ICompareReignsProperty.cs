using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D73 RID: 23923
	public struct ICompareReignsProperty : IFlatbufferObject
	{
		// Token: 0x1700B32C RID: 45868
		// (get) Token: 0x06028EC6 RID: 167622 RVA: 0x0059F102 File Offset: 0x0059D302
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028EC7 RID: 167623 RVA: 0x0059F10F File Offset: 0x0059D30F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028EC8 RID: 167624 RVA: 0x0059F118 File Offset: 0x0059D318
		public static ICompareReignsProperty GetRootAsICompareReignsProperty(ByteBuffer _bb)
		{
			return ICompareReignsProperty.GetRootAsICompareReignsProperty(_bb, default(ICompareReignsProperty));
		}

		// Token: 0x06028EC9 RID: 167625 RVA: 0x0059F134 File Offset: 0x0059D334
		public static ICompareReignsProperty GetRootAsICompareReignsProperty(ByteBuffer _bb, ICompareReignsProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028ECA RID: 167626 RVA: 0x0059F151 File Offset: 0x0059D351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028ECB RID: 167627 RVA: 0x0059F160 File Offset: 0x0059D360
		public ICompareReignsProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B32D RID: 45869
		// (get) Token: 0x06028ECC RID: 167628 RVA: 0x0059F170 File Offset: 0x0059D370
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

		// Token: 0x1700B32E RID: 45870
		// (get) Token: 0x06028ECD RID: 167629 RVA: 0x0059F1AC File Offset: 0x0059D3AC
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

		// Token: 0x1700B32F RID: 45871
		// (get) Token: 0x06028ECE RID: 167630 RVA: 0x0059F1E8 File Offset: 0x0059D3E8
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

		// Token: 0x06028ECF RID: 167631 RVA: 0x0059F224 File Offset: 0x0059D424
		public static Offset<ICompareReignsProperty> CreateICompareReignsProperty(FlatBufferBuilder builder, int PropertyId = 0, EReignsPropertyCompare Compare = EReignsPropertyCompare.Eq, int Target = 0)
		{
			builder.StartTable(3);
			ICompareReignsProperty.AddTarget(builder, Target);
			ICompareReignsProperty.AddPropertyId(builder, PropertyId);
			ICompareReignsProperty.AddCompare(builder, Compare);
			return ICompareReignsProperty.EndICompareReignsProperty(builder);
		}

		// Token: 0x06028ED0 RID: 167632 RVA: 0x0059F248 File Offset: 0x0059D448
		public static void StartICompareReignsProperty(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028ED1 RID: 167633 RVA: 0x0059F251 File Offset: 0x0059D451
		public static void AddPropertyId(FlatBufferBuilder builder, int propertyId)
		{
			builder.AddInt(0, propertyId, 0);
		}

		// Token: 0x06028ED2 RID: 167634 RVA: 0x0059F25C File Offset: 0x0059D45C
		public static void AddCompare(FlatBufferBuilder builder, EReignsPropertyCompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06028ED3 RID: 167635 RVA: 0x0059F267 File Offset: 0x0059D467
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(2, target, 0);
		}

		// Token: 0x06028ED4 RID: 167636 RVA: 0x0059F272 File Offset: 0x0059D472
		public static Offset<ICompareReignsProperty> EndICompareReignsProperty(FlatBufferBuilder builder)
		{
			return new Offset<ICompareReignsProperty>(builder.EndTable());
		}

		// Token: 0x06028ED5 RID: 167637 RVA: 0x0059F280 File Offset: 0x0059D480
		public ICompareReignsPropertyT UnPack()
		{
			ICompareReignsPropertyT compareReignsPropertyT = new ICompareReignsPropertyT();
			this.UnPackTo(compareReignsPropertyT);
			return compareReignsPropertyT;
		}

		// Token: 0x06028ED6 RID: 167638 RVA: 0x0059F29B File Offset: 0x0059D49B
		public void UnPackTo(ICompareReignsPropertyT _o)
		{
			_o.PropertyId = this.PropertyId;
			_o.Compare = this.Compare;
			_o.Target = this.Target;
		}

		// Token: 0x06028ED7 RID: 167639 RVA: 0x0059F2C4 File Offset: 0x0059D4C4
		public static Offset<ICompareReignsProperty> Pack(FlatBufferBuilder builder, ICompareReignsPropertyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareReignsProperty>);
			}
			return ICompareReignsProperty.CreateICompareReignsProperty(builder, _o.PropertyId, _o.Compare, _o.Target);
		}

		// Token: 0x0400F73C RID: 63292
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051D5 RID: 20949
	public struct IStabilityPointAttribute : IFlatbufferObject
	{
		// Token: 0x17009603 RID: 38403
		// (get) Token: 0x06020FBD RID: 135101 RVA: 0x0048F4D0 File Offset: 0x0048D6D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020FBE RID: 135102 RVA: 0x0048F4DD File Offset: 0x0048D6DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020FBF RID: 135103 RVA: 0x0048F4E4 File Offset: 0x0048D6E4
		public static IStabilityPointAttribute GetRootAsIStabilityPointAttribute(ByteBuffer _bb)
		{
			return IStabilityPointAttribute.GetRootAsIStabilityPointAttribute(_bb, default(IStabilityPointAttribute));
		}

		// Token: 0x06020FC0 RID: 135104 RVA: 0x0048F500 File Offset: 0x0048D700
		public static IStabilityPointAttribute GetRootAsIStabilityPointAttribute(ByteBuffer _bb, IStabilityPointAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020FC1 RID: 135105 RVA: 0x0048F51D File Offset: 0x0048D71D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020FC2 RID: 135106 RVA: 0x0048F52C File Offset: 0x0048D72C
		public IStabilityPointAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009604 RID: 38404
		// (get) Token: 0x06020FC3 RID: 135107 RVA: 0x0048F53C File Offset: 0x0048D73C
		public EPlayerAttributeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerAttributeType.Health;
				}
				return (EPlayerAttributeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009605 RID: 38405
		// (get) Token: 0x06020FC4 RID: 135108 RVA: 0x0048F578 File Offset: 0x0048D778
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009606 RID: 38406
		// (get) Token: 0x06020FC5 RID: 135109 RVA: 0x0048F5B4 File Offset: 0x0048D7B4
		public int Value
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

		// Token: 0x17009607 RID: 38407
		// (get) Token: 0x06020FC6 RID: 135110 RVA: 0x0048F5F0 File Offset: 0x0048D7F0
		public int ValueGroup
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009608 RID: 38408
		// (get) Token: 0x06020FC7 RID: 135111 RVA: 0x0048F630 File Offset: 0x0048D830
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020FC8 RID: 135112 RVA: 0x0048F66D File Offset: 0x0048D86D
		public static Offset<IStabilityPointAttribute> CreateIStabilityPointAttribute(FlatBufferBuilder builder, EPlayerAttributeType Type = EPlayerAttributeType.Health, ECompare Compare = ECompare.Eq, int Value = 0, int ValueGroup = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IStabilityPointAttribute.AddValueGroup(builder, ValueGroup);
			IStabilityPointAttribute.AddValue(builder, Value);
			IStabilityPointAttribute.AddNullMask(builder, NullMask);
			IStabilityPointAttribute.AddCompare(builder, Compare);
			IStabilityPointAttribute.AddType(builder, Type);
			return IStabilityPointAttribute.EndIStabilityPointAttribute(builder);
		}

		// Token: 0x06020FC9 RID: 135113 RVA: 0x0048F6A1 File Offset: 0x0048D8A1
		public static void StartIStabilityPointAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020FCA RID: 135114 RVA: 0x0048F6AA File Offset: 0x0048D8AA
		public static void AddType(FlatBufferBuilder builder, EPlayerAttributeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020FCB RID: 135115 RVA: 0x0048F6B5 File Offset: 0x0048D8B5
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020FCC RID: 135116 RVA: 0x0048F6C0 File Offset: 0x0048D8C0
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(2, value, 0);
		}

		// Token: 0x06020FCD RID: 135117 RVA: 0x0048F6CB File Offset: 0x0048D8CB
		public static void AddValueGroup(FlatBufferBuilder builder, int valueGroup)
		{
			builder.AddInt(3, valueGroup, 0);
		}

		// Token: 0x06020FCE RID: 135118 RVA: 0x0048F6D6 File Offset: 0x0048D8D6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06020FCF RID: 135119 RVA: 0x0048F6E1 File Offset: 0x0048D8E1
		public static Offset<IStabilityPointAttribute> EndIStabilityPointAttribute(FlatBufferBuilder builder)
		{
			return new Offset<IStabilityPointAttribute>(builder.EndTable());
		}

		// Token: 0x06020FD0 RID: 135120 RVA: 0x0048F6F0 File Offset: 0x0048D8F0
		public IStabilityPointAttributeT UnPack()
		{
			IStabilityPointAttributeT stabilityPointAttributeT = new IStabilityPointAttributeT();
			this.UnPackTo(stabilityPointAttributeT);
			return stabilityPointAttributeT;
		}

		// Token: 0x06020FD1 RID: 135121 RVA: 0x0048F70B File Offset: 0x0048D90B
		public void UnPackTo(IStabilityPointAttributeT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Value = this.Value;
			_o.ValueGroup = this.ValueGroup;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020FD2 RID: 135122 RVA: 0x0048F74C File Offset: 0x0048D94C
		public static Offset<IStabilityPointAttribute> Pack(FlatBufferBuilder builder, IStabilityPointAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStabilityPointAttribute>);
			}
			return IStabilityPointAttribute.CreateIStabilityPointAttribute(builder, _o.Type, _o.Compare, _o.Value, _o.ValueGroup, _o.NullMask);
		}

		// Token: 0x0400E1D4 RID: 57812
		private Table __p;
	}
}

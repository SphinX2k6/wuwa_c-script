using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C3A RID: 19514
	public struct IHealthAttribute : IFlatbufferObject
	{
		// Token: 0x17008DC2 RID: 36290
		// (get) Token: 0x0601EED3 RID: 126675 RVA: 0x00453B4A File Offset: 0x00451D4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EED4 RID: 126676 RVA: 0x00453B57 File Offset: 0x00451D57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EED5 RID: 126677 RVA: 0x00453B60 File Offset: 0x00451D60
		public static IHealthAttribute GetRootAsIHealthAttribute(ByteBuffer _bb)
		{
			return IHealthAttribute.GetRootAsIHealthAttribute(_bb, default(IHealthAttribute));
		}

		// Token: 0x0601EED6 RID: 126678 RVA: 0x00453B7C File Offset: 0x00451D7C
		public static IHealthAttribute GetRootAsIHealthAttribute(ByteBuffer _bb, IHealthAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EED7 RID: 126679 RVA: 0x00453B99 File Offset: 0x00451D99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EED8 RID: 126680 RVA: 0x00453BA8 File Offset: 0x00451DA8
		public IHealthAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DC3 RID: 36291
		// (get) Token: 0x0601EED9 RID: 126681 RVA: 0x00453BB8 File Offset: 0x00451DB8
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

		// Token: 0x17008DC4 RID: 36292
		// (get) Token: 0x0601EEDA RID: 126682 RVA: 0x00453BF4 File Offset: 0x00451DF4
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

		// Token: 0x17008DC5 RID: 36293
		// (get) Token: 0x0601EEDB RID: 126683 RVA: 0x00453C30 File Offset: 0x00451E30
		public float Value
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

		// Token: 0x0601EEDC RID: 126684 RVA: 0x00453C70 File Offset: 0x00451E70
		public static Offset<IHealthAttribute> CreateIHealthAttribute(FlatBufferBuilder builder, EPlayerAttributeType Type = EPlayerAttributeType.Health, ECompare Compare = ECompare.Eq, float Value = 0f)
		{
			builder.StartTable(3);
			IHealthAttribute.AddValue(builder, Value);
			IHealthAttribute.AddCompare(builder, Compare);
			IHealthAttribute.AddType(builder, Type);
			return IHealthAttribute.EndIHealthAttribute(builder);
		}

		// Token: 0x0601EEDD RID: 126685 RVA: 0x00453C94 File Offset: 0x00451E94
		public static void StartIHealthAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601EEDE RID: 126686 RVA: 0x00453C9D File Offset: 0x00451E9D
		public static void AddType(FlatBufferBuilder builder, EPlayerAttributeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EEDF RID: 126687 RVA: 0x00453CA8 File Offset: 0x00451EA8
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601EEE0 RID: 126688 RVA: 0x00453CB3 File Offset: 0x00451EB3
		public static void AddValue(FlatBufferBuilder builder, float value)
		{
			builder.AddFloat(2, value, 0.0);
		}

		// Token: 0x0601EEE1 RID: 126689 RVA: 0x00453CC6 File Offset: 0x00451EC6
		public static Offset<IHealthAttribute> EndIHealthAttribute(FlatBufferBuilder builder)
		{
			return new Offset<IHealthAttribute>(builder.EndTable());
		}

		// Token: 0x0601EEE2 RID: 126690 RVA: 0x00453CD4 File Offset: 0x00451ED4
		public IHealthAttributeT UnPack()
		{
			IHealthAttributeT healthAttributeT = new IHealthAttributeT();
			this.UnPackTo(healthAttributeT);
			return healthAttributeT;
		}

		// Token: 0x0601EEE3 RID: 126691 RVA: 0x00453CEF File Offset: 0x00451EEF
		public void UnPackTo(IHealthAttributeT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Value = this.Value;
		}

		// Token: 0x0601EEE4 RID: 126692 RVA: 0x00453D18 File Offset: 0x00451F18
		public static Offset<IHealthAttribute> Pack(FlatBufferBuilder builder, IHealthAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHealthAttribute>);
			}
			return IHealthAttribute.CreateIHealthAttribute(builder, _o.Type, _o.Compare, _o.Value);
		}

		// Token: 0x0400D5DE RID: 54750
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200512D RID: 20781
	public struct IHealthAttribute : IFlatbufferObject
	{
		// Token: 0x170094EB RID: 38123
		// (get) Token: 0x06020AD7 RID: 133847 RVA: 0x00487426 File Offset: 0x00485626
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020AD8 RID: 133848 RVA: 0x00487433 File Offset: 0x00485633
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020AD9 RID: 133849 RVA: 0x0048743C File Offset: 0x0048563C
		public static IHealthAttribute GetRootAsIHealthAttribute(ByteBuffer _bb)
		{
			return IHealthAttribute.GetRootAsIHealthAttribute(_bb, default(IHealthAttribute));
		}

		// Token: 0x06020ADA RID: 133850 RVA: 0x00487458 File Offset: 0x00485658
		public static IHealthAttribute GetRootAsIHealthAttribute(ByteBuffer _bb, IHealthAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020ADB RID: 133851 RVA: 0x00487475 File Offset: 0x00485675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020ADC RID: 133852 RVA: 0x00487484 File Offset: 0x00485684
		public IHealthAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094EC RID: 38124
		// (get) Token: 0x06020ADD RID: 133853 RVA: 0x00487494 File Offset: 0x00485694
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

		// Token: 0x170094ED RID: 38125
		// (get) Token: 0x06020ADE RID: 133854 RVA: 0x004874D0 File Offset: 0x004856D0
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

		// Token: 0x170094EE RID: 38126
		// (get) Token: 0x06020ADF RID: 133855 RVA: 0x0048750C File Offset: 0x0048570C
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

		// Token: 0x06020AE0 RID: 133856 RVA: 0x0048754C File Offset: 0x0048574C
		public static Offset<IHealthAttribute> CreateIHealthAttribute(FlatBufferBuilder builder, EPlayerAttributeType Type = EPlayerAttributeType.Health, ECompare Compare = ECompare.Eq, float Value = 0f)
		{
			builder.StartTable(3);
			IHealthAttribute.AddValue(builder, Value);
			IHealthAttribute.AddCompare(builder, Compare);
			IHealthAttribute.AddType(builder, Type);
			return IHealthAttribute.EndIHealthAttribute(builder);
		}

		// Token: 0x06020AE1 RID: 133857 RVA: 0x00487570 File Offset: 0x00485770
		public static void StartIHealthAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020AE2 RID: 133858 RVA: 0x00487579 File Offset: 0x00485779
		public static void AddType(FlatBufferBuilder builder, EPlayerAttributeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020AE3 RID: 133859 RVA: 0x00487584 File Offset: 0x00485784
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020AE4 RID: 133860 RVA: 0x0048758F File Offset: 0x0048578F
		public static void AddValue(FlatBufferBuilder builder, float value)
		{
			builder.AddFloat(2, value, 0.0);
		}

		// Token: 0x06020AE5 RID: 133861 RVA: 0x004875A2 File Offset: 0x004857A2
		public static Offset<IHealthAttribute> EndIHealthAttribute(FlatBufferBuilder builder)
		{
			return new Offset<IHealthAttribute>(builder.EndTable());
		}

		// Token: 0x06020AE6 RID: 133862 RVA: 0x004875B0 File Offset: 0x004857B0
		public IHealthAttributeT UnPack()
		{
			IHealthAttributeT healthAttributeT = new IHealthAttributeT();
			this.UnPackTo(healthAttributeT);
			return healthAttributeT;
		}

		// Token: 0x06020AE7 RID: 133863 RVA: 0x004875CB File Offset: 0x004857CB
		public void UnPackTo(IHealthAttributeT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Value = this.Value;
		}

		// Token: 0x06020AE8 RID: 133864 RVA: 0x004875F4 File Offset: 0x004857F4
		public static Offset<IHealthAttribute> Pack(FlatBufferBuilder builder, IHealthAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHealthAttribute>);
			}
			return IHealthAttribute.CreateIHealthAttribute(builder, _o.Type, _o.Compare, _o.Value);
		}

		// Token: 0x0400E0FD RID: 57597
		private Table __p;
	}
}

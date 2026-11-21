using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004064 RID: 16484
	public struct ITargetPointTipsActor : IFlatbufferObject
	{
		// Token: 0x17007036 RID: 28726
		// (get) Token: 0x06016AD5 RID: 92885 RVA: 0x0033DDEA File Offset: 0x0033BFEA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016AD6 RID: 92886 RVA: 0x0033DDF7 File Offset: 0x0033BFF7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016AD7 RID: 92887 RVA: 0x0033DE00 File Offset: 0x0033C000
		public static ITargetPointTipsActor GetRootAsITargetPointTipsActor(ByteBuffer _bb)
		{
			return ITargetPointTipsActor.GetRootAsITargetPointTipsActor(_bb, default(ITargetPointTipsActor));
		}

		// Token: 0x06016AD8 RID: 92888 RVA: 0x0033DE1C File Offset: 0x0033C01C
		public static ITargetPointTipsActor GetRootAsITargetPointTipsActor(ByteBuffer _bb, ITargetPointTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016AD9 RID: 92889 RVA: 0x0033DE39 File Offset: 0x0033C039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016ADA RID: 92890 RVA: 0x0033DE48 File Offset: 0x0033C048
		public ITargetPointTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007037 RID: 28727
		// (get) Token: 0x06016ADB RID: 92891 RVA: 0x0033DE58 File Offset: 0x0033C058
		public ETipsActorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETipsActorType.Sphere;
				}
				return (ETipsActorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007038 RID: 28728
		// (get) Token: 0x06016ADC RID: 92892 RVA: 0x0033DE94 File Offset: 0x0033C094
		public ETipsActorColorType ColorType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETipsActorColorType.Inner;
				}
				return (ETipsActorColorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007039 RID: 28729
		// (get) Token: 0x06016ADD RID: 92893 RVA: 0x0033DED0 File Offset: 0x0033C0D0
		public string Label
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016ADE RID: 92894 RVA: 0x0033DF07 File Offset: 0x0033C107
		public Span<byte> GetLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016ADF RID: 92895 RVA: 0x0033DF16 File Offset: 0x0033C116
		public byte[] GetLabelArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700703A RID: 28730
		// (get) Token: 0x06016AE0 RID: 92896 RVA: 0x0033DF24 File Offset: 0x0033C124
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016AE1 RID: 92897 RVA: 0x0033DF61 File Offset: 0x0033C161
		public static Offset<ITargetPointTipsActor> CreateITargetPointTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, StringOffset LabelOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ITargetPointTipsActor.AddLabel(builder, LabelOffset);
			ITargetPointTipsActor.AddNullMask(builder, NullMask);
			ITargetPointTipsActor.AddColorType(builder, ColorType);
			ITargetPointTipsActor.AddType(builder, Type);
			return ITargetPointTipsActor.EndITargetPointTipsActor(builder);
		}

		// Token: 0x06016AE2 RID: 92898 RVA: 0x0033DF8D File Offset: 0x0033C18D
		public static void StartITargetPointTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016AE3 RID: 92899 RVA: 0x0033DF96 File Offset: 0x0033C196
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016AE4 RID: 92900 RVA: 0x0033DFA1 File Offset: 0x0033C1A1
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06016AE5 RID: 92901 RVA: 0x0033DFAC File Offset: 0x0033C1AC
		public static void AddLabel(FlatBufferBuilder builder, StringOffset labelOffset)
		{
			builder.AddOffset(2, labelOffset.Value, 0);
		}

		// Token: 0x06016AE6 RID: 92902 RVA: 0x0033DFBC File Offset: 0x0033C1BC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06016AE7 RID: 92903 RVA: 0x0033DFC7 File Offset: 0x0033C1C7
		public static Offset<ITargetPointTipsActor> EndITargetPointTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ITargetPointTipsActor>(builder.EndTable());
		}

		// Token: 0x06016AE8 RID: 92904 RVA: 0x0033DFD4 File Offset: 0x0033C1D4
		public ITargetPointTipsActorT UnPack()
		{
			ITargetPointTipsActorT targetPointTipsActorT = new ITargetPointTipsActorT();
			this.UnPackTo(targetPointTipsActorT);
			return targetPointTipsActorT;
		}

		// Token: 0x06016AE9 RID: 92905 RVA: 0x0033DFEF File Offset: 0x0033C1EF
		public void UnPackTo(ITargetPointTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Label = this.Label;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016AEA RID: 92906 RVA: 0x0033E024 File Offset: 0x0033C224
		public static Offset<ITargetPointTipsActor> Pack(FlatBufferBuilder builder, ITargetPointTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetPointTipsActor>);
			}
			StringOffset labelOffset = (_o.Label == null) ? default(StringOffset) : builder.CreateString(_o.Label);
			return ITargetPointTipsActor.CreateITargetPointTipsActor(builder, _o.Type, _o.ColorType, labelOffset, _o.NullMask);
		}

		// Token: 0x0400BBFB RID: 48123
		private Table __p;
	}
}

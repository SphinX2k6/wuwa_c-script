using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200682B RID: 26667
	public struct IFlowTemplateTransitionEffect : IFlatbufferObject
	{
		// Token: 0x1700C617 RID: 50711
		// (get) Token: 0x0602E7D5 RID: 190421 RVA: 0x00658356 File Offset: 0x00656556
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E7D6 RID: 190422 RVA: 0x00658363 File Offset: 0x00656563
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E7D7 RID: 190423 RVA: 0x0065836C File Offset: 0x0065656C
		public static IFlowTemplateTransitionEffect GetRootAsIFlowTemplateTransitionEffect(ByteBuffer _bb)
		{
			return IFlowTemplateTransitionEffect.GetRootAsIFlowTemplateTransitionEffect(_bb, default(IFlowTemplateTransitionEffect));
		}

		// Token: 0x0602E7D8 RID: 190424 RVA: 0x00658388 File Offset: 0x00656588
		public static IFlowTemplateTransitionEffect GetRootAsIFlowTemplateTransitionEffect(ByteBuffer _bb, IFlowTemplateTransitionEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E7D9 RID: 190425 RVA: 0x006583A5 File Offset: 0x006565A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E7DA RID: 190426 RVA: 0x006583B4 File Offset: 0x006565B4
		public IFlowTemplateTransitionEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C618 RID: 50712
		// (get) Token: 0x0602E7DB RID: 190427 RVA: 0x006583C4 File Offset: 0x006565C4
		public EFlowTemplateTransitionEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFlowTemplateTransitionEffectType.Blur;
				}
				return (EFlowTemplateTransitionEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E7DC RID: 190428 RVA: 0x00658400 File Offset: 0x00656600
		public static Offset<IFlowTemplateTransitionEffect> CreateIFlowTemplateTransitionEffect(FlatBufferBuilder builder, EFlowTemplateTransitionEffectType Type = EFlowTemplateTransitionEffectType.Blur)
		{
			builder.StartTable(1);
			IFlowTemplateTransitionEffect.AddType(builder, Type);
			return IFlowTemplateTransitionEffect.EndIFlowTemplateTransitionEffect(builder);
		}

		// Token: 0x0602E7DD RID: 190429 RVA: 0x00658416 File Offset: 0x00656616
		public static void StartIFlowTemplateTransitionEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E7DE RID: 190430 RVA: 0x0065841F File Offset: 0x0065661F
		public static void AddType(FlatBufferBuilder builder, EFlowTemplateTransitionEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E7DF RID: 190431 RVA: 0x0065842A File Offset: 0x0065662A
		public static Offset<IFlowTemplateTransitionEffect> EndIFlowTemplateTransitionEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateTransitionEffect>(builder.EndTable());
		}

		// Token: 0x0602E7E0 RID: 190432 RVA: 0x00658438 File Offset: 0x00656638
		public IFlowTemplateTransitionEffectT UnPack()
		{
			IFlowTemplateTransitionEffectT flowTemplateTransitionEffectT = new IFlowTemplateTransitionEffectT();
			this.UnPackTo(flowTemplateTransitionEffectT);
			return flowTemplateTransitionEffectT;
		}

		// Token: 0x0602E7E1 RID: 190433 RVA: 0x00658453 File Offset: 0x00656653
		public void UnPackTo(IFlowTemplateTransitionEffectT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E7E2 RID: 190434 RVA: 0x00658464 File Offset: 0x00656664
		public static Offset<IFlowTemplateTransitionEffect> Pack(FlatBufferBuilder builder, IFlowTemplateTransitionEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowTemplateTransitionEffect>);
			}
			return IFlowTemplateTransitionEffect.CreateIFlowTemplateTransitionEffect(builder, _o.Type);
		}

		// Token: 0x04010F6B RID: 69483
		private Table __p;
	}
}

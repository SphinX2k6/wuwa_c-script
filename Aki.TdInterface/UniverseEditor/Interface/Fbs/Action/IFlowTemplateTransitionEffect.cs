using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB1 RID: 28337
	public struct IFlowTemplateTransitionEffect : IFlatbufferObject
	{
		// Token: 0x1700CFDB RID: 53211
		// (get) Token: 0x0603105D RID: 200797 RVA: 0x006A6296 File Offset: 0x006A4496
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603105E RID: 200798 RVA: 0x006A62A3 File Offset: 0x006A44A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603105F RID: 200799 RVA: 0x006A62AC File Offset: 0x006A44AC
		public static IFlowTemplateTransitionEffect GetRootAsIFlowTemplateTransitionEffect(ByteBuffer _bb)
		{
			return IFlowTemplateTransitionEffect.GetRootAsIFlowTemplateTransitionEffect(_bb, default(IFlowTemplateTransitionEffect));
		}

		// Token: 0x06031060 RID: 200800 RVA: 0x006A62C8 File Offset: 0x006A44C8
		public static IFlowTemplateTransitionEffect GetRootAsIFlowTemplateTransitionEffect(ByteBuffer _bb, IFlowTemplateTransitionEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031061 RID: 200801 RVA: 0x006A62E5 File Offset: 0x006A44E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031062 RID: 200802 RVA: 0x006A62F4 File Offset: 0x006A44F4
		public IFlowTemplateTransitionEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFDC RID: 53212
		// (get) Token: 0x06031063 RID: 200803 RVA: 0x006A6304 File Offset: 0x006A4504
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

		// Token: 0x06031064 RID: 200804 RVA: 0x006A6340 File Offset: 0x006A4540
		public static Offset<IFlowTemplateTransitionEffect> CreateIFlowTemplateTransitionEffect(FlatBufferBuilder builder, EFlowTemplateTransitionEffectType Type = EFlowTemplateTransitionEffectType.Blur)
		{
			builder.StartTable(1);
			IFlowTemplateTransitionEffect.AddType(builder, Type);
			return IFlowTemplateTransitionEffect.EndIFlowTemplateTransitionEffect(builder);
		}

		// Token: 0x06031065 RID: 200805 RVA: 0x006A6356 File Offset: 0x006A4556
		public static void StartIFlowTemplateTransitionEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031066 RID: 200806 RVA: 0x006A635F File Offset: 0x006A455F
		public static void AddType(FlatBufferBuilder builder, EFlowTemplateTransitionEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031067 RID: 200807 RVA: 0x006A636A File Offset: 0x006A456A
		public static Offset<IFlowTemplateTransitionEffect> EndIFlowTemplateTransitionEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateTransitionEffect>(builder.EndTable());
		}

		// Token: 0x06031068 RID: 200808 RVA: 0x006A6378 File Offset: 0x006A4578
		public IFlowTemplateTransitionEffectT UnPack()
		{
			IFlowTemplateTransitionEffectT flowTemplateTransitionEffectT = new IFlowTemplateTransitionEffectT();
			this.UnPackTo(flowTemplateTransitionEffectT);
			return flowTemplateTransitionEffectT;
		}

		// Token: 0x06031069 RID: 200809 RVA: 0x006A6393 File Offset: 0x006A4593
		public void UnPackTo(IFlowTemplateTransitionEffectT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603106A RID: 200810 RVA: 0x006A63A4 File Offset: 0x006A45A4
		public static Offset<IFlowTemplateTransitionEffect> Pack(FlatBufferBuilder builder, IFlowTemplateTransitionEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowTemplateTransitionEffect>);
			}
			return IFlowTemplateTransitionEffect.CreateIFlowTemplateTransitionEffect(builder, _o.Type);
		}

		// Token: 0x04011DA5 RID: 73125
		private Table __p;
	}
}

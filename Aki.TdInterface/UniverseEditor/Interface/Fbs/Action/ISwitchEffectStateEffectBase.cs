using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A31 RID: 31281
	public struct ISwitchEffectStateEffectBase : IFlatbufferObject
	{
		// Token: 0x1700E534 RID: 58676
		// (get) Token: 0x060371F6 RID: 225782 RVA: 0x0075D720 File Offset: 0x0075B920
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060371F7 RID: 225783 RVA: 0x0075D72D File Offset: 0x0075B92D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060371F8 RID: 225784 RVA: 0x0075D734 File Offset: 0x0075B934
		public static ISwitchEffectStateEffectBase GetRootAsISwitchEffectStateEffectBase(ByteBuffer _bb)
		{
			return ISwitchEffectStateEffectBase.GetRootAsISwitchEffectStateEffectBase(_bb, default(ISwitchEffectStateEffectBase));
		}

		// Token: 0x060371F9 RID: 225785 RVA: 0x0075D750 File Offset: 0x0075B950
		public static ISwitchEffectStateEffectBase GetRootAsISwitchEffectStateEffectBase(ByteBuffer _bb, ISwitchEffectStateEffectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060371FA RID: 225786 RVA: 0x0075D76D File Offset: 0x0075B96D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060371FB RID: 225787 RVA: 0x0075D77C File Offset: 0x0075B97C
		public ISwitchEffectStateEffectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E535 RID: 58677
		// (get) Token: 0x060371FC RID: 225788 RVA: 0x0075D78C File Offset: 0x0075B98C
		public ESwitchEffectStateEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESwitchEffectStateEffectType.ScreenEffect;
				}
				return (ESwitchEffectStateEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060371FD RID: 225789 RVA: 0x0075D7C8 File Offset: 0x0075B9C8
		public static Offset<ISwitchEffectStateEffectBase> CreateISwitchEffectStateEffectBase(FlatBufferBuilder builder, ESwitchEffectStateEffectType Type = ESwitchEffectStateEffectType.ScreenEffect)
		{
			builder.StartTable(1);
			ISwitchEffectStateEffectBase.AddType(builder, Type);
			return ISwitchEffectStateEffectBase.EndISwitchEffectStateEffectBase(builder);
		}

		// Token: 0x060371FE RID: 225790 RVA: 0x0075D7DE File Offset: 0x0075B9DE
		public static void StartISwitchEffectStateEffectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060371FF RID: 225791 RVA: 0x0075D7E7 File Offset: 0x0075B9E7
		public static void AddType(FlatBufferBuilder builder, ESwitchEffectStateEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037200 RID: 225792 RVA: 0x0075D7F2 File Offset: 0x0075B9F2
		public static Offset<ISwitchEffectStateEffectBase> EndISwitchEffectStateEffectBase(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchEffectStateEffectBase>(builder.EndTable());
		}

		// Token: 0x06037201 RID: 225793 RVA: 0x0075D800 File Offset: 0x0075BA00
		public ISwitchEffectStateEffectBaseT UnPack()
		{
			ISwitchEffectStateEffectBaseT switchEffectStateEffectBaseT = new ISwitchEffectStateEffectBaseT();
			this.UnPackTo(switchEffectStateEffectBaseT);
			return switchEffectStateEffectBaseT;
		}

		// Token: 0x06037202 RID: 225794 RVA: 0x0075D81B File Offset: 0x0075BA1B
		public void UnPackTo(ISwitchEffectStateEffectBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06037203 RID: 225795 RVA: 0x0075D82C File Offset: 0x0075BA2C
		public static Offset<ISwitchEffectStateEffectBase> Pack(FlatBufferBuilder builder, ISwitchEffectStateEffectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchEffectStateEffectBase>);
			}
			return ISwitchEffectStateEffectBase.CreateISwitchEffectStateEffectBase(builder, _o.Type);
		}

		// Token: 0x04012D57 RID: 77143
		private Table __p;
	}
}

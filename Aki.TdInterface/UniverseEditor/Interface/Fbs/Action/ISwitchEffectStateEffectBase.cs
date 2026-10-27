using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200725C RID: 29276
	public struct ISwitchEffectStateEffectBase : IFlatbufferObject
	{
		// Token: 0x1700D93B RID: 55611
		// (get) Token: 0x06033EF4 RID: 212724 RVA: 0x006FC3C0 File Offset: 0x006FA5C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033EF5 RID: 212725 RVA: 0x006FC3CD File Offset: 0x006FA5CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033EF6 RID: 212726 RVA: 0x006FC3D4 File Offset: 0x006FA5D4
		public static ISwitchEffectStateEffectBase GetRootAsISwitchEffectStateEffectBase(ByteBuffer _bb)
		{
			return ISwitchEffectStateEffectBase.GetRootAsISwitchEffectStateEffectBase(_bb, default(ISwitchEffectStateEffectBase));
		}

		// Token: 0x06033EF7 RID: 212727 RVA: 0x006FC3F0 File Offset: 0x006FA5F0
		public static ISwitchEffectStateEffectBase GetRootAsISwitchEffectStateEffectBase(ByteBuffer _bb, ISwitchEffectStateEffectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033EF8 RID: 212728 RVA: 0x006FC40D File Offset: 0x006FA60D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033EF9 RID: 212729 RVA: 0x006FC41C File Offset: 0x006FA61C
		public ISwitchEffectStateEffectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D93C RID: 55612
		// (get) Token: 0x06033EFA RID: 212730 RVA: 0x006FC42C File Offset: 0x006FA62C
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

		// Token: 0x06033EFB RID: 212731 RVA: 0x006FC468 File Offset: 0x006FA668
		public static Offset<ISwitchEffectStateEffectBase> CreateISwitchEffectStateEffectBase(FlatBufferBuilder builder, ESwitchEffectStateEffectType Type = ESwitchEffectStateEffectType.ScreenEffect)
		{
			builder.StartTable(1);
			ISwitchEffectStateEffectBase.AddType(builder, Type);
			return ISwitchEffectStateEffectBase.EndISwitchEffectStateEffectBase(builder);
		}

		// Token: 0x06033EFC RID: 212732 RVA: 0x006FC47E File Offset: 0x006FA67E
		public static void StartISwitchEffectStateEffectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033EFD RID: 212733 RVA: 0x006FC487 File Offset: 0x006FA687
		public static void AddType(FlatBufferBuilder builder, ESwitchEffectStateEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033EFE RID: 212734 RVA: 0x006FC492 File Offset: 0x006FA692
		public static Offset<ISwitchEffectStateEffectBase> EndISwitchEffectStateEffectBase(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchEffectStateEffectBase>(builder.EndTable());
		}

		// Token: 0x06033EFF RID: 212735 RVA: 0x006FC4A0 File Offset: 0x006FA6A0
		public ISwitchEffectStateEffectBaseT UnPack()
		{
			ISwitchEffectStateEffectBaseT switchEffectStateEffectBaseT = new ISwitchEffectStateEffectBaseT();
			this.UnPackTo(switchEffectStateEffectBaseT);
			return switchEffectStateEffectBaseT;
		}

		// Token: 0x06033F00 RID: 212736 RVA: 0x006FC4BB File Offset: 0x006FA6BB
		public void UnPackTo(ISwitchEffectStateEffectBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033F01 RID: 212737 RVA: 0x006FC4CC File Offset: 0x006FA6CC
		public static Offset<ISwitchEffectStateEffectBase> Pack(FlatBufferBuilder builder, ISwitchEffectStateEffectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchEffectStateEffectBase>);
			}
			return ISwitchEffectStateEffectBase.CreateISwitchEffectStateEffectBase(builder, _o.Type);
		}

		// Token: 0x04011D55 RID: 73045
		private Table __p;
	}
}

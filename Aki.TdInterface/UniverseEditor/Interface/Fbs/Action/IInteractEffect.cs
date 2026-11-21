using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007034 RID: 28724
	public struct IInteractEffect : IFlatbufferObject
	{
		// Token: 0x1700D252 RID: 53842
		// (get) Token: 0x06031C84 RID: 203908 RVA: 0x006BD408 File Offset: 0x006BB608
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031C85 RID: 203909 RVA: 0x006BD415 File Offset: 0x006BB615
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031C86 RID: 203910 RVA: 0x006BD41C File Offset: 0x006BB61C
		public static IInteractEffect GetRootAsIInteractEffect(ByteBuffer _bb)
		{
			return IInteractEffect.GetRootAsIInteractEffect(_bb, default(IInteractEffect));
		}

		// Token: 0x06031C87 RID: 203911 RVA: 0x006BD438 File Offset: 0x006BB638
		public static IInteractEffect GetRootAsIInteractEffect(ByteBuffer _bb, IInteractEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031C88 RID: 203912 RVA: 0x006BD455 File Offset: 0x006BB655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031C89 RID: 203913 RVA: 0x006BD464 File Offset: 0x006BB664
		public IInteractEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D253 RID: 53843
		// (get) Token: 0x06031C8A RID: 203914 RVA: 0x006BD474 File Offset: 0x006BB674
		public EInteractEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractEffectType.ModifyTipText;
				}
				return (EInteractEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D254 RID: 53844
		// (get) Token: 0x06031C8B RID: 203915 RVA: 0x006BD4B0 File Offset: 0x006BB6B0
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D255 RID: 53845
		// (get) Token: 0x06031C8C RID: 203916 RVA: 0x006BD4F0 File Offset: 0x006BB6F0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031C8D RID: 203917 RVA: 0x006BD52C File Offset: 0x006BB72C
		public static Offset<IInteractEffect> CreateIInteractEffect(FlatBufferBuilder builder, EInteractEffectType Type = EInteractEffectType.ModifyTipText, float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IInteractEffect.AddDelayTime(builder, DelayTime);
			IInteractEffect.AddNullMask(builder, NullMask);
			IInteractEffect.AddType(builder, Type);
			return IInteractEffect.EndIInteractEffect(builder);
		}

		// Token: 0x06031C8E RID: 203918 RVA: 0x006BD550 File Offset: 0x006BB750
		public static void StartIInteractEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031C8F RID: 203919 RVA: 0x006BD559 File Offset: 0x006BB759
		public static void AddType(FlatBufferBuilder builder, EInteractEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031C90 RID: 203920 RVA: 0x006BD564 File Offset: 0x006BB764
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x06031C91 RID: 203921 RVA: 0x006BD577 File Offset: 0x006BB777
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06031C92 RID: 203922 RVA: 0x006BD582 File Offset: 0x006BB782
		public static Offset<IInteractEffect> EndIInteractEffect(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEffect>(builder.EndTable());
		}

		// Token: 0x06031C93 RID: 203923 RVA: 0x006BD590 File Offset: 0x006BB790
		public IInteractEffectT UnPack()
		{
			IInteractEffectT interactEffectT = new IInteractEffectT();
			this.UnPackTo(interactEffectT);
			return interactEffectT;
		}

		// Token: 0x06031C94 RID: 203924 RVA: 0x006BD5AB File Offset: 0x006BB7AB
		public void UnPackTo(IInteractEffectT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031C95 RID: 203925 RVA: 0x006BD5D4 File Offset: 0x006BB7D4
		public static Offset<IInteractEffect> Pack(FlatBufferBuilder builder, IInteractEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractEffect>);
			}
			return IInteractEffect.CreateIInteractEffect(builder, _o.Type, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x04011F74 RID: 73588
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077AF RID: 30639
	public struct ISetEntityTag : IFlatbufferObject
	{
		// Token: 0x1700E081 RID: 57473
		// (get) Token: 0x06035CB4 RID: 220340 RVA: 0x00734EBE File Offset: 0x007330BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035CB5 RID: 220341 RVA: 0x00734ECB File Offset: 0x007330CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035CB6 RID: 220342 RVA: 0x00734ED4 File Offset: 0x007330D4
		public static ISetEntityTag GetRootAsISetEntityTag(ByteBuffer _bb)
		{
			return ISetEntityTag.GetRootAsISetEntityTag(_bb, default(ISetEntityTag));
		}

		// Token: 0x06035CB7 RID: 220343 RVA: 0x00734EF0 File Offset: 0x007330F0
		public static ISetEntityTag GetRootAsISetEntityTag(ByteBuffer _bb, ISetEntityTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035CB8 RID: 220344 RVA: 0x00734F0D File Offset: 0x0073310D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035CB9 RID: 220345 RVA: 0x00734F1C File Offset: 0x0073311C
		public ISetEntityTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E082 RID: 57474
		// (get) Token: 0x06035CBA RID: 220346 RVA: 0x00734F2C File Offset: 0x0073312C
		public int EntityId
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

		// Token: 0x1700E083 RID: 57475
		// (get) Token: 0x06035CBB RID: 220347 RVA: 0x00734F68 File Offset: 0x00733168
		public string GameplayTag
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035CBC RID: 220348 RVA: 0x00734F9F File Offset: 0x0073319F
		public Span<byte> GetGameplayTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06035CBD RID: 220349 RVA: 0x00734FAE File Offset: 0x007331AE
		public byte[] GetGameplayTagArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E084 RID: 57476
		// (get) Token: 0x06035CBE RID: 220350 RVA: 0x00734FBC File Offset: 0x007331BC
		public ESetEntityTagType SetType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ESetEntityTagType.Add;
				}
				return (ESetEntityTagType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E085 RID: 57477
		// (get) Token: 0x06035CBF RID: 220351 RVA: 0x00734FF8 File Offset: 0x007331F8
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E086 RID: 57478
		// (get) Token: 0x06035CC0 RID: 220352 RVA: 0x0073503C File Offset: 0x0073323C
		public bool BeforeHide
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E087 RID: 57479
		// (get) Token: 0x06035CC1 RID: 220353 RVA: 0x0073507C File Offset: 0x0073327C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035CC2 RID: 220354 RVA: 0x007350B9 File Offset: 0x007332B9
		public static Offset<ISetEntityTag> CreateISetEntityTag(FlatBufferBuilder builder, int EntityId = 0, StringOffset GameplayTagOffset = default(StringOffset), ESetEntityTagType SetType = ESetEntityTagType.Add, float DelayTime = 0f, bool BeforeHide = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			ISetEntityTag.AddDelayTime(builder, DelayTime);
			ISetEntityTag.AddGameplayTag(builder, GameplayTagOffset);
			ISetEntityTag.AddEntityId(builder, EntityId);
			ISetEntityTag.AddNullMask(builder, NullMask);
			ISetEntityTag.AddBeforeHide(builder, BeforeHide);
			ISetEntityTag.AddSetType(builder, SetType);
			return ISetEntityTag.EndISetEntityTag(builder);
		}

		// Token: 0x06035CC3 RID: 220355 RVA: 0x007350F5 File Offset: 0x007332F5
		public static void StartISetEntityTag(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06035CC4 RID: 220356 RVA: 0x007350FE File Offset: 0x007332FE
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06035CC5 RID: 220357 RVA: 0x00735109 File Offset: 0x00733309
		public static void AddGameplayTag(FlatBufferBuilder builder, StringOffset gameplayTagOffset)
		{
			builder.AddOffset(1, gameplayTagOffset.Value, 0);
		}

		// Token: 0x06035CC6 RID: 220358 RVA: 0x00735119 File Offset: 0x00733319
		public static void AddSetType(FlatBufferBuilder builder, ESetEntityTagType setType)
		{
			builder.AddByte(2, (byte)setType, 0);
		}

		// Token: 0x06035CC7 RID: 220359 RVA: 0x00735124 File Offset: 0x00733324
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x06035CC8 RID: 220360 RVA: 0x00735137 File Offset: 0x00733337
		public static void AddBeforeHide(FlatBufferBuilder builder, bool beforeHide)
		{
			builder.AddBool(4, beforeHide, false);
		}

		// Token: 0x06035CC9 RID: 220361 RVA: 0x00735142 File Offset: 0x00733342
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06035CCA RID: 220362 RVA: 0x0073514D File Offset: 0x0073334D
		public static Offset<ISetEntityTag> EndISetEntityTag(FlatBufferBuilder builder)
		{
			return new Offset<ISetEntityTag>(builder.EndTable());
		}

		// Token: 0x06035CCB RID: 220363 RVA: 0x0073515C File Offset: 0x0073335C
		public ISetEntityTagT UnPack()
		{
			ISetEntityTagT setEntityTagT = new ISetEntityTagT();
			this.UnPackTo(setEntityTagT);
			return setEntityTagT;
		}

		// Token: 0x06035CCC RID: 220364 RVA: 0x00735178 File Offset: 0x00733378
		public void UnPackTo(ISetEntityTagT _o)
		{
			_o.EntityId = this.EntityId;
			_o.GameplayTag = this.GameplayTag;
			_o.SetType = this.SetType;
			_o.DelayTime = this.DelayTime;
			_o.BeforeHide = this.BeforeHide;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035CCD RID: 220365 RVA: 0x007351D0 File Offset: 0x007333D0
		public static Offset<ISetEntityTag> Pack(FlatBufferBuilder builder, ISetEntityTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetEntityTag>);
			}
			StringOffset gameplayTagOffset = (_o.GameplayTag == null) ? default(StringOffset) : builder.CreateString(_o.GameplayTag);
			return ISetEntityTag.CreateISetEntityTag(builder, _o.EntityId, gameplayTagOffset, _o.SetType, _o.DelayTime, _o.BeforeHide, _o.NullMask);
		}

		// Token: 0x040129DA RID: 76250
		private Table __p;
	}
}

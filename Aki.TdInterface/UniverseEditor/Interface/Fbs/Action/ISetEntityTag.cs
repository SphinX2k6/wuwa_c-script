using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE6 RID: 28646
	public struct ISetEntityTag : IFlatbufferObject
	{
		// Token: 0x1700D4AD RID: 54445
		// (get) Token: 0x06032A4E RID: 207438 RVA: 0x006D527A File Offset: 0x006D347A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A4F RID: 207439 RVA: 0x006D5287 File Offset: 0x006D3487
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A50 RID: 207440 RVA: 0x006D5290 File Offset: 0x006D3490
		public static ISetEntityTag GetRootAsISetEntityTag(ByteBuffer _bb)
		{
			return ISetEntityTag.GetRootAsISetEntityTag(_bb, default(ISetEntityTag));
		}

		// Token: 0x06032A51 RID: 207441 RVA: 0x006D52AC File Offset: 0x006D34AC
		public static ISetEntityTag GetRootAsISetEntityTag(ByteBuffer _bb, ISetEntityTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032A52 RID: 207442 RVA: 0x006D52C9 File Offset: 0x006D34C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032A53 RID: 207443 RVA: 0x006D52D8 File Offset: 0x006D34D8
		public ISetEntityTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4AE RID: 54446
		// (get) Token: 0x06032A54 RID: 207444 RVA: 0x006D52E8 File Offset: 0x006D34E8
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

		// Token: 0x1700D4AF RID: 54447
		// (get) Token: 0x06032A55 RID: 207445 RVA: 0x006D5324 File Offset: 0x006D3524
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

		// Token: 0x06032A56 RID: 207446 RVA: 0x006D535B File Offset: 0x006D355B
		public Span<byte> GetGameplayTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06032A57 RID: 207447 RVA: 0x006D536A File Offset: 0x006D356A
		public byte[] GetGameplayTagArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D4B0 RID: 54448
		// (get) Token: 0x06032A58 RID: 207448 RVA: 0x006D5378 File Offset: 0x006D3578
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

		// Token: 0x1700D4B1 RID: 54449
		// (get) Token: 0x06032A59 RID: 207449 RVA: 0x006D53B4 File Offset: 0x006D35B4
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

		// Token: 0x1700D4B2 RID: 54450
		// (get) Token: 0x06032A5A RID: 207450 RVA: 0x006D53F8 File Offset: 0x006D35F8
		public bool BeforeHide
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D4B3 RID: 54451
		// (get) Token: 0x06032A5B RID: 207451 RVA: 0x006D5438 File Offset: 0x006D3638
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

		// Token: 0x06032A5C RID: 207452 RVA: 0x006D5475 File Offset: 0x006D3675
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

		// Token: 0x06032A5D RID: 207453 RVA: 0x006D54B1 File Offset: 0x006D36B1
		public static void StartISetEntityTag(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06032A5E RID: 207454 RVA: 0x006D54BA File Offset: 0x006D36BA
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06032A5F RID: 207455 RVA: 0x006D54C5 File Offset: 0x006D36C5
		public static void AddGameplayTag(FlatBufferBuilder builder, StringOffset gameplayTagOffset)
		{
			builder.AddOffset(1, gameplayTagOffset.Value, 0);
		}

		// Token: 0x06032A60 RID: 207456 RVA: 0x006D54D5 File Offset: 0x006D36D5
		public static void AddSetType(FlatBufferBuilder builder, ESetEntityTagType setType)
		{
			builder.AddByte(2, (byte)setType, 0);
		}

		// Token: 0x06032A61 RID: 207457 RVA: 0x006D54E0 File Offset: 0x006D36E0
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x06032A62 RID: 207458 RVA: 0x006D54F3 File Offset: 0x006D36F3
		public static void AddBeforeHide(FlatBufferBuilder builder, bool beforeHide)
		{
			builder.AddBool(4, beforeHide, false);
		}

		// Token: 0x06032A63 RID: 207459 RVA: 0x006D54FE File Offset: 0x006D36FE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06032A64 RID: 207460 RVA: 0x006D5509 File Offset: 0x006D3709
		public static Offset<ISetEntityTag> EndISetEntityTag(FlatBufferBuilder builder)
		{
			return new Offset<ISetEntityTag>(builder.EndTable());
		}

		// Token: 0x06032A65 RID: 207461 RVA: 0x006D5518 File Offset: 0x006D3718
		public ISetEntityTagT UnPack()
		{
			ISetEntityTagT setEntityTagT = new ISetEntityTagT();
			this.UnPackTo(setEntityTagT);
			return setEntityTagT;
		}

		// Token: 0x06032A66 RID: 207462 RVA: 0x006D5534 File Offset: 0x006D3734
		public void UnPackTo(ISetEntityTagT _o)
		{
			_o.EntityId = this.EntityId;
			_o.GameplayTag = this.GameplayTag;
			_o.SetType = this.SetType;
			_o.DelayTime = this.DelayTime;
			_o.BeforeHide = this.BeforeHide;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032A67 RID: 207463 RVA: 0x006D558C File Offset: 0x006D378C
		public static Offset<ISetEntityTag> Pack(FlatBufferBuilder builder, ISetEntityTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetEntityTag>);
			}
			StringOffset gameplayTagOffset = (_o.GameplayTag == null) ? default(StringOffset) : builder.CreateString(_o.GameplayTag);
			return ISetEntityTag.CreateISetEntityTag(builder, _o.EntityId, gameplayTagOffset, _o.SetType, _o.DelayTime, _o.BeforeHide, _o.NullMask);
		}

		// Token: 0x040119F5 RID: 72181
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074BC RID: 29884
	public struct IPlaySpineAnimation : IFlatbufferObject
	{
		// Token: 0x1700DBDA RID: 56282
		// (get) Token: 0x06034603 RID: 214531 RVA: 0x0070DCB2 File Offset: 0x0070BEB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034604 RID: 214532 RVA: 0x0070DCBF File Offset: 0x0070BEBF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034605 RID: 214533 RVA: 0x0070DCC8 File Offset: 0x0070BEC8
		public static IPlaySpineAnimation GetRootAsIPlaySpineAnimation(ByteBuffer _bb)
		{
			return IPlaySpineAnimation.GetRootAsIPlaySpineAnimation(_bb, default(IPlaySpineAnimation));
		}

		// Token: 0x06034606 RID: 214534 RVA: 0x0070DCE4 File Offset: 0x0070BEE4
		public static IPlaySpineAnimation GetRootAsIPlaySpineAnimation(ByteBuffer _bb, IPlaySpineAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034607 RID: 214535 RVA: 0x0070DD01 File Offset: 0x0070BF01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034608 RID: 214536 RVA: 0x0070DD10 File Offset: 0x0070BF10
		public IPlaySpineAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DBDB RID: 56283
		// (get) Token: 0x06034609 RID: 214537 RVA: 0x0070DD20 File Offset: 0x0070BF20
		public ESetSpineAnimation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetSpineAnimation.Play;
				}
				return (ESetSpineAnimation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DBDC RID: 56284
		// (get) Token: 0x0603460A RID: 214538 RVA: 0x0070DD5C File Offset: 0x0070BF5C
		public string Name
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

		// Token: 0x0603460B RID: 214539 RVA: 0x0070DD93 File Offset: 0x0070BF93
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603460C RID: 214540 RVA: 0x0070DDA2 File Offset: 0x0070BFA2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700DBDD RID: 56285
		// (get) Token: 0x0603460D RID: 214541 RVA: 0x0070DDB0 File Offset: 0x0070BFB0
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0603460E RID: 214542 RVA: 0x0070DDEF File Offset: 0x0070BFEF
		public static Offset<IPlaySpineAnimation> CreateIPlaySpineAnimation(FlatBufferBuilder builder, ESetSpineAnimation Type = ESetSpineAnimation.Play, StringOffset NameOffset = default(StringOffset), bool IsLoop = false)
		{
			builder.StartTable(3);
			IPlaySpineAnimation.AddName(builder, NameOffset);
			IPlaySpineAnimation.AddIsLoop(builder, IsLoop);
			IPlaySpineAnimation.AddType(builder, Type);
			return IPlaySpineAnimation.EndIPlaySpineAnimation(builder);
		}

		// Token: 0x0603460F RID: 214543 RVA: 0x0070DE13 File Offset: 0x0070C013
		public static void StartIPlaySpineAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034610 RID: 214544 RVA: 0x0070DE1C File Offset: 0x0070C01C
		public static void AddType(FlatBufferBuilder builder, ESetSpineAnimation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034611 RID: 214545 RVA: 0x0070DE27 File Offset: 0x0070C027
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06034612 RID: 214546 RVA: 0x0070DE37 File Offset: 0x0070C037
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(2, isLoop, false);
		}

		// Token: 0x06034613 RID: 214547 RVA: 0x0070DE42 File Offset: 0x0070C042
		public static Offset<IPlaySpineAnimation> EndIPlaySpineAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IPlaySpineAnimation>(builder.EndTable());
		}

		// Token: 0x06034614 RID: 214548 RVA: 0x0070DE50 File Offset: 0x0070C050
		public IPlaySpineAnimationT UnPack()
		{
			IPlaySpineAnimationT playSpineAnimationT = new IPlaySpineAnimationT();
			this.UnPackTo(playSpineAnimationT);
			return playSpineAnimationT;
		}

		// Token: 0x06034615 RID: 214549 RVA: 0x0070DE6B File Offset: 0x0070C06B
		public void UnPackTo(IPlaySpineAnimationT _o)
		{
			_o.Type = this.Type;
			_o.Name = this.Name;
			_o.IsLoop = this.IsLoop;
		}

		// Token: 0x06034616 RID: 214550 RVA: 0x0070DE94 File Offset: 0x0070C094
		public static Offset<IPlaySpineAnimation> Pack(FlatBufferBuilder builder, IPlaySpineAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlaySpineAnimation>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return IPlaySpineAnimation.CreateIPlaySpineAnimation(builder, _o.Type, nameOffset, _o.IsLoop);
		}

		// Token: 0x0401266A RID: 75370
		private Table __p;
	}
}

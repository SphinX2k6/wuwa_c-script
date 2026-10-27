using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F5B RID: 20315
	public struct ICategoryMatchingAnimation : IFlatbufferObject
	{
		// Token: 0x170092A3 RID: 37539
		// (get) Token: 0x06020357 RID: 131927 RVA: 0x0047B492 File Offset: 0x00479692
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020358 RID: 131928 RVA: 0x0047B49F File Offset: 0x0047969F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020359 RID: 131929 RVA: 0x0047B4A8 File Offset: 0x004796A8
		public static ICategoryMatchingAnimation GetRootAsICategoryMatchingAnimation(ByteBuffer _bb)
		{
			return ICategoryMatchingAnimation.GetRootAsICategoryMatchingAnimation(_bb, default(ICategoryMatchingAnimation));
		}

		// Token: 0x0602035A RID: 131930 RVA: 0x0047B4C4 File Offset: 0x004796C4
		public static ICategoryMatchingAnimation GetRootAsICategoryMatchingAnimation(ByteBuffer _bb, ICategoryMatchingAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602035B RID: 131931 RVA: 0x0047B4E1 File Offset: 0x004796E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602035C RID: 131932 RVA: 0x0047B4F0 File Offset: 0x004796F0
		public ICategoryMatchingAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092A4 RID: 37540
		// (get) Token: 0x0602035D RID: 131933 RVA: 0x0047B500 File Offset: 0x00479700
		public IVectorInfo? MatchPos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170092A5 RID: 37541
		// (get) Token: 0x0602035E RID: 131934 RVA: 0x0047B560 File Offset: 0x00479760
		public IVectorInfo? MatchRot
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170092A6 RID: 37542
		// (get) Token: 0x0602035F RID: 131935 RVA: 0x0047B5C0 File Offset: 0x004797C0
		public string MatchReferenceKey
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

		// Token: 0x06020360 RID: 131936 RVA: 0x0047B5F7 File Offset: 0x004797F7
		public Span<byte> GetMatchReferenceKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06020361 RID: 131937 RVA: 0x0047B606 File Offset: 0x00479806
		public byte[] GetMatchReferenceKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170092A7 RID: 37543
		// (get) Token: 0x06020362 RID: 131938 RVA: 0x0047B614 File Offset: 0x00479814
		public string MatchSequence
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020363 RID: 131939 RVA: 0x0047B64C File Offset: 0x0047984C
		public Span<byte> GetMatchSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06020364 RID: 131940 RVA: 0x0047B65C File Offset: 0x0047985C
		public byte[] GetMatchSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x170092A8 RID: 37544
		// (get) Token: 0x06020365 RID: 131941 RVA: 0x0047B66C File Offset: 0x0047986C
		public IVectorInfo? MatchSequenceOffset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06020366 RID: 131942 RVA: 0x0047B6CA File Offset: 0x004798CA
		public static Offset<ICategoryMatchingAnimation> CreateICategoryMatchingAnimation(FlatBufferBuilder builder, Offset<IVectorInfo> MatchPosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> MatchRotOffset = default(Offset<IVectorInfo>), StringOffset MatchReferenceKeyOffset = default(StringOffset), StringOffset MatchSequenceOffset = default(StringOffset), Offset<IVectorInfo> MatchSequenceOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(5);
			ICategoryMatchingAnimation.AddMatchSequenceOffset(builder, MatchSequenceOffsetOffset);
			ICategoryMatchingAnimation.AddMatchSequence(builder, MatchSequenceOffset);
			ICategoryMatchingAnimation.AddMatchReferenceKey(builder, MatchReferenceKeyOffset);
			ICategoryMatchingAnimation.AddMatchRot(builder, MatchRotOffset);
			ICategoryMatchingAnimation.AddMatchPos(builder, MatchPosOffset);
			return ICategoryMatchingAnimation.EndICategoryMatchingAnimation(builder);
		}

		// Token: 0x06020367 RID: 131943 RVA: 0x0047B6FE File Offset: 0x004798FE
		public static void StartICategoryMatchingAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020368 RID: 131944 RVA: 0x0047B707 File Offset: 0x00479907
		public static void AddMatchPos(FlatBufferBuilder builder, Offset<IVectorInfo> matchPosOffset)
		{
			builder.AddOffset(0, matchPosOffset.Value, 0);
		}

		// Token: 0x06020369 RID: 131945 RVA: 0x0047B717 File Offset: 0x00479917
		public static void AddMatchRot(FlatBufferBuilder builder, Offset<IVectorInfo> matchRotOffset)
		{
			builder.AddOffset(1, matchRotOffset.Value, 0);
		}

		// Token: 0x0602036A RID: 131946 RVA: 0x0047B727 File Offset: 0x00479927
		public static void AddMatchReferenceKey(FlatBufferBuilder builder, StringOffset matchReferenceKeyOffset)
		{
			builder.AddOffset(2, matchReferenceKeyOffset.Value, 0);
		}

		// Token: 0x0602036B RID: 131947 RVA: 0x0047B737 File Offset: 0x00479937
		public static void AddMatchSequence(FlatBufferBuilder builder, StringOffset matchSequenceOffset)
		{
			builder.AddOffset(3, matchSequenceOffset.Value, 0);
		}

		// Token: 0x0602036C RID: 131948 RVA: 0x0047B747 File Offset: 0x00479947
		public static void AddMatchSequenceOffset(FlatBufferBuilder builder, Offset<IVectorInfo> matchSequenceOffsetOffset)
		{
			builder.AddOffset(4, matchSequenceOffsetOffset.Value, 0);
		}

		// Token: 0x0602036D RID: 131949 RVA: 0x0047B757 File Offset: 0x00479957
		public static Offset<ICategoryMatchingAnimation> EndICategoryMatchingAnimation(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingAnimation>(builder.EndTable());
		}

		// Token: 0x0602036E RID: 131950 RVA: 0x0047B764 File Offset: 0x00479964
		public ICategoryMatchingAnimationT UnPack()
		{
			ICategoryMatchingAnimationT categoryMatchingAnimationT = new ICategoryMatchingAnimationT();
			this.UnPackTo(categoryMatchingAnimationT);
			return categoryMatchingAnimationT;
		}

		// Token: 0x0602036F RID: 131951 RVA: 0x0047B780 File Offset: 0x00479980
		public void UnPackTo(ICategoryMatchingAnimationT _o)
		{
			_o.MatchPos = ((this.MatchPos != null) ? this.MatchPos.Value.UnPack() : null);
			_o.MatchRot = ((this.MatchRot != null) ? this.MatchRot.Value.UnPack() : null);
			_o.MatchReferenceKey = this.MatchReferenceKey;
			_o.MatchSequence = this.MatchSequence;
			_o.MatchSequenceOffset = ((this.MatchSequenceOffset != null) ? this.MatchSequenceOffset.Value.UnPack() : null);
		}

		// Token: 0x06020370 RID: 131952 RVA: 0x0047B834 File Offset: 0x00479A34
		public static Offset<ICategoryMatchingAnimation> Pack(FlatBufferBuilder builder, ICategoryMatchingAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICategoryMatchingAnimation>);
			}
			Offset<IVectorInfo> matchPosOffset = (_o.MatchPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.MatchPos);
			Offset<IVectorInfo> matchRotOffset = (_o.MatchRot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.MatchRot);
			StringOffset matchReferenceKeyOffset = (_o.MatchReferenceKey == null) ? default(StringOffset) : builder.CreateString(_o.MatchReferenceKey);
			StringOffset matchSequenceOffset = (_o.MatchSequence == null) ? default(StringOffset) : builder.CreateString(_o.MatchSequence);
			Offset<IVectorInfo> matchSequenceOffsetOffset = (_o.MatchSequenceOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.MatchSequenceOffset);
			return ICategoryMatchingAnimation.CreateICategoryMatchingAnimation(builder, matchPosOffset, matchRotOffset, matchReferenceKeyOffset, matchSequenceOffset, matchSequenceOffsetOffset);
		}

		// Token: 0x0400DDE8 RID: 56808
		private Table __p;
	}
}

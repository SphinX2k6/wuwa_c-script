using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D41 RID: 27969
	public struct IPlaySpineAnimation : IFlatbufferObject
	{
		// Token: 0x1700D092 RID: 53394
		// (get) Token: 0x06031607 RID: 202247 RVA: 0x006B25CA File Offset: 0x006B07CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031608 RID: 202248 RVA: 0x006B25D7 File Offset: 0x006B07D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031609 RID: 202249 RVA: 0x006B25E0 File Offset: 0x006B07E0
		public static IPlaySpineAnimation GetRootAsIPlaySpineAnimation(ByteBuffer _bb)
		{
			return IPlaySpineAnimation.GetRootAsIPlaySpineAnimation(_bb, default(IPlaySpineAnimation));
		}

		// Token: 0x0603160A RID: 202250 RVA: 0x006B25FC File Offset: 0x006B07FC
		public static IPlaySpineAnimation GetRootAsIPlaySpineAnimation(ByteBuffer _bb, IPlaySpineAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603160B RID: 202251 RVA: 0x006B2619 File Offset: 0x006B0819
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603160C RID: 202252 RVA: 0x006B2628 File Offset: 0x006B0828
		public IPlaySpineAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D093 RID: 53395
		// (get) Token: 0x0603160D RID: 202253 RVA: 0x006B2638 File Offset: 0x006B0838
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

		// Token: 0x1700D094 RID: 53396
		// (get) Token: 0x0603160E RID: 202254 RVA: 0x006B2674 File Offset: 0x006B0874
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

		// Token: 0x0603160F RID: 202255 RVA: 0x006B26AB File Offset: 0x006B08AB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031610 RID: 202256 RVA: 0x006B26BA File Offset: 0x006B08BA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D095 RID: 53397
		// (get) Token: 0x06031611 RID: 202257 RVA: 0x006B26C8 File Offset: 0x006B08C8
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06031612 RID: 202258 RVA: 0x006B2707 File Offset: 0x006B0907
		public static Offset<IPlaySpineAnimation> CreateIPlaySpineAnimation(FlatBufferBuilder builder, ESetSpineAnimation Type = ESetSpineAnimation.Play, StringOffset NameOffset = default(StringOffset), bool IsLoop = false)
		{
			builder.StartTable(3);
			IPlaySpineAnimation.AddName(builder, NameOffset);
			IPlaySpineAnimation.AddIsLoop(builder, IsLoop);
			IPlaySpineAnimation.AddType(builder, Type);
			return IPlaySpineAnimation.EndIPlaySpineAnimation(builder);
		}

		// Token: 0x06031613 RID: 202259 RVA: 0x006B272B File Offset: 0x006B092B
		public static void StartIPlaySpineAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031614 RID: 202260 RVA: 0x006B2734 File Offset: 0x006B0934
		public static void AddType(FlatBufferBuilder builder, ESetSpineAnimation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031615 RID: 202261 RVA: 0x006B273F File Offset: 0x006B093F
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06031616 RID: 202262 RVA: 0x006B274F File Offset: 0x006B094F
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(2, isLoop, false);
		}

		// Token: 0x06031617 RID: 202263 RVA: 0x006B275A File Offset: 0x006B095A
		public static Offset<IPlaySpineAnimation> EndIPlaySpineAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IPlaySpineAnimation>(builder.EndTable());
		}

		// Token: 0x06031618 RID: 202264 RVA: 0x006B2768 File Offset: 0x006B0968
		public IPlaySpineAnimationT UnPack()
		{
			IPlaySpineAnimationT playSpineAnimationT = new IPlaySpineAnimationT();
			this.UnPackTo(playSpineAnimationT);
			return playSpineAnimationT;
		}

		// Token: 0x06031619 RID: 202265 RVA: 0x006B2783 File Offset: 0x006B0983
		public void UnPackTo(IPlaySpineAnimationT _o)
		{
			_o.Type = this.Type;
			_o.Name = this.Name;
			_o.IsLoop = this.IsLoop;
		}

		// Token: 0x0603161A RID: 202266 RVA: 0x006B27AC File Offset: 0x006B09AC
		public static Offset<IPlaySpineAnimation> Pack(FlatBufferBuilder builder, IPlaySpineAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlaySpineAnimation>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return IPlaySpineAnimation.CreateIPlaySpineAnimation(builder, _o.Type, nameOffset, _o.IsLoop);
		}

		// Token: 0x040116EE RID: 71406
		private Table __p;
	}
}

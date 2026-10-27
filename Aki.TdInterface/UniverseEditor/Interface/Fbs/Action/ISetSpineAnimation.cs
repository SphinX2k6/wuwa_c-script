using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007070 RID: 28784
	public struct ISetSpineAnimation : IFlatbufferObject
	{
		// Token: 0x1700D5F2 RID: 54770
		// (get) Token: 0x06032F74 RID: 208756 RVA: 0x006E0087 File Offset: 0x006DE287
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032F75 RID: 208757 RVA: 0x006E0094 File Offset: 0x006DE294
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032F76 RID: 208758 RVA: 0x006E009C File Offset: 0x006DE29C
		public static ISetSpineAnimation GetRootAsISetSpineAnimation(ByteBuffer _bb)
		{
			return ISetSpineAnimation.GetRootAsISetSpineAnimation(_bb, default(ISetSpineAnimation));
		}

		// Token: 0x06032F77 RID: 208759 RVA: 0x006E00B8 File Offset: 0x006DE2B8
		public static ISetSpineAnimation GetRootAsISetSpineAnimation(ByteBuffer _bb, ISetSpineAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032F78 RID: 208760 RVA: 0x006E00D5 File Offset: 0x006DE2D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032F79 RID: 208761 RVA: 0x006E00E4 File Offset: 0x006DE2E4
		public ISetSpineAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5F3 RID: 54771
		// (get) Token: 0x06032F7A RID: 208762 RVA: 0x006E00F4 File Offset: 0x006DE2F4
		public IPlaySpineAnimation? Config
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPlaySpineAnimation?(default(IPlaySpineAnimation).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032F7B RID: 208763 RVA: 0x006E0151 File Offset: 0x006DE351
		public static Offset<ISetSpineAnimation> CreateISetSpineAnimation(FlatBufferBuilder builder, Offset<IPlaySpineAnimation> ConfigOffset = default(Offset<IPlaySpineAnimation>))
		{
			builder.StartTable(1);
			ISetSpineAnimation.AddConfig(builder, ConfigOffset);
			return ISetSpineAnimation.EndISetSpineAnimation(builder);
		}

		// Token: 0x06032F7C RID: 208764 RVA: 0x006E0167 File Offset: 0x006DE367
		public static void StartISetSpineAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032F7D RID: 208765 RVA: 0x006E0170 File Offset: 0x006DE370
		public static void AddConfig(FlatBufferBuilder builder, Offset<IPlaySpineAnimation> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x06032F7E RID: 208766 RVA: 0x006E0180 File Offset: 0x006DE380
		public static Offset<ISetSpineAnimation> EndISetSpineAnimation(FlatBufferBuilder builder)
		{
			return new Offset<ISetSpineAnimation>(builder.EndTable());
		}

		// Token: 0x06032F7F RID: 208767 RVA: 0x006E0190 File Offset: 0x006DE390
		public ISetSpineAnimationT UnPack()
		{
			ISetSpineAnimationT setSpineAnimationT = new ISetSpineAnimationT();
			this.UnPackTo(setSpineAnimationT);
			return setSpineAnimationT;
		}

		// Token: 0x06032F80 RID: 208768 RVA: 0x006E01AC File Offset: 0x006DE3AC
		public void UnPackTo(ISetSpineAnimationT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x06032F81 RID: 208769 RVA: 0x006E01E8 File Offset: 0x006DE3E8
		public static Offset<ISetSpineAnimation> Pack(FlatBufferBuilder builder, ISetSpineAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetSpineAnimation>);
			}
			Offset<IPlaySpineAnimation> configOffset = (_o.Config == null) ? default(Offset<IPlaySpineAnimation>) : IPlaySpineAnimation.Pack(builder, _o.Config);
			return ISetSpineAnimation.CreateISetSpineAnimation(builder, configOffset);
		}

		// Token: 0x04011AD5 RID: 72405
		private Table __p;
	}
}

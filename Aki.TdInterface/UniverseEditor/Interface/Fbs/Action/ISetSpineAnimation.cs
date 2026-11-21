using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200783C RID: 30780
	public struct ISetSpineAnimation : IFlatbufferObject
	{
		// Token: 0x1700E1D5 RID: 57813
		// (get) Token: 0x06036215 RID: 221717 RVA: 0x0074063B File Offset: 0x0073E83B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036216 RID: 221718 RVA: 0x00740648 File Offset: 0x0073E848
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036217 RID: 221719 RVA: 0x00740650 File Offset: 0x0073E850
		public static ISetSpineAnimation GetRootAsISetSpineAnimation(ByteBuffer _bb)
		{
			return ISetSpineAnimation.GetRootAsISetSpineAnimation(_bb, default(ISetSpineAnimation));
		}

		// Token: 0x06036218 RID: 221720 RVA: 0x0074066C File Offset: 0x0073E86C
		public static ISetSpineAnimation GetRootAsISetSpineAnimation(ByteBuffer _bb, ISetSpineAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036219 RID: 221721 RVA: 0x00740689 File Offset: 0x0073E889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603621A RID: 221722 RVA: 0x00740698 File Offset: 0x0073E898
		public ISetSpineAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1D6 RID: 57814
		// (get) Token: 0x0603621B RID: 221723 RVA: 0x007406A8 File Offset: 0x0073E8A8
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

		// Token: 0x0603621C RID: 221724 RVA: 0x00740705 File Offset: 0x0073E905
		public static Offset<ISetSpineAnimation> CreateISetSpineAnimation(FlatBufferBuilder builder, Offset<IPlaySpineAnimation> ConfigOffset = default(Offset<IPlaySpineAnimation>))
		{
			builder.StartTable(1);
			ISetSpineAnimation.AddConfig(builder, ConfigOffset);
			return ISetSpineAnimation.EndISetSpineAnimation(builder);
		}

		// Token: 0x0603621D RID: 221725 RVA: 0x0074071B File Offset: 0x0073E91B
		public static void StartISetSpineAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603621E RID: 221726 RVA: 0x00740724 File Offset: 0x0073E924
		public static void AddConfig(FlatBufferBuilder builder, Offset<IPlaySpineAnimation> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x0603621F RID: 221727 RVA: 0x00740734 File Offset: 0x0073E934
		public static Offset<ISetSpineAnimation> EndISetSpineAnimation(FlatBufferBuilder builder)
		{
			return new Offset<ISetSpineAnimation>(builder.EndTable());
		}

		// Token: 0x06036220 RID: 221728 RVA: 0x00740744 File Offset: 0x0073E944
		public ISetSpineAnimationT UnPack()
		{
			ISetSpineAnimationT setSpineAnimationT = new ISetSpineAnimationT();
			this.UnPackTo(setSpineAnimationT);
			return setSpineAnimationT;
		}

		// Token: 0x06036221 RID: 221729 RVA: 0x00740760 File Offset: 0x0073E960
		public void UnPackTo(ISetSpineAnimationT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x06036222 RID: 221730 RVA: 0x0074079C File Offset: 0x0073E99C
		public static Offset<ISetSpineAnimation> Pack(FlatBufferBuilder builder, ISetSpineAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetSpineAnimation>);
			}
			Offset<IPlaySpineAnimation> configOffset = (_o.Config == null) ? default(Offset<IPlaySpineAnimation>) : IPlaySpineAnimation.Pack(builder, _o.Config);
			return ISetSpineAnimation.CreateISetSpineAnimation(builder, configOffset);
		}

		// Token: 0x04012AC3 RID: 76483
		private Table __p;
	}
}

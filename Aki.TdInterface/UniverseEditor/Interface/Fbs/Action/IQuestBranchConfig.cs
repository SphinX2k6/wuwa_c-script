using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DFB RID: 28155
	public struct IQuestBranchConfig : IFlatbufferObject
	{
		// Token: 0x1700D1D9 RID: 53721
		// (get) Token: 0x06031BC5 RID: 203717 RVA: 0x006BBF06 File Offset: 0x006BA106
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031BC6 RID: 203718 RVA: 0x006BBF13 File Offset: 0x006BA113
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031BC7 RID: 203719 RVA: 0x006BBF1C File Offset: 0x006BA11C
		public static IQuestBranchConfig GetRootAsIQuestBranchConfig(ByteBuffer _bb)
		{
			return IQuestBranchConfig.GetRootAsIQuestBranchConfig(_bb, default(IQuestBranchConfig));
		}

		// Token: 0x06031BC8 RID: 203720 RVA: 0x006BBF38 File Offset: 0x006BA138
		public static IQuestBranchConfig GetRootAsIQuestBranchConfig(ByteBuffer _bb, IQuestBranchConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031BC9 RID: 203721 RVA: 0x006BBF55 File Offset: 0x006BA155
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031BCA RID: 203722 RVA: 0x006BBF64 File Offset: 0x006BA164
		public IQuestBranchConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1DA RID: 53722
		// (get) Token: 0x06031BCB RID: 203723 RVA: 0x006BBF74 File Offset: 0x006BA174
		public bool EnableAnimation
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D1DB RID: 53723
		// (get) Token: 0x06031BCC RID: 203724 RVA: 0x006BBFB4 File Offset: 0x006BA1B4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031BCD RID: 203725 RVA: 0x006BBFF0 File Offset: 0x006BA1F0
		public static Offset<IQuestBranchConfig> CreateIQuestBranchConfig(FlatBufferBuilder builder, bool EnableAnimation = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IQuestBranchConfig.AddNullMask(builder, NullMask);
			IQuestBranchConfig.AddEnableAnimation(builder, EnableAnimation);
			return IQuestBranchConfig.EndIQuestBranchConfig(builder);
		}

		// Token: 0x06031BCE RID: 203726 RVA: 0x006BC00D File Offset: 0x006BA20D
		public static void StartIQuestBranchConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031BCF RID: 203727 RVA: 0x006BC016 File Offset: 0x006BA216
		public static void AddEnableAnimation(FlatBufferBuilder builder, bool enableAnimation)
		{
			builder.AddBool(0, enableAnimation, false);
		}

		// Token: 0x06031BD0 RID: 203728 RVA: 0x006BC021 File Offset: 0x006BA221
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06031BD1 RID: 203729 RVA: 0x006BC02C File Offset: 0x006BA22C
		public static Offset<IQuestBranchConfig> EndIQuestBranchConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQuestBranchConfig>(builder.EndTable());
		}

		// Token: 0x06031BD2 RID: 203730 RVA: 0x006BC03C File Offset: 0x006BA23C
		public IQuestBranchConfigT UnPack()
		{
			IQuestBranchConfigT questBranchConfigT = new IQuestBranchConfigT();
			this.UnPackTo(questBranchConfigT);
			return questBranchConfigT;
		}

		// Token: 0x06031BD3 RID: 203731 RVA: 0x006BC057 File Offset: 0x006BA257
		public void UnPackTo(IQuestBranchConfigT _o)
		{
			_o.EnableAnimation = this.EnableAnimation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031BD4 RID: 203732 RVA: 0x006BC074 File Offset: 0x006BA274
		public static Offset<IQuestBranchConfig> Pack(FlatBufferBuilder builder, IQuestBranchConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestBranchConfig>);
			}
			return IQuestBranchConfig.CreateIQuestBranchConfig(builder, _o.EnableAnimation, _o.NullMask);
		}

		// Token: 0x040117DA RID: 71642
		private Table __p;
	}
}

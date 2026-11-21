using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007576 RID: 30070
	public struct IQuestBranchConfig : IFlatbufferObject
	{
		// Token: 0x1700DD21 RID: 56609
		// (get) Token: 0x06034BC1 RID: 216001 RVA: 0x007175EE File Offset: 0x007157EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034BC2 RID: 216002 RVA: 0x007175FB File Offset: 0x007157FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034BC3 RID: 216003 RVA: 0x00717604 File Offset: 0x00715804
		public static IQuestBranchConfig GetRootAsIQuestBranchConfig(ByteBuffer _bb)
		{
			return IQuestBranchConfig.GetRootAsIQuestBranchConfig(_bb, default(IQuestBranchConfig));
		}

		// Token: 0x06034BC4 RID: 216004 RVA: 0x00717620 File Offset: 0x00715820
		public static IQuestBranchConfig GetRootAsIQuestBranchConfig(ByteBuffer _bb, IQuestBranchConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034BC5 RID: 216005 RVA: 0x0071763D File Offset: 0x0071583D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034BC6 RID: 216006 RVA: 0x0071764C File Offset: 0x0071584C
		public IQuestBranchConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD22 RID: 56610
		// (get) Token: 0x06034BC7 RID: 216007 RVA: 0x0071765C File Offset: 0x0071585C
		public bool EnableAnimation
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DD23 RID: 56611
		// (get) Token: 0x06034BC8 RID: 216008 RVA: 0x0071769C File Offset: 0x0071589C
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

		// Token: 0x06034BC9 RID: 216009 RVA: 0x007176D8 File Offset: 0x007158D8
		public static Offset<IQuestBranchConfig> CreateIQuestBranchConfig(FlatBufferBuilder builder, bool EnableAnimation = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IQuestBranchConfig.AddNullMask(builder, NullMask);
			IQuestBranchConfig.AddEnableAnimation(builder, EnableAnimation);
			return IQuestBranchConfig.EndIQuestBranchConfig(builder);
		}

		// Token: 0x06034BCA RID: 216010 RVA: 0x007176F5 File Offset: 0x007158F5
		public static void StartIQuestBranchConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034BCB RID: 216011 RVA: 0x007176FE File Offset: 0x007158FE
		public static void AddEnableAnimation(FlatBufferBuilder builder, bool enableAnimation)
		{
			builder.AddBool(0, enableAnimation, false);
		}

		// Token: 0x06034BCC RID: 216012 RVA: 0x00717709 File Offset: 0x00715909
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06034BCD RID: 216013 RVA: 0x00717714 File Offset: 0x00715914
		public static Offset<IQuestBranchConfig> EndIQuestBranchConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQuestBranchConfig>(builder.EndTable());
		}

		// Token: 0x06034BCE RID: 216014 RVA: 0x00717724 File Offset: 0x00715924
		public IQuestBranchConfigT UnPack()
		{
			IQuestBranchConfigT questBranchConfigT = new IQuestBranchConfigT();
			this.UnPackTo(questBranchConfigT);
			return questBranchConfigT;
		}

		// Token: 0x06034BCF RID: 216015 RVA: 0x0071773F File Offset: 0x0071593F
		public void UnPackTo(IQuestBranchConfigT _o)
		{
			_o.EnableAnimation = this.EnableAnimation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034BD0 RID: 216016 RVA: 0x0071775C File Offset: 0x0071595C
		public static Offset<IQuestBranchConfig> Pack(FlatBufferBuilder builder, IQuestBranchConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestBranchConfig>);
			}
			return IQuestBranchConfig.CreateIQuestBranchConfig(builder, _o.EnableAnimation, _o.NullMask);
		}

		// Token: 0x04012756 RID: 75606
		private Table __p;
	}
}

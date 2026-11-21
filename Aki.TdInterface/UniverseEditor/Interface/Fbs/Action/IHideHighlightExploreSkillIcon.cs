using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F9E RID: 28574
	public struct IHideHighlightExploreSkillIcon : IFlatbufferObject
	{
		// Token: 0x1700D147 RID: 53575
		// (get) Token: 0x06031775 RID: 202613 RVA: 0x006B4AFA File Offset: 0x006B2CFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031776 RID: 202614 RVA: 0x006B4B07 File Offset: 0x006B2D07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031777 RID: 202615 RVA: 0x006B4B10 File Offset: 0x006B2D10
		public static IHideHighlightExploreSkillIcon GetRootAsIHideHighlightExploreSkillIcon(ByteBuffer _bb)
		{
			return IHideHighlightExploreSkillIcon.GetRootAsIHideHighlightExploreSkillIcon(_bb, default(IHideHighlightExploreSkillIcon));
		}

		// Token: 0x06031778 RID: 202616 RVA: 0x006B4B2C File Offset: 0x006B2D2C
		public static IHideHighlightExploreSkillIcon GetRootAsIHideHighlightExploreSkillIcon(ByteBuffer _bb, IHideHighlightExploreSkillIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031779 RID: 202617 RVA: 0x006B4B49 File Offset: 0x006B2D49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603177A RID: 202618 RVA: 0x006B4B58 File Offset: 0x006B2D58
		public IHideHighlightExploreSkillIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D148 RID: 53576
		// (get) Token: 0x0603177B RID: 202619 RVA: 0x006B4B68 File Offset: 0x006B2D68
		public EHighlightExploreSkillIconType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHighlightExploreSkillIconType.Show;
				}
				return (EHighlightExploreSkillIconType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D149 RID: 53577
		// (get) Token: 0x0603177C RID: 202620 RVA: 0x006B4BA4 File Offset: 0x006B2DA4
		public EHighlightType HighlightType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EHighlightType.CommonWhite;
				}
				return (EHighlightType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D14A RID: 53578
		// (get) Token: 0x0603177D RID: 202621 RVA: 0x006B4BE0 File Offset: 0x006B2DE0
		public IHideHighlightExploreSkillIconTargetConfig? TargetConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IHideHighlightExploreSkillIconTargetConfig?(default(IHideHighlightExploreSkillIconTargetConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D14B RID: 53579
		// (get) Token: 0x0603177E RID: 202622 RVA: 0x006B4C40 File Offset: 0x006B2E40
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603177F RID: 202623 RVA: 0x006B4C7D File Offset: 0x006B2E7D
		public static Offset<IHideHighlightExploreSkillIcon> CreateIHideHighlightExploreSkillIcon(FlatBufferBuilder builder, EHighlightExploreSkillIconType Type = EHighlightExploreSkillIconType.Show, EHighlightType HighlightType = EHighlightType.CommonWhite, Offset<IHideHighlightExploreSkillIconTargetConfig> TargetConfigOffset = default(Offset<IHideHighlightExploreSkillIconTargetConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IHideHighlightExploreSkillIcon.AddTargetConfig(builder, TargetConfigOffset);
			IHideHighlightExploreSkillIcon.AddNullMask(builder, NullMask);
			IHideHighlightExploreSkillIcon.AddHighlightType(builder, HighlightType);
			IHideHighlightExploreSkillIcon.AddType(builder, Type);
			return IHideHighlightExploreSkillIcon.EndIHideHighlightExploreSkillIcon(builder);
		}

		// Token: 0x06031780 RID: 202624 RVA: 0x006B4CA9 File Offset: 0x006B2EA9
		public static void StartIHideHighlightExploreSkillIcon(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031781 RID: 202625 RVA: 0x006B4CB2 File Offset: 0x006B2EB2
		public static void AddType(FlatBufferBuilder builder, EHighlightExploreSkillIconType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031782 RID: 202626 RVA: 0x006B4CBD File Offset: 0x006B2EBD
		public static void AddHighlightType(FlatBufferBuilder builder, EHighlightType highlightType)
		{
			builder.AddByte(1, (byte)highlightType, 0);
		}

		// Token: 0x06031783 RID: 202627 RVA: 0x006B4CC8 File Offset: 0x006B2EC8
		public static void AddTargetConfig(FlatBufferBuilder builder, Offset<IHideHighlightExploreSkillIconTargetConfig> targetConfigOffset)
		{
			builder.AddOffset(2, targetConfigOffset.Value, 0);
		}

		// Token: 0x06031784 RID: 202628 RVA: 0x006B4CD8 File Offset: 0x006B2ED8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06031785 RID: 202629 RVA: 0x006B4CE3 File Offset: 0x006B2EE3
		public static Offset<IHideHighlightExploreSkillIcon> EndIHideHighlightExploreSkillIcon(FlatBufferBuilder builder)
		{
			return new Offset<IHideHighlightExploreSkillIcon>(builder.EndTable());
		}

		// Token: 0x06031786 RID: 202630 RVA: 0x006B4CF0 File Offset: 0x006B2EF0
		public IHideHighlightExploreSkillIconT UnPack()
		{
			IHideHighlightExploreSkillIconT hideHighlightExploreSkillIconT = new IHideHighlightExploreSkillIconT();
			this.UnPackTo(hideHighlightExploreSkillIconT);
			return hideHighlightExploreSkillIconT;
		}

		// Token: 0x06031787 RID: 202631 RVA: 0x006B4D0C File Offset: 0x006B2F0C
		public void UnPackTo(IHideHighlightExploreSkillIconT _o)
		{
			_o.Type = this.Type;
			_o.HighlightType = this.HighlightType;
			_o.TargetConfig = ((this.TargetConfig != null) ? this.TargetConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031788 RID: 202632 RVA: 0x006B4D6C File Offset: 0x006B2F6C
		public static Offset<IHideHighlightExploreSkillIcon> Pack(FlatBufferBuilder builder, IHideHighlightExploreSkillIconT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideHighlightExploreSkillIcon>);
			}
			Offset<IHideHighlightExploreSkillIconTargetConfig> targetConfigOffset = (_o.TargetConfig == null) ? default(Offset<IHideHighlightExploreSkillIconTargetConfig>) : IHideHighlightExploreSkillIconTargetConfig.Pack(builder, _o.TargetConfig);
			return IHideHighlightExploreSkillIcon.CreateIHideHighlightExploreSkillIcon(builder, _o.Type, _o.HighlightType, targetConfigOffset, _o.NullMask);
		}

		// Token: 0x04011EC4 RID: 73412
		private Table __p;
	}
}

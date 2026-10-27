using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007409 RID: 29705
	public struct IToggleHighlightExploreUi : IFlatbufferObject
	{
		// Token: 0x1700E19D RID: 57757
		// (get) Token: 0x06035F71 RID: 221041 RVA: 0x00757C22 File Offset: 0x00755E22
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035F72 RID: 221042 RVA: 0x00757C2F File Offset: 0x00755E2F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035F73 RID: 221043 RVA: 0x00757C38 File Offset: 0x00755E38
		public static IToggleHighlightExploreUi GetRootAsIToggleHighlightExploreUi(ByteBuffer _bb)
		{
			return IToggleHighlightExploreUi.GetRootAsIToggleHighlightExploreUi(_bb, default(IToggleHighlightExploreUi));
		}

		// Token: 0x06035F74 RID: 221044 RVA: 0x00757C54 File Offset: 0x00755E54
		public static IToggleHighlightExploreUi GetRootAsIToggleHighlightExploreUi(ByteBuffer _bb, IToggleHighlightExploreUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035F75 RID: 221045 RVA: 0x00757C71 File Offset: 0x00755E71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035F76 RID: 221046 RVA: 0x00757C80 File Offset: 0x00755E80
		public IToggleHighlightExploreUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E19E RID: 57758
		// (get) Token: 0x06035F77 RID: 221047 RVA: 0x00757C90 File Offset: 0x00755E90
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

		// Token: 0x1700E19F RID: 57759
		// (get) Token: 0x06035F78 RID: 221048 RVA: 0x00757CCC File Offset: 0x00755ECC
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

		// Token: 0x1700E1A0 RID: 57760
		// (get) Token: 0x06035F79 RID: 221049 RVA: 0x00757D08 File Offset: 0x00755F08
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035F7A RID: 221050 RVA: 0x00757D44 File Offset: 0x00755F44
		public static Offset<IToggleHighlightExploreUi> CreateIToggleHighlightExploreUi(FlatBufferBuilder builder, EHighlightExploreSkillIconType Type = EHighlightExploreSkillIconType.Show, EHighlightType HighlightType = EHighlightType.CommonWhite, byte NullMask = 0)
		{
			builder.StartTable(3);
			IToggleHighlightExploreUi.AddNullMask(builder, NullMask);
			IToggleHighlightExploreUi.AddHighlightType(builder, HighlightType);
			IToggleHighlightExploreUi.AddType(builder, Type);
			return IToggleHighlightExploreUi.EndIToggleHighlightExploreUi(builder);
		}

		// Token: 0x06035F7B RID: 221051 RVA: 0x00757D68 File Offset: 0x00755F68
		public static void StartIToggleHighlightExploreUi(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035F7C RID: 221052 RVA: 0x00757D71 File Offset: 0x00755F71
		public static void AddType(FlatBufferBuilder builder, EHighlightExploreSkillIconType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035F7D RID: 221053 RVA: 0x00757D7C File Offset: 0x00755F7C
		public static void AddHighlightType(FlatBufferBuilder builder, EHighlightType highlightType)
		{
			builder.AddByte(1, (byte)highlightType, 0);
		}

		// Token: 0x06035F7E RID: 221054 RVA: 0x00757D87 File Offset: 0x00755F87
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06035F7F RID: 221055 RVA: 0x00757D92 File Offset: 0x00755F92
		public static Offset<IToggleHighlightExploreUi> EndIToggleHighlightExploreUi(FlatBufferBuilder builder)
		{
			return new Offset<IToggleHighlightExploreUi>(builder.EndTable());
		}

		// Token: 0x06035F80 RID: 221056 RVA: 0x00757DA0 File Offset: 0x00755FA0
		public IToggleHighlightExploreUiT UnPack()
		{
			IToggleHighlightExploreUiT toggleHighlightExploreUiT = new IToggleHighlightExploreUiT();
			this.UnPackTo(toggleHighlightExploreUiT);
			return toggleHighlightExploreUiT;
		}

		// Token: 0x06035F81 RID: 221057 RVA: 0x00757DBB File Offset: 0x00755FBB
		public void UnPackTo(IToggleHighlightExploreUiT _o)
		{
			_o.Type = this.Type;
			_o.HighlightType = this.HighlightType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035F82 RID: 221058 RVA: 0x00757DE4 File Offset: 0x00755FE4
		public static Offset<IToggleHighlightExploreUi> Pack(FlatBufferBuilder builder, IToggleHighlightExploreUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleHighlightExploreUi>);
			}
			return IToggleHighlightExploreUi.CreateIToggleHighlightExploreUi(builder, _o.Type, _o.HighlightType, _o.NullMask);
		}

		// Token: 0x04012272 RID: 74354
		private Table __p;
	}
}

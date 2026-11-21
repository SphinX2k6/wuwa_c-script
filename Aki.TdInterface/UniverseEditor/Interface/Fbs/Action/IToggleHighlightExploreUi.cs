using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BF3 RID: 31731
	public struct IToggleHighlightExploreUi : IFlatbufferObject
	{
		// Token: 0x1700EDB2 RID: 60850
		// (get) Token: 0x06039324 RID: 234276 RVA: 0x007BA396 File Offset: 0x007B8596
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039325 RID: 234277 RVA: 0x007BA3A3 File Offset: 0x007B85A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039326 RID: 234278 RVA: 0x007BA3AC File Offset: 0x007B85AC
		public static IToggleHighlightExploreUi GetRootAsIToggleHighlightExploreUi(ByteBuffer _bb)
		{
			return IToggleHighlightExploreUi.GetRootAsIToggleHighlightExploreUi(_bb, default(IToggleHighlightExploreUi));
		}

		// Token: 0x06039327 RID: 234279 RVA: 0x007BA3C8 File Offset: 0x007B85C8
		public static IToggleHighlightExploreUi GetRootAsIToggleHighlightExploreUi(ByteBuffer _bb, IToggleHighlightExploreUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039328 RID: 234280 RVA: 0x007BA3E5 File Offset: 0x007B85E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039329 RID: 234281 RVA: 0x007BA3F4 File Offset: 0x007B85F4
		public IToggleHighlightExploreUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDB3 RID: 60851
		// (get) Token: 0x0603932A RID: 234282 RVA: 0x007BA404 File Offset: 0x007B8604
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

		// Token: 0x1700EDB4 RID: 60852
		// (get) Token: 0x0603932B RID: 234283 RVA: 0x007BA440 File Offset: 0x007B8640
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

		// Token: 0x1700EDB5 RID: 60853
		// (get) Token: 0x0603932C RID: 234284 RVA: 0x007BA47C File Offset: 0x007B867C
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

		// Token: 0x0603932D RID: 234285 RVA: 0x007BA4B8 File Offset: 0x007B86B8
		public static Offset<IToggleHighlightExploreUi> CreateIToggleHighlightExploreUi(FlatBufferBuilder builder, EHighlightExploreSkillIconType Type = EHighlightExploreSkillIconType.Show, EHighlightType HighlightType = EHighlightType.CommonWhite, byte NullMask = 0)
		{
			builder.StartTable(3);
			IToggleHighlightExploreUi.AddNullMask(builder, NullMask);
			IToggleHighlightExploreUi.AddHighlightType(builder, HighlightType);
			IToggleHighlightExploreUi.AddType(builder, Type);
			return IToggleHighlightExploreUi.EndIToggleHighlightExploreUi(builder);
		}

		// Token: 0x0603932E RID: 234286 RVA: 0x007BA4DC File Offset: 0x007B86DC
		public static void StartIToggleHighlightExploreUi(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603932F RID: 234287 RVA: 0x007BA4E5 File Offset: 0x007B86E5
		public static void AddType(FlatBufferBuilder builder, EHighlightExploreSkillIconType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039330 RID: 234288 RVA: 0x007BA4F0 File Offset: 0x007B86F0
		public static void AddHighlightType(FlatBufferBuilder builder, EHighlightType highlightType)
		{
			builder.AddByte(1, (byte)highlightType, 0);
		}

		// Token: 0x06039331 RID: 234289 RVA: 0x007BA4FB File Offset: 0x007B86FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06039332 RID: 234290 RVA: 0x007BA506 File Offset: 0x007B8706
		public static Offset<IToggleHighlightExploreUi> EndIToggleHighlightExploreUi(FlatBufferBuilder builder)
		{
			return new Offset<IToggleHighlightExploreUi>(builder.EndTable());
		}

		// Token: 0x06039333 RID: 234291 RVA: 0x007BA514 File Offset: 0x007B8714
		public IToggleHighlightExploreUiT UnPack()
		{
			IToggleHighlightExploreUiT toggleHighlightExploreUiT = new IToggleHighlightExploreUiT();
			this.UnPackTo(toggleHighlightExploreUiT);
			return toggleHighlightExploreUiT;
		}

		// Token: 0x06039334 RID: 234292 RVA: 0x007BA52F File Offset: 0x007B872F
		public void UnPackTo(IToggleHighlightExploreUiT _o)
		{
			_o.Type = this.Type;
			_o.HighlightType = this.HighlightType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039335 RID: 234293 RVA: 0x007BA558 File Offset: 0x007B8758
		public static Offset<IToggleHighlightExploreUi> Pack(FlatBufferBuilder builder, IToggleHighlightExploreUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleHighlightExploreUi>);
			}
			return IToggleHighlightExploreUi.CreateIToggleHighlightExploreUi(builder, _o.Type, _o.HighlightType, _o.NullMask);
		}

		// Token: 0x0401328E RID: 78478
		private Table __p;
	}
}

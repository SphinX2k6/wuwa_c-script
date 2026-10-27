using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200420B RID: 16907
	public struct ITrackReturnDungeon : IFlatbufferObject
	{
		// Token: 0x17007815 RID: 30741
		// (get) Token: 0x06018F98 RID: 102296 RVA: 0x0039828C File Offset: 0x0039648C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018F99 RID: 102297 RVA: 0x00398299 File Offset: 0x00396499
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018F9A RID: 102298 RVA: 0x003982A0 File Offset: 0x003964A0
		public static ITrackReturnDungeon GetRootAsITrackReturnDungeon(ByteBuffer _bb)
		{
			return ITrackReturnDungeon.GetRootAsITrackReturnDungeon(_bb, default(ITrackReturnDungeon));
		}

		// Token: 0x06018F9B RID: 102299 RVA: 0x003982BC File Offset: 0x003964BC
		public static ITrackReturnDungeon GetRootAsITrackReturnDungeon(ByteBuffer _bb, ITrackReturnDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018F9C RID: 102300 RVA: 0x003982D9 File Offset: 0x003964D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018F9D RID: 102301 RVA: 0x003982E8 File Offset: 0x003964E8
		public ITrackReturnDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007816 RID: 30742
		// (get) Token: 0x06018F9E RID: 102302 RVA: 0x003982F8 File Offset: 0x003964F8
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007817 RID: 30743
		// (get) Token: 0x06018F9F RID: 102303 RVA: 0x00398334 File Offset: 0x00396534
		public bool IsRegroup
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007818 RID: 30744
		// (get) Token: 0x06018FA0 RID: 102304 RVA: 0x00398374 File Offset: 0x00396574
		public TTeleportTransitionOption TransitionOptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTeleportTransitionOption.NONE;
				}
				return (TTeleportTransitionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018FA1 RID: 102305 RVA: 0x003983B0 File Offset: 0x003965B0
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018FA2 RID: 102306 RVA: 0x003983F8 File Offset: 0x003965F8
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x06018FA3 RID: 102307 RVA: 0x00398414 File Offset: 0x00396614
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06018FA4 RID: 102308 RVA: 0x00398430 File Offset: 0x00396630
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x06018FA5 RID: 102309 RVA: 0x0039844C File Offset: 0x0039664C
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06018FA6 RID: 102310 RVA: 0x00398468 File Offset: 0x00396668
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x06018FA7 RID: 102311 RVA: 0x00398484 File Offset: 0x00396684
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06018FA8 RID: 102312 RVA: 0x003984A0 File Offset: 0x003966A0
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x06018FA9 RID: 102313 RVA: 0x003984BC File Offset: 0x003966BC
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x06018FAA RID: 102314 RVA: 0x003984D8 File Offset: 0x003966D8
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x06018FAB RID: 102315 RVA: 0x003984F4 File Offset: 0x003966F4
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06018FAC RID: 102316 RVA: 0x00398510 File Offset: 0x00396710
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x17007819 RID: 30745
		// (get) Token: 0x06018FAD RID: 102317 RVA: 0x0039852C File Offset: 0x0039672C
		public string TidTip
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018FAE RID: 102318 RVA: 0x00398564 File Offset: 0x00396764
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06018FAF RID: 102319 RVA: 0x00398574 File Offset: 0x00396774
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700781A RID: 30746
		// (get) Token: 0x06018FB0 RID: 102320 RVA: 0x00398584 File Offset: 0x00396784
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018FB1 RID: 102321 RVA: 0x003985C1 File Offset: 0x003967C1
		public static Offset<ITrackReturnDungeon> CreateITrackReturnDungeon(FlatBufferBuilder builder, int DungeonId = 0, bool IsRegroup = false, TTeleportTransitionOption TransitionOption_type = TTeleportTransitionOption.NONE, int TransitionOptionOffset = 0, StringOffset TidTipOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			ITrackReturnDungeon.AddTidTip(builder, TidTipOffset);
			ITrackReturnDungeon.AddTransitionOption(builder, TransitionOptionOffset);
			ITrackReturnDungeon.AddDungeonId(builder, DungeonId);
			ITrackReturnDungeon.AddNullMask(builder, NullMask);
			ITrackReturnDungeon.AddTransitionOptionType(builder, TransitionOption_type);
			ITrackReturnDungeon.AddIsRegroup(builder, IsRegroup);
			return ITrackReturnDungeon.EndITrackReturnDungeon(builder);
		}

		// Token: 0x06018FB2 RID: 102322 RVA: 0x003985FD File Offset: 0x003967FD
		public static void StartITrackReturnDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06018FB3 RID: 102323 RVA: 0x00398606 File Offset: 0x00396806
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(0, dungeonId, 0);
		}

		// Token: 0x06018FB4 RID: 102324 RVA: 0x00398611 File Offset: 0x00396811
		public static void AddIsRegroup(FlatBufferBuilder builder, bool isRegroup)
		{
			builder.AddBool(1, isRegroup, false);
		}

		// Token: 0x06018FB5 RID: 102325 RVA: 0x0039861C File Offset: 0x0039681C
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(2, (byte)transitionOptionType, 0);
		}

		// Token: 0x06018FB6 RID: 102326 RVA: 0x00398627 File Offset: 0x00396827
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(3, transitionOptionOffset, 0);
		}

		// Token: 0x06018FB7 RID: 102327 RVA: 0x00398632 File Offset: 0x00396832
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(4, tidTipOffset.Value, 0);
		}

		// Token: 0x06018FB8 RID: 102328 RVA: 0x00398642 File Offset: 0x00396842
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06018FB9 RID: 102329 RVA: 0x0039864D File Offset: 0x0039684D
		public static Offset<ITrackReturnDungeon> EndITrackReturnDungeon(FlatBufferBuilder builder)
		{
			return new Offset<ITrackReturnDungeon>(builder.EndTable());
		}

		// Token: 0x06018FBA RID: 102330 RVA: 0x0039865C File Offset: 0x0039685C
		public ITrackReturnDungeonT UnPack()
		{
			ITrackReturnDungeonT trackReturnDungeonT = new ITrackReturnDungeonT();
			this.UnPackTo(trackReturnDungeonT);
			return trackReturnDungeonT;
		}

		// Token: 0x06018FBB RID: 102331 RVA: 0x00398678 File Offset: 0x00396878
		public void UnPackTo(ITrackReturnDungeonT _o)
		{
			_o.DungeonId = this.DungeonId;
			_o.IsRegroup = this.IsRegroup;
			_o.TransitionOption = new TTeleportTransitionOptionUnion();
			_o.TransitionOption.Type = this.TransitionOptionType;
			switch (this.TransitionOptionType)
			{
			case TTeleportTransitionOption.ITeleportTransitionInDigitalScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInDigitalScreen>() != null) ? this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionInSeamlessType:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInSeamlessType>() != null) ? this.TransitionOption<ITeleportTransitionInSeamlessType>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCenterText:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCenterText>() != null) ? this.TransitionOption<ITeleportTransitionWithCenterText>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCharacterDisplay:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCharacterDisplay>() != null) ? this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithEffect:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithEffect>() != null) ? this.TransitionOption<ITeleportTransitionWithEffect>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithFadeInScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithFadeInScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithMp4:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithMp4>() != null) ? this.TransitionOption<ITeleportTransitionWithMp4>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithPlayFlow:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithPlayFlow>() != null) ? this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithSpecialCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value.UnPack() : null);
				break;
			}
			_o.TidTip = this.TidTip;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018FBC RID: 102332 RVA: 0x00398998 File Offset: 0x00396B98
		public static Offset<ITrackReturnDungeon> Pack(FlatBufferBuilder builder, ITrackReturnDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackReturnDungeon>);
			}
			TTeleportTransitionOption transitionOption_type = (_o.TransitionOption == null) ? TTeleportTransitionOption.NONE : _o.TransitionOption.Type;
			int transitionOptionOffset = (_o.TransitionOption == null) ? 0 : TTeleportTransitionOptionUnion.Pack(builder, _o.TransitionOption);
			StringOffset tidTipOffset = (_o.TidTip == null) ? default(StringOffset) : builder.CreateString(_o.TidTip);
			return ITrackReturnDungeon.CreateITrackReturnDungeon(builder, _o.DungeonId, _o.IsRegroup, transitionOption_type, transitionOptionOffset, tidTipOffset, _o.NullMask);
		}

		// Token: 0x0400BE79 RID: 48761
		private Table __p;
	}
}

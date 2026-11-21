using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004667 RID: 18023
	public struct ITrackReturnDungeon : IFlatbufferObject
	{
		// Token: 0x17007E46 RID: 32326
		// (get) Token: 0x0601A704 RID: 108292 RVA: 0x003C3964 File Offset: 0x003C1B64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A705 RID: 108293 RVA: 0x003C3971 File Offset: 0x003C1B71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A706 RID: 108294 RVA: 0x003C3978 File Offset: 0x003C1B78
		public static ITrackReturnDungeon GetRootAsITrackReturnDungeon(ByteBuffer _bb)
		{
			return ITrackReturnDungeon.GetRootAsITrackReturnDungeon(_bb, default(ITrackReturnDungeon));
		}

		// Token: 0x0601A707 RID: 108295 RVA: 0x003C3994 File Offset: 0x003C1B94
		public static ITrackReturnDungeon GetRootAsITrackReturnDungeon(ByteBuffer _bb, ITrackReturnDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A708 RID: 108296 RVA: 0x003C39B1 File Offset: 0x003C1BB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A709 RID: 108297 RVA: 0x003C39C0 File Offset: 0x003C1BC0
		public ITrackReturnDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E47 RID: 32327
		// (get) Token: 0x0601A70A RID: 108298 RVA: 0x003C39D0 File Offset: 0x003C1BD0
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

		// Token: 0x17007E48 RID: 32328
		// (get) Token: 0x0601A70B RID: 108299 RVA: 0x003C3A0C File Offset: 0x003C1C0C
		public bool IsRegroup
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007E49 RID: 32329
		// (get) Token: 0x0601A70C RID: 108300 RVA: 0x003C3A4C File Offset: 0x003C1C4C
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

		// Token: 0x0601A70D RID: 108301 RVA: 0x003C3A88 File Offset: 0x003C1C88
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A70E RID: 108302 RVA: 0x003C3AD0 File Offset: 0x003C1CD0
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x0601A70F RID: 108303 RVA: 0x003C3AEC File Offset: 0x003C1CEC
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x0601A710 RID: 108304 RVA: 0x003C3B08 File Offset: 0x003C1D08
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x0601A711 RID: 108305 RVA: 0x003C3B24 File Offset: 0x003C1D24
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x0601A712 RID: 108306 RVA: 0x003C3B40 File Offset: 0x003C1D40
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x0601A713 RID: 108307 RVA: 0x003C3B5C File Offset: 0x003C1D5C
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x0601A714 RID: 108308 RVA: 0x003C3B78 File Offset: 0x003C1D78
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x0601A715 RID: 108309 RVA: 0x003C3B94 File Offset: 0x003C1D94
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x0601A716 RID: 108310 RVA: 0x003C3BB0 File Offset: 0x003C1DB0
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x0601A717 RID: 108311 RVA: 0x003C3BCC File Offset: 0x003C1DCC
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x0601A718 RID: 108312 RVA: 0x003C3BE8 File Offset: 0x003C1DE8
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x17007E4A RID: 32330
		// (get) Token: 0x0601A719 RID: 108313 RVA: 0x003C3C04 File Offset: 0x003C1E04
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

		// Token: 0x0601A71A RID: 108314 RVA: 0x003C3C3C File Offset: 0x003C1E3C
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601A71B RID: 108315 RVA: 0x003C3C4C File Offset: 0x003C1E4C
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17007E4B RID: 32331
		// (get) Token: 0x0601A71C RID: 108316 RVA: 0x003C3C5C File Offset: 0x003C1E5C
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

		// Token: 0x0601A71D RID: 108317 RVA: 0x003C3C99 File Offset: 0x003C1E99
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

		// Token: 0x0601A71E RID: 108318 RVA: 0x003C3CD5 File Offset: 0x003C1ED5
		public static void StartITrackReturnDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601A71F RID: 108319 RVA: 0x003C3CDE File Offset: 0x003C1EDE
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(0, dungeonId, 0);
		}

		// Token: 0x0601A720 RID: 108320 RVA: 0x003C3CE9 File Offset: 0x003C1EE9
		public static void AddIsRegroup(FlatBufferBuilder builder, bool isRegroup)
		{
			builder.AddBool(1, isRegroup, false);
		}

		// Token: 0x0601A721 RID: 108321 RVA: 0x003C3CF4 File Offset: 0x003C1EF4
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(2, (byte)transitionOptionType, 0);
		}

		// Token: 0x0601A722 RID: 108322 RVA: 0x003C3CFF File Offset: 0x003C1EFF
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(3, transitionOptionOffset, 0);
		}

		// Token: 0x0601A723 RID: 108323 RVA: 0x003C3D0A File Offset: 0x003C1F0A
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(4, tidTipOffset.Value, 0);
		}

		// Token: 0x0601A724 RID: 108324 RVA: 0x003C3D1A File Offset: 0x003C1F1A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601A725 RID: 108325 RVA: 0x003C3D25 File Offset: 0x003C1F25
		public static Offset<ITrackReturnDungeon> EndITrackReturnDungeon(FlatBufferBuilder builder)
		{
			return new Offset<ITrackReturnDungeon>(builder.EndTable());
		}

		// Token: 0x0601A726 RID: 108326 RVA: 0x003C3D34 File Offset: 0x003C1F34
		public ITrackReturnDungeonT UnPack()
		{
			ITrackReturnDungeonT trackReturnDungeonT = new ITrackReturnDungeonT();
			this.UnPackTo(trackReturnDungeonT);
			return trackReturnDungeonT;
		}

		// Token: 0x0601A727 RID: 108327 RVA: 0x003C3D50 File Offset: 0x003C1F50
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

		// Token: 0x0601A728 RID: 108328 RVA: 0x003C4070 File Offset: 0x003C2270
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

		// Token: 0x0400C886 RID: 51334
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006071 RID: 24689
	public struct IActionConfigItem : IFlatbufferObject
	{
		// Token: 0x1700B5EE RID: 46574
		// (get) Token: 0x06029CE6 RID: 171238 RVA: 0x005BC6C0 File Offset: 0x005BA8C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029CE7 RID: 171239 RVA: 0x005BC6CD File Offset: 0x005BA8CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029CE8 RID: 171240 RVA: 0x005BC6D4 File Offset: 0x005BA8D4
		public static IActionConfigItem GetRootAsIActionConfigItem(ByteBuffer _bb)
		{
			return IActionConfigItem.GetRootAsIActionConfigItem(_bb, default(IActionConfigItem));
		}

		// Token: 0x06029CE9 RID: 171241 RVA: 0x005BC6F0 File Offset: 0x005BA8F0
		public static IActionConfigItem GetRootAsIActionConfigItem(ByteBuffer _bb, IActionConfigItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029CEA RID: 171242 RVA: 0x005BC70D File Offset: 0x005BA90D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029CEB RID: 171243 RVA: 0x005BC71C File Offset: 0x005BA91C
		public IActionConfigItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5EF RID: 46575
		// (get) Token: 0x06029CEC RID: 171244 RVA: 0x005BC72C File Offset: 0x005BA92C
		public EOnlineParticipateRule OnlineParticipateRule
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOnlineParticipateRule.AnyPlayer;
				}
				return (EOnlineParticipateRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B5F0 RID: 46576
		// (get) Token: 0x06029CED RID: 171245 RVA: 0x005BC768 File Offset: 0x005BA968
		public bool IsDetectScreenOccupation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B5F1 RID: 46577
		// (get) Token: 0x06029CEE RID: 171246 RVA: 0x005BC7A8 File Offset: 0x005BA9A8
		public bool IsWithResultOnly
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B5F2 RID: 46578
		// (get) Token: 0x06029CEF RID: 171247 RVA: 0x005BC7E8 File Offset: 0x005BA9E8
		public bool IsOperatePlayer
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B5F3 RID: 46579
		// (get) Token: 0x06029CF0 RID: 171248 RVA: 0x005BC828 File Offset: 0x005BAA28
		public string CnName
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

		// Token: 0x06029CF1 RID: 171249 RVA: 0x005BC860 File Offset: 0x005BAA60
		public Span<byte> GetCnNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06029CF2 RID: 171250 RVA: 0x005BC870 File Offset: 0x005BAA70
		public byte[] GetCnNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700B5F4 RID: 46580
		// (get) Token: 0x06029CF3 RID: 171251 RVA: 0x005BC880 File Offset: 0x005BAA80
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

		// Token: 0x06029CF4 RID: 171252 RVA: 0x005BC8BD File Offset: 0x005BAABD
		public static Offset<IActionConfigItem> CreateIActionConfigItem(FlatBufferBuilder builder, EOnlineParticipateRule OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer, bool IsDetectScreenOccupation = false, bool IsWithResultOnly = false, bool IsOperatePlayer = false, StringOffset CnNameOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IActionConfigItem.AddCnName(builder, CnNameOffset);
			IActionConfigItem.AddNullMask(builder, NullMask);
			IActionConfigItem.AddIsOperatePlayer(builder, IsOperatePlayer);
			IActionConfigItem.AddIsWithResultOnly(builder, IsWithResultOnly);
			IActionConfigItem.AddIsDetectScreenOccupation(builder, IsDetectScreenOccupation);
			IActionConfigItem.AddOnlineParticipateRule(builder, OnlineParticipateRule);
			return IActionConfigItem.EndIActionConfigItem(builder);
		}

		// Token: 0x06029CF5 RID: 171253 RVA: 0x005BC8F9 File Offset: 0x005BAAF9
		public static void StartIActionConfigItem(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06029CF6 RID: 171254 RVA: 0x005BC902 File Offset: 0x005BAB02
		public static void AddOnlineParticipateRule(FlatBufferBuilder builder, EOnlineParticipateRule onlineParticipateRule)
		{
			builder.AddByte(0, (byte)onlineParticipateRule, 0);
		}

		// Token: 0x06029CF7 RID: 171255 RVA: 0x005BC90D File Offset: 0x005BAB0D
		public static void AddIsDetectScreenOccupation(FlatBufferBuilder builder, bool isDetectScreenOccupation)
		{
			builder.AddBool(1, isDetectScreenOccupation, false);
		}

		// Token: 0x06029CF8 RID: 171256 RVA: 0x005BC918 File Offset: 0x005BAB18
		public static void AddIsWithResultOnly(FlatBufferBuilder builder, bool isWithResultOnly)
		{
			builder.AddBool(2, isWithResultOnly, false);
		}

		// Token: 0x06029CF9 RID: 171257 RVA: 0x005BC923 File Offset: 0x005BAB23
		public static void AddIsOperatePlayer(FlatBufferBuilder builder, bool isOperatePlayer)
		{
			builder.AddBool(3, isOperatePlayer, false);
		}

		// Token: 0x06029CFA RID: 171258 RVA: 0x005BC92E File Offset: 0x005BAB2E
		public static void AddCnName(FlatBufferBuilder builder, StringOffset cnNameOffset)
		{
			builder.AddOffset(4, cnNameOffset.Value, 0);
		}

		// Token: 0x06029CFB RID: 171259 RVA: 0x005BC93E File Offset: 0x005BAB3E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06029CFC RID: 171260 RVA: 0x005BC949 File Offset: 0x005BAB49
		public static Offset<IActionConfigItem> EndIActionConfigItem(FlatBufferBuilder builder)
		{
			return new Offset<IActionConfigItem>(builder.EndTable());
		}

		// Token: 0x06029CFD RID: 171261 RVA: 0x005BC958 File Offset: 0x005BAB58
		public IActionConfigItemT UnPack()
		{
			IActionConfigItemT actionConfigItemT = new IActionConfigItemT();
			this.UnPackTo(actionConfigItemT);
			return actionConfigItemT;
		}

		// Token: 0x06029CFE RID: 171262 RVA: 0x005BC974 File Offset: 0x005BAB74
		public void UnPackTo(IActionConfigItemT _o)
		{
			_o.OnlineParticipateRule = this.OnlineParticipateRule;
			_o.IsDetectScreenOccupation = this.IsDetectScreenOccupation;
			_o.IsWithResultOnly = this.IsWithResultOnly;
			_o.IsOperatePlayer = this.IsOperatePlayer;
			_o.CnName = this.CnName;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029CFF RID: 171263 RVA: 0x005BC9CC File Offset: 0x005BABCC
		public static Offset<IActionConfigItem> Pack(FlatBufferBuilder builder, IActionConfigItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionConfigItem>);
			}
			StringOffset cnNameOffset = (_o.CnName == null) ? default(StringOffset) : builder.CreateString(_o.CnName);
			return IActionConfigItem.CreateIActionConfigItem(builder, _o.OnlineParticipateRule, _o.IsDetectScreenOccupation, _o.IsWithResultOnly, _o.IsOperatePlayer, cnNameOffset, _o.NullMask);
		}

		// Token: 0x04010235 RID: 66101
		private Table __p;
	}
}

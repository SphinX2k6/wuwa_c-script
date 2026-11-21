using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AB2 RID: 31410
	public struct ITalkItemDisableAutoSelectOptionGroup : IFlatbufferObject
	{
		// Token: 0x1700E86F RID: 59503
		// (get) Token: 0x06037E29 RID: 228905 RVA: 0x00780ED5 File Offset: 0x0077F0D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037E2A RID: 228906 RVA: 0x00780EE2 File Offset: 0x0077F0E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037E2B RID: 228907 RVA: 0x00780EEC File Offset: 0x0077F0EC
		public static ITalkItemDisableAutoSelectOptionGroup GetRootAsITalkItemDisableAutoSelectOptionGroup(ByteBuffer _bb)
		{
			return ITalkItemDisableAutoSelectOptionGroup.GetRootAsITalkItemDisableAutoSelectOptionGroup(_bb, default(ITalkItemDisableAutoSelectOptionGroup));
		}

		// Token: 0x06037E2C RID: 228908 RVA: 0x00780F08 File Offset: 0x0077F108
		public static ITalkItemDisableAutoSelectOptionGroup GetRootAsITalkItemDisableAutoSelectOptionGroup(ByteBuffer _bb, ITalkItemDisableAutoSelectOptionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037E2D RID: 228909 RVA: 0x00780F25 File Offset: 0x0077F125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037E2E RID: 228910 RVA: 0x00780F34 File Offset: 0x0077F134
		public ITalkItemDisableAutoSelectOptionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E870 RID: 59504
		// (get) Token: 0x06037E2F RID: 228911 RVA: 0x00780F44 File Offset: 0x0077F144
		public string TextKey
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037E30 RID: 228912 RVA: 0x00780F7B File Offset: 0x0077F17B
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06037E31 RID: 228913 RVA: 0x00780F8A File Offset: 0x0077F18A
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E871 RID: 59505
		// (get) Token: 0x06037E32 RID: 228914 RVA: 0x00780F98 File Offset: 0x0077F198
		public int IconId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E872 RID: 59506
		// (get) Token: 0x06037E33 RID: 228915 RVA: 0x00780FD4 File Offset: 0x0077F1D4
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

		// Token: 0x06037E34 RID: 228916 RVA: 0x00781010 File Offset: 0x0077F210
		public static Offset<ITalkItemDisableAutoSelectOptionGroup> CreateITalkItemDisableAutoSelectOptionGroup(FlatBufferBuilder builder, StringOffset TextKeyOffset = default(StringOffset), int IconId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITalkItemDisableAutoSelectOptionGroup.AddIconId(builder, IconId);
			ITalkItemDisableAutoSelectOptionGroup.AddTextKey(builder, TextKeyOffset);
			ITalkItemDisableAutoSelectOptionGroup.AddNullMask(builder, NullMask);
			return ITalkItemDisableAutoSelectOptionGroup.EndITalkItemDisableAutoSelectOptionGroup(builder);
		}

		// Token: 0x06037E35 RID: 228917 RVA: 0x00781034 File Offset: 0x0077F234
		public static void StartITalkItemDisableAutoSelectOptionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06037E36 RID: 228918 RVA: 0x0078103D File Offset: 0x0077F23D
		public static void AddTextKey(FlatBufferBuilder builder, StringOffset textKeyOffset)
		{
			builder.AddOffset(0, textKeyOffset.Value, 0);
		}

		// Token: 0x06037E37 RID: 228919 RVA: 0x0078104D File Offset: 0x0077F24D
		public static void AddIconId(FlatBufferBuilder builder, int iconId)
		{
			builder.AddInt(1, iconId, 0);
		}

		// Token: 0x06037E38 RID: 228920 RVA: 0x00781058 File Offset: 0x0077F258
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06037E39 RID: 228921 RVA: 0x00781063 File Offset: 0x0077F263
		public static Offset<ITalkItemDisableAutoSelectOptionGroup> EndITalkItemDisableAutoSelectOptionGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemDisableAutoSelectOptionGroup>(builder.EndTable());
		}

		// Token: 0x06037E3A RID: 228922 RVA: 0x00781070 File Offset: 0x0077F270
		public ITalkItemDisableAutoSelectOptionGroupT UnPack()
		{
			ITalkItemDisableAutoSelectOptionGroupT talkItemDisableAutoSelectOptionGroupT = new ITalkItemDisableAutoSelectOptionGroupT();
			this.UnPackTo(talkItemDisableAutoSelectOptionGroupT);
			return talkItemDisableAutoSelectOptionGroupT;
		}

		// Token: 0x06037E3B RID: 228923 RVA: 0x0078108B File Offset: 0x0077F28B
		public void UnPackTo(ITalkItemDisableAutoSelectOptionGroupT _o)
		{
			_o.TextKey = this.TextKey;
			_o.IconId = this.IconId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06037E3C RID: 228924 RVA: 0x007810B4 File Offset: 0x0077F2B4
		public static Offset<ITalkItemDisableAutoSelectOptionGroup> Pack(FlatBufferBuilder builder, ITalkItemDisableAutoSelectOptionGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemDisableAutoSelectOptionGroup>);
			}
			StringOffset textKeyOffset = (_o.TextKey == null) ? default(StringOffset) : builder.CreateString(_o.TextKey);
			return ITalkItemDisableAutoSelectOptionGroup.CreateITalkItemDisableAutoSelectOptionGroup(builder, textKeyOffset, _o.IconId, _o.NullMask);
		}

		// Token: 0x04012F30 RID: 77616
		private Table __p;
	}
}

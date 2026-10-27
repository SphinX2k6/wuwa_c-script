using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200650D RID: 25869
	public struct ICustomScreenTextSetting : IFlatbufferObject
	{
		// Token: 0x1700C05C RID: 49244
		// (get) Token: 0x0602CDF7 RID: 183799 RVA: 0x00629D7A File Offset: 0x00627F7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CDF8 RID: 183800 RVA: 0x00629D87 File Offset: 0x00627F87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CDF9 RID: 183801 RVA: 0x00629D90 File Offset: 0x00627F90
		public static ICustomScreenTextSetting GetRootAsICustomScreenTextSetting(ByteBuffer _bb)
		{
			return ICustomScreenTextSetting.GetRootAsICustomScreenTextSetting(_bb, default(ICustomScreenTextSetting));
		}

		// Token: 0x0602CDFA RID: 183802 RVA: 0x00629DAC File Offset: 0x00627FAC
		public static ICustomScreenTextSetting GetRootAsICustomScreenTextSetting(ByteBuffer _bb, ICustomScreenTextSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CDFB RID: 183803 RVA: 0x00629DC9 File Offset: 0x00627FC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CDFC RID: 183804 RVA: 0x00629DD8 File Offset: 0x00627FD8
		public ICustomScreenTextSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C05D RID: 49245
		// (get) Token: 0x0602CDFD RID: 183805 RVA: 0x00629DE8 File Offset: 0x00627FE8
		public bool IsShowTextInfo
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C05E RID: 49246
		// (get) Token: 0x0602CDFE RID: 183806 RVA: 0x00629E28 File Offset: 0x00628028
		public string TidTextContent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CDFF RID: 183807 RVA: 0x00629E5F File Offset: 0x0062805F
		public Span<byte> GetTidTextContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CE00 RID: 183808 RVA: 0x00629E6E File Offset: 0x0062806E
		public byte[] GetTidTextContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C05F RID: 49247
		// (get) Token: 0x0602CE01 RID: 183809 RVA: 0x00629E7C File Offset: 0x0062807C
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

		// Token: 0x0602CE02 RID: 183810 RVA: 0x00629EB8 File Offset: 0x006280B8
		public static Offset<ICustomScreenTextSetting> CreateICustomScreenTextSetting(FlatBufferBuilder builder, bool IsShowTextInfo = false, StringOffset TidTextContentOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ICustomScreenTextSetting.AddTidTextContent(builder, TidTextContentOffset);
			ICustomScreenTextSetting.AddNullMask(builder, NullMask);
			ICustomScreenTextSetting.AddIsShowTextInfo(builder, IsShowTextInfo);
			return ICustomScreenTextSetting.EndICustomScreenTextSetting(builder);
		}

		// Token: 0x0602CE03 RID: 183811 RVA: 0x00629EDC File Offset: 0x006280DC
		public static void StartICustomScreenTextSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CE04 RID: 183812 RVA: 0x00629EE5 File Offset: 0x006280E5
		public static void AddIsShowTextInfo(FlatBufferBuilder builder, bool isShowTextInfo)
		{
			builder.AddBool(0, isShowTextInfo, false);
		}

		// Token: 0x0602CE05 RID: 183813 RVA: 0x00629EF0 File Offset: 0x006280F0
		public static void AddTidTextContent(FlatBufferBuilder builder, StringOffset tidTextContentOffset)
		{
			builder.AddOffset(1, tidTextContentOffset.Value, 0);
		}

		// Token: 0x0602CE06 RID: 183814 RVA: 0x00629F00 File Offset: 0x00628100
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602CE07 RID: 183815 RVA: 0x00629F0B File Offset: 0x0062810B
		public static Offset<ICustomScreenTextSetting> EndICustomScreenTextSetting(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenTextSetting>(builder.EndTable());
		}

		// Token: 0x0602CE08 RID: 183816 RVA: 0x00629F18 File Offset: 0x00628118
		public ICustomScreenTextSettingT UnPack()
		{
			ICustomScreenTextSettingT customScreenTextSettingT = new ICustomScreenTextSettingT();
			this.UnPackTo(customScreenTextSettingT);
			return customScreenTextSettingT;
		}

		// Token: 0x0602CE09 RID: 183817 RVA: 0x00629F33 File Offset: 0x00628133
		public void UnPackTo(ICustomScreenTextSettingT _o)
		{
			_o.IsShowTextInfo = this.IsShowTextInfo;
			_o.TidTextContent = this.TidTextContent;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CE0A RID: 183818 RVA: 0x00629F5C File Offset: 0x0062815C
		public static Offset<ICustomScreenTextSetting> Pack(FlatBufferBuilder builder, ICustomScreenTextSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenTextSetting>);
			}
			StringOffset tidTextContentOffset = (_o.TidTextContent == null) ? default(StringOffset) : builder.CreateString(_o.TidTextContent);
			return ICustomScreenTextSetting.CreateICustomScreenTextSetting(builder, _o.IsShowTextInfo, tidTextContentOffset, _o.NullMask);
		}

		// Token: 0x04010B51 RID: 68433
		private Table __p;
	}
}

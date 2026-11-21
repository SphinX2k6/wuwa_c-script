using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B7B RID: 27515
	public struct ICustomScreenTextSetting : IFlatbufferObject
	{
		// Token: 0x1700C9EC RID: 51692
		// (get) Token: 0x0602F58D RID: 193933 RVA: 0x0067601A File Offset: 0x0067421A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F58E RID: 193934 RVA: 0x00676027 File Offset: 0x00674227
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F58F RID: 193935 RVA: 0x00676030 File Offset: 0x00674230
		public static ICustomScreenTextSetting GetRootAsICustomScreenTextSetting(ByteBuffer _bb)
		{
			return ICustomScreenTextSetting.GetRootAsICustomScreenTextSetting(_bb, default(ICustomScreenTextSetting));
		}

		// Token: 0x0602F590 RID: 193936 RVA: 0x0067604C File Offset: 0x0067424C
		public static ICustomScreenTextSetting GetRootAsICustomScreenTextSetting(ByteBuffer _bb, ICustomScreenTextSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F591 RID: 193937 RVA: 0x00676069 File Offset: 0x00674269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F592 RID: 193938 RVA: 0x00676078 File Offset: 0x00674278
		public ICustomScreenTextSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9ED RID: 51693
		// (get) Token: 0x0602F593 RID: 193939 RVA: 0x00676088 File Offset: 0x00674288
		public bool IsShowTextInfo
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C9EE RID: 51694
		// (get) Token: 0x0602F594 RID: 193940 RVA: 0x006760C8 File Offset: 0x006742C8
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

		// Token: 0x0602F595 RID: 193941 RVA: 0x006760FF File Offset: 0x006742FF
		public Span<byte> GetTidTextContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F596 RID: 193942 RVA: 0x0067610E File Offset: 0x0067430E
		public byte[] GetTidTextContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C9EF RID: 51695
		// (get) Token: 0x0602F597 RID: 193943 RVA: 0x0067611C File Offset: 0x0067431C
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

		// Token: 0x0602F598 RID: 193944 RVA: 0x00676158 File Offset: 0x00674358
		public static Offset<ICustomScreenTextSetting> CreateICustomScreenTextSetting(FlatBufferBuilder builder, bool IsShowTextInfo = false, StringOffset TidTextContentOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ICustomScreenTextSetting.AddTidTextContent(builder, TidTextContentOffset);
			ICustomScreenTextSetting.AddNullMask(builder, NullMask);
			ICustomScreenTextSetting.AddIsShowTextInfo(builder, IsShowTextInfo);
			return ICustomScreenTextSetting.EndICustomScreenTextSetting(builder);
		}

		// Token: 0x0602F599 RID: 193945 RVA: 0x0067617C File Offset: 0x0067437C
		public static void StartICustomScreenTextSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F59A RID: 193946 RVA: 0x00676185 File Offset: 0x00674385
		public static void AddIsShowTextInfo(FlatBufferBuilder builder, bool isShowTextInfo)
		{
			builder.AddBool(0, isShowTextInfo, false);
		}

		// Token: 0x0602F59B RID: 193947 RVA: 0x00676190 File Offset: 0x00674390
		public static void AddTidTextContent(FlatBufferBuilder builder, StringOffset tidTextContentOffset)
		{
			builder.AddOffset(1, tidTextContentOffset.Value, 0);
		}

		// Token: 0x0602F59C RID: 193948 RVA: 0x006761A0 File Offset: 0x006743A0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602F59D RID: 193949 RVA: 0x006761AB File Offset: 0x006743AB
		public static Offset<ICustomScreenTextSetting> EndICustomScreenTextSetting(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenTextSetting>(builder.EndTable());
		}

		// Token: 0x0602F59E RID: 193950 RVA: 0x006761B8 File Offset: 0x006743B8
		public ICustomScreenTextSettingT UnPack()
		{
			ICustomScreenTextSettingT customScreenTextSettingT = new ICustomScreenTextSettingT();
			this.UnPackTo(customScreenTextSettingT);
			return customScreenTextSettingT;
		}

		// Token: 0x0602F59F RID: 193951 RVA: 0x006761D3 File Offset: 0x006743D3
		public void UnPackTo(ICustomScreenTextSettingT _o)
		{
			_o.IsShowTextInfo = this.IsShowTextInfo;
			_o.TidTextContent = this.TidTextContent;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F5A0 RID: 193952 RVA: 0x006761FC File Offset: 0x006743FC
		public static Offset<ICustomScreenTextSetting> Pack(FlatBufferBuilder builder, ICustomScreenTextSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenTextSetting>);
			}
			StringOffset tidTextContentOffset = (_o.TidTextContent == null) ? default(StringOffset) : builder.CreateString(_o.TidTextContent);
			return ICustomScreenTextSetting.CreateICustomScreenTextSetting(builder, _o.IsShowTextInfo, tidTextContentOffset, _o.NullMask);
		}

		// Token: 0x04011969 RID: 72041
		private Table __p;
	}
}

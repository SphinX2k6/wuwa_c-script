using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B84 RID: 27524
	public struct ICustomShowUi : IFlatbufferObject
	{
		// Token: 0x1700C9F8 RID: 51704
		// (get) Token: 0x0602F5CB RID: 193995 RVA: 0x006765DA File Offset: 0x006747DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F5CC RID: 193996 RVA: 0x006765E7 File Offset: 0x006747E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F5CD RID: 193997 RVA: 0x006765F0 File Offset: 0x006747F0
		public static ICustomShowUi GetRootAsICustomShowUi(ByteBuffer _bb)
		{
			return ICustomShowUi.GetRootAsICustomShowUi(_bb, default(ICustomShowUi));
		}

		// Token: 0x0602F5CE RID: 193998 RVA: 0x0067660C File Offset: 0x0067480C
		public static ICustomShowUi GetRootAsICustomShowUi(ByteBuffer _bb, ICustomShowUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F5CF RID: 193999 RVA: 0x00676629 File Offset: 0x00674829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F5D0 RID: 194000 RVA: 0x00676638 File Offset: 0x00674838
		public ICustomShowUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9F9 RID: 51705
		// (get) Token: 0x0602F5D1 RID: 194001 RVA: 0x00676648 File Offset: 0x00674848
		public ICustomScreenTextSetting? TextSetting
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ICustomScreenTextSetting?(default(ICustomScreenTextSetting).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C9FA RID: 51706
		// (get) Token: 0x0602F5D2 RID: 194002 RVA: 0x006766A8 File Offset: 0x006748A8
		public bool IsHideCircle
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C9FB RID: 51707
		// (get) Token: 0x0602F5D3 RID: 194003 RVA: 0x006766E8 File Offset: 0x006748E8
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

		// Token: 0x0602F5D4 RID: 194004 RVA: 0x00676724 File Offset: 0x00674924
		public static Offset<ICustomShowUi> CreateICustomShowUi(FlatBufferBuilder builder, Offset<ICustomScreenTextSetting> TextSettingOffset = default(Offset<ICustomScreenTextSetting>), bool IsHideCircle = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICustomShowUi.AddTextSetting(builder, TextSettingOffset);
			ICustomShowUi.AddNullMask(builder, NullMask);
			ICustomShowUi.AddIsHideCircle(builder, IsHideCircle);
			return ICustomShowUi.EndICustomShowUi(builder);
		}

		// Token: 0x0602F5D5 RID: 194005 RVA: 0x00676748 File Offset: 0x00674948
		public static void StartICustomShowUi(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F5D6 RID: 194006 RVA: 0x00676751 File Offset: 0x00674951
		public static void AddTextSetting(FlatBufferBuilder builder, Offset<ICustomScreenTextSetting> textSettingOffset)
		{
			builder.AddOffset(0, textSettingOffset.Value, 0);
		}

		// Token: 0x0602F5D7 RID: 194007 RVA: 0x00676761 File Offset: 0x00674961
		public static void AddIsHideCircle(FlatBufferBuilder builder, bool isHideCircle)
		{
			builder.AddBool(1, isHideCircle, false);
		}

		// Token: 0x0602F5D8 RID: 194008 RVA: 0x0067676C File Offset: 0x0067496C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602F5D9 RID: 194009 RVA: 0x00676777 File Offset: 0x00674977
		public static Offset<ICustomShowUi> EndICustomShowUi(FlatBufferBuilder builder)
		{
			return new Offset<ICustomShowUi>(builder.EndTable());
		}

		// Token: 0x0602F5DA RID: 194010 RVA: 0x00676784 File Offset: 0x00674984
		public ICustomShowUiT UnPack()
		{
			ICustomShowUiT customShowUiT = new ICustomShowUiT();
			this.UnPackTo(customShowUiT);
			return customShowUiT;
		}

		// Token: 0x0602F5DB RID: 194011 RVA: 0x006767A0 File Offset: 0x006749A0
		public void UnPackTo(ICustomShowUiT _o)
		{
			_o.TextSetting = ((this.TextSetting != null) ? this.TextSetting.Value.UnPack() : null);
			_o.IsHideCircle = this.IsHideCircle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F5DC RID: 194012 RVA: 0x006767F4 File Offset: 0x006749F4
		public static Offset<ICustomShowUi> Pack(FlatBufferBuilder builder, ICustomShowUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomShowUi>);
			}
			Offset<ICustomScreenTextSetting> textSettingOffset = (_o.TextSetting == null) ? default(Offset<ICustomScreenTextSetting>) : ICustomScreenTextSetting.Pack(builder, _o.TextSetting);
			return ICustomShowUi.CreateICustomShowUi(builder, textSettingOffset, _o.IsHideCircle, _o.NullMask);
		}

		// Token: 0x04011977 RID: 72055
		private Table __p;
	}
}

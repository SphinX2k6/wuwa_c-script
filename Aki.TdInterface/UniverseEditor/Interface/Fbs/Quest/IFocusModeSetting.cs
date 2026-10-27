using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E6C RID: 15980
	public struct IFocusModeSetting : IFlatbufferObject
	{
		// Token: 0x17006EC7 RID: 28359
		// (get) Token: 0x06016803 RID: 92163 RVA: 0x003409DC File Offset: 0x0033EBDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016804 RID: 92164 RVA: 0x003409E9 File Offset: 0x0033EBE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016805 RID: 92165 RVA: 0x003409F0 File Offset: 0x0033EBF0
		public static IFocusModeSetting GetRootAsIFocusModeSetting(ByteBuffer _bb)
		{
			return IFocusModeSetting.GetRootAsIFocusModeSetting(_bb, default(IFocusModeSetting));
		}

		// Token: 0x06016806 RID: 92166 RVA: 0x00340A0C File Offset: 0x0033EC0C
		public static IFocusModeSetting GetRootAsIFocusModeSetting(ByteBuffer _bb, IFocusModeSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016807 RID: 92167 RVA: 0x00340A29 File Offset: 0x0033EC29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016808 RID: 92168 RVA: 0x00340A38 File Offset: 0x0033EC38
		public IFocusModeSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EC8 RID: 28360
		// (get) Token: 0x06016809 RID: 92169 RVA: 0x00340A48 File Offset: 0x0033EC48
		public bool CanOpenFocusMode
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006EC9 RID: 28361
		// (get) Token: 0x0601680A RID: 92170 RVA: 0x00340A88 File Offset: 0x0033EC88
		public bool IsFocusModeInherit
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006ECA RID: 28362
		// (get) Token: 0x0601680B RID: 92171 RVA: 0x00340AC8 File Offset: 0x0033ECC8
		public bool CanAcceptInFocusMode
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006ECB RID: 28363
		// (get) Token: 0x0601680C RID: 92172 RVA: 0x00340B08 File Offset: 0x0033ED08
		public bool IsFocusModeWhiteList
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006ECC RID: 28364
		// (get) Token: 0x0601680D RID: 92173 RVA: 0x00340B48 File Offset: 0x0033ED48
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601680E RID: 92174 RVA: 0x00340B85 File Offset: 0x0033ED85
		public static Offset<IFocusModeSetting> CreateIFocusModeSetting(FlatBufferBuilder builder, bool CanOpenFocusMode = false, bool IsFocusModeInherit = false, bool CanAcceptInFocusMode = false, bool IsFocusModeWhiteList = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IFocusModeSetting.AddNullMask(builder, NullMask);
			IFocusModeSetting.AddIsFocusModeWhiteList(builder, IsFocusModeWhiteList);
			IFocusModeSetting.AddCanAcceptInFocusMode(builder, CanAcceptInFocusMode);
			IFocusModeSetting.AddIsFocusModeInherit(builder, IsFocusModeInherit);
			IFocusModeSetting.AddCanOpenFocusMode(builder, CanOpenFocusMode);
			return IFocusModeSetting.EndIFocusModeSetting(builder);
		}

		// Token: 0x0601680F RID: 92175 RVA: 0x00340BB9 File Offset: 0x0033EDB9
		public static void StartIFocusModeSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016810 RID: 92176 RVA: 0x00340BC2 File Offset: 0x0033EDC2
		public static void AddCanOpenFocusMode(FlatBufferBuilder builder, bool canOpenFocusMode)
		{
			builder.AddBool(0, canOpenFocusMode, false);
		}

		// Token: 0x06016811 RID: 92177 RVA: 0x00340BCD File Offset: 0x0033EDCD
		public static void AddIsFocusModeInherit(FlatBufferBuilder builder, bool isFocusModeInherit)
		{
			builder.AddBool(1, isFocusModeInherit, false);
		}

		// Token: 0x06016812 RID: 92178 RVA: 0x00340BD8 File Offset: 0x0033EDD8
		public static void AddCanAcceptInFocusMode(FlatBufferBuilder builder, bool canAcceptInFocusMode)
		{
			builder.AddBool(2, canAcceptInFocusMode, false);
		}

		// Token: 0x06016813 RID: 92179 RVA: 0x00340BE3 File Offset: 0x0033EDE3
		public static void AddIsFocusModeWhiteList(FlatBufferBuilder builder, bool isFocusModeWhiteList)
		{
			builder.AddBool(3, isFocusModeWhiteList, false);
		}

		// Token: 0x06016814 RID: 92180 RVA: 0x00340BEE File Offset: 0x0033EDEE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06016815 RID: 92181 RVA: 0x00340BF9 File Offset: 0x0033EDF9
		public static Offset<IFocusModeSetting> EndIFocusModeSetting(FlatBufferBuilder builder)
		{
			return new Offset<IFocusModeSetting>(builder.EndTable());
		}

		// Token: 0x06016816 RID: 92182 RVA: 0x00340C08 File Offset: 0x0033EE08
		public IFocusModeSettingT UnPack()
		{
			IFocusModeSettingT focusModeSettingT = new IFocusModeSettingT();
			this.UnPackTo(focusModeSettingT);
			return focusModeSettingT;
		}

		// Token: 0x06016817 RID: 92183 RVA: 0x00340C23 File Offset: 0x0033EE23
		public void UnPackTo(IFocusModeSettingT _o)
		{
			_o.CanOpenFocusMode = this.CanOpenFocusMode;
			_o.IsFocusModeInherit = this.IsFocusModeInherit;
			_o.CanAcceptInFocusMode = this.CanAcceptInFocusMode;
			_o.IsFocusModeWhiteList = this.IsFocusModeWhiteList;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016818 RID: 92184 RVA: 0x00340C64 File Offset: 0x0033EE64
		public static Offset<IFocusModeSetting> Pack(FlatBufferBuilder builder, IFocusModeSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusModeSetting>);
			}
			return IFocusModeSetting.CreateIFocusModeSetting(builder, _o.CanOpenFocusMode, _o.IsFocusModeInherit, _o.CanAcceptInFocusMode, _o.IsFocusModeWhiteList, _o.NullMask);
		}

		// Token: 0x0400B81D RID: 47133
		private Table __p;
	}
}

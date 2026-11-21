using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A7 RID: 17063
	public struct IFocusModeSetting : IFlatbufferObject
	{
		// Token: 0x170074AB RID: 29867
		// (get) Token: 0x06017E2A RID: 97834 RVA: 0x0036950C File Offset: 0x0036770C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017E2B RID: 97835 RVA: 0x00369519 File Offset: 0x00367719
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017E2C RID: 97836 RVA: 0x00369520 File Offset: 0x00367720
		public static IFocusModeSetting GetRootAsIFocusModeSetting(ByteBuffer _bb)
		{
			return IFocusModeSetting.GetRootAsIFocusModeSetting(_bb, default(IFocusModeSetting));
		}

		// Token: 0x06017E2D RID: 97837 RVA: 0x0036953C File Offset: 0x0036773C
		public static IFocusModeSetting GetRootAsIFocusModeSetting(ByteBuffer _bb, IFocusModeSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017E2E RID: 97838 RVA: 0x00369559 File Offset: 0x00367759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017E2F RID: 97839 RVA: 0x00369568 File Offset: 0x00367768
		public IFocusModeSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074AC RID: 29868
		// (get) Token: 0x06017E30 RID: 97840 RVA: 0x00369578 File Offset: 0x00367778
		public bool CanOpenFocusMode
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170074AD RID: 29869
		// (get) Token: 0x06017E31 RID: 97841 RVA: 0x003695B8 File Offset: 0x003677B8
		public bool IsFocusModeInherit
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170074AE RID: 29870
		// (get) Token: 0x06017E32 RID: 97842 RVA: 0x003695F8 File Offset: 0x003677F8
		public bool CanAcceptInFocusMode
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170074AF RID: 29871
		// (get) Token: 0x06017E33 RID: 97843 RVA: 0x00369638 File Offset: 0x00367838
		public bool IsFocusModeWhiteList
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170074B0 RID: 29872
		// (get) Token: 0x06017E34 RID: 97844 RVA: 0x00369678 File Offset: 0x00367878
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

		// Token: 0x06017E35 RID: 97845 RVA: 0x003696B5 File Offset: 0x003678B5
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

		// Token: 0x06017E36 RID: 97846 RVA: 0x003696E9 File Offset: 0x003678E9
		public static void StartIFocusModeSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017E37 RID: 97847 RVA: 0x003696F2 File Offset: 0x003678F2
		public static void AddCanOpenFocusMode(FlatBufferBuilder builder, bool canOpenFocusMode)
		{
			builder.AddBool(0, canOpenFocusMode, false);
		}

		// Token: 0x06017E38 RID: 97848 RVA: 0x003696FD File Offset: 0x003678FD
		public static void AddIsFocusModeInherit(FlatBufferBuilder builder, bool isFocusModeInherit)
		{
			builder.AddBool(1, isFocusModeInherit, false);
		}

		// Token: 0x06017E39 RID: 97849 RVA: 0x00369708 File Offset: 0x00367908
		public static void AddCanAcceptInFocusMode(FlatBufferBuilder builder, bool canAcceptInFocusMode)
		{
			builder.AddBool(2, canAcceptInFocusMode, false);
		}

		// Token: 0x06017E3A RID: 97850 RVA: 0x00369713 File Offset: 0x00367913
		public static void AddIsFocusModeWhiteList(FlatBufferBuilder builder, bool isFocusModeWhiteList)
		{
			builder.AddBool(3, isFocusModeWhiteList, false);
		}

		// Token: 0x06017E3B RID: 97851 RVA: 0x0036971E File Offset: 0x0036791E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06017E3C RID: 97852 RVA: 0x00369729 File Offset: 0x00367929
		public static Offset<IFocusModeSetting> EndIFocusModeSetting(FlatBufferBuilder builder)
		{
			return new Offset<IFocusModeSetting>(builder.EndTable());
		}

		// Token: 0x06017E3D RID: 97853 RVA: 0x00369738 File Offset: 0x00367938
		public IFocusModeSettingT UnPack()
		{
			IFocusModeSettingT focusModeSettingT = new IFocusModeSettingT();
			this.UnPackTo(focusModeSettingT);
			return focusModeSettingT;
		}

		// Token: 0x06017E3E RID: 97854 RVA: 0x00369753 File Offset: 0x00367953
		public void UnPackTo(IFocusModeSettingT _o)
		{
			_o.CanOpenFocusMode = this.CanOpenFocusMode;
			_o.IsFocusModeInherit = this.IsFocusModeInherit;
			_o.CanAcceptInFocusMode = this.CanAcceptInFocusMode;
			_o.IsFocusModeWhiteList = this.IsFocusModeWhiteList;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017E3F RID: 97855 RVA: 0x00369794 File Offset: 0x00367994
		public static Offset<IFocusModeSetting> Pack(FlatBufferBuilder builder, IFocusModeSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusModeSetting>);
			}
			return IFocusModeSetting.CreateIFocusModeSetting(builder, _o.CanOpenFocusMode, _o.IsFocusModeInherit, _o.CanAcceptInFocusMode, _o.IsFocusModeWhiteList, _o.NullMask);
		}

		// Token: 0x0400C1F4 RID: 49652
		private Table __p;
	}
}

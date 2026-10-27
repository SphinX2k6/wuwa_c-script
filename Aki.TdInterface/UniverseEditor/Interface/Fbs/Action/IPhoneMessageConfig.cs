using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA5 RID: 27813
	public struct IPhoneMessageConfig : IFlatbufferObject
	{
		// Token: 0x1700CF18 RID: 53016
		// (get) Token: 0x06031033 RID: 200755 RVA: 0x006A7272 File Offset: 0x006A5472
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031034 RID: 200756 RVA: 0x006A727F File Offset: 0x006A547F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031035 RID: 200757 RVA: 0x006A7288 File Offset: 0x006A5488
		public static IPhoneMessageConfig GetRootAsIPhoneMessageConfig(ByteBuffer _bb)
		{
			return IPhoneMessageConfig.GetRootAsIPhoneMessageConfig(_bb, default(IPhoneMessageConfig));
		}

		// Token: 0x06031036 RID: 200758 RVA: 0x006A72A4 File Offset: 0x006A54A4
		public static IPhoneMessageConfig GetRootAsIPhoneMessageConfig(ByteBuffer _bb, IPhoneMessageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031037 RID: 200759 RVA: 0x006A72C1 File Offset: 0x006A54C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031038 RID: 200760 RVA: 0x006A72D0 File Offset: 0x006A54D0
		public IPhoneMessageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF19 RID: 53017
		// (get) Token: 0x06031039 RID: 200761 RVA: 0x006A72E0 File Offset: 0x006A54E0
		public bool IsJumpToFirstOption
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF1A RID: 53018
		// (get) Token: 0x0603103A RID: 200762 RVA: 0x006A7320 File Offset: 0x006A5520
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603103B RID: 200763 RVA: 0x006A735C File Offset: 0x006A555C
		public static Offset<IPhoneMessageConfig> CreateIPhoneMessageConfig(FlatBufferBuilder builder, bool IsJumpToFirstOption = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IPhoneMessageConfig.AddNullMask(builder, NullMask);
			IPhoneMessageConfig.AddIsJumpToFirstOption(builder, IsJumpToFirstOption);
			return IPhoneMessageConfig.EndIPhoneMessageConfig(builder);
		}

		// Token: 0x0603103C RID: 200764 RVA: 0x006A7379 File Offset: 0x006A5579
		public static void StartIPhoneMessageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603103D RID: 200765 RVA: 0x006A7382 File Offset: 0x006A5582
		public static void AddIsJumpToFirstOption(FlatBufferBuilder builder, bool isJumpToFirstOption)
		{
			builder.AddBool(0, isJumpToFirstOption, false);
		}

		// Token: 0x0603103E RID: 200766 RVA: 0x006A738D File Offset: 0x006A558D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0603103F RID: 200767 RVA: 0x006A7398 File Offset: 0x006A5598
		public static Offset<IPhoneMessageConfig> EndIPhoneMessageConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneMessageConfig>(builder.EndTable());
		}

		// Token: 0x06031040 RID: 200768 RVA: 0x006A73A8 File Offset: 0x006A55A8
		public IPhoneMessageConfigT UnPack()
		{
			IPhoneMessageConfigT phoneMessageConfigT = new IPhoneMessageConfigT();
			this.UnPackTo(phoneMessageConfigT);
			return phoneMessageConfigT;
		}

		// Token: 0x06031041 RID: 200769 RVA: 0x006A73C3 File Offset: 0x006A55C3
		public void UnPackTo(IPhoneMessageConfigT _o)
		{
			_o.IsJumpToFirstOption = this.IsJumpToFirstOption;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031042 RID: 200770 RVA: 0x006A73E0 File Offset: 0x006A55E0
		public static Offset<IPhoneMessageConfig> Pack(FlatBufferBuilder builder, IPhoneMessageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneMessageConfig>);
			}
			return IPhoneMessageConfig.CreateIPhoneMessageConfig(builder, _o.IsJumpToFirstOption, _o.NullMask);
		}

		// Token: 0x040115FE RID: 71166
		private Table __p;
	}
}

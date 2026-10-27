using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA8 RID: 27816
	public struct IPhoneRecordActionConfig : IFlatbufferObject
	{
		// Token: 0x1700CF1D RID: 53021
		// (get) Token: 0x06031049 RID: 200777 RVA: 0x006A7476 File Offset: 0x006A5676
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603104A RID: 200778 RVA: 0x006A7483 File Offset: 0x006A5683
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603104B RID: 200779 RVA: 0x006A748C File Offset: 0x006A568C
		public static IPhoneRecordActionConfig GetRootAsIPhoneRecordActionConfig(ByteBuffer _bb)
		{
			return IPhoneRecordActionConfig.GetRootAsIPhoneRecordActionConfig(_bb, default(IPhoneRecordActionConfig));
		}

		// Token: 0x0603104C RID: 200780 RVA: 0x006A74A8 File Offset: 0x006A56A8
		public static IPhoneRecordActionConfig GetRootAsIPhoneRecordActionConfig(ByteBuffer _bb, IPhoneRecordActionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603104D RID: 200781 RVA: 0x006A74C5 File Offset: 0x006A56C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603104E RID: 200782 RVA: 0x006A74D4 File Offset: 0x006A56D4
		public IPhoneRecordActionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF1E RID: 53022
		// (get) Token: 0x0603104F RID: 200783 RVA: 0x006A74E4 File Offset: 0x006A56E4
		public int PhoneMessageId
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

		// Token: 0x1700CF1F RID: 53023
		// (get) Token: 0x06031050 RID: 200784 RVA: 0x006A7520 File Offset: 0x006A5720
		public int DialogProgress
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

		// Token: 0x1700CF20 RID: 53024
		// (get) Token: 0x06031051 RID: 200785 RVA: 0x006A755C File Offset: 0x006A575C
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

		// Token: 0x06031052 RID: 200786 RVA: 0x006A7598 File Offset: 0x006A5798
		public static Offset<IPhoneRecordActionConfig> CreateIPhoneRecordActionConfig(FlatBufferBuilder builder, int PhoneMessageId = 0, int DialogProgress = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPhoneRecordActionConfig.AddDialogProgress(builder, DialogProgress);
			IPhoneRecordActionConfig.AddPhoneMessageId(builder, PhoneMessageId);
			IPhoneRecordActionConfig.AddNullMask(builder, NullMask);
			return IPhoneRecordActionConfig.EndIPhoneRecordActionConfig(builder);
		}

		// Token: 0x06031053 RID: 200787 RVA: 0x006A75BC File Offset: 0x006A57BC
		public static void StartIPhoneRecordActionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031054 RID: 200788 RVA: 0x006A75C5 File Offset: 0x006A57C5
		public static void AddPhoneMessageId(FlatBufferBuilder builder, int phoneMessageId)
		{
			builder.AddInt(0, phoneMessageId, 0);
		}

		// Token: 0x06031055 RID: 200789 RVA: 0x006A75D0 File Offset: 0x006A57D0
		public static void AddDialogProgress(FlatBufferBuilder builder, int dialogProgress)
		{
			builder.AddInt(1, dialogProgress, 0);
		}

		// Token: 0x06031056 RID: 200790 RVA: 0x006A75DB File Offset: 0x006A57DB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06031057 RID: 200791 RVA: 0x006A75E6 File Offset: 0x006A57E6
		public static Offset<IPhoneRecordActionConfig> EndIPhoneRecordActionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneRecordActionConfig>(builder.EndTable());
		}

		// Token: 0x06031058 RID: 200792 RVA: 0x006A75F4 File Offset: 0x006A57F4
		public IPhoneRecordActionConfigT UnPack()
		{
			IPhoneRecordActionConfigT phoneRecordActionConfigT = new IPhoneRecordActionConfigT();
			this.UnPackTo(phoneRecordActionConfigT);
			return phoneRecordActionConfigT;
		}

		// Token: 0x06031059 RID: 200793 RVA: 0x006A760F File Offset: 0x006A580F
		public void UnPackTo(IPhoneRecordActionConfigT _o)
		{
			_o.PhoneMessageId = this.PhoneMessageId;
			_o.DialogProgress = this.DialogProgress;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603105A RID: 200794 RVA: 0x006A7638 File Offset: 0x006A5838
		public static Offset<IPhoneRecordActionConfig> Pack(FlatBufferBuilder builder, IPhoneRecordActionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneRecordActionConfig>);
			}
			return IPhoneRecordActionConfig.CreateIPhoneRecordActionConfig(builder, _o.PhoneMessageId, _o.DialogProgress, _o.NullMask);
		}

		// Token: 0x04011601 RID: 71169
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200741E RID: 29726
	public struct IPhoneRecordActionConfig : IFlatbufferObject
	{
		// Token: 0x1700DA5A RID: 55898
		// (get) Token: 0x06034020 RID: 213024 RVA: 0x007026AA File Offset: 0x007008AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034021 RID: 213025 RVA: 0x007026B7 File Offset: 0x007008B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034022 RID: 213026 RVA: 0x007026C0 File Offset: 0x007008C0
		public static IPhoneRecordActionConfig GetRootAsIPhoneRecordActionConfig(ByteBuffer _bb)
		{
			return IPhoneRecordActionConfig.GetRootAsIPhoneRecordActionConfig(_bb, default(IPhoneRecordActionConfig));
		}

		// Token: 0x06034023 RID: 213027 RVA: 0x007026DC File Offset: 0x007008DC
		public static IPhoneRecordActionConfig GetRootAsIPhoneRecordActionConfig(ByteBuffer _bb, IPhoneRecordActionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034024 RID: 213028 RVA: 0x007026F9 File Offset: 0x007008F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034025 RID: 213029 RVA: 0x00702708 File Offset: 0x00700908
		public IPhoneRecordActionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA5B RID: 55899
		// (get) Token: 0x06034026 RID: 213030 RVA: 0x00702718 File Offset: 0x00700918
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

		// Token: 0x1700DA5C RID: 55900
		// (get) Token: 0x06034027 RID: 213031 RVA: 0x00702754 File Offset: 0x00700954
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

		// Token: 0x1700DA5D RID: 55901
		// (get) Token: 0x06034028 RID: 213032 RVA: 0x00702790 File Offset: 0x00700990
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

		// Token: 0x06034029 RID: 213033 RVA: 0x007027CC File Offset: 0x007009CC
		public static Offset<IPhoneRecordActionConfig> CreateIPhoneRecordActionConfig(FlatBufferBuilder builder, int PhoneMessageId = 0, int DialogProgress = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPhoneRecordActionConfig.AddDialogProgress(builder, DialogProgress);
			IPhoneRecordActionConfig.AddPhoneMessageId(builder, PhoneMessageId);
			IPhoneRecordActionConfig.AddNullMask(builder, NullMask);
			return IPhoneRecordActionConfig.EndIPhoneRecordActionConfig(builder);
		}

		// Token: 0x0603402A RID: 213034 RVA: 0x007027F0 File Offset: 0x007009F0
		public static void StartIPhoneRecordActionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603402B RID: 213035 RVA: 0x007027F9 File Offset: 0x007009F9
		public static void AddPhoneMessageId(FlatBufferBuilder builder, int phoneMessageId)
		{
			builder.AddInt(0, phoneMessageId, 0);
		}

		// Token: 0x0603402C RID: 213036 RVA: 0x00702804 File Offset: 0x00700A04
		public static void AddDialogProgress(FlatBufferBuilder builder, int dialogProgress)
		{
			builder.AddInt(1, dialogProgress, 0);
		}

		// Token: 0x0603402D RID: 213037 RVA: 0x0070280F File Offset: 0x00700A0F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603402E RID: 213038 RVA: 0x0070281A File Offset: 0x00700A1A
		public static Offset<IPhoneRecordActionConfig> EndIPhoneRecordActionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneRecordActionConfig>(builder.EndTable());
		}

		// Token: 0x0603402F RID: 213039 RVA: 0x00702828 File Offset: 0x00700A28
		public IPhoneRecordActionConfigT UnPack()
		{
			IPhoneRecordActionConfigT phoneRecordActionConfigT = new IPhoneRecordActionConfigT();
			this.UnPackTo(phoneRecordActionConfigT);
			return phoneRecordActionConfigT;
		}

		// Token: 0x06034030 RID: 213040 RVA: 0x00702843 File Offset: 0x00700A43
		public void UnPackTo(IPhoneRecordActionConfigT _o)
		{
			_o.PhoneMessageId = this.PhoneMessageId;
			_o.DialogProgress = this.DialogProgress;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034031 RID: 213041 RVA: 0x0070286C File Offset: 0x00700A6C
		public static Offset<IPhoneRecordActionConfig> Pack(FlatBufferBuilder builder, IPhoneRecordActionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneRecordActionConfig>);
			}
			return IPhoneRecordActionConfig.CreateIPhoneRecordActionConfig(builder, _o.PhoneMessageId, _o.DialogProgress, _o.NullMask);
		}

		// Token: 0x04012571 RID: 75121
		private Table __p;
	}
}

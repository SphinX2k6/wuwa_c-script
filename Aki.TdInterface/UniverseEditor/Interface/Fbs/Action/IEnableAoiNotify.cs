using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CBF RID: 27839
	public struct IEnableAoiNotify : IFlatbufferObject
	{
		// Token: 0x1700CC37 RID: 52279
		// (get) Token: 0x0602FFB4 RID: 196532 RVA: 0x00687B84 File Offset: 0x00685D84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FFB5 RID: 196533 RVA: 0x00687B91 File Offset: 0x00685D91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FFB6 RID: 196534 RVA: 0x00687B98 File Offset: 0x00685D98
		public static IEnableAoiNotify GetRootAsIEnableAoiNotify(ByteBuffer _bb)
		{
			return IEnableAoiNotify.GetRootAsIEnableAoiNotify(_bb, default(IEnableAoiNotify));
		}

		// Token: 0x0602FFB7 RID: 196535 RVA: 0x00687BB4 File Offset: 0x00685DB4
		public static IEnableAoiNotify GetRootAsIEnableAoiNotify(ByteBuffer _bb, IEnableAoiNotify obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FFB8 RID: 196536 RVA: 0x00687BD1 File Offset: 0x00685DD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FFB9 RID: 196537 RVA: 0x00687BE0 File Offset: 0x00685DE0
		public IEnableAoiNotify __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC38 RID: 52280
		// (get) Token: 0x0602FFBA RID: 196538 RVA: 0x00687BF0 File Offset: 0x00685DF0
		public EAoiNotifyState State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAoiNotifyState.Open;
				}
				return (EAoiNotifyState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FFBB RID: 196539 RVA: 0x00687C2C File Offset: 0x00685E2C
		public static Offset<IEnableAoiNotify> CreateIEnableAoiNotify(FlatBufferBuilder builder, EAoiNotifyState State = EAoiNotifyState.Open)
		{
			builder.StartTable(1);
			IEnableAoiNotify.AddState(builder, State);
			return IEnableAoiNotify.EndIEnableAoiNotify(builder);
		}

		// Token: 0x0602FFBC RID: 196540 RVA: 0x00687C42 File Offset: 0x00685E42
		public static void StartIEnableAoiNotify(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FFBD RID: 196541 RVA: 0x00687C4B File Offset: 0x00685E4B
		public static void AddState(FlatBufferBuilder builder, EAoiNotifyState state)
		{
			builder.AddByte(0, (byte)state, 0);
		}

		// Token: 0x0602FFBE RID: 196542 RVA: 0x00687C56 File Offset: 0x00685E56
		public static Offset<IEnableAoiNotify> EndIEnableAoiNotify(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAoiNotify>(builder.EndTable());
		}

		// Token: 0x0602FFBF RID: 196543 RVA: 0x00687C64 File Offset: 0x00685E64
		public IEnableAoiNotifyT UnPack()
		{
			IEnableAoiNotifyT enableAoiNotifyT = new IEnableAoiNotifyT();
			this.UnPackTo(enableAoiNotifyT);
			return enableAoiNotifyT;
		}

		// Token: 0x0602FFC0 RID: 196544 RVA: 0x00687C7F File Offset: 0x00685E7F
		public void UnPackTo(IEnableAoiNotifyT _o)
		{
			_o.State = this.State;
		}

		// Token: 0x0602FFC1 RID: 196545 RVA: 0x00687C90 File Offset: 0x00685E90
		public static Offset<IEnableAoiNotify> Pack(FlatBufferBuilder builder, IEnableAoiNotifyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableAoiNotify>);
			}
			return IEnableAoiNotify.CreateIEnableAoiNotify(builder, _o.State);
		}

		// Token: 0x04011B07 RID: 72455
		private Table __p;
	}
}

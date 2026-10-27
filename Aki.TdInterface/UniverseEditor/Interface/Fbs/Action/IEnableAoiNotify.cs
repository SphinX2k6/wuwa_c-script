using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200664E RID: 26190
	public struct IEnableAoiNotify : IFlatbufferObject
	{
		// Token: 0x1700C299 RID: 49817
		// (get) Token: 0x0602D7E3 RID: 186339 RVA: 0x0063B01C File Offset: 0x0063921C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D7E4 RID: 186340 RVA: 0x0063B029 File Offset: 0x00639229
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D7E5 RID: 186341 RVA: 0x0063B030 File Offset: 0x00639230
		public static IEnableAoiNotify GetRootAsIEnableAoiNotify(ByteBuffer _bb)
		{
			return IEnableAoiNotify.GetRootAsIEnableAoiNotify(_bb, default(IEnableAoiNotify));
		}

		// Token: 0x0602D7E6 RID: 186342 RVA: 0x0063B04C File Offset: 0x0063924C
		public static IEnableAoiNotify GetRootAsIEnableAoiNotify(ByteBuffer _bb, IEnableAoiNotify obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D7E7 RID: 186343 RVA: 0x0063B069 File Offset: 0x00639269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D7E8 RID: 186344 RVA: 0x0063B078 File Offset: 0x00639278
		public IEnableAoiNotify __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C29A RID: 49818
		// (get) Token: 0x0602D7E9 RID: 186345 RVA: 0x0063B088 File Offset: 0x00639288
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

		// Token: 0x0602D7EA RID: 186346 RVA: 0x0063B0C4 File Offset: 0x006392C4
		public static Offset<IEnableAoiNotify> CreateIEnableAoiNotify(FlatBufferBuilder builder, EAoiNotifyState State = EAoiNotifyState.Open)
		{
			builder.StartTable(1);
			IEnableAoiNotify.AddState(builder, State);
			return IEnableAoiNotify.EndIEnableAoiNotify(builder);
		}

		// Token: 0x0602D7EB RID: 186347 RVA: 0x0063B0DA File Offset: 0x006392DA
		public static void StartIEnableAoiNotify(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D7EC RID: 186348 RVA: 0x0063B0E3 File Offset: 0x006392E3
		public static void AddState(FlatBufferBuilder builder, EAoiNotifyState state)
		{
			builder.AddByte(0, (byte)state, 0);
		}

		// Token: 0x0602D7ED RID: 186349 RVA: 0x0063B0EE File Offset: 0x006392EE
		public static Offset<IEnableAoiNotify> EndIEnableAoiNotify(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAoiNotify>(builder.EndTable());
		}

		// Token: 0x0602D7EE RID: 186350 RVA: 0x0063B0FC File Offset: 0x006392FC
		public IEnableAoiNotifyT UnPack()
		{
			IEnableAoiNotifyT enableAoiNotifyT = new IEnableAoiNotifyT();
			this.UnPackTo(enableAoiNotifyT);
			return enableAoiNotifyT;
		}

		// Token: 0x0602D7EF RID: 186351 RVA: 0x0063B117 File Offset: 0x00639317
		public void UnPackTo(IEnableAoiNotifyT _o)
		{
			_o.State = this.State;
		}

		// Token: 0x0602D7F0 RID: 186352 RVA: 0x0063B128 File Offset: 0x00639328
		public static Offset<IEnableAoiNotify> Pack(FlatBufferBuilder builder, IEnableAoiNotifyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableAoiNotify>);
			}
			return IEnableAoiNotify.CreateIEnableAoiNotify(builder, _o.State);
		}

		// Token: 0x04010CEC RID: 68844
		private Table __p;
	}
}

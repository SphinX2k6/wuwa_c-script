using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044B4 RID: 17588
	public struct IRecallConditionBase : IFlatbufferObject
	{
		// Token: 0x17007A6F RID: 31343
		// (get) Token: 0x06019654 RID: 104020 RVA: 0x0039FF19 File Offset: 0x0039E119
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019655 RID: 104021 RVA: 0x0039FF26 File Offset: 0x0039E126
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019656 RID: 104022 RVA: 0x0039FF30 File Offset: 0x0039E130
		public static IRecallConditionBase GetRootAsIRecallConditionBase(ByteBuffer _bb)
		{
			return IRecallConditionBase.GetRootAsIRecallConditionBase(_bb, default(IRecallConditionBase));
		}

		// Token: 0x06019657 RID: 104023 RVA: 0x0039FF4C File Offset: 0x0039E14C
		public static IRecallConditionBase GetRootAsIRecallConditionBase(ByteBuffer _bb, IRecallConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019658 RID: 104024 RVA: 0x0039FF69 File Offset: 0x0039E169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019659 RID: 104025 RVA: 0x0039FF78 File Offset: 0x0039E178
		public IRecallConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A70 RID: 31344
		// (get) Token: 0x0601965A RID: 104026 RVA: 0x0039FF88 File Offset: 0x0039E188
		public ERecallConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERecallConditionType.ByEntityType;
				}
				return (ERecallConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007A71 RID: 31345
		// (get) Token: 0x0601965B RID: 104027 RVA: 0x0039FFC4 File Offset: 0x0039E1C4
		public ERecallOperation Operation
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ERecallOperation.Include;
				}
				return (ERecallOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601965C RID: 104028 RVA: 0x003A0000 File Offset: 0x0039E200
		public static Offset<IRecallConditionBase> CreateIRecallConditionBase(FlatBufferBuilder builder, ERecallConditionType Type = ERecallConditionType.ByEntityType, ERecallOperation Operation = ERecallOperation.Include)
		{
			builder.StartTable(2);
			IRecallConditionBase.AddOperation(builder, Operation);
			IRecallConditionBase.AddType(builder, Type);
			return IRecallConditionBase.EndIRecallConditionBase(builder);
		}

		// Token: 0x0601965D RID: 104029 RVA: 0x003A001D File Offset: 0x0039E21D
		public static void StartIRecallConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601965E RID: 104030 RVA: 0x003A0026 File Offset: 0x0039E226
		public static void AddType(FlatBufferBuilder builder, ERecallConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601965F RID: 104031 RVA: 0x003A0031 File Offset: 0x0039E231
		public static void AddOperation(FlatBufferBuilder builder, ERecallOperation operation)
		{
			builder.AddByte(1, (byte)operation, 0);
		}

		// Token: 0x06019660 RID: 104032 RVA: 0x003A003C File Offset: 0x0039E23C
		public static Offset<IRecallConditionBase> EndIRecallConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<IRecallConditionBase>(builder.EndTable());
		}

		// Token: 0x06019661 RID: 104033 RVA: 0x003A004C File Offset: 0x0039E24C
		public IRecallConditionBaseT UnPack()
		{
			IRecallConditionBaseT recallConditionBaseT = new IRecallConditionBaseT();
			this.UnPackTo(recallConditionBaseT);
			return recallConditionBaseT;
		}

		// Token: 0x06019662 RID: 104034 RVA: 0x003A0067 File Offset: 0x0039E267
		public void UnPackTo(IRecallConditionBaseT _o)
		{
			_o.Type = this.Type;
			_o.Operation = this.Operation;
		}

		// Token: 0x06019663 RID: 104035 RVA: 0x003A0084 File Offset: 0x0039E284
		public static Offset<IRecallConditionBase> Pack(FlatBufferBuilder builder, IRecallConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallConditionBase>);
			}
			return IRecallConditionBase.CreateIRecallConditionBase(builder, _o.Type, _o.Operation);
		}

		// Token: 0x0400C5D6 RID: 50646
		private Table __p;
	}
}

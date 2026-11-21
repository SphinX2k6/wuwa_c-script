using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004355 RID: 17237
	public struct ILogicProgramSpecialProcessOperation : IFlatbufferObject
	{
		// Token: 0x17007644 RID: 30276
		// (get) Token: 0x06018532 RID: 99634 RVA: 0x00378473 File Offset: 0x00376673
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018533 RID: 99635 RVA: 0x00378480 File Offset: 0x00376680
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018534 RID: 99636 RVA: 0x00378488 File Offset: 0x00376688
		public static ILogicProgramSpecialProcessOperation GetRootAsILogicProgramSpecialProcessOperation(ByteBuffer _bb)
		{
			return ILogicProgramSpecialProcessOperation.GetRootAsILogicProgramSpecialProcessOperation(_bb, default(ILogicProgramSpecialProcessOperation));
		}

		// Token: 0x06018535 RID: 99637 RVA: 0x003784A4 File Offset: 0x003766A4
		public static ILogicProgramSpecialProcessOperation GetRootAsILogicProgramSpecialProcessOperation(ByteBuffer _bb, ILogicProgramSpecialProcessOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018536 RID: 99638 RVA: 0x003784C1 File Offset: 0x003766C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018537 RID: 99639 RVA: 0x003784D0 File Offset: 0x003766D0
		public ILogicProgramSpecialProcessOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007645 RID: 30277
		// (get) Token: 0x06018538 RID: 99640 RVA: 0x003784E0 File Offset: 0x003766E0
		public ELogicProgramSpecialProcess Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELogicProgramSpecialProcess.DisableURO;
				}
				return (ELogicProgramSpecialProcess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018539 RID: 99641 RVA: 0x0037851C File Offset: 0x0037671C
		public static Offset<ILogicProgramSpecialProcessOperation> CreateILogicProgramSpecialProcessOperation(FlatBufferBuilder builder, ELogicProgramSpecialProcess Type = ELogicProgramSpecialProcess.DisableURO)
		{
			builder.StartTable(1);
			ILogicProgramSpecialProcessOperation.AddType(builder, Type);
			return ILogicProgramSpecialProcessOperation.EndILogicProgramSpecialProcessOperation(builder);
		}

		// Token: 0x0601853A RID: 99642 RVA: 0x00378532 File Offset: 0x00376732
		public static void StartILogicProgramSpecialProcessOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601853B RID: 99643 RVA: 0x0037853B File Offset: 0x0037673B
		public static void AddType(FlatBufferBuilder builder, ELogicProgramSpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601853C RID: 99644 RVA: 0x00378546 File Offset: 0x00376746
		public static Offset<ILogicProgramSpecialProcessOperation> EndILogicProgramSpecialProcessOperation(FlatBufferBuilder builder)
		{
			return new Offset<ILogicProgramSpecialProcessOperation>(builder.EndTable());
		}

		// Token: 0x0601853D RID: 99645 RVA: 0x00378554 File Offset: 0x00376754
		public ILogicProgramSpecialProcessOperationT UnPack()
		{
			ILogicProgramSpecialProcessOperationT logicProgramSpecialProcessOperationT = new ILogicProgramSpecialProcessOperationT();
			this.UnPackTo(logicProgramSpecialProcessOperationT);
			return logicProgramSpecialProcessOperationT;
		}

		// Token: 0x0601853E RID: 99646 RVA: 0x0037856F File Offset: 0x0037676F
		public void UnPackTo(ILogicProgramSpecialProcessOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601853F RID: 99647 RVA: 0x00378580 File Offset: 0x00376780
		public static Offset<ILogicProgramSpecialProcessOperation> Pack(FlatBufferBuilder builder, ILogicProgramSpecialProcessOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILogicProgramSpecialProcessOperation>);
			}
			return ILogicProgramSpecialProcessOperation.CreateILogicProgramSpecialProcessOperation(builder, _o.Type);
		}

		// Token: 0x0400C2F9 RID: 49913
		private Table __p;
	}
}

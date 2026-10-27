using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F17 RID: 16151
	public struct ILogicProgramSpecialProcessOperation : IFlatbufferObject
	{
		// Token: 0x17007055 RID: 28757
		// (get) Token: 0x06016EDA RID: 93914 RVA: 0x0034F24B File Offset: 0x0034D44B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016EDB RID: 93915 RVA: 0x0034F258 File Offset: 0x0034D458
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016EDC RID: 93916 RVA: 0x0034F260 File Offset: 0x0034D460
		public static ILogicProgramSpecialProcessOperation GetRootAsILogicProgramSpecialProcessOperation(ByteBuffer _bb)
		{
			return ILogicProgramSpecialProcessOperation.GetRootAsILogicProgramSpecialProcessOperation(_bb, default(ILogicProgramSpecialProcessOperation));
		}

		// Token: 0x06016EDD RID: 93917 RVA: 0x0034F27C File Offset: 0x0034D47C
		public static ILogicProgramSpecialProcessOperation GetRootAsILogicProgramSpecialProcessOperation(ByteBuffer _bb, ILogicProgramSpecialProcessOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016EDE RID: 93918 RVA: 0x0034F299 File Offset: 0x0034D499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016EDF RID: 93919 RVA: 0x0034F2A8 File Offset: 0x0034D4A8
		public ILogicProgramSpecialProcessOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007056 RID: 28758
		// (get) Token: 0x06016EE0 RID: 93920 RVA: 0x0034F2B8 File Offset: 0x0034D4B8
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

		// Token: 0x06016EE1 RID: 93921 RVA: 0x0034F2F4 File Offset: 0x0034D4F4
		public static Offset<ILogicProgramSpecialProcessOperation> CreateILogicProgramSpecialProcessOperation(FlatBufferBuilder builder, ELogicProgramSpecialProcess Type = ELogicProgramSpecialProcess.DisableURO)
		{
			builder.StartTable(1);
			ILogicProgramSpecialProcessOperation.AddType(builder, Type);
			return ILogicProgramSpecialProcessOperation.EndILogicProgramSpecialProcessOperation(builder);
		}

		// Token: 0x06016EE2 RID: 93922 RVA: 0x0034F30A File Offset: 0x0034D50A
		public static void StartILogicProgramSpecialProcessOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016EE3 RID: 93923 RVA: 0x0034F313 File Offset: 0x0034D513
		public static void AddType(FlatBufferBuilder builder, ELogicProgramSpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016EE4 RID: 93924 RVA: 0x0034F31E File Offset: 0x0034D51E
		public static Offset<ILogicProgramSpecialProcessOperation> EndILogicProgramSpecialProcessOperation(FlatBufferBuilder builder)
		{
			return new Offset<ILogicProgramSpecialProcessOperation>(builder.EndTable());
		}

		// Token: 0x06016EE5 RID: 93925 RVA: 0x0034F32C File Offset: 0x0034D52C
		public ILogicProgramSpecialProcessOperationT UnPack()
		{
			ILogicProgramSpecialProcessOperationT logicProgramSpecialProcessOperationT = new ILogicProgramSpecialProcessOperationT();
			this.UnPackTo(logicProgramSpecialProcessOperationT);
			return logicProgramSpecialProcessOperationT;
		}

		// Token: 0x06016EE6 RID: 93926 RVA: 0x0034F347 File Offset: 0x0034D547
		public void UnPackTo(ILogicProgramSpecialProcessOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016EE7 RID: 93927 RVA: 0x0034F358 File Offset: 0x0034D558
		public static Offset<ILogicProgramSpecialProcessOperation> Pack(FlatBufferBuilder builder, ILogicProgramSpecialProcessOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILogicProgramSpecialProcessOperation>);
			}
			return ILogicProgramSpecialProcessOperation.CreateILogicProgramSpecialProcessOperation(builder, _o.Type);
		}

		// Token: 0x0400B91C RID: 47388
		private Table __p;
	}
}

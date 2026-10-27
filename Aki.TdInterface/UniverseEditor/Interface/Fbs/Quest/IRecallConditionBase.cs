using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004073 RID: 16499
	public struct IRecallConditionBase : IFlatbufferObject
	{
		// Token: 0x1700746D RID: 29805
		// (get) Token: 0x06017FBB RID: 98235 RVA: 0x003760E1 File Offset: 0x003742E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017FBC RID: 98236 RVA: 0x003760EE File Offset: 0x003742EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017FBD RID: 98237 RVA: 0x003760F8 File Offset: 0x003742F8
		public static IRecallConditionBase GetRootAsIRecallConditionBase(ByteBuffer _bb)
		{
			return IRecallConditionBase.GetRootAsIRecallConditionBase(_bb, default(IRecallConditionBase));
		}

		// Token: 0x06017FBE RID: 98238 RVA: 0x00376114 File Offset: 0x00374314
		public static IRecallConditionBase GetRootAsIRecallConditionBase(ByteBuffer _bb, IRecallConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017FBF RID: 98239 RVA: 0x00376131 File Offset: 0x00374331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017FC0 RID: 98240 RVA: 0x00376140 File Offset: 0x00374340
		public IRecallConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700746E RID: 29806
		// (get) Token: 0x06017FC1 RID: 98241 RVA: 0x00376150 File Offset: 0x00374350
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

		// Token: 0x1700746F RID: 29807
		// (get) Token: 0x06017FC2 RID: 98242 RVA: 0x0037618C File Offset: 0x0037438C
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

		// Token: 0x06017FC3 RID: 98243 RVA: 0x003761C8 File Offset: 0x003743C8
		public static Offset<IRecallConditionBase> CreateIRecallConditionBase(FlatBufferBuilder builder, ERecallConditionType Type = ERecallConditionType.ByEntityType, ERecallOperation Operation = ERecallOperation.Include)
		{
			builder.StartTable(2);
			IRecallConditionBase.AddOperation(builder, Operation);
			IRecallConditionBase.AddType(builder, Type);
			return IRecallConditionBase.EndIRecallConditionBase(builder);
		}

		// Token: 0x06017FC4 RID: 98244 RVA: 0x003761E5 File Offset: 0x003743E5
		public static void StartIRecallConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017FC5 RID: 98245 RVA: 0x003761EE File Offset: 0x003743EE
		public static void AddType(FlatBufferBuilder builder, ERecallConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017FC6 RID: 98246 RVA: 0x003761F9 File Offset: 0x003743F9
		public static void AddOperation(FlatBufferBuilder builder, ERecallOperation operation)
		{
			builder.AddByte(1, (byte)operation, 0);
		}

		// Token: 0x06017FC7 RID: 98247 RVA: 0x00376204 File Offset: 0x00374404
		public static Offset<IRecallConditionBase> EndIRecallConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<IRecallConditionBase>(builder.EndTable());
		}

		// Token: 0x06017FC8 RID: 98248 RVA: 0x00376214 File Offset: 0x00374414
		public IRecallConditionBaseT UnPack()
		{
			IRecallConditionBaseT recallConditionBaseT = new IRecallConditionBaseT();
			this.UnPackTo(recallConditionBaseT);
			return recallConditionBaseT;
		}

		// Token: 0x06017FC9 RID: 98249 RVA: 0x0037622F File Offset: 0x0037442F
		public void UnPackTo(IRecallConditionBaseT _o)
		{
			_o.Type = this.Type;
			_o.Operation = this.Operation;
		}

		// Token: 0x06017FCA RID: 98250 RVA: 0x0037624C File Offset: 0x0037444C
		public static Offset<IRecallConditionBase> Pack(FlatBufferBuilder builder, IRecallConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallConditionBase>);
			}
			return IRecallConditionBase.CreateIRecallConditionBase(builder, _o.Type, _o.Operation);
		}

		// Token: 0x0400BBEF RID: 48111
		private Table __p;
	}
}

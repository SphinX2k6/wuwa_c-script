using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF5 RID: 23285
	public struct IModelId : IFlatbufferObject
	{
		// Token: 0x1700A9ED RID: 43501
		// (get) Token: 0x06026418 RID: 156696 RVA: 0x0053DF50 File Offset: 0x0053C150
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026419 RID: 156697 RVA: 0x0053DF5D File Offset: 0x0053C15D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602641A RID: 156698 RVA: 0x0053DF64 File Offset: 0x0053C164
		public static IModelId GetRootAsIModelId(ByteBuffer _bb)
		{
			return IModelId.GetRootAsIModelId(_bb, default(IModelId));
		}

		// Token: 0x0602641B RID: 156699 RVA: 0x0053DF80 File Offset: 0x0053C180
		public static IModelId GetRootAsIModelId(ByteBuffer _bb, IModelId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602641C RID: 156700 RVA: 0x0053DF9D File Offset: 0x0053C19D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602641D RID: 156701 RVA: 0x0053DFAC File Offset: 0x0053C1AC
		public IModelId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9EE RID: 43502
		// (get) Token: 0x0602641E RID: 156702 RVA: 0x0053DFBC File Offset: 0x0053C1BC
		public EModelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModelType.LevelPrefab;
				}
				return (EModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A9EF RID: 43503
		// (get) Token: 0x0602641F RID: 156703 RVA: 0x0053DFF8 File Offset: 0x0053C1F8
		public int ModelId
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

		// Token: 0x06026420 RID: 156704 RVA: 0x0053E034 File Offset: 0x0053C234
		public static Offset<IModelId> CreateIModelId(FlatBufferBuilder builder, EModelType Type = EModelType.LevelPrefab, int ModelId = 0)
		{
			builder.StartTable(2);
			IModelId.AddModelId(builder, ModelId);
			IModelId.AddType(builder, Type);
			return IModelId.EndIModelId(builder);
		}

		// Token: 0x06026421 RID: 156705 RVA: 0x0053E051 File Offset: 0x0053C251
		public static void StartIModelId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026422 RID: 156706 RVA: 0x0053E05A File Offset: 0x0053C25A
		public static void AddType(FlatBufferBuilder builder, EModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026423 RID: 156707 RVA: 0x0053E065 File Offset: 0x0053C265
		public static void AddModelId(FlatBufferBuilder builder, int modelId)
		{
			builder.AddInt(1, modelId, 0);
		}

		// Token: 0x06026424 RID: 156708 RVA: 0x0053E070 File Offset: 0x0053C270
		public static Offset<IModelId> EndIModelId(FlatBufferBuilder builder)
		{
			return new Offset<IModelId>(builder.EndTable());
		}

		// Token: 0x06026425 RID: 156709 RVA: 0x0053E080 File Offset: 0x0053C280
		public IModelIdT UnPack()
		{
			IModelIdT modelIdT = new IModelIdT();
			this.UnPackTo(modelIdT);
			return modelIdT;
		}

		// Token: 0x06026426 RID: 156710 RVA: 0x0053E09B File Offset: 0x0053C29B
		public void UnPackTo(IModelIdT _o)
		{
			_o.Type = this.Type;
			_o.ModelId = this.ModelId;
		}

		// Token: 0x06026427 RID: 156711 RVA: 0x0053E0B8 File Offset: 0x0053C2B8
		public static Offset<IModelId> Pack(FlatBufferBuilder builder, IModelIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModelId>);
			}
			return IModelId.CreateIModelId(builder, _o.Type, _o.ModelId);
		}

		// Token: 0x0400F4D1 RID: 62673
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005563 RID: 21859
	public struct IModelId : IFlatbufferObject
	{
		// Token: 0x1700A177 RID: 41335
		// (get) Token: 0x06024273 RID: 148083 RVA: 0x004FE68C File Offset: 0x004FC88C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024274 RID: 148084 RVA: 0x004FE699 File Offset: 0x004FC899
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024275 RID: 148085 RVA: 0x004FE6A0 File Offset: 0x004FC8A0
		public static IModelId GetRootAsIModelId(ByteBuffer _bb)
		{
			return IModelId.GetRootAsIModelId(_bb, default(IModelId));
		}

		// Token: 0x06024276 RID: 148086 RVA: 0x004FE6BC File Offset: 0x004FC8BC
		public static IModelId GetRootAsIModelId(ByteBuffer _bb, IModelId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024277 RID: 148087 RVA: 0x004FE6D9 File Offset: 0x004FC8D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024278 RID: 148088 RVA: 0x004FE6E8 File Offset: 0x004FC8E8
		public IModelId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A178 RID: 41336
		// (get) Token: 0x06024279 RID: 148089 RVA: 0x004FE6F8 File Offset: 0x004FC8F8
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

		// Token: 0x1700A179 RID: 41337
		// (get) Token: 0x0602427A RID: 148090 RVA: 0x004FE734 File Offset: 0x004FC934
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

		// Token: 0x0602427B RID: 148091 RVA: 0x004FE770 File Offset: 0x004FC970
		public static Offset<IModelId> CreateIModelId(FlatBufferBuilder builder, EModelType Type = EModelType.LevelPrefab, int ModelId = 0)
		{
			builder.StartTable(2);
			IModelId.AddModelId(builder, ModelId);
			IModelId.AddType(builder, Type);
			return IModelId.EndIModelId(builder);
		}

		// Token: 0x0602427C RID: 148092 RVA: 0x004FE78D File Offset: 0x004FC98D
		public static void StartIModelId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602427D RID: 148093 RVA: 0x004FE796 File Offset: 0x004FC996
		public static void AddType(FlatBufferBuilder builder, EModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602427E RID: 148094 RVA: 0x004FE7A1 File Offset: 0x004FC9A1
		public static void AddModelId(FlatBufferBuilder builder, int modelId)
		{
			builder.AddInt(1, modelId, 0);
		}

		// Token: 0x0602427F RID: 148095 RVA: 0x004FE7AC File Offset: 0x004FC9AC
		public static Offset<IModelId> EndIModelId(FlatBufferBuilder builder)
		{
			return new Offset<IModelId>(builder.EndTable());
		}

		// Token: 0x06024280 RID: 148096 RVA: 0x004FE7BC File Offset: 0x004FC9BC
		public IModelIdT UnPack()
		{
			IModelIdT modelIdT = new IModelIdT();
			this.UnPackTo(modelIdT);
			return modelIdT;
		}

		// Token: 0x06024281 RID: 148097 RVA: 0x004FE7D7 File Offset: 0x004FC9D7
		public void UnPackTo(IModelIdT _o)
		{
			_o.Type = this.Type;
			_o.ModelId = this.ModelId;
		}

		// Token: 0x06024282 RID: 148098 RVA: 0x004FE7F4 File Offset: 0x004FC9F4
		public static Offset<IModelId> Pack(FlatBufferBuilder builder, IModelIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModelId>);
			}
			return IModelId.CreateIModelId(builder, _o.Type, _o.ModelId);
		}

		// Token: 0x0400E87F RID: 59519
		private Table __p;
	}
}

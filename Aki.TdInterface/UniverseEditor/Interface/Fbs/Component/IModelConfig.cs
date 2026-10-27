using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200555D RID: 21853
	public struct IModelConfig : IFlatbufferObject
	{
		// Token: 0x1700A172 RID: 41330
		// (get) Token: 0x0602424F RID: 148047 RVA: 0x004FE34B File Offset: 0x004FC54B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024250 RID: 148048 RVA: 0x004FE358 File Offset: 0x004FC558
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024251 RID: 148049 RVA: 0x004FE360 File Offset: 0x004FC560
		public static IModelConfig GetRootAsIModelConfig(ByteBuffer _bb)
		{
			return IModelConfig.GetRootAsIModelConfig(_bb, default(IModelConfig));
		}

		// Token: 0x06024252 RID: 148050 RVA: 0x004FE37C File Offset: 0x004FC57C
		public static IModelConfig GetRootAsIModelConfig(ByteBuffer _bb, IModelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024253 RID: 148051 RVA: 0x004FE399 File Offset: 0x004FC599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024254 RID: 148052 RVA: 0x004FE3A8 File Offset: 0x004FC5A8
		public IModelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A173 RID: 41331
		// (get) Token: 0x06024255 RID: 148053 RVA: 0x004FE3B8 File Offset: 0x004FC5B8
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

		// Token: 0x06024256 RID: 148054 RVA: 0x004FE3F4 File Offset: 0x004FC5F4
		public static Offset<IModelConfig> CreateIModelConfig(FlatBufferBuilder builder, EModelType Type = EModelType.LevelPrefab)
		{
			builder.StartTable(1);
			IModelConfig.AddType(builder, Type);
			return IModelConfig.EndIModelConfig(builder);
		}

		// Token: 0x06024257 RID: 148055 RVA: 0x004FE40A File Offset: 0x004FC60A
		public static void StartIModelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024258 RID: 148056 RVA: 0x004FE413 File Offset: 0x004FC613
		public static void AddType(FlatBufferBuilder builder, EModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024259 RID: 148057 RVA: 0x004FE41E File Offset: 0x004FC61E
		public static Offset<IModelConfig> EndIModelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IModelConfig>(builder.EndTable());
		}

		// Token: 0x0602425A RID: 148058 RVA: 0x004FE42C File Offset: 0x004FC62C
		public IModelConfigT UnPack()
		{
			IModelConfigT modelConfigT = new IModelConfigT();
			this.UnPackTo(modelConfigT);
			return modelConfigT;
		}

		// Token: 0x0602425B RID: 148059 RVA: 0x004FE447 File Offset: 0x004FC647
		public void UnPackTo(IModelConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602425C RID: 148060 RVA: 0x004FE458 File Offset: 0x004FC658
		public static Offset<IModelConfig> Pack(FlatBufferBuilder builder, IModelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModelConfig>);
			}
			return IModelConfig.CreateIModelConfig(builder, _o.Type);
		}

		// Token: 0x0400E874 RID: 59508
		private Table __p;
	}
}

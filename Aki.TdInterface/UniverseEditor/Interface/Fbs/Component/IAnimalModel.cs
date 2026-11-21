using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D3 RID: 21459
	public struct IAnimalModel : IFlatbufferObject
	{
		// Token: 0x170097DB RID: 38875
		// (get) Token: 0x06021857 RID: 137303 RVA: 0x0049F8B4 File Offset: 0x0049DAB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021858 RID: 137304 RVA: 0x0049F8C1 File Offset: 0x0049DAC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021859 RID: 137305 RVA: 0x0049F8C8 File Offset: 0x0049DAC8
		public static IAnimalModel GetRootAsIAnimalModel(ByteBuffer _bb)
		{
			return IAnimalModel.GetRootAsIAnimalModel(_bb, default(IAnimalModel));
		}

		// Token: 0x0602185A RID: 137306 RVA: 0x0049F8E4 File Offset: 0x0049DAE4
		public static IAnimalModel GetRootAsIAnimalModel(ByteBuffer _bb, IAnimalModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602185B RID: 137307 RVA: 0x0049F901 File Offset: 0x0049DB01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602185C RID: 137308 RVA: 0x0049F910 File Offset: 0x0049DB10
		public IAnimalModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097DC RID: 38876
		// (get) Token: 0x0602185D RID: 137309 RVA: 0x0049F920 File Offset: 0x0049DB20
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

		// Token: 0x170097DD RID: 38877
		// (get) Token: 0x0602185E RID: 137310 RVA: 0x0049F95C File Offset: 0x0049DB5C
		public string BlueprintPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602185F RID: 137311 RVA: 0x0049F993 File Offset: 0x0049DB93
		public Span<byte> GetBlueprintPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021860 RID: 137312 RVA: 0x0049F9A2 File Offset: 0x0049DBA2
		public byte[] GetBlueprintPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170097DE RID: 38878
		// (get) Token: 0x06021861 RID: 137313 RVA: 0x0049F9B0 File Offset: 0x0049DBB0
		public IMeshAnimalModel? AnimalModel
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMeshAnimalModel?(default(IMeshAnimalModel).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170097DF RID: 38879
		// (get) Token: 0x06021862 RID: 137314 RVA: 0x0049FA10 File Offset: 0x0049DC10
		public string Abp
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021863 RID: 137315 RVA: 0x0049FA48 File Offset: 0x0049DC48
		public Span<byte> GetAbpBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06021864 RID: 137316 RVA: 0x0049FA58 File Offset: 0x0049DC58
		public byte[] GetAbpArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06021865 RID: 137317 RVA: 0x0049FA67 File Offset: 0x0049DC67
		public static Offset<IAnimalModel> CreateIAnimalModel(FlatBufferBuilder builder, EModelType Type = EModelType.LevelPrefab, StringOffset BlueprintPathOffset = default(StringOffset), Offset<IMeshAnimalModel> AnimalModelOffset = default(Offset<IMeshAnimalModel>), StringOffset AbpOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IAnimalModel.AddAbp(builder, AbpOffset);
			IAnimalModel.AddAnimalModel(builder, AnimalModelOffset);
			IAnimalModel.AddBlueprintPath(builder, BlueprintPathOffset);
			IAnimalModel.AddType(builder, Type);
			return IAnimalModel.EndIAnimalModel(builder);
		}

		// Token: 0x06021866 RID: 137318 RVA: 0x0049FA93 File Offset: 0x0049DC93
		public static void StartIAnimalModel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021867 RID: 137319 RVA: 0x0049FA9C File Offset: 0x0049DC9C
		public static void AddType(FlatBufferBuilder builder, EModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021868 RID: 137320 RVA: 0x0049FAA7 File Offset: 0x0049DCA7
		public static void AddBlueprintPath(FlatBufferBuilder builder, StringOffset blueprintPathOffset)
		{
			builder.AddOffset(1, blueprintPathOffset.Value, 0);
		}

		// Token: 0x06021869 RID: 137321 RVA: 0x0049FAB7 File Offset: 0x0049DCB7
		public static void AddAnimalModel(FlatBufferBuilder builder, Offset<IMeshAnimalModel> animalModelOffset)
		{
			builder.AddOffset(2, animalModelOffset.Value, 0);
		}

		// Token: 0x0602186A RID: 137322 RVA: 0x0049FAC7 File Offset: 0x0049DCC7
		public static void AddAbp(FlatBufferBuilder builder, StringOffset abpOffset)
		{
			builder.AddOffset(3, abpOffset.Value, 0);
		}

		// Token: 0x0602186B RID: 137323 RVA: 0x0049FAD7 File Offset: 0x0049DCD7
		public static Offset<IAnimalModel> EndIAnimalModel(FlatBufferBuilder builder)
		{
			return new Offset<IAnimalModel>(builder.EndTable());
		}

		// Token: 0x0602186C RID: 137324 RVA: 0x0049FAE4 File Offset: 0x0049DCE4
		public IAnimalModelT UnPack()
		{
			IAnimalModelT animalModelT = new IAnimalModelT();
			this.UnPackTo(animalModelT);
			return animalModelT;
		}

		// Token: 0x0602186D RID: 137325 RVA: 0x0049FB00 File Offset: 0x0049DD00
		public void UnPackTo(IAnimalModelT _o)
		{
			_o.Type = this.Type;
			_o.BlueprintPath = this.BlueprintPath;
			_o.AnimalModel = ((this.AnimalModel != null) ? this.AnimalModel.Value.UnPack() : null);
			_o.Abp = this.Abp;
		}

		// Token: 0x0602186E RID: 137326 RVA: 0x0049FB60 File Offset: 0x0049DD60
		public static Offset<IAnimalModel> Pack(FlatBufferBuilder builder, IAnimalModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAnimalModel>);
			}
			StringOffset blueprintPathOffset = (_o.BlueprintPath == null) ? default(StringOffset) : builder.CreateString(_o.BlueprintPath);
			Offset<IMeshAnimalModel> animalModelOffset = (_o.AnimalModel == null) ? default(Offset<IMeshAnimalModel>) : IMeshAnimalModel.Pack(builder, _o.AnimalModel);
			StringOffset abpOffset = (_o.Abp == null) ? default(StringOffset) : builder.CreateString(_o.Abp);
			return IAnimalModel.CreateIAnimalModel(builder, _o.Type, blueprintPathOffset, animalModelOffset, abpOffset);
		}

		// Token: 0x0400E829 RID: 59433
		private Table __p;
	}
}

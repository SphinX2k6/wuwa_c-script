using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EAA RID: 20138
	public struct IAnimalModel : IFlatbufferObject
	{
		// Token: 0x1700907A RID: 36986
		// (get) Token: 0x0601FB56 RID: 129878 RVA: 0x0046A438 File Offset: 0x00468638
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FB57 RID: 129879 RVA: 0x0046A445 File Offset: 0x00468645
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FB58 RID: 129880 RVA: 0x0046A44C File Offset: 0x0046864C
		public static IAnimalModel GetRootAsIAnimalModel(ByteBuffer _bb)
		{
			return IAnimalModel.GetRootAsIAnimalModel(_bb, default(IAnimalModel));
		}

		// Token: 0x0601FB59 RID: 129881 RVA: 0x0046A468 File Offset: 0x00468668
		public static IAnimalModel GetRootAsIAnimalModel(ByteBuffer _bb, IAnimalModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FB5A RID: 129882 RVA: 0x0046A485 File Offset: 0x00468685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FB5B RID: 129883 RVA: 0x0046A494 File Offset: 0x00468694
		public IAnimalModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700907B RID: 36987
		// (get) Token: 0x0601FB5C RID: 129884 RVA: 0x0046A4A4 File Offset: 0x004686A4
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

		// Token: 0x1700907C RID: 36988
		// (get) Token: 0x0601FB5D RID: 129885 RVA: 0x0046A4E0 File Offset: 0x004686E0
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

		// Token: 0x0601FB5E RID: 129886 RVA: 0x0046A517 File Offset: 0x00468717
		public Span<byte> GetBlueprintPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601FB5F RID: 129887 RVA: 0x0046A526 File Offset: 0x00468726
		public byte[] GetBlueprintPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700907D RID: 36989
		// (get) Token: 0x0601FB60 RID: 129888 RVA: 0x0046A534 File Offset: 0x00468734
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

		// Token: 0x1700907E RID: 36990
		// (get) Token: 0x0601FB61 RID: 129889 RVA: 0x0046A594 File Offset: 0x00468794
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

		// Token: 0x0601FB62 RID: 129890 RVA: 0x0046A5CC File Offset: 0x004687CC
		public Span<byte> GetAbpBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601FB63 RID: 129891 RVA: 0x0046A5DC File Offset: 0x004687DC
		public byte[] GetAbpArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601FB64 RID: 129892 RVA: 0x0046A5EB File Offset: 0x004687EB
		public static Offset<IAnimalModel> CreateIAnimalModel(FlatBufferBuilder builder, EModelType Type = EModelType.LevelPrefab, StringOffset BlueprintPathOffset = default(StringOffset), Offset<IMeshAnimalModel> AnimalModelOffset = default(Offset<IMeshAnimalModel>), StringOffset AbpOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IAnimalModel.AddAbp(builder, AbpOffset);
			IAnimalModel.AddAnimalModel(builder, AnimalModelOffset);
			IAnimalModel.AddBlueprintPath(builder, BlueprintPathOffset);
			IAnimalModel.AddType(builder, Type);
			return IAnimalModel.EndIAnimalModel(builder);
		}

		// Token: 0x0601FB65 RID: 129893 RVA: 0x0046A617 File Offset: 0x00468817
		public static void StartIAnimalModel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601FB66 RID: 129894 RVA: 0x0046A620 File Offset: 0x00468820
		public static void AddType(FlatBufferBuilder builder, EModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FB67 RID: 129895 RVA: 0x0046A62B File Offset: 0x0046882B
		public static void AddBlueprintPath(FlatBufferBuilder builder, StringOffset blueprintPathOffset)
		{
			builder.AddOffset(1, blueprintPathOffset.Value, 0);
		}

		// Token: 0x0601FB68 RID: 129896 RVA: 0x0046A63B File Offset: 0x0046883B
		public static void AddAnimalModel(FlatBufferBuilder builder, Offset<IMeshAnimalModel> animalModelOffset)
		{
			builder.AddOffset(2, animalModelOffset.Value, 0);
		}

		// Token: 0x0601FB69 RID: 129897 RVA: 0x0046A64B File Offset: 0x0046884B
		public static void AddAbp(FlatBufferBuilder builder, StringOffset abpOffset)
		{
			builder.AddOffset(3, abpOffset.Value, 0);
		}

		// Token: 0x0601FB6A RID: 129898 RVA: 0x0046A65B File Offset: 0x0046885B
		public static Offset<IAnimalModel> EndIAnimalModel(FlatBufferBuilder builder)
		{
			return new Offset<IAnimalModel>(builder.EndTable());
		}

		// Token: 0x0601FB6B RID: 129899 RVA: 0x0046A668 File Offset: 0x00468868
		public IAnimalModelT UnPack()
		{
			IAnimalModelT animalModelT = new IAnimalModelT();
			this.UnPackTo(animalModelT);
			return animalModelT;
		}

		// Token: 0x0601FB6C RID: 129900 RVA: 0x0046A684 File Offset: 0x00468884
		public void UnPackTo(IAnimalModelT _o)
		{
			_o.Type = this.Type;
			_o.BlueprintPath = this.BlueprintPath;
			_o.AnimalModel = ((this.AnimalModel != null) ? this.AnimalModel.Value.UnPack() : null);
			_o.Abp = this.Abp;
		}

		// Token: 0x0601FB6D RID: 129901 RVA: 0x0046A6E4 File Offset: 0x004688E4
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

		// Token: 0x0400DC8D RID: 56461
		private Table __p;
	}
}

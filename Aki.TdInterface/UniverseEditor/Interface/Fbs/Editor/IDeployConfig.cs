using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004850 RID: 18512
	public struct IDeployConfig : IFlatbufferObject
	{
		// Token: 0x170084E5 RID: 34021
		// (get) Token: 0x0601CA3E RID: 117310 RVA: 0x0040C66D File Offset: 0x0040A86D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CA3F RID: 117311 RVA: 0x0040C67A File Offset: 0x0040A87A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CA40 RID: 117312 RVA: 0x0040C684 File Offset: 0x0040A884
		public static IDeployConfig GetRootAsIDeployConfig(ByteBuffer _bb)
		{
			return IDeployConfig.GetRootAsIDeployConfig(_bb, default(IDeployConfig));
		}

		// Token: 0x0601CA41 RID: 117313 RVA: 0x0040C6A0 File Offset: 0x0040A8A0
		public static IDeployConfig GetRootAsIDeployConfig(ByteBuffer _bb, IDeployConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CA42 RID: 117314 RVA: 0x0040C6BD File Offset: 0x0040A8BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CA43 RID: 117315 RVA: 0x0040C6CC File Offset: 0x0040A8CC
		public IDeployConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084E6 RID: 34022
		// (get) Token: 0x0601CA44 RID: 117316 RVA: 0x0040C6DC File Offset: 0x0040A8DC
		public bool IsShowDeploySettings
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170084E7 RID: 34023
		// (get) Token: 0x0601CA45 RID: 117317 RVA: 0x0040C71C File Offset: 0x0040A91C
		public bool IsEnableInputDeployFolder
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CA46 RID: 117318 RVA: 0x0040C75C File Offset: 0x0040A95C
		public Record_Int_IEntityDeployConfig? DefaultEntityDeployConfigByLevelId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_IEntityDeployConfig?(default(Record_Int_IEntityDeployConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170084E8 RID: 34024
		// (get) Token: 0x0601CA47 RID: 117319 RVA: 0x0040C7BC File Offset: 0x0040A9BC
		public int DefaultEntityDeployConfigByLevelIdLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170084E9 RID: 34025
		// (get) Token: 0x0601CA48 RID: 117320 RVA: 0x0040C7E8 File Offset: 0x0040A9E8
		public bool IsUseEntityDeployFolder
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CA49 RID: 117321 RVA: 0x0040C828 File Offset: 0x0040AA28
		public Record_Int_IActorDeployConfig? DefaultActorDeployConfigByLevelId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_IActorDeployConfig?(default(Record_Int_IActorDeployConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170084EA RID: 34026
		// (get) Token: 0x0601CA4A RID: 117322 RVA: 0x0040C88C File Offset: 0x0040AA8C
		public int DefaultActorDeployConfigByLevelIdLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170084EB RID: 34027
		// (get) Token: 0x0601CA4B RID: 117323 RVA: 0x0040C8B8 File Offset: 0x0040AAB8
		public bool IsUseActorDeployFolder
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170084EC RID: 34028
		// (get) Token: 0x0601CA4C RID: 117324 RVA: 0x0040C8F8 File Offset: 0x0040AAF8
		public bool IsUsePackId
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CA4D RID: 117325 RVA: 0x0040C938 File Offset: 0x0040AB38
		public Record_Int_Int? DefaultEntityPackIdByLevelId(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_Int?(default(Record_Int_Int).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170084ED RID: 34029
		// (get) Token: 0x0601CA4E RID: 117326 RVA: 0x0040C99C File Offset: 0x0040AB9C
		public int DefaultEntityPackIdByLevelIdLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601CA4F RID: 117327 RVA: 0x0040C9C8 File Offset: 0x0040ABC8
		public IComponentFieldModification? PostProcessComponents(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IComponentFieldModification?(default(IComponentFieldModification).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170084EE RID: 34030
		// (get) Token: 0x0601CA50 RID: 117328 RVA: 0x0040CA2C File Offset: 0x0040AC2C
		public int PostProcessComponentsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601CA51 RID: 117329 RVA: 0x0040CA58 File Offset: 0x0040AC58
		public static Offset<IDeployConfig> CreateIDeployConfig(FlatBufferBuilder builder, bool IsShowDeploySettings = false, bool IsEnableInputDeployFolder = false, VectorOffset DefaultEntityDeployConfigByLevelIdOffset = default(VectorOffset), bool IsUseEntityDeployFolder = false, VectorOffset DefaultActorDeployConfigByLevelIdOffset = default(VectorOffset), bool IsUseActorDeployFolder = false, bool IsUsePackId = false, VectorOffset DefaultEntityPackIdByLevelIdOffset = default(VectorOffset), VectorOffset PostProcessComponentsOffset = default(VectorOffset))
		{
			builder.StartTable(9);
			IDeployConfig.AddPostProcessComponents(builder, PostProcessComponentsOffset);
			IDeployConfig.AddDefaultEntityPackIdByLevelId(builder, DefaultEntityPackIdByLevelIdOffset);
			IDeployConfig.AddDefaultActorDeployConfigByLevelId(builder, DefaultActorDeployConfigByLevelIdOffset);
			IDeployConfig.AddDefaultEntityDeployConfigByLevelId(builder, DefaultEntityDeployConfigByLevelIdOffset);
			IDeployConfig.AddIsUsePackId(builder, IsUsePackId);
			IDeployConfig.AddIsUseActorDeployFolder(builder, IsUseActorDeployFolder);
			IDeployConfig.AddIsUseEntityDeployFolder(builder, IsUseEntityDeployFolder);
			IDeployConfig.AddIsEnableInputDeployFolder(builder, IsEnableInputDeployFolder);
			IDeployConfig.AddIsShowDeploySettings(builder, IsShowDeploySettings);
			return IDeployConfig.EndIDeployConfig(builder);
		}

		// Token: 0x0601CA52 RID: 117330 RVA: 0x0040CAB8 File Offset: 0x0040ACB8
		public static void StartIDeployConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601CA53 RID: 117331 RVA: 0x0040CAC2 File Offset: 0x0040ACC2
		public static void AddIsShowDeploySettings(FlatBufferBuilder builder, bool isShowDeploySettings)
		{
			builder.AddBool(0, isShowDeploySettings, false);
		}

		// Token: 0x0601CA54 RID: 117332 RVA: 0x0040CACD File Offset: 0x0040ACCD
		public static void AddIsEnableInputDeployFolder(FlatBufferBuilder builder, bool isEnableInputDeployFolder)
		{
			builder.AddBool(1, isEnableInputDeployFolder, false);
		}

		// Token: 0x0601CA55 RID: 117333 RVA: 0x0040CAD8 File Offset: 0x0040ACD8
		public static void AddDefaultEntityDeployConfigByLevelId(FlatBufferBuilder builder, VectorOffset defaultEntityDeployConfigByLevelIdOffset)
		{
			builder.AddOffset(2, defaultEntityDeployConfigByLevelIdOffset.Value, 0);
		}

		// Token: 0x0601CA56 RID: 117334 RVA: 0x0040CAE8 File Offset: 0x0040ACE8
		public static VectorOffset CreateDefaultEntityDeployConfigByLevelIdVector(FlatBufferBuilder builder, Offset<Record_Int_IEntityDeployConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CA57 RID: 117335 RVA: 0x0040CB28 File Offset: 0x0040AD28
		public static VectorOffset CreateDefaultEntityDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_IEntityDeployConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_IEntityDeployConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA58 RID: 117336 RVA: 0x0040CB42 File Offset: 0x0040AD42
		public static VectorOffset CreateDefaultEntityDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_IEntityDeployConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_IEntityDeployConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA59 RID: 117337 RVA: 0x0040CB60 File Offset: 0x0040AD60
		public static VectorOffset CreateDefaultEntityDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_IEntityDeployConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CA5A RID: 117338 RVA: 0x0040CB79 File Offset: 0x0040AD79
		public static void StartDefaultEntityDeployConfigByLevelIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CA5B RID: 117339 RVA: 0x0040CB84 File Offset: 0x0040AD84
		public static void AddIsUseEntityDeployFolder(FlatBufferBuilder builder, bool isUseEntityDeployFolder)
		{
			builder.AddBool(3, isUseEntityDeployFolder, false);
		}

		// Token: 0x0601CA5C RID: 117340 RVA: 0x0040CB8F File Offset: 0x0040AD8F
		public static void AddDefaultActorDeployConfigByLevelId(FlatBufferBuilder builder, VectorOffset defaultActorDeployConfigByLevelIdOffset)
		{
			builder.AddOffset(4, defaultActorDeployConfigByLevelIdOffset.Value, 0);
		}

		// Token: 0x0601CA5D RID: 117341 RVA: 0x0040CBA0 File Offset: 0x0040ADA0
		public static VectorOffset CreateDefaultActorDeployConfigByLevelIdVector(FlatBufferBuilder builder, Offset<Record_Int_IActorDeployConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CA5E RID: 117342 RVA: 0x0040CBE0 File Offset: 0x0040ADE0
		public static VectorOffset CreateDefaultActorDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_IActorDeployConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_IActorDeployConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA5F RID: 117343 RVA: 0x0040CBFA File Offset: 0x0040ADFA
		public static VectorOffset CreateDefaultActorDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_IActorDeployConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_IActorDeployConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA60 RID: 117344 RVA: 0x0040CC18 File Offset: 0x0040AE18
		public static VectorOffset CreateDefaultActorDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_IActorDeployConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CA61 RID: 117345 RVA: 0x0040CC31 File Offset: 0x0040AE31
		public static void StartDefaultActorDeployConfigByLevelIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CA62 RID: 117346 RVA: 0x0040CC3C File Offset: 0x0040AE3C
		public static void AddIsUseActorDeployFolder(FlatBufferBuilder builder, bool isUseActorDeployFolder)
		{
			builder.AddBool(5, isUseActorDeployFolder, false);
		}

		// Token: 0x0601CA63 RID: 117347 RVA: 0x0040CC47 File Offset: 0x0040AE47
		public static void AddIsUsePackId(FlatBufferBuilder builder, bool isUsePackId)
		{
			builder.AddBool(6, isUsePackId, false);
		}

		// Token: 0x0601CA64 RID: 117348 RVA: 0x0040CC52 File Offset: 0x0040AE52
		public static void AddDefaultEntityPackIdByLevelId(FlatBufferBuilder builder, VectorOffset defaultEntityPackIdByLevelIdOffset)
		{
			builder.AddOffset(7, defaultEntityPackIdByLevelIdOffset.Value, 0);
		}

		// Token: 0x0601CA65 RID: 117349 RVA: 0x0040CC64 File Offset: 0x0040AE64
		public static VectorOffset CreateDefaultEntityPackIdByLevelIdVector(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CA66 RID: 117350 RVA: 0x0040CCA4 File Offset: 0x0040AEA4
		public static VectorOffset CreateDefaultEntityPackIdByLevelIdVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA67 RID: 117351 RVA: 0x0040CCBE File Offset: 0x0040AEBE
		public static VectorOffset CreateDefaultEntityPackIdByLevelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_Int>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA68 RID: 117352 RVA: 0x0040CCDC File Offset: 0x0040AEDC
		public static VectorOffset CreateDefaultEntityPackIdByLevelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_Int>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CA69 RID: 117353 RVA: 0x0040CCF5 File Offset: 0x0040AEF5
		public static void StartDefaultEntityPackIdByLevelIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CA6A RID: 117354 RVA: 0x0040CD00 File Offset: 0x0040AF00
		public static void AddPostProcessComponents(FlatBufferBuilder builder, VectorOffset postProcessComponentsOffset)
		{
			builder.AddOffset(8, postProcessComponentsOffset.Value, 0);
		}

		// Token: 0x0601CA6B RID: 117355 RVA: 0x0040CD10 File Offset: 0x0040AF10
		public static VectorOffset CreatePostProcessComponentsVector(FlatBufferBuilder builder, Offset<IComponentFieldModification>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CA6C RID: 117356 RVA: 0x0040CD50 File Offset: 0x0040AF50
		public static VectorOffset CreatePostProcessComponentsVectorBlock(FlatBufferBuilder builder, Offset<IComponentFieldModification>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IComponentFieldModification>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA6D RID: 117357 RVA: 0x0040CD6A File Offset: 0x0040AF6A
		public static VectorOffset CreatePostProcessComponentsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IComponentFieldModification>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IComponentFieldModification>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CA6E RID: 117358 RVA: 0x0040CD88 File Offset: 0x0040AF88
		public static VectorOffset CreatePostProcessComponentsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IComponentFieldModification>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CA6F RID: 117359 RVA: 0x0040CDA1 File Offset: 0x0040AFA1
		public static void StartPostProcessComponentsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CA70 RID: 117360 RVA: 0x0040CDAC File Offset: 0x0040AFAC
		public static Offset<IDeployConfig> EndIDeployConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeployConfig>(builder.EndTable());
		}

		// Token: 0x0601CA71 RID: 117361 RVA: 0x0040CDBC File Offset: 0x0040AFBC
		public IDeployConfigT UnPack()
		{
			IDeployConfigT deployConfigT = new IDeployConfigT();
			this.UnPackTo(deployConfigT);
			return deployConfigT;
		}

		// Token: 0x0601CA72 RID: 117362 RVA: 0x0040CDD8 File Offset: 0x0040AFD8
		public void UnPackTo(IDeployConfigT _o)
		{
			_o.IsShowDeploySettings = this.IsShowDeploySettings;
			_o.IsEnableInputDeployFolder = this.IsEnableInputDeployFolder;
			_o.DefaultEntityDeployConfigByLevelId = new List<Record_Int_IEntityDeployConfigT>();
			for (int i = 0; i < this.DefaultEntityDeployConfigByLevelIdLength; i++)
			{
				_o.DefaultEntityDeployConfigByLevelId.Add((this.DefaultEntityDeployConfigByLevelId(i) != null) ? this.DefaultEntityDeployConfigByLevelId(i).Value.UnPack() : null);
			}
			_o.IsUseEntityDeployFolder = this.IsUseEntityDeployFolder;
			_o.DefaultActorDeployConfigByLevelId = new List<Record_Int_IActorDeployConfigT>();
			for (int j = 0; j < this.DefaultActorDeployConfigByLevelIdLength; j++)
			{
				_o.DefaultActorDeployConfigByLevelId.Add((this.DefaultActorDeployConfigByLevelId(j) != null) ? this.DefaultActorDeployConfigByLevelId(j).Value.UnPack() : null);
			}
			_o.IsUseActorDeployFolder = this.IsUseActorDeployFolder;
			_o.IsUsePackId = this.IsUsePackId;
			_o.DefaultEntityPackIdByLevelId = new List<Record_Int_IntT>();
			for (int k = 0; k < this.DefaultEntityPackIdByLevelIdLength; k++)
			{
				_o.DefaultEntityPackIdByLevelId.Add((this.DefaultEntityPackIdByLevelId(k) != null) ? this.DefaultEntityPackIdByLevelId(k).Value.UnPack() : null);
			}
			_o.PostProcessComponents = new List<IComponentFieldModificationT>();
			for (int l = 0; l < this.PostProcessComponentsLength; l++)
			{
				_o.PostProcessComponents.Add((this.PostProcessComponents(l) != null) ? this.PostProcessComponents(l).Value.UnPack() : null);
			}
		}

		// Token: 0x0601CA73 RID: 117363 RVA: 0x0040CF80 File Offset: 0x0040B180
		public static Offset<IDeployConfig> Pack(FlatBufferBuilder builder, IDeployConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeployConfig>);
			}
			VectorOffset defaultEntityDeployConfigByLevelIdOffset = default(VectorOffset);
			if (_o.DefaultEntityDeployConfigByLevelId != null)
			{
				Offset<Record_Int_IEntityDeployConfig>[] array = new Offset<Record_Int_IEntityDeployConfig>[_o.DefaultEntityDeployConfigByLevelId.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Record_Int_IEntityDeployConfig.Pack(builder, _o.DefaultEntityDeployConfigByLevelId[i]);
				}
				defaultEntityDeployConfigByLevelIdOffset = IDeployConfig.CreateDefaultEntityDeployConfigByLevelIdVector(builder, array);
			}
			VectorOffset defaultActorDeployConfigByLevelIdOffset = default(VectorOffset);
			if (_o.DefaultActorDeployConfigByLevelId != null)
			{
				Offset<Record_Int_IActorDeployConfig>[] array2 = new Offset<Record_Int_IActorDeployConfig>[_o.DefaultActorDeployConfigByLevelId.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = Record_Int_IActorDeployConfig.Pack(builder, _o.DefaultActorDeployConfigByLevelId[j]);
				}
				defaultActorDeployConfigByLevelIdOffset = IDeployConfig.CreateDefaultActorDeployConfigByLevelIdVector(builder, array2);
			}
			VectorOffset defaultEntityPackIdByLevelIdOffset = default(VectorOffset);
			if (_o.DefaultEntityPackIdByLevelId != null)
			{
				Offset<Record_Int_Int>[] array3 = new Offset<Record_Int_Int>[_o.DefaultEntityPackIdByLevelId.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = Record_Int_Int.Pack(builder, _o.DefaultEntityPackIdByLevelId[k]);
				}
				defaultEntityPackIdByLevelIdOffset = IDeployConfig.CreateDefaultEntityPackIdByLevelIdVector(builder, array3);
			}
			VectorOffset postProcessComponentsOffset = default(VectorOffset);
			if (_o.PostProcessComponents != null)
			{
				Offset<IComponentFieldModification>[] array4 = new Offset<IComponentFieldModification>[_o.PostProcessComponents.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IComponentFieldModification.Pack(builder, _o.PostProcessComponents[l]);
				}
				postProcessComponentsOffset = IDeployConfig.CreatePostProcessComponentsVector(builder, array4);
			}
			return IDeployConfig.CreateIDeployConfig(builder, _o.IsShowDeploySettings, _o.IsEnableInputDeployFolder, defaultEntityDeployConfigByLevelIdOffset, _o.IsUseEntityDeployFolder, defaultActorDeployConfigByLevelIdOffset, _o.IsUseActorDeployFolder, _o.IsUsePackId, defaultEntityPackIdByLevelIdOffset, postProcessComponentsOffset);
		}

		// Token: 0x0400CD84 RID: 52612
		private Table __p;
	}
}

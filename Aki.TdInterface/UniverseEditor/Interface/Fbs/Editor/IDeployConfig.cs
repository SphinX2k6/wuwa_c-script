using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CB8 RID: 19640
	public struct IDeployConfig : IFlatbufferObject
	{
		// Token: 0x17008B30 RID: 35632
		// (get) Token: 0x0601E23B RID: 123451 RVA: 0x00438FBD File Offset: 0x004371BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E23C RID: 123452 RVA: 0x00438FCA File Offset: 0x004371CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E23D RID: 123453 RVA: 0x00438FD4 File Offset: 0x004371D4
		public static IDeployConfig GetRootAsIDeployConfig(ByteBuffer _bb)
		{
			return IDeployConfig.GetRootAsIDeployConfig(_bb, default(IDeployConfig));
		}

		// Token: 0x0601E23E RID: 123454 RVA: 0x00438FF0 File Offset: 0x004371F0
		public static IDeployConfig GetRootAsIDeployConfig(ByteBuffer _bb, IDeployConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E23F RID: 123455 RVA: 0x0043900D File Offset: 0x0043720D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E240 RID: 123456 RVA: 0x0043901C File Offset: 0x0043721C
		public IDeployConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B31 RID: 35633
		// (get) Token: 0x0601E241 RID: 123457 RVA: 0x0043902C File Offset: 0x0043722C
		public bool IsShowDeploySettings
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B32 RID: 35634
		// (get) Token: 0x0601E242 RID: 123458 RVA: 0x0043906C File Offset: 0x0043726C
		public bool IsEnableInputDeployFolder
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E243 RID: 123459 RVA: 0x004390AC File Offset: 0x004372AC
		public Record_Int_IEntityDeployConfig? DefaultEntityDeployConfigByLevelId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_IEntityDeployConfig?(default(Record_Int_IEntityDeployConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008B33 RID: 35635
		// (get) Token: 0x0601E244 RID: 123460 RVA: 0x0043910C File Offset: 0x0043730C
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

		// Token: 0x17008B34 RID: 35636
		// (get) Token: 0x0601E245 RID: 123461 RVA: 0x00439138 File Offset: 0x00437338
		public bool IsUseEntityDeployFolder
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E246 RID: 123462 RVA: 0x00439178 File Offset: 0x00437378
		public Record_Int_IActorDeployConfig? DefaultActorDeployConfigByLevelId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_IActorDeployConfig?(default(Record_Int_IActorDeployConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008B35 RID: 35637
		// (get) Token: 0x0601E247 RID: 123463 RVA: 0x004391DC File Offset: 0x004373DC
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

		// Token: 0x17008B36 RID: 35638
		// (get) Token: 0x0601E248 RID: 123464 RVA: 0x00439208 File Offset: 0x00437408
		public bool IsUseActorDeployFolder
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B37 RID: 35639
		// (get) Token: 0x0601E249 RID: 123465 RVA: 0x00439248 File Offset: 0x00437448
		public bool IsUsePackId
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E24A RID: 123466 RVA: 0x00439288 File Offset: 0x00437488
		public Record_Int_Int? DefaultEntityPackIdByLevelId(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_Int?(default(Record_Int_Int).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008B38 RID: 35640
		// (get) Token: 0x0601E24B RID: 123467 RVA: 0x004392EC File Offset: 0x004374EC
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

		// Token: 0x0601E24C RID: 123468 RVA: 0x00439318 File Offset: 0x00437518
		public IComponentFieldModification? PostProcessComponents(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IComponentFieldModification?(default(IComponentFieldModification).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008B39 RID: 35641
		// (get) Token: 0x0601E24D RID: 123469 RVA: 0x0043937C File Offset: 0x0043757C
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

		// Token: 0x0601E24E RID: 123470 RVA: 0x004393A8 File Offset: 0x004375A8
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

		// Token: 0x0601E24F RID: 123471 RVA: 0x00439408 File Offset: 0x00437608
		public static void StartIDeployConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601E250 RID: 123472 RVA: 0x00439412 File Offset: 0x00437612
		public static void AddIsShowDeploySettings(FlatBufferBuilder builder, bool isShowDeploySettings)
		{
			builder.AddBool(0, isShowDeploySettings, false);
		}

		// Token: 0x0601E251 RID: 123473 RVA: 0x0043941D File Offset: 0x0043761D
		public static void AddIsEnableInputDeployFolder(FlatBufferBuilder builder, bool isEnableInputDeployFolder)
		{
			builder.AddBool(1, isEnableInputDeployFolder, false);
		}

		// Token: 0x0601E252 RID: 123474 RVA: 0x00439428 File Offset: 0x00437628
		public static void AddDefaultEntityDeployConfigByLevelId(FlatBufferBuilder builder, VectorOffset defaultEntityDeployConfigByLevelIdOffset)
		{
			builder.AddOffset(2, defaultEntityDeployConfigByLevelIdOffset.Value, 0);
		}

		// Token: 0x0601E253 RID: 123475 RVA: 0x00439438 File Offset: 0x00437638
		public static VectorOffset CreateDefaultEntityDeployConfigByLevelIdVector(FlatBufferBuilder builder, Offset<Record_Int_IEntityDeployConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E254 RID: 123476 RVA: 0x00439478 File Offset: 0x00437678
		public static VectorOffset CreateDefaultEntityDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_IEntityDeployConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_IEntityDeployConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E255 RID: 123477 RVA: 0x00439492 File Offset: 0x00437692
		public static VectorOffset CreateDefaultEntityDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_IEntityDeployConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_IEntityDeployConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E256 RID: 123478 RVA: 0x004394B0 File Offset: 0x004376B0
		public static VectorOffset CreateDefaultEntityDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_IEntityDeployConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E257 RID: 123479 RVA: 0x004394C9 File Offset: 0x004376C9
		public static void StartDefaultEntityDeployConfigByLevelIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E258 RID: 123480 RVA: 0x004394D4 File Offset: 0x004376D4
		public static void AddIsUseEntityDeployFolder(FlatBufferBuilder builder, bool isUseEntityDeployFolder)
		{
			builder.AddBool(3, isUseEntityDeployFolder, false);
		}

		// Token: 0x0601E259 RID: 123481 RVA: 0x004394DF File Offset: 0x004376DF
		public static void AddDefaultActorDeployConfigByLevelId(FlatBufferBuilder builder, VectorOffset defaultActorDeployConfigByLevelIdOffset)
		{
			builder.AddOffset(4, defaultActorDeployConfigByLevelIdOffset.Value, 0);
		}

		// Token: 0x0601E25A RID: 123482 RVA: 0x004394F0 File Offset: 0x004376F0
		public static VectorOffset CreateDefaultActorDeployConfigByLevelIdVector(FlatBufferBuilder builder, Offset<Record_Int_IActorDeployConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E25B RID: 123483 RVA: 0x00439530 File Offset: 0x00437730
		public static VectorOffset CreateDefaultActorDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_IActorDeployConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_IActorDeployConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E25C RID: 123484 RVA: 0x0043954A File Offset: 0x0043774A
		public static VectorOffset CreateDefaultActorDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_IActorDeployConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_IActorDeployConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E25D RID: 123485 RVA: 0x00439568 File Offset: 0x00437768
		public static VectorOffset CreateDefaultActorDeployConfigByLevelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_IActorDeployConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E25E RID: 123486 RVA: 0x00439581 File Offset: 0x00437781
		public static void StartDefaultActorDeployConfigByLevelIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E25F RID: 123487 RVA: 0x0043958C File Offset: 0x0043778C
		public static void AddIsUseActorDeployFolder(FlatBufferBuilder builder, bool isUseActorDeployFolder)
		{
			builder.AddBool(5, isUseActorDeployFolder, false);
		}

		// Token: 0x0601E260 RID: 123488 RVA: 0x00439597 File Offset: 0x00437797
		public static void AddIsUsePackId(FlatBufferBuilder builder, bool isUsePackId)
		{
			builder.AddBool(6, isUsePackId, false);
		}

		// Token: 0x0601E261 RID: 123489 RVA: 0x004395A2 File Offset: 0x004377A2
		public static void AddDefaultEntityPackIdByLevelId(FlatBufferBuilder builder, VectorOffset defaultEntityPackIdByLevelIdOffset)
		{
			builder.AddOffset(7, defaultEntityPackIdByLevelIdOffset.Value, 0);
		}

		// Token: 0x0601E262 RID: 123490 RVA: 0x004395B4 File Offset: 0x004377B4
		public static VectorOffset CreateDefaultEntityPackIdByLevelIdVector(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E263 RID: 123491 RVA: 0x004395F4 File Offset: 0x004377F4
		public static VectorOffset CreateDefaultEntityPackIdByLevelIdVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E264 RID: 123492 RVA: 0x0043960E File Offset: 0x0043780E
		public static VectorOffset CreateDefaultEntityPackIdByLevelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_Int>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E265 RID: 123493 RVA: 0x0043962C File Offset: 0x0043782C
		public static VectorOffset CreateDefaultEntityPackIdByLevelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_Int>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E266 RID: 123494 RVA: 0x00439645 File Offset: 0x00437845
		public static void StartDefaultEntityPackIdByLevelIdVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E267 RID: 123495 RVA: 0x00439650 File Offset: 0x00437850
		public static void AddPostProcessComponents(FlatBufferBuilder builder, VectorOffset postProcessComponentsOffset)
		{
			builder.AddOffset(8, postProcessComponentsOffset.Value, 0);
		}

		// Token: 0x0601E268 RID: 123496 RVA: 0x00439660 File Offset: 0x00437860
		public static VectorOffset CreatePostProcessComponentsVector(FlatBufferBuilder builder, Offset<IComponentFieldModification>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E269 RID: 123497 RVA: 0x004396A0 File Offset: 0x004378A0
		public static VectorOffset CreatePostProcessComponentsVectorBlock(FlatBufferBuilder builder, Offset<IComponentFieldModification>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IComponentFieldModification>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E26A RID: 123498 RVA: 0x004396BA File Offset: 0x004378BA
		public static VectorOffset CreatePostProcessComponentsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IComponentFieldModification>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IComponentFieldModification>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E26B RID: 123499 RVA: 0x004396D8 File Offset: 0x004378D8
		public static VectorOffset CreatePostProcessComponentsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IComponentFieldModification>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E26C RID: 123500 RVA: 0x004396F1 File Offset: 0x004378F1
		public static void StartPostProcessComponentsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E26D RID: 123501 RVA: 0x004396FC File Offset: 0x004378FC
		public static Offset<IDeployConfig> EndIDeployConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDeployConfig>(builder.EndTable());
		}

		// Token: 0x0601E26E RID: 123502 RVA: 0x0043970C File Offset: 0x0043790C
		public IDeployConfigT UnPack()
		{
			IDeployConfigT deployConfigT = new IDeployConfigT();
			this.UnPackTo(deployConfigT);
			return deployConfigT;
		}

		// Token: 0x0601E26F RID: 123503 RVA: 0x00439728 File Offset: 0x00437928
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

		// Token: 0x0601E270 RID: 123504 RVA: 0x004398D0 File Offset: 0x00437AD0
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

		// Token: 0x0400D7BF RID: 55231
		private Table __p;
	}
}

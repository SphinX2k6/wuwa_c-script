using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC4 RID: 23492
	public struct INpcModel : IFlatbufferObject
	{
		// Token: 0x1700ABB4 RID: 43956
		// (get) Token: 0x06026BBF RID: 158655 RVA: 0x0054D2F3 File Offset: 0x0054B4F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026BC0 RID: 158656 RVA: 0x0054D300 File Offset: 0x0054B500
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026BC1 RID: 158657 RVA: 0x0054D308 File Offset: 0x0054B508
		public static INpcModel GetRootAsINpcModel(ByteBuffer _bb)
		{
			return INpcModel.GetRootAsINpcModel(_bb, default(INpcModel));
		}

		// Token: 0x06026BC2 RID: 158658 RVA: 0x0054D324 File Offset: 0x0054B524
		public static INpcModel GetRootAsINpcModel(ByteBuffer _bb, INpcModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026BC3 RID: 158659 RVA: 0x0054D341 File Offset: 0x0054B541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026BC4 RID: 158660 RVA: 0x0054D350 File Offset: 0x0054B550
		public INpcModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABB5 RID: 43957
		// (get) Token: 0x06026BC5 RID: 158661 RVA: 0x0054D360 File Offset: 0x0054B560
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

		// Token: 0x1700ABB6 RID: 43958
		// (get) Token: 0x06026BC6 RID: 158662 RVA: 0x0054D39C File Offset: 0x0054B59C
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

		// Token: 0x06026BC7 RID: 158663 RVA: 0x0054D3D3 File Offset: 0x0054B5D3
		public Span<byte> GetBlueprintPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026BC8 RID: 158664 RVA: 0x0054D3E2 File Offset: 0x0054B5E2
		public byte[] GetBlueprintPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700ABB7 RID: 43959
		// (get) Token: 0x06026BC9 RID: 158665 RVA: 0x0054D3F0 File Offset: 0x0054B5F0
		public TNpcModelType NpcModelType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TNpcModelType.NONE;
				}
				return (TNpcModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026BCA RID: 158666 RVA: 0x0054D42C File Offset: 0x0054B62C
		public TTable? NpcModel<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026BCB RID: 158667 RVA: 0x0054D474 File Offset: 0x0054B674
		public ICombineDaNpcModel NpcModelAsICombineDaNpcModel()
		{
			return this.NpcModel<ICombineDaNpcModel>().Value;
		}

		// Token: 0x06026BCC RID: 158668 RVA: 0x0054D490 File Offset: 0x0054B690
		public IDaNpcModel NpcModelAsIDaNpcModel()
		{
			return this.NpcModel<IDaNpcModel>().Value;
		}

		// Token: 0x06026BCD RID: 158669 RVA: 0x0054D4AC File Offset: 0x0054B6AC
		public IMeshNpcModel NpcModelAsIMeshNpcModel()
		{
			return this.NpcModel<IMeshNpcModel>().Value;
		}

		// Token: 0x1700ABB8 RID: 43960
		// (get) Token: 0x06026BCE RID: 158670 RVA: 0x0054D4C8 File Offset: 0x0054B6C8
		public string Abp
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026BCF RID: 158671 RVA: 0x0054D500 File Offset: 0x0054B700
		public Span<byte> GetAbpBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06026BD0 RID: 158672 RVA: 0x0054D510 File Offset: 0x0054B710
		public byte[] GetAbpArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06026BD1 RID: 158673 RVA: 0x0054D520 File Offset: 0x0054B720
		public string BattleSockets(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700ABB9 RID: 43961
		// (get) Token: 0x06026BD2 RID: 158674 RVA: 0x0054D55C File Offset: 0x0054B75C
		public int BattleSocketsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06026BD3 RID: 158675 RVA: 0x0054D588 File Offset: 0x0054B788
		public string NormalSockets(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700ABBA RID: 43962
		// (get) Token: 0x06026BD4 RID: 158676 RVA: 0x0054D5C4 File Offset: 0x0054B7C4
		public int NormalSocketsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700ABBB RID: 43963
		// (get) Token: 0x06026BD5 RID: 158677 RVA: 0x0054D5F0 File Offset: 0x0054B7F0
		public float LookingUpAngle
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ABBC RID: 43964
		// (get) Token: 0x06026BD6 RID: 158678 RVA: 0x0054D634 File Offset: 0x0054B834
		public EBodyType BodyType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return EBodyType.None;
				}
				return (EBodyType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ABBD RID: 43965
		// (get) Token: 0x06026BD7 RID: 158679 RVA: 0x0054D674 File Offset: 0x0054B874
		public float NameZaxisOffset
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ABBE RID: 43966
		// (get) Token: 0x06026BD8 RID: 158680 RVA: 0x0054D6B8 File Offset: 0x0054B8B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026BD9 RID: 158681 RVA: 0x0054D6F8 File Offset: 0x0054B8F8
		public static Offset<INpcModel> CreateINpcModel(FlatBufferBuilder builder, EModelType Type = EModelType.LevelPrefab, StringOffset BlueprintPathOffset = default(StringOffset), TNpcModelType NpcModel_type = TNpcModelType.NONE, int NpcModelOffset = 0, StringOffset AbpOffset = default(StringOffset), VectorOffset BattleSocketsOffset = default(VectorOffset), VectorOffset NormalSocketsOffset = default(VectorOffset), float LookingUpAngle = 0f, EBodyType BodyType = EBodyType.None, float NameZaxisOffset = 0f, byte NullMask = 0)
		{
			builder.StartTable(11);
			INpcModel.AddNameZaxisOffset(builder, NameZaxisOffset);
			INpcModel.AddLookingUpAngle(builder, LookingUpAngle);
			INpcModel.AddNormalSockets(builder, NormalSocketsOffset);
			INpcModel.AddBattleSockets(builder, BattleSocketsOffset);
			INpcModel.AddAbp(builder, AbpOffset);
			INpcModel.AddNpcModel(builder, NpcModelOffset);
			INpcModel.AddBlueprintPath(builder, BlueprintPathOffset);
			INpcModel.AddNullMask(builder, NullMask);
			INpcModel.AddBodyType(builder, BodyType);
			INpcModel.AddNpcModelType(builder, NpcModel_type);
			INpcModel.AddType(builder, Type);
			return INpcModel.EndINpcModel(builder);
		}

		// Token: 0x06026BDA RID: 158682 RVA: 0x0054D768 File Offset: 0x0054B968
		public static void StartINpcModel(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06026BDB RID: 158683 RVA: 0x0054D772 File Offset: 0x0054B972
		public static void AddType(FlatBufferBuilder builder, EModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026BDC RID: 158684 RVA: 0x0054D77D File Offset: 0x0054B97D
		public static void AddBlueprintPath(FlatBufferBuilder builder, StringOffset blueprintPathOffset)
		{
			builder.AddOffset(1, blueprintPathOffset.Value, 0);
		}

		// Token: 0x06026BDD RID: 158685 RVA: 0x0054D78D File Offset: 0x0054B98D
		public static void AddNpcModelType(FlatBufferBuilder builder, TNpcModelType npcModelType)
		{
			builder.AddByte(2, (byte)npcModelType, 0);
		}

		// Token: 0x06026BDE RID: 158686 RVA: 0x0054D798 File Offset: 0x0054B998
		public static void AddNpcModel(FlatBufferBuilder builder, int npcModelOffset)
		{
			builder.AddOffset(3, npcModelOffset, 0);
		}

		// Token: 0x06026BDF RID: 158687 RVA: 0x0054D7A3 File Offset: 0x0054B9A3
		public static void AddAbp(FlatBufferBuilder builder, StringOffset abpOffset)
		{
			builder.AddOffset(4, abpOffset.Value, 0);
		}

		// Token: 0x06026BE0 RID: 158688 RVA: 0x0054D7B3 File Offset: 0x0054B9B3
		public static void AddBattleSockets(FlatBufferBuilder builder, VectorOffset battleSocketsOffset)
		{
			builder.AddOffset(5, battleSocketsOffset.Value, 0);
		}

		// Token: 0x06026BE1 RID: 158689 RVA: 0x0054D7C4 File Offset: 0x0054B9C4
		public static VectorOffset CreateBattleSocketsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026BE2 RID: 158690 RVA: 0x0054D804 File Offset: 0x0054BA04
		public static VectorOffset CreateBattleSocketsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06026BE3 RID: 158691 RVA: 0x0054D81E File Offset: 0x0054BA1E
		public static VectorOffset CreateBattleSocketsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06026BE4 RID: 158692 RVA: 0x0054D83C File Offset: 0x0054BA3C
		public static VectorOffset CreateBattleSocketsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026BE5 RID: 158693 RVA: 0x0054D855 File Offset: 0x0054BA55
		public static void StartBattleSocketsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026BE6 RID: 158694 RVA: 0x0054D860 File Offset: 0x0054BA60
		public static void AddNormalSockets(FlatBufferBuilder builder, VectorOffset normalSocketsOffset)
		{
			builder.AddOffset(6, normalSocketsOffset.Value, 0);
		}

		// Token: 0x06026BE7 RID: 158695 RVA: 0x0054D870 File Offset: 0x0054BA70
		public static VectorOffset CreateNormalSocketsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026BE8 RID: 158696 RVA: 0x0054D8B0 File Offset: 0x0054BAB0
		public static VectorOffset CreateNormalSocketsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06026BE9 RID: 158697 RVA: 0x0054D8CA File Offset: 0x0054BACA
		public static VectorOffset CreateNormalSocketsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06026BEA RID: 158698 RVA: 0x0054D8E8 File Offset: 0x0054BAE8
		public static VectorOffset CreateNormalSocketsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026BEB RID: 158699 RVA: 0x0054D901 File Offset: 0x0054BB01
		public static void StartNormalSocketsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026BEC RID: 158700 RVA: 0x0054D90C File Offset: 0x0054BB0C
		public static void AddLookingUpAngle(FlatBufferBuilder builder, float lookingUpAngle)
		{
			builder.AddFloat(7, lookingUpAngle, 0.0);
		}

		// Token: 0x06026BED RID: 158701 RVA: 0x0054D91F File Offset: 0x0054BB1F
		public static void AddBodyType(FlatBufferBuilder builder, EBodyType bodyType)
		{
			builder.AddByte(8, (byte)bodyType, 0);
		}

		// Token: 0x06026BEE RID: 158702 RVA: 0x0054D92A File Offset: 0x0054BB2A
		public static void AddNameZaxisOffset(FlatBufferBuilder builder, float nameZaxisOffset)
		{
			builder.AddFloat(9, nameZaxisOffset, 0.0);
		}

		// Token: 0x06026BEF RID: 158703 RVA: 0x0054D93E File Offset: 0x0054BB3E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06026BF0 RID: 158704 RVA: 0x0054D94A File Offset: 0x0054BB4A
		public static Offset<INpcModel> EndINpcModel(FlatBufferBuilder builder)
		{
			return new Offset<INpcModel>(builder.EndTable());
		}

		// Token: 0x06026BF1 RID: 158705 RVA: 0x0054D958 File Offset: 0x0054BB58
		public INpcModelT UnPack()
		{
			INpcModelT npcModelT = new INpcModelT();
			this.UnPackTo(npcModelT);
			return npcModelT;
		}

		// Token: 0x06026BF2 RID: 158706 RVA: 0x0054D974 File Offset: 0x0054BB74
		public void UnPackTo(INpcModelT _o)
		{
			_o.Type = this.Type;
			_o.BlueprintPath = this.BlueprintPath;
			_o.NpcModel = new TNpcModelTypeUnion();
			_o.NpcModel.Type = this.NpcModelType;
			switch (this.NpcModelType)
			{
			case TNpcModelType.ICombineDaNpcModel:
				_o.NpcModel.Value = ((this.NpcModel<ICombineDaNpcModel>() != null) ? this.NpcModel<ICombineDaNpcModel>().Value.UnPack() : null);
				break;
			case TNpcModelType.IDaNpcModel:
				_o.NpcModel.Value = ((this.NpcModel<IDaNpcModel>() != null) ? this.NpcModel<IDaNpcModel>().Value.UnPack() : null);
				break;
			case TNpcModelType.IMeshNpcModel:
				_o.NpcModel.Value = ((this.NpcModel<IMeshNpcModel>() != null) ? this.NpcModel<IMeshNpcModel>().Value.UnPack() : null);
				break;
			}
			_o.Abp = this.Abp;
			_o.BattleSockets = new List<string>();
			for (int i = 0; i < this.BattleSocketsLength; i++)
			{
				_o.BattleSockets.Add(this.BattleSockets(i));
			}
			_o.NormalSockets = new List<string>();
			for (int j = 0; j < this.NormalSocketsLength; j++)
			{
				_o.NormalSockets.Add(this.NormalSockets(j));
			}
			_o.LookingUpAngle = this.LookingUpAngle;
			_o.BodyType = this.BodyType;
			_o.NameZaxisOffset = this.NameZaxisOffset;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026BF3 RID: 158707 RVA: 0x0054DB1C File Offset: 0x0054BD1C
		public static Offset<INpcModel> Pack(FlatBufferBuilder builder, INpcModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcModel>);
			}
			StringOffset blueprintPathOffset = (_o.BlueprintPath == null) ? default(StringOffset) : builder.CreateString(_o.BlueprintPath);
			TNpcModelType npcModel_type = (_o.NpcModel == null) ? TNpcModelType.NONE : _o.NpcModel.Type;
			int npcModelOffset = (_o.NpcModel == null) ? 0 : TNpcModelTypeUnion.Pack(builder, _o.NpcModel);
			StringOffset abpOffset = (_o.Abp == null) ? default(StringOffset) : builder.CreateString(_o.Abp);
			VectorOffset battleSocketsOffset = default(VectorOffset);
			if (_o.BattleSockets != null)
			{
				StringOffset[] array = new StringOffset[_o.BattleSockets.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.BattleSockets[i]);
				}
				battleSocketsOffset = INpcModel.CreateBattleSocketsVector(builder, array);
			}
			VectorOffset normalSocketsOffset = default(VectorOffset);
			if (_o.NormalSockets != null)
			{
				StringOffset[] array2 = new StringOffset[_o.NormalSockets.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.NormalSockets[j]);
				}
				normalSocketsOffset = INpcModel.CreateNormalSocketsVector(builder, array2);
			}
			return INpcModel.CreateINpcModel(builder, _o.Type, blueprintPathOffset, npcModel_type, npcModelOffset, abpOffset, battleSocketsOffset, normalSocketsOffset, _o.LookingUpAngle, _o.BodyType, _o.NameZaxisOffset, _o.NullMask);
		}

		// Token: 0x0400F60D RID: 62989
		private Table __p;
	}
}

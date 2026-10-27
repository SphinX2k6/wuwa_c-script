using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005626 RID: 22054
	public struct INpcModel : IFlatbufferObject
	{
		// Token: 0x1700A32C RID: 41772
		// (get) Token: 0x060249AF RID: 149935 RVA: 0x0050CCDB File Offset: 0x0050AEDB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060249B0 RID: 149936 RVA: 0x0050CCE8 File Offset: 0x0050AEE8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060249B1 RID: 149937 RVA: 0x0050CCF0 File Offset: 0x0050AEF0
		public static INpcModel GetRootAsINpcModel(ByteBuffer _bb)
		{
			return INpcModel.GetRootAsINpcModel(_bb, default(INpcModel));
		}

		// Token: 0x060249B2 RID: 149938 RVA: 0x0050CD0C File Offset: 0x0050AF0C
		public static INpcModel GetRootAsINpcModel(ByteBuffer _bb, INpcModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060249B3 RID: 149939 RVA: 0x0050CD29 File Offset: 0x0050AF29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060249B4 RID: 149940 RVA: 0x0050CD38 File Offset: 0x0050AF38
		public INpcModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A32D RID: 41773
		// (get) Token: 0x060249B5 RID: 149941 RVA: 0x0050CD48 File Offset: 0x0050AF48
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

		// Token: 0x1700A32E RID: 41774
		// (get) Token: 0x060249B6 RID: 149942 RVA: 0x0050CD84 File Offset: 0x0050AF84
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

		// Token: 0x060249B7 RID: 149943 RVA: 0x0050CDBB File Offset: 0x0050AFBB
		public Span<byte> GetBlueprintPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060249B8 RID: 149944 RVA: 0x0050CDCA File Offset: 0x0050AFCA
		public byte[] GetBlueprintPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A32F RID: 41775
		// (get) Token: 0x060249B9 RID: 149945 RVA: 0x0050CDD8 File Offset: 0x0050AFD8
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

		// Token: 0x060249BA RID: 149946 RVA: 0x0050CE14 File Offset: 0x0050B014
		public TTable? NpcModel<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060249BB RID: 149947 RVA: 0x0050CE5C File Offset: 0x0050B05C
		public IDaNpcModel NpcModelAsIDaNpcModel()
		{
			return this.NpcModel<IDaNpcModel>().Value;
		}

		// Token: 0x060249BC RID: 149948 RVA: 0x0050CE78 File Offset: 0x0050B078
		public IMeshNpcModel NpcModelAsIMeshNpcModel()
		{
			return this.NpcModel<IMeshNpcModel>().Value;
		}

		// Token: 0x1700A330 RID: 41776
		// (get) Token: 0x060249BD RID: 149949 RVA: 0x0050CE94 File Offset: 0x0050B094
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

		// Token: 0x060249BE RID: 149950 RVA: 0x0050CECC File Offset: 0x0050B0CC
		public Span<byte> GetAbpBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060249BF RID: 149951 RVA: 0x0050CEDC File Offset: 0x0050B0DC
		public byte[] GetAbpArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x060249C0 RID: 149952 RVA: 0x0050CEEC File Offset: 0x0050B0EC
		public string BattleSockets(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A331 RID: 41777
		// (get) Token: 0x060249C1 RID: 149953 RVA: 0x0050CF28 File Offset: 0x0050B128
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

		// Token: 0x060249C2 RID: 149954 RVA: 0x0050CF54 File Offset: 0x0050B154
		public string NormalSockets(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A332 RID: 41778
		// (get) Token: 0x060249C3 RID: 149955 RVA: 0x0050CF90 File Offset: 0x0050B190
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

		// Token: 0x1700A333 RID: 41779
		// (get) Token: 0x060249C4 RID: 149956 RVA: 0x0050CFBC File Offset: 0x0050B1BC
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

		// Token: 0x1700A334 RID: 41780
		// (get) Token: 0x060249C5 RID: 149957 RVA: 0x0050D000 File Offset: 0x0050B200
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

		// Token: 0x1700A335 RID: 41781
		// (get) Token: 0x060249C6 RID: 149958 RVA: 0x0050D040 File Offset: 0x0050B240
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

		// Token: 0x1700A336 RID: 41782
		// (get) Token: 0x060249C7 RID: 149959 RVA: 0x0050D084 File Offset: 0x0050B284
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

		// Token: 0x060249C8 RID: 149960 RVA: 0x0050D0C4 File Offset: 0x0050B2C4
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

		// Token: 0x060249C9 RID: 149961 RVA: 0x0050D134 File Offset: 0x0050B334
		public static void StartINpcModel(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x060249CA RID: 149962 RVA: 0x0050D13E File Offset: 0x0050B33E
		public static void AddType(FlatBufferBuilder builder, EModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060249CB RID: 149963 RVA: 0x0050D149 File Offset: 0x0050B349
		public static void AddBlueprintPath(FlatBufferBuilder builder, StringOffset blueprintPathOffset)
		{
			builder.AddOffset(1, blueprintPathOffset.Value, 0);
		}

		// Token: 0x060249CC RID: 149964 RVA: 0x0050D159 File Offset: 0x0050B359
		public static void AddNpcModelType(FlatBufferBuilder builder, TNpcModelType npcModelType)
		{
			builder.AddByte(2, (byte)npcModelType, 0);
		}

		// Token: 0x060249CD RID: 149965 RVA: 0x0050D164 File Offset: 0x0050B364
		public static void AddNpcModel(FlatBufferBuilder builder, int npcModelOffset)
		{
			builder.AddOffset(3, npcModelOffset, 0);
		}

		// Token: 0x060249CE RID: 149966 RVA: 0x0050D16F File Offset: 0x0050B36F
		public static void AddAbp(FlatBufferBuilder builder, StringOffset abpOffset)
		{
			builder.AddOffset(4, abpOffset.Value, 0);
		}

		// Token: 0x060249CF RID: 149967 RVA: 0x0050D17F File Offset: 0x0050B37F
		public static void AddBattleSockets(FlatBufferBuilder builder, VectorOffset battleSocketsOffset)
		{
			builder.AddOffset(5, battleSocketsOffset.Value, 0);
		}

		// Token: 0x060249D0 RID: 149968 RVA: 0x0050D190 File Offset: 0x0050B390
		public static VectorOffset CreateBattleSocketsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060249D1 RID: 149969 RVA: 0x0050D1D0 File Offset: 0x0050B3D0
		public static VectorOffset CreateBattleSocketsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060249D2 RID: 149970 RVA: 0x0050D1EA File Offset: 0x0050B3EA
		public static VectorOffset CreateBattleSocketsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060249D3 RID: 149971 RVA: 0x0050D208 File Offset: 0x0050B408
		public static VectorOffset CreateBattleSocketsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060249D4 RID: 149972 RVA: 0x0050D221 File Offset: 0x0050B421
		public static void StartBattleSocketsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060249D5 RID: 149973 RVA: 0x0050D22C File Offset: 0x0050B42C
		public static void AddNormalSockets(FlatBufferBuilder builder, VectorOffset normalSocketsOffset)
		{
			builder.AddOffset(6, normalSocketsOffset.Value, 0);
		}

		// Token: 0x060249D6 RID: 149974 RVA: 0x0050D23C File Offset: 0x0050B43C
		public static VectorOffset CreateNormalSocketsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060249D7 RID: 149975 RVA: 0x0050D27C File Offset: 0x0050B47C
		public static VectorOffset CreateNormalSocketsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060249D8 RID: 149976 RVA: 0x0050D296 File Offset: 0x0050B496
		public static VectorOffset CreateNormalSocketsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060249D9 RID: 149977 RVA: 0x0050D2B4 File Offset: 0x0050B4B4
		public static VectorOffset CreateNormalSocketsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060249DA RID: 149978 RVA: 0x0050D2CD File Offset: 0x0050B4CD
		public static void StartNormalSocketsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060249DB RID: 149979 RVA: 0x0050D2D8 File Offset: 0x0050B4D8
		public static void AddLookingUpAngle(FlatBufferBuilder builder, float lookingUpAngle)
		{
			builder.AddFloat(7, lookingUpAngle, 0.0);
		}

		// Token: 0x060249DC RID: 149980 RVA: 0x0050D2EB File Offset: 0x0050B4EB
		public static void AddBodyType(FlatBufferBuilder builder, EBodyType bodyType)
		{
			builder.AddByte(8, (byte)bodyType, 0);
		}

		// Token: 0x060249DD RID: 149981 RVA: 0x0050D2F6 File Offset: 0x0050B4F6
		public static void AddNameZaxisOffset(FlatBufferBuilder builder, float nameZaxisOffset)
		{
			builder.AddFloat(9, nameZaxisOffset, 0.0);
		}

		// Token: 0x060249DE RID: 149982 RVA: 0x0050D30A File Offset: 0x0050B50A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x060249DF RID: 149983 RVA: 0x0050D316 File Offset: 0x0050B516
		public static Offset<INpcModel> EndINpcModel(FlatBufferBuilder builder)
		{
			return new Offset<INpcModel>(builder.EndTable());
		}

		// Token: 0x060249E0 RID: 149984 RVA: 0x0050D324 File Offset: 0x0050B524
		public INpcModelT UnPack()
		{
			INpcModelT npcModelT = new INpcModelT();
			this.UnPackTo(npcModelT);
			return npcModelT;
		}

		// Token: 0x060249E1 RID: 149985 RVA: 0x0050D340 File Offset: 0x0050B540
		public void UnPackTo(INpcModelT _o)
		{
			_o.Type = this.Type;
			_o.BlueprintPath = this.BlueprintPath;
			_o.NpcModel = new TNpcModelTypeUnion();
			_o.NpcModel.Type = this.NpcModelType;
			TNpcModelType npcModelType = this.NpcModelType;
			if (npcModelType != TNpcModelType.IDaNpcModel)
			{
				if (npcModelType == TNpcModelType.IMeshNpcModel)
				{
					_o.NpcModel.Value = ((this.NpcModel<IMeshNpcModel>() != null) ? this.NpcModel<IMeshNpcModel>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.NpcModel.Value = ((this.NpcModel<IDaNpcModel>() != null) ? this.NpcModel<IDaNpcModel>().Value.UnPack() : null);
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

		// Token: 0x060249E2 RID: 149986 RVA: 0x0050D4A0 File Offset: 0x0050B6A0
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

		// Token: 0x0400E9AA RID: 59818
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A0 RID: 29600
	public struct ITeleportTransitionInSeamlessType : IFlatbufferObject
	{
		// Token: 0x1700E0A4 RID: 57508
		// (get) Token: 0x06035B83 RID: 220035 RVA: 0x00750036 File Offset: 0x0074E236
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B84 RID: 220036 RVA: 0x00750043 File Offset: 0x0074E243
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B85 RID: 220037 RVA: 0x0075004C File Offset: 0x0074E24C
		public static ITeleportTransitionInSeamlessType GetRootAsITeleportTransitionInSeamlessType(ByteBuffer _bb)
		{
			return ITeleportTransitionInSeamlessType.GetRootAsITeleportTransitionInSeamlessType(_bb, default(ITeleportTransitionInSeamlessType));
		}

		// Token: 0x06035B86 RID: 220038 RVA: 0x00750068 File Offset: 0x0074E268
		public static ITeleportTransitionInSeamlessType GetRootAsITeleportTransitionInSeamlessType(ByteBuffer _bb, ITeleportTransitionInSeamlessType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B87 RID: 220039 RVA: 0x00750085 File Offset: 0x0074E285
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B88 RID: 220040 RVA: 0x00750094 File Offset: 0x0074E294
		public ITeleportTransitionInSeamlessType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0A5 RID: 57509
		// (get) Token: 0x06035B89 RID: 220041 RVA: 0x007500A4 File Offset: 0x0074E2A4
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E0A6 RID: 57510
		// (get) Token: 0x06035B8A RID: 220042 RVA: 0x007500E0 File Offset: 0x0074E2E0
		public string EffectDaPath
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

		// Token: 0x06035B8B RID: 220043 RVA: 0x00750117 File Offset: 0x0074E317
		public Span<byte> GetEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06035B8C RID: 220044 RVA: 0x00750126 File Offset: 0x0074E326
		public byte[] GetEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E0A7 RID: 57511
		// (get) Token: 0x06035B8D RID: 220045 RVA: 0x00750134 File Offset: 0x0074E334
		public float LeastTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E0A8 RID: 57512
		// (get) Token: 0x06035B8E RID: 220046 RVA: 0x00750174 File Offset: 0x0074E374
		public float EffectExpandTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E0A9 RID: 57513
		// (get) Token: 0x06035B8F RID: 220047 RVA: 0x007501B8 File Offset: 0x0074E3B8
		public float EffectCollapseTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E0AA RID: 57514
		// (get) Token: 0x06035B90 RID: 220048 RVA: 0x007501FC File Offset: 0x0074E3FC
		public string SceneEffectDaPath
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035B91 RID: 220049 RVA: 0x00750234 File Offset: 0x0074E434
		public Span<byte> GetSceneEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06035B92 RID: 220050 RVA: 0x00750244 File Offset: 0x0074E444
		public byte[] GetSceneEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700E0AB RID: 57515
		// (get) Token: 0x06035B93 RID: 220051 RVA: 0x00750254 File Offset: 0x0074E454
		public string TransitionWeatherDaPath
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035B94 RID: 220052 RVA: 0x0075028C File Offset: 0x0074E48C
		public Span<byte> GetTransitionWeatherDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06035B95 RID: 220053 RVA: 0x0075029C File Offset: 0x0074E49C
		public byte[] GetTransitionWeatherDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700E0AC RID: 57516
		// (get) Token: 0x06035B96 RID: 220054 RVA: 0x007502AC File Offset: 0x0074E4AC
		public IFloorSettings? FloorSettings
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IFloorSettings?(default(IFloorSettings).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E0AD RID: 57517
		// (get) Token: 0x06035B97 RID: 220055 RVA: 0x0075030C File Offset: 0x0074E50C
		public bool IsTeleportInPlace
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06035B98 RID: 220056 RVA: 0x0075034C File Offset: 0x0074E54C
		public EKeepMovementState KeepMovementStates(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return EKeepMovementState.Kite;
			}
			return (EKeepMovementState)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700E0AE RID: 57518
		// (get) Token: 0x06035B99 RID: 220057 RVA: 0x0075038C File Offset: 0x0074E58C
		public int KeepMovementStatesLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06035B9A RID: 220058 RVA: 0x007503B8 File Offset: 0x0074E5B8
		public Span<EKeepMovementState> GetKeepMovementStatesBytes()
		{
			return this.__p.__vector_as_span<EKeepMovementState>(22, 1);
		}

		// Token: 0x06035B9B RID: 220059 RVA: 0x007503C8 File Offset: 0x0074E5C8
		public EKeepMovementState[] GetKeepMovementStatesArray()
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EKeepMovementState[] array = new EKeepMovementState[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EKeepMovementState)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x1700E0AF RID: 57519
		// (get) Token: 0x06035B9C RID: 220060 RVA: 0x00750434 File Offset: 0x0074E634
		public ISeamlessTeleportFinishConfig? SeamlessTeleportFinishConfig
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new ISeamlessTeleportFinishConfig?(default(ISeamlessTeleportFinishConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E0B0 RID: 57520
		// (get) Token: 0x06035B9D RID: 220061 RVA: 0x00750494 File Offset: 0x0074E694
		public bool IsNormalStreamingLoad
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E0B1 RID: 57521
		// (get) Token: 0x06035B9E RID: 220062 RVA: 0x007504D4 File Offset: 0x0074E6D4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035B9F RID: 220063 RVA: 0x00750514 File Offset: 0x0074E714
		public static Offset<ITeleportTransitionInSeamlessType> CreateITeleportTransitionInSeamlessType(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, StringOffset EffectDaPathOffset = default(StringOffset), float LeastTime = 0f, float EffectExpandTime = 0f, float EffectCollapseTime = 0f, StringOffset SceneEffectDaPathOffset = default(StringOffset), StringOffset TransitionWeatherDaPathOffset = default(StringOffset), Offset<IFloorSettings> FloorSettingsOffset = default(Offset<IFloorSettings>), bool IsTeleportInPlace = false, VectorOffset KeepMovementStatesOffset = default(VectorOffset), Offset<ISeamlessTeleportFinishConfig> SeamlessTeleportFinishConfigOffset = default(Offset<ISeamlessTeleportFinishConfig>), bool IsNormalStreamingLoad = false, byte NullMask = 0)
		{
			builder.StartTable(13);
			ITeleportTransitionInSeamlessType.AddSeamlessTeleportFinishConfig(builder, SeamlessTeleportFinishConfigOffset);
			ITeleportTransitionInSeamlessType.AddKeepMovementStates(builder, KeepMovementStatesOffset);
			ITeleportTransitionInSeamlessType.AddFloorSettings(builder, FloorSettingsOffset);
			ITeleportTransitionInSeamlessType.AddTransitionWeatherDaPath(builder, TransitionWeatherDaPathOffset);
			ITeleportTransitionInSeamlessType.AddSceneEffectDaPath(builder, SceneEffectDaPathOffset);
			ITeleportTransitionInSeamlessType.AddEffectCollapseTime(builder, EffectCollapseTime);
			ITeleportTransitionInSeamlessType.AddEffectExpandTime(builder, EffectExpandTime);
			ITeleportTransitionInSeamlessType.AddLeastTime(builder, LeastTime);
			ITeleportTransitionInSeamlessType.AddEffectDaPath(builder, EffectDaPathOffset);
			ITeleportTransitionInSeamlessType.AddNullMask(builder, NullMask);
			ITeleportTransitionInSeamlessType.AddIsNormalStreamingLoad(builder, IsNormalStreamingLoad);
			ITeleportTransitionInSeamlessType.AddIsTeleportInPlace(builder, IsTeleportInPlace);
			ITeleportTransitionInSeamlessType.AddType(builder, Type);
			return ITeleportTransitionInSeamlessType.EndITeleportTransitionInSeamlessType(builder);
		}

		// Token: 0x06035BA0 RID: 220064 RVA: 0x00750594 File Offset: 0x0074E794
		public static void StartITeleportTransitionInSeamlessType(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06035BA1 RID: 220065 RVA: 0x0075059E File Offset: 0x0074E79E
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035BA2 RID: 220066 RVA: 0x007505A9 File Offset: 0x0074E7A9
		public static void AddEffectDaPath(FlatBufferBuilder builder, StringOffset effectDaPathOffset)
		{
			builder.AddOffset(1, effectDaPathOffset.Value, 0);
		}

		// Token: 0x06035BA3 RID: 220067 RVA: 0x007505B9 File Offset: 0x0074E7B9
		public static void AddLeastTime(FlatBufferBuilder builder, float leastTime)
		{
			builder.AddFloat(2, leastTime, 0.0);
		}

		// Token: 0x06035BA4 RID: 220068 RVA: 0x007505CC File Offset: 0x0074E7CC
		public static void AddEffectExpandTime(FlatBufferBuilder builder, float effectExpandTime)
		{
			builder.AddFloat(3, effectExpandTime, 0.0);
		}

		// Token: 0x06035BA5 RID: 220069 RVA: 0x007505DF File Offset: 0x0074E7DF
		public static void AddEffectCollapseTime(FlatBufferBuilder builder, float effectCollapseTime)
		{
			builder.AddFloat(4, effectCollapseTime, 0.0);
		}

		// Token: 0x06035BA6 RID: 220070 RVA: 0x007505F2 File Offset: 0x0074E7F2
		public static void AddSceneEffectDaPath(FlatBufferBuilder builder, StringOffset sceneEffectDaPathOffset)
		{
			builder.AddOffset(5, sceneEffectDaPathOffset.Value, 0);
		}

		// Token: 0x06035BA7 RID: 220071 RVA: 0x00750602 File Offset: 0x0074E802
		public static void AddTransitionWeatherDaPath(FlatBufferBuilder builder, StringOffset transitionWeatherDaPathOffset)
		{
			builder.AddOffset(6, transitionWeatherDaPathOffset.Value, 0);
		}

		// Token: 0x06035BA8 RID: 220072 RVA: 0x00750612 File Offset: 0x0074E812
		public static void AddFloorSettings(FlatBufferBuilder builder, Offset<IFloorSettings> floorSettingsOffset)
		{
			builder.AddOffset(7, floorSettingsOffset.Value, 0);
		}

		// Token: 0x06035BA9 RID: 220073 RVA: 0x00750622 File Offset: 0x0074E822
		public static void AddIsTeleportInPlace(FlatBufferBuilder builder, bool isTeleportInPlace)
		{
			builder.AddBool(8, isTeleportInPlace, false);
		}

		// Token: 0x06035BAA RID: 220074 RVA: 0x0075062D File Offset: 0x0074E82D
		public static void AddKeepMovementStates(FlatBufferBuilder builder, VectorOffset keepMovementStatesOffset)
		{
			builder.AddOffset(9, keepMovementStatesOffset.Value, 0);
		}

		// Token: 0x06035BAB RID: 220075 RVA: 0x00750640 File Offset: 0x0074E840
		public static VectorOffset CreateKeepMovementStatesVector(FlatBufferBuilder builder, EKeepMovementState[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035BAC RID: 220076 RVA: 0x00750677 File Offset: 0x0074E877
		public static VectorOffset CreateKeepMovementStatesVectorBlock(FlatBufferBuilder builder, EKeepMovementState[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EKeepMovementState>(data);
			return builder.EndVector();
		}

		// Token: 0x06035BAD RID: 220077 RVA: 0x00750691 File Offset: 0x0074E891
		public static VectorOffset CreateKeepMovementStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<EKeepMovementState> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EKeepMovementState>(data);
			return builder.EndVector();
		}

		// Token: 0x06035BAE RID: 220078 RVA: 0x007506AF File Offset: 0x0074E8AF
		public static VectorOffset CreateKeepMovementStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EKeepMovementState>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035BAF RID: 220079 RVA: 0x007506C8 File Offset: 0x0074E8C8
		public static void StartKeepMovementStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06035BB0 RID: 220080 RVA: 0x007506D3 File Offset: 0x0074E8D3
		public static void AddSeamlessTeleportFinishConfig(FlatBufferBuilder builder, Offset<ISeamlessTeleportFinishConfig> seamlessTeleportFinishConfigOffset)
		{
			builder.AddOffset(10, seamlessTeleportFinishConfigOffset.Value, 0);
		}

		// Token: 0x06035BB1 RID: 220081 RVA: 0x007506E4 File Offset: 0x0074E8E4
		public static void AddIsNormalStreamingLoad(FlatBufferBuilder builder, bool isNormalStreamingLoad)
		{
			builder.AddBool(11, isNormalStreamingLoad, false);
		}

		// Token: 0x06035BB2 RID: 220082 RVA: 0x007506F0 File Offset: 0x0074E8F0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06035BB3 RID: 220083 RVA: 0x007506FC File Offset: 0x0074E8FC
		public static Offset<ITeleportTransitionInSeamlessType> EndITeleportTransitionInSeamlessType(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionInSeamlessType>(builder.EndTable());
		}

		// Token: 0x06035BB4 RID: 220084 RVA: 0x0075070C File Offset: 0x0074E90C
		public ITeleportTransitionInSeamlessTypeT UnPack()
		{
			ITeleportTransitionInSeamlessTypeT teleportTransitionInSeamlessTypeT = new ITeleportTransitionInSeamlessTypeT();
			this.UnPackTo(teleportTransitionInSeamlessTypeT);
			return teleportTransitionInSeamlessTypeT;
		}

		// Token: 0x06035BB5 RID: 220085 RVA: 0x00750728 File Offset: 0x0074E928
		public void UnPackTo(ITeleportTransitionInSeamlessTypeT _o)
		{
			_o.Type = this.Type;
			_o.EffectDaPath = this.EffectDaPath;
			_o.LeastTime = this.LeastTime;
			_o.EffectExpandTime = this.EffectExpandTime;
			_o.EffectCollapseTime = this.EffectCollapseTime;
			_o.SceneEffectDaPath = this.SceneEffectDaPath;
			_o.TransitionWeatherDaPath = this.TransitionWeatherDaPath;
			_o.FloorSettings = ((this.FloorSettings != null) ? this.FloorSettings.Value.UnPack() : null);
			_o.IsTeleportInPlace = this.IsTeleportInPlace;
			_o.KeepMovementStates = new List<EKeepMovementState>();
			for (int i = 0; i < this.KeepMovementStatesLength; i++)
			{
				_o.KeepMovementStates.Add(this.KeepMovementStates(i));
			}
			_o.SeamlessTeleportFinishConfig = ((this.SeamlessTeleportFinishConfig != null) ? this.SeamlessTeleportFinishConfig.Value.UnPack() : null);
			_o.IsNormalStreamingLoad = this.IsNormalStreamingLoad;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035BB6 RID: 220086 RVA: 0x0075083C File Offset: 0x0074EA3C
		public static Offset<ITeleportTransitionInSeamlessType> Pack(FlatBufferBuilder builder, ITeleportTransitionInSeamlessTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionInSeamlessType>);
			}
			StringOffset effectDaPathOffset = (_o.EffectDaPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectDaPath);
			StringOffset sceneEffectDaPathOffset = (_o.SceneEffectDaPath == null) ? default(StringOffset) : builder.CreateString(_o.SceneEffectDaPath);
			StringOffset transitionWeatherDaPathOffset = (_o.TransitionWeatherDaPath == null) ? default(StringOffset) : builder.CreateString(_o.TransitionWeatherDaPath);
			Offset<IFloorSettings> floorSettingsOffset = (_o.FloorSettings == null) ? default(Offset<IFloorSettings>) : IFloorSettings.Pack(builder, _o.FloorSettings);
			VectorOffset keepMovementStatesOffset = default(VectorOffset);
			if (_o.KeepMovementStates != null)
			{
				EKeepMovementState[] data = _o.KeepMovementStates.ToArray();
				keepMovementStatesOffset = ITeleportTransitionInSeamlessType.CreateKeepMovementStatesVector(builder, data);
			}
			Offset<ISeamlessTeleportFinishConfig> seamlessTeleportFinishConfigOffset = (_o.SeamlessTeleportFinishConfig == null) ? default(Offset<ISeamlessTeleportFinishConfig>) : ISeamlessTeleportFinishConfig.Pack(builder, _o.SeamlessTeleportFinishConfig);
			return ITeleportTransitionInSeamlessType.CreateITeleportTransitionInSeamlessType(builder, _o.Type, effectDaPathOffset, _o.LeastTime, _o.EffectExpandTime, _o.EffectCollapseTime, sceneEffectDaPathOffset, transitionWeatherDaPathOffset, floorSettingsOffset, _o.IsTeleportInPlace, keepMovementStatesOffset, seamlessTeleportFinishConfigOffset, _o.IsNormalStreamingLoad, _o.NullMask);
		}

		// Token: 0x040121BD RID: 74173
		private Table __p;
	}
}

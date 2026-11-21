using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B87 RID: 31623
	public struct ITeleportTransitionInSeamlessType : IFlatbufferObject
	{
		// Token: 0x1700ECB4 RID: 60596
		// (get) Token: 0x06038F1E RID: 233246 RVA: 0x007B2576 File Offset: 0x007B0776
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038F1F RID: 233247 RVA: 0x007B2583 File Offset: 0x007B0783
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038F20 RID: 233248 RVA: 0x007B258C File Offset: 0x007B078C
		public static ITeleportTransitionInSeamlessType GetRootAsITeleportTransitionInSeamlessType(ByteBuffer _bb)
		{
			return ITeleportTransitionInSeamlessType.GetRootAsITeleportTransitionInSeamlessType(_bb, default(ITeleportTransitionInSeamlessType));
		}

		// Token: 0x06038F21 RID: 233249 RVA: 0x007B25A8 File Offset: 0x007B07A8
		public static ITeleportTransitionInSeamlessType GetRootAsITeleportTransitionInSeamlessType(ByteBuffer _bb, ITeleportTransitionInSeamlessType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038F22 RID: 233250 RVA: 0x007B25C5 File Offset: 0x007B07C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038F23 RID: 233251 RVA: 0x007B25D4 File Offset: 0x007B07D4
		public ITeleportTransitionInSeamlessType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECB5 RID: 60597
		// (get) Token: 0x06038F24 RID: 233252 RVA: 0x007B25E4 File Offset: 0x007B07E4
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

		// Token: 0x1700ECB6 RID: 60598
		// (get) Token: 0x06038F25 RID: 233253 RVA: 0x007B2620 File Offset: 0x007B0820
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

		// Token: 0x06038F26 RID: 233254 RVA: 0x007B2657 File Offset: 0x007B0857
		public Span<byte> GetEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06038F27 RID: 233255 RVA: 0x007B2666 File Offset: 0x007B0866
		public byte[] GetEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700ECB7 RID: 60599
		// (get) Token: 0x06038F28 RID: 233256 RVA: 0x007B2674 File Offset: 0x007B0874
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

		// Token: 0x1700ECB8 RID: 60600
		// (get) Token: 0x06038F29 RID: 233257 RVA: 0x007B26B4 File Offset: 0x007B08B4
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

		// Token: 0x1700ECB9 RID: 60601
		// (get) Token: 0x06038F2A RID: 233258 RVA: 0x007B26F8 File Offset: 0x007B08F8
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

		// Token: 0x1700ECBA RID: 60602
		// (get) Token: 0x06038F2B RID: 233259 RVA: 0x007B273C File Offset: 0x007B093C
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

		// Token: 0x06038F2C RID: 233260 RVA: 0x007B2774 File Offset: 0x007B0974
		public Span<byte> GetSceneEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06038F2D RID: 233261 RVA: 0x007B2784 File Offset: 0x007B0984
		public byte[] GetSceneEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700ECBB RID: 60603
		// (get) Token: 0x06038F2E RID: 233262 RVA: 0x007B2794 File Offset: 0x007B0994
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

		// Token: 0x06038F2F RID: 233263 RVA: 0x007B27CC File Offset: 0x007B09CC
		public Span<byte> GetTransitionWeatherDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06038F30 RID: 233264 RVA: 0x007B27DC File Offset: 0x007B09DC
		public byte[] GetTransitionWeatherDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700ECBC RID: 60604
		// (get) Token: 0x06038F31 RID: 233265 RVA: 0x007B27EC File Offset: 0x007B09EC
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

		// Token: 0x1700ECBD RID: 60605
		// (get) Token: 0x06038F32 RID: 233266 RVA: 0x007B284C File Offset: 0x007B0A4C
		public bool IsTeleportInPlace
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06038F33 RID: 233267 RVA: 0x007B288C File Offset: 0x007B0A8C
		public EKeepMovementState KeepMovementStates(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return EKeepMovementState.Kite;
			}
			return (EKeepMovementState)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700ECBE RID: 60606
		// (get) Token: 0x06038F34 RID: 233268 RVA: 0x007B28CC File Offset: 0x007B0ACC
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

		// Token: 0x06038F35 RID: 233269 RVA: 0x007B28F8 File Offset: 0x007B0AF8
		public Span<EKeepMovementState> GetKeepMovementStatesBytes()
		{
			return this.__p.__vector_as_span<EKeepMovementState>(22, 1);
		}

		// Token: 0x06038F36 RID: 233270 RVA: 0x007B2908 File Offset: 0x007B0B08
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

		// Token: 0x1700ECBF RID: 60607
		// (get) Token: 0x06038F37 RID: 233271 RVA: 0x007B2974 File Offset: 0x007B0B74
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

		// Token: 0x1700ECC0 RID: 60608
		// (get) Token: 0x06038F38 RID: 233272 RVA: 0x007B29D4 File Offset: 0x007B0BD4
		public bool IsNormalStreamingLoad
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ECC1 RID: 60609
		// (get) Token: 0x06038F39 RID: 233273 RVA: 0x007B2A14 File Offset: 0x007B0C14
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

		// Token: 0x06038F3A RID: 233274 RVA: 0x007B2A54 File Offset: 0x007B0C54
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

		// Token: 0x06038F3B RID: 233275 RVA: 0x007B2AD4 File Offset: 0x007B0CD4
		public static void StartITeleportTransitionInSeamlessType(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06038F3C RID: 233276 RVA: 0x007B2ADE File Offset: 0x007B0CDE
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038F3D RID: 233277 RVA: 0x007B2AE9 File Offset: 0x007B0CE9
		public static void AddEffectDaPath(FlatBufferBuilder builder, StringOffset effectDaPathOffset)
		{
			builder.AddOffset(1, effectDaPathOffset.Value, 0);
		}

		// Token: 0x06038F3E RID: 233278 RVA: 0x007B2AF9 File Offset: 0x007B0CF9
		public static void AddLeastTime(FlatBufferBuilder builder, float leastTime)
		{
			builder.AddFloat(2, leastTime, 0.0);
		}

		// Token: 0x06038F3F RID: 233279 RVA: 0x007B2B0C File Offset: 0x007B0D0C
		public static void AddEffectExpandTime(FlatBufferBuilder builder, float effectExpandTime)
		{
			builder.AddFloat(3, effectExpandTime, 0.0);
		}

		// Token: 0x06038F40 RID: 233280 RVA: 0x007B2B1F File Offset: 0x007B0D1F
		public static void AddEffectCollapseTime(FlatBufferBuilder builder, float effectCollapseTime)
		{
			builder.AddFloat(4, effectCollapseTime, 0.0);
		}

		// Token: 0x06038F41 RID: 233281 RVA: 0x007B2B32 File Offset: 0x007B0D32
		public static void AddSceneEffectDaPath(FlatBufferBuilder builder, StringOffset sceneEffectDaPathOffset)
		{
			builder.AddOffset(5, sceneEffectDaPathOffset.Value, 0);
		}

		// Token: 0x06038F42 RID: 233282 RVA: 0x007B2B42 File Offset: 0x007B0D42
		public static void AddTransitionWeatherDaPath(FlatBufferBuilder builder, StringOffset transitionWeatherDaPathOffset)
		{
			builder.AddOffset(6, transitionWeatherDaPathOffset.Value, 0);
		}

		// Token: 0x06038F43 RID: 233283 RVA: 0x007B2B52 File Offset: 0x007B0D52
		public static void AddFloorSettings(FlatBufferBuilder builder, Offset<IFloorSettings> floorSettingsOffset)
		{
			builder.AddOffset(7, floorSettingsOffset.Value, 0);
		}

		// Token: 0x06038F44 RID: 233284 RVA: 0x007B2B62 File Offset: 0x007B0D62
		public static void AddIsTeleportInPlace(FlatBufferBuilder builder, bool isTeleportInPlace)
		{
			builder.AddBool(8, isTeleportInPlace, false);
		}

		// Token: 0x06038F45 RID: 233285 RVA: 0x007B2B6D File Offset: 0x007B0D6D
		public static void AddKeepMovementStates(FlatBufferBuilder builder, VectorOffset keepMovementStatesOffset)
		{
			builder.AddOffset(9, keepMovementStatesOffset.Value, 0);
		}

		// Token: 0x06038F46 RID: 233286 RVA: 0x007B2B80 File Offset: 0x007B0D80
		public static VectorOffset CreateKeepMovementStatesVector(FlatBufferBuilder builder, EKeepMovementState[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038F47 RID: 233287 RVA: 0x007B2BB7 File Offset: 0x007B0DB7
		public static VectorOffset CreateKeepMovementStatesVectorBlock(FlatBufferBuilder builder, EKeepMovementState[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EKeepMovementState>(data);
			return builder.EndVector();
		}

		// Token: 0x06038F48 RID: 233288 RVA: 0x007B2BD1 File Offset: 0x007B0DD1
		public static VectorOffset CreateKeepMovementStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<EKeepMovementState> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EKeepMovementState>(data);
			return builder.EndVector();
		}

		// Token: 0x06038F49 RID: 233289 RVA: 0x007B2BEF File Offset: 0x007B0DEF
		public static VectorOffset CreateKeepMovementStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EKeepMovementState>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038F4A RID: 233290 RVA: 0x007B2C08 File Offset: 0x007B0E08
		public static void StartKeepMovementStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06038F4B RID: 233291 RVA: 0x007B2C13 File Offset: 0x007B0E13
		public static void AddSeamlessTeleportFinishConfig(FlatBufferBuilder builder, Offset<ISeamlessTeleportFinishConfig> seamlessTeleportFinishConfigOffset)
		{
			builder.AddOffset(10, seamlessTeleportFinishConfigOffset.Value, 0);
		}

		// Token: 0x06038F4C RID: 233292 RVA: 0x007B2C24 File Offset: 0x007B0E24
		public static void AddIsNormalStreamingLoad(FlatBufferBuilder builder, bool isNormalStreamingLoad)
		{
			builder.AddBool(11, isNormalStreamingLoad, false);
		}

		// Token: 0x06038F4D RID: 233293 RVA: 0x007B2C30 File Offset: 0x007B0E30
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06038F4E RID: 233294 RVA: 0x007B2C3C File Offset: 0x007B0E3C
		public static Offset<ITeleportTransitionInSeamlessType> EndITeleportTransitionInSeamlessType(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionInSeamlessType>(builder.EndTable());
		}

		// Token: 0x06038F4F RID: 233295 RVA: 0x007B2C4C File Offset: 0x007B0E4C
		public ITeleportTransitionInSeamlessTypeT UnPack()
		{
			ITeleportTransitionInSeamlessTypeT teleportTransitionInSeamlessTypeT = new ITeleportTransitionInSeamlessTypeT();
			this.UnPackTo(teleportTransitionInSeamlessTypeT);
			return teleportTransitionInSeamlessTypeT;
		}

		// Token: 0x06038F50 RID: 233296 RVA: 0x007B2C68 File Offset: 0x007B0E68
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

		// Token: 0x06038F51 RID: 233297 RVA: 0x007B2D7C File Offset: 0x007B0F7C
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

		// Token: 0x040131D6 RID: 78294
		private Table __p;
	}
}

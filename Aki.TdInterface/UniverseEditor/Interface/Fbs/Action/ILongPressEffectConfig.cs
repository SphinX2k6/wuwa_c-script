using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A3B RID: 27195
	public struct ILongPressEffectConfig : IFlatbufferObject
	{
		// Token: 0x1700C9B3 RID: 51635
		// (get) Token: 0x0602F982 RID: 194946 RVA: 0x0067A4E9 File Offset: 0x006786E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F983 RID: 194947 RVA: 0x0067A4F6 File Offset: 0x006786F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F984 RID: 194948 RVA: 0x0067A500 File Offset: 0x00678700
		public static ILongPressEffectConfig GetRootAsILongPressEffectConfig(ByteBuffer _bb)
		{
			return ILongPressEffectConfig.GetRootAsILongPressEffectConfig(_bb, default(ILongPressEffectConfig));
		}

		// Token: 0x0602F985 RID: 194949 RVA: 0x0067A51C File Offset: 0x0067871C
		public static ILongPressEffectConfig GetRootAsILongPressEffectConfig(ByteBuffer _bb, ILongPressEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F986 RID: 194950 RVA: 0x0067A539 File Offset: 0x00678739
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F987 RID: 194951 RVA: 0x0067A548 File Offset: 0x00678748
		public ILongPressEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9B4 RID: 51636
		// (get) Token: 0x0602F988 RID: 194952 RVA: 0x0067A558 File Offset: 0x00678758
		public string CameraShakeBpPath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F989 RID: 194953 RVA: 0x0067A58F File Offset: 0x0067878F
		public Span<byte> GetCameraShakeBpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602F98A RID: 194954 RVA: 0x0067A59E File Offset: 0x0067879E
		public byte[] GetCameraShakeBpPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C9B5 RID: 51637
		// (get) Token: 0x0602F98B RID: 194955 RVA: 0x0067A5AC File Offset: 0x006787AC
		public string LongPressSound
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

		// Token: 0x0602F98C RID: 194956 RVA: 0x0067A5E3 File Offset: 0x006787E3
		public Span<byte> GetLongPressSoundBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F98D RID: 194957 RVA: 0x0067A5F2 File Offset: 0x006787F2
		public byte[] GetLongPressSoundArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C9B6 RID: 51638
		// (get) Token: 0x0602F98E RID: 194958 RVA: 0x0067A600 File Offset: 0x00678800
		public IGamePadInteractVibration? GamePadVibration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IGamePadInteractVibration?(default(IGamePadInteractVibration).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C9B7 RID: 51639
		// (get) Token: 0x0602F98F RID: 194959 RVA: 0x0067A660 File Offset: 0x00678860
		public string LongPressScreenEffect
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

		// Token: 0x0602F990 RID: 194960 RVA: 0x0067A698 File Offset: 0x00678898
		public Span<byte> GetLongPressScreenEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602F991 RID: 194961 RVA: 0x0067A6A8 File Offset: 0x006788A8
		public byte[] GetLongPressScreenEffectArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0602F992 RID: 194962 RVA: 0x0067A6B8 File Offset: 0x006788B8
		public string PlayEffects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C9B8 RID: 51640
		// (get) Token: 0x0602F993 RID: 194963 RVA: 0x0067A6F4 File Offset: 0x006788F4
		public int PlayEffectsLength
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

		// Token: 0x1700C9B9 RID: 51641
		// (get) Token: 0x0602F994 RID: 194964 RVA: 0x0067A720 File Offset: 0x00678920
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F995 RID: 194965 RVA: 0x0067A75D File Offset: 0x0067895D
		public static Offset<ILongPressEffectConfig> CreateILongPressEffectConfig(FlatBufferBuilder builder, StringOffset CameraShakeBpPathOffset = default(StringOffset), StringOffset LongPressSoundOffset = default(StringOffset), Offset<IGamePadInteractVibration> GamePadVibrationOffset = default(Offset<IGamePadInteractVibration>), StringOffset LongPressScreenEffectOffset = default(StringOffset), VectorOffset PlayEffectsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			ILongPressEffectConfig.AddPlayEffects(builder, PlayEffectsOffset);
			ILongPressEffectConfig.AddLongPressScreenEffect(builder, LongPressScreenEffectOffset);
			ILongPressEffectConfig.AddGamePadVibration(builder, GamePadVibrationOffset);
			ILongPressEffectConfig.AddLongPressSound(builder, LongPressSoundOffset);
			ILongPressEffectConfig.AddCameraShakeBpPath(builder, CameraShakeBpPathOffset);
			ILongPressEffectConfig.AddNullMask(builder, NullMask);
			return ILongPressEffectConfig.EndILongPressEffectConfig(builder);
		}

		// Token: 0x0602F996 RID: 194966 RVA: 0x0067A799 File Offset: 0x00678999
		public static void StartILongPressEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602F997 RID: 194967 RVA: 0x0067A7A2 File Offset: 0x006789A2
		public static void AddCameraShakeBpPath(FlatBufferBuilder builder, StringOffset cameraShakeBpPathOffset)
		{
			builder.AddOffset(0, cameraShakeBpPathOffset.Value, 0);
		}

		// Token: 0x0602F998 RID: 194968 RVA: 0x0067A7B2 File Offset: 0x006789B2
		public static void AddLongPressSound(FlatBufferBuilder builder, StringOffset longPressSoundOffset)
		{
			builder.AddOffset(1, longPressSoundOffset.Value, 0);
		}

		// Token: 0x0602F999 RID: 194969 RVA: 0x0067A7C2 File Offset: 0x006789C2
		public static void AddGamePadVibration(FlatBufferBuilder builder, Offset<IGamePadInteractVibration> gamePadVibrationOffset)
		{
			builder.AddOffset(2, gamePadVibrationOffset.Value, 0);
		}

		// Token: 0x0602F99A RID: 194970 RVA: 0x0067A7D2 File Offset: 0x006789D2
		public static void AddLongPressScreenEffect(FlatBufferBuilder builder, StringOffset longPressScreenEffectOffset)
		{
			builder.AddOffset(3, longPressScreenEffectOffset.Value, 0);
		}

		// Token: 0x0602F99B RID: 194971 RVA: 0x0067A7E2 File Offset: 0x006789E2
		public static void AddPlayEffects(FlatBufferBuilder builder, VectorOffset playEffectsOffset)
		{
			builder.AddOffset(4, playEffectsOffset.Value, 0);
		}

		// Token: 0x0602F99C RID: 194972 RVA: 0x0067A7F4 File Offset: 0x006789F4
		public static VectorOffset CreatePlayEffectsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F99D RID: 194973 RVA: 0x0067A834 File Offset: 0x00678A34
		public static VectorOffset CreatePlayEffectsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F99E RID: 194974 RVA: 0x0067A84E File Offset: 0x00678A4E
		public static VectorOffset CreatePlayEffectsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F99F RID: 194975 RVA: 0x0067A86C File Offset: 0x00678A6C
		public static VectorOffset CreatePlayEffectsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F9A0 RID: 194976 RVA: 0x0067A885 File Offset: 0x00678A85
		public static void StartPlayEffectsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F9A1 RID: 194977 RVA: 0x0067A890 File Offset: 0x00678A90
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602F9A2 RID: 194978 RVA: 0x0067A89B File Offset: 0x00678A9B
		public static Offset<ILongPressEffectConfig> EndILongPressEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressEffectConfig>(builder.EndTable());
		}

		// Token: 0x0602F9A3 RID: 194979 RVA: 0x0067A8A8 File Offset: 0x00678AA8
		public ILongPressEffectConfigT UnPack()
		{
			ILongPressEffectConfigT longPressEffectConfigT = new ILongPressEffectConfigT();
			this.UnPackTo(longPressEffectConfigT);
			return longPressEffectConfigT;
		}

		// Token: 0x0602F9A4 RID: 194980 RVA: 0x0067A8C4 File Offset: 0x00678AC4
		public void UnPackTo(ILongPressEffectConfigT _o)
		{
			_o.CameraShakeBpPath = this.CameraShakeBpPath;
			_o.LongPressSound = this.LongPressSound;
			_o.GamePadVibration = ((this.GamePadVibration != null) ? this.GamePadVibration.Value.UnPack() : null);
			_o.LongPressScreenEffect = this.LongPressScreenEffect;
			_o.PlayEffects = new List<string>();
			for (int i = 0; i < this.PlayEffectsLength; i++)
			{
				_o.PlayEffects.Add(this.PlayEffects(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F9A5 RID: 194981 RVA: 0x0067A960 File Offset: 0x00678B60
		public static Offset<ILongPressEffectConfig> Pack(FlatBufferBuilder builder, ILongPressEffectConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressEffectConfig>);
			}
			StringOffset cameraShakeBpPathOffset = (_o.CameraShakeBpPath == null) ? default(StringOffset) : builder.CreateString(_o.CameraShakeBpPath);
			StringOffset longPressSoundOffset = (_o.LongPressSound == null) ? default(StringOffset) : builder.CreateString(_o.LongPressSound);
			Offset<IGamePadInteractVibration> gamePadVibrationOffset = (_o.GamePadVibration == null) ? default(Offset<IGamePadInteractVibration>) : IGamePadInteractVibration.Pack(builder, _o.GamePadVibration);
			StringOffset longPressScreenEffectOffset = (_o.LongPressScreenEffect == null) ? default(StringOffset) : builder.CreateString(_o.LongPressScreenEffect);
			VectorOffset playEffectsOffset = default(VectorOffset);
			if (_o.PlayEffects != null)
			{
				StringOffset[] array = new StringOffset[_o.PlayEffects.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.PlayEffects[i]);
				}
				playEffectsOffset = ILongPressEffectConfig.CreatePlayEffectsVector(builder, array);
			}
			return ILongPressEffectConfig.CreateILongPressEffectConfig(builder, cameraShakeBpPathOffset, longPressSoundOffset, gamePadVibrationOffset, longPressScreenEffectOffset, playEffectsOffset, _o.NullMask);
		}

		// Token: 0x0401124A RID: 70218
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200715D RID: 29021
	public struct ILongPressEffectConfig : IFlatbufferObject
	{
		// Token: 0x1700D45E RID: 54366
		// (get) Token: 0x060326A8 RID: 206504 RVA: 0x006D05A9 File Offset: 0x006CE7A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060326A9 RID: 206505 RVA: 0x006D05B6 File Offset: 0x006CE7B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060326AA RID: 206506 RVA: 0x006D05C0 File Offset: 0x006CE7C0
		public static ILongPressEffectConfig GetRootAsILongPressEffectConfig(ByteBuffer _bb)
		{
			return ILongPressEffectConfig.GetRootAsILongPressEffectConfig(_bb, default(ILongPressEffectConfig));
		}

		// Token: 0x060326AB RID: 206507 RVA: 0x006D05DC File Offset: 0x006CE7DC
		public static ILongPressEffectConfig GetRootAsILongPressEffectConfig(ByteBuffer _bb, ILongPressEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060326AC RID: 206508 RVA: 0x006D05F9 File Offset: 0x006CE7F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060326AD RID: 206509 RVA: 0x006D0608 File Offset: 0x006CE808
		public ILongPressEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D45F RID: 54367
		// (get) Token: 0x060326AE RID: 206510 RVA: 0x006D0618 File Offset: 0x006CE818
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

		// Token: 0x060326AF RID: 206511 RVA: 0x006D064F File Offset: 0x006CE84F
		public Span<byte> GetCameraShakeBpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060326B0 RID: 206512 RVA: 0x006D065E File Offset: 0x006CE85E
		public byte[] GetCameraShakeBpPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D460 RID: 54368
		// (get) Token: 0x060326B1 RID: 206513 RVA: 0x006D066C File Offset: 0x006CE86C
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

		// Token: 0x060326B2 RID: 206514 RVA: 0x006D06A3 File Offset: 0x006CE8A3
		public Span<byte> GetLongPressSoundBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060326B3 RID: 206515 RVA: 0x006D06B2 File Offset: 0x006CE8B2
		public byte[] GetLongPressSoundArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D461 RID: 54369
		// (get) Token: 0x060326B4 RID: 206516 RVA: 0x006D06C0 File Offset: 0x006CE8C0
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

		// Token: 0x1700D462 RID: 54370
		// (get) Token: 0x060326B5 RID: 206517 RVA: 0x006D0720 File Offset: 0x006CE920
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

		// Token: 0x060326B6 RID: 206518 RVA: 0x006D0758 File Offset: 0x006CE958
		public Span<byte> GetLongPressScreenEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060326B7 RID: 206519 RVA: 0x006D0768 File Offset: 0x006CE968
		public byte[] GetLongPressScreenEffectArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x060326B8 RID: 206520 RVA: 0x006D0778 File Offset: 0x006CE978
		public string PlayEffects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D463 RID: 54371
		// (get) Token: 0x060326B9 RID: 206521 RVA: 0x006D07B4 File Offset: 0x006CE9B4
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

		// Token: 0x1700D464 RID: 54372
		// (get) Token: 0x060326BA RID: 206522 RVA: 0x006D07E0 File Offset: 0x006CE9E0
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

		// Token: 0x060326BB RID: 206523 RVA: 0x006D081D File Offset: 0x006CEA1D
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

		// Token: 0x060326BC RID: 206524 RVA: 0x006D0859 File Offset: 0x006CEA59
		public static void StartILongPressEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060326BD RID: 206525 RVA: 0x006D0862 File Offset: 0x006CEA62
		public static void AddCameraShakeBpPath(FlatBufferBuilder builder, StringOffset cameraShakeBpPathOffset)
		{
			builder.AddOffset(0, cameraShakeBpPathOffset.Value, 0);
		}

		// Token: 0x060326BE RID: 206526 RVA: 0x006D0872 File Offset: 0x006CEA72
		public static void AddLongPressSound(FlatBufferBuilder builder, StringOffset longPressSoundOffset)
		{
			builder.AddOffset(1, longPressSoundOffset.Value, 0);
		}

		// Token: 0x060326BF RID: 206527 RVA: 0x006D0882 File Offset: 0x006CEA82
		public static void AddGamePadVibration(FlatBufferBuilder builder, Offset<IGamePadInteractVibration> gamePadVibrationOffset)
		{
			builder.AddOffset(2, gamePadVibrationOffset.Value, 0);
		}

		// Token: 0x060326C0 RID: 206528 RVA: 0x006D0892 File Offset: 0x006CEA92
		public static void AddLongPressScreenEffect(FlatBufferBuilder builder, StringOffset longPressScreenEffectOffset)
		{
			builder.AddOffset(3, longPressScreenEffectOffset.Value, 0);
		}

		// Token: 0x060326C1 RID: 206529 RVA: 0x006D08A2 File Offset: 0x006CEAA2
		public static void AddPlayEffects(FlatBufferBuilder builder, VectorOffset playEffectsOffset)
		{
			builder.AddOffset(4, playEffectsOffset.Value, 0);
		}

		// Token: 0x060326C2 RID: 206530 RVA: 0x006D08B4 File Offset: 0x006CEAB4
		public static VectorOffset CreatePlayEffectsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060326C3 RID: 206531 RVA: 0x006D08F4 File Offset: 0x006CEAF4
		public static VectorOffset CreatePlayEffectsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060326C4 RID: 206532 RVA: 0x006D090E File Offset: 0x006CEB0E
		public static VectorOffset CreatePlayEffectsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060326C5 RID: 206533 RVA: 0x006D092C File Offset: 0x006CEB2C
		public static VectorOffset CreatePlayEffectsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060326C6 RID: 206534 RVA: 0x006D0945 File Offset: 0x006CEB45
		public static void StartPlayEffectsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060326C7 RID: 206535 RVA: 0x006D0950 File Offset: 0x006CEB50
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060326C8 RID: 206536 RVA: 0x006D095B File Offset: 0x006CEB5B
		public static Offset<ILongPressEffectConfig> EndILongPressEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressEffectConfig>(builder.EndTable());
		}

		// Token: 0x060326C9 RID: 206537 RVA: 0x006D0968 File Offset: 0x006CEB68
		public ILongPressEffectConfigT UnPack()
		{
			ILongPressEffectConfigT longPressEffectConfigT = new ILongPressEffectConfigT();
			this.UnPackTo(longPressEffectConfigT);
			return longPressEffectConfigT;
		}

		// Token: 0x060326CA RID: 206538 RVA: 0x006D0984 File Offset: 0x006CEB84
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

		// Token: 0x060326CB RID: 206539 RVA: 0x006D0A20 File Offset: 0x006CEC20
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

		// Token: 0x04012142 RID: 74050
		private Table __p;
	}
}

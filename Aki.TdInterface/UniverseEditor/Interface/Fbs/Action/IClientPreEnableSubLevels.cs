using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A5F RID: 27231
	public struct IClientPreEnableSubLevels : IFlatbufferObject
	{
		// Token: 0x1700C80B RID: 51211
		// (get) Token: 0x0602EB6F RID: 191343 RVA: 0x0065E04C File Offset: 0x0065C24C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB70 RID: 191344 RVA: 0x0065E059 File Offset: 0x0065C259
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB71 RID: 191345 RVA: 0x0065E060 File Offset: 0x0065C260
		public static IClientPreEnableSubLevels GetRootAsIClientPreEnableSubLevels(ByteBuffer _bb)
		{
			return IClientPreEnableSubLevels.GetRootAsIClientPreEnableSubLevels(_bb, default(IClientPreEnableSubLevels));
		}

		// Token: 0x0602EB72 RID: 191346 RVA: 0x0065E07C File Offset: 0x0065C27C
		public static IClientPreEnableSubLevels GetRootAsIClientPreEnableSubLevels(ByteBuffer _bb, IClientPreEnableSubLevels obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EB73 RID: 191347 RVA: 0x0065E099 File Offset: 0x0065C299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EB74 RID: 191348 RVA: 0x0065E0A8 File Offset: 0x0065C2A8
		public IClientPreEnableSubLevels __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602EB75 RID: 191349 RVA: 0x0065E0B8 File Offset: 0x0065C2B8
		public string EnableLevels(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C80C RID: 51212
		// (get) Token: 0x0602EB76 RID: 191350 RVA: 0x0065E0F4 File Offset: 0x0065C2F4
		public int EnableLevelsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602EB77 RID: 191351 RVA: 0x0065E120 File Offset: 0x0065C320
		public string DisableLevels(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C80D RID: 51213
		// (get) Token: 0x0602EB78 RID: 191352 RVA: 0x0065E15C File Offset: 0x0065C35C
		public int DisableLevelsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700C80E RID: 51214
		// (get) Token: 0x0602EB79 RID: 191353 RVA: 0x0065E188 File Offset: 0x0065C388
		public IEnableSubLevelTransitionWithSceneCapture? TransitionOption
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IEnableSubLevelTransitionWithSceneCapture?(default(IEnableSubLevelTransitionWithSceneCapture).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C80F RID: 51215
		// (get) Token: 0x0602EB7A RID: 191354 RVA: 0x0065E1E8 File Offset: 0x0065C3E8
		public bool IsWaitForEnableComplete
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C810 RID: 51216
		// (get) Token: 0x0602EB7B RID: 191355 RVA: 0x0065E228 File Offset: 0x0065C428
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EB7C RID: 191356 RVA: 0x0065E265 File Offset: 0x0065C465
		public static Offset<IClientPreEnableSubLevels> CreateIClientPreEnableSubLevels(FlatBufferBuilder builder, VectorOffset EnableLevelsOffset = default(VectorOffset), VectorOffset DisableLevelsOffset = default(VectorOffset), Offset<IEnableSubLevelTransitionWithSceneCapture> TransitionOptionOffset = default(Offset<IEnableSubLevelTransitionWithSceneCapture>), bool IsWaitForEnableComplete = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IClientPreEnableSubLevels.AddTransitionOption(builder, TransitionOptionOffset);
			IClientPreEnableSubLevels.AddDisableLevels(builder, DisableLevelsOffset);
			IClientPreEnableSubLevels.AddEnableLevels(builder, EnableLevelsOffset);
			IClientPreEnableSubLevels.AddNullMask(builder, NullMask);
			IClientPreEnableSubLevels.AddIsWaitForEnableComplete(builder, IsWaitForEnableComplete);
			return IClientPreEnableSubLevels.EndIClientPreEnableSubLevels(builder);
		}

		// Token: 0x0602EB7D RID: 191357 RVA: 0x0065E299 File Offset: 0x0065C499
		public static void StartIClientPreEnableSubLevels(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602EB7E RID: 191358 RVA: 0x0065E2A2 File Offset: 0x0065C4A2
		public static void AddEnableLevels(FlatBufferBuilder builder, VectorOffset enableLevelsOffset)
		{
			builder.AddOffset(0, enableLevelsOffset.Value, 0);
		}

		// Token: 0x0602EB7F RID: 191359 RVA: 0x0065E2B4 File Offset: 0x0065C4B4
		public static VectorOffset CreateEnableLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EB80 RID: 191360 RVA: 0x0065E2F4 File Offset: 0x0065C4F4
		public static VectorOffset CreateEnableLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB81 RID: 191361 RVA: 0x0065E30E File Offset: 0x0065C50E
		public static VectorOffset CreateEnableLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB82 RID: 191362 RVA: 0x0065E32C File Offset: 0x0065C52C
		public static VectorOffset CreateEnableLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EB83 RID: 191363 RVA: 0x0065E345 File Offset: 0x0065C545
		public static void StartEnableLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EB84 RID: 191364 RVA: 0x0065E350 File Offset: 0x0065C550
		public static void AddDisableLevels(FlatBufferBuilder builder, VectorOffset disableLevelsOffset)
		{
			builder.AddOffset(1, disableLevelsOffset.Value, 0);
		}

		// Token: 0x0602EB85 RID: 191365 RVA: 0x0065E360 File Offset: 0x0065C560
		public static VectorOffset CreateDisableLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EB86 RID: 191366 RVA: 0x0065E3A0 File Offset: 0x0065C5A0
		public static VectorOffset CreateDisableLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB87 RID: 191367 RVA: 0x0065E3BA File Offset: 0x0065C5BA
		public static VectorOffset CreateDisableLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB88 RID: 191368 RVA: 0x0065E3D8 File Offset: 0x0065C5D8
		public static VectorOffset CreateDisableLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EB89 RID: 191369 RVA: 0x0065E3F1 File Offset: 0x0065C5F1
		public static void StartDisableLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EB8A RID: 191370 RVA: 0x0065E3FC File Offset: 0x0065C5FC
		public static void AddTransitionOption(FlatBufferBuilder builder, Offset<IEnableSubLevelTransitionWithSceneCapture> transitionOptionOffset)
		{
			builder.AddOffset(2, transitionOptionOffset.Value, 0);
		}

		// Token: 0x0602EB8B RID: 191371 RVA: 0x0065E40C File Offset: 0x0065C60C
		public static void AddIsWaitForEnableComplete(FlatBufferBuilder builder, bool isWaitForEnableComplete)
		{
			builder.AddBool(3, isWaitForEnableComplete, false);
		}

		// Token: 0x0602EB8C RID: 191372 RVA: 0x0065E417 File Offset: 0x0065C617
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602EB8D RID: 191373 RVA: 0x0065E422 File Offset: 0x0065C622
		public static Offset<IClientPreEnableSubLevels> EndIClientPreEnableSubLevels(FlatBufferBuilder builder)
		{
			return new Offset<IClientPreEnableSubLevels>(builder.EndTable());
		}

		// Token: 0x0602EB8E RID: 191374 RVA: 0x0065E430 File Offset: 0x0065C630
		public IClientPreEnableSubLevelsT UnPack()
		{
			IClientPreEnableSubLevelsT clientPreEnableSubLevelsT = new IClientPreEnableSubLevelsT();
			this.UnPackTo(clientPreEnableSubLevelsT);
			return clientPreEnableSubLevelsT;
		}

		// Token: 0x0602EB8F RID: 191375 RVA: 0x0065E44C File Offset: 0x0065C64C
		public void UnPackTo(IClientPreEnableSubLevelsT _o)
		{
			_o.EnableLevels = new List<string>();
			for (int i = 0; i < this.EnableLevelsLength; i++)
			{
				_o.EnableLevels.Add(this.EnableLevels(i));
			}
			_o.DisableLevels = new List<string>();
			for (int j = 0; j < this.DisableLevelsLength; j++)
			{
				_o.DisableLevels.Add(this.DisableLevels(j));
			}
			_o.TransitionOption = ((this.TransitionOption != null) ? this.TransitionOption.Value.UnPack() : null);
			_o.IsWaitForEnableComplete = this.IsWaitForEnableComplete;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602EB90 RID: 191376 RVA: 0x0065E4FC File Offset: 0x0065C6FC
		public static Offset<IClientPreEnableSubLevels> Pack(FlatBufferBuilder builder, IClientPreEnableSubLevelsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientPreEnableSubLevels>);
			}
			VectorOffset enableLevelsOffset = default(VectorOffset);
			if (_o.EnableLevels != null)
			{
				StringOffset[] array = new StringOffset[_o.EnableLevels.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.EnableLevels[i]);
				}
				enableLevelsOffset = IClientPreEnableSubLevels.CreateEnableLevelsVector(builder, array);
			}
			VectorOffset disableLevelsOffset = default(VectorOffset);
			if (_o.DisableLevels != null)
			{
				StringOffset[] array2 = new StringOffset[_o.DisableLevels.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.DisableLevels[j]);
				}
				disableLevelsOffset = IClientPreEnableSubLevels.CreateDisableLevelsVector(builder, array2);
			}
			Offset<IEnableSubLevelTransitionWithSceneCapture> transitionOptionOffset = (_o.TransitionOption == null) ? default(Offset<IEnableSubLevelTransitionWithSceneCapture>) : IEnableSubLevelTransitionWithSceneCapture.Pack(builder, _o.TransitionOption);
			return IClientPreEnableSubLevels.CreateIClientPreEnableSubLevels(builder, enableLevelsOffset, disableLevelsOffset, transitionOptionOffset, _o.IsWaitForEnableComplete, _o.NullMask);
		}

		// Token: 0x040117E4 RID: 71652
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063DF RID: 25567
	public struct IClientPreEnableSubLevels : IFlatbufferObject
	{
		// Token: 0x1700BE71 RID: 48753
		// (get) Token: 0x0602C399 RID: 181145 RVA: 0x006121C0 File Offset: 0x006103C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C39A RID: 181146 RVA: 0x006121CD File Offset: 0x006103CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C39B RID: 181147 RVA: 0x006121D4 File Offset: 0x006103D4
		public static IClientPreEnableSubLevels GetRootAsIClientPreEnableSubLevels(ByteBuffer _bb)
		{
			return IClientPreEnableSubLevels.GetRootAsIClientPreEnableSubLevels(_bb, default(IClientPreEnableSubLevels));
		}

		// Token: 0x0602C39C RID: 181148 RVA: 0x006121F0 File Offset: 0x006103F0
		public static IClientPreEnableSubLevels GetRootAsIClientPreEnableSubLevels(ByteBuffer _bb, IClientPreEnableSubLevels obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C39D RID: 181149 RVA: 0x0061220D File Offset: 0x0061040D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C39E RID: 181150 RVA: 0x0061221C File Offset: 0x0061041C
		public IClientPreEnableSubLevels __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C39F RID: 181151 RVA: 0x0061222C File Offset: 0x0061042C
		public string EnableLevels(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BE72 RID: 48754
		// (get) Token: 0x0602C3A0 RID: 181152 RVA: 0x00612268 File Offset: 0x00610468
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

		// Token: 0x0602C3A1 RID: 181153 RVA: 0x00612294 File Offset: 0x00610494
		public string DisableLevels(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BE73 RID: 48755
		// (get) Token: 0x0602C3A2 RID: 181154 RVA: 0x006122D0 File Offset: 0x006104D0
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

		// Token: 0x1700BE74 RID: 48756
		// (get) Token: 0x0602C3A3 RID: 181155 RVA: 0x006122FC File Offset: 0x006104FC
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

		// Token: 0x1700BE75 RID: 48757
		// (get) Token: 0x0602C3A4 RID: 181156 RVA: 0x0061235C File Offset: 0x0061055C
		public bool IsWaitForEnableComplete
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BE76 RID: 48758
		// (get) Token: 0x0602C3A5 RID: 181157 RVA: 0x0061239C File Offset: 0x0061059C
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

		// Token: 0x0602C3A6 RID: 181158 RVA: 0x006123D9 File Offset: 0x006105D9
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

		// Token: 0x0602C3A7 RID: 181159 RVA: 0x0061240D File Offset: 0x0061060D
		public static void StartIClientPreEnableSubLevels(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602C3A8 RID: 181160 RVA: 0x00612416 File Offset: 0x00610616
		public static void AddEnableLevels(FlatBufferBuilder builder, VectorOffset enableLevelsOffset)
		{
			builder.AddOffset(0, enableLevelsOffset.Value, 0);
		}

		// Token: 0x0602C3A9 RID: 181161 RVA: 0x00612428 File Offset: 0x00610628
		public static VectorOffset CreateEnableLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C3AA RID: 181162 RVA: 0x00612468 File Offset: 0x00610668
		public static VectorOffset CreateEnableLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C3AB RID: 181163 RVA: 0x00612482 File Offset: 0x00610682
		public static VectorOffset CreateEnableLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C3AC RID: 181164 RVA: 0x006124A0 File Offset: 0x006106A0
		public static VectorOffset CreateEnableLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C3AD RID: 181165 RVA: 0x006124B9 File Offset: 0x006106B9
		public static void StartEnableLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C3AE RID: 181166 RVA: 0x006124C4 File Offset: 0x006106C4
		public static void AddDisableLevels(FlatBufferBuilder builder, VectorOffset disableLevelsOffset)
		{
			builder.AddOffset(1, disableLevelsOffset.Value, 0);
		}

		// Token: 0x0602C3AF RID: 181167 RVA: 0x006124D4 File Offset: 0x006106D4
		public static VectorOffset CreateDisableLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C3B0 RID: 181168 RVA: 0x00612514 File Offset: 0x00610714
		public static VectorOffset CreateDisableLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C3B1 RID: 181169 RVA: 0x0061252E File Offset: 0x0061072E
		public static VectorOffset CreateDisableLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C3B2 RID: 181170 RVA: 0x0061254C File Offset: 0x0061074C
		public static VectorOffset CreateDisableLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C3B3 RID: 181171 RVA: 0x00612565 File Offset: 0x00610765
		public static void StartDisableLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C3B4 RID: 181172 RVA: 0x00612570 File Offset: 0x00610770
		public static void AddTransitionOption(FlatBufferBuilder builder, Offset<IEnableSubLevelTransitionWithSceneCapture> transitionOptionOffset)
		{
			builder.AddOffset(2, transitionOptionOffset.Value, 0);
		}

		// Token: 0x0602C3B5 RID: 181173 RVA: 0x00612580 File Offset: 0x00610780
		public static void AddIsWaitForEnableComplete(FlatBufferBuilder builder, bool isWaitForEnableComplete)
		{
			builder.AddBool(3, isWaitForEnableComplete, false);
		}

		// Token: 0x0602C3B6 RID: 181174 RVA: 0x0061258B File Offset: 0x0061078B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602C3B7 RID: 181175 RVA: 0x00612596 File Offset: 0x00610796
		public static Offset<IClientPreEnableSubLevels> EndIClientPreEnableSubLevels(FlatBufferBuilder builder)
		{
			return new Offset<IClientPreEnableSubLevels>(builder.EndTable());
		}

		// Token: 0x0602C3B8 RID: 181176 RVA: 0x006125A4 File Offset: 0x006107A4
		public IClientPreEnableSubLevelsT UnPack()
		{
			IClientPreEnableSubLevelsT clientPreEnableSubLevelsT = new IClientPreEnableSubLevelsT();
			this.UnPackTo(clientPreEnableSubLevelsT);
			return clientPreEnableSubLevelsT;
		}

		// Token: 0x0602C3B9 RID: 181177 RVA: 0x006125C0 File Offset: 0x006107C0
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

		// Token: 0x0602C3BA RID: 181178 RVA: 0x00612670 File Offset: 0x00610870
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

		// Token: 0x040109BE RID: 68030
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200774A RID: 30538
	public struct ISequenceInteractStage : IFlatbufferObject
	{
		// Token: 0x1700DFD5 RID: 57301
		// (get) Token: 0x06035952 RID: 219474 RVA: 0x0072E72C File Offset: 0x0072C92C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035953 RID: 219475 RVA: 0x0072E739 File Offset: 0x0072C939
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035954 RID: 219476 RVA: 0x0072E740 File Offset: 0x0072C940
		public static ISequenceInteractStage GetRootAsISequenceInteractStage(ByteBuffer _bb)
		{
			return ISequenceInteractStage.GetRootAsISequenceInteractStage(_bb, default(ISequenceInteractStage));
		}

		// Token: 0x06035955 RID: 219477 RVA: 0x0072E75C File Offset: 0x0072C95C
		public static ISequenceInteractStage GetRootAsISequenceInteractStage(ByteBuffer _bb, ISequenceInteractStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035956 RID: 219478 RVA: 0x0072E779 File Offset: 0x0072C979
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035957 RID: 219479 RVA: 0x0072E788 File Offset: 0x0072C988
		public ISequenceInteractStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06035958 RID: 219480 RVA: 0x0072E798 File Offset: 0x0072C998
		public TInteractEffect EnterStageEffectsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TInteractEffect.NONE;
			}
			return (TInteractEffect)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DFD6 RID: 57302
		// (get) Token: 0x06035959 RID: 219481 RVA: 0x0072E7D8 File Offset: 0x0072C9D8
		public int EnterStageEffectsTypeLength
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

		// Token: 0x0603595A RID: 219482 RVA: 0x0072E803 File Offset: 0x0072CA03
		public Span<TInteractEffect> GetEnterStageEffectsTypeBytes()
		{
			return this.__p.__vector_as_span<TInteractEffect>(4, 1);
		}

		// Token: 0x0603595B RID: 219483 RVA: 0x0072E814 File Offset: 0x0072CA14
		public TInteractEffect[] GetEnterStageEffectsTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TInteractEffect[] array = new TInteractEffect[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TInteractEffect)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0603595C RID: 219484 RVA: 0x0072E880 File Offset: 0x0072CA80
		public TTable? EnterStageEffects<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DFD7 RID: 57303
		// (get) Token: 0x0603595D RID: 219485 RVA: 0x0072E8C8 File Offset: 0x0072CAC8
		public int EnterStageEffectsLength
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

		// Token: 0x0603595E RID: 219486 RVA: 0x0072E8F4 File Offset: 0x0072CAF4
		public IInteractPoint? InteractPoints(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IInteractPoint?(default(IInteractPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DFD8 RID: 57304
		// (get) Token: 0x0603595F RID: 219487 RVA: 0x0072E954 File Offset: 0x0072CB54
		public int InteractPointsLength
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

		// Token: 0x1700DFD9 RID: 57305
		// (get) Token: 0x06035960 RID: 219488 RVA: 0x0072E980 File Offset: 0x0072CB80
		public string UiTipText
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

		// Token: 0x06035961 RID: 219489 RVA: 0x0072E9B8 File Offset: 0x0072CBB8
		public Span<byte> GetUiTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06035962 RID: 219490 RVA: 0x0072E9C8 File Offset: 0x0072CBC8
		public byte[] GetUiTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700DFDA RID: 57306
		// (get) Token: 0x06035963 RID: 219491 RVA: 0x0072E9D8 File Offset: 0x0072CBD8
		public bool IsResetAfterStageEnd
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DFDB RID: 57307
		// (get) Token: 0x06035964 RID: 219492 RVA: 0x0072EA18 File Offset: 0x0072CC18
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

		// Token: 0x06035965 RID: 219493 RVA: 0x0072EA55 File Offset: 0x0072CC55
		public static Offset<ISequenceInteractStage> CreateISequenceInteractStage(FlatBufferBuilder builder, VectorOffset EnterStageEffects_typeOffset = default(VectorOffset), VectorOffset EnterStageEffectsOffset = default(VectorOffset), VectorOffset InteractPointsOffset = default(VectorOffset), StringOffset UiTipTextOffset = default(StringOffset), bool IsResetAfterStageEnd = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			ISequenceInteractStage.AddUiTipText(builder, UiTipTextOffset);
			ISequenceInteractStage.AddInteractPoints(builder, InteractPointsOffset);
			ISequenceInteractStage.AddEnterStageEffects(builder, EnterStageEffectsOffset);
			ISequenceInteractStage.AddEnterStageEffectsType(builder, EnterStageEffects_typeOffset);
			ISequenceInteractStage.AddNullMask(builder, NullMask);
			ISequenceInteractStage.AddIsResetAfterStageEnd(builder, IsResetAfterStageEnd);
			return ISequenceInteractStage.EndISequenceInteractStage(builder);
		}

		// Token: 0x06035966 RID: 219494 RVA: 0x0072EA91 File Offset: 0x0072CC91
		public static void StartISequenceInteractStage(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06035967 RID: 219495 RVA: 0x0072EA9A File Offset: 0x0072CC9A
		public static void AddEnterStageEffectsType(FlatBufferBuilder builder, VectorOffset enterStageEffectsTypeOffset)
		{
			builder.AddOffset(0, enterStageEffectsTypeOffset.Value, 0);
		}

		// Token: 0x06035968 RID: 219496 RVA: 0x0072EAAC File Offset: 0x0072CCAC
		public static VectorOffset CreateEnterStageEffectsTypeVector(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035969 RID: 219497 RVA: 0x0072EAE3 File Offset: 0x0072CCE3
		public static VectorOffset CreateEnterStageEffectsTypeVectorBlock(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x0603596A RID: 219498 RVA: 0x0072EAFD File Offset: 0x0072CCFD
		public static VectorOffset CreateEnterStageEffectsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TInteractEffect> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x0603596B RID: 219499 RVA: 0x0072EB1B File Offset: 0x0072CD1B
		public static VectorOffset CreateEnterStageEffectsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TInteractEffect>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603596C RID: 219500 RVA: 0x0072EB34 File Offset: 0x0072CD34
		public static void StartEnterStageEffectsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0603596D RID: 219501 RVA: 0x0072EB3F File Offset: 0x0072CD3F
		public static void AddEnterStageEffects(FlatBufferBuilder builder, VectorOffset enterStageEffectsOffset)
		{
			builder.AddOffset(1, enterStageEffectsOffset.Value, 0);
		}

		// Token: 0x0603596E RID: 219502 RVA: 0x0072EB50 File Offset: 0x0072CD50
		public static VectorOffset CreateEnterStageEffectsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603596F RID: 219503 RVA: 0x0072EB87 File Offset: 0x0072CD87
		public static VectorOffset CreateEnterStageEffectsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035970 RID: 219504 RVA: 0x0072EBA1 File Offset: 0x0072CDA1
		public static VectorOffset CreateEnterStageEffectsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035971 RID: 219505 RVA: 0x0072EBBF File Offset: 0x0072CDBF
		public static VectorOffset CreateEnterStageEffectsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035972 RID: 219506 RVA: 0x0072EBD8 File Offset: 0x0072CDD8
		public static void StartEnterStageEffectsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035973 RID: 219507 RVA: 0x0072EBE3 File Offset: 0x0072CDE3
		public static void AddInteractPoints(FlatBufferBuilder builder, VectorOffset interactPointsOffset)
		{
			builder.AddOffset(2, interactPointsOffset.Value, 0);
		}

		// Token: 0x06035974 RID: 219508 RVA: 0x0072EBF4 File Offset: 0x0072CDF4
		public static VectorOffset CreateInteractPointsVector(FlatBufferBuilder builder, Offset<IInteractPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035975 RID: 219509 RVA: 0x0072EC34 File Offset: 0x0072CE34
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, Offset<IInteractPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInteractPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035976 RID: 219510 RVA: 0x0072EC4E File Offset: 0x0072CE4E
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInteractPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInteractPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035977 RID: 219511 RVA: 0x0072EC6C File Offset: 0x0072CE6C
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInteractPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035978 RID: 219512 RVA: 0x0072EC85 File Offset: 0x0072CE85
		public static void StartInteractPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035979 RID: 219513 RVA: 0x0072EC90 File Offset: 0x0072CE90
		public static void AddUiTipText(FlatBufferBuilder builder, StringOffset uiTipTextOffset)
		{
			builder.AddOffset(3, uiTipTextOffset.Value, 0);
		}

		// Token: 0x0603597A RID: 219514 RVA: 0x0072ECA0 File Offset: 0x0072CEA0
		public static void AddIsResetAfterStageEnd(FlatBufferBuilder builder, bool isResetAfterStageEnd)
		{
			builder.AddBool(4, isResetAfterStageEnd, false);
		}

		// Token: 0x0603597B RID: 219515 RVA: 0x0072ECAB File Offset: 0x0072CEAB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0603597C RID: 219516 RVA: 0x0072ECB6 File Offset: 0x0072CEB6
		public static Offset<ISequenceInteractStage> EndISequenceInteractStage(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceInteractStage>(builder.EndTable());
		}

		// Token: 0x0603597D RID: 219517 RVA: 0x0072ECC4 File Offset: 0x0072CEC4
		public ISequenceInteractStageT UnPack()
		{
			ISequenceInteractStageT sequenceInteractStageT = new ISequenceInteractStageT();
			this.UnPackTo(sequenceInteractStageT);
			return sequenceInteractStageT;
		}

		// Token: 0x0603597E RID: 219518 RVA: 0x0072ECE0 File Offset: 0x0072CEE0
		public void UnPackTo(ISequenceInteractStageT _o)
		{
			_o.EnterStageEffects = new List<TInteractEffectUnion>();
			for (int i = 0; i < this.EnterStageEffectsLength; i++)
			{
				TInteractEffectUnion tinteractEffectUnion = new TInteractEffectUnion();
				tinteractEffectUnion.Type = this.EnterStageEffectsType(i);
				switch (this.EnterStageEffectsType(i))
				{
				case TInteractEffect.IExecuteTag:
					tinteractEffectUnion.Value = ((this.EnterStageEffects<IExecuteTag>(i) != null) ? this.EnterStageEffects<IExecuteTag>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.IModifyTipText:
					tinteractEffectUnion.Value = ((this.EnterStageEffects<IModifyTipText>(i) != null) ? this.EnterStageEffects<IModifyTipText>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.ITriggerDialogues:
					tinteractEffectUnion.Value = ((this.EnterStageEffects<ITriggerDialogues>(i) != null) ? this.EnterStageEffects<ITriggerDialogues>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.ITriggerVoiceDialogues:
					tinteractEffectUnion.Value = ((this.EnterStageEffects<ITriggerVoiceDialogues>(i) != null) ? this.EnterStageEffects<ITriggerVoiceDialogues>(i).Value.UnPack() : null);
					break;
				}
				_o.EnterStageEffects.Add(tinteractEffectUnion);
			}
			_o.InteractPoints = new List<IInteractPointT>();
			for (int j = 0; j < this.InteractPointsLength; j++)
			{
				_o.InteractPoints.Add((this.InteractPoints(j) != null) ? this.InteractPoints(j).Value.UnPack() : null);
			}
			_o.UiTipText = this.UiTipText;
			_o.IsResetAfterStageEnd = this.IsResetAfterStageEnd;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603597F RID: 219519 RVA: 0x0072EEAC File Offset: 0x0072D0AC
		public static Offset<ISequenceInteractStage> Pack(FlatBufferBuilder builder, ISequenceInteractStageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISequenceInteractStage>);
			}
			VectorOffset enterStageEffects_typeOffset = default(VectorOffset);
			if (_o.EnterStageEffects != null)
			{
				TInteractEffect[] array = new TInteractEffect[_o.EnterStageEffects.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.EnterStageEffects[i].Type;
				}
				enterStageEffects_typeOffset = ISequenceInteractStage.CreateEnterStageEffectsTypeVector(builder, array);
			}
			VectorOffset enterStageEffectsOffset = default(VectorOffset);
			if (_o.EnterStageEffects != null)
			{
				int[] array2 = new int[_o.EnterStageEffects.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TInteractEffectUnion.Pack(builder, _o.EnterStageEffects[j]);
				}
				enterStageEffectsOffset = ISequenceInteractStage.CreateEnterStageEffectsVector(builder, array2);
			}
			VectorOffset interactPointsOffset = default(VectorOffset);
			if (_o.InteractPoints != null)
			{
				Offset<IInteractPoint>[] array3 = new Offset<IInteractPoint>[_o.InteractPoints.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IInteractPoint.Pack(builder, _o.InteractPoints[k]);
				}
				interactPointsOffset = ISequenceInteractStage.CreateInteractPointsVector(builder, array3);
			}
			StringOffset uiTipTextOffset = (_o.UiTipText == null) ? default(StringOffset) : builder.CreateString(_o.UiTipText);
			return ISequenceInteractStage.CreateISequenceInteractStage(builder, enterStageEffects_typeOffset, enterStageEffectsOffset, interactPointsOffset, uiTipTextOffset, _o.IsResetAfterStageEnd, _o.NullMask);
		}

		// Token: 0x04012960 RID: 76128
		private Table __p;
	}
}

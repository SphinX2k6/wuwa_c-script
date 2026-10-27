using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F84 RID: 28548
	public struct ISequenceInteractStage : IFlatbufferObject
	{
		// Token: 0x1700D406 RID: 54278
		// (get) Token: 0x06032702 RID: 206594 RVA: 0x006CED74 File Offset: 0x006CCF74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032703 RID: 206595 RVA: 0x006CED81 File Offset: 0x006CCF81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032704 RID: 206596 RVA: 0x006CED88 File Offset: 0x006CCF88
		public static ISequenceInteractStage GetRootAsISequenceInteractStage(ByteBuffer _bb)
		{
			return ISequenceInteractStage.GetRootAsISequenceInteractStage(_bb, default(ISequenceInteractStage));
		}

		// Token: 0x06032705 RID: 206597 RVA: 0x006CEDA4 File Offset: 0x006CCFA4
		public static ISequenceInteractStage GetRootAsISequenceInteractStage(ByteBuffer _bb, ISequenceInteractStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032706 RID: 206598 RVA: 0x006CEDC1 File Offset: 0x006CCFC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032707 RID: 206599 RVA: 0x006CEDD0 File Offset: 0x006CCFD0
		public ISequenceInteractStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032708 RID: 206600 RVA: 0x006CEDE0 File Offset: 0x006CCFE0
		public TInteractEffect EnterStageEffectsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TInteractEffect.NONE;
			}
			return (TInteractEffect)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700D407 RID: 54279
		// (get) Token: 0x06032709 RID: 206601 RVA: 0x006CEE20 File Offset: 0x006CD020
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

		// Token: 0x0603270A RID: 206602 RVA: 0x006CEE4B File Offset: 0x006CD04B
		public Span<TInteractEffect> GetEnterStageEffectsTypeBytes()
		{
			return this.__p.__vector_as_span<TInteractEffect>(4, 1);
		}

		// Token: 0x0603270B RID: 206603 RVA: 0x006CEE5C File Offset: 0x006CD05C
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

		// Token: 0x0603270C RID: 206604 RVA: 0x006CEEC8 File Offset: 0x006CD0C8
		public TTable? EnterStageEffects<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700D408 RID: 54280
		// (get) Token: 0x0603270D RID: 206605 RVA: 0x006CEF10 File Offset: 0x006CD110
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

		// Token: 0x0603270E RID: 206606 RVA: 0x006CEF3C File Offset: 0x006CD13C
		public IInteractPoint? InteractPoints(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IInteractPoint?(default(IInteractPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D409 RID: 54281
		// (get) Token: 0x0603270F RID: 206607 RVA: 0x006CEF9C File Offset: 0x006CD19C
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

		// Token: 0x1700D40A RID: 54282
		// (get) Token: 0x06032710 RID: 206608 RVA: 0x006CEFC8 File Offset: 0x006CD1C8
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

		// Token: 0x06032711 RID: 206609 RVA: 0x006CF000 File Offset: 0x006CD200
		public Span<byte> GetUiTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06032712 RID: 206610 RVA: 0x006CF010 File Offset: 0x006CD210
		public byte[] GetUiTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D40B RID: 54283
		// (get) Token: 0x06032713 RID: 206611 RVA: 0x006CF020 File Offset: 0x006CD220
		public bool IsResetAfterStageEnd
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D40C RID: 54284
		// (get) Token: 0x06032714 RID: 206612 RVA: 0x006CF060 File Offset: 0x006CD260
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

		// Token: 0x06032715 RID: 206613 RVA: 0x006CF09D File Offset: 0x006CD29D
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

		// Token: 0x06032716 RID: 206614 RVA: 0x006CF0D9 File Offset: 0x006CD2D9
		public static void StartISequenceInteractStage(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06032717 RID: 206615 RVA: 0x006CF0E2 File Offset: 0x006CD2E2
		public static void AddEnterStageEffectsType(FlatBufferBuilder builder, VectorOffset enterStageEffectsTypeOffset)
		{
			builder.AddOffset(0, enterStageEffectsTypeOffset.Value, 0);
		}

		// Token: 0x06032718 RID: 206616 RVA: 0x006CF0F4 File Offset: 0x006CD2F4
		public static VectorOffset CreateEnterStageEffectsTypeVector(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032719 RID: 206617 RVA: 0x006CF12B File Offset: 0x006CD32B
		public static VectorOffset CreateEnterStageEffectsTypeVectorBlock(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x0603271A RID: 206618 RVA: 0x006CF145 File Offset: 0x006CD345
		public static VectorOffset CreateEnterStageEffectsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TInteractEffect> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x0603271B RID: 206619 RVA: 0x006CF163 File Offset: 0x006CD363
		public static VectorOffset CreateEnterStageEffectsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TInteractEffect>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603271C RID: 206620 RVA: 0x006CF17C File Offset: 0x006CD37C
		public static void StartEnterStageEffectsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0603271D RID: 206621 RVA: 0x006CF187 File Offset: 0x006CD387
		public static void AddEnterStageEffects(FlatBufferBuilder builder, VectorOffset enterStageEffectsOffset)
		{
			builder.AddOffset(1, enterStageEffectsOffset.Value, 0);
		}

		// Token: 0x0603271E RID: 206622 RVA: 0x006CF198 File Offset: 0x006CD398
		public static VectorOffset CreateEnterStageEffectsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603271F RID: 206623 RVA: 0x006CF1CF File Offset: 0x006CD3CF
		public static VectorOffset CreateEnterStageEffectsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032720 RID: 206624 RVA: 0x006CF1E9 File Offset: 0x006CD3E9
		public static VectorOffset CreateEnterStageEffectsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032721 RID: 206625 RVA: 0x006CF207 File Offset: 0x006CD407
		public static VectorOffset CreateEnterStageEffectsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032722 RID: 206626 RVA: 0x006CF220 File Offset: 0x006CD420
		public static void StartEnterStageEffectsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032723 RID: 206627 RVA: 0x006CF22B File Offset: 0x006CD42B
		public static void AddInteractPoints(FlatBufferBuilder builder, VectorOffset interactPointsOffset)
		{
			builder.AddOffset(2, interactPointsOffset.Value, 0);
		}

		// Token: 0x06032724 RID: 206628 RVA: 0x006CF23C File Offset: 0x006CD43C
		public static VectorOffset CreateInteractPointsVector(FlatBufferBuilder builder, Offset<IInteractPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032725 RID: 206629 RVA: 0x006CF27C File Offset: 0x006CD47C
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, Offset<IInteractPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInteractPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032726 RID: 206630 RVA: 0x006CF296 File Offset: 0x006CD496
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInteractPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInteractPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032727 RID: 206631 RVA: 0x006CF2B4 File Offset: 0x006CD4B4
		public static VectorOffset CreateInteractPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInteractPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032728 RID: 206632 RVA: 0x006CF2CD File Offset: 0x006CD4CD
		public static void StartInteractPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032729 RID: 206633 RVA: 0x006CF2D8 File Offset: 0x006CD4D8
		public static void AddUiTipText(FlatBufferBuilder builder, StringOffset uiTipTextOffset)
		{
			builder.AddOffset(3, uiTipTextOffset.Value, 0);
		}

		// Token: 0x0603272A RID: 206634 RVA: 0x006CF2E8 File Offset: 0x006CD4E8
		public static void AddIsResetAfterStageEnd(FlatBufferBuilder builder, bool isResetAfterStageEnd)
		{
			builder.AddBool(4, isResetAfterStageEnd, false);
		}

		// Token: 0x0603272B RID: 206635 RVA: 0x006CF2F3 File Offset: 0x006CD4F3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0603272C RID: 206636 RVA: 0x006CF2FE File Offset: 0x006CD4FE
		public static Offset<ISequenceInteractStage> EndISequenceInteractStage(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceInteractStage>(builder.EndTable());
		}

		// Token: 0x0603272D RID: 206637 RVA: 0x006CF30C File Offset: 0x006CD50C
		public ISequenceInteractStageT UnPack()
		{
			ISequenceInteractStageT sequenceInteractStageT = new ISequenceInteractStageT();
			this.UnPackTo(sequenceInteractStageT);
			return sequenceInteractStageT;
		}

		// Token: 0x0603272E RID: 206638 RVA: 0x006CF328 File Offset: 0x006CD528
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

		// Token: 0x0603272F RID: 206639 RVA: 0x006CF4F4 File Offset: 0x006CD6F4
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

		// Token: 0x0401197E RID: 72062
		private Table __p;
	}
}

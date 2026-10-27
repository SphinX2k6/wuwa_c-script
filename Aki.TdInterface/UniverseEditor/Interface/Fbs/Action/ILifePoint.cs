using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F6 RID: 27126
	public struct ILifePoint : IFlatbufferObject
	{
		// Token: 0x1700C93C RID: 51516
		// (get) Token: 0x0602F74B RID: 194379 RVA: 0x00676930 File Offset: 0x00674B30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F74C RID: 194380 RVA: 0x0067693D File Offset: 0x00674B3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F74D RID: 194381 RVA: 0x00676944 File Offset: 0x00674B44
		public static ILifePoint GetRootAsILifePoint(ByteBuffer _bb)
		{
			return ILifePoint.GetRootAsILifePoint(_bb, default(ILifePoint));
		}

		// Token: 0x0602F74E RID: 194382 RVA: 0x00676960 File Offset: 0x00674B60
		public static ILifePoint GetRootAsILifePoint(ByteBuffer _bb, ILifePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F74F RID: 194383 RVA: 0x0067697D File Offset: 0x00674B7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F750 RID: 194384 RVA: 0x0067698C File Offset: 0x00674B8C
		public ILifePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C93D RID: 51517
		// (get) Token: 0x0602F751 RID: 194385 RVA: 0x0067699C File Offset: 0x00674B9C
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C93E RID: 51518
		// (get) Token: 0x0602F752 RID: 194386 RVA: 0x006769D8 File Offset: 0x00674BD8
		public ILifePointColorBoard? ColorBoard
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ILifePointColorBoard?(default(ILifePointColorBoard).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C93F RID: 51519
		// (get) Token: 0x0602F753 RID: 194387 RVA: 0x00676A38 File Offset: 0x00674C38
		public int StepLimit
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C940 RID: 51520
		// (get) Token: 0x0602F754 RID: 194388 RVA: 0x00676A74 File Offset: 0x00674C74
		public string TidDesc
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

		// Token: 0x0602F755 RID: 194389 RVA: 0x00676AAC File Offset: 0x00674CAC
		public Span<byte> GetTidDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602F756 RID: 194390 RVA: 0x00676ABC File Offset: 0x00674CBC
		public byte[] GetTidDescArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0602F757 RID: 194391 RVA: 0x00676ACC File Offset: 0x00674CCC
		public ILifePointMaxStepRewardRuleItem? MaxStepRewardRule(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ILifePointMaxStepRewardRuleItem?(default(ILifePointMaxStepRewardRuleItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C941 RID: 51521
		// (get) Token: 0x0602F758 RID: 194392 RVA: 0x00676B30 File Offset: 0x00674D30
		public int MaxStepRewardRuleLength
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

		// Token: 0x1700C942 RID: 51522
		// (get) Token: 0x0602F759 RID: 194393 RVA: 0x00676B5C File Offset: 0x00674D5C
		public bool CloseUiAfterCompletion
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C943 RID: 51523
		// (get) Token: 0x0602F75A RID: 194394 RVA: 0x00676B9C File Offset: 0x00674D9C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F75B RID: 194395 RVA: 0x00676BDC File Offset: 0x00674DDC
		public static Offset<ILifePoint> CreateILifePoint(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, Offset<ILifePointColorBoard> ColorBoardOffset = default(Offset<ILifePointColorBoard>), int StepLimit = 0, StringOffset TidDescOffset = default(StringOffset), VectorOffset MaxStepRewardRuleOffset = default(VectorOffset), bool CloseUiAfterCompletion = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			ILifePoint.AddMaxStepRewardRule(builder, MaxStepRewardRuleOffset);
			ILifePoint.AddTidDesc(builder, TidDescOffset);
			ILifePoint.AddStepLimit(builder, StepLimit);
			ILifePoint.AddColorBoard(builder, ColorBoardOffset);
			ILifePoint.AddNullMask(builder, NullMask);
			ILifePoint.AddCloseUiAfterCompletion(builder, CloseUiAfterCompletion);
			ILifePoint.AddType(builder, Type);
			return ILifePoint.EndILifePoint(builder);
		}

		// Token: 0x0602F75C RID: 194396 RVA: 0x00676C2B File Offset: 0x00674E2B
		public static void StartILifePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602F75D RID: 194397 RVA: 0x00676C34 File Offset: 0x00674E34
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F75E RID: 194398 RVA: 0x00676C3F File Offset: 0x00674E3F
		public static void AddColorBoard(FlatBufferBuilder builder, Offset<ILifePointColorBoard> colorBoardOffset)
		{
			builder.AddOffset(1, colorBoardOffset.Value, 0);
		}

		// Token: 0x0602F75F RID: 194399 RVA: 0x00676C4F File Offset: 0x00674E4F
		public static void AddStepLimit(FlatBufferBuilder builder, int stepLimit)
		{
			builder.AddInt(2, stepLimit, 0);
		}

		// Token: 0x0602F760 RID: 194400 RVA: 0x00676C5A File Offset: 0x00674E5A
		public static void AddTidDesc(FlatBufferBuilder builder, StringOffset tidDescOffset)
		{
			builder.AddOffset(3, tidDescOffset.Value, 0);
		}

		// Token: 0x0602F761 RID: 194401 RVA: 0x00676C6A File Offset: 0x00674E6A
		public static void AddMaxStepRewardRule(FlatBufferBuilder builder, VectorOffset maxStepRewardRuleOffset)
		{
			builder.AddOffset(4, maxStepRewardRuleOffset.Value, 0);
		}

		// Token: 0x0602F762 RID: 194402 RVA: 0x00676C7C File Offset: 0x00674E7C
		public static VectorOffset CreateMaxStepRewardRuleVector(FlatBufferBuilder builder, Offset<ILifePointMaxStepRewardRuleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F763 RID: 194403 RVA: 0x00676CBC File Offset: 0x00674EBC
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, Offset<ILifePointMaxStepRewardRuleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILifePointMaxStepRewardRuleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F764 RID: 194404 RVA: 0x00676CD6 File Offset: 0x00674ED6
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILifePointMaxStepRewardRuleItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILifePointMaxStepRewardRuleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F765 RID: 194405 RVA: 0x00676CF4 File Offset: 0x00674EF4
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILifePointMaxStepRewardRuleItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F766 RID: 194406 RVA: 0x00676D0D File Offset: 0x00674F0D
		public static void StartMaxStepRewardRuleVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F767 RID: 194407 RVA: 0x00676D18 File Offset: 0x00674F18
		public static void AddCloseUiAfterCompletion(FlatBufferBuilder builder, bool closeUiAfterCompletion)
		{
			builder.AddBool(5, closeUiAfterCompletion, false);
		}

		// Token: 0x0602F768 RID: 194408 RVA: 0x00676D23 File Offset: 0x00674F23
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602F769 RID: 194409 RVA: 0x00676D2E File Offset: 0x00674F2E
		public static Offset<ILifePoint> EndILifePoint(FlatBufferBuilder builder)
		{
			return new Offset<ILifePoint>(builder.EndTable());
		}

		// Token: 0x0602F76A RID: 194410 RVA: 0x00676D3C File Offset: 0x00674F3C
		public ILifePointT UnPack()
		{
			ILifePointT lifePointT = new ILifePointT();
			this.UnPackTo(lifePointT);
			return lifePointT;
		}

		// Token: 0x0602F76B RID: 194411 RVA: 0x00676D58 File Offset: 0x00674F58
		public void UnPackTo(ILifePointT _o)
		{
			_o.Type = this.Type;
			_o.ColorBoard = ((this.ColorBoard != null) ? this.ColorBoard.Value.UnPack() : null);
			_o.StepLimit = this.StepLimit;
			_o.TidDesc = this.TidDesc;
			_o.MaxStepRewardRule = new List<ILifePointMaxStepRewardRuleItemT>();
			for (int i = 0; i < this.MaxStepRewardRuleLength; i++)
			{
				_o.MaxStepRewardRule.Add((this.MaxStepRewardRule(i) != null) ? this.MaxStepRewardRule(i).Value.UnPack() : null);
			}
			_o.CloseUiAfterCompletion = this.CloseUiAfterCompletion;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F76C RID: 194412 RVA: 0x00676E24 File Offset: 0x00675024
		public static Offset<ILifePoint> Pack(FlatBufferBuilder builder, ILifePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILifePoint>);
			}
			Offset<ILifePointColorBoard> colorBoardOffset = (_o.ColorBoard == null) ? default(Offset<ILifePointColorBoard>) : ILifePointColorBoard.Pack(builder, _o.ColorBoard);
			StringOffset tidDescOffset = (_o.TidDesc == null) ? default(StringOffset) : builder.CreateString(_o.TidDesc);
			VectorOffset maxStepRewardRuleOffset = default(VectorOffset);
			if (_o.MaxStepRewardRule != null)
			{
				Offset<ILifePointMaxStepRewardRuleItem>[] array = new Offset<ILifePointMaxStepRewardRuleItem>[_o.MaxStepRewardRule.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILifePointMaxStepRewardRuleItem.Pack(builder, _o.MaxStepRewardRule[i]);
				}
				maxStepRewardRuleOffset = ILifePoint.CreateMaxStepRewardRuleVector(builder, array);
			}
			return ILifePoint.CreateILifePoint(builder, _o.Type, colorBoardOffset, _o.StepLimit, tidDescOffset, maxStepRewardRuleOffset, _o.CloseUiAfterCompletion, _o.NullMask);
		}

		// Token: 0x040111F1 RID: 70129
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007160 RID: 29024
	public struct ILongPressInteractConfig : IFlatbufferObject
	{
		// Token: 0x1700D46B RID: 54379
		// (get) Token: 0x060326DA RID: 206554 RVA: 0x006D0C47 File Offset: 0x006CEE47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060326DB RID: 206555 RVA: 0x006D0C54 File Offset: 0x006CEE54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060326DC RID: 206556 RVA: 0x006D0C5C File Offset: 0x006CEE5C
		public static ILongPressInteractConfig GetRootAsILongPressInteractConfig(ByteBuffer _bb)
		{
			return ILongPressInteractConfig.GetRootAsILongPressInteractConfig(_bb, default(ILongPressInteractConfig));
		}

		// Token: 0x060326DD RID: 206557 RVA: 0x006D0C78 File Offset: 0x006CEE78
		public static ILongPressInteractConfig GetRootAsILongPressInteractConfig(ByteBuffer _bb, ILongPressInteractConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060326DE RID: 206558 RVA: 0x006D0C95 File Offset: 0x006CEE95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060326DF RID: 206559 RVA: 0x006D0CA4 File Offset: 0x006CEEA4
		public ILongPressInteractConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D46C RID: 54380
		// (get) Token: 0x060326E0 RID: 206560 RVA: 0x006D0CB4 File Offset: 0x006CEEB4
		public float PressDuration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D46D RID: 54381
		// (get) Token: 0x060326E1 RID: 206561 RVA: 0x006D0CF4 File Offset: 0x006CEEF4
		public ILongPressEffectConfig? PressEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ILongPressEffectConfig?(default(ILongPressEffectConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D46E RID: 54382
		// (get) Token: 0x060326E2 RID: 206562 RVA: 0x006D0D54 File Offset: 0x006CEF54
		public TLongPressInteractStyleConfig StyleType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TLongPressInteractStyleConfig.NONE;
				}
				return (TLongPressInteractStyleConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060326E3 RID: 206563 RVA: 0x006D0D90 File Offset: 0x006CEF90
		public TTable? Style<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060326E4 RID: 206564 RVA: 0x006D0DD8 File Offset: 0x006CEFD8
		public ILongPressInteractStyleConfigDefault StyleAsILongPressInteractStyleConfigDefault()
		{
			return this.Style<ILongPressInteractStyleConfigDefault>().Value;
		}

		// Token: 0x060326E5 RID: 206565 RVA: 0x006D0DF4 File Offset: 0x006CEFF4
		public ILongPressInteractStyleConfigTimeBackInteract StyleAsILongPressInteractStyleConfigTimeBackInteract()
		{
			return this.Style<ILongPressInteractStyleConfigTimeBackInteract>().Value;
		}

		// Token: 0x060326E6 RID: 206566 RVA: 0x006D0E10 File Offset: 0x006CF010
		public ILongPressInteractStyleCoreFix StyleAsILongPressInteractStyleCoreFix()
		{
			return this.Style<ILongPressInteractStyleCoreFix>().Value;
		}

		// Token: 0x060326E7 RID: 206567 RVA: 0x006D0E2C File Offset: 0x006CF02C
		public ILongPressInteractStyleSwordRider StyleAsILongPressInteractStyleSwordRider()
		{
			return this.Style<ILongPressInteractStyleSwordRider>().Value;
		}

		// Token: 0x1700D46F RID: 54383
		// (get) Token: 0x060326E8 RID: 206568 RVA: 0x006D0E48 File Offset: 0x006CF048
		public bool ResetFromCurrentProgress
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D470 RID: 54384
		// (get) Token: 0x060326E9 RID: 206569 RVA: 0x006D0E88 File Offset: 0x006CF088
		public ILongPressButtonActionMapping? LongPressButtonActionMapping
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ILongPressButtonActionMapping?(default(ILongPressButtonActionMapping).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060326EA RID: 206570 RVA: 0x006D0EE8 File Offset: 0x006CF0E8
		public IActionInfo? LongPressStartActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D471 RID: 54385
		// (get) Token: 0x060326EB RID: 206571 RVA: 0x006D0F4C File Offset: 0x006CF14C
		public int LongPressStartActionsLength
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

		// Token: 0x060326EC RID: 206572 RVA: 0x006D0F78 File Offset: 0x006CF178
		public IActionInfo? LongPressInterruptedActions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D472 RID: 54386
		// (get) Token: 0x060326ED RID: 206573 RVA: 0x006D0FDC File Offset: 0x006CF1DC
		public int LongPressInterruptedActionsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060326EE RID: 206574 RVA: 0x006D1008 File Offset: 0x006CF208
		public IActionInfo? LongPressSuccessActions(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D473 RID: 54387
		// (get) Token: 0x060326EF RID: 206575 RVA: 0x006D106C File Offset: 0x006CF26C
		public int LongPressSuccessActionsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060326F0 RID: 206576 RVA: 0x006D1098 File Offset: 0x006CF298
		public ILongPressProgressAction? LongPressProgressActions(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new ILongPressProgressAction?(default(ILongPressProgressAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D474 RID: 54388
		// (get) Token: 0x060326F1 RID: 206577 RVA: 0x006D10FC File Offset: 0x006CF2FC
		public int LongPressProgressActionsLength
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

		// Token: 0x1700D475 RID: 54389
		// (get) Token: 0x060326F2 RID: 206578 RVA: 0x006D1128 File Offset: 0x006CF328
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

		// Token: 0x060326F3 RID: 206579 RVA: 0x006D1168 File Offset: 0x006CF368
		public static Offset<ILongPressInteractConfig> CreateILongPressInteractConfig(FlatBufferBuilder builder, float PressDuration = 0f, Offset<ILongPressEffectConfig> PressEffectOffset = default(Offset<ILongPressEffectConfig>), TLongPressInteractStyleConfig Style_type = TLongPressInteractStyleConfig.NONE, int StyleOffset = 0, bool ResetFromCurrentProgress = false, Offset<ILongPressButtonActionMapping> LongPressButtonActionMappingOffset = default(Offset<ILongPressButtonActionMapping>), VectorOffset LongPressStartActionsOffset = default(VectorOffset), VectorOffset LongPressInterruptedActionsOffset = default(VectorOffset), VectorOffset LongPressSuccessActionsOffset = default(VectorOffset), VectorOffset LongPressProgressActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(11);
			ILongPressInteractConfig.AddLongPressProgressActions(builder, LongPressProgressActionsOffset);
			ILongPressInteractConfig.AddLongPressSuccessActions(builder, LongPressSuccessActionsOffset);
			ILongPressInteractConfig.AddLongPressInterruptedActions(builder, LongPressInterruptedActionsOffset);
			ILongPressInteractConfig.AddLongPressStartActions(builder, LongPressStartActionsOffset);
			ILongPressInteractConfig.AddLongPressButtonActionMapping(builder, LongPressButtonActionMappingOffset);
			ILongPressInteractConfig.AddStyle(builder, StyleOffset);
			ILongPressInteractConfig.AddPressEffect(builder, PressEffectOffset);
			ILongPressInteractConfig.AddPressDuration(builder, PressDuration);
			ILongPressInteractConfig.AddNullMask(builder, NullMask);
			ILongPressInteractConfig.AddResetFromCurrentProgress(builder, ResetFromCurrentProgress);
			ILongPressInteractConfig.AddStyleType(builder, Style_type);
			return ILongPressInteractConfig.EndILongPressInteractConfig(builder);
		}

		// Token: 0x060326F4 RID: 206580 RVA: 0x006D11D8 File Offset: 0x006CF3D8
		public static void StartILongPressInteractConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x060326F5 RID: 206581 RVA: 0x006D11E2 File Offset: 0x006CF3E2
		public static void AddPressDuration(FlatBufferBuilder builder, float pressDuration)
		{
			builder.AddFloat(0, pressDuration, 0.0);
		}

		// Token: 0x060326F6 RID: 206582 RVA: 0x006D11F5 File Offset: 0x006CF3F5
		public static void AddPressEffect(FlatBufferBuilder builder, Offset<ILongPressEffectConfig> pressEffectOffset)
		{
			builder.AddOffset(1, pressEffectOffset.Value, 0);
		}

		// Token: 0x060326F7 RID: 206583 RVA: 0x006D1205 File Offset: 0x006CF405
		public static void AddStyleType(FlatBufferBuilder builder, TLongPressInteractStyleConfig styleType)
		{
			builder.AddByte(2, (byte)styleType, 0);
		}

		// Token: 0x060326F8 RID: 206584 RVA: 0x006D1210 File Offset: 0x006CF410
		public static void AddStyle(FlatBufferBuilder builder, int styleOffset)
		{
			builder.AddOffset(3, styleOffset, 0);
		}

		// Token: 0x060326F9 RID: 206585 RVA: 0x006D121B File Offset: 0x006CF41B
		public static void AddResetFromCurrentProgress(FlatBufferBuilder builder, bool resetFromCurrentProgress)
		{
			builder.AddBool(4, resetFromCurrentProgress, false);
		}

		// Token: 0x060326FA RID: 206586 RVA: 0x006D1226 File Offset: 0x006CF426
		public static void AddLongPressButtonActionMapping(FlatBufferBuilder builder, Offset<ILongPressButtonActionMapping> longPressButtonActionMappingOffset)
		{
			builder.AddOffset(5, longPressButtonActionMappingOffset.Value, 0);
		}

		// Token: 0x060326FB RID: 206587 RVA: 0x006D1236 File Offset: 0x006CF436
		public static void AddLongPressStartActions(FlatBufferBuilder builder, VectorOffset longPressStartActionsOffset)
		{
			builder.AddOffset(6, longPressStartActionsOffset.Value, 0);
		}

		// Token: 0x060326FC RID: 206588 RVA: 0x006D1248 File Offset: 0x006CF448
		public static VectorOffset CreateLongPressStartActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060326FD RID: 206589 RVA: 0x006D1288 File Offset: 0x006CF488
		public static VectorOffset CreateLongPressStartActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060326FE RID: 206590 RVA: 0x006D12A2 File Offset: 0x006CF4A2
		public static VectorOffset CreateLongPressStartActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060326FF RID: 206591 RVA: 0x006D12C0 File Offset: 0x006CF4C0
		public static VectorOffset CreateLongPressStartActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032700 RID: 206592 RVA: 0x006D12D9 File Offset: 0x006CF4D9
		public static void StartLongPressStartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032701 RID: 206593 RVA: 0x006D12E4 File Offset: 0x006CF4E4
		public static void AddLongPressInterruptedActions(FlatBufferBuilder builder, VectorOffset longPressInterruptedActionsOffset)
		{
			builder.AddOffset(7, longPressInterruptedActionsOffset.Value, 0);
		}

		// Token: 0x06032702 RID: 206594 RVA: 0x006D12F4 File Offset: 0x006CF4F4
		public static VectorOffset CreateLongPressInterruptedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032703 RID: 206595 RVA: 0x006D1334 File Offset: 0x006CF534
		public static VectorOffset CreateLongPressInterruptedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032704 RID: 206596 RVA: 0x006D134E File Offset: 0x006CF54E
		public static VectorOffset CreateLongPressInterruptedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032705 RID: 206597 RVA: 0x006D136C File Offset: 0x006CF56C
		public static VectorOffset CreateLongPressInterruptedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032706 RID: 206598 RVA: 0x006D1385 File Offset: 0x006CF585
		public static void StartLongPressInterruptedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032707 RID: 206599 RVA: 0x006D1390 File Offset: 0x006CF590
		public static void AddLongPressSuccessActions(FlatBufferBuilder builder, VectorOffset longPressSuccessActionsOffset)
		{
			builder.AddOffset(8, longPressSuccessActionsOffset.Value, 0);
		}

		// Token: 0x06032708 RID: 206600 RVA: 0x006D13A0 File Offset: 0x006CF5A0
		public static VectorOffset CreateLongPressSuccessActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032709 RID: 206601 RVA: 0x006D13E0 File Offset: 0x006CF5E0
		public static VectorOffset CreateLongPressSuccessActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603270A RID: 206602 RVA: 0x006D13FA File Offset: 0x006CF5FA
		public static VectorOffset CreateLongPressSuccessActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603270B RID: 206603 RVA: 0x006D1418 File Offset: 0x006CF618
		public static VectorOffset CreateLongPressSuccessActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603270C RID: 206604 RVA: 0x006D1431 File Offset: 0x006CF631
		public static void StartLongPressSuccessActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603270D RID: 206605 RVA: 0x006D143C File Offset: 0x006CF63C
		public static void AddLongPressProgressActions(FlatBufferBuilder builder, VectorOffset longPressProgressActionsOffset)
		{
			builder.AddOffset(9, longPressProgressActionsOffset.Value, 0);
		}

		// Token: 0x0603270E RID: 206606 RVA: 0x006D1450 File Offset: 0x006CF650
		public static VectorOffset CreateLongPressProgressActionsVector(FlatBufferBuilder builder, Offset<ILongPressProgressAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603270F RID: 206607 RVA: 0x006D1490 File Offset: 0x006CF690
		public static VectorOffset CreateLongPressProgressActionsVectorBlock(FlatBufferBuilder builder, Offset<ILongPressProgressAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILongPressProgressAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032710 RID: 206608 RVA: 0x006D14AA File Offset: 0x006CF6AA
		public static VectorOffset CreateLongPressProgressActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILongPressProgressAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILongPressProgressAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032711 RID: 206609 RVA: 0x006D14C8 File Offset: 0x006CF6C8
		public static VectorOffset CreateLongPressProgressActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILongPressProgressAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032712 RID: 206610 RVA: 0x006D14E1 File Offset: 0x006CF6E1
		public static void StartLongPressProgressActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032713 RID: 206611 RVA: 0x006D14EC File Offset: 0x006CF6EC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06032714 RID: 206612 RVA: 0x006D14F8 File Offset: 0x006CF6F8
		public static Offset<ILongPressInteractConfig> EndILongPressInteractConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractConfig>(builder.EndTable());
		}

		// Token: 0x06032715 RID: 206613 RVA: 0x006D1508 File Offset: 0x006CF708
		public ILongPressInteractConfigT UnPack()
		{
			ILongPressInteractConfigT longPressInteractConfigT = new ILongPressInteractConfigT();
			this.UnPackTo(longPressInteractConfigT);
			return longPressInteractConfigT;
		}

		// Token: 0x06032716 RID: 206614 RVA: 0x006D1524 File Offset: 0x006CF724
		public void UnPackTo(ILongPressInteractConfigT _o)
		{
			_o.PressDuration = this.PressDuration;
			_o.PressEffect = ((this.PressEffect != null) ? this.PressEffect.Value.UnPack() : null);
			_o.Style = new TLongPressInteractStyleConfigUnion();
			_o.Style.Type = this.StyleType;
			switch (this.StyleType)
			{
			case TLongPressInteractStyleConfig.ILongPressInteractStyleConfigDefault:
				_o.Style.Value = ((this.Style<ILongPressInteractStyleConfigDefault>() != null) ? this.Style<ILongPressInteractStyleConfigDefault>().Value.UnPack() : null);
				break;
			case TLongPressInteractStyleConfig.ILongPressInteractStyleConfigTimeBackInteract:
				_o.Style.Value = ((this.Style<ILongPressInteractStyleConfigTimeBackInteract>() != null) ? this.Style<ILongPressInteractStyleConfigTimeBackInteract>().Value.UnPack() : null);
				break;
			case TLongPressInteractStyleConfig.ILongPressInteractStyleCoreFix:
				_o.Style.Value = ((this.Style<ILongPressInteractStyleCoreFix>() != null) ? this.Style<ILongPressInteractStyleCoreFix>().Value.UnPack() : null);
				break;
			case TLongPressInteractStyleConfig.ILongPressInteractStyleSwordRider:
				_o.Style.Value = ((this.Style<ILongPressInteractStyleSwordRider>() != null) ? this.Style<ILongPressInteractStyleSwordRider>().Value.UnPack() : null);
				break;
			}
			_o.ResetFromCurrentProgress = this.ResetFromCurrentProgress;
			_o.LongPressButtonActionMapping = ((this.LongPressButtonActionMapping != null) ? this.LongPressButtonActionMapping.Value.UnPack() : null);
			_o.LongPressStartActions = new List<IActionInfoT>();
			for (int i = 0; i < this.LongPressStartActionsLength; i++)
			{
				_o.LongPressStartActions.Add((this.LongPressStartActions(i) != null) ? this.LongPressStartActions(i).Value.UnPack() : null);
			}
			_o.LongPressInterruptedActions = new List<IActionInfoT>();
			for (int j = 0; j < this.LongPressInterruptedActionsLength; j++)
			{
				_o.LongPressInterruptedActions.Add((this.LongPressInterruptedActions(j) != null) ? this.LongPressInterruptedActions(j).Value.UnPack() : null);
			}
			_o.LongPressSuccessActions = new List<IActionInfoT>();
			for (int k = 0; k < this.LongPressSuccessActionsLength; k++)
			{
				_o.LongPressSuccessActions.Add((this.LongPressSuccessActions(k) != null) ? this.LongPressSuccessActions(k).Value.UnPack() : null);
			}
			_o.LongPressProgressActions = new List<ILongPressProgressActionT>();
			for (int l = 0; l < this.LongPressProgressActionsLength; l++)
			{
				_o.LongPressProgressActions.Add((this.LongPressProgressActions(l) != null) ? this.LongPressProgressActions(l).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032717 RID: 206615 RVA: 0x006D1848 File Offset: 0x006CFA48
		public static Offset<ILongPressInteractConfig> Pack(FlatBufferBuilder builder, ILongPressInteractConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractConfig>);
			}
			Offset<ILongPressEffectConfig> pressEffectOffset = (_o.PressEffect == null) ? default(Offset<ILongPressEffectConfig>) : ILongPressEffectConfig.Pack(builder, _o.PressEffect);
			TLongPressInteractStyleConfig style_type = (_o.Style == null) ? TLongPressInteractStyleConfig.NONE : _o.Style.Type;
			int styleOffset = (_o.Style == null) ? 0 : TLongPressInteractStyleConfigUnion.Pack(builder, _o.Style);
			Offset<ILongPressButtonActionMapping> longPressButtonActionMappingOffset = (_o.LongPressButtonActionMapping == null) ? default(Offset<ILongPressButtonActionMapping>) : ILongPressButtonActionMapping.Pack(builder, _o.LongPressButtonActionMapping);
			VectorOffset longPressStartActionsOffset = default(VectorOffset);
			if (_o.LongPressStartActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.LongPressStartActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.LongPressStartActions[i]);
				}
				longPressStartActionsOffset = ILongPressInteractConfig.CreateLongPressStartActionsVector(builder, array);
			}
			VectorOffset longPressInterruptedActionsOffset = default(VectorOffset);
			if (_o.LongPressInterruptedActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.LongPressInterruptedActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.LongPressInterruptedActions[j]);
				}
				longPressInterruptedActionsOffset = ILongPressInteractConfig.CreateLongPressInterruptedActionsVector(builder, array2);
			}
			VectorOffset longPressSuccessActionsOffset = default(VectorOffset);
			if (_o.LongPressSuccessActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.LongPressSuccessActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.LongPressSuccessActions[k]);
				}
				longPressSuccessActionsOffset = ILongPressInteractConfig.CreateLongPressSuccessActionsVector(builder, array3);
			}
			VectorOffset longPressProgressActionsOffset = default(VectorOffset);
			if (_o.LongPressProgressActions != null)
			{
				Offset<ILongPressProgressAction>[] array4 = new Offset<ILongPressProgressAction>[_o.LongPressProgressActions.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = ILongPressProgressAction.Pack(builder, _o.LongPressProgressActions[l]);
				}
				longPressProgressActionsOffset = ILongPressInteractConfig.CreateLongPressProgressActionsVector(builder, array4);
			}
			return ILongPressInteractConfig.CreateILongPressInteractConfig(builder, _o.PressDuration, pressEffectOffset, style_type, styleOffset, _o.ResetFromCurrentProgress, longPressButtonActionMappingOffset, longPressStartActionsOffset, longPressInterruptedActionsOffset, longPressSuccessActionsOffset, longPressProgressActionsOffset, _o.NullMask);
		}

		// Token: 0x04012149 RID: 74057
		private Table __p;
	}
}

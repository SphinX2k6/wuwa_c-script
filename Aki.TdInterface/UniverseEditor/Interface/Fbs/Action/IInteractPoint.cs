using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006999 RID: 27033
	public struct IInteractPoint : IFlatbufferObject
	{
		// Token: 0x1700C88B RID: 51339
		// (get) Token: 0x0602F3A3 RID: 193443 RVA: 0x0066EEF5 File Offset: 0x0066D0F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F3A4 RID: 193444 RVA: 0x0066EF02 File Offset: 0x0066D102
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F3A5 RID: 193445 RVA: 0x0066EF0C File Offset: 0x0066D10C
		public static IInteractPoint GetRootAsIInteractPoint(ByteBuffer _bb)
		{
			return IInteractPoint.GetRootAsIInteractPoint(_bb, default(IInteractPoint));
		}

		// Token: 0x0602F3A6 RID: 193446 RVA: 0x0066EF28 File Offset: 0x0066D128
		public static IInteractPoint GetRootAsIInteractPoint(ByteBuffer _bb, IInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F3A7 RID: 193447 RVA: 0x0066EF45 File Offset: 0x0066D145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F3A8 RID: 193448 RVA: 0x0066EF54 File Offset: 0x0066D154
		public IInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C88C RID: 51340
		// (get) Token: 0x0602F3A9 RID: 193449 RVA: 0x0066EF64 File Offset: 0x0066D164
		public int Tag
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F3AA RID: 193450 RVA: 0x0066EFA0 File Offset: 0x0066D1A0
		public TInteractEffect InteractEffectsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TInteractEffect.NONE;
			}
			return (TInteractEffect)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700C88D RID: 51341
		// (get) Token: 0x0602F3AB RID: 193451 RVA: 0x0066EFE0 File Offset: 0x0066D1E0
		public int InteractEffectsTypeLength
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

		// Token: 0x0602F3AC RID: 193452 RVA: 0x0066F00B File Offset: 0x0066D20B
		public Span<TInteractEffect> GetInteractEffectsTypeBytes()
		{
			return this.__p.__vector_as_span<TInteractEffect>(6, 1);
		}

		// Token: 0x0602F3AD RID: 193453 RVA: 0x0066F01C File Offset: 0x0066D21C
		public TInteractEffect[] GetInteractEffectsTypeArray()
		{
			int num = this.__p.__offset(6);
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

		// Token: 0x0602F3AE RID: 193454 RVA: 0x0066F088 File Offset: 0x0066D288
		public TTable? InteractEffects<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700C88E RID: 51342
		// (get) Token: 0x0602F3AF RID: 193455 RVA: 0x0066F0D0 File Offset: 0x0066D2D0
		public int InteractEffectsLength
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

		// Token: 0x1700C88F RID: 51343
		// (get) Token: 0x0602F3B0 RID: 193456 RVA: 0x0066F0FC File Offset: 0x0066D2FC
		public bool IsValidPoint
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C890 RID: 51344
		// (get) Token: 0x0602F3B1 RID: 193457 RVA: 0x0066F13C File Offset: 0x0066D33C
		public float ProtectTime
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

		// Token: 0x1700C891 RID: 51345
		// (get) Token: 0x0602F3B2 RID: 193458 RVA: 0x0066F180 File Offset: 0x0066D380
		public bool CancelRaycast
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C892 RID: 51346
		// (get) Token: 0x0602F3B3 RID: 193459 RVA: 0x0066F1C0 File Offset: 0x0066D3C0
		public IDragInteractPointInteraction? InteractionConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IDragInteractPointInteraction?(default(IDragInteractPointInteraction).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C893 RID: 51347
		// (get) Token: 0x0602F3B4 RID: 193460 RVA: 0x0066F220 File Offset: 0x0066D420
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F3B5 RID: 193461 RVA: 0x0066F260 File Offset: 0x0066D460
		public static Offset<IInteractPoint> CreateIInteractPoint(FlatBufferBuilder builder, int Tag = 0, VectorOffset InteractEffects_typeOffset = default(VectorOffset), VectorOffset InteractEffectsOffset = default(VectorOffset), bool IsValidPoint = false, float ProtectTime = 0f, bool CancelRaycast = false, Offset<IDragInteractPointInteraction> InteractionConfigOffset = default(Offset<IDragInteractPointInteraction>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IInteractPoint.AddInteractionConfig(builder, InteractionConfigOffset);
			IInteractPoint.AddProtectTime(builder, ProtectTime);
			IInteractPoint.AddInteractEffects(builder, InteractEffectsOffset);
			IInteractPoint.AddInteractEffectsType(builder, InteractEffects_typeOffset);
			IInteractPoint.AddTag(builder, Tag);
			IInteractPoint.AddNullMask(builder, NullMask);
			IInteractPoint.AddCancelRaycast(builder, CancelRaycast);
			IInteractPoint.AddIsValidPoint(builder, IsValidPoint);
			return IInteractPoint.EndIInteractPoint(builder);
		}

		// Token: 0x0602F3B6 RID: 193462 RVA: 0x0066F2B7 File Offset: 0x0066D4B7
		public static void StartIInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602F3B7 RID: 193463 RVA: 0x0066F2C0 File Offset: 0x0066D4C0
		public static void AddTag(FlatBufferBuilder builder, int tag)
		{
			builder.AddInt(0, tag, 0);
		}

		// Token: 0x0602F3B8 RID: 193464 RVA: 0x0066F2CB File Offset: 0x0066D4CB
		public static void AddInteractEffectsType(FlatBufferBuilder builder, VectorOffset interactEffectsTypeOffset)
		{
			builder.AddOffset(1, interactEffectsTypeOffset.Value, 0);
		}

		// Token: 0x0602F3B9 RID: 193465 RVA: 0x0066F2DC File Offset: 0x0066D4DC
		public static VectorOffset CreateInteractEffectsTypeVector(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F3BA RID: 193466 RVA: 0x0066F313 File Offset: 0x0066D513
		public static VectorOffset CreateInteractEffectsTypeVectorBlock(FlatBufferBuilder builder, TInteractEffect[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F3BB RID: 193467 RVA: 0x0066F32D File Offset: 0x0066D52D
		public static VectorOffset CreateInteractEffectsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TInteractEffect> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TInteractEffect>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F3BC RID: 193468 RVA: 0x0066F34B File Offset: 0x0066D54B
		public static VectorOffset CreateInteractEffectsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TInteractEffect>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F3BD RID: 193469 RVA: 0x0066F364 File Offset: 0x0066D564
		public static void StartInteractEffectsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602F3BE RID: 193470 RVA: 0x0066F36F File Offset: 0x0066D56F
		public static void AddInteractEffects(FlatBufferBuilder builder, VectorOffset interactEffectsOffset)
		{
			builder.AddOffset(2, interactEffectsOffset.Value, 0);
		}

		// Token: 0x0602F3BF RID: 193471 RVA: 0x0066F380 File Offset: 0x0066D580
		public static VectorOffset CreateInteractEffectsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F3C0 RID: 193472 RVA: 0x0066F3B7 File Offset: 0x0066D5B7
		public static VectorOffset CreateInteractEffectsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F3C1 RID: 193473 RVA: 0x0066F3D1 File Offset: 0x0066D5D1
		public static VectorOffset CreateInteractEffectsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F3C2 RID: 193474 RVA: 0x0066F3EF File Offset: 0x0066D5EF
		public static VectorOffset CreateInteractEffectsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F3C3 RID: 193475 RVA: 0x0066F408 File Offset: 0x0066D608
		public static void StartInteractEffectsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F3C4 RID: 193476 RVA: 0x0066F413 File Offset: 0x0066D613
		public static void AddIsValidPoint(FlatBufferBuilder builder, bool isValidPoint)
		{
			builder.AddBool(3, isValidPoint, false);
		}

		// Token: 0x0602F3C5 RID: 193477 RVA: 0x0066F41E File Offset: 0x0066D61E
		public static void AddProtectTime(FlatBufferBuilder builder, float protectTime)
		{
			builder.AddFloat(4, protectTime, 0.0);
		}

		// Token: 0x0602F3C6 RID: 193478 RVA: 0x0066F431 File Offset: 0x0066D631
		public static void AddCancelRaycast(FlatBufferBuilder builder, bool cancelRaycast)
		{
			builder.AddBool(5, cancelRaycast, false);
		}

		// Token: 0x0602F3C7 RID: 193479 RVA: 0x0066F43C File Offset: 0x0066D63C
		public static void AddInteractionConfig(FlatBufferBuilder builder, Offset<IDragInteractPointInteraction> interactionConfigOffset)
		{
			builder.AddOffset(6, interactionConfigOffset.Value, 0);
		}

		// Token: 0x0602F3C8 RID: 193480 RVA: 0x0066F44C File Offset: 0x0066D64C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602F3C9 RID: 193481 RVA: 0x0066F457 File Offset: 0x0066D657
		public static Offset<IInteractPoint> EndIInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPoint>(builder.EndTable());
		}

		// Token: 0x0602F3CA RID: 193482 RVA: 0x0066F464 File Offset: 0x0066D664
		public IInteractPointT UnPack()
		{
			IInteractPointT interactPointT = new IInteractPointT();
			this.UnPackTo(interactPointT);
			return interactPointT;
		}

		// Token: 0x0602F3CB RID: 193483 RVA: 0x0066F480 File Offset: 0x0066D680
		public void UnPackTo(IInteractPointT _o)
		{
			_o.Tag = this.Tag;
			_o.InteractEffects = new List<TInteractEffectUnion>();
			for (int i = 0; i < this.InteractEffectsLength; i++)
			{
				TInteractEffectUnion tinteractEffectUnion = new TInteractEffectUnion();
				tinteractEffectUnion.Type = this.InteractEffectsType(i);
				switch (this.InteractEffectsType(i))
				{
				case TInteractEffect.IExecuteTag:
					tinteractEffectUnion.Value = ((this.InteractEffects<IExecuteTag>(i) != null) ? this.InteractEffects<IExecuteTag>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.IModifyTipText:
					tinteractEffectUnion.Value = ((this.InteractEffects<IModifyTipText>(i) != null) ? this.InteractEffects<IModifyTipText>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.ITriggerDialogues:
					tinteractEffectUnion.Value = ((this.InteractEffects<ITriggerDialogues>(i) != null) ? this.InteractEffects<ITriggerDialogues>(i).Value.UnPack() : null);
					break;
				case TInteractEffect.ITriggerVoiceDialogues:
					tinteractEffectUnion.Value = ((this.InteractEffects<ITriggerVoiceDialogues>(i) != null) ? this.InteractEffects<ITriggerVoiceDialogues>(i).Value.UnPack() : null);
					break;
				}
				_o.InteractEffects.Add(tinteractEffectUnion);
			}
			_o.IsValidPoint = this.IsValidPoint;
			_o.ProtectTime = this.ProtectTime;
			_o.CancelRaycast = this.CancelRaycast;
			_o.InteractionConfig = ((this.InteractionConfig != null) ? this.InteractionConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F3CC RID: 193484 RVA: 0x0066F638 File Offset: 0x0066D838
		public static Offset<IInteractPoint> Pack(FlatBufferBuilder builder, IInteractPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPoint>);
			}
			VectorOffset interactEffects_typeOffset = default(VectorOffset);
			if (_o.InteractEffects != null)
			{
				TInteractEffect[] array = new TInteractEffect[_o.InteractEffects.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.InteractEffects[i].Type;
				}
				interactEffects_typeOffset = IInteractPoint.CreateInteractEffectsTypeVector(builder, array);
			}
			VectorOffset interactEffectsOffset = default(VectorOffset);
			if (_o.InteractEffects != null)
			{
				int[] array2 = new int[_o.InteractEffects.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TInteractEffectUnion.Pack(builder, _o.InteractEffects[j]);
				}
				interactEffectsOffset = IInteractPoint.CreateInteractEffectsVector(builder, array2);
			}
			Offset<IDragInteractPointInteraction> interactionConfigOffset = (_o.InteractionConfig == null) ? default(Offset<IDragInteractPointInteraction>) : IDragInteractPointInteraction.Pack(builder, _o.InteractionConfig);
			return IInteractPoint.CreateIInteractPoint(builder, _o.Tag, interactEffects_typeOffset, interactEffectsOffset, _o.IsValidPoint, _o.ProtectTime, _o.CancelRaycast, interactionConfigOffset, _o.NullMask);
		}

		// Token: 0x04011138 RID: 69944
		private Table __p;
	}
}

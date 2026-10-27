using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060CE RID: 24782
	public struct IActorInitialState : IFlatbufferObject
	{
		// Token: 0x1700B697 RID: 46743
		// (get) Token: 0x0602A504 RID: 173316 RVA: 0x005D4D97 File Offset: 0x005D2F97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A505 RID: 173317 RVA: 0x005D4DA4 File Offset: 0x005D2FA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A506 RID: 173318 RVA: 0x005D4DAC File Offset: 0x005D2FAC
		public static IActorInitialState GetRootAsIActorInitialState(ByteBuffer _bb)
		{
			return IActorInitialState.GetRootAsIActorInitialState(_bb, default(IActorInitialState));
		}

		// Token: 0x0602A507 RID: 173319 RVA: 0x005D4DC8 File Offset: 0x005D2FC8
		public static IActorInitialState GetRootAsIActorInitialState(ByteBuffer _bb, IActorInitialState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A508 RID: 173320 RVA: 0x005D4DE5 File Offset: 0x005D2FE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A509 RID: 173321 RVA: 0x005D4DF4 File Offset: 0x005D2FF4
		public IActorInitialState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B698 RID: 46744
		// (get) Token: 0x0602A50A RID: 173322 RVA: 0x005D4E04 File Offset: 0x005D3004
		public IActorInitialMontage? InitialMontage
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IActorInitialMontage?(default(IActorInitialMontage).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B699 RID: 46745
		// (get) Token: 0x0602A50B RID: 173323 RVA: 0x005D4E64 File Offset: 0x005D3064
		public IActorLookAtData_Union InitialLookAtType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return IActorLookAtData_Union.NONE;
				}
				return (IActorLookAtData_Union)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A50C RID: 173324 RVA: 0x005D4EA0 File Offset: 0x005D30A0
		public TTable? InitialLookAt<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A50D RID: 173325 RVA: 0x005D4EE4 File Offset: 0x005D30E4
		public IActorLookAtData InitialLookAtAsIActorLookAtData()
		{
			return this.InitialLookAt<IActorLookAtData>().Value;
		}

		// Token: 0x0602A50E RID: 173326 RVA: 0x005D4F00 File Offset: 0x005D3100
		public IActorLookAtLockable InitialLookAtAsIActorLookAtLockable()
		{
			return this.InitialLookAt<IActorLookAtLockable>().Value;
		}

		// Token: 0x0602A50F RID: 173327 RVA: 0x005D4F1C File Offset: 0x005D311C
		public IActorLookAtTalkerData InitialLookAtAsIActorLookAtTalkerData()
		{
			return this.InitialLookAt<IActorLookAtTalkerData>().Value;
		}

		// Token: 0x0602A510 RID: 173328 RVA: 0x005D4F38 File Offset: 0x005D3138
		public IActorLookAtEmptyData InitialLookAtAsIActorLookAtEmptyData()
		{
			return this.InitialLookAt<IActorLookAtEmptyData>().Value;
		}

		// Token: 0x0602A511 RID: 173329 RVA: 0x005D4F54 File Offset: 0x005D3154
		public IActorLookAtEntityData InitialLookAtAsIActorLookAtEntityData()
		{
			return this.InitialLookAt<IActorLookAtEntityData>().Value;
		}

		// Token: 0x0602A512 RID: 173330 RVA: 0x005D4F70 File Offset: 0x005D3170
		public IActorLookAtPositionData InitialLookAtAsIActorLookAtPositionData()
		{
			return this.InitialLookAt<IActorLookAtPositionData>().Value;
		}

		// Token: 0x0602A513 RID: 173331 RVA: 0x005D4F8C File Offset: 0x005D318C
		public IActorLookAtPlayerData InitialLookAtAsIActorLookAtPlayerData()
		{
			return this.InitialLookAt<IActorLookAtPlayerData>().Value;
		}

		// Token: 0x0602A514 RID: 173332 RVA: 0x005D4FA8 File Offset: 0x005D31A8
		public IActorLookAtOtherActor InitialLookAtAsIActorLookAtOtherActor()
		{
			return this.InitialLookAt<IActorLookAtOtherActor>().Value;
		}

		// Token: 0x0602A515 RID: 173333 RVA: 0x005D4FC4 File Offset: 0x005D31C4
		public IActorLookAtUnLock InitialLookAtAsIActorLookAtUnLock()
		{
			return this.InitialLookAt<IActorLookAtUnLock>().Value;
		}

		// Token: 0x1700B69A RID: 46746
		// (get) Token: 0x0602A516 RID: 173334 RVA: 0x005D4FE0 File Offset: 0x005D31E0
		public IActorInitialEffect? InitialEffects
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IActorInitialEffect?(default(IActorInitialEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B69B RID: 46747
		// (get) Token: 0x0602A517 RID: 173335 RVA: 0x005D5040 File Offset: 0x005D3240
		public int InitialFaceExpressionId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B69C RID: 46748
		// (get) Token: 0x0602A518 RID: 173336 RVA: 0x005D5080 File Offset: 0x005D3280
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

		// Token: 0x0602A519 RID: 173337 RVA: 0x005D50BD File Offset: 0x005D32BD
		public static Offset<IActorInitialState> CreateIActorInitialState(FlatBufferBuilder builder, Offset<IActorInitialMontage> InitialMontageOffset = default(Offset<IActorInitialMontage>), IActorLookAtData_Union InitialLookAt_type = IActorLookAtData_Union.NONE, int InitialLookAtOffset = 0, Offset<IActorInitialEffect> InitialEffectsOffset = default(Offset<IActorInitialEffect>), int InitialFaceExpressionId = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IActorInitialState.AddInitialFaceExpressionId(builder, InitialFaceExpressionId);
			IActorInitialState.AddInitialEffects(builder, InitialEffectsOffset);
			IActorInitialState.AddInitialLookAt(builder, InitialLookAtOffset);
			IActorInitialState.AddInitialMontage(builder, InitialMontageOffset);
			IActorInitialState.AddNullMask(builder, NullMask);
			IActorInitialState.AddInitialLookAtType(builder, InitialLookAt_type);
			return IActorInitialState.EndIActorInitialState(builder);
		}

		// Token: 0x0602A51A RID: 173338 RVA: 0x005D50F9 File Offset: 0x005D32F9
		public static void StartIActorInitialState(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602A51B RID: 173339 RVA: 0x005D5102 File Offset: 0x005D3302
		public static void AddInitialMontage(FlatBufferBuilder builder, Offset<IActorInitialMontage> initialMontageOffset)
		{
			builder.AddOffset(0, initialMontageOffset.Value, 0);
		}

		// Token: 0x0602A51C RID: 173340 RVA: 0x005D5112 File Offset: 0x005D3312
		public static void AddInitialLookAtType(FlatBufferBuilder builder, IActorLookAtData_Union initialLookAtType)
		{
			builder.AddByte(1, (byte)initialLookAtType, 0);
		}

		// Token: 0x0602A51D RID: 173341 RVA: 0x005D511D File Offset: 0x005D331D
		public static void AddInitialLookAt(FlatBufferBuilder builder, int initialLookAtOffset)
		{
			builder.AddOffset(2, initialLookAtOffset, 0);
		}

		// Token: 0x0602A51E RID: 173342 RVA: 0x005D5128 File Offset: 0x005D3328
		public static void AddInitialEffects(FlatBufferBuilder builder, Offset<IActorInitialEffect> initialEffectsOffset)
		{
			builder.AddOffset(3, initialEffectsOffset.Value, 0);
		}

		// Token: 0x0602A51F RID: 173343 RVA: 0x005D5138 File Offset: 0x005D3338
		public static void AddInitialFaceExpressionId(FlatBufferBuilder builder, int initialFaceExpressionId)
		{
			builder.AddInt(4, initialFaceExpressionId, 0);
		}

		// Token: 0x0602A520 RID: 173344 RVA: 0x005D5143 File Offset: 0x005D3343
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602A521 RID: 173345 RVA: 0x005D514E File Offset: 0x005D334E
		public static Offset<IActorInitialState> EndIActorInitialState(FlatBufferBuilder builder)
		{
			return new Offset<IActorInitialState>(builder.EndTable());
		}

		// Token: 0x0602A522 RID: 173346 RVA: 0x005D515C File Offset: 0x005D335C
		public IActorInitialStateT UnPack()
		{
			IActorInitialStateT actorInitialStateT = new IActorInitialStateT();
			this.UnPackTo(actorInitialStateT);
			return actorInitialStateT;
		}

		// Token: 0x0602A523 RID: 173347 RVA: 0x005D5178 File Offset: 0x005D3378
		public void UnPackTo(IActorInitialStateT _o)
		{
			_o.InitialMontage = ((this.InitialMontage != null) ? this.InitialMontage.Value.UnPack() : null);
			_o.InitialLookAt = new IActorLookAtData_UnionUnion();
			_o.InitialLookAt.Type = this.InitialLookAtType;
			switch (this.InitialLookAtType)
			{
			case IActorLookAtData_Union.IActorLookAtData:
				_o.InitialLookAt.Value = ((this.InitialLookAt<IActorLookAtData>() != null) ? this.InitialLookAt<IActorLookAtData>().Value.UnPack() : null);
				break;
			case IActorLookAtData_Union.IActorLookAtLockable:
				_o.InitialLookAt.Value = ((this.InitialLookAt<IActorLookAtLockable>() != null) ? this.InitialLookAt<IActorLookAtLockable>().Value.UnPack() : null);
				break;
			case IActorLookAtData_Union.IActorLookAtTalkerData:
				_o.InitialLookAt.Value = ((this.InitialLookAt<IActorLookAtTalkerData>() != null) ? this.InitialLookAt<IActorLookAtTalkerData>().Value.UnPack() : null);
				break;
			case IActorLookAtData_Union.IActorLookAtEmptyData:
				_o.InitialLookAt.Value = ((this.InitialLookAt<IActorLookAtEmptyData>() != null) ? this.InitialLookAt<IActorLookAtEmptyData>().Value.UnPack() : null);
				break;
			case IActorLookAtData_Union.IActorLookAtEntityData:
				_o.InitialLookAt.Value = ((this.InitialLookAt<IActorLookAtEntityData>() != null) ? this.InitialLookAt<IActorLookAtEntityData>().Value.UnPack() : null);
				break;
			case IActorLookAtData_Union.IActorLookAtPositionData:
				_o.InitialLookAt.Value = ((this.InitialLookAt<IActorLookAtPositionData>() != null) ? this.InitialLookAt<IActorLookAtPositionData>().Value.UnPack() : null);
				break;
			case IActorLookAtData_Union.IActorLookAtPlayerData:
				_o.InitialLookAt.Value = ((this.InitialLookAt<IActorLookAtPlayerData>() != null) ? this.InitialLookAt<IActorLookAtPlayerData>().Value.UnPack() : null);
				break;
			case IActorLookAtData_Union.IActorLookAtOtherActor:
				_o.InitialLookAt.Value = ((this.InitialLookAt<IActorLookAtOtherActor>() != null) ? this.InitialLookAt<IActorLookAtOtherActor>().Value.UnPack() : null);
				break;
			case IActorLookAtData_Union.IActorLookAtUnLock:
				_o.InitialLookAt.Value = ((this.InitialLookAt<IActorLookAtUnLock>() != null) ? this.InitialLookAt<IActorLookAtUnLock>().Value.UnPack() : null);
				break;
			}
			_o.InitialEffects = ((this.InitialEffects != null) ? this.InitialEffects.Value.UnPack() : null);
			_o.InitialFaceExpressionId = this.InitialFaceExpressionId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A524 RID: 173348 RVA: 0x005D5464 File Offset: 0x005D3664
		public static Offset<IActorInitialState> Pack(FlatBufferBuilder builder, IActorInitialStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorInitialState>);
			}
			Offset<IActorInitialMontage> initialMontageOffset = (_o.InitialMontage == null) ? default(Offset<IActorInitialMontage>) : IActorInitialMontage.Pack(builder, _o.InitialMontage);
			IActorLookAtData_Union initialLookAt_type = (_o.InitialLookAt == null) ? IActorLookAtData_Union.NONE : _o.InitialLookAt.Type;
			int initialLookAtOffset = (_o.InitialLookAt == null) ? 0 : IActorLookAtData_UnionUnion.Pack(builder, _o.InitialLookAt);
			Offset<IActorInitialEffect> initialEffectsOffset = (_o.InitialEffects == null) ? default(Offset<IActorInitialEffect>) : IActorInitialEffect.Pack(builder, _o.InitialEffects);
			return IActorInitialState.CreateIActorInitialState(builder, initialMontageOffset, initialLookAt_type, initialLookAtOffset, initialEffectsOffset, _o.InitialFaceExpressionId, _o.NullMask);
		}

		// Token: 0x04010478 RID: 66680
		private Table __p;
	}
}

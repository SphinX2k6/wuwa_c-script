using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006730 RID: 26416
	public struct IActorInitialState : IFlatbufferObject
	{
		// Token: 0x1700C002 RID: 49154
		// (get) Token: 0x0602CBE5 RID: 183269 RVA: 0x0061ED3F File Offset: 0x0061CF3F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CBE6 RID: 183270 RVA: 0x0061ED4C File Offset: 0x0061CF4C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CBE7 RID: 183271 RVA: 0x0061ED54 File Offset: 0x0061CF54
		public static IActorInitialState GetRootAsIActorInitialState(ByteBuffer _bb)
		{
			return IActorInitialState.GetRootAsIActorInitialState(_bb, default(IActorInitialState));
		}

		// Token: 0x0602CBE8 RID: 183272 RVA: 0x0061ED70 File Offset: 0x0061CF70
		public static IActorInitialState GetRootAsIActorInitialState(ByteBuffer _bb, IActorInitialState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CBE9 RID: 183273 RVA: 0x0061ED8D File Offset: 0x0061CF8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CBEA RID: 183274 RVA: 0x0061ED9C File Offset: 0x0061CF9C
		public IActorInitialState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C003 RID: 49155
		// (get) Token: 0x0602CBEB RID: 183275 RVA: 0x0061EDAC File Offset: 0x0061CFAC
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

		// Token: 0x1700C004 RID: 49156
		// (get) Token: 0x0602CBEC RID: 183276 RVA: 0x0061EE0C File Offset: 0x0061D00C
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

		// Token: 0x0602CBED RID: 183277 RVA: 0x0061EE48 File Offset: 0x0061D048
		public TTable? InitialLookAt<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CBEE RID: 183278 RVA: 0x0061EE8C File Offset: 0x0061D08C
		public IActorLookAtData InitialLookAtAsIActorLookAtData()
		{
			return this.InitialLookAt<IActorLookAtData>().Value;
		}

		// Token: 0x0602CBEF RID: 183279 RVA: 0x0061EEA8 File Offset: 0x0061D0A8
		public IActorLookAtLockable InitialLookAtAsIActorLookAtLockable()
		{
			return this.InitialLookAt<IActorLookAtLockable>().Value;
		}

		// Token: 0x0602CBF0 RID: 183280 RVA: 0x0061EEC4 File Offset: 0x0061D0C4
		public IActorLookAtTalkerData InitialLookAtAsIActorLookAtTalkerData()
		{
			return this.InitialLookAt<IActorLookAtTalkerData>().Value;
		}

		// Token: 0x0602CBF1 RID: 183281 RVA: 0x0061EEE0 File Offset: 0x0061D0E0
		public IActorLookAtEmptyData InitialLookAtAsIActorLookAtEmptyData()
		{
			return this.InitialLookAt<IActorLookAtEmptyData>().Value;
		}

		// Token: 0x0602CBF2 RID: 183282 RVA: 0x0061EEFC File Offset: 0x0061D0FC
		public IActorLookAtEntityData InitialLookAtAsIActorLookAtEntityData()
		{
			return this.InitialLookAt<IActorLookAtEntityData>().Value;
		}

		// Token: 0x0602CBF3 RID: 183283 RVA: 0x0061EF18 File Offset: 0x0061D118
		public IActorLookAtPositionData InitialLookAtAsIActorLookAtPositionData()
		{
			return this.InitialLookAt<IActorLookAtPositionData>().Value;
		}

		// Token: 0x0602CBF4 RID: 183284 RVA: 0x0061EF34 File Offset: 0x0061D134
		public IActorLookAtPlayerData InitialLookAtAsIActorLookAtPlayerData()
		{
			return this.InitialLookAt<IActorLookAtPlayerData>().Value;
		}

		// Token: 0x0602CBF5 RID: 183285 RVA: 0x0061EF50 File Offset: 0x0061D150
		public IActorLookAtOtherActor InitialLookAtAsIActorLookAtOtherActor()
		{
			return this.InitialLookAt<IActorLookAtOtherActor>().Value;
		}

		// Token: 0x0602CBF6 RID: 183286 RVA: 0x0061EF6C File Offset: 0x0061D16C
		public IActorLookAtUnLock InitialLookAtAsIActorLookAtUnLock()
		{
			return this.InitialLookAt<IActorLookAtUnLock>().Value;
		}

		// Token: 0x1700C005 RID: 49157
		// (get) Token: 0x0602CBF7 RID: 183287 RVA: 0x0061EF88 File Offset: 0x0061D188
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

		// Token: 0x1700C006 RID: 49158
		// (get) Token: 0x0602CBF8 RID: 183288 RVA: 0x0061EFE8 File Offset: 0x0061D1E8
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

		// Token: 0x1700C007 RID: 49159
		// (get) Token: 0x0602CBF9 RID: 183289 RVA: 0x0061F028 File Offset: 0x0061D228
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

		// Token: 0x0602CBFA RID: 183290 RVA: 0x0061F065 File Offset: 0x0061D265
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

		// Token: 0x0602CBFB RID: 183291 RVA: 0x0061F0A1 File Offset: 0x0061D2A1
		public static void StartIActorInitialState(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602CBFC RID: 183292 RVA: 0x0061F0AA File Offset: 0x0061D2AA
		public static void AddInitialMontage(FlatBufferBuilder builder, Offset<IActorInitialMontage> initialMontageOffset)
		{
			builder.AddOffset(0, initialMontageOffset.Value, 0);
		}

		// Token: 0x0602CBFD RID: 183293 RVA: 0x0061F0BA File Offset: 0x0061D2BA
		public static void AddInitialLookAtType(FlatBufferBuilder builder, IActorLookAtData_Union initialLookAtType)
		{
			builder.AddByte(1, (byte)initialLookAtType, 0);
		}

		// Token: 0x0602CBFE RID: 183294 RVA: 0x0061F0C5 File Offset: 0x0061D2C5
		public static void AddInitialLookAt(FlatBufferBuilder builder, int initialLookAtOffset)
		{
			builder.AddOffset(2, initialLookAtOffset, 0);
		}

		// Token: 0x0602CBFF RID: 183295 RVA: 0x0061F0D0 File Offset: 0x0061D2D0
		public static void AddInitialEffects(FlatBufferBuilder builder, Offset<IActorInitialEffect> initialEffectsOffset)
		{
			builder.AddOffset(3, initialEffectsOffset.Value, 0);
		}

		// Token: 0x0602CC00 RID: 183296 RVA: 0x0061F0E0 File Offset: 0x0061D2E0
		public static void AddInitialFaceExpressionId(FlatBufferBuilder builder, int initialFaceExpressionId)
		{
			builder.AddInt(4, initialFaceExpressionId, 0);
		}

		// Token: 0x0602CC01 RID: 183297 RVA: 0x0061F0EB File Offset: 0x0061D2EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602CC02 RID: 183298 RVA: 0x0061F0F6 File Offset: 0x0061D2F6
		public static Offset<IActorInitialState> EndIActorInitialState(FlatBufferBuilder builder)
		{
			return new Offset<IActorInitialState>(builder.EndTable());
		}

		// Token: 0x0602CC03 RID: 183299 RVA: 0x0061F104 File Offset: 0x0061D304
		public IActorInitialStateT UnPack()
		{
			IActorInitialStateT actorInitialStateT = new IActorInitialStateT();
			this.UnPackTo(actorInitialStateT);
			return actorInitialStateT;
		}

		// Token: 0x0602CC04 RID: 183300 RVA: 0x0061F120 File Offset: 0x0061D320
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

		// Token: 0x0602CC05 RID: 183301 RVA: 0x0061F40C File Offset: 0x0061D60C
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

		// Token: 0x0401127C RID: 70268
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E8F RID: 16015
	public struct IFishParams : IFlatbufferObject
	{
		// Token: 0x17006C45 RID: 27717
		// (get) Token: 0x060159EC RID: 88556 RVA: 0x0031D868 File Offset: 0x0031BA68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060159ED RID: 88557 RVA: 0x0031D875 File Offset: 0x0031BA75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060159EE RID: 88558 RVA: 0x0031D87C File Offset: 0x0031BA7C
		public static IFishParams GetRootAsIFishParams(ByteBuffer _bb)
		{
			return IFishParams.GetRootAsIFishParams(_bb, default(IFishParams));
		}

		// Token: 0x060159EF RID: 88559 RVA: 0x0031D898 File Offset: 0x0031BA98
		public static IFishParams GetRootAsIFishParams(ByteBuffer _bb, IFishParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060159F0 RID: 88560 RVA: 0x0031D8B5 File Offset: 0x0031BAB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060159F1 RID: 88561 RVA: 0x0031D8C4 File Offset: 0x0031BAC4
		public IFishParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C46 RID: 27718
		// (get) Token: 0x060159F2 RID: 88562 RVA: 0x0031D8D4 File Offset: 0x0031BAD4
		public EParamsPreset Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EParamsPreset.Decal;
				}
				return (EParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C47 RID: 27719
		// (get) Token: 0x060159F3 RID: 88563 RVA: 0x0031D910 File Offset: 0x0031BB10
		public TFishState StateType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TFishState.NONE;
				}
				return (TFishState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060159F4 RID: 88564 RVA: 0x0031D94C File Offset: 0x0031BB4C
		public TTable? State<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060159F5 RID: 88565 RVA: 0x0031D990 File Offset: 0x0031BB90
		public IFishDestroyState StateAsIFishDestroyState()
		{
			return this.State<IFishDestroyState>().Value;
		}

		// Token: 0x060159F6 RID: 88566 RVA: 0x0031D9AC File Offset: 0x0031BBAC
		public IFishFollowState StateAsIFishFollowState()
		{
			return this.State<IFishFollowState>().Value;
		}

		// Token: 0x060159F7 RID: 88567 RVA: 0x0031D9C8 File Offset: 0x0031BBC8
		public IFishIdleState StateAsIFishIdleState()
		{
			return this.State<IFishIdleState>().Value;
		}

		// Token: 0x060159F8 RID: 88568 RVA: 0x0031D9E4 File Offset: 0x0031BBE4
		public IFishSplinePatrolState StateAsIFishSplinePatrolState()
		{
			return this.State<IFishSplinePatrolState>().Value;
		}

		// Token: 0x060159F9 RID: 88569 RVA: 0x0031D9FF File Offset: 0x0031BBFF
		public static Offset<IFishParams> CreateIFishParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, TFishState State_type = TFishState.NONE, int StateOffset = 0)
		{
			builder.StartTable(3);
			IFishParams.AddState(builder, StateOffset);
			IFishParams.AddStateType(builder, State_type);
			IFishParams.AddType(builder, Type);
			return IFishParams.EndIFishParams(builder);
		}

		// Token: 0x060159FA RID: 88570 RVA: 0x0031DA23 File Offset: 0x0031BC23
		public static void StartIFishParams(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060159FB RID: 88571 RVA: 0x0031DA2C File Offset: 0x0031BC2C
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060159FC RID: 88572 RVA: 0x0031DA37 File Offset: 0x0031BC37
		public static void AddStateType(FlatBufferBuilder builder, TFishState stateType)
		{
			builder.AddByte(1, (byte)stateType, 0);
		}

		// Token: 0x060159FD RID: 88573 RVA: 0x0031DA42 File Offset: 0x0031BC42
		public static void AddState(FlatBufferBuilder builder, int stateOffset)
		{
			builder.AddOffset(2, stateOffset, 0);
		}

		// Token: 0x060159FE RID: 88574 RVA: 0x0031DA4D File Offset: 0x0031BC4D
		public static Offset<IFishParams> EndIFishParams(FlatBufferBuilder builder)
		{
			return new Offset<IFishParams>(builder.EndTable());
		}

		// Token: 0x060159FF RID: 88575 RVA: 0x0031DA5C File Offset: 0x0031BC5C
		public IFishParamsT UnPack()
		{
			IFishParamsT fishParamsT = new IFishParamsT();
			this.UnPackTo(fishParamsT);
			return fishParamsT;
		}

		// Token: 0x06015A00 RID: 88576 RVA: 0x0031DA78 File Offset: 0x0031BC78
		public void UnPackTo(IFishParamsT _o)
		{
			_o.Type = this.Type;
			_o.State = new TFishStateUnion();
			_o.State.Type = this.StateType;
			switch (this.StateType)
			{
			case TFishState.IFishDestroyState:
				_o.State.Value = ((this.State<IFishDestroyState>() != null) ? this.State<IFishDestroyState>().Value.UnPack() : null);
				return;
			case TFishState.IFishFollowState:
				_o.State.Value = ((this.State<IFishFollowState>() != null) ? this.State<IFishFollowState>().Value.UnPack() : null);
				return;
			case TFishState.IFishIdleState:
				_o.State.Value = ((this.State<IFishIdleState>() != null) ? this.State<IFishIdleState>().Value.UnPack() : null);
				return;
			case TFishState.IFishSplinePatrolState:
				_o.State.Value = ((this.State<IFishSplinePatrolState>() != null) ? this.State<IFishSplinePatrolState>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06015A01 RID: 88577 RVA: 0x0031DBA8 File Offset: 0x0031BDA8
		public static Offset<IFishParams> Pack(FlatBufferBuilder builder, IFishParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishParams>);
			}
			TFishState state_type = (_o.State == null) ? TFishState.NONE : _o.State.Type;
			int stateOffset = (_o.State == null) ? 0 : TFishStateUnion.Pack(builder, _o.State);
			return IFishParams.CreateIFishParams(builder, _o.Type, state_type, stateOffset);
		}

		// Token: 0x0400B86D RID: 47213
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005787 RID: 22407
	public struct IFailureConditionArbitraryState : IFlatbufferObject
	{
		// Token: 0x1700A1F5 RID: 41461
		// (get) Token: 0x0602423F RID: 148031 RVA: 0x004F8314 File Offset: 0x004F6514
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024240 RID: 148032 RVA: 0x004F8321 File Offset: 0x004F6521
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024241 RID: 148033 RVA: 0x004F8328 File Offset: 0x004F6528
		public static IFailureConditionArbitraryState GetRootAsIFailureConditionArbitraryState(ByteBuffer _bb)
		{
			return IFailureConditionArbitraryState.GetRootAsIFailureConditionArbitraryState(_bb, default(IFailureConditionArbitraryState));
		}

		// Token: 0x06024242 RID: 148034 RVA: 0x004F8344 File Offset: 0x004F6544
		public static IFailureConditionArbitraryState GetRootAsIFailureConditionArbitraryState(ByteBuffer _bb, IFailureConditionArbitraryState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024243 RID: 148035 RVA: 0x004F8361 File Offset: 0x004F6561
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024244 RID: 148036 RVA: 0x004F8370 File Offset: 0x004F6570
		public IFailureConditionArbitraryState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1F6 RID: 41462
		// (get) Token: 0x06024245 RID: 148037 RVA: 0x004F8380 File Offset: 0x004F6580
		public ETargetGearGroupFailureCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetGearGroupFailureCondition.ArbitraryState;
				}
				return (ETargetGearGroupFailureCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A1F7 RID: 41463
		// (get) Token: 0x06024246 RID: 148038 RVA: 0x004F83BC File Offset: 0x004F65BC
		public string State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024247 RID: 148039 RVA: 0x004F83F3 File Offset: 0x004F65F3
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024248 RID: 148040 RVA: 0x004F8402 File Offset: 0x004F6602
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06024249 RID: 148041 RVA: 0x004F8410 File Offset: 0x004F6610
		public static Offset<IFailureConditionArbitraryState> CreateIFailureConditionArbitraryState(FlatBufferBuilder builder, ETargetGearGroupFailureCondition Type = ETargetGearGroupFailureCondition.ArbitraryState, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFailureConditionArbitraryState.AddState(builder, StateOffset);
			IFailureConditionArbitraryState.AddType(builder, Type);
			return IFailureConditionArbitraryState.EndIFailureConditionArbitraryState(builder);
		}

		// Token: 0x0602424A RID: 148042 RVA: 0x004F842D File Offset: 0x004F662D
		public static void StartIFailureConditionArbitraryState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602424B RID: 148043 RVA: 0x004F8436 File Offset: 0x004F6636
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602424C RID: 148044 RVA: 0x004F8441 File Offset: 0x004F6641
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0602424D RID: 148045 RVA: 0x004F8451 File Offset: 0x004F6651
		public static Offset<IFailureConditionArbitraryState> EndIFailureConditionArbitraryState(FlatBufferBuilder builder)
		{
			return new Offset<IFailureConditionArbitraryState>(builder.EndTable());
		}

		// Token: 0x0602424E RID: 148046 RVA: 0x004F8460 File Offset: 0x004F6660
		public IFailureConditionArbitraryStateT UnPack()
		{
			IFailureConditionArbitraryStateT failureConditionArbitraryStateT = new IFailureConditionArbitraryStateT();
			this.UnPackTo(failureConditionArbitraryStateT);
			return failureConditionArbitraryStateT;
		}

		// Token: 0x0602424F RID: 148047 RVA: 0x004F847B File Offset: 0x004F667B
		public void UnPackTo(IFailureConditionArbitraryStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06024250 RID: 148048 RVA: 0x004F8498 File Offset: 0x004F6698
		public static Offset<IFailureConditionArbitraryState> Pack(FlatBufferBuilder builder, IFailureConditionArbitraryStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFailureConditionArbitraryState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IFailureConditionArbitraryState.CreateIFailureConditionArbitraryState(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400EF60 RID: 61280
		private Table __p;
	}
}

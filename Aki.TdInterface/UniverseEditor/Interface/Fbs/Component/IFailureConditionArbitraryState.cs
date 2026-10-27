using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200521F RID: 21023
	public struct IFailureConditionArbitraryState : IFlatbufferObject
	{
		// Token: 0x170099F9 RID: 39417
		// (get) Token: 0x060222A9 RID: 139945 RVA: 0x004BD850 File Offset: 0x004BBA50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060222AA RID: 139946 RVA: 0x004BD85D File Offset: 0x004BBA5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060222AB RID: 139947 RVA: 0x004BD864 File Offset: 0x004BBA64
		public static IFailureConditionArbitraryState GetRootAsIFailureConditionArbitraryState(ByteBuffer _bb)
		{
			return IFailureConditionArbitraryState.GetRootAsIFailureConditionArbitraryState(_bb, default(IFailureConditionArbitraryState));
		}

		// Token: 0x060222AC RID: 139948 RVA: 0x004BD880 File Offset: 0x004BBA80
		public static IFailureConditionArbitraryState GetRootAsIFailureConditionArbitraryState(ByteBuffer _bb, IFailureConditionArbitraryState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060222AD RID: 139949 RVA: 0x004BD89D File Offset: 0x004BBA9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060222AE RID: 139950 RVA: 0x004BD8AC File Offset: 0x004BBAAC
		public IFailureConditionArbitraryState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099FA RID: 39418
		// (get) Token: 0x060222AF RID: 139951 RVA: 0x004BD8BC File Offset: 0x004BBABC
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

		// Token: 0x170099FB RID: 39419
		// (get) Token: 0x060222B0 RID: 139952 RVA: 0x004BD8F8 File Offset: 0x004BBAF8
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

		// Token: 0x060222B1 RID: 139953 RVA: 0x004BD92F File Offset: 0x004BBB2F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060222B2 RID: 139954 RVA: 0x004BD93E File Offset: 0x004BBB3E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060222B3 RID: 139955 RVA: 0x004BD94C File Offset: 0x004BBB4C
		public static Offset<IFailureConditionArbitraryState> CreateIFailureConditionArbitraryState(FlatBufferBuilder builder, ETargetGearGroupFailureCondition Type = ETargetGearGroupFailureCondition.ArbitraryState, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFailureConditionArbitraryState.AddState(builder, StateOffset);
			IFailureConditionArbitraryState.AddType(builder, Type);
			return IFailureConditionArbitraryState.EndIFailureConditionArbitraryState(builder);
		}

		// Token: 0x060222B4 RID: 139956 RVA: 0x004BD969 File Offset: 0x004BBB69
		public static void StartIFailureConditionArbitraryState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060222B5 RID: 139957 RVA: 0x004BD972 File Offset: 0x004BBB72
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060222B6 RID: 139958 RVA: 0x004BD97D File Offset: 0x004BBB7D
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x060222B7 RID: 139959 RVA: 0x004BD98D File Offset: 0x004BBB8D
		public static Offset<IFailureConditionArbitraryState> EndIFailureConditionArbitraryState(FlatBufferBuilder builder)
		{
			return new Offset<IFailureConditionArbitraryState>(builder.EndTable());
		}

		// Token: 0x060222B8 RID: 139960 RVA: 0x004BD99C File Offset: 0x004BBB9C
		public IFailureConditionArbitraryStateT UnPack()
		{
			IFailureConditionArbitraryStateT failureConditionArbitraryStateT = new IFailureConditionArbitraryStateT();
			this.UnPackTo(failureConditionArbitraryStateT);
			return failureConditionArbitraryStateT;
		}

		// Token: 0x060222B9 RID: 139961 RVA: 0x004BD9B7 File Offset: 0x004BBBB7
		public void UnPackTo(IFailureConditionArbitraryStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x060222BA RID: 139962 RVA: 0x004BD9D4 File Offset: 0x004BBBD4
		public static Offset<IFailureConditionArbitraryState> Pack(FlatBufferBuilder builder, IFailureConditionArbitraryStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFailureConditionArbitraryState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IFailureConditionArbitraryState.CreateIFailureConditionArbitraryState(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400E35A RID: 58202
		private Table __p;
	}
}

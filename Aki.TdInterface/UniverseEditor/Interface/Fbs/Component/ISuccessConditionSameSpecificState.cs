using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E9 RID: 23017
	public struct ISuccessConditionSameSpecificState : IFlatbufferObject
	{
		// Token: 0x1700ACE7 RID: 44263
		// (get) Token: 0x060270C2 RID: 159938 RVA: 0x0055F3CD File Offset: 0x0055D5CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060270C3 RID: 159939 RVA: 0x0055F3DA File Offset: 0x0055D5DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060270C4 RID: 159940 RVA: 0x0055F3E4 File Offset: 0x0055D5E4
		public static ISuccessConditionSameSpecificState GetRootAsISuccessConditionSameSpecificState(ByteBuffer _bb)
		{
			return ISuccessConditionSameSpecificState.GetRootAsISuccessConditionSameSpecificState(_bb, default(ISuccessConditionSameSpecificState));
		}

		// Token: 0x060270C5 RID: 159941 RVA: 0x0055F400 File Offset: 0x0055D600
		public static ISuccessConditionSameSpecificState GetRootAsISuccessConditionSameSpecificState(ByteBuffer _bb, ISuccessConditionSameSpecificState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060270C6 RID: 159942 RVA: 0x0055F41D File Offset: 0x0055D61D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060270C7 RID: 159943 RVA: 0x0055F42C File Offset: 0x0055D62C
		public ISuccessConditionSameSpecificState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACE8 RID: 44264
		// (get) Token: 0x060270C8 RID: 159944 RVA: 0x0055F43C File Offset: 0x0055D63C
		public ETargetGearGroupSuccessCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetGearGroupSuccessCondition.SameSpecificState;
				}
				return (ETargetGearGroupSuccessCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ACE9 RID: 44265
		// (get) Token: 0x060270C9 RID: 159945 RVA: 0x0055F478 File Offset: 0x0055D678
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

		// Token: 0x060270CA RID: 159946 RVA: 0x0055F4AF File Offset: 0x0055D6AF
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060270CB RID: 159947 RVA: 0x0055F4BE File Offset: 0x0055D6BE
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060270CC RID: 159948 RVA: 0x0055F4CC File Offset: 0x0055D6CC
		public static Offset<ISuccessConditionSameSpecificState> CreateISuccessConditionSameSpecificState(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition Type = ETargetGearGroupSuccessCondition.SameSpecificState, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISuccessConditionSameSpecificState.AddState(builder, StateOffset);
			ISuccessConditionSameSpecificState.AddType(builder, Type);
			return ISuccessConditionSameSpecificState.EndISuccessConditionSameSpecificState(builder);
		}

		// Token: 0x060270CD RID: 159949 RVA: 0x0055F4E9 File Offset: 0x0055D6E9
		public static void StartISuccessConditionSameSpecificState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060270CE RID: 159950 RVA: 0x0055F4F2 File Offset: 0x0055D6F2
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060270CF RID: 159951 RVA: 0x0055F4FD File Offset: 0x0055D6FD
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x060270D0 RID: 159952 RVA: 0x0055F50D File Offset: 0x0055D70D
		public static Offset<ISuccessConditionSameSpecificState> EndISuccessConditionSameSpecificState(FlatBufferBuilder builder)
		{
			return new Offset<ISuccessConditionSameSpecificState>(builder.EndTable());
		}

		// Token: 0x060270D1 RID: 159953 RVA: 0x0055F51C File Offset: 0x0055D71C
		public ISuccessConditionSameSpecificStateT UnPack()
		{
			ISuccessConditionSameSpecificStateT successConditionSameSpecificStateT = new ISuccessConditionSameSpecificStateT();
			this.UnPackTo(successConditionSameSpecificStateT);
			return successConditionSameSpecificStateT;
		}

		// Token: 0x060270D2 RID: 159954 RVA: 0x0055F537 File Offset: 0x0055D737
		public void UnPackTo(ISuccessConditionSameSpecificStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x060270D3 RID: 159955 RVA: 0x0055F554 File Offset: 0x0055D754
		public static Offset<ISuccessConditionSameSpecificState> Pack(FlatBufferBuilder builder, ISuccessConditionSameSpecificStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISuccessConditionSameSpecificState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ISuccessConditionSameSpecificState.CreateISuccessConditionSameSpecificState(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400F020 RID: 61472
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E6 RID: 23014
	public struct ISuccessConditionSameArbitraryState : IFlatbufferObject
	{
		// Token: 0x1700ACE4 RID: 44260
		// (get) Token: 0x060270B0 RID: 159920 RVA: 0x0055F255 File Offset: 0x0055D455
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060270B1 RID: 159921 RVA: 0x0055F262 File Offset: 0x0055D462
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060270B2 RID: 159922 RVA: 0x0055F26C File Offset: 0x0055D46C
		public static ISuccessConditionSameArbitraryState GetRootAsISuccessConditionSameArbitraryState(ByteBuffer _bb)
		{
			return ISuccessConditionSameArbitraryState.GetRootAsISuccessConditionSameArbitraryState(_bb, default(ISuccessConditionSameArbitraryState));
		}

		// Token: 0x060270B3 RID: 159923 RVA: 0x0055F288 File Offset: 0x0055D488
		public static ISuccessConditionSameArbitraryState GetRootAsISuccessConditionSameArbitraryState(ByteBuffer _bb, ISuccessConditionSameArbitraryState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060270B4 RID: 159924 RVA: 0x0055F2A5 File Offset: 0x0055D4A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060270B5 RID: 159925 RVA: 0x0055F2B4 File Offset: 0x0055D4B4
		public ISuccessConditionSameArbitraryState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACE5 RID: 44261
		// (get) Token: 0x060270B6 RID: 159926 RVA: 0x0055F2C4 File Offset: 0x0055D4C4
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

		// Token: 0x060270B7 RID: 159927 RVA: 0x0055F300 File Offset: 0x0055D500
		public static Offset<ISuccessConditionSameArbitraryState> CreateISuccessConditionSameArbitraryState(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition Type = ETargetGearGroupSuccessCondition.SameSpecificState)
		{
			builder.StartTable(1);
			ISuccessConditionSameArbitraryState.AddType(builder, Type);
			return ISuccessConditionSameArbitraryState.EndISuccessConditionSameArbitraryState(builder);
		}

		// Token: 0x060270B8 RID: 159928 RVA: 0x0055F316 File Offset: 0x0055D516
		public static void StartISuccessConditionSameArbitraryState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060270B9 RID: 159929 RVA: 0x0055F31F File Offset: 0x0055D51F
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060270BA RID: 159930 RVA: 0x0055F32A File Offset: 0x0055D52A
		public static Offset<ISuccessConditionSameArbitraryState> EndISuccessConditionSameArbitraryState(FlatBufferBuilder builder)
		{
			return new Offset<ISuccessConditionSameArbitraryState>(builder.EndTable());
		}

		// Token: 0x060270BB RID: 159931 RVA: 0x0055F338 File Offset: 0x0055D538
		public ISuccessConditionSameArbitraryStateT UnPack()
		{
			ISuccessConditionSameArbitraryStateT successConditionSameArbitraryStateT = new ISuccessConditionSameArbitraryStateT();
			this.UnPackTo(successConditionSameArbitraryStateT);
			return successConditionSameArbitraryStateT;
		}

		// Token: 0x060270BC RID: 159932 RVA: 0x0055F353 File Offset: 0x0055D553
		public void UnPackTo(ISuccessConditionSameArbitraryStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060270BD RID: 159933 RVA: 0x0055F364 File Offset: 0x0055D564
		public static Offset<ISuccessConditionSameArbitraryState> Pack(FlatBufferBuilder builder, ISuccessConditionSameArbitraryStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISuccessConditionSameArbitraryState>);
			}
			return ISuccessConditionSameArbitraryState.CreateISuccessConditionSameArbitraryState(builder, _o.Type);
		}

		// Token: 0x0400F01E RID: 61470
		private Table __p;
	}
}

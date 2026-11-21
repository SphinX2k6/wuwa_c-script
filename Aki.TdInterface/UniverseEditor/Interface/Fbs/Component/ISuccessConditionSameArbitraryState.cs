using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FF3 RID: 24563
	public struct ISuccessConditionSameArbitraryState : IFlatbufferObject
	{
		// Token: 0x1700B61C RID: 46620
		// (get) Token: 0x06029628 RID: 169512 RVA: 0x005A6219 File Offset: 0x005A4419
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029629 RID: 169513 RVA: 0x005A6226 File Offset: 0x005A4426
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602962A RID: 169514 RVA: 0x005A6230 File Offset: 0x005A4430
		public static ISuccessConditionSameArbitraryState GetRootAsISuccessConditionSameArbitraryState(ByteBuffer _bb)
		{
			return ISuccessConditionSameArbitraryState.GetRootAsISuccessConditionSameArbitraryState(_bb, default(ISuccessConditionSameArbitraryState));
		}

		// Token: 0x0602962B RID: 169515 RVA: 0x005A624C File Offset: 0x005A444C
		public static ISuccessConditionSameArbitraryState GetRootAsISuccessConditionSameArbitraryState(ByteBuffer _bb, ISuccessConditionSameArbitraryState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602962C RID: 169516 RVA: 0x005A6269 File Offset: 0x005A4469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602962D RID: 169517 RVA: 0x005A6278 File Offset: 0x005A4478
		public ISuccessConditionSameArbitraryState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B61D RID: 46621
		// (get) Token: 0x0602962E RID: 169518 RVA: 0x005A6288 File Offset: 0x005A4488
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

		// Token: 0x0602962F RID: 169519 RVA: 0x005A62C4 File Offset: 0x005A44C4
		public static Offset<ISuccessConditionSameArbitraryState> CreateISuccessConditionSameArbitraryState(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition Type = ETargetGearGroupSuccessCondition.SameSpecificState)
		{
			builder.StartTable(1);
			ISuccessConditionSameArbitraryState.AddType(builder, Type);
			return ISuccessConditionSameArbitraryState.EndISuccessConditionSameArbitraryState(builder);
		}

		// Token: 0x06029630 RID: 169520 RVA: 0x005A62DA File Offset: 0x005A44DA
		public static void StartISuccessConditionSameArbitraryState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029631 RID: 169521 RVA: 0x005A62E3 File Offset: 0x005A44E3
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029632 RID: 169522 RVA: 0x005A62EE File Offset: 0x005A44EE
		public static Offset<ISuccessConditionSameArbitraryState> EndISuccessConditionSameArbitraryState(FlatBufferBuilder builder)
		{
			return new Offset<ISuccessConditionSameArbitraryState>(builder.EndTable());
		}

		// Token: 0x06029633 RID: 169523 RVA: 0x005A62FC File Offset: 0x005A44FC
		public ISuccessConditionSameArbitraryStateT UnPack()
		{
			ISuccessConditionSameArbitraryStateT successConditionSameArbitraryStateT = new ISuccessConditionSameArbitraryStateT();
			this.UnPackTo(successConditionSameArbitraryStateT);
			return successConditionSameArbitraryStateT;
		}

		// Token: 0x06029634 RID: 169524 RVA: 0x005A6317 File Offset: 0x005A4517
		public void UnPackTo(ISuccessConditionSameArbitraryStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029635 RID: 169525 RVA: 0x005A6328 File Offset: 0x005A4528
		public static Offset<ISuccessConditionSameArbitraryState> Pack(FlatBufferBuilder builder, ISuccessConditionSameArbitraryStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISuccessConditionSameArbitraryState>);
			}
			return ISuccessConditionSameArbitraryState.CreateISuccessConditionSameArbitraryState(builder, _o.Type);
		}

		// Token: 0x0400FD15 RID: 64789
		private Table __p;
	}
}

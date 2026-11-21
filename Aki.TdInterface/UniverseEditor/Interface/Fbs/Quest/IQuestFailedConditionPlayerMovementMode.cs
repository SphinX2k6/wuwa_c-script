using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004427 RID: 17447
	public struct IQuestFailedConditionPlayerMovementMode : IFlatbufferObject
	{
		// Token: 0x170078CB RID: 30923
		// (get) Token: 0x06018F4C RID: 102220 RVA: 0x0038F222 File Offset: 0x0038D422
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018F4D RID: 102221 RVA: 0x0038F22F File Offset: 0x0038D42F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018F4E RID: 102222 RVA: 0x0038F238 File Offset: 0x0038D438
		public static IQuestFailedConditionPlayerMovementMode GetRootAsIQuestFailedConditionPlayerMovementMode(ByteBuffer _bb)
		{
			return IQuestFailedConditionPlayerMovementMode.GetRootAsIQuestFailedConditionPlayerMovementMode(_bb, default(IQuestFailedConditionPlayerMovementMode));
		}

		// Token: 0x06018F4F RID: 102223 RVA: 0x0038F254 File Offset: 0x0038D454
		public static IQuestFailedConditionPlayerMovementMode GetRootAsIQuestFailedConditionPlayerMovementMode(ByteBuffer _bb, IQuestFailedConditionPlayerMovementMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018F50 RID: 102224 RVA: 0x0038F271 File Offset: 0x0038D471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018F51 RID: 102225 RVA: 0x0038F280 File Offset: 0x0038D480
		public IQuestFailedConditionPlayerMovementMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078CC RID: 30924
		// (get) Token: 0x06018F52 RID: 102226 RVA: 0x0038F290 File Offset: 0x0038D490
		public EPlayerMovementMode Mode
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerMovementMode.Ski;
				}
				return (EPlayerMovementMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170078CD RID: 30925
		// (get) Token: 0x06018F53 RID: 102227 RVA: 0x0038F2CC File Offset: 0x0038D4CC
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018F54 RID: 102228 RVA: 0x0038F308 File Offset: 0x0038D508
		public static Offset<IQuestFailedConditionPlayerMovementMode> CreateIQuestFailedConditionPlayerMovementMode(FlatBufferBuilder builder, EPlayerMovementMode Mode = EPlayerMovementMode.Ski, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(2);
			IQuestFailedConditionPlayerMovementMode.AddCompare(builder, Compare);
			IQuestFailedConditionPlayerMovementMode.AddMode(builder, Mode);
			return IQuestFailedConditionPlayerMovementMode.EndIQuestFailedConditionPlayerMovementMode(builder);
		}

		// Token: 0x06018F55 RID: 102229 RVA: 0x0038F325 File Offset: 0x0038D525
		public static void StartIQuestFailedConditionPlayerMovementMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018F56 RID: 102230 RVA: 0x0038F32E File Offset: 0x0038D52E
		public static void AddMode(FlatBufferBuilder builder, EPlayerMovementMode mode)
		{
			builder.AddByte(0, (byte)mode, 0);
		}

		// Token: 0x06018F57 RID: 102231 RVA: 0x0038F339 File Offset: 0x0038D539
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06018F58 RID: 102232 RVA: 0x0038F344 File Offset: 0x0038D544
		public static Offset<IQuestFailedConditionPlayerMovementMode> EndIQuestFailedConditionPlayerMovementMode(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConditionPlayerMovementMode>(builder.EndTable());
		}

		// Token: 0x06018F59 RID: 102233 RVA: 0x0038F354 File Offset: 0x0038D554
		public IQuestFailedConditionPlayerMovementModeT UnPack()
		{
			IQuestFailedConditionPlayerMovementModeT questFailedConditionPlayerMovementModeT = new IQuestFailedConditionPlayerMovementModeT();
			this.UnPackTo(questFailedConditionPlayerMovementModeT);
			return questFailedConditionPlayerMovementModeT;
		}

		// Token: 0x06018F5A RID: 102234 RVA: 0x0038F36F File Offset: 0x0038D56F
		public void UnPackTo(IQuestFailedConditionPlayerMovementModeT _o)
		{
			_o.Mode = this.Mode;
			_o.Compare = this.Compare;
		}

		// Token: 0x06018F5B RID: 102235 RVA: 0x0038F38C File Offset: 0x0038D58C
		public static Offset<IQuestFailedConditionPlayerMovementMode> Pack(FlatBufferBuilder builder, IQuestFailedConditionPlayerMovementModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedConditionPlayerMovementMode>);
			}
			return IQuestFailedConditionPlayerMovementMode.CreateIQuestFailedConditionPlayerMovementMode(builder, _o.Mode, _o.Compare);
		}

		// Token: 0x0400C4CC RID: 50380
		private Table __p;
	}
}

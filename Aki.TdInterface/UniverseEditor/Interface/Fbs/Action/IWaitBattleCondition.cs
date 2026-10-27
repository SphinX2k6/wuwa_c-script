using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F8 RID: 30200
	public struct IWaitBattleCondition : IFlatbufferObject
	{
		// Token: 0x1700E56F RID: 58735
		// (get) Token: 0x06037038 RID: 225336 RVA: 0x00776E67 File Offset: 0x00775067
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037039 RID: 225337 RVA: 0x00776E74 File Offset: 0x00775074
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603703A RID: 225338 RVA: 0x00776E7C File Offset: 0x0077507C
		public static IWaitBattleCondition GetRootAsIWaitBattleCondition(ByteBuffer _bb)
		{
			return IWaitBattleCondition.GetRootAsIWaitBattleCondition(_bb, default(IWaitBattleCondition));
		}

		// Token: 0x0603703B RID: 225339 RVA: 0x00776E98 File Offset: 0x00775098
		public static IWaitBattleCondition GetRootAsIWaitBattleCondition(ByteBuffer _bb, IWaitBattleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603703C RID: 225340 RVA: 0x00776EB5 File Offset: 0x007750B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603703D RID: 225341 RVA: 0x00776EC4 File Offset: 0x007750C4
		public IWaitBattleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E570 RID: 58736
		// (get) Token: 0x0603703E RID: 225342 RVA: 0x00776ED4 File Offset: 0x007750D4
		public IDetectBattleTag? StateOption
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IDetectBattleTag?(default(IDetectBattleTag).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603703F RID: 225343 RVA: 0x00776F31 File Offset: 0x00775131
		public static Offset<IWaitBattleCondition> CreateIWaitBattleCondition(FlatBufferBuilder builder, Offset<IDetectBattleTag> StateOptionOffset = default(Offset<IDetectBattleTag>))
		{
			builder.StartTable(1);
			IWaitBattleCondition.AddStateOption(builder, StateOptionOffset);
			return IWaitBattleCondition.EndIWaitBattleCondition(builder);
		}

		// Token: 0x06037040 RID: 225344 RVA: 0x00776F47 File Offset: 0x00775147
		public static void StartIWaitBattleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06037041 RID: 225345 RVA: 0x00776F50 File Offset: 0x00775150
		public static void AddStateOption(FlatBufferBuilder builder, Offset<IDetectBattleTag> stateOptionOffset)
		{
			builder.AddOffset(0, stateOptionOffset.Value, 0);
		}

		// Token: 0x06037042 RID: 225346 RVA: 0x00776F60 File Offset: 0x00775160
		public static Offset<IWaitBattleCondition> EndIWaitBattleCondition(FlatBufferBuilder builder)
		{
			return new Offset<IWaitBattleCondition>(builder.EndTable());
		}

		// Token: 0x06037043 RID: 225347 RVA: 0x00776F70 File Offset: 0x00775170
		public IWaitBattleConditionT UnPack()
		{
			IWaitBattleConditionT waitBattleConditionT = new IWaitBattleConditionT();
			this.UnPackTo(waitBattleConditionT);
			return waitBattleConditionT;
		}

		// Token: 0x06037044 RID: 225348 RVA: 0x00776F8C File Offset: 0x0077518C
		public void UnPackTo(IWaitBattleConditionT _o)
		{
			_o.StateOption = ((this.StateOption != null) ? this.StateOption.Value.UnPack() : null);
		}

		// Token: 0x06037045 RID: 225349 RVA: 0x00776FC8 File Offset: 0x007751C8
		public static Offset<IWaitBattleCondition> Pack(FlatBufferBuilder builder, IWaitBattleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitBattleCondition>);
			}
			Offset<IDetectBattleTag> stateOptionOffset = (_o.StateOption == null) ? default(Offset<IDetectBattleTag>) : IDetectBattleTag.Pack(builder, _o.StateOption);
			return IWaitBattleCondition.CreateIWaitBattleCondition(builder, stateOptionOffset);
		}

		// Token: 0x0401256C RID: 75116
		private Table __p;
	}
}

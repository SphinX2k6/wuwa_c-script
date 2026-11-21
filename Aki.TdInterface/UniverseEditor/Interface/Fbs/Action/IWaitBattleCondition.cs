using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E06 RID: 32262
	public struct IWaitBattleCondition : IFlatbufferObject
	{
		// Token: 0x1700F1AD RID: 61869
		// (get) Token: 0x0603A4DD RID: 238813 RVA: 0x007DAF63 File Offset: 0x007D9163
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A4DE RID: 238814 RVA: 0x007DAF70 File Offset: 0x007D9170
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A4DF RID: 238815 RVA: 0x007DAF78 File Offset: 0x007D9178
		public static IWaitBattleCondition GetRootAsIWaitBattleCondition(ByteBuffer _bb)
		{
			return IWaitBattleCondition.GetRootAsIWaitBattleCondition(_bb, default(IWaitBattleCondition));
		}

		// Token: 0x0603A4E0 RID: 238816 RVA: 0x007DAF94 File Offset: 0x007D9194
		public static IWaitBattleCondition GetRootAsIWaitBattleCondition(ByteBuffer _bb, IWaitBattleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A4E1 RID: 238817 RVA: 0x007DAFB1 File Offset: 0x007D91B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A4E2 RID: 238818 RVA: 0x007DAFC0 File Offset: 0x007D91C0
		public IWaitBattleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1AE RID: 61870
		// (get) Token: 0x0603A4E3 RID: 238819 RVA: 0x007DAFD0 File Offset: 0x007D91D0
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

		// Token: 0x0603A4E4 RID: 238820 RVA: 0x007DB02D File Offset: 0x007D922D
		public static Offset<IWaitBattleCondition> CreateIWaitBattleCondition(FlatBufferBuilder builder, Offset<IDetectBattleTag> StateOptionOffset = default(Offset<IDetectBattleTag>))
		{
			builder.StartTable(1);
			IWaitBattleCondition.AddStateOption(builder, StateOptionOffset);
			return IWaitBattleCondition.EndIWaitBattleCondition(builder);
		}

		// Token: 0x0603A4E5 RID: 238821 RVA: 0x007DB043 File Offset: 0x007D9243
		public static void StartIWaitBattleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A4E6 RID: 238822 RVA: 0x007DB04C File Offset: 0x007D924C
		public static void AddStateOption(FlatBufferBuilder builder, Offset<IDetectBattleTag> stateOptionOffset)
		{
			builder.AddOffset(0, stateOptionOffset.Value, 0);
		}

		// Token: 0x0603A4E7 RID: 238823 RVA: 0x007DB05C File Offset: 0x007D925C
		public static Offset<IWaitBattleCondition> EndIWaitBattleCondition(FlatBufferBuilder builder)
		{
			return new Offset<IWaitBattleCondition>(builder.EndTable());
		}

		// Token: 0x0603A4E8 RID: 238824 RVA: 0x007DB06C File Offset: 0x007D926C
		public IWaitBattleConditionT UnPack()
		{
			IWaitBattleConditionT waitBattleConditionT = new IWaitBattleConditionT();
			this.UnPackTo(waitBattleConditionT);
			return waitBattleConditionT;
		}

		// Token: 0x0603A4E9 RID: 238825 RVA: 0x007DB088 File Offset: 0x007D9288
		public void UnPackTo(IWaitBattleConditionT _o)
		{
			_o.StateOption = ((this.StateOption != null) ? this.StateOption.Value.UnPack() : null);
		}

		// Token: 0x0603A4EA RID: 238826 RVA: 0x007DB0C4 File Offset: 0x007D92C4
		public static Offset<IWaitBattleCondition> Pack(FlatBufferBuilder builder, IWaitBattleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitBattleCondition>);
			}
			Offset<IDetectBattleTag> stateOptionOffset = (_o.StateOption == null) ? default(Offset<IDetectBattleTag>) : IDetectBattleTag.Pack(builder, _o.StateOption);
			return IWaitBattleCondition.CreateIWaitBattleCondition(builder, stateOptionOffset);
		}

		// Token: 0x040135B6 RID: 79286
		private Table __p;
	}
}

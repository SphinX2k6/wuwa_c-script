using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200429E RID: 17054
	public struct IFlipperConditionStepFight : IFlatbufferObject
	{
		// Token: 0x1700749E RID: 29854
		// (get) Token: 0x06017DDF RID: 97759 RVA: 0x00368B5A File Offset: 0x00366D5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017DE0 RID: 97760 RVA: 0x00368B67 File Offset: 0x00366D67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017DE1 RID: 97761 RVA: 0x00368B70 File Offset: 0x00366D70
		public static IFlipperConditionStepFight GetRootAsIFlipperConditionStepFight(ByteBuffer _bb)
		{
			return IFlipperConditionStepFight.GetRootAsIFlipperConditionStepFight(_bb, default(IFlipperConditionStepFight));
		}

		// Token: 0x06017DE2 RID: 97762 RVA: 0x00368B8C File Offset: 0x00366D8C
		public static IFlipperConditionStepFight GetRootAsIFlipperConditionStepFight(ByteBuffer _bb, IFlipperConditionStepFight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017DE3 RID: 97763 RVA: 0x00368BA9 File Offset: 0x00366DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017DE4 RID: 97764 RVA: 0x00368BB8 File Offset: 0x00366DB8
		public IFlipperConditionStepFight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700749F RID: 29855
		// (get) Token: 0x06017DE5 RID: 97765 RVA: 0x00368BC8 File Offset: 0x00366DC8
		public EFlipperConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFlipperConditionStep.Fight;
				}
				return (EFlipperConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017DE6 RID: 97766 RVA: 0x00368C04 File Offset: 0x00366E04
		public static Offset<IFlipperConditionStepFight> CreateIFlipperConditionStepFight(FlatBufferBuilder builder, EFlipperConditionStep Type = EFlipperConditionStep.Fight)
		{
			builder.StartTable(1);
			IFlipperConditionStepFight.AddType(builder, Type);
			return IFlipperConditionStepFight.EndIFlipperConditionStepFight(builder);
		}

		// Token: 0x06017DE7 RID: 97767 RVA: 0x00368C1A File Offset: 0x00366E1A
		public static void StartIFlipperConditionStepFight(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017DE8 RID: 97768 RVA: 0x00368C23 File Offset: 0x00366E23
		public static void AddType(FlatBufferBuilder builder, EFlipperConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017DE9 RID: 97769 RVA: 0x00368C2E File Offset: 0x00366E2E
		public static Offset<IFlipperConditionStepFight> EndIFlipperConditionStepFight(FlatBufferBuilder builder)
		{
			return new Offset<IFlipperConditionStepFight>(builder.EndTable());
		}

		// Token: 0x06017DEA RID: 97770 RVA: 0x00368C3C File Offset: 0x00366E3C
		public IFlipperConditionStepFightT UnPack()
		{
			IFlipperConditionStepFightT flipperConditionStepFightT = new IFlipperConditionStepFightT();
			this.UnPackTo(flipperConditionStepFightT);
			return flipperConditionStepFightT;
		}

		// Token: 0x06017DEB RID: 97771 RVA: 0x00368C57 File Offset: 0x00366E57
		public void UnPackTo(IFlipperConditionStepFightT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017DEC RID: 97772 RVA: 0x00368C68 File Offset: 0x00366E68
		public static Offset<IFlipperConditionStepFight> Pack(FlatBufferBuilder builder, IFlipperConditionStepFightT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlipperConditionStepFight>);
			}
			return IFlipperConditionStepFight.CreateIFlipperConditionStepFight(builder, _o.Type);
		}

		// Token: 0x0400C1EC RID: 49644
		private Table __p;
	}
}

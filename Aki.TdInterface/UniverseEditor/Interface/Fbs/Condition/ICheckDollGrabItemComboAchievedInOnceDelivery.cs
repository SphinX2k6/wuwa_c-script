using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049CA RID: 18890
	public struct ICheckDollGrabItemComboAchievedInOnceDelivery : IFlatbufferObject
	{
		// Token: 0x17008895 RID: 34965
		// (get) Token: 0x0601D7E6 RID: 120806 RVA: 0x00427603 File Offset: 0x00425803
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D7E7 RID: 120807 RVA: 0x00427610 File Offset: 0x00425810
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D7E8 RID: 120808 RVA: 0x00427618 File Offset: 0x00425818
		public static ICheckDollGrabItemComboAchievedInOnceDelivery GetRootAsICheckDollGrabItemComboAchievedInOnceDelivery(ByteBuffer _bb)
		{
			return ICheckDollGrabItemComboAchievedInOnceDelivery.GetRootAsICheckDollGrabItemComboAchievedInOnceDelivery(_bb, default(ICheckDollGrabItemComboAchievedInOnceDelivery));
		}

		// Token: 0x0601D7E9 RID: 120809 RVA: 0x00427634 File Offset: 0x00425834
		public static ICheckDollGrabItemComboAchievedInOnceDelivery GetRootAsICheckDollGrabItemComboAchievedInOnceDelivery(ByteBuffer _bb, ICheckDollGrabItemComboAchievedInOnceDelivery obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D7EA RID: 120810 RVA: 0x00427651 File Offset: 0x00425851
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D7EB RID: 120811 RVA: 0x00427660 File Offset: 0x00425860
		public ICheckDollGrabItemComboAchievedInOnceDelivery __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008896 RID: 34966
		// (get) Token: 0x0601D7EC RID: 120812 RVA: 0x00427670 File Offset: 0x00425870
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008897 RID: 34967
		// (get) Token: 0x0601D7ED RID: 120813 RVA: 0x004276AC File Offset: 0x004258AC
		public int ShowcaseEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D7EE RID: 120814 RVA: 0x004276E8 File Offset: 0x004258E8
		public static Offset<ICheckDollGrabItemComboAchievedInOnceDelivery> CreateICheckDollGrabItemComboAchievedInOnceDelivery(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ShowcaseEntityId = 0)
		{
			builder.StartTable(2);
			ICheckDollGrabItemComboAchievedInOnceDelivery.AddShowcaseEntityId(builder, ShowcaseEntityId);
			ICheckDollGrabItemComboAchievedInOnceDelivery.AddType(builder, Type);
			return ICheckDollGrabItemComboAchievedInOnceDelivery.EndICheckDollGrabItemComboAchievedInOnceDelivery(builder);
		}

		// Token: 0x0601D7EF RID: 120815 RVA: 0x00427705 File Offset: 0x00425905
		public static void StartICheckDollGrabItemComboAchievedInOnceDelivery(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D7F0 RID: 120816 RVA: 0x0042770E File Offset: 0x0042590E
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D7F1 RID: 120817 RVA: 0x00427719 File Offset: 0x00425919
		public static void AddShowcaseEntityId(FlatBufferBuilder builder, int showcaseEntityId)
		{
			builder.AddInt(1, showcaseEntityId, 0);
		}

		// Token: 0x0601D7F2 RID: 120818 RVA: 0x00427724 File Offset: 0x00425924
		public static Offset<ICheckDollGrabItemComboAchievedInOnceDelivery> EndICheckDollGrabItemComboAchievedInOnceDelivery(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDollGrabItemComboAchievedInOnceDelivery>(builder.EndTable());
		}

		// Token: 0x0601D7F3 RID: 120819 RVA: 0x00427734 File Offset: 0x00425934
		public ICheckDollGrabItemComboAchievedInOnceDeliveryT UnPack()
		{
			ICheckDollGrabItemComboAchievedInOnceDeliveryT checkDollGrabItemComboAchievedInOnceDeliveryT = new ICheckDollGrabItemComboAchievedInOnceDeliveryT();
			this.UnPackTo(checkDollGrabItemComboAchievedInOnceDeliveryT);
			return checkDollGrabItemComboAchievedInOnceDeliveryT;
		}

		// Token: 0x0601D7F4 RID: 120820 RVA: 0x0042774F File Offset: 0x0042594F
		public void UnPackTo(ICheckDollGrabItemComboAchievedInOnceDeliveryT _o)
		{
			_o.Type = this.Type;
			_o.ShowcaseEntityId = this.ShowcaseEntityId;
		}

		// Token: 0x0601D7F5 RID: 120821 RVA: 0x0042776C File Offset: 0x0042596C
		public static Offset<ICheckDollGrabItemComboAchievedInOnceDelivery> Pack(FlatBufferBuilder builder, ICheckDollGrabItemComboAchievedInOnceDeliveryT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDollGrabItemComboAchievedInOnceDelivery>);
			}
			return ICheckDollGrabItemComboAchievedInOnceDelivery.CreateICheckDollGrabItemComboAchievedInOnceDelivery(builder, _o.Type, _o.ShowcaseEntityId);
		}

		// Token: 0x0400D1F4 RID: 53748
		private Table __p;
	}
}

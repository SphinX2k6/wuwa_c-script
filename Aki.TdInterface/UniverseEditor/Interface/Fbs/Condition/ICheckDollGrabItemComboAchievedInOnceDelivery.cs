using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E8A RID: 20106
	public struct ICheckDollGrabItemComboAchievedInOnceDelivery : IFlatbufferObject
	{
		// Token: 0x17008F65 RID: 36709
		// (get) Token: 0x0601F259 RID: 127577 RVA: 0x0045826F File Offset: 0x0045646F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F25A RID: 127578 RVA: 0x0045827C File Offset: 0x0045647C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F25B RID: 127579 RVA: 0x00458284 File Offset: 0x00456484
		public static ICheckDollGrabItemComboAchievedInOnceDelivery GetRootAsICheckDollGrabItemComboAchievedInOnceDelivery(ByteBuffer _bb)
		{
			return ICheckDollGrabItemComboAchievedInOnceDelivery.GetRootAsICheckDollGrabItemComboAchievedInOnceDelivery(_bb, default(ICheckDollGrabItemComboAchievedInOnceDelivery));
		}

		// Token: 0x0601F25C RID: 127580 RVA: 0x004582A0 File Offset: 0x004564A0
		public static ICheckDollGrabItemComboAchievedInOnceDelivery GetRootAsICheckDollGrabItemComboAchievedInOnceDelivery(ByteBuffer _bb, ICheckDollGrabItemComboAchievedInOnceDelivery obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F25D RID: 127581 RVA: 0x004582BD File Offset: 0x004564BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F25E RID: 127582 RVA: 0x004582CC File Offset: 0x004564CC
		public ICheckDollGrabItemComboAchievedInOnceDelivery __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F66 RID: 36710
		// (get) Token: 0x0601F25F RID: 127583 RVA: 0x004582DC File Offset: 0x004564DC
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

		// Token: 0x17008F67 RID: 36711
		// (get) Token: 0x0601F260 RID: 127584 RVA: 0x00458318 File Offset: 0x00456518
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

		// Token: 0x0601F261 RID: 127585 RVA: 0x00458354 File Offset: 0x00456554
		public static Offset<ICheckDollGrabItemComboAchievedInOnceDelivery> CreateICheckDollGrabItemComboAchievedInOnceDelivery(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ShowcaseEntityId = 0)
		{
			builder.StartTable(2);
			ICheckDollGrabItemComboAchievedInOnceDelivery.AddShowcaseEntityId(builder, ShowcaseEntityId);
			ICheckDollGrabItemComboAchievedInOnceDelivery.AddType(builder, Type);
			return ICheckDollGrabItemComboAchievedInOnceDelivery.EndICheckDollGrabItemComboAchievedInOnceDelivery(builder);
		}

		// Token: 0x0601F262 RID: 127586 RVA: 0x00458371 File Offset: 0x00456571
		public static void StartICheckDollGrabItemComboAchievedInOnceDelivery(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F263 RID: 127587 RVA: 0x0045837A File Offset: 0x0045657A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F264 RID: 127588 RVA: 0x00458385 File Offset: 0x00456585
		public static void AddShowcaseEntityId(FlatBufferBuilder builder, int showcaseEntityId)
		{
			builder.AddInt(1, showcaseEntityId, 0);
		}

		// Token: 0x0601F265 RID: 127589 RVA: 0x00458390 File Offset: 0x00456590
		public static Offset<ICheckDollGrabItemComboAchievedInOnceDelivery> EndICheckDollGrabItemComboAchievedInOnceDelivery(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDollGrabItemComboAchievedInOnceDelivery>(builder.EndTable());
		}

		// Token: 0x0601F266 RID: 127590 RVA: 0x004583A0 File Offset: 0x004565A0
		public ICheckDollGrabItemComboAchievedInOnceDeliveryT UnPack()
		{
			ICheckDollGrabItemComboAchievedInOnceDeliveryT checkDollGrabItemComboAchievedInOnceDeliveryT = new ICheckDollGrabItemComboAchievedInOnceDeliveryT();
			this.UnPackTo(checkDollGrabItemComboAchievedInOnceDeliveryT);
			return checkDollGrabItemComboAchievedInOnceDeliveryT;
		}

		// Token: 0x0601F267 RID: 127591 RVA: 0x004583BB File Offset: 0x004565BB
		public void UnPackTo(ICheckDollGrabItemComboAchievedInOnceDeliveryT _o)
		{
			_o.Type = this.Type;
			_o.ShowcaseEntityId = this.ShowcaseEntityId;
		}

		// Token: 0x0601F268 RID: 127592 RVA: 0x004583D8 File Offset: 0x004565D8
		public static Offset<ICheckDollGrabItemComboAchievedInOnceDelivery> Pack(FlatBufferBuilder builder, ICheckDollGrabItemComboAchievedInOnceDeliveryT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDollGrabItemComboAchievedInOnceDelivery>);
			}
			return ICheckDollGrabItemComboAchievedInOnceDelivery.CreateICheckDollGrabItemComboAchievedInOnceDelivery(builder, _o.Type, _o.ShowcaseEntityId);
		}

		// Token: 0x0400DCC8 RID: 56520
		private Table __p;
	}
}

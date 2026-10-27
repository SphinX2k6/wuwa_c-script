using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200581A RID: 22554
	public struct IRefreshConditionBase : IFlatbufferObject
	{
		// Token: 0x1700A87D RID: 43133
		// (get) Token: 0x06025ECE RID: 155342 RVA: 0x0053ACE4 File Offset: 0x00538EE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025ECF RID: 155343 RVA: 0x0053ACF1 File Offset: 0x00538EF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025ED0 RID: 155344 RVA: 0x0053ACF8 File Offset: 0x00538EF8
		public static IRefreshConditionBase GetRootAsIRefreshConditionBase(ByteBuffer _bb)
		{
			return IRefreshConditionBase.GetRootAsIRefreshConditionBase(_bb, default(IRefreshConditionBase));
		}

		// Token: 0x06025ED1 RID: 155345 RVA: 0x0053AD14 File Offset: 0x00538F14
		public static IRefreshConditionBase GetRootAsIRefreshConditionBase(ByteBuffer _bb, IRefreshConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025ED2 RID: 155346 RVA: 0x0053AD31 File Offset: 0x00538F31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025ED3 RID: 155347 RVA: 0x0053AD40 File Offset: 0x00538F40
		public IRefreshConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A87E RID: 43134
		// (get) Token: 0x06025ED4 RID: 155348 RVA: 0x0053AD50 File Offset: 0x00538F50
		public ERewardDropType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERewardDropType.Death;
				}
				return (ERewardDropType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025ED5 RID: 155349 RVA: 0x0053AD8C File Offset: 0x00538F8C
		public static Offset<IRefreshConditionBase> CreateIRefreshConditionBase(FlatBufferBuilder builder, ERewardDropType Type = ERewardDropType.Death)
		{
			builder.StartTable(1);
			IRefreshConditionBase.AddType(builder, Type);
			return IRefreshConditionBase.EndIRefreshConditionBase(builder);
		}

		// Token: 0x06025ED6 RID: 155350 RVA: 0x0053ADA2 File Offset: 0x00538FA2
		public static void StartIRefreshConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025ED7 RID: 155351 RVA: 0x0053ADAB File Offset: 0x00538FAB
		public static void AddType(FlatBufferBuilder builder, ERewardDropType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025ED8 RID: 155352 RVA: 0x0053ADB6 File Offset: 0x00538FB6
		public static Offset<IRefreshConditionBase> EndIRefreshConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshConditionBase>(builder.EndTable());
		}

		// Token: 0x06025ED9 RID: 155353 RVA: 0x0053ADC4 File Offset: 0x00538FC4
		public IRefreshConditionBaseT UnPack()
		{
			IRefreshConditionBaseT refreshConditionBaseT = new IRefreshConditionBaseT();
			this.UnPackTo(refreshConditionBaseT);
			return refreshConditionBaseT;
		}

		// Token: 0x06025EDA RID: 155354 RVA: 0x0053ADDF File Offset: 0x00538FDF
		public void UnPackTo(IRefreshConditionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025EDB RID: 155355 RVA: 0x0053ADF0 File Offset: 0x00538FF0
		public static Offset<IRefreshConditionBase> Pack(FlatBufferBuilder builder, IRefreshConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshConditionBase>);
			}
			return IRefreshConditionBase.CreateIRefreshConditionBase(builder, _o.Type);
		}

		// Token: 0x0400ED1F RID: 60703
		private Table __p;
	}
}

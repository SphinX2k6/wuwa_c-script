using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051A8 RID: 20904
	public struct IReachAreaCondtion : IFlatbufferObject
	{
		// Token: 0x170095BB RID: 38331
		// (get) Token: 0x06020E81 RID: 134785 RVA: 0x0048D700 File Offset: 0x0048B900
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020E82 RID: 134786 RVA: 0x0048D70D File Offset: 0x0048B90D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020E83 RID: 134787 RVA: 0x0048D714 File Offset: 0x0048B914
		public static IReachAreaCondtion GetRootAsIReachAreaCondtion(ByteBuffer _bb)
		{
			return IReachAreaCondtion.GetRootAsIReachAreaCondtion(_bb, default(IReachAreaCondtion));
		}

		// Token: 0x06020E84 RID: 134788 RVA: 0x0048D730 File Offset: 0x0048B930
		public static IReachAreaCondtion GetRootAsIReachAreaCondtion(ByteBuffer _bb, IReachAreaCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020E85 RID: 134789 RVA: 0x0048D74D File Offset: 0x0048B94D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020E86 RID: 134790 RVA: 0x0048D75C File Offset: 0x0048B95C
		public IReachAreaCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095BC RID: 38332
		// (get) Token: 0x06020E87 RID: 134791 RVA: 0x0048D76C File Offset: 0x0048B96C
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095BD RID: 38333
		// (get) Token: 0x06020E88 RID: 134792 RVA: 0x0048D7A8 File Offset: 0x0048B9A8
		public int RangeEntityId
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

		// Token: 0x06020E89 RID: 134793 RVA: 0x0048D7E4 File Offset: 0x0048B9E4
		public static Offset<IReachAreaCondtion> CreateIReachAreaCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int RangeEntityId = 0)
		{
			builder.StartTable(2);
			IReachAreaCondtion.AddRangeEntityId(builder, RangeEntityId);
			IReachAreaCondtion.AddType(builder, Type);
			return IReachAreaCondtion.EndIReachAreaCondtion(builder);
		}

		// Token: 0x06020E8A RID: 134794 RVA: 0x0048D801 File Offset: 0x0048BA01
		public static void StartIReachAreaCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020E8B RID: 134795 RVA: 0x0048D80A File Offset: 0x0048BA0A
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020E8C RID: 134796 RVA: 0x0048D815 File Offset: 0x0048BA15
		public static void AddRangeEntityId(FlatBufferBuilder builder, int rangeEntityId)
		{
			builder.AddInt(1, rangeEntityId, 0);
		}

		// Token: 0x06020E8D RID: 134797 RVA: 0x0048D820 File Offset: 0x0048BA20
		public static Offset<IReachAreaCondtion> EndIReachAreaCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IReachAreaCondtion>(builder.EndTable());
		}

		// Token: 0x06020E8E RID: 134798 RVA: 0x0048D830 File Offset: 0x0048BA30
		public IReachAreaCondtionT UnPack()
		{
			IReachAreaCondtionT reachAreaCondtionT = new IReachAreaCondtionT();
			this.UnPackTo(reachAreaCondtionT);
			return reachAreaCondtionT;
		}

		// Token: 0x06020E8F RID: 134799 RVA: 0x0048D84B File Offset: 0x0048BA4B
		public void UnPackTo(IReachAreaCondtionT _o)
		{
			_o.Type = this.Type;
			_o.RangeEntityId = this.RangeEntityId;
		}

		// Token: 0x06020E90 RID: 134800 RVA: 0x0048D868 File Offset: 0x0048BA68
		public static Offset<IReachAreaCondtion> Pack(FlatBufferBuilder builder, IReachAreaCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReachAreaCondtion>);
			}
			return IReachAreaCondtion.CreateIReachAreaCondtion(builder, _o.Type, _o.RangeEntityId);
		}

		// Token: 0x0400E199 RID: 57753
		private Table __p;
	}
}

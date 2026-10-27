using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CAF RID: 19631
	public struct IReachAreaCondtion : IFlatbufferObject
	{
		// Token: 0x17008E8D RID: 36493
		// (get) Token: 0x0601F25F RID: 127583 RVA: 0x00459BB0 File Offset: 0x00457DB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F260 RID: 127584 RVA: 0x00459BBD File Offset: 0x00457DBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F261 RID: 127585 RVA: 0x00459BC4 File Offset: 0x00457DC4
		public static IReachAreaCondtion GetRootAsIReachAreaCondtion(ByteBuffer _bb)
		{
			return IReachAreaCondtion.GetRootAsIReachAreaCondtion(_bb, default(IReachAreaCondtion));
		}

		// Token: 0x0601F262 RID: 127586 RVA: 0x00459BE0 File Offset: 0x00457DE0
		public static IReachAreaCondtion GetRootAsIReachAreaCondtion(ByteBuffer _bb, IReachAreaCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F263 RID: 127587 RVA: 0x00459BFD File Offset: 0x00457DFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F264 RID: 127588 RVA: 0x00459C0C File Offset: 0x00457E0C
		public IReachAreaCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E8E RID: 36494
		// (get) Token: 0x0601F265 RID: 127589 RVA: 0x00459C1C File Offset: 0x00457E1C
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

		// Token: 0x17008E8F RID: 36495
		// (get) Token: 0x0601F266 RID: 127590 RVA: 0x00459C58 File Offset: 0x00457E58
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

		// Token: 0x0601F267 RID: 127591 RVA: 0x00459C94 File Offset: 0x00457E94
		public static Offset<IReachAreaCondtion> CreateIReachAreaCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int RangeEntityId = 0)
		{
			builder.StartTable(2);
			IReachAreaCondtion.AddRangeEntityId(builder, RangeEntityId);
			IReachAreaCondtion.AddType(builder, Type);
			return IReachAreaCondtion.EndIReachAreaCondtion(builder);
		}

		// Token: 0x0601F268 RID: 127592 RVA: 0x00459CB1 File Offset: 0x00457EB1
		public static void StartIReachAreaCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F269 RID: 127593 RVA: 0x00459CBA File Offset: 0x00457EBA
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F26A RID: 127594 RVA: 0x00459CC5 File Offset: 0x00457EC5
		public static void AddRangeEntityId(FlatBufferBuilder builder, int rangeEntityId)
		{
			builder.AddInt(1, rangeEntityId, 0);
		}

		// Token: 0x0601F26B RID: 127595 RVA: 0x00459CD0 File Offset: 0x00457ED0
		public static Offset<IReachAreaCondtion> EndIReachAreaCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IReachAreaCondtion>(builder.EndTable());
		}

		// Token: 0x0601F26C RID: 127596 RVA: 0x00459CE0 File Offset: 0x00457EE0
		public IReachAreaCondtionT UnPack()
		{
			IReachAreaCondtionT reachAreaCondtionT = new IReachAreaCondtionT();
			this.UnPackTo(reachAreaCondtionT);
			return reachAreaCondtionT;
		}

		// Token: 0x0601F26D RID: 127597 RVA: 0x00459CFB File Offset: 0x00457EFB
		public void UnPackTo(IReachAreaCondtionT _o)
		{
			_o.Type = this.Type;
			_o.RangeEntityId = this.RangeEntityId;
		}

		// Token: 0x0601F26E RID: 127598 RVA: 0x00459D18 File Offset: 0x00457F18
		public static Offset<IReachAreaCondtion> Pack(FlatBufferBuilder builder, IReachAreaCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReachAreaCondtion>);
			}
			return IReachAreaCondtion.CreateIReachAreaCondtion(builder, _o.Type, _o.RangeEntityId);
		}

		// Token: 0x0400D672 RID: 54898
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ED5 RID: 20181
	public struct ICheckEntityReward : IFlatbufferObject
	{
		// Token: 0x1700901B RID: 36891
		// (get) Token: 0x0601F534 RID: 128308 RVA: 0x0045D96C File Offset: 0x0045BB6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F535 RID: 128309 RVA: 0x0045D979 File Offset: 0x0045BB79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F536 RID: 128310 RVA: 0x0045D980 File Offset: 0x0045BB80
		public static ICheckEntityReward GetRootAsICheckEntityReward(ByteBuffer _bb)
		{
			return ICheckEntityReward.GetRootAsICheckEntityReward(_bb, default(ICheckEntityReward));
		}

		// Token: 0x0601F537 RID: 128311 RVA: 0x0045D99C File Offset: 0x0045BB9C
		public static ICheckEntityReward GetRootAsICheckEntityReward(ByteBuffer _bb, ICheckEntityReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F538 RID: 128312 RVA: 0x0045D9B9 File Offset: 0x0045BBB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F539 RID: 128313 RVA: 0x0045D9C8 File Offset: 0x0045BBC8
		public ICheckEntityReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700901C RID: 36892
		// (get) Token: 0x0601F53A RID: 128314 RVA: 0x0045D9D8 File Offset: 0x0045BBD8
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

		// Token: 0x1700901D RID: 36893
		// (get) Token: 0x0601F53B RID: 128315 RVA: 0x0045DA14 File Offset: 0x0045BC14
		public int EntityId
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

		// Token: 0x1700901E RID: 36894
		// (get) Token: 0x0601F53C RID: 128316 RVA: 0x0045DA50 File Offset: 0x0045BC50
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F53D RID: 128317 RVA: 0x0045DA8C File Offset: 0x0045BC8C
		public static Offset<ICheckEntityReward> CreateICheckEntityReward(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICheckEntityReward.AddEntityId(builder, EntityId);
			ICheckEntityReward.AddNullMask(builder, NullMask);
			ICheckEntityReward.AddType(builder, Type);
			return ICheckEntityReward.EndICheckEntityReward(builder);
		}

		// Token: 0x0601F53E RID: 128318 RVA: 0x0045DAB0 File Offset: 0x0045BCB0
		public static void StartICheckEntityReward(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F53F RID: 128319 RVA: 0x0045DAB9 File Offset: 0x0045BCB9
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F540 RID: 128320 RVA: 0x0045DAC4 File Offset: 0x0045BCC4
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601F541 RID: 128321 RVA: 0x0045DACF File Offset: 0x0045BCCF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601F542 RID: 128322 RVA: 0x0045DADA File Offset: 0x0045BCDA
		public static Offset<ICheckEntityReward> EndICheckEntityReward(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityReward>(builder.EndTable());
		}

		// Token: 0x0601F543 RID: 128323 RVA: 0x0045DAE8 File Offset: 0x0045BCE8
		public ICheckEntityRewardT UnPack()
		{
			ICheckEntityRewardT checkEntityRewardT = new ICheckEntityRewardT();
			this.UnPackTo(checkEntityRewardT);
			return checkEntityRewardT;
		}

		// Token: 0x0601F544 RID: 128324 RVA: 0x0045DB03 File Offset: 0x0045BD03
		public void UnPackTo(ICheckEntityRewardT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F545 RID: 128325 RVA: 0x0045DB2C File Offset: 0x0045BD2C
		public static Offset<ICheckEntityReward> Pack(FlatBufferBuilder builder, ICheckEntityRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityReward>);
			}
			return ICheckEntityReward.CreateICheckEntityReward(builder, _o.Type, _o.EntityId, _o.NullMask);
		}

		// Token: 0x0400DD35 RID: 56629
		private Table __p;
	}
}

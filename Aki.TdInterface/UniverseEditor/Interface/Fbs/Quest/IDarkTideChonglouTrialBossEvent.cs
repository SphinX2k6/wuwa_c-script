using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041EA RID: 16874
	public struct IDarkTideChonglouTrialBossEvent : IFlatbufferObject
	{
		// Token: 0x170072F2 RID: 29426
		// (get) Token: 0x060176AC RID: 95916 RVA: 0x00358C2C File Offset: 0x00356E2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060176AD RID: 95917 RVA: 0x00358C39 File Offset: 0x00356E39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060176AE RID: 95918 RVA: 0x00358C40 File Offset: 0x00356E40
		public static IDarkTideChonglouTrialBossEvent GetRootAsIDarkTideChonglouTrialBossEvent(ByteBuffer _bb)
		{
			return IDarkTideChonglouTrialBossEvent.GetRootAsIDarkTideChonglouTrialBossEvent(_bb, default(IDarkTideChonglouTrialBossEvent));
		}

		// Token: 0x060176AF RID: 95919 RVA: 0x00358C5C File Offset: 0x00356E5C
		public static IDarkTideChonglouTrialBossEvent GetRootAsIDarkTideChonglouTrialBossEvent(ByteBuffer _bb, IDarkTideChonglouTrialBossEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060176B0 RID: 95920 RVA: 0x00358C79 File Offset: 0x00356E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060176B1 RID: 95921 RVA: 0x00358C88 File Offset: 0x00356E88
		public IDarkTideChonglouTrialBossEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072F3 RID: 29427
		// (get) Token: 0x060176B2 RID: 95922 RVA: 0x00358C98 File Offset: 0x00356E98
		public EDarkTideBossEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDarkTideBossEventType.XinjilemuChase;
				}
				return (EDarkTideBossEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060176B3 RID: 95923 RVA: 0x00358CD4 File Offset: 0x00356ED4
		public static Offset<IDarkTideChonglouTrialBossEvent> CreateIDarkTideChonglouTrialBossEvent(FlatBufferBuilder builder, EDarkTideBossEventType Type = EDarkTideBossEventType.XinjilemuChase)
		{
			builder.StartTable(1);
			IDarkTideChonglouTrialBossEvent.AddType(builder, Type);
			return IDarkTideChonglouTrialBossEvent.EndIDarkTideChonglouTrialBossEvent(builder);
		}

		// Token: 0x060176B4 RID: 95924 RVA: 0x00358CEA File Offset: 0x00356EEA
		public static void StartIDarkTideChonglouTrialBossEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060176B5 RID: 95925 RVA: 0x00358CF3 File Offset: 0x00356EF3
		public static void AddType(FlatBufferBuilder builder, EDarkTideBossEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060176B6 RID: 95926 RVA: 0x00358CFE File Offset: 0x00356EFE
		public static Offset<IDarkTideChonglouTrialBossEvent> EndIDarkTideChonglouTrialBossEvent(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideChonglouTrialBossEvent>(builder.EndTable());
		}

		// Token: 0x060176B7 RID: 95927 RVA: 0x00358D0C File Offset: 0x00356F0C
		public IDarkTideChonglouTrialBossEventT UnPack()
		{
			IDarkTideChonglouTrialBossEventT darkTideChonglouTrialBossEventT = new IDarkTideChonglouTrialBossEventT();
			this.UnPackTo(darkTideChonglouTrialBossEventT);
			return darkTideChonglouTrialBossEventT;
		}

		// Token: 0x060176B8 RID: 95928 RVA: 0x00358D27 File Offset: 0x00356F27
		public void UnPackTo(IDarkTideChonglouTrialBossEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060176B9 RID: 95929 RVA: 0x00358D38 File Offset: 0x00356F38
		public static Offset<IDarkTideChonglouTrialBossEvent> Pack(FlatBufferBuilder builder, IDarkTideChonglouTrialBossEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideChonglouTrialBossEvent>);
			}
			return IDarkTideChonglouTrialBossEvent.CreateIDarkTideChonglouTrialBossEvent(builder, _o.Type);
		}

		// Token: 0x0400C0C7 RID: 49351
		private Table __p;
	}
}

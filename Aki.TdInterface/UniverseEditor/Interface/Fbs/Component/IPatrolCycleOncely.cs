using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570A RID: 22282
	public struct IPatrolCycleOncely : IFlatbufferObject
	{
		// Token: 0x1700A5E6 RID: 42470
		// (get) Token: 0x06025411 RID: 152593 RVA: 0x00523FF2 File Offset: 0x005221F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025412 RID: 152594 RVA: 0x00523FFF File Offset: 0x005221FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025413 RID: 152595 RVA: 0x00524008 File Offset: 0x00522208
		public static IPatrolCycleOncely GetRootAsIPatrolCycleOncely(ByteBuffer _bb)
		{
			return IPatrolCycleOncely.GetRootAsIPatrolCycleOncely(_bb, default(IPatrolCycleOncely));
		}

		// Token: 0x06025414 RID: 152596 RVA: 0x00524024 File Offset: 0x00522224
		public static IPatrolCycleOncely GetRootAsIPatrolCycleOncely(ByteBuffer _bb, IPatrolCycleOncely obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025415 RID: 152597 RVA: 0x00524041 File Offset: 0x00522241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025416 RID: 152598 RVA: 0x00524050 File Offset: 0x00522250
		public IPatrolCycleOncely __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5E7 RID: 42471
		// (get) Token: 0x06025417 RID: 152599 RVA: 0x00524060 File Offset: 0x00522260
		public EPatrolCycleMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPatrolCycleMode.Loop;
				}
				return (EPatrolCycleMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025418 RID: 152600 RVA: 0x0052409C File Offset: 0x0052229C
		public static Offset<IPatrolCycleOncely> CreateIPatrolCycleOncely(FlatBufferBuilder builder, EPatrolCycleMode Type = EPatrolCycleMode.Loop)
		{
			builder.StartTable(1);
			IPatrolCycleOncely.AddType(builder, Type);
			return IPatrolCycleOncely.EndIPatrolCycleOncely(builder);
		}

		// Token: 0x06025419 RID: 152601 RVA: 0x005240B2 File Offset: 0x005222B2
		public static void StartIPatrolCycleOncely(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602541A RID: 152602 RVA: 0x005240BB File Offset: 0x005222BB
		public static void AddType(FlatBufferBuilder builder, EPatrolCycleMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602541B RID: 152603 RVA: 0x005240C6 File Offset: 0x005222C6
		public static Offset<IPatrolCycleOncely> EndIPatrolCycleOncely(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolCycleOncely>(builder.EndTable());
		}

		// Token: 0x0602541C RID: 152604 RVA: 0x005240D4 File Offset: 0x005222D4
		public IPatrolCycleOncelyT UnPack()
		{
			IPatrolCycleOncelyT patrolCycleOncelyT = new IPatrolCycleOncelyT();
			this.UnPackTo(patrolCycleOncelyT);
			return patrolCycleOncelyT;
		}

		// Token: 0x0602541D RID: 152605 RVA: 0x005240EF File Offset: 0x005222EF
		public void UnPackTo(IPatrolCycleOncelyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602541E RID: 152606 RVA: 0x00524100 File Offset: 0x00522300
		public static Offset<IPatrolCycleOncely> Pack(FlatBufferBuilder builder, IPatrolCycleOncelyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolCycleOncely>);
			}
			return IPatrolCycleOncely.CreateIPatrolCycleOncely(builder, _o.Type);
		}

		// Token: 0x0400EB6A RID: 60266
		private Table __p;
	}
}

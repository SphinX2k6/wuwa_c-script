using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582C RID: 22572
	public struct IRefreshOnDeath : IFlatbufferObject
	{
		// Token: 0x1700A8A1 RID: 43169
		// (get) Token: 0x06025F73 RID: 155507 RVA: 0x0053C1A2 File Offset: 0x0053A3A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025F74 RID: 155508 RVA: 0x0053C1AF File Offset: 0x0053A3AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025F75 RID: 155509 RVA: 0x0053C1B8 File Offset: 0x0053A3B8
		public static IRefreshOnDeath GetRootAsIRefreshOnDeath(ByteBuffer _bb)
		{
			return IRefreshOnDeath.GetRootAsIRefreshOnDeath(_bb, default(IRefreshOnDeath));
		}

		// Token: 0x06025F76 RID: 155510 RVA: 0x0053C1D4 File Offset: 0x0053A3D4
		public static IRefreshOnDeath GetRootAsIRefreshOnDeath(ByteBuffer _bb, IRefreshOnDeath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025F77 RID: 155511 RVA: 0x0053C1F1 File Offset: 0x0053A3F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025F78 RID: 155512 RVA: 0x0053C200 File Offset: 0x0053A400
		public IRefreshOnDeath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8A2 RID: 43170
		// (get) Token: 0x06025F79 RID: 155513 RVA: 0x0053C210 File Offset: 0x0053A410
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

		// Token: 0x06025F7A RID: 155514 RVA: 0x0053C24C File Offset: 0x0053A44C
		public static Offset<IRefreshOnDeath> CreateIRefreshOnDeath(FlatBufferBuilder builder, ERewardDropType Type = ERewardDropType.Death)
		{
			builder.StartTable(1);
			IRefreshOnDeath.AddType(builder, Type);
			return IRefreshOnDeath.EndIRefreshOnDeath(builder);
		}

		// Token: 0x06025F7B RID: 155515 RVA: 0x0053C262 File Offset: 0x0053A462
		public static void StartIRefreshOnDeath(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025F7C RID: 155516 RVA: 0x0053C26B File Offset: 0x0053A46B
		public static void AddType(FlatBufferBuilder builder, ERewardDropType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025F7D RID: 155517 RVA: 0x0053C276 File Offset: 0x0053A476
		public static Offset<IRefreshOnDeath> EndIRefreshOnDeath(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshOnDeath>(builder.EndTable());
		}

		// Token: 0x06025F7E RID: 155518 RVA: 0x0053C284 File Offset: 0x0053A484
		public IRefreshOnDeathT UnPack()
		{
			IRefreshOnDeathT refreshOnDeathT = new IRefreshOnDeathT();
			this.UnPackTo(refreshOnDeathT);
			return refreshOnDeathT;
		}

		// Token: 0x06025F7F RID: 155519 RVA: 0x0053C29F File Offset: 0x0053A49F
		public void UnPackTo(IRefreshOnDeathT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025F80 RID: 155520 RVA: 0x0053C2B0 File Offset: 0x0053A4B0
		public static Offset<IRefreshOnDeath> Pack(FlatBufferBuilder builder, IRefreshOnDeathT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshOnDeath>);
			}
			return IRefreshOnDeath.CreateIRefreshOnDeath(builder, _o.Type);
		}

		// Token: 0x0400ED3F RID: 60735
		private Table __p;
	}
}

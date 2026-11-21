using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E33 RID: 24115
	public struct IRefreshOnDeath : IFlatbufferObject
	{
		// Token: 0x1700B1C5 RID: 45509
		// (get) Token: 0x06028493 RID: 165011 RVA: 0x0058232E File Offset: 0x0058052E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028494 RID: 165012 RVA: 0x0058233B File Offset: 0x0058053B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028495 RID: 165013 RVA: 0x00582344 File Offset: 0x00580544
		public static IRefreshOnDeath GetRootAsIRefreshOnDeath(ByteBuffer _bb)
		{
			return IRefreshOnDeath.GetRootAsIRefreshOnDeath(_bb, default(IRefreshOnDeath));
		}

		// Token: 0x06028496 RID: 165014 RVA: 0x00582360 File Offset: 0x00580560
		public static IRefreshOnDeath GetRootAsIRefreshOnDeath(ByteBuffer _bb, IRefreshOnDeath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028497 RID: 165015 RVA: 0x0058237D File Offset: 0x0058057D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028498 RID: 165016 RVA: 0x0058238C File Offset: 0x0058058C
		public IRefreshOnDeath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1C6 RID: 45510
		// (get) Token: 0x06028499 RID: 165017 RVA: 0x0058239C File Offset: 0x0058059C
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

		// Token: 0x0602849A RID: 165018 RVA: 0x005823D8 File Offset: 0x005805D8
		public static Offset<IRefreshOnDeath> CreateIRefreshOnDeath(FlatBufferBuilder builder, ERewardDropType Type = ERewardDropType.Death)
		{
			builder.StartTable(1);
			IRefreshOnDeath.AddType(builder, Type);
			return IRefreshOnDeath.EndIRefreshOnDeath(builder);
		}

		// Token: 0x0602849B RID: 165019 RVA: 0x005823EE File Offset: 0x005805EE
		public static void StartIRefreshOnDeath(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602849C RID: 165020 RVA: 0x005823F7 File Offset: 0x005805F7
		public static void AddType(FlatBufferBuilder builder, ERewardDropType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602849D RID: 165021 RVA: 0x00582402 File Offset: 0x00580602
		public static Offset<IRefreshOnDeath> EndIRefreshOnDeath(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshOnDeath>(builder.EndTable());
		}

		// Token: 0x0602849E RID: 165022 RVA: 0x00582410 File Offset: 0x00580610
		public IRefreshOnDeathT UnPack()
		{
			IRefreshOnDeathT refreshOnDeathT = new IRefreshOnDeathT();
			this.UnPackTo(refreshOnDeathT);
			return refreshOnDeathT;
		}

		// Token: 0x0602849F RID: 165023 RVA: 0x0058242B File Offset: 0x0058062B
		public void UnPackTo(IRefreshOnDeathT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060284A0 RID: 165024 RVA: 0x0058243C File Offset: 0x0058063C
		public static Offset<IRefreshOnDeath> Pack(FlatBufferBuilder builder, IRefreshOnDeathT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshOnDeath>);
			}
			return IRefreshOnDeath.CreateIRefreshOnDeath(builder, _o.Type);
		}

		// Token: 0x0400FA2A RID: 64042
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B34 RID: 23348
	public struct IMonsterPerformConfig : IFlatbufferObject
	{
		// Token: 0x1700AA63 RID: 43619
		// (get) Token: 0x06026660 RID: 157280 RVA: 0x005425D5 File Offset: 0x005407D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026661 RID: 157281 RVA: 0x005425E2 File Offset: 0x005407E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026662 RID: 157282 RVA: 0x005425EC File Offset: 0x005407EC
		public static IMonsterPerformConfig GetRootAsIMonsterPerformConfig(ByteBuffer _bb)
		{
			return IMonsterPerformConfig.GetRootAsIMonsterPerformConfig(_bb, default(IMonsterPerformConfig));
		}

		// Token: 0x06026663 RID: 157283 RVA: 0x00542608 File Offset: 0x00540808
		public static IMonsterPerformConfig GetRootAsIMonsterPerformConfig(ByteBuffer _bb, IMonsterPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026664 RID: 157284 RVA: 0x00542625 File Offset: 0x00540825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026665 RID: 157285 RVA: 0x00542634 File Offset: 0x00540834
		public IMonsterPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA64 RID: 43620
		// (get) Token: 0x06026666 RID: 157286 RVA: 0x00542644 File Offset: 0x00540844
		public IMonsterShowOnDeathEffect? ShowOnDeath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IMonsterShowOnDeathEffect?(default(IMonsterShowOnDeathEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06026667 RID: 157287 RVA: 0x005426A1 File Offset: 0x005408A1
		public static Offset<IMonsterPerformConfig> CreateIMonsterPerformConfig(FlatBufferBuilder builder, Offset<IMonsterShowOnDeathEffect> ShowOnDeathOffset = default(Offset<IMonsterShowOnDeathEffect>))
		{
			builder.StartTable(1);
			IMonsterPerformConfig.AddShowOnDeath(builder, ShowOnDeathOffset);
			return IMonsterPerformConfig.EndIMonsterPerformConfig(builder);
		}

		// Token: 0x06026668 RID: 157288 RVA: 0x005426B7 File Offset: 0x005408B7
		public static void StartIMonsterPerformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026669 RID: 157289 RVA: 0x005426C0 File Offset: 0x005408C0
		public static void AddShowOnDeath(FlatBufferBuilder builder, Offset<IMonsterShowOnDeathEffect> showOnDeathOffset)
		{
			builder.AddOffset(0, showOnDeathOffset.Value, 0);
		}

		// Token: 0x0602666A RID: 157290 RVA: 0x005426D0 File Offset: 0x005408D0
		public static Offset<IMonsterPerformConfig> EndIMonsterPerformConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterPerformConfig>(builder.EndTable());
		}

		// Token: 0x0602666B RID: 157291 RVA: 0x005426E0 File Offset: 0x005408E0
		public IMonsterPerformConfigT UnPack()
		{
			IMonsterPerformConfigT monsterPerformConfigT = new IMonsterPerformConfigT();
			this.UnPackTo(monsterPerformConfigT);
			return monsterPerformConfigT;
		}

		// Token: 0x0602666C RID: 157292 RVA: 0x005426FC File Offset: 0x005408FC
		public void UnPackTo(IMonsterPerformConfigT _o)
		{
			_o.ShowOnDeath = ((this.ShowOnDeath != null) ? this.ShowOnDeath.Value.UnPack() : null);
		}

		// Token: 0x0602666D RID: 157293 RVA: 0x00542738 File Offset: 0x00540938
		public static Offset<IMonsterPerformConfig> Pack(FlatBufferBuilder builder, IMonsterPerformConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterPerformConfig>);
			}
			Offset<IMonsterShowOnDeathEffect> showOnDeathOffset = (_o.ShowOnDeath == null) ? default(Offset<IMonsterShowOnDeathEffect>) : IMonsterShowOnDeathEffect.Pack(builder, _o.ShowOnDeath);
			return IMonsterPerformConfig.CreateIMonsterPerformConfig(builder, showOnDeathOffset);
		}

		// Token: 0x0400F527 RID: 62759
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005596 RID: 21910
	public struct IMonsterPerformConfig : IFlatbufferObject
	{
		// Token: 0x1700A1DB RID: 41435
		// (get) Token: 0x06024453 RID: 148563 RVA: 0x0050205D File Offset: 0x0050025D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024454 RID: 148564 RVA: 0x0050206A File Offset: 0x0050026A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024455 RID: 148565 RVA: 0x00502074 File Offset: 0x00500274
		public static IMonsterPerformConfig GetRootAsIMonsterPerformConfig(ByteBuffer _bb)
		{
			return IMonsterPerformConfig.GetRootAsIMonsterPerformConfig(_bb, default(IMonsterPerformConfig));
		}

		// Token: 0x06024456 RID: 148566 RVA: 0x00502090 File Offset: 0x00500290
		public static IMonsterPerformConfig GetRootAsIMonsterPerformConfig(ByteBuffer _bb, IMonsterPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024457 RID: 148567 RVA: 0x005020AD File Offset: 0x005002AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024458 RID: 148568 RVA: 0x005020BC File Offset: 0x005002BC
		public IMonsterPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1DC RID: 41436
		// (get) Token: 0x06024459 RID: 148569 RVA: 0x005020CC File Offset: 0x005002CC
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

		// Token: 0x0602445A RID: 148570 RVA: 0x00502129 File Offset: 0x00500329
		public static Offset<IMonsterPerformConfig> CreateIMonsterPerformConfig(FlatBufferBuilder builder, Offset<IMonsterShowOnDeathEffect> ShowOnDeathOffset = default(Offset<IMonsterShowOnDeathEffect>))
		{
			builder.StartTable(1);
			IMonsterPerformConfig.AddShowOnDeath(builder, ShowOnDeathOffset);
			return IMonsterPerformConfig.EndIMonsterPerformConfig(builder);
		}

		// Token: 0x0602445B RID: 148571 RVA: 0x0050213F File Offset: 0x0050033F
		public static void StartIMonsterPerformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602445C RID: 148572 RVA: 0x00502148 File Offset: 0x00500348
		public static void AddShowOnDeath(FlatBufferBuilder builder, Offset<IMonsterShowOnDeathEffect> showOnDeathOffset)
		{
			builder.AddOffset(0, showOnDeathOffset.Value, 0);
		}

		// Token: 0x0602445D RID: 148573 RVA: 0x00502158 File Offset: 0x00500358
		public static Offset<IMonsterPerformConfig> EndIMonsterPerformConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterPerformConfig>(builder.EndTable());
		}

		// Token: 0x0602445E RID: 148574 RVA: 0x00502168 File Offset: 0x00500368
		public IMonsterPerformConfigT UnPack()
		{
			IMonsterPerformConfigT monsterPerformConfigT = new IMonsterPerformConfigT();
			this.UnPackTo(monsterPerformConfigT);
			return monsterPerformConfigT;
		}

		// Token: 0x0602445F RID: 148575 RVA: 0x00502184 File Offset: 0x00500384
		public void UnPackTo(IMonsterPerformConfigT _o)
		{
			_o.ShowOnDeath = ((this.ShowOnDeath != null) ? this.ShowOnDeath.Value.UnPack() : null);
		}

		// Token: 0x06024460 RID: 148576 RVA: 0x005021C0 File Offset: 0x005003C0
		public static Offset<IMonsterPerformConfig> Pack(FlatBufferBuilder builder, IMonsterPerformConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterPerformConfig>);
			}
			Offset<IMonsterShowOnDeathEffect> showOnDeathOffset = (_o.ShowOnDeath == null) ? default(Offset<IMonsterShowOnDeathEffect>) : IMonsterShowOnDeathEffect.Pack(builder, _o.ShowOnDeath);
			return IMonsterPerformConfig.CreateIMonsterPerformConfig(builder, showOnDeathOffset);
		}

		// Token: 0x0400E8C5 RID: 59589
		private Table __p;
	}
}

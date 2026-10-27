using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005599 RID: 21913
	public struct IMonsterShowOnDeathConfig : IFlatbufferObject
	{
		// Token: 0x1700A1DE RID: 41438
		// (get) Token: 0x06024465 RID: 148581 RVA: 0x0050225B File Offset: 0x0050045B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024466 RID: 148582 RVA: 0x00502268 File Offset: 0x00500468
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024467 RID: 148583 RVA: 0x00502270 File Offset: 0x00500470
		public static IMonsterShowOnDeathConfig GetRootAsIMonsterShowOnDeathConfig(ByteBuffer _bb)
		{
			return IMonsterShowOnDeathConfig.GetRootAsIMonsterShowOnDeathConfig(_bb, default(IMonsterShowOnDeathConfig));
		}

		// Token: 0x06024468 RID: 148584 RVA: 0x0050228C File Offset: 0x0050048C
		public static IMonsterShowOnDeathConfig GetRootAsIMonsterShowOnDeathConfig(ByteBuffer _bb, IMonsterShowOnDeathConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024469 RID: 148585 RVA: 0x005022A9 File Offset: 0x005004A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602446A RID: 148586 RVA: 0x005022B8 File Offset: 0x005004B8
		public IMonsterShowOnDeathConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1DF RID: 41439
		// (get) Token: 0x0602446B RID: 148587 RVA: 0x005022C8 File Offset: 0x005004C8
		public EMonsterShowOnDeathType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterShowOnDeathType.Effect;
				}
				return (EMonsterShowOnDeathType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602446C RID: 148588 RVA: 0x00502304 File Offset: 0x00500504
		public static Offset<IMonsterShowOnDeathConfig> CreateIMonsterShowOnDeathConfig(FlatBufferBuilder builder, EMonsterShowOnDeathType Type = EMonsterShowOnDeathType.Effect)
		{
			builder.StartTable(1);
			IMonsterShowOnDeathConfig.AddType(builder, Type);
			return IMonsterShowOnDeathConfig.EndIMonsterShowOnDeathConfig(builder);
		}

		// Token: 0x0602446D RID: 148589 RVA: 0x0050231A File Offset: 0x0050051A
		public static void StartIMonsterShowOnDeathConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602446E RID: 148590 RVA: 0x00502323 File Offset: 0x00500523
		public static void AddType(FlatBufferBuilder builder, EMonsterShowOnDeathType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602446F RID: 148591 RVA: 0x0050232E File Offset: 0x0050052E
		public static Offset<IMonsterShowOnDeathConfig> EndIMonsterShowOnDeathConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterShowOnDeathConfig>(builder.EndTable());
		}

		// Token: 0x06024470 RID: 148592 RVA: 0x0050233C File Offset: 0x0050053C
		public IMonsterShowOnDeathConfigT UnPack()
		{
			IMonsterShowOnDeathConfigT monsterShowOnDeathConfigT = new IMonsterShowOnDeathConfigT();
			this.UnPackTo(monsterShowOnDeathConfigT);
			return monsterShowOnDeathConfigT;
		}

		// Token: 0x06024471 RID: 148593 RVA: 0x00502357 File Offset: 0x00500557
		public void UnPackTo(IMonsterShowOnDeathConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024472 RID: 148594 RVA: 0x00502368 File Offset: 0x00500568
		public static Offset<IMonsterShowOnDeathConfig> Pack(FlatBufferBuilder builder, IMonsterShowOnDeathConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterShowOnDeathConfig>);
			}
			return IMonsterShowOnDeathConfig.CreateIMonsterShowOnDeathConfig(builder, _o.Type);
		}

		// Token: 0x0400E8C7 RID: 59591
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B37 RID: 23351
	public struct IMonsterShowOnDeathConfig : IFlatbufferObject
	{
		// Token: 0x1700AA66 RID: 43622
		// (get) Token: 0x06026672 RID: 157298 RVA: 0x005427D3 File Offset: 0x005409D3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026673 RID: 157299 RVA: 0x005427E0 File Offset: 0x005409E0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026674 RID: 157300 RVA: 0x005427E8 File Offset: 0x005409E8
		public static IMonsterShowOnDeathConfig GetRootAsIMonsterShowOnDeathConfig(ByteBuffer _bb)
		{
			return IMonsterShowOnDeathConfig.GetRootAsIMonsterShowOnDeathConfig(_bb, default(IMonsterShowOnDeathConfig));
		}

		// Token: 0x06026675 RID: 157301 RVA: 0x00542804 File Offset: 0x00540A04
		public static IMonsterShowOnDeathConfig GetRootAsIMonsterShowOnDeathConfig(ByteBuffer _bb, IMonsterShowOnDeathConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026676 RID: 157302 RVA: 0x00542821 File Offset: 0x00540A21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026677 RID: 157303 RVA: 0x00542830 File Offset: 0x00540A30
		public IMonsterShowOnDeathConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA67 RID: 43623
		// (get) Token: 0x06026678 RID: 157304 RVA: 0x00542840 File Offset: 0x00540A40
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

		// Token: 0x06026679 RID: 157305 RVA: 0x0054287C File Offset: 0x00540A7C
		public static Offset<IMonsterShowOnDeathConfig> CreateIMonsterShowOnDeathConfig(FlatBufferBuilder builder, EMonsterShowOnDeathType Type = EMonsterShowOnDeathType.Effect)
		{
			builder.StartTable(1);
			IMonsterShowOnDeathConfig.AddType(builder, Type);
			return IMonsterShowOnDeathConfig.EndIMonsterShowOnDeathConfig(builder);
		}

		// Token: 0x0602667A RID: 157306 RVA: 0x00542892 File Offset: 0x00540A92
		public static void StartIMonsterShowOnDeathConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602667B RID: 157307 RVA: 0x0054289B File Offset: 0x00540A9B
		public static void AddType(FlatBufferBuilder builder, EMonsterShowOnDeathType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602667C RID: 157308 RVA: 0x005428A6 File Offset: 0x00540AA6
		public static Offset<IMonsterShowOnDeathConfig> EndIMonsterShowOnDeathConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterShowOnDeathConfig>(builder.EndTable());
		}

		// Token: 0x0602667D RID: 157309 RVA: 0x005428B4 File Offset: 0x00540AB4
		public IMonsterShowOnDeathConfigT UnPack()
		{
			IMonsterShowOnDeathConfigT monsterShowOnDeathConfigT = new IMonsterShowOnDeathConfigT();
			this.UnPackTo(monsterShowOnDeathConfigT);
			return monsterShowOnDeathConfigT;
		}

		// Token: 0x0602667E RID: 157310 RVA: 0x005428CF File Offset: 0x00540ACF
		public void UnPackTo(IMonsterShowOnDeathConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602667F RID: 157311 RVA: 0x005428E0 File Offset: 0x00540AE0
		public static Offset<IMonsterShowOnDeathConfig> Pack(FlatBufferBuilder builder, IMonsterShowOnDeathConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterShowOnDeathConfig>);
			}
			return IMonsterShowOnDeathConfig.CreateIMonsterShowOnDeathConfig(builder, _o.Type);
		}

		// Token: 0x0400F529 RID: 62761
		private Table __p;
	}
}

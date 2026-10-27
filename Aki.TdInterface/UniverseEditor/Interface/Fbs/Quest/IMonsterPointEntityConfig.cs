using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F3E RID: 16190
	public struct IMonsterPointEntityConfig : IFlatbufferObject
	{
		// Token: 0x17007097 RID: 28823
		// (get) Token: 0x06017025 RID: 94245 RVA: 0x003518FF File Offset: 0x0034FAFF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017026 RID: 94246 RVA: 0x0035190C File Offset: 0x0034FB0C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017027 RID: 94247 RVA: 0x00351914 File Offset: 0x0034FB14
		public static IMonsterPointEntityConfig GetRootAsIMonsterPointEntityConfig(ByteBuffer _bb)
		{
			return IMonsterPointEntityConfig.GetRootAsIMonsterPointEntityConfig(_bb, default(IMonsterPointEntityConfig));
		}

		// Token: 0x06017028 RID: 94248 RVA: 0x00351930 File Offset: 0x0034FB30
		public static IMonsterPointEntityConfig GetRootAsIMonsterPointEntityConfig(ByteBuffer _bb, IMonsterPointEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017029 RID: 94249 RVA: 0x0035194D File Offset: 0x0034FB4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601702A RID: 94250 RVA: 0x0035195C File Offset: 0x0034FB5C
		public IMonsterPointEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007098 RID: 28824
		// (get) Token: 0x0601702B RID: 94251 RVA: 0x0035196C File Offset: 0x0034FB6C
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007099 RID: 28825
		// (get) Token: 0x0601702C RID: 94252 RVA: 0x003519A8 File Offset: 0x0034FBA8
		public int Point
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

		// Token: 0x0601702D RID: 94253 RVA: 0x003519E4 File Offset: 0x0034FBE4
		public static Offset<IMonsterPointEntityConfig> CreateIMonsterPointEntityConfig(FlatBufferBuilder builder, int EntityId = 0, int Point = 0)
		{
			builder.StartTable(2);
			IMonsterPointEntityConfig.AddPoint(builder, Point);
			IMonsterPointEntityConfig.AddEntityId(builder, EntityId);
			return IMonsterPointEntityConfig.EndIMonsterPointEntityConfig(builder);
		}

		// Token: 0x0601702E RID: 94254 RVA: 0x00351A01 File Offset: 0x0034FC01
		public static void StartIMonsterPointEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601702F RID: 94255 RVA: 0x00351A0A File Offset: 0x0034FC0A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06017030 RID: 94256 RVA: 0x00351A15 File Offset: 0x0034FC15
		public static void AddPoint(FlatBufferBuilder builder, int point)
		{
			builder.AddInt(1, point, 0);
		}

		// Token: 0x06017031 RID: 94257 RVA: 0x00351A20 File Offset: 0x0034FC20
		public static Offset<IMonsterPointEntityConfig> EndIMonsterPointEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterPointEntityConfig>(builder.EndTable());
		}

		// Token: 0x06017032 RID: 94258 RVA: 0x00351A30 File Offset: 0x0034FC30
		public IMonsterPointEntityConfigT UnPack()
		{
			IMonsterPointEntityConfigT monsterPointEntityConfigT = new IMonsterPointEntityConfigT();
			this.UnPackTo(monsterPointEntityConfigT);
			return monsterPointEntityConfigT;
		}

		// Token: 0x06017033 RID: 94259 RVA: 0x00351A4B File Offset: 0x0034FC4B
		public void UnPackTo(IMonsterPointEntityConfigT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Point = this.Point;
		}

		// Token: 0x06017034 RID: 94260 RVA: 0x00351A68 File Offset: 0x0034FC68
		public static Offset<IMonsterPointEntityConfig> Pack(FlatBufferBuilder builder, IMonsterPointEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterPointEntityConfig>);
			}
			return IMonsterPointEntityConfig.CreateIMonsterPointEntityConfig(builder, _o.EntityId, _o.Point);
		}

		// Token: 0x0400B94E RID: 47438
		private Table __p;
	}
}

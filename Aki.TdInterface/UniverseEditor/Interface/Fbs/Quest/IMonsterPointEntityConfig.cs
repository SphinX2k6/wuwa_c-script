using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200437C RID: 17276
	public struct IMonsterPointEntityConfig : IFlatbufferObject
	{
		// Token: 0x17007688 RID: 30344
		// (get) Token: 0x06018687 RID: 99975 RVA: 0x0037AD73 File Offset: 0x00378F73
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018688 RID: 99976 RVA: 0x0037AD80 File Offset: 0x00378F80
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018689 RID: 99977 RVA: 0x0037AD88 File Offset: 0x00378F88
		public static IMonsterPointEntityConfig GetRootAsIMonsterPointEntityConfig(ByteBuffer _bb)
		{
			return IMonsterPointEntityConfig.GetRootAsIMonsterPointEntityConfig(_bb, default(IMonsterPointEntityConfig));
		}

		// Token: 0x0601868A RID: 99978 RVA: 0x0037ADA4 File Offset: 0x00378FA4
		public static IMonsterPointEntityConfig GetRootAsIMonsterPointEntityConfig(ByteBuffer _bb, IMonsterPointEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601868B RID: 99979 RVA: 0x0037ADC1 File Offset: 0x00378FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601868C RID: 99980 RVA: 0x0037ADD0 File Offset: 0x00378FD0
		public IMonsterPointEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007689 RID: 30345
		// (get) Token: 0x0601868D RID: 99981 RVA: 0x0037ADE0 File Offset: 0x00378FE0
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

		// Token: 0x1700768A RID: 30346
		// (get) Token: 0x0601868E RID: 99982 RVA: 0x0037AE1C File Offset: 0x0037901C
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

		// Token: 0x0601868F RID: 99983 RVA: 0x0037AE58 File Offset: 0x00379058
		public static Offset<IMonsterPointEntityConfig> CreateIMonsterPointEntityConfig(FlatBufferBuilder builder, int EntityId = 0, int Point = 0)
		{
			builder.StartTable(2);
			IMonsterPointEntityConfig.AddPoint(builder, Point);
			IMonsterPointEntityConfig.AddEntityId(builder, EntityId);
			return IMonsterPointEntityConfig.EndIMonsterPointEntityConfig(builder);
		}

		// Token: 0x06018690 RID: 99984 RVA: 0x0037AE75 File Offset: 0x00379075
		public static void StartIMonsterPointEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018691 RID: 99985 RVA: 0x0037AE7E File Offset: 0x0037907E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06018692 RID: 99986 RVA: 0x0037AE89 File Offset: 0x00379089
		public static void AddPoint(FlatBufferBuilder builder, int point)
		{
			builder.AddInt(1, point, 0);
		}

		// Token: 0x06018693 RID: 99987 RVA: 0x0037AE94 File Offset: 0x00379094
		public static Offset<IMonsterPointEntityConfig> EndIMonsterPointEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterPointEntityConfig>(builder.EndTable());
		}

		// Token: 0x06018694 RID: 99988 RVA: 0x0037AEA4 File Offset: 0x003790A4
		public IMonsterPointEntityConfigT UnPack()
		{
			IMonsterPointEntityConfigT monsterPointEntityConfigT = new IMonsterPointEntityConfigT();
			this.UnPackTo(monsterPointEntityConfigT);
			return monsterPointEntityConfigT;
		}

		// Token: 0x06018695 RID: 99989 RVA: 0x0037AEBF File Offset: 0x003790BF
		public void UnPackTo(IMonsterPointEntityConfigT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Point = this.Point;
		}

		// Token: 0x06018696 RID: 99990 RVA: 0x0037AEDC File Offset: 0x003790DC
		public static Offset<IMonsterPointEntityConfig> Pack(FlatBufferBuilder builder, IMonsterPointEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterPointEntityConfig>);
			}
			return IMonsterPointEntityConfig.CreateIMonsterPointEntityConfig(builder, _o.EntityId, _o.Point);
		}

		// Token: 0x0400C32C RID: 49964
		private Table __p;
	}
}

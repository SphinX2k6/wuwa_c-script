using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DA6 RID: 23974
	public struct IEntityDirection : IFlatbufferObject
	{
		// Token: 0x1700B38D RID: 45965
		// (get) Token: 0x06029084 RID: 168068 RVA: 0x005A26CA File Offset: 0x005A08CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029085 RID: 168069 RVA: 0x005A26D7 File Offset: 0x005A08D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029086 RID: 168070 RVA: 0x005A26E0 File Offset: 0x005A08E0
		public static IEntityDirection GetRootAsIEntityDirection(ByteBuffer _bb)
		{
			return IEntityDirection.GetRootAsIEntityDirection(_bb, default(IEntityDirection));
		}

		// Token: 0x06029087 RID: 168071 RVA: 0x005A26FC File Offset: 0x005A08FC
		public static IEntityDirection GetRootAsIEntityDirection(ByteBuffer _bb, IEntityDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029088 RID: 168072 RVA: 0x005A2719 File Offset: 0x005A0919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029089 RID: 168073 RVA: 0x005A2728 File Offset: 0x005A0928
		public IEntityDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B38E RID: 45966
		// (get) Token: 0x0602908A RID: 168074 RVA: 0x005A2738 File Offset: 0x005A0938
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

		// Token: 0x1700B38F RID: 45967
		// (get) Token: 0x0602908B RID: 168075 RVA: 0x005A2774 File Offset: 0x005A0974
		public IVectorInfo? GravityDirection
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602908C RID: 168076 RVA: 0x005A27D1 File Offset: 0x005A09D1
		public static Offset<IEntityDirection> CreateIEntityDirection(FlatBufferBuilder builder, int EntityId = 0, Offset<IVectorInfo> GravityDirectionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IEntityDirection.AddGravityDirection(builder, GravityDirectionOffset);
			IEntityDirection.AddEntityId(builder, EntityId);
			return IEntityDirection.EndIEntityDirection(builder);
		}

		// Token: 0x0602908D RID: 168077 RVA: 0x005A27EE File Offset: 0x005A09EE
		public static void StartIEntityDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602908E RID: 168078 RVA: 0x005A27F7 File Offset: 0x005A09F7
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602908F RID: 168079 RVA: 0x005A2802 File Offset: 0x005A0A02
		public static void AddGravityDirection(FlatBufferBuilder builder, Offset<IVectorInfo> gravityDirectionOffset)
		{
			builder.AddOffset(1, gravityDirectionOffset.Value, 0);
		}

		// Token: 0x06029090 RID: 168080 RVA: 0x005A2812 File Offset: 0x005A0A12
		public static Offset<IEntityDirection> EndIEntityDirection(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDirection>(builder.EndTable());
		}

		// Token: 0x06029091 RID: 168081 RVA: 0x005A2820 File Offset: 0x005A0A20
		public IEntityDirectionT UnPack()
		{
			IEntityDirectionT entityDirectionT = new IEntityDirectionT();
			this.UnPackTo(entityDirectionT);
			return entityDirectionT;
		}

		// Token: 0x06029092 RID: 168082 RVA: 0x005A283C File Offset: 0x005A0A3C
		public void UnPackTo(IEntityDirectionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.GravityDirection = ((this.GravityDirection != null) ? this.GravityDirection.Value.UnPack() : null);
		}

		// Token: 0x06029093 RID: 168083 RVA: 0x005A2884 File Offset: 0x005A0A84
		public static Offset<IEntityDirection> Pack(FlatBufferBuilder builder, IEntityDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityDirection>);
			}
			Offset<IVectorInfo> gravityDirectionOffset = (_o.GravityDirection == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.GravityDirection);
			return IEntityDirection.CreateIEntityDirection(builder, _o.EntityId, gravityDirectionOffset);
		}

		// Token: 0x0400F781 RID: 63361
		private Table __p;
	}
}

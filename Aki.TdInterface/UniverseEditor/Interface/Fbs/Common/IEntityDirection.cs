using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063E3 RID: 25571
	public struct IEntityDirection : IFlatbufferObject
	{
		// Token: 0x1700BCF3 RID: 48371
		// (get) Token: 0x0602B70E RID: 177934 RVA: 0x005EB3FA File Offset: 0x005E95FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B70F RID: 177935 RVA: 0x005EB407 File Offset: 0x005E9607
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B710 RID: 177936 RVA: 0x005EB410 File Offset: 0x005E9610
		public static IEntityDirection GetRootAsIEntityDirection(ByteBuffer _bb)
		{
			return IEntityDirection.GetRootAsIEntityDirection(_bb, default(IEntityDirection));
		}

		// Token: 0x0602B711 RID: 177937 RVA: 0x005EB42C File Offset: 0x005E962C
		public static IEntityDirection GetRootAsIEntityDirection(ByteBuffer _bb, IEntityDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B712 RID: 177938 RVA: 0x005EB449 File Offset: 0x005E9649
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B713 RID: 177939 RVA: 0x005EB458 File Offset: 0x005E9658
		public IEntityDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCF4 RID: 48372
		// (get) Token: 0x0602B714 RID: 177940 RVA: 0x005EB468 File Offset: 0x005E9668
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

		// Token: 0x1700BCF5 RID: 48373
		// (get) Token: 0x0602B715 RID: 177941 RVA: 0x005EB4A4 File Offset: 0x005E96A4
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

		// Token: 0x0602B716 RID: 177942 RVA: 0x005EB501 File Offset: 0x005E9701
		public static Offset<IEntityDirection> CreateIEntityDirection(FlatBufferBuilder builder, int EntityId = 0, Offset<IVectorInfo> GravityDirectionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IEntityDirection.AddGravityDirection(builder, GravityDirectionOffset);
			IEntityDirection.AddEntityId(builder, EntityId);
			return IEntityDirection.EndIEntityDirection(builder);
		}

		// Token: 0x0602B717 RID: 177943 RVA: 0x005EB51E File Offset: 0x005E971E
		public static void StartIEntityDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B718 RID: 177944 RVA: 0x005EB527 File Offset: 0x005E9727
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602B719 RID: 177945 RVA: 0x005EB532 File Offset: 0x005E9732
		public static void AddGravityDirection(FlatBufferBuilder builder, Offset<IVectorInfo> gravityDirectionOffset)
		{
			builder.AddOffset(1, gravityDirectionOffset.Value, 0);
		}

		// Token: 0x0602B71A RID: 177946 RVA: 0x005EB542 File Offset: 0x005E9742
		public static Offset<IEntityDirection> EndIEntityDirection(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDirection>(builder.EndTable());
		}

		// Token: 0x0602B71B RID: 177947 RVA: 0x005EB550 File Offset: 0x005E9750
		public IEntityDirectionT UnPack()
		{
			IEntityDirectionT entityDirectionT = new IEntityDirectionT();
			this.UnPackTo(entityDirectionT);
			return entityDirectionT;
		}

		// Token: 0x0602B71C RID: 177948 RVA: 0x005EB56C File Offset: 0x005E976C
		public void UnPackTo(IEntityDirectionT _o)
		{
			_o.EntityId = this.EntityId;
			_o.GravityDirection = ((this.GravityDirection != null) ? this.GravityDirection.Value.UnPack() : null);
		}

		// Token: 0x0602B71D RID: 177949 RVA: 0x005EB5B4 File Offset: 0x005E97B4
		public static Offset<IEntityDirection> Pack(FlatBufferBuilder builder, IEntityDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityDirection>);
			}
			Offset<IVectorInfo> gravityDirectionOffset = (_o.GravityDirection == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.GravityDirection);
			return IEntityDirection.CreateIEntityDirection(builder, _o.EntityId, gravityDirectionOffset);
		}

		// Token: 0x040104DC RID: 66780
		private Table __p;
	}
}

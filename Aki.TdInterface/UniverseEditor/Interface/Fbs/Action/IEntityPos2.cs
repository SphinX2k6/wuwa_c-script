using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D67 RID: 28007
	public struct IEntityPos2 : IFlatbufferObject
	{
		// Token: 0x1700CD76 RID: 52598
		// (get) Token: 0x06030516 RID: 197910 RVA: 0x00690E95 File Offset: 0x0068F095
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030517 RID: 197911 RVA: 0x00690EA2 File Offset: 0x0068F0A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030518 RID: 197912 RVA: 0x00690EAC File Offset: 0x0068F0AC
		public static IEntityPos2 GetRootAsIEntityPos2(ByteBuffer _bb)
		{
			return IEntityPos2.GetRootAsIEntityPos2(_bb, default(IEntityPos2));
		}

		// Token: 0x06030519 RID: 197913 RVA: 0x00690EC8 File Offset: 0x0068F0C8
		public static IEntityPos2 GetRootAsIEntityPos2(ByteBuffer _bb, IEntityPos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603051A RID: 197914 RVA: 0x00690EE5 File Offset: 0x0068F0E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603051B RID: 197915 RVA: 0x00690EF4 File Offset: 0x0068F0F4
		public IEntityPos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD77 RID: 52599
		// (get) Token: 0x0603051C RID: 197916 RVA: 0x00690F04 File Offset: 0x0068F104
		public EPos2 Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPos2.Player;
				}
				return (EPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD78 RID: 52600
		// (get) Token: 0x0603051D RID: 197917 RVA: 0x00690F40 File Offset: 0x0068F140
		public int EntityId
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

		// Token: 0x1700CD79 RID: 52601
		// (get) Token: 0x0603051E RID: 197918 RVA: 0x00690F7C File Offset: 0x0068F17C
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603051F RID: 197919 RVA: 0x00690FD9 File Offset: 0x0068F1D9
		public static Offset<IEntityPos2> CreateIEntityPos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player, int EntityId = 0, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IEntityPos2.AddOffset(builder, OffsetOffset);
			IEntityPos2.AddEntityId(builder, EntityId);
			IEntityPos2.AddType(builder, Type);
			return IEntityPos2.EndIEntityPos2(builder);
		}

		// Token: 0x06030520 RID: 197920 RVA: 0x00690FFD File Offset: 0x0068F1FD
		public static void StartIEntityPos2(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030521 RID: 197921 RVA: 0x00691006 File Offset: 0x0068F206
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030522 RID: 197922 RVA: 0x00691011 File Offset: 0x0068F211
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06030523 RID: 197923 RVA: 0x0069101C File Offset: 0x0068F21C
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x06030524 RID: 197924 RVA: 0x0069102C File Offset: 0x0068F22C
		public static Offset<IEntityPos2> EndIEntityPos2(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPos2>(builder.EndTable());
		}

		// Token: 0x06030525 RID: 197925 RVA: 0x0069103C File Offset: 0x0068F23C
		public IEntityPos2T UnPack()
		{
			IEntityPos2T entityPos2T = new IEntityPos2T();
			this.UnPackTo(entityPos2T);
			return entityPos2T;
		}

		// Token: 0x06030526 RID: 197926 RVA: 0x00691058 File Offset: 0x0068F258
		public void UnPackTo(IEntityPos2T _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x06030527 RID: 197927 RVA: 0x006910AC File Offset: 0x0068F2AC
		public static Offset<IEntityPos2> Pack(FlatBufferBuilder builder, IEntityPos2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityPos2>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IEntityPos2.CreateIEntityPos2(builder, _o.Type, _o.EntityId, offsetOffset);
		}

		// Token: 0x04011BE8 RID: 72680
		private Table __p;
	}
}

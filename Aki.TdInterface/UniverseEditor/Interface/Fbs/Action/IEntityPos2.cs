using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E7 RID: 26343
	public struct IEntityPos2 : IFlatbufferObject
	{
		// Token: 0x1700C3C0 RID: 50112
		// (get) Token: 0x0602DCD9 RID: 187609 RVA: 0x00643921 File Offset: 0x00641B21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DCDA RID: 187610 RVA: 0x0064392E File Offset: 0x00641B2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DCDB RID: 187611 RVA: 0x00643938 File Offset: 0x00641B38
		public static IEntityPos2 GetRootAsIEntityPos2(ByteBuffer _bb)
		{
			return IEntityPos2.GetRootAsIEntityPos2(_bb, default(IEntityPos2));
		}

		// Token: 0x0602DCDC RID: 187612 RVA: 0x00643954 File Offset: 0x00641B54
		public static IEntityPos2 GetRootAsIEntityPos2(ByteBuffer _bb, IEntityPos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DCDD RID: 187613 RVA: 0x00643971 File Offset: 0x00641B71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DCDE RID: 187614 RVA: 0x00643980 File Offset: 0x00641B80
		public IEntityPos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3C1 RID: 50113
		// (get) Token: 0x0602DCDF RID: 187615 RVA: 0x00643990 File Offset: 0x00641B90
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

		// Token: 0x1700C3C2 RID: 50114
		// (get) Token: 0x0602DCE0 RID: 187616 RVA: 0x006439CC File Offset: 0x00641BCC
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

		// Token: 0x1700C3C3 RID: 50115
		// (get) Token: 0x0602DCE1 RID: 187617 RVA: 0x00643A08 File Offset: 0x00641C08
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

		// Token: 0x0602DCE2 RID: 187618 RVA: 0x00643A65 File Offset: 0x00641C65
		public static Offset<IEntityPos2> CreateIEntityPos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player, int EntityId = 0, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IEntityPos2.AddOffset(builder, OffsetOffset);
			IEntityPos2.AddEntityId(builder, EntityId);
			IEntityPos2.AddType(builder, Type);
			return IEntityPos2.EndIEntityPos2(builder);
		}

		// Token: 0x0602DCE3 RID: 187619 RVA: 0x00643A89 File Offset: 0x00641C89
		public static void StartIEntityPos2(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602DCE4 RID: 187620 RVA: 0x00643A92 File Offset: 0x00641C92
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DCE5 RID: 187621 RVA: 0x00643A9D File Offset: 0x00641C9D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602DCE6 RID: 187622 RVA: 0x00643AA8 File Offset: 0x00641CA8
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x0602DCE7 RID: 187623 RVA: 0x00643AB8 File Offset: 0x00641CB8
		public static Offset<IEntityPos2> EndIEntityPos2(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPos2>(builder.EndTable());
		}

		// Token: 0x0602DCE8 RID: 187624 RVA: 0x00643AC8 File Offset: 0x00641CC8
		public IEntityPos2T UnPack()
		{
			IEntityPos2T entityPos2T = new IEntityPos2T();
			this.UnPackTo(entityPos2T);
			return entityPos2T;
		}

		// Token: 0x0602DCE9 RID: 187625 RVA: 0x00643AE4 File Offset: 0x00641CE4
		public void UnPackTo(IEntityPos2T _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x0602DCEA RID: 187626 RVA: 0x00643B38 File Offset: 0x00641D38
		public static Offset<IEntityPos2> Pack(FlatBufferBuilder builder, IEntityPos2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityPos2>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IEntityPos2.CreateIEntityPos2(builder, _o.Type, _o.EntityId, offsetOffset);
		}

		// Token: 0x04010DB9 RID: 69049
		private Table __p;
	}
}

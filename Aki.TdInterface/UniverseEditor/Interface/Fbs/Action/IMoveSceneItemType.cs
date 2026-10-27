using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B57 RID: 27479
	public struct IMoveSceneItemType : IFlatbufferObject
	{
		// Token: 0x1700CC2C RID: 52268
		// (get) Token: 0x060303C1 RID: 197569 RVA: 0x0068DE28 File Offset: 0x0068C028
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060303C2 RID: 197570 RVA: 0x0068DE35 File Offset: 0x0068C035
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060303C3 RID: 197571 RVA: 0x0068DE3C File Offset: 0x0068C03C
		public static IMoveSceneItemType GetRootAsIMoveSceneItemType(ByteBuffer _bb)
		{
			return IMoveSceneItemType.GetRootAsIMoveSceneItemType(_bb, default(IMoveSceneItemType));
		}

		// Token: 0x060303C4 RID: 197572 RVA: 0x0068DE58 File Offset: 0x0068C058
		public static IMoveSceneItemType GetRootAsIMoveSceneItemType(ByteBuffer _bb, IMoveSceneItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060303C5 RID: 197573 RVA: 0x0068DE75 File Offset: 0x0068C075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060303C6 RID: 197574 RVA: 0x0068DE84 File Offset: 0x0068C084
		public IMoveSceneItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC2D RID: 52269
		// (get) Token: 0x060303C7 RID: 197575 RVA: 0x0068DE94 File Offset: 0x0068C094
		public EMoveSceneItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMoveSceneItemType.MoveToPoint;
				}
				return (EMoveSceneItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060303C8 RID: 197576 RVA: 0x0068DED0 File Offset: 0x0068C0D0
		public static Offset<IMoveSceneItemType> CreateIMoveSceneItemType(FlatBufferBuilder builder, EMoveSceneItemType Type = EMoveSceneItemType.MoveToPoint)
		{
			builder.StartTable(1);
			IMoveSceneItemType.AddType(builder, Type);
			return IMoveSceneItemType.EndIMoveSceneItemType(builder);
		}

		// Token: 0x060303C9 RID: 197577 RVA: 0x0068DEE6 File Offset: 0x0068C0E6
		public static void StartIMoveSceneItemType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060303CA RID: 197578 RVA: 0x0068DEEF File Offset: 0x0068C0EF
		public static void AddType(FlatBufferBuilder builder, EMoveSceneItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060303CB RID: 197579 RVA: 0x0068DEFA File Offset: 0x0068C0FA
		public static Offset<IMoveSceneItemType> EndIMoveSceneItemType(FlatBufferBuilder builder)
		{
			return new Offset<IMoveSceneItemType>(builder.EndTable());
		}

		// Token: 0x060303CC RID: 197580 RVA: 0x0068DF08 File Offset: 0x0068C108
		public IMoveSceneItemTypeT UnPack()
		{
			IMoveSceneItemTypeT moveSceneItemTypeT = new IMoveSceneItemTypeT();
			this.UnPackTo(moveSceneItemTypeT);
			return moveSceneItemTypeT;
		}

		// Token: 0x060303CD RID: 197581 RVA: 0x0068DF23 File Offset: 0x0068C123
		public void UnPackTo(IMoveSceneItemTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060303CE RID: 197582 RVA: 0x0068DF34 File Offset: 0x0068C134
		public static Offset<IMoveSceneItemType> Pack(FlatBufferBuilder builder, IMoveSceneItemTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveSceneItemType>);
			}
			return IMoveSceneItemType.CreateIMoveSceneItemType(builder, _o.Type);
		}

		// Token: 0x040113FC RID: 70652
		private Table __p;
	}
}

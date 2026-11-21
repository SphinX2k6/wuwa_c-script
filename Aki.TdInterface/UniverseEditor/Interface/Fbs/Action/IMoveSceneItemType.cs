using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200729D RID: 29341
	public struct IMoveSceneItemType : IFlatbufferObject
	{
		// Token: 0x1700D711 RID: 55057
		// (get) Token: 0x06033218 RID: 209432 RVA: 0x006E63E4 File Offset: 0x006E45E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033219 RID: 209433 RVA: 0x006E63F1 File Offset: 0x006E45F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603321A RID: 209434 RVA: 0x006E63F8 File Offset: 0x006E45F8
		public static IMoveSceneItemType GetRootAsIMoveSceneItemType(ByteBuffer _bb)
		{
			return IMoveSceneItemType.GetRootAsIMoveSceneItemType(_bb, default(IMoveSceneItemType));
		}

		// Token: 0x0603321B RID: 209435 RVA: 0x006E6414 File Offset: 0x006E4614
		public static IMoveSceneItemType GetRootAsIMoveSceneItemType(ByteBuffer _bb, IMoveSceneItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603321C RID: 209436 RVA: 0x006E6431 File Offset: 0x006E4631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603321D RID: 209437 RVA: 0x006E6440 File Offset: 0x006E4640
		public IMoveSceneItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D712 RID: 55058
		// (get) Token: 0x0603321E RID: 209438 RVA: 0x006E6450 File Offset: 0x006E4650
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

		// Token: 0x0603321F RID: 209439 RVA: 0x006E648C File Offset: 0x006E468C
		public static Offset<IMoveSceneItemType> CreateIMoveSceneItemType(FlatBufferBuilder builder, EMoveSceneItemType Type = EMoveSceneItemType.MoveToPoint)
		{
			builder.StartTable(1);
			IMoveSceneItemType.AddType(builder, Type);
			return IMoveSceneItemType.EndIMoveSceneItemType(builder);
		}

		// Token: 0x06033220 RID: 209440 RVA: 0x006E64A2 File Offset: 0x006E46A2
		public static void StartIMoveSceneItemType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033221 RID: 209441 RVA: 0x006E64AB File Offset: 0x006E46AB
		public static void AddType(FlatBufferBuilder builder, EMoveSceneItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033222 RID: 209442 RVA: 0x006E64B6 File Offset: 0x006E46B6
		public static Offset<IMoveSceneItemType> EndIMoveSceneItemType(FlatBufferBuilder builder)
		{
			return new Offset<IMoveSceneItemType>(builder.EndTable());
		}

		// Token: 0x06033223 RID: 209443 RVA: 0x006E64C4 File Offset: 0x006E46C4
		public IMoveSceneItemTypeT UnPack()
		{
			IMoveSceneItemTypeT moveSceneItemTypeT = new IMoveSceneItemTypeT();
			this.UnPackTo(moveSceneItemTypeT);
			return moveSceneItemTypeT;
		}

		// Token: 0x06033224 RID: 209444 RVA: 0x006E64DF File Offset: 0x006E46DF
		public void UnPackTo(IMoveSceneItemTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033225 RID: 209445 RVA: 0x006E64F0 File Offset: 0x006E46F0
		public static Offset<IMoveSceneItemType> Pack(FlatBufferBuilder builder, IMoveSceneItemTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveSceneItemType>);
			}
			return IMoveSceneItemType.CreateIMoveSceneItemType(builder, _o.Type);
		}

		// Token: 0x04012325 RID: 74533
		private Table __p;
	}
}

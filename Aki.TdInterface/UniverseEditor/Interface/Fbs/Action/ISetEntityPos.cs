using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE3 RID: 28643
	public struct ISetEntityPos : IFlatbufferObject
	{
		// Token: 0x1700D4A6 RID: 54438
		// (get) Token: 0x06032A34 RID: 207412 RVA: 0x006D4EE3 File Offset: 0x006D30E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A35 RID: 207413 RVA: 0x006D4EF0 File Offset: 0x006D30F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A36 RID: 207414 RVA: 0x006D4EF8 File Offset: 0x006D30F8
		public static ISetEntityPos GetRootAsISetEntityPos(ByteBuffer _bb)
		{
			return ISetEntityPos.GetRootAsISetEntityPos(_bb, default(ISetEntityPos));
		}

		// Token: 0x06032A37 RID: 207415 RVA: 0x006D4F14 File Offset: 0x006D3114
		public static ISetEntityPos GetRootAsISetEntityPos(ByteBuffer _bb, ISetEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032A38 RID: 207416 RVA: 0x006D4F31 File Offset: 0x006D3131
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032A39 RID: 207417 RVA: 0x006D4F40 File Offset: 0x006D3140
		public ISetEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4A7 RID: 54439
		// (get) Token: 0x06032A3A RID: 207418 RVA: 0x006D4F50 File Offset: 0x006D3150
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

		// Token: 0x1700D4A8 RID: 54440
		// (get) Token: 0x06032A3B RID: 207419 RVA: 0x006D4F8C File Offset: 0x006D318C
		public IPosA? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D4A9 RID: 54441
		// (get) Token: 0x06032A3C RID: 207420 RVA: 0x006D4FEC File Offset: 0x006D31EC
		public IVectorInfo? Rot
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

		// Token: 0x06032A3D RID: 207421 RVA: 0x006D5049 File Offset: 0x006D3249
		public static Offset<ISetEntityPos> CreateISetEntityPos(FlatBufferBuilder builder, int EntityId = 0, Offset<IPosA> PosOffset = default(Offset<IPosA>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ISetEntityPos.AddRot(builder, RotOffset);
			ISetEntityPos.AddPos(builder, PosOffset);
			ISetEntityPos.AddEntityId(builder, EntityId);
			return ISetEntityPos.EndISetEntityPos(builder);
		}

		// Token: 0x06032A3E RID: 207422 RVA: 0x006D506D File Offset: 0x006D326D
		public static void StartISetEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032A3F RID: 207423 RVA: 0x006D5076 File Offset: 0x006D3276
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06032A40 RID: 207424 RVA: 0x006D5081 File Offset: 0x006D3281
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06032A41 RID: 207425 RVA: 0x006D5091 File Offset: 0x006D3291
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(2, rotOffset.Value, 0);
		}

		// Token: 0x06032A42 RID: 207426 RVA: 0x006D50A1 File Offset: 0x006D32A1
		public static Offset<ISetEntityPos> EndISetEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<ISetEntityPos>(builder.EndTable());
		}

		// Token: 0x06032A43 RID: 207427 RVA: 0x006D50B0 File Offset: 0x006D32B0
		public ISetEntityPosT UnPack()
		{
			ISetEntityPosT setEntityPosT = new ISetEntityPosT();
			this.UnPackTo(setEntityPosT);
			return setEntityPosT;
		}

		// Token: 0x06032A44 RID: 207428 RVA: 0x006D50CC File Offset: 0x006D32CC
		public void UnPackTo(ISetEntityPosT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x06032A45 RID: 207429 RVA: 0x006D5144 File Offset: 0x006D3344
		public static Offset<ISetEntityPos> Pack(FlatBufferBuilder builder, ISetEntityPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetEntityPos>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return ISetEntityPos.CreateISetEntityPos(builder, _o.EntityId, posOffset, rotOffset);
		}

		// Token: 0x040119F1 RID: 72177
		private Table __p;
	}
}

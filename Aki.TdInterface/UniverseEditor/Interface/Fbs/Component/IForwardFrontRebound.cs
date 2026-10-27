using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052BB RID: 21179
	public struct IForwardFrontRebound : IFlatbufferObject
	{
		// Token: 0x17009B4A RID: 39754
		// (get) Token: 0x0602287B RID: 141435 RVA: 0x004C9259 File Offset: 0x004C7459
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602287C RID: 141436 RVA: 0x004C9266 File Offset: 0x004C7466
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602287D RID: 141437 RVA: 0x004C9270 File Offset: 0x004C7470
		public static IForwardFrontRebound GetRootAsIForwardFrontRebound(ByteBuffer _bb)
		{
			return IForwardFrontRebound.GetRootAsIForwardFrontRebound(_bb, default(IForwardFrontRebound));
		}

		// Token: 0x0602287E RID: 141438 RVA: 0x004C928C File Offset: 0x004C748C
		public static IForwardFrontRebound GetRootAsIForwardFrontRebound(ByteBuffer _bb, IForwardFrontRebound obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602287F RID: 141439 RVA: 0x004C92A9 File Offset: 0x004C74A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022880 RID: 141440 RVA: 0x004C92B8 File Offset: 0x004C74B8
		public IForwardFrontRebound __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B4B RID: 39755
		// (get) Token: 0x06022881 RID: 141441 RVA: 0x004C92C8 File Offset: 0x004C74C8
		public EReboundOptionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EReboundOptionType.ForwardFront;
				}
				return (EReboundOptionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B4C RID: 39756
		// (get) Token: 0x06022882 RID: 141442 RVA: 0x004C9304 File Offset: 0x004C7504
		public IVectorInfo? ReboundPoint
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

		// Token: 0x06022883 RID: 141443 RVA: 0x004C9361 File Offset: 0x004C7561
		public static Offset<IForwardFrontRebound> CreateIForwardFrontRebound(FlatBufferBuilder builder, EReboundOptionType Type = EReboundOptionType.ForwardFront, Offset<IVectorInfo> ReboundPointOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IForwardFrontRebound.AddReboundPoint(builder, ReboundPointOffset);
			IForwardFrontRebound.AddType(builder, Type);
			return IForwardFrontRebound.EndIForwardFrontRebound(builder);
		}

		// Token: 0x06022884 RID: 141444 RVA: 0x004C937E File Offset: 0x004C757E
		public static void StartIForwardFrontRebound(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022885 RID: 141445 RVA: 0x004C9387 File Offset: 0x004C7587
		public static void AddType(FlatBufferBuilder builder, EReboundOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022886 RID: 141446 RVA: 0x004C9392 File Offset: 0x004C7592
		public static void AddReboundPoint(FlatBufferBuilder builder, Offset<IVectorInfo> reboundPointOffset)
		{
			builder.AddOffset(1, reboundPointOffset.Value, 0);
		}

		// Token: 0x06022887 RID: 141447 RVA: 0x004C93A2 File Offset: 0x004C75A2
		public static Offset<IForwardFrontRebound> EndIForwardFrontRebound(FlatBufferBuilder builder)
		{
			return new Offset<IForwardFrontRebound>(builder.EndTable());
		}

		// Token: 0x06022888 RID: 141448 RVA: 0x004C93B0 File Offset: 0x004C75B0
		public IForwardFrontReboundT UnPack()
		{
			IForwardFrontReboundT forwardFrontReboundT = new IForwardFrontReboundT();
			this.UnPackTo(forwardFrontReboundT);
			return forwardFrontReboundT;
		}

		// Token: 0x06022889 RID: 141449 RVA: 0x004C93CC File Offset: 0x004C75CC
		public void UnPackTo(IForwardFrontReboundT _o)
		{
			_o.Type = this.Type;
			_o.ReboundPoint = ((this.ReboundPoint != null) ? this.ReboundPoint.Value.UnPack() : null);
		}

		// Token: 0x0602288A RID: 141450 RVA: 0x004C9414 File Offset: 0x004C7614
		public static Offset<IForwardFrontRebound> Pack(FlatBufferBuilder builder, IForwardFrontReboundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IForwardFrontRebound>);
			}
			Offset<IVectorInfo> reboundPointOffset = (_o.ReboundPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ReboundPoint);
			return IForwardFrontRebound.CreateIForwardFrontRebound(builder, _o.Type, reboundPointOffset);
		}

		// Token: 0x0400E43B RID: 58427
		private Table __p;
	}
}

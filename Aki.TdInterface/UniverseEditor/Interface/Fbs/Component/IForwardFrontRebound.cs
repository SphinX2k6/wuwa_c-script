using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005826 RID: 22566
	public struct IForwardFrontRebound : IFlatbufferObject
	{
		// Token: 0x1700A353 RID: 41811
		// (get) Token: 0x0602483F RID: 149567 RVA: 0x00504355 File Offset: 0x00502555
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024840 RID: 149568 RVA: 0x00504362 File Offset: 0x00502562
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024841 RID: 149569 RVA: 0x0050436C File Offset: 0x0050256C
		public static IForwardFrontRebound GetRootAsIForwardFrontRebound(ByteBuffer _bb)
		{
			return IForwardFrontRebound.GetRootAsIForwardFrontRebound(_bb, default(IForwardFrontRebound));
		}

		// Token: 0x06024842 RID: 149570 RVA: 0x00504388 File Offset: 0x00502588
		public static IForwardFrontRebound GetRootAsIForwardFrontRebound(ByteBuffer _bb, IForwardFrontRebound obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024843 RID: 149571 RVA: 0x005043A5 File Offset: 0x005025A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024844 RID: 149572 RVA: 0x005043B4 File Offset: 0x005025B4
		public IForwardFrontRebound __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A354 RID: 41812
		// (get) Token: 0x06024845 RID: 149573 RVA: 0x005043C4 File Offset: 0x005025C4
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

		// Token: 0x1700A355 RID: 41813
		// (get) Token: 0x06024846 RID: 149574 RVA: 0x00504400 File Offset: 0x00502600
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

		// Token: 0x06024847 RID: 149575 RVA: 0x0050445D File Offset: 0x0050265D
		public static Offset<IForwardFrontRebound> CreateIForwardFrontRebound(FlatBufferBuilder builder, EReboundOptionType Type = EReboundOptionType.ForwardFront, Offset<IVectorInfo> ReboundPointOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IForwardFrontRebound.AddReboundPoint(builder, ReboundPointOffset);
			IForwardFrontRebound.AddType(builder, Type);
			return IForwardFrontRebound.EndIForwardFrontRebound(builder);
		}

		// Token: 0x06024848 RID: 149576 RVA: 0x0050447A File Offset: 0x0050267A
		public static void StartIForwardFrontRebound(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024849 RID: 149577 RVA: 0x00504483 File Offset: 0x00502683
		public static void AddType(FlatBufferBuilder builder, EReboundOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602484A RID: 149578 RVA: 0x0050448E File Offset: 0x0050268E
		public static void AddReboundPoint(FlatBufferBuilder builder, Offset<IVectorInfo> reboundPointOffset)
		{
			builder.AddOffset(1, reboundPointOffset.Value, 0);
		}

		// Token: 0x0602484B RID: 149579 RVA: 0x0050449E File Offset: 0x0050269E
		public static Offset<IForwardFrontRebound> EndIForwardFrontRebound(FlatBufferBuilder builder)
		{
			return new Offset<IForwardFrontRebound>(builder.EndTable());
		}

		// Token: 0x0602484C RID: 149580 RVA: 0x005044AC File Offset: 0x005026AC
		public IForwardFrontReboundT UnPack()
		{
			IForwardFrontReboundT forwardFrontReboundT = new IForwardFrontReboundT();
			this.UnPackTo(forwardFrontReboundT);
			return forwardFrontReboundT;
		}

		// Token: 0x0602484D RID: 149581 RVA: 0x005044C8 File Offset: 0x005026C8
		public void UnPackTo(IForwardFrontReboundT _o)
		{
			_o.Type = this.Type;
			_o.ReboundPoint = ((this.ReboundPoint != null) ? this.ReboundPoint.Value.UnPack() : null);
		}

		// Token: 0x0602484E RID: 149582 RVA: 0x00504510 File Offset: 0x00502710
		public static Offset<IForwardFrontRebound> Pack(FlatBufferBuilder builder, IForwardFrontReboundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IForwardFrontRebound>);
			}
			Offset<IVectorInfo> reboundPointOffset = (_o.ReboundPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ReboundPoint);
			return IForwardFrontRebound.CreateIForwardFrontRebound(builder, _o.Type, reboundPointOffset);
		}

		// Token: 0x0400F048 RID: 61512
		private Table __p;
	}
}

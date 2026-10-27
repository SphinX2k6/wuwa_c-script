using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D08 RID: 27912
	public struct IPlayerNewSplineStopTarget : IFlatbufferObject
	{
		// Token: 0x1700CFDC RID: 53212
		// (get) Token: 0x06031384 RID: 201604 RVA: 0x006AD425 File Offset: 0x006AB625
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031385 RID: 201605 RVA: 0x006AD432 File Offset: 0x006AB632
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031386 RID: 201606 RVA: 0x006AD43C File Offset: 0x006AB63C
		public static IPlayerNewSplineStopTarget GetRootAsIPlayerNewSplineStopTarget(ByteBuffer _bb)
		{
			return IPlayerNewSplineStopTarget.GetRootAsIPlayerNewSplineStopTarget(_bb, default(IPlayerNewSplineStopTarget));
		}

		// Token: 0x06031387 RID: 201607 RVA: 0x006AD458 File Offset: 0x006AB658
		public static IPlayerNewSplineStopTarget GetRootAsIPlayerNewSplineStopTarget(ByteBuffer _bb, IPlayerNewSplineStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031388 RID: 201608 RVA: 0x006AD475 File Offset: 0x006AB675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031389 RID: 201609 RVA: 0x006AD484 File Offset: 0x006AB684
		public IPlayerNewSplineStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFDD RID: 53213
		// (get) Token: 0x0603138A RID: 201610 RVA: 0x006AD494 File Offset: 0x006AB694
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603138B RID: 201611 RVA: 0x006AD4D0 File Offset: 0x006AB6D0
		public static Offset<IPlayerNewSplineStopTarget> CreateIPlayerNewSplineStopTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player)
		{
			builder.StartTable(1);
			IPlayerNewSplineStopTarget.AddType(builder, Type);
			return IPlayerNewSplineStopTarget.EndIPlayerNewSplineStopTarget(builder);
		}

		// Token: 0x0603138C RID: 201612 RVA: 0x006AD4E6 File Offset: 0x006AB6E6
		public static void StartIPlayerNewSplineStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603138D RID: 201613 RVA: 0x006AD4EF File Offset: 0x006AB6EF
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603138E RID: 201614 RVA: 0x006AD4FA File Offset: 0x006AB6FA
		public static Offset<IPlayerNewSplineStopTarget> EndIPlayerNewSplineStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerNewSplineStopTarget>(builder.EndTable());
		}

		// Token: 0x0603138F RID: 201615 RVA: 0x006AD508 File Offset: 0x006AB708
		public IPlayerNewSplineStopTargetT UnPack()
		{
			IPlayerNewSplineStopTargetT playerNewSplineStopTargetT = new IPlayerNewSplineStopTargetT();
			this.UnPackTo(playerNewSplineStopTargetT);
			return playerNewSplineStopTargetT;
		}

		// Token: 0x06031390 RID: 201616 RVA: 0x006AD523 File Offset: 0x006AB723
		public void UnPackTo(IPlayerNewSplineStopTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031391 RID: 201617 RVA: 0x006AD534 File Offset: 0x006AB734
		public static Offset<IPlayerNewSplineStopTarget> Pack(FlatBufferBuilder builder, IPlayerNewSplineStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerNewSplineStopTarget>);
			}
			return IPlayerNewSplineStopTarget.CreateIPlayerNewSplineStopTarget(builder, _o.Type);
		}

		// Token: 0x04011685 RID: 71301
		private Table __p;
	}
}

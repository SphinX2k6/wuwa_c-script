using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072EC RID: 29420
	public struct INewSplineStopTarget : IFlatbufferObject
	{
		// Token: 0x1700D7B6 RID: 55222
		// (get) Token: 0x060334BD RID: 210109 RVA: 0x006EB4A2 File Offset: 0x006E96A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060334BE RID: 210110 RVA: 0x006EB4AF File Offset: 0x006E96AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060334BF RID: 210111 RVA: 0x006EB4B8 File Offset: 0x006E96B8
		public static INewSplineStopTarget GetRootAsINewSplineStopTarget(ByteBuffer _bb)
		{
			return INewSplineStopTarget.GetRootAsINewSplineStopTarget(_bb, default(INewSplineStopTarget));
		}

		// Token: 0x060334C0 RID: 210112 RVA: 0x006EB4D4 File Offset: 0x006E96D4
		public static INewSplineStopTarget GetRootAsINewSplineStopTarget(ByteBuffer _bb, INewSplineStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060334C1 RID: 210113 RVA: 0x006EB4F1 File Offset: 0x006E96F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060334C2 RID: 210114 RVA: 0x006EB500 File Offset: 0x006E9700
		public INewSplineStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7B7 RID: 55223
		// (get) Token: 0x060334C3 RID: 210115 RVA: 0x006EB510 File Offset: 0x006E9710
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

		// Token: 0x060334C4 RID: 210116 RVA: 0x006EB54C File Offset: 0x006E974C
		public static Offset<INewSplineStopTarget> CreateINewSplineStopTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player)
		{
			builder.StartTable(1);
			INewSplineStopTarget.AddType(builder, Type);
			return INewSplineStopTarget.EndINewSplineStopTarget(builder);
		}

		// Token: 0x060334C5 RID: 210117 RVA: 0x006EB562 File Offset: 0x006E9762
		public static void StartINewSplineStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060334C6 RID: 210118 RVA: 0x006EB56B File Offset: 0x006E976B
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060334C7 RID: 210119 RVA: 0x006EB576 File Offset: 0x006E9776
		public static Offset<INewSplineStopTarget> EndINewSplineStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<INewSplineStopTarget>(builder.EndTable());
		}

		// Token: 0x060334C8 RID: 210120 RVA: 0x006EB584 File Offset: 0x006E9784
		public INewSplineStopTargetT UnPack()
		{
			INewSplineStopTargetT newSplineStopTargetT = new INewSplineStopTargetT();
			this.UnPackTo(newSplineStopTargetT);
			return newSplineStopTargetT;
		}

		// Token: 0x060334C9 RID: 210121 RVA: 0x006EB59F File Offset: 0x006E979F
		public void UnPackTo(INewSplineStopTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060334CA RID: 210122 RVA: 0x006EB5B0 File Offset: 0x006E97B0
		public static Offset<INewSplineStopTarget> Pack(FlatBufferBuilder builder, INewSplineStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewSplineStopTarget>);
			}
			return INewSplineStopTarget.CreateINewSplineStopTarget(builder, _o.Type);
		}

		// Token: 0x0401239D RID: 74653
		private Table __p;
	}
}

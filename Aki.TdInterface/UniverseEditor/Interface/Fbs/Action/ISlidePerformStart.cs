using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007142 RID: 28994
	public struct ISlidePerformStart : IFlatbufferObject
	{
		// Token: 0x1700D770 RID: 55152
		// (get) Token: 0x06033666 RID: 210534 RVA: 0x006ED372 File Offset: 0x006EB572
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033667 RID: 210535 RVA: 0x006ED37F File Offset: 0x006EB57F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033668 RID: 210536 RVA: 0x006ED388 File Offset: 0x006EB588
		public static ISlidePerformStart GetRootAsISlidePerformStart(ByteBuffer _bb)
		{
			return ISlidePerformStart.GetRootAsISlidePerformStart(_bb, default(ISlidePerformStart));
		}

		// Token: 0x06033669 RID: 210537 RVA: 0x006ED3A4 File Offset: 0x006EB5A4
		public static ISlidePerformStart GetRootAsISlidePerformStart(ByteBuffer _bb, ISlidePerformStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603366A RID: 210538 RVA: 0x006ED3C1 File Offset: 0x006EB5C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603366B RID: 210539 RVA: 0x006ED3D0 File Offset: 0x006EB5D0
		public ISlidePerformStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D771 RID: 55153
		// (get) Token: 0x0603366C RID: 210540 RVA: 0x006ED3E0 File Offset: 0x006EB5E0
		public int SlideEntityId
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

		// Token: 0x1700D772 RID: 55154
		// (get) Token: 0x0603366D RID: 210541 RVA: 0x006ED41C File Offset: 0x006EB61C
		public ISlopeSlidePerformStart? SlidePerformConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISlopeSlidePerformStart?(default(ISlopeSlidePerformStart).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603366E RID: 210542 RVA: 0x006ED479 File Offset: 0x006EB679
		public static Offset<ISlidePerformStart> CreateISlidePerformStart(FlatBufferBuilder builder, int SlideEntityId = 0, Offset<ISlopeSlidePerformStart> SlidePerformConfigOffset = default(Offset<ISlopeSlidePerformStart>))
		{
			builder.StartTable(2);
			ISlidePerformStart.AddSlidePerformConfig(builder, SlidePerformConfigOffset);
			ISlidePerformStart.AddSlideEntityId(builder, SlideEntityId);
			return ISlidePerformStart.EndISlidePerformStart(builder);
		}

		// Token: 0x0603366F RID: 210543 RVA: 0x006ED496 File Offset: 0x006EB696
		public static void StartISlidePerformStart(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033670 RID: 210544 RVA: 0x006ED49F File Offset: 0x006EB69F
		public static void AddSlideEntityId(FlatBufferBuilder builder, int slideEntityId)
		{
			builder.AddInt(0, slideEntityId, 0);
		}

		// Token: 0x06033671 RID: 210545 RVA: 0x006ED4AA File Offset: 0x006EB6AA
		public static void AddSlidePerformConfig(FlatBufferBuilder builder, Offset<ISlopeSlidePerformStart> slidePerformConfigOffset)
		{
			builder.AddOffset(1, slidePerformConfigOffset.Value, 0);
		}

		// Token: 0x06033672 RID: 210546 RVA: 0x006ED4BA File Offset: 0x006EB6BA
		public static Offset<ISlidePerformStart> EndISlidePerformStart(FlatBufferBuilder builder)
		{
			return new Offset<ISlidePerformStart>(builder.EndTable());
		}

		// Token: 0x06033673 RID: 210547 RVA: 0x006ED4C8 File Offset: 0x006EB6C8
		public ISlidePerformStartT UnPack()
		{
			ISlidePerformStartT slidePerformStartT = new ISlidePerformStartT();
			this.UnPackTo(slidePerformStartT);
			return slidePerformStartT;
		}

		// Token: 0x06033674 RID: 210548 RVA: 0x006ED4E4 File Offset: 0x006EB6E4
		public void UnPackTo(ISlidePerformStartT _o)
		{
			_o.SlideEntityId = this.SlideEntityId;
			_o.SlidePerformConfig = ((this.SlidePerformConfig != null) ? this.SlidePerformConfig.Value.UnPack() : null);
		}

		// Token: 0x06033675 RID: 210549 RVA: 0x006ED52C File Offset: 0x006EB72C
		public static Offset<ISlidePerformStart> Pack(FlatBufferBuilder builder, ISlidePerformStartT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlidePerformStart>);
			}
			Offset<ISlopeSlidePerformStart> slidePerformConfigOffset = (_o.SlidePerformConfig == null) ? default(Offset<ISlopeSlidePerformStart>) : ISlopeSlidePerformStart.Pack(builder, _o.SlidePerformConfig);
			return ISlidePerformStart.CreateISlidePerformStart(builder, _o.SlideEntityId, slidePerformConfigOffset);
		}

		// Token: 0x04011BDD RID: 72669
		private Table __p;
	}
}

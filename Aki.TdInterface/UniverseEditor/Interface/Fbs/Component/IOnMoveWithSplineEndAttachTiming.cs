using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A1 RID: 22177
	public struct IOnMoveWithSplineEndAttachTiming : IFlatbufferObject
	{
		// Token: 0x1700A4EC RID: 42220
		// (get) Token: 0x06025030 RID: 151600 RVA: 0x0051C7D7 File Offset: 0x0051A9D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025031 RID: 151601 RVA: 0x0051C7E4 File Offset: 0x0051A9E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025032 RID: 151602 RVA: 0x0051C7EC File Offset: 0x0051A9EC
		public static IOnMoveWithSplineEndAttachTiming GetRootAsIOnMoveWithSplineEndAttachTiming(ByteBuffer _bb)
		{
			return IOnMoveWithSplineEndAttachTiming.GetRootAsIOnMoveWithSplineEndAttachTiming(_bb, default(IOnMoveWithSplineEndAttachTiming));
		}

		// Token: 0x06025033 RID: 151603 RVA: 0x0051C808 File Offset: 0x0051AA08
		public static IOnMoveWithSplineEndAttachTiming GetRootAsIOnMoveWithSplineEndAttachTiming(ByteBuffer _bb, IOnMoveWithSplineEndAttachTiming obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025034 RID: 151604 RVA: 0x0051C825 File Offset: 0x0051AA25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025035 RID: 151605 RVA: 0x0051C834 File Offset: 0x0051AA34
		public IOnMoveWithSplineEndAttachTiming __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4ED RID: 42221
		// (get) Token: 0x06025036 RID: 151606 RVA: 0x0051C844 File Offset: 0x0051AA44
		public EAttachTimingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachTimingType.Default;
				}
				return (EAttachTimingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A4EE RID: 42222
		// (get) Token: 0x06025037 RID: 151607 RVA: 0x0051C880 File Offset: 0x0051AA80
		public int SplineEntityId
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

		// Token: 0x06025038 RID: 151608 RVA: 0x0051C8BC File Offset: 0x0051AABC
		public static Offset<IOnMoveWithSplineEndAttachTiming> CreateIOnMoveWithSplineEndAttachTiming(FlatBufferBuilder builder, EAttachTimingType Type = EAttachTimingType.Default, int SplineEntityId = 0)
		{
			builder.StartTable(2);
			IOnMoveWithSplineEndAttachTiming.AddSplineEntityId(builder, SplineEntityId);
			IOnMoveWithSplineEndAttachTiming.AddType(builder, Type);
			return IOnMoveWithSplineEndAttachTiming.EndIOnMoveWithSplineEndAttachTiming(builder);
		}

		// Token: 0x06025039 RID: 151609 RVA: 0x0051C8D9 File Offset: 0x0051AAD9
		public static void StartIOnMoveWithSplineEndAttachTiming(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602503A RID: 151610 RVA: 0x0051C8E2 File Offset: 0x0051AAE2
		public static void AddType(FlatBufferBuilder builder, EAttachTimingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602503B RID: 151611 RVA: 0x0051C8ED File Offset: 0x0051AAED
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x0602503C RID: 151612 RVA: 0x0051C8F8 File Offset: 0x0051AAF8
		public static Offset<IOnMoveWithSplineEndAttachTiming> EndIOnMoveWithSplineEndAttachTiming(FlatBufferBuilder builder)
		{
			return new Offset<IOnMoveWithSplineEndAttachTiming>(builder.EndTable());
		}

		// Token: 0x0602503D RID: 151613 RVA: 0x0051C908 File Offset: 0x0051AB08
		public IOnMoveWithSplineEndAttachTimingT UnPack()
		{
			IOnMoveWithSplineEndAttachTimingT onMoveWithSplineEndAttachTimingT = new IOnMoveWithSplineEndAttachTimingT();
			this.UnPackTo(onMoveWithSplineEndAttachTimingT);
			return onMoveWithSplineEndAttachTimingT;
		}

		// Token: 0x0602503E RID: 151614 RVA: 0x0051C923 File Offset: 0x0051AB23
		public void UnPackTo(IOnMoveWithSplineEndAttachTimingT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x0602503F RID: 151615 RVA: 0x0051C940 File Offset: 0x0051AB40
		public static Offset<IOnMoveWithSplineEndAttachTiming> Pack(FlatBufferBuilder builder, IOnMoveWithSplineEndAttachTimingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnMoveWithSplineEndAttachTiming>);
			}
			return IOnMoveWithSplineEndAttachTiming.CreateIOnMoveWithSplineEndAttachTiming(builder, _o.Type, _o.SplineEntityId);
		}

		// Token: 0x0400EAC5 RID: 60101
		private Table __p;
	}
}

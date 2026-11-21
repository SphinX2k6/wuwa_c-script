using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C26 RID: 31782
	public struct ITrackingEventTypeBase : IFlatbufferObject
	{
		// Token: 0x1700EDFB RID: 60923
		// (get) Token: 0x06039493 RID: 234643 RVA: 0x007BC996 File Offset: 0x007BAB96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039494 RID: 234644 RVA: 0x007BC9A3 File Offset: 0x007BABA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039495 RID: 234645 RVA: 0x007BC9AC File Offset: 0x007BABAC
		public static ITrackingEventTypeBase GetRootAsITrackingEventTypeBase(ByteBuffer _bb)
		{
			return ITrackingEventTypeBase.GetRootAsITrackingEventTypeBase(_bb, default(ITrackingEventTypeBase));
		}

		// Token: 0x06039496 RID: 234646 RVA: 0x007BC9C8 File Offset: 0x007BABC8
		public static ITrackingEventTypeBase GetRootAsITrackingEventTypeBase(ByteBuffer _bb, ITrackingEventTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039497 RID: 234647 RVA: 0x007BC9E5 File Offset: 0x007BABE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039498 RID: 234648 RVA: 0x007BC9F4 File Offset: 0x007BABF4
		public ITrackingEventTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDFC RID: 60924
		// (get) Token: 0x06039499 RID: 234649 RVA: 0x007BCA04 File Offset: 0x007BAC04
		public ETrackingEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackingEventType.EasterEgg;
				}
				return (ETrackingEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603949A RID: 234650 RVA: 0x007BCA40 File Offset: 0x007BAC40
		public static Offset<ITrackingEventTypeBase> CreateITrackingEventTypeBase(FlatBufferBuilder builder, ETrackingEventType Type = ETrackingEventType.EasterEgg)
		{
			builder.StartTable(1);
			ITrackingEventTypeBase.AddType(builder, Type);
			return ITrackingEventTypeBase.EndITrackingEventTypeBase(builder);
		}

		// Token: 0x0603949B RID: 234651 RVA: 0x007BCA56 File Offset: 0x007BAC56
		public static void StartITrackingEventTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603949C RID: 234652 RVA: 0x007BCA5F File Offset: 0x007BAC5F
		public static void AddType(FlatBufferBuilder builder, ETrackingEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603949D RID: 234653 RVA: 0x007BCA6A File Offset: 0x007BAC6A
		public static Offset<ITrackingEventTypeBase> EndITrackingEventTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ITrackingEventTypeBase>(builder.EndTable());
		}

		// Token: 0x0603949E RID: 234654 RVA: 0x007BCA78 File Offset: 0x007BAC78
		public ITrackingEventTypeBaseT UnPack()
		{
			ITrackingEventTypeBaseT trackingEventTypeBaseT = new ITrackingEventTypeBaseT();
			this.UnPackTo(trackingEventTypeBaseT);
			return trackingEventTypeBaseT;
		}

		// Token: 0x0603949F RID: 234655 RVA: 0x007BCA93 File Offset: 0x007BAC93
		public void UnPackTo(ITrackingEventTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060394A0 RID: 234656 RVA: 0x007BCAA4 File Offset: 0x007BACA4
		public static Offset<ITrackingEventTypeBase> Pack(FlatBufferBuilder builder, ITrackingEventTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackingEventTypeBase>);
			}
			return ITrackingEventTypeBase.CreateITrackingEventTypeBase(builder, _o.Type);
		}

		// Token: 0x040132D3 RID: 78547
		private Table __p;
	}
}

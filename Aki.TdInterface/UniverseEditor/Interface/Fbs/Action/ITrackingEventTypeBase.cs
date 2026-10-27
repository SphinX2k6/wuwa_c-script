using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007433 RID: 29747
	public struct ITrackingEventTypeBase : IFlatbufferObject
	{
		// Token: 0x1700E1DE RID: 57822
		// (get) Token: 0x060360AA RID: 221354 RVA: 0x00759C6A File Offset: 0x00757E6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060360AB RID: 221355 RVA: 0x00759C77 File Offset: 0x00757E77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060360AC RID: 221356 RVA: 0x00759C80 File Offset: 0x00757E80
		public static ITrackingEventTypeBase GetRootAsITrackingEventTypeBase(ByteBuffer _bb)
		{
			return ITrackingEventTypeBase.GetRootAsITrackingEventTypeBase(_bb, default(ITrackingEventTypeBase));
		}

		// Token: 0x060360AD RID: 221357 RVA: 0x00759C9C File Offset: 0x00757E9C
		public static ITrackingEventTypeBase GetRootAsITrackingEventTypeBase(ByteBuffer _bb, ITrackingEventTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060360AE RID: 221358 RVA: 0x00759CB9 File Offset: 0x00757EB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060360AF RID: 221359 RVA: 0x00759CC8 File Offset: 0x00757EC8
		public ITrackingEventTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1DF RID: 57823
		// (get) Token: 0x060360B0 RID: 221360 RVA: 0x00759CD8 File Offset: 0x00757ED8
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

		// Token: 0x060360B1 RID: 221361 RVA: 0x00759D14 File Offset: 0x00757F14
		public static Offset<ITrackingEventTypeBase> CreateITrackingEventTypeBase(FlatBufferBuilder builder, ETrackingEventType Type = ETrackingEventType.EasterEgg)
		{
			builder.StartTable(1);
			ITrackingEventTypeBase.AddType(builder, Type);
			return ITrackingEventTypeBase.EndITrackingEventTypeBase(builder);
		}

		// Token: 0x060360B2 RID: 221362 RVA: 0x00759D2A File Offset: 0x00757F2A
		public static void StartITrackingEventTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060360B3 RID: 221363 RVA: 0x00759D33 File Offset: 0x00757F33
		public static void AddType(FlatBufferBuilder builder, ETrackingEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060360B4 RID: 221364 RVA: 0x00759D3E File Offset: 0x00757F3E
		public static Offset<ITrackingEventTypeBase> EndITrackingEventTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ITrackingEventTypeBase>(builder.EndTable());
		}

		// Token: 0x060360B5 RID: 221365 RVA: 0x00759D4C File Offset: 0x00757F4C
		public ITrackingEventTypeBaseT UnPack()
		{
			ITrackingEventTypeBaseT trackingEventTypeBaseT = new ITrackingEventTypeBaseT();
			this.UnPackTo(trackingEventTypeBaseT);
			return trackingEventTypeBaseT;
		}

		// Token: 0x060360B6 RID: 221366 RVA: 0x00759D67 File Offset: 0x00757F67
		public void UnPackTo(ITrackingEventTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060360B7 RID: 221367 RVA: 0x00759D78 File Offset: 0x00757F78
		public static Offset<ITrackingEventTypeBase> Pack(FlatBufferBuilder builder, ITrackingEventTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackingEventTypeBase>);
			}
			return ITrackingEventTypeBase.CreateITrackingEventTypeBase(builder, _o.Type);
		}

		// Token: 0x040122AC RID: 74412
		private Table __p;
	}
}

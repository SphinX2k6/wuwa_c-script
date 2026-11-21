using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A08 RID: 27144
	public struct IClientEventFlyingFlowerEvent : IFlatbufferObject
	{
		// Token: 0x1700C79D RID: 51101
		// (get) Token: 0x0602E921 RID: 190753 RVA: 0x0065A119 File Offset: 0x00658319
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E922 RID: 190754 RVA: 0x0065A126 File Offset: 0x00658326
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E923 RID: 190755 RVA: 0x0065A130 File Offset: 0x00658330
		public static IClientEventFlyingFlowerEvent GetRootAsIClientEventFlyingFlowerEvent(ByteBuffer _bb)
		{
			return IClientEventFlyingFlowerEvent.GetRootAsIClientEventFlyingFlowerEvent(_bb, default(IClientEventFlyingFlowerEvent));
		}

		// Token: 0x0602E924 RID: 190756 RVA: 0x0065A14C File Offset: 0x0065834C
		public static IClientEventFlyingFlowerEvent GetRootAsIClientEventFlyingFlowerEvent(ByteBuffer _bb, IClientEventFlyingFlowerEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E925 RID: 190757 RVA: 0x0065A169 File Offset: 0x00658369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E926 RID: 190758 RVA: 0x0065A178 File Offset: 0x00658378
		public IClientEventFlyingFlowerEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C79E RID: 51102
		// (get) Token: 0x0602E927 RID: 190759 RVA: 0x0065A188 File Offset: 0x00658388
		public EClientEventFlyingFlowerEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventFlyingFlowerEventType.UpdateSubtitle;
				}
				return (EClientEventFlyingFlowerEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E928 RID: 190760 RVA: 0x0065A1C4 File Offset: 0x006583C4
		public static Offset<IClientEventFlyingFlowerEvent> CreateIClientEventFlyingFlowerEvent(FlatBufferBuilder builder, EClientEventFlyingFlowerEventType Type = EClientEventFlyingFlowerEventType.UpdateSubtitle)
		{
			builder.StartTable(1);
			IClientEventFlyingFlowerEvent.AddType(builder, Type);
			return IClientEventFlyingFlowerEvent.EndIClientEventFlyingFlowerEvent(builder);
		}

		// Token: 0x0602E929 RID: 190761 RVA: 0x0065A1DA File Offset: 0x006583DA
		public static void StartIClientEventFlyingFlowerEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E92A RID: 190762 RVA: 0x0065A1E3 File Offset: 0x006583E3
		public static void AddType(FlatBufferBuilder builder, EClientEventFlyingFlowerEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E92B RID: 190763 RVA: 0x0065A1EE File Offset: 0x006583EE
		public static Offset<IClientEventFlyingFlowerEvent> EndIClientEventFlyingFlowerEvent(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventFlyingFlowerEvent>(builder.EndTable());
		}

		// Token: 0x0602E92C RID: 190764 RVA: 0x0065A1FC File Offset: 0x006583FC
		public IClientEventFlyingFlowerEventT UnPack()
		{
			IClientEventFlyingFlowerEventT clientEventFlyingFlowerEventT = new IClientEventFlyingFlowerEventT();
			this.UnPackTo(clientEventFlyingFlowerEventT);
			return clientEventFlyingFlowerEventT;
		}

		// Token: 0x0602E92D RID: 190765 RVA: 0x0065A217 File Offset: 0x00658417
		public void UnPackTo(IClientEventFlyingFlowerEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E92E RID: 190766 RVA: 0x0065A228 File Offset: 0x00658428
		public static Offset<IClientEventFlyingFlowerEvent> Pack(FlatBufferBuilder builder, IClientEventFlyingFlowerEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventFlyingFlowerEvent>);
			}
			return IClientEventFlyingFlowerEvent.CreateIClientEventFlyingFlowerEvent(builder, _o.Type);
		}

		// Token: 0x04011779 RID: 71545
		private Table __p;
	}
}

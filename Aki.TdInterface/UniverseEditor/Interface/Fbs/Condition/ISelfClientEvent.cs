using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CBE RID: 19646
	public struct ISelfClientEvent : IFlatbufferObject
	{
		// Token: 0x17008EA3 RID: 36515
		// (get) Token: 0x0601F2C3 RID: 127683 RVA: 0x0045A540 File Offset: 0x00458740
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F2C4 RID: 127684 RVA: 0x0045A54D File Offset: 0x0045874D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F2C5 RID: 127685 RVA: 0x0045A554 File Offset: 0x00458754
		public static ISelfClientEvent GetRootAsISelfClientEvent(ByteBuffer _bb)
		{
			return ISelfClientEvent.GetRootAsISelfClientEvent(_bb, default(ISelfClientEvent));
		}

		// Token: 0x0601F2C6 RID: 127686 RVA: 0x0045A570 File Offset: 0x00458770
		public static ISelfClientEvent GetRootAsISelfClientEvent(ByteBuffer _bb, ISelfClientEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F2C7 RID: 127687 RVA: 0x0045A58D File Offset: 0x0045878D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F2C8 RID: 127688 RVA: 0x0045A59C File Offset: 0x0045879C
		public ISelfClientEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EA4 RID: 36516
		// (get) Token: 0x0601F2C9 RID: 127689 RVA: 0x0045A5AC File Offset: 0x004587AC
		public EClientEventTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventTarget.Self;
				}
				return (EClientEventTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F2CA RID: 127690 RVA: 0x0045A5E8 File Offset: 0x004587E8
		public static Offset<ISelfClientEvent> CreateISelfClientEvent(FlatBufferBuilder builder, EClientEventTarget Type = EClientEventTarget.Self)
		{
			builder.StartTable(1);
			ISelfClientEvent.AddType(builder, Type);
			return ISelfClientEvent.EndISelfClientEvent(builder);
		}

		// Token: 0x0601F2CB RID: 127691 RVA: 0x0045A5FE File Offset: 0x004587FE
		public static void StartISelfClientEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F2CC RID: 127692 RVA: 0x0045A607 File Offset: 0x00458807
		public static void AddType(FlatBufferBuilder builder, EClientEventTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F2CD RID: 127693 RVA: 0x0045A612 File Offset: 0x00458812
		public static Offset<ISelfClientEvent> EndISelfClientEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISelfClientEvent>(builder.EndTable());
		}

		// Token: 0x0601F2CE RID: 127694 RVA: 0x0045A620 File Offset: 0x00458820
		public ISelfClientEventT UnPack()
		{
			ISelfClientEventT selfClientEventT = new ISelfClientEventT();
			this.UnPackTo(selfClientEventT);
			return selfClientEventT;
		}

		// Token: 0x0601F2CF RID: 127695 RVA: 0x0045A63B File Offset: 0x0045883B
		public void UnPackTo(ISelfClientEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F2D0 RID: 127696 RVA: 0x0045A64C File Offset: 0x0045884C
		public static Offset<ISelfClientEvent> Pack(FlatBufferBuilder builder, ISelfClientEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfClientEvent>);
			}
			return ISelfClientEvent.CreateISelfClientEvent(builder, _o.Type);
		}

		// Token: 0x0400D684 RID: 54916
		private Table __p;
	}
}

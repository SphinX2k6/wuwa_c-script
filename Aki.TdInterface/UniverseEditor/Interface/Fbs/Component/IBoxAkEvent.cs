using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F22 RID: 20258
	public struct IBoxAkEvent : IFlatbufferObject
	{
		// Token: 0x170091E8 RID: 37352
		// (get) Token: 0x0602009A RID: 131226 RVA: 0x004753CE File Offset: 0x004735CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602009B RID: 131227 RVA: 0x004753DB File Offset: 0x004735DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602009C RID: 131228 RVA: 0x004753E4 File Offset: 0x004735E4
		public static IBoxAkEvent GetRootAsIBoxAkEvent(ByteBuffer _bb)
		{
			return IBoxAkEvent.GetRootAsIBoxAkEvent(_bb, default(IBoxAkEvent));
		}

		// Token: 0x0602009D RID: 131229 RVA: 0x00475400 File Offset: 0x00473600
		public static IBoxAkEvent GetRootAsIBoxAkEvent(ByteBuffer _bb, IBoxAkEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602009E RID: 131230 RVA: 0x0047541D File Offset: 0x0047361D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602009F RID: 131231 RVA: 0x0047542C File Offset: 0x0047362C
		public IBoxAkEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091E9 RID: 37353
		// (get) Token: 0x060200A0 RID: 131232 RVA: 0x0047543C File Offset: 0x0047363C
		public EAkEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAkEventType.Point;
				}
				return (EAkEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091EA RID: 37354
		// (get) Token: 0x060200A1 RID: 131233 RVA: 0x00475478 File Offset: 0x00473678
		public EAudioType AudioType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAudioType.AudioAMB;
				}
				return (EAudioType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091EB RID: 37355
		// (get) Token: 0x060200A2 RID: 131234 RVA: 0x004754B4 File Offset: 0x004736B4
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060200A3 RID: 131235 RVA: 0x004754F0 File Offset: 0x004736F0
		public static Offset<IBoxAkEvent> CreateIBoxAkEvent(FlatBufferBuilder builder, EAkEventType Type = EAkEventType.Point, EAudioType AudioType = EAudioType.AudioAMB, int Priority = 0)
		{
			builder.StartTable(3);
			IBoxAkEvent.AddPriority(builder, Priority);
			IBoxAkEvent.AddAudioType(builder, AudioType);
			IBoxAkEvent.AddType(builder, Type);
			return IBoxAkEvent.EndIBoxAkEvent(builder);
		}

		// Token: 0x060200A4 RID: 131236 RVA: 0x00475514 File Offset: 0x00473714
		public static void StartIBoxAkEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060200A5 RID: 131237 RVA: 0x0047551D File Offset: 0x0047371D
		public static void AddType(FlatBufferBuilder builder, EAkEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060200A6 RID: 131238 RVA: 0x00475528 File Offset: 0x00473728
		public static void AddAudioType(FlatBufferBuilder builder, EAudioType audioType)
		{
			builder.AddByte(1, (byte)audioType, 0);
		}

		// Token: 0x060200A7 RID: 131239 RVA: 0x00475533 File Offset: 0x00473733
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(2, priority, 0);
		}

		// Token: 0x060200A8 RID: 131240 RVA: 0x0047553E File Offset: 0x0047373E
		public static Offset<IBoxAkEvent> EndIBoxAkEvent(FlatBufferBuilder builder)
		{
			return new Offset<IBoxAkEvent>(builder.EndTable());
		}

		// Token: 0x060200A9 RID: 131241 RVA: 0x0047554C File Offset: 0x0047374C
		public IBoxAkEventT UnPack()
		{
			IBoxAkEventT boxAkEventT = new IBoxAkEventT();
			this.UnPackTo(boxAkEventT);
			return boxAkEventT;
		}

		// Token: 0x060200AA RID: 131242 RVA: 0x00475567 File Offset: 0x00473767
		public void UnPackTo(IBoxAkEventT _o)
		{
			_o.Type = this.Type;
			_o.AudioType = this.AudioType;
			_o.Priority = this.Priority;
		}

		// Token: 0x060200AB RID: 131243 RVA: 0x00475590 File Offset: 0x00473790
		public static Offset<IBoxAkEvent> Pack(FlatBufferBuilder builder, IBoxAkEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBoxAkEvent>);
			}
			return IBoxAkEvent.CreateIBoxAkEvent(builder, _o.Type, _o.AudioType, _o.Priority);
		}

		// Token: 0x0400DD79 RID: 56697
		private Table __p;
	}
}

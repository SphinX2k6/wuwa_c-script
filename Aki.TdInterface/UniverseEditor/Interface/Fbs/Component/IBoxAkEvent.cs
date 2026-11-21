using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005454 RID: 21588
	public struct IBoxAkEvent : IFlatbufferObject
	{
		// Token: 0x1700996A RID: 39274
		// (get) Token: 0x06021E0A RID: 138762 RVA: 0x004AB762 File Offset: 0x004A9962
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021E0B RID: 138763 RVA: 0x004AB76F File Offset: 0x004A996F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021E0C RID: 138764 RVA: 0x004AB778 File Offset: 0x004A9978
		public static IBoxAkEvent GetRootAsIBoxAkEvent(ByteBuffer _bb)
		{
			return IBoxAkEvent.GetRootAsIBoxAkEvent(_bb, default(IBoxAkEvent));
		}

		// Token: 0x06021E0D RID: 138765 RVA: 0x004AB794 File Offset: 0x004A9994
		public static IBoxAkEvent GetRootAsIBoxAkEvent(ByteBuffer _bb, IBoxAkEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021E0E RID: 138766 RVA: 0x004AB7B1 File Offset: 0x004A99B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021E0F RID: 138767 RVA: 0x004AB7C0 File Offset: 0x004A99C0
		public IBoxAkEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700996B RID: 39275
		// (get) Token: 0x06021E10 RID: 138768 RVA: 0x004AB7D0 File Offset: 0x004A99D0
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

		// Token: 0x1700996C RID: 39276
		// (get) Token: 0x06021E11 RID: 138769 RVA: 0x004AB80C File Offset: 0x004A9A0C
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

		// Token: 0x1700996D RID: 39277
		// (get) Token: 0x06021E12 RID: 138770 RVA: 0x004AB848 File Offset: 0x004A9A48
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

		// Token: 0x06021E13 RID: 138771 RVA: 0x004AB884 File Offset: 0x004A9A84
		public static Offset<IBoxAkEvent> CreateIBoxAkEvent(FlatBufferBuilder builder, EAkEventType Type = EAkEventType.Point, EAudioType AudioType = EAudioType.AudioAMB, int Priority = 0)
		{
			builder.StartTable(3);
			IBoxAkEvent.AddPriority(builder, Priority);
			IBoxAkEvent.AddAudioType(builder, AudioType);
			IBoxAkEvent.AddType(builder, Type);
			return IBoxAkEvent.EndIBoxAkEvent(builder);
		}

		// Token: 0x06021E14 RID: 138772 RVA: 0x004AB8A8 File Offset: 0x004A9AA8
		public static void StartIBoxAkEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021E15 RID: 138773 RVA: 0x004AB8B1 File Offset: 0x004A9AB1
		public static void AddType(FlatBufferBuilder builder, EAkEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021E16 RID: 138774 RVA: 0x004AB8BC File Offset: 0x004A9ABC
		public static void AddAudioType(FlatBufferBuilder builder, EAudioType audioType)
		{
			builder.AddByte(1, (byte)audioType, 0);
		}

		// Token: 0x06021E17 RID: 138775 RVA: 0x004AB8C7 File Offset: 0x004A9AC7
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(2, priority, 0);
		}

		// Token: 0x06021E18 RID: 138776 RVA: 0x004AB8D2 File Offset: 0x004A9AD2
		public static Offset<IBoxAkEvent> EndIBoxAkEvent(FlatBufferBuilder builder)
		{
			return new Offset<IBoxAkEvent>(builder.EndTable());
		}

		// Token: 0x06021E19 RID: 138777 RVA: 0x004AB8E0 File Offset: 0x004A9AE0
		public IBoxAkEventT UnPack()
		{
			IBoxAkEventT boxAkEventT = new IBoxAkEventT();
			this.UnPackTo(boxAkEventT);
			return boxAkEventT;
		}

		// Token: 0x06021E1A RID: 138778 RVA: 0x004AB8FB File Offset: 0x004A9AFB
		public void UnPackTo(IBoxAkEventT _o)
		{
			_o.Type = this.Type;
			_o.AudioType = this.AudioType;
			_o.Priority = this.Priority;
		}

		// Token: 0x06021E1B RID: 138779 RVA: 0x004AB924 File Offset: 0x004A9B24
		public static Offset<IBoxAkEvent> Pack(FlatBufferBuilder builder, IBoxAkEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBoxAkEvent>);
			}
			return IBoxAkEvent.CreateIBoxAkEvent(builder, _o.Type, _o.AudioType, _o.Priority);
		}

		// Token: 0x0400E928 RID: 59688
		private Table __p;
	}
}

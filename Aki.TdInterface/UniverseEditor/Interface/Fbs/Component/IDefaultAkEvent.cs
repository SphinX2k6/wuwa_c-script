using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005078 RID: 20600
	public struct IDefaultAkEvent : IFlatbufferObject
	{
		// Token: 0x17009575 RID: 38261
		// (get) Token: 0x0602105F RID: 135263 RVA: 0x0049669A File Offset: 0x0049489A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021060 RID: 135264 RVA: 0x004966A7 File Offset: 0x004948A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021061 RID: 135265 RVA: 0x004966B0 File Offset: 0x004948B0
		public static IDefaultAkEvent GetRootAsIDefaultAkEvent(ByteBuffer _bb)
		{
			return IDefaultAkEvent.GetRootAsIDefaultAkEvent(_bb, default(IDefaultAkEvent));
		}

		// Token: 0x06021062 RID: 135266 RVA: 0x004966CC File Offset: 0x004948CC
		public static IDefaultAkEvent GetRootAsIDefaultAkEvent(ByteBuffer _bb, IDefaultAkEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021063 RID: 135267 RVA: 0x004966E9 File Offset: 0x004948E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021064 RID: 135268 RVA: 0x004966F8 File Offset: 0x004948F8
		public IDefaultAkEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009576 RID: 38262
		// (get) Token: 0x06021065 RID: 135269 RVA: 0x00496708 File Offset: 0x00494908
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

		// Token: 0x06021066 RID: 135270 RVA: 0x00496744 File Offset: 0x00494944
		public static Offset<IDefaultAkEvent> CreateIDefaultAkEvent(FlatBufferBuilder builder, EAkEventType Type = EAkEventType.Point)
		{
			builder.StartTable(1);
			IDefaultAkEvent.AddType(builder, Type);
			return IDefaultAkEvent.EndIDefaultAkEvent(builder);
		}

		// Token: 0x06021067 RID: 135271 RVA: 0x0049675A File Offset: 0x0049495A
		public static void StartIDefaultAkEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021068 RID: 135272 RVA: 0x00496763 File Offset: 0x00494963
		public static void AddType(FlatBufferBuilder builder, EAkEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021069 RID: 135273 RVA: 0x0049676E File Offset: 0x0049496E
		public static Offset<IDefaultAkEvent> EndIDefaultAkEvent(FlatBufferBuilder builder)
		{
			return new Offset<IDefaultAkEvent>(builder.EndTable());
		}

		// Token: 0x0602106A RID: 135274 RVA: 0x0049677C File Offset: 0x0049497C
		public IDefaultAkEventT UnPack()
		{
			IDefaultAkEventT defaultAkEventT = new IDefaultAkEventT();
			this.UnPackTo(defaultAkEventT);
			return defaultAkEventT;
		}

		// Token: 0x0602106B RID: 135275 RVA: 0x00496797 File Offset: 0x00494997
		public void UnPackTo(IDefaultAkEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602106C RID: 135276 RVA: 0x004967A8 File Offset: 0x004949A8
		public static Offset<IDefaultAkEvent> Pack(FlatBufferBuilder builder, IDefaultAkEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDefaultAkEvent>);
			}
			return IDefaultAkEvent.CreateIDefaultAkEvent(builder, _o.Type);
		}

		// Token: 0x0400E07C RID: 57468
		private Table __p;
	}
}

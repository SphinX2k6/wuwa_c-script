using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005823 RID: 22563
	public struct IFollowTrackToStart : IFlatbufferObject
	{
		// Token: 0x1700A350 RID: 41808
		// (get) Token: 0x0602482D RID: 149549 RVA: 0x005041DD File Offset: 0x005023DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602482E RID: 149550 RVA: 0x005041EA File Offset: 0x005023EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602482F RID: 149551 RVA: 0x005041F4 File Offset: 0x005023F4
		public static IFollowTrackToStart GetRootAsIFollowTrackToStart(ByteBuffer _bb)
		{
			return IFollowTrackToStart.GetRootAsIFollowTrackToStart(_bb, default(IFollowTrackToStart));
		}

		// Token: 0x06024830 RID: 149552 RVA: 0x00504210 File Offset: 0x00502410
		public static IFollowTrackToStart GetRootAsIFollowTrackToStart(ByteBuffer _bb, IFollowTrackToStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024831 RID: 149553 RVA: 0x0050422D File Offset: 0x0050242D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024832 RID: 149554 RVA: 0x0050423C File Offset: 0x0050243C
		public IFollowTrackToStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A351 RID: 41809
		// (get) Token: 0x06024833 RID: 149555 RVA: 0x0050424C File Offset: 0x0050244C
		public EFollowTrackEndType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowTrackEndType.ToStart;
				}
				return (EFollowTrackEndType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024834 RID: 149556 RVA: 0x00504288 File Offset: 0x00502488
		public static Offset<IFollowTrackToStart> CreateIFollowTrackToStart(FlatBufferBuilder builder, EFollowTrackEndType Type = EFollowTrackEndType.ToStart)
		{
			builder.StartTable(1);
			IFollowTrackToStart.AddType(builder, Type);
			return IFollowTrackToStart.EndIFollowTrackToStart(builder);
		}

		// Token: 0x06024835 RID: 149557 RVA: 0x0050429E File Offset: 0x0050249E
		public static void StartIFollowTrackToStart(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024836 RID: 149558 RVA: 0x005042A7 File Offset: 0x005024A7
		public static void AddType(FlatBufferBuilder builder, EFollowTrackEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024837 RID: 149559 RVA: 0x005042B2 File Offset: 0x005024B2
		public static Offset<IFollowTrackToStart> EndIFollowTrackToStart(FlatBufferBuilder builder)
		{
			return new Offset<IFollowTrackToStart>(builder.EndTable());
		}

		// Token: 0x06024838 RID: 149560 RVA: 0x005042C0 File Offset: 0x005024C0
		public IFollowTrackToStartT UnPack()
		{
			IFollowTrackToStartT followTrackToStartT = new IFollowTrackToStartT();
			this.UnPackTo(followTrackToStartT);
			return followTrackToStartT;
		}

		// Token: 0x06024839 RID: 149561 RVA: 0x005042DB File Offset: 0x005024DB
		public void UnPackTo(IFollowTrackToStartT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602483A RID: 149562 RVA: 0x005042EC File Offset: 0x005024EC
		public static Offset<IFollowTrackToStart> Pack(FlatBufferBuilder builder, IFollowTrackToStartT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowTrackToStart>);
			}
			return IFollowTrackToStart.CreateIFollowTrackToStart(builder, _o.Type);
		}

		// Token: 0x0400F046 RID: 61510
		private Table __p;
	}
}

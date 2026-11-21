using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FDA RID: 28634
	public struct IHonamiStoryInteractPickUp : IFlatbufferObject
	{
		// Token: 0x1700D1B8 RID: 53688
		// (get) Token: 0x060319B3 RID: 203187 RVA: 0x006B88B3 File Offset: 0x006B6AB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060319B4 RID: 203188 RVA: 0x006B88C0 File Offset: 0x006B6AC0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060319B5 RID: 203189 RVA: 0x006B88C8 File Offset: 0x006B6AC8
		public static IHonamiStoryInteractPickUp GetRootAsIHonamiStoryInteractPickUp(ByteBuffer _bb)
		{
			return IHonamiStoryInteractPickUp.GetRootAsIHonamiStoryInteractPickUp(_bb, default(IHonamiStoryInteractPickUp));
		}

		// Token: 0x060319B6 RID: 203190 RVA: 0x006B88E4 File Offset: 0x006B6AE4
		public static IHonamiStoryInteractPickUp GetRootAsIHonamiStoryInteractPickUp(ByteBuffer _bb, IHonamiStoryInteractPickUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060319B7 RID: 203191 RVA: 0x006B8901 File Offset: 0x006B6B01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060319B8 RID: 203192 RVA: 0x006B8910 File Offset: 0x006B6B10
		public IHonamiStoryInteractPickUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060319B9 RID: 203193 RVA: 0x006B8920 File Offset: 0x006B6B20
		public static void StartIHonamiStoryInteractPickUp(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060319BA RID: 203194 RVA: 0x006B8929 File Offset: 0x006B6B29
		public static Offset<IHonamiStoryInteractPickUp> EndIHonamiStoryInteractPickUp(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryInteractPickUp>(builder.EndTable());
		}

		// Token: 0x060319BB RID: 203195 RVA: 0x006B8938 File Offset: 0x006B6B38
		public IHonamiStoryInteractPickUpT UnPack()
		{
			IHonamiStoryInteractPickUpT honamiStoryInteractPickUpT = new IHonamiStoryInteractPickUpT();
			this.UnPackTo(honamiStoryInteractPickUpT);
			return honamiStoryInteractPickUpT;
		}

		// Token: 0x060319BC RID: 203196 RVA: 0x006B8953 File Offset: 0x006B6B53
		public void UnPackTo(IHonamiStoryInteractPickUpT _o)
		{
		}

		// Token: 0x060319BD RID: 203197 RVA: 0x006B8958 File Offset: 0x006B6B58
		public static Offset<IHonamiStoryInteractPickUp> Pack(FlatBufferBuilder builder, IHonamiStoryInteractPickUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryInteractPickUp>);
			}
			IHonamiStoryInteractPickUp.StartIHonamiStoryInteractPickUp(builder);
			return IHonamiStoryInteractPickUp.EndIHonamiStoryInteractPickUp(builder);
		}

		// Token: 0x04011F0D RID: 73485
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006927 RID: 26919
	public struct IHonamiStoryInteractPickUp : IFlatbufferObject
	{
		// Token: 0x1700C7B5 RID: 51125
		// (get) Token: 0x0602EFE3 RID: 192483 RVA: 0x006683CB File Offset: 0x006665CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EFE4 RID: 192484 RVA: 0x006683D8 File Offset: 0x006665D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EFE5 RID: 192485 RVA: 0x006683E0 File Offset: 0x006665E0
		public static IHonamiStoryInteractPickUp GetRootAsIHonamiStoryInteractPickUp(ByteBuffer _bb)
		{
			return IHonamiStoryInteractPickUp.GetRootAsIHonamiStoryInteractPickUp(_bb, default(IHonamiStoryInteractPickUp));
		}

		// Token: 0x0602EFE6 RID: 192486 RVA: 0x006683FC File Offset: 0x006665FC
		public static IHonamiStoryInteractPickUp GetRootAsIHonamiStoryInteractPickUp(ByteBuffer _bb, IHonamiStoryInteractPickUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EFE7 RID: 192487 RVA: 0x00668419 File Offset: 0x00666619
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EFE8 RID: 192488 RVA: 0x00668428 File Offset: 0x00666628
		public IHonamiStoryInteractPickUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602EFE9 RID: 192489 RVA: 0x00668438 File Offset: 0x00666638
		public static void StartIHonamiStoryInteractPickUp(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602EFEA RID: 192490 RVA: 0x00668441 File Offset: 0x00666641
		public static Offset<IHonamiStoryInteractPickUp> EndIHonamiStoryInteractPickUp(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryInteractPickUp>(builder.EndTable());
		}

		// Token: 0x0602EFEB RID: 192491 RVA: 0x00668450 File Offset: 0x00666650
		public IHonamiStoryInteractPickUpT UnPack()
		{
			IHonamiStoryInteractPickUpT honamiStoryInteractPickUpT = new IHonamiStoryInteractPickUpT();
			this.UnPackTo(honamiStoryInteractPickUpT);
			return honamiStoryInteractPickUpT;
		}

		// Token: 0x0602EFEC RID: 192492 RVA: 0x0066846B File Offset: 0x0066666B
		public void UnPackTo(IHonamiStoryInteractPickUpT _o)
		{
		}

		// Token: 0x0602EFED RID: 192493 RVA: 0x00668470 File Offset: 0x00666670
		public static Offset<IHonamiStoryInteractPickUp> Pack(FlatBufferBuilder builder, IHonamiStoryInteractPickUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryInteractPickUp>);
			}
			IHonamiStoryInteractPickUp.StartIHonamiStoryInteractPickUp(builder);
			return IHonamiStoryInteractPickUp.EndIHonamiStoryInteractPickUp(builder);
		}

		// Token: 0x040110A1 RID: 69793
		private Table __p;
	}
}

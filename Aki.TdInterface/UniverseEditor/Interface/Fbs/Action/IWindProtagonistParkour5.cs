using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007613 RID: 30227
	public struct IWindProtagonistParkour5 : IFlatbufferObject
	{
		// Token: 0x1700E590 RID: 58768
		// (get) Token: 0x060370EA RID: 225514 RVA: 0x00777E31 File Offset: 0x00776031
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060370EB RID: 225515 RVA: 0x00777E3E File Offset: 0x0077603E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060370EC RID: 225516 RVA: 0x00777E48 File Offset: 0x00776048
		public static IWindProtagonistParkour5 GetRootAsIWindProtagonistParkour5(ByteBuffer _bb)
		{
			return IWindProtagonistParkour5.GetRootAsIWindProtagonistParkour5(_bb, default(IWindProtagonistParkour5));
		}

		// Token: 0x060370ED RID: 225517 RVA: 0x00777E64 File Offset: 0x00776064
		public static IWindProtagonistParkour5 GetRootAsIWindProtagonistParkour5(ByteBuffer _bb, IWindProtagonistParkour5 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060370EE RID: 225518 RVA: 0x00777E81 File Offset: 0x00776081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060370EF RID: 225519 RVA: 0x00777E90 File Offset: 0x00776090
		public IWindProtagonistParkour5 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E591 RID: 58769
		// (get) Token: 0x060370F0 RID: 225520 RVA: 0x00777EA0 File Offset: 0x007760A0
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060370F1 RID: 225521 RVA: 0x00777EDC File Offset: 0x007760DC
		public static Offset<IWindProtagonistParkour5> CreateIWindProtagonistParkour5(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IWindProtagonistParkour5.AddType(builder, Type);
			return IWindProtagonistParkour5.EndIWindProtagonistParkour5(builder);
		}

		// Token: 0x060370F2 RID: 225522 RVA: 0x00777EF2 File Offset: 0x007760F2
		public static void StartIWindProtagonistParkour5(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060370F3 RID: 225523 RVA: 0x00777EFB File Offset: 0x007760FB
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060370F4 RID: 225524 RVA: 0x00777F06 File Offset: 0x00776106
		public static Offset<IWindProtagonistParkour5> EndIWindProtagonistParkour5(FlatBufferBuilder builder)
		{
			return new Offset<IWindProtagonistParkour5>(builder.EndTable());
		}

		// Token: 0x060370F5 RID: 225525 RVA: 0x00777F14 File Offset: 0x00776114
		public IWindProtagonistParkour5T UnPack()
		{
			IWindProtagonistParkour5T windProtagonistParkour5T = new IWindProtagonistParkour5T();
			this.UnPackTo(windProtagonistParkour5T);
			return windProtagonistParkour5T;
		}

		// Token: 0x060370F6 RID: 225526 RVA: 0x00777F2F File Offset: 0x0077612F
		public void UnPackTo(IWindProtagonistParkour5T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060370F7 RID: 225527 RVA: 0x00777F40 File Offset: 0x00776140
		public static Offset<IWindProtagonistParkour5> Pack(FlatBufferBuilder builder, IWindProtagonistParkour5T _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindProtagonistParkour5>);
			}
			return IWindProtagonistParkour5.CreateIWindProtagonistParkour5(builder, _o.Type);
		}

		// Token: 0x04012581 RID: 75137
		private Table __p;
	}
}

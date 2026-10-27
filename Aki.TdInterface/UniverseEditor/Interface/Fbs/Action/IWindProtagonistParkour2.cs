using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200760A RID: 30218
	public struct IWindProtagonistParkour2 : IFlatbufferObject
	{
		// Token: 0x1700E587 RID: 58759
		// (get) Token: 0x060370B4 RID: 225460 RVA: 0x007779C9 File Offset: 0x00775BC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060370B5 RID: 225461 RVA: 0x007779D6 File Offset: 0x00775BD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060370B6 RID: 225462 RVA: 0x007779E0 File Offset: 0x00775BE0
		public static IWindProtagonistParkour2 GetRootAsIWindProtagonistParkour2(ByteBuffer _bb)
		{
			return IWindProtagonistParkour2.GetRootAsIWindProtagonistParkour2(_bb, default(IWindProtagonistParkour2));
		}

		// Token: 0x060370B7 RID: 225463 RVA: 0x007779FC File Offset: 0x00775BFC
		public static IWindProtagonistParkour2 GetRootAsIWindProtagonistParkour2(ByteBuffer _bb, IWindProtagonistParkour2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060370B8 RID: 225464 RVA: 0x00777A19 File Offset: 0x00775C19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060370B9 RID: 225465 RVA: 0x00777A28 File Offset: 0x00775C28
		public IWindProtagonistParkour2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E588 RID: 58760
		// (get) Token: 0x060370BA RID: 225466 RVA: 0x00777A38 File Offset: 0x00775C38
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

		// Token: 0x060370BB RID: 225467 RVA: 0x00777A74 File Offset: 0x00775C74
		public static Offset<IWindProtagonistParkour2> CreateIWindProtagonistParkour2(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IWindProtagonistParkour2.AddType(builder, Type);
			return IWindProtagonistParkour2.EndIWindProtagonistParkour2(builder);
		}

		// Token: 0x060370BC RID: 225468 RVA: 0x00777A8A File Offset: 0x00775C8A
		public static void StartIWindProtagonistParkour2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060370BD RID: 225469 RVA: 0x00777A93 File Offset: 0x00775C93
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060370BE RID: 225470 RVA: 0x00777A9E File Offset: 0x00775C9E
		public static Offset<IWindProtagonistParkour2> EndIWindProtagonistParkour2(FlatBufferBuilder builder)
		{
			return new Offset<IWindProtagonistParkour2>(builder.EndTable());
		}

		// Token: 0x060370BF RID: 225471 RVA: 0x00777AAC File Offset: 0x00775CAC
		public IWindProtagonistParkour2T UnPack()
		{
			IWindProtagonistParkour2T windProtagonistParkour2T = new IWindProtagonistParkour2T();
			this.UnPackTo(windProtagonistParkour2T);
			return windProtagonistParkour2T;
		}

		// Token: 0x060370C0 RID: 225472 RVA: 0x00777AC7 File Offset: 0x00775CC7
		public void UnPackTo(IWindProtagonistParkour2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060370C1 RID: 225473 RVA: 0x00777AD8 File Offset: 0x00775CD8
		public static Offset<IWindProtagonistParkour2> Pack(FlatBufferBuilder builder, IWindProtagonistParkour2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindProtagonistParkour2>);
			}
			return IWindProtagonistParkour2.CreateIWindProtagonistParkour2(builder, _o.Type);
		}

		// Token: 0x0401257B RID: 75131
		private Table __p;
	}
}

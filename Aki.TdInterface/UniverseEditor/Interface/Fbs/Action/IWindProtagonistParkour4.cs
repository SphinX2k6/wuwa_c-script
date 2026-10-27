using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007610 RID: 30224
	public struct IWindProtagonistParkour4 : IFlatbufferObject
	{
		// Token: 0x1700E58D RID: 58765
		// (get) Token: 0x060370D8 RID: 225496 RVA: 0x00777CB9 File Offset: 0x00775EB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060370D9 RID: 225497 RVA: 0x00777CC6 File Offset: 0x00775EC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060370DA RID: 225498 RVA: 0x00777CD0 File Offset: 0x00775ED0
		public static IWindProtagonistParkour4 GetRootAsIWindProtagonistParkour4(ByteBuffer _bb)
		{
			return IWindProtagonistParkour4.GetRootAsIWindProtagonistParkour4(_bb, default(IWindProtagonistParkour4));
		}

		// Token: 0x060370DB RID: 225499 RVA: 0x00777CEC File Offset: 0x00775EEC
		public static IWindProtagonistParkour4 GetRootAsIWindProtagonistParkour4(ByteBuffer _bb, IWindProtagonistParkour4 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060370DC RID: 225500 RVA: 0x00777D09 File Offset: 0x00775F09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060370DD RID: 225501 RVA: 0x00777D18 File Offset: 0x00775F18
		public IWindProtagonistParkour4 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E58E RID: 58766
		// (get) Token: 0x060370DE RID: 225502 RVA: 0x00777D28 File Offset: 0x00775F28
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

		// Token: 0x060370DF RID: 225503 RVA: 0x00777D64 File Offset: 0x00775F64
		public static Offset<IWindProtagonistParkour4> CreateIWindProtagonistParkour4(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IWindProtagonistParkour4.AddType(builder, Type);
			return IWindProtagonistParkour4.EndIWindProtagonistParkour4(builder);
		}

		// Token: 0x060370E0 RID: 225504 RVA: 0x00777D7A File Offset: 0x00775F7A
		public static void StartIWindProtagonistParkour4(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060370E1 RID: 225505 RVA: 0x00777D83 File Offset: 0x00775F83
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060370E2 RID: 225506 RVA: 0x00777D8E File Offset: 0x00775F8E
		public static Offset<IWindProtagonistParkour4> EndIWindProtagonistParkour4(FlatBufferBuilder builder)
		{
			return new Offset<IWindProtagonistParkour4>(builder.EndTable());
		}

		// Token: 0x060370E3 RID: 225507 RVA: 0x00777D9C File Offset: 0x00775F9C
		public IWindProtagonistParkour4T UnPack()
		{
			IWindProtagonistParkour4T windProtagonistParkour4T = new IWindProtagonistParkour4T();
			this.UnPackTo(windProtagonistParkour4T);
			return windProtagonistParkour4T;
		}

		// Token: 0x060370E4 RID: 225508 RVA: 0x00777DB7 File Offset: 0x00775FB7
		public void UnPackTo(IWindProtagonistParkour4T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060370E5 RID: 225509 RVA: 0x00777DC8 File Offset: 0x00775FC8
		public static Offset<IWindProtagonistParkour4> Pack(FlatBufferBuilder builder, IWindProtagonistParkour4T _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindProtagonistParkour4>);
			}
			return IWindProtagonistParkour4.CreateIWindProtagonistParkour4(builder, _o.Type);
		}

		// Token: 0x0401257F RID: 75135
		private Table __p;
	}
}

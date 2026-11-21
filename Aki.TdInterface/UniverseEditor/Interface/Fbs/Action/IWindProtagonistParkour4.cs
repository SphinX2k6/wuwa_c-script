using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E1E RID: 32286
	public struct IWindProtagonistParkour4 : IFlatbufferObject
	{
		// Token: 0x1700F1CB RID: 61899
		// (get) Token: 0x0603A57D RID: 238973 RVA: 0x007DBDB5 File Offset: 0x007D9FB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A57E RID: 238974 RVA: 0x007DBDC2 File Offset: 0x007D9FC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A57F RID: 238975 RVA: 0x007DBDCC File Offset: 0x007D9FCC
		public static IWindProtagonistParkour4 GetRootAsIWindProtagonistParkour4(ByteBuffer _bb)
		{
			return IWindProtagonistParkour4.GetRootAsIWindProtagonistParkour4(_bb, default(IWindProtagonistParkour4));
		}

		// Token: 0x0603A580 RID: 238976 RVA: 0x007DBDE8 File Offset: 0x007D9FE8
		public static IWindProtagonistParkour4 GetRootAsIWindProtagonistParkour4(ByteBuffer _bb, IWindProtagonistParkour4 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A581 RID: 238977 RVA: 0x007DBE05 File Offset: 0x007DA005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A582 RID: 238978 RVA: 0x007DBE14 File Offset: 0x007DA014
		public IWindProtagonistParkour4 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1CC RID: 61900
		// (get) Token: 0x0603A583 RID: 238979 RVA: 0x007DBE24 File Offset: 0x007DA024
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

		// Token: 0x0603A584 RID: 238980 RVA: 0x007DBE60 File Offset: 0x007DA060
		public static Offset<IWindProtagonistParkour4> CreateIWindProtagonistParkour4(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IWindProtagonistParkour4.AddType(builder, Type);
			return IWindProtagonistParkour4.EndIWindProtagonistParkour4(builder);
		}

		// Token: 0x0603A585 RID: 238981 RVA: 0x007DBE76 File Offset: 0x007DA076
		public static void StartIWindProtagonistParkour4(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A586 RID: 238982 RVA: 0x007DBE7F File Offset: 0x007DA07F
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A587 RID: 238983 RVA: 0x007DBE8A File Offset: 0x007DA08A
		public static Offset<IWindProtagonistParkour4> EndIWindProtagonistParkour4(FlatBufferBuilder builder)
		{
			return new Offset<IWindProtagonistParkour4>(builder.EndTable());
		}

		// Token: 0x0603A588 RID: 238984 RVA: 0x007DBE98 File Offset: 0x007DA098
		public IWindProtagonistParkour4T UnPack()
		{
			IWindProtagonistParkour4T windProtagonistParkour4T = new IWindProtagonistParkour4T();
			this.UnPackTo(windProtagonistParkour4T);
			return windProtagonistParkour4T;
		}

		// Token: 0x0603A589 RID: 238985 RVA: 0x007DBEB3 File Offset: 0x007DA0B3
		public void UnPackTo(IWindProtagonistParkour4T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A58A RID: 238986 RVA: 0x007DBEC4 File Offset: 0x007DA0C4
		public static Offset<IWindProtagonistParkour4> Pack(FlatBufferBuilder builder, IWindProtagonistParkour4T _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindProtagonistParkour4>);
			}
			return IWindProtagonistParkour4.CreateIWindProtagonistParkour4(builder, _o.Type);
		}

		// Token: 0x040135C9 RID: 79305
		private Table __p;
	}
}

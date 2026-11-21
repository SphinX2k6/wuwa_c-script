using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E21 RID: 32289
	public struct IWindProtagonistParkour5 : IFlatbufferObject
	{
		// Token: 0x1700F1CE RID: 61902
		// (get) Token: 0x0603A58F RID: 238991 RVA: 0x007DBF2D File Offset: 0x007DA12D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A590 RID: 238992 RVA: 0x007DBF3A File Offset: 0x007DA13A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A591 RID: 238993 RVA: 0x007DBF44 File Offset: 0x007DA144
		public static IWindProtagonistParkour5 GetRootAsIWindProtagonistParkour5(ByteBuffer _bb)
		{
			return IWindProtagonistParkour5.GetRootAsIWindProtagonistParkour5(_bb, default(IWindProtagonistParkour5));
		}

		// Token: 0x0603A592 RID: 238994 RVA: 0x007DBF60 File Offset: 0x007DA160
		public static IWindProtagonistParkour5 GetRootAsIWindProtagonistParkour5(ByteBuffer _bb, IWindProtagonistParkour5 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A593 RID: 238995 RVA: 0x007DBF7D File Offset: 0x007DA17D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A594 RID: 238996 RVA: 0x007DBF8C File Offset: 0x007DA18C
		public IWindProtagonistParkour5 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1CF RID: 61903
		// (get) Token: 0x0603A595 RID: 238997 RVA: 0x007DBF9C File Offset: 0x007DA19C
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

		// Token: 0x0603A596 RID: 238998 RVA: 0x007DBFD8 File Offset: 0x007DA1D8
		public static Offset<IWindProtagonistParkour5> CreateIWindProtagonistParkour5(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IWindProtagonistParkour5.AddType(builder, Type);
			return IWindProtagonistParkour5.EndIWindProtagonistParkour5(builder);
		}

		// Token: 0x0603A597 RID: 238999 RVA: 0x007DBFEE File Offset: 0x007DA1EE
		public static void StartIWindProtagonistParkour5(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A598 RID: 239000 RVA: 0x007DBFF7 File Offset: 0x007DA1F7
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A599 RID: 239001 RVA: 0x007DC002 File Offset: 0x007DA202
		public static Offset<IWindProtagonistParkour5> EndIWindProtagonistParkour5(FlatBufferBuilder builder)
		{
			return new Offset<IWindProtagonistParkour5>(builder.EndTable());
		}

		// Token: 0x0603A59A RID: 239002 RVA: 0x007DC010 File Offset: 0x007DA210
		public IWindProtagonistParkour5T UnPack()
		{
			IWindProtagonistParkour5T windProtagonistParkour5T = new IWindProtagonistParkour5T();
			this.UnPackTo(windProtagonistParkour5T);
			return windProtagonistParkour5T;
		}

		// Token: 0x0603A59B RID: 239003 RVA: 0x007DC02B File Offset: 0x007DA22B
		public void UnPackTo(IWindProtagonistParkour5T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A59C RID: 239004 RVA: 0x007DC03C File Offset: 0x007DA23C
		public static Offset<IWindProtagonistParkour5> Pack(FlatBufferBuilder builder, IWindProtagonistParkour5T _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindProtagonistParkour5>);
			}
			return IWindProtagonistParkour5.CreateIWindProtagonistParkour5(builder, _o.Type);
		}

		// Token: 0x040135CB RID: 79307
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060A4 RID: 24740
	public struct IActorFaceExpressionType : IFlatbufferObject
	{
		// Token: 0x1700B650 RID: 46672
		// (get) Token: 0x0602A3B4 RID: 172980 RVA: 0x005D275C File Offset: 0x005D095C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A3B5 RID: 172981 RVA: 0x005D2769 File Offset: 0x005D0969
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A3B6 RID: 172982 RVA: 0x005D2770 File Offset: 0x005D0970
		public static IActorFaceExpressionType GetRootAsIActorFaceExpressionType(ByteBuffer _bb)
		{
			return IActorFaceExpressionType.GetRootAsIActorFaceExpressionType(_bb, default(IActorFaceExpressionType));
		}

		// Token: 0x0602A3B7 RID: 172983 RVA: 0x005D278C File Offset: 0x005D098C
		public static IActorFaceExpressionType GetRootAsIActorFaceExpressionType(ByteBuffer _bb, IActorFaceExpressionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A3B8 RID: 172984 RVA: 0x005D27A9 File Offset: 0x005D09A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A3B9 RID: 172985 RVA: 0x005D27B8 File Offset: 0x005D09B8
		public IActorFaceExpressionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B651 RID: 46673
		// (get) Token: 0x0602A3BA RID: 172986 RVA: 0x005D27C8 File Offset: 0x005D09C8
		public EActorFaceExpressionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorFaceExpressionType.Play;
				}
				return (EActorFaceExpressionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A3BB RID: 172987 RVA: 0x005D2804 File Offset: 0x005D0A04
		public static Offset<IActorFaceExpressionType> CreateIActorFaceExpressionType(FlatBufferBuilder builder, EActorFaceExpressionType Type = EActorFaceExpressionType.Play)
		{
			builder.StartTable(1);
			IActorFaceExpressionType.AddType(builder, Type);
			return IActorFaceExpressionType.EndIActorFaceExpressionType(builder);
		}

		// Token: 0x0602A3BC RID: 172988 RVA: 0x005D281A File Offset: 0x005D0A1A
		public static void StartIActorFaceExpressionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A3BD RID: 172989 RVA: 0x005D2823 File Offset: 0x005D0A23
		public static void AddType(FlatBufferBuilder builder, EActorFaceExpressionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A3BE RID: 172990 RVA: 0x005D282E File Offset: 0x005D0A2E
		public static Offset<IActorFaceExpressionType> EndIActorFaceExpressionType(FlatBufferBuilder builder)
		{
			return new Offset<IActorFaceExpressionType>(builder.EndTable());
		}

		// Token: 0x0602A3BF RID: 172991 RVA: 0x005D283C File Offset: 0x005D0A3C
		public IActorFaceExpressionTypeT UnPack()
		{
			IActorFaceExpressionTypeT actorFaceExpressionTypeT = new IActorFaceExpressionTypeT();
			this.UnPackTo(actorFaceExpressionTypeT);
			return actorFaceExpressionTypeT;
		}

		// Token: 0x0602A3C0 RID: 172992 RVA: 0x005D2857 File Offset: 0x005D0A57
		public void UnPackTo(IActorFaceExpressionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A3C1 RID: 172993 RVA: 0x005D2868 File Offset: 0x005D0A68
		public static Offset<IActorFaceExpressionType> Pack(FlatBufferBuilder builder, IActorFaceExpressionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFaceExpressionType>);
			}
			return IActorFaceExpressionType.CreateIActorFaceExpressionType(builder, _o.Type);
		}

		// Token: 0x0401043D RID: 66621
		private Table __p;
	}
}

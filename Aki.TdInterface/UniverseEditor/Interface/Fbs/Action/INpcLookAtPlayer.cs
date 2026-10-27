using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BCD RID: 27597
	public struct INpcLookAtPlayer : IFlatbufferObject
	{
		// Token: 0x1700CD18 RID: 52504
		// (get) Token: 0x060307B8 RID: 198584 RVA: 0x0069555E File Offset: 0x0069375E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060307B9 RID: 198585 RVA: 0x0069556B File Offset: 0x0069376B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060307BA RID: 198586 RVA: 0x00695574 File Offset: 0x00693774
		public static INpcLookAtPlayer GetRootAsINpcLookAtPlayer(ByteBuffer _bb)
		{
			return INpcLookAtPlayer.GetRootAsINpcLookAtPlayer(_bb, default(INpcLookAtPlayer));
		}

		// Token: 0x060307BB RID: 198587 RVA: 0x00695590 File Offset: 0x00693790
		public static INpcLookAtPlayer GetRootAsINpcLookAtPlayer(ByteBuffer _bb, INpcLookAtPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060307BC RID: 198588 RVA: 0x006955AD File Offset: 0x006937AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060307BD RID: 198589 RVA: 0x006955BC File Offset: 0x006937BC
		public INpcLookAtPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD19 RID: 52505
		// (get) Token: 0x060307BE RID: 198590 RVA: 0x006955CC File Offset: 0x006937CC
		public ECommonTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTargetType.Player;
				}
				return (ECommonTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060307BF RID: 198591 RVA: 0x00695608 File Offset: 0x00693808
		public static Offset<INpcLookAtPlayer> CreateINpcLookAtPlayer(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player)
		{
			builder.StartTable(1);
			INpcLookAtPlayer.AddType(builder, Type);
			return INpcLookAtPlayer.EndINpcLookAtPlayer(builder);
		}

		// Token: 0x060307C0 RID: 198592 RVA: 0x0069561E File Offset: 0x0069381E
		public static void StartINpcLookAtPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060307C1 RID: 198593 RVA: 0x00695627 File Offset: 0x00693827
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060307C2 RID: 198594 RVA: 0x00695632 File Offset: 0x00693832
		public static Offset<INpcLookAtPlayer> EndINpcLookAtPlayer(FlatBufferBuilder builder)
		{
			return new Offset<INpcLookAtPlayer>(builder.EndTable());
		}

		// Token: 0x060307C3 RID: 198595 RVA: 0x00695640 File Offset: 0x00693840
		public INpcLookAtPlayerT UnPack()
		{
			INpcLookAtPlayerT npcLookAtPlayerT = new INpcLookAtPlayerT();
			this.UnPackTo(npcLookAtPlayerT);
			return npcLookAtPlayerT;
		}

		// Token: 0x060307C4 RID: 198596 RVA: 0x0069565B File Offset: 0x0069385B
		public void UnPackTo(INpcLookAtPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060307C5 RID: 198597 RVA: 0x0069566C File Offset: 0x0069386C
		public static Offset<INpcLookAtPlayer> Pack(FlatBufferBuilder builder, INpcLookAtPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLookAtPlayer>);
			}
			return INpcLookAtPlayer.CreateINpcLookAtPlayer(builder, _o.Type);
		}

		// Token: 0x040114AD RID: 70829
		private Table __p;
	}
}

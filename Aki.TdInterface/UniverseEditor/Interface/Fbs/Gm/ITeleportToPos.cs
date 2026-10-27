using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046C3 RID: 18115
	public struct ITeleportToPos : IFlatbufferObject
	{
		// Token: 0x170080B6 RID: 32950
		// (get) Token: 0x0601B895 RID: 112789 RVA: 0x003E8416 File Offset: 0x003E6616
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B896 RID: 112790 RVA: 0x003E8423 File Offset: 0x003E6623
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B897 RID: 112791 RVA: 0x003E842C File Offset: 0x003E662C
		public static ITeleportToPos GetRootAsITeleportToPos(ByteBuffer _bb)
		{
			return ITeleportToPos.GetRootAsITeleportToPos(_bb, default(ITeleportToPos));
		}

		// Token: 0x0601B898 RID: 112792 RVA: 0x003E8448 File Offset: 0x003E6648
		public static ITeleportToPos GetRootAsITeleportToPos(ByteBuffer _bb, ITeleportToPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B899 RID: 112793 RVA: 0x003E8465 File Offset: 0x003E6665
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B89A RID: 112794 RVA: 0x003E8474 File Offset: 0x003E6674
		public ITeleportToPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080B7 RID: 32951
		// (get) Token: 0x0601B89B RID: 112795 RVA: 0x003E8484 File Offset: 0x003E6684
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170080B8 RID: 32952
		// (get) Token: 0x0601B89C RID: 112796 RVA: 0x003E84C0 File Offset: 0x003E66C0
		public IPosA? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601B89D RID: 112797 RVA: 0x003E851D File Offset: 0x003E671D
		public static Offset<ITeleportToPos> CreateITeleportToPos(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, Offset<IPosA> PosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(2);
			ITeleportToPos.AddPos(builder, PosOffset);
			ITeleportToPos.AddType(builder, Type);
			return ITeleportToPos.EndITeleportToPos(builder);
		}

		// Token: 0x0601B89E RID: 112798 RVA: 0x003E853A File Offset: 0x003E673A
		public static void StartITeleportToPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B89F RID: 112799 RVA: 0x003E8543 File Offset: 0x003E6743
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B8A0 RID: 112800 RVA: 0x003E854E File Offset: 0x003E674E
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0601B8A1 RID: 112801 RVA: 0x003E855E File Offset: 0x003E675E
		public static Offset<ITeleportToPos> EndITeleportToPos(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToPos>(builder.EndTable());
		}

		// Token: 0x0601B8A2 RID: 112802 RVA: 0x003E856C File Offset: 0x003E676C
		public ITeleportToPosT UnPack()
		{
			ITeleportToPosT teleportToPosT = new ITeleportToPosT();
			this.UnPackTo(teleportToPosT);
			return teleportToPosT;
		}

		// Token: 0x0601B8A3 RID: 112803 RVA: 0x003E8588 File Offset: 0x003E6788
		public void UnPackTo(ITeleportToPosT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0601B8A4 RID: 112804 RVA: 0x003E85D0 File Offset: 0x003E67D0
		public static Offset<ITeleportToPos> Pack(FlatBufferBuilder builder, ITeleportToPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToPos>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return ITeleportToPos.CreateITeleportToPos(builder, _o.Type, posOffset);
		}

		// Token: 0x0400C895 RID: 51349
		private Table __p;
	}
}

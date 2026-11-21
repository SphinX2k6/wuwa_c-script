using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B2B RID: 19243
	public struct ITeleportToPos : IFlatbufferObject
	{
		// Token: 0x170086F7 RID: 34551
		// (get) Token: 0x0601D06A RID: 118890 RVA: 0x004146B2 File Offset: 0x004128B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D06B RID: 118891 RVA: 0x004146BF File Offset: 0x004128BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D06C RID: 118892 RVA: 0x004146C8 File Offset: 0x004128C8
		public static ITeleportToPos GetRootAsITeleportToPos(ByteBuffer _bb)
		{
			return ITeleportToPos.GetRootAsITeleportToPos(_bb, default(ITeleportToPos));
		}

		// Token: 0x0601D06D RID: 118893 RVA: 0x004146E4 File Offset: 0x004128E4
		public static ITeleportToPos GetRootAsITeleportToPos(ByteBuffer _bb, ITeleportToPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D06E RID: 118894 RVA: 0x00414701 File Offset: 0x00412901
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D06F RID: 118895 RVA: 0x00414710 File Offset: 0x00412910
		public ITeleportToPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086F8 RID: 34552
		// (get) Token: 0x0601D070 RID: 118896 RVA: 0x00414720 File Offset: 0x00412920
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

		// Token: 0x170086F9 RID: 34553
		// (get) Token: 0x0601D071 RID: 118897 RVA: 0x0041475C File Offset: 0x0041295C
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

		// Token: 0x0601D072 RID: 118898 RVA: 0x004147B9 File Offset: 0x004129B9
		public static Offset<ITeleportToPos> CreateITeleportToPos(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, Offset<IPosA> PosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(2);
			ITeleportToPos.AddPos(builder, PosOffset);
			ITeleportToPos.AddType(builder, Type);
			return ITeleportToPos.EndITeleportToPos(builder);
		}

		// Token: 0x0601D073 RID: 118899 RVA: 0x004147D6 File Offset: 0x004129D6
		public static void StartITeleportToPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D074 RID: 118900 RVA: 0x004147DF File Offset: 0x004129DF
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D075 RID: 118901 RVA: 0x004147EA File Offset: 0x004129EA
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0601D076 RID: 118902 RVA: 0x004147FA File Offset: 0x004129FA
		public static Offset<ITeleportToPos> EndITeleportToPos(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToPos>(builder.EndTable());
		}

		// Token: 0x0601D077 RID: 118903 RVA: 0x00414808 File Offset: 0x00412A08
		public ITeleportToPosT UnPack()
		{
			ITeleportToPosT teleportToPosT = new ITeleportToPosT();
			this.UnPackTo(teleportToPosT);
			return teleportToPosT;
		}

		// Token: 0x0601D078 RID: 118904 RVA: 0x00414824 File Offset: 0x00412A24
		public void UnPackTo(ITeleportToPosT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0601D079 RID: 118905 RVA: 0x0041486C File Offset: 0x00412A6C
		public static Offset<ITeleportToPos> Pack(FlatBufferBuilder builder, ITeleportToPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToPos>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return ITeleportToPos.CreateITeleportToPos(builder, _o.Type, posOffset);
		}

		// Token: 0x0400D2C4 RID: 53956
		private Table __p;
	}
}

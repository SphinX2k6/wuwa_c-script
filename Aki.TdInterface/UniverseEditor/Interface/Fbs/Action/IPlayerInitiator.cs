using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007471 RID: 29809
	public struct IPlayerInitiator : IFlatbufferObject
	{
		// Token: 0x1700DB02 RID: 56066
		// (get) Token: 0x060342ED RID: 213741 RVA: 0x00707999 File Offset: 0x00705B99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060342EE RID: 213742 RVA: 0x007079A6 File Offset: 0x00705BA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060342EF RID: 213743 RVA: 0x007079B0 File Offset: 0x00705BB0
		public static IPlayerInitiator GetRootAsIPlayerInitiator(ByteBuffer _bb)
		{
			return IPlayerInitiator.GetRootAsIPlayerInitiator(_bb, default(IPlayerInitiator));
		}

		// Token: 0x060342F0 RID: 213744 RVA: 0x007079CC File Offset: 0x00705BCC
		public static IPlayerInitiator GetRootAsIPlayerInitiator(ByteBuffer _bb, IPlayerInitiator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060342F1 RID: 213745 RVA: 0x007079E9 File Offset: 0x00705BE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060342F2 RID: 213746 RVA: 0x007079F8 File Offset: 0x00705BF8
		public IPlayerInitiator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB03 RID: 56067
		// (get) Token: 0x060342F3 RID: 213747 RVA: 0x00707A08 File Offset: 0x00705C08
		public ENpcGroupPerformInitiatorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformInitiatorType.Player;
				}
				return (ENpcGroupPerformInitiatorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060342F4 RID: 213748 RVA: 0x00707A44 File Offset: 0x00705C44
		public static Offset<IPlayerInitiator> CreateIPlayerInitiator(FlatBufferBuilder builder, ENpcGroupPerformInitiatorType Type = ENpcGroupPerformInitiatorType.Player)
		{
			builder.StartTable(1);
			IPlayerInitiator.AddType(builder, Type);
			return IPlayerInitiator.EndIPlayerInitiator(builder);
		}

		// Token: 0x060342F5 RID: 213749 RVA: 0x00707A5A File Offset: 0x00705C5A
		public static void StartIPlayerInitiator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060342F6 RID: 213750 RVA: 0x00707A63 File Offset: 0x00705C63
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformInitiatorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060342F7 RID: 213751 RVA: 0x00707A6E File Offset: 0x00705C6E
		public static Offset<IPlayerInitiator> EndIPlayerInitiator(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerInitiator>(builder.EndTable());
		}

		// Token: 0x060342F8 RID: 213752 RVA: 0x00707A7C File Offset: 0x00705C7C
		public IPlayerInitiatorT UnPack()
		{
			IPlayerInitiatorT playerInitiatorT = new IPlayerInitiatorT();
			this.UnPackTo(playerInitiatorT);
			return playerInitiatorT;
		}

		// Token: 0x060342F9 RID: 213753 RVA: 0x00707A97 File Offset: 0x00705C97
		public void UnPackTo(IPlayerInitiatorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060342FA RID: 213754 RVA: 0x00707AA8 File Offset: 0x00705CA8
		public static Offset<IPlayerInitiator> Pack(FlatBufferBuilder builder, IPlayerInitiatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerInitiator>);
			}
			return IPlayerInitiator.CreateIPlayerInitiator(builder, _o.Type);
		}

		// Token: 0x040125ED RID: 75245
		private Table __p;
	}
}

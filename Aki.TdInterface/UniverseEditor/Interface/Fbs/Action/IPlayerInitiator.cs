using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF6 RID: 27894
	public struct IPlayerInitiator : IFlatbufferObject
	{
		// Token: 0x1700CFBE RID: 53182
		// (get) Token: 0x060312F9 RID: 201465 RVA: 0x006AC469 File Offset: 0x006AA669
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060312FA RID: 201466 RVA: 0x006AC476 File Offset: 0x006AA676
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060312FB RID: 201467 RVA: 0x006AC480 File Offset: 0x006AA680
		public static IPlayerInitiator GetRootAsIPlayerInitiator(ByteBuffer _bb)
		{
			return IPlayerInitiator.GetRootAsIPlayerInitiator(_bb, default(IPlayerInitiator));
		}

		// Token: 0x060312FC RID: 201468 RVA: 0x006AC49C File Offset: 0x006AA69C
		public static IPlayerInitiator GetRootAsIPlayerInitiator(ByteBuffer _bb, IPlayerInitiator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060312FD RID: 201469 RVA: 0x006AC4B9 File Offset: 0x006AA6B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060312FE RID: 201470 RVA: 0x006AC4C8 File Offset: 0x006AA6C8
		public IPlayerInitiator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFBF RID: 53183
		// (get) Token: 0x060312FF RID: 201471 RVA: 0x006AC4D8 File Offset: 0x006AA6D8
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

		// Token: 0x06031300 RID: 201472 RVA: 0x006AC514 File Offset: 0x006AA714
		public static Offset<IPlayerInitiator> CreateIPlayerInitiator(FlatBufferBuilder builder, ENpcGroupPerformInitiatorType Type = ENpcGroupPerformInitiatorType.Player)
		{
			builder.StartTable(1);
			IPlayerInitiator.AddType(builder, Type);
			return IPlayerInitiator.EndIPlayerInitiator(builder);
		}

		// Token: 0x06031301 RID: 201473 RVA: 0x006AC52A File Offset: 0x006AA72A
		public static void StartIPlayerInitiator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031302 RID: 201474 RVA: 0x006AC533 File Offset: 0x006AA733
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformInitiatorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031303 RID: 201475 RVA: 0x006AC53E File Offset: 0x006AA73E
		public static Offset<IPlayerInitiator> EndIPlayerInitiator(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerInitiator>(builder.EndTable());
		}

		// Token: 0x06031304 RID: 201476 RVA: 0x006AC54C File Offset: 0x006AA74C
		public IPlayerInitiatorT UnPack()
		{
			IPlayerInitiatorT playerInitiatorT = new IPlayerInitiatorT();
			this.UnPackTo(playerInitiatorT);
			return playerInitiatorT;
		}

		// Token: 0x06031305 RID: 201477 RVA: 0x006AC567 File Offset: 0x006AA767
		public void UnPackTo(IPlayerInitiatorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031306 RID: 201478 RVA: 0x006AC578 File Offset: 0x006AA778
		public static Offset<IPlayerInitiator> Pack(FlatBufferBuilder builder, IPlayerInitiatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerInitiator>);
			}
			return IPlayerInitiator.CreateIPlayerInitiator(builder, _o.Type);
		}

		// Token: 0x04011673 RID: 71283
		private Table __p;
	}
}

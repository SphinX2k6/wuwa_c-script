using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D5 RID: 27093
	public struct ICheckFlowLookAtPlayer : IFlatbufferObject
	{
		// Token: 0x1700C75E RID: 51038
		// (get) Token: 0x0602E7B7 RID: 190391 RVA: 0x0065793A File Offset: 0x00655B3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E7B8 RID: 190392 RVA: 0x00657947 File Offset: 0x00655B47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E7B9 RID: 190393 RVA: 0x00657950 File Offset: 0x00655B50
		public static ICheckFlowLookAtPlayer GetRootAsICheckFlowLookAtPlayer(ByteBuffer _bb)
		{
			return ICheckFlowLookAtPlayer.GetRootAsICheckFlowLookAtPlayer(_bb, default(ICheckFlowLookAtPlayer));
		}

		// Token: 0x0602E7BA RID: 190394 RVA: 0x0065796C File Offset: 0x00655B6C
		public static ICheckFlowLookAtPlayer GetRootAsICheckFlowLookAtPlayer(ByteBuffer _bb, ICheckFlowLookAtPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E7BB RID: 190395 RVA: 0x00657989 File Offset: 0x00655B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E7BC RID: 190396 RVA: 0x00657998 File Offset: 0x00655B98
		public ICheckFlowLookAtPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C75F RID: 51039
		// (get) Token: 0x0602E7BD RID: 190397 RVA: 0x006579A8 File Offset: 0x00655BA8
		public ECheckFlowLookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckFlowLookAtTargetType.Entity;
				}
				return (ECheckFlowLookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E7BE RID: 190398 RVA: 0x006579E4 File Offset: 0x00655BE4
		public static Offset<ICheckFlowLookAtPlayer> CreateICheckFlowLookAtPlayer(FlatBufferBuilder builder, ECheckFlowLookAtTargetType Type = ECheckFlowLookAtTargetType.Entity)
		{
			builder.StartTable(1);
			ICheckFlowLookAtPlayer.AddType(builder, Type);
			return ICheckFlowLookAtPlayer.EndICheckFlowLookAtPlayer(builder);
		}

		// Token: 0x0602E7BF RID: 190399 RVA: 0x006579FA File Offset: 0x00655BFA
		public static void StartICheckFlowLookAtPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E7C0 RID: 190400 RVA: 0x00657A03 File Offset: 0x00655C03
		public static void AddType(FlatBufferBuilder builder, ECheckFlowLookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E7C1 RID: 190401 RVA: 0x00657A0E File Offset: 0x00655C0E
		public static Offset<ICheckFlowLookAtPlayer> EndICheckFlowLookAtPlayer(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlowLookAtPlayer>(builder.EndTable());
		}

		// Token: 0x0602E7C2 RID: 190402 RVA: 0x00657A1C File Offset: 0x00655C1C
		public ICheckFlowLookAtPlayerT UnPack()
		{
			ICheckFlowLookAtPlayerT checkFlowLookAtPlayerT = new ICheckFlowLookAtPlayerT();
			this.UnPackTo(checkFlowLookAtPlayerT);
			return checkFlowLookAtPlayerT;
		}

		// Token: 0x0602E7C3 RID: 190403 RVA: 0x00657A37 File Offset: 0x00655C37
		public void UnPackTo(ICheckFlowLookAtPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E7C4 RID: 190404 RVA: 0x00657A48 File Offset: 0x00655C48
		public static Offset<ICheckFlowLookAtPlayer> Pack(FlatBufferBuilder builder, ICheckFlowLookAtPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFlowLookAtPlayer>);
			}
			return ICheckFlowLookAtPlayer.CreateICheckFlowLookAtPlayer(builder, _o.Type);
		}

		// Token: 0x04011747 RID: 71495
		private Table __p;
	}
}

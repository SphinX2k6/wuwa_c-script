using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007337 RID: 29495
	public struct INpcLookAtTypeBase : IFlatbufferObject
	{
		// Token: 0x1700D82C RID: 55340
		// (get) Token: 0x060336FC RID: 210684 RVA: 0x006EF264 File Offset: 0x006ED464
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060336FD RID: 210685 RVA: 0x006EF271 File Offset: 0x006ED471
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060336FE RID: 210686 RVA: 0x006EF278 File Offset: 0x006ED478
		public static INpcLookAtTypeBase GetRootAsINpcLookAtTypeBase(ByteBuffer _bb)
		{
			return INpcLookAtTypeBase.GetRootAsINpcLookAtTypeBase(_bb, default(INpcLookAtTypeBase));
		}

		// Token: 0x060336FF RID: 210687 RVA: 0x006EF294 File Offset: 0x006ED494
		public static INpcLookAtTypeBase GetRootAsINpcLookAtTypeBase(ByteBuffer _bb, INpcLookAtTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033700 RID: 210688 RVA: 0x006EF2B1 File Offset: 0x006ED4B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033701 RID: 210689 RVA: 0x006EF2C0 File Offset: 0x006ED4C0
		public INpcLookAtTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D82D RID: 55341
		// (get) Token: 0x06033702 RID: 210690 RVA: 0x006EF2D0 File Offset: 0x006ED4D0
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

		// Token: 0x06033703 RID: 210691 RVA: 0x006EF30C File Offset: 0x006ED50C
		public static Offset<INpcLookAtTypeBase> CreateINpcLookAtTypeBase(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player)
		{
			builder.StartTable(1);
			INpcLookAtTypeBase.AddType(builder, Type);
			return INpcLookAtTypeBase.EndINpcLookAtTypeBase(builder);
		}

		// Token: 0x06033704 RID: 210692 RVA: 0x006EF322 File Offset: 0x006ED522
		public static void StartINpcLookAtTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033705 RID: 210693 RVA: 0x006EF32B File Offset: 0x006ED52B
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033706 RID: 210694 RVA: 0x006EF336 File Offset: 0x006ED536
		public static Offset<INpcLookAtTypeBase> EndINpcLookAtTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<INpcLookAtTypeBase>(builder.EndTable());
		}

		// Token: 0x06033707 RID: 210695 RVA: 0x006EF344 File Offset: 0x006ED544
		public INpcLookAtTypeBaseT UnPack()
		{
			INpcLookAtTypeBaseT npcLookAtTypeBaseT = new INpcLookAtTypeBaseT();
			this.UnPackTo(npcLookAtTypeBaseT);
			return npcLookAtTypeBaseT;
		}

		// Token: 0x06033708 RID: 210696 RVA: 0x006EF35F File Offset: 0x006ED55F
		public void UnPackTo(INpcLookAtTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033709 RID: 210697 RVA: 0x006EF370 File Offset: 0x006ED570
		public static Offset<INpcLookAtTypeBase> Pack(FlatBufferBuilder builder, INpcLookAtTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLookAtTypeBase>);
			}
			return INpcLookAtTypeBase.CreateINpcLookAtTypeBase(builder, _o.Type);
		}

		// Token: 0x04012401 RID: 74753
		private Table __p;
	}
}

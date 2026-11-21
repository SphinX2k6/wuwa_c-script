using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007346 RID: 29510
	public struct INpcSitDown : IFlatbufferObject
	{
		// Token: 0x1700D842 RID: 55362
		// (get) Token: 0x06033764 RID: 210788 RVA: 0x006EFC7E File Offset: 0x006EDE7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033765 RID: 210789 RVA: 0x006EFC8B File Offset: 0x006EDE8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033766 RID: 210790 RVA: 0x006EFC94 File Offset: 0x006EDE94
		public static INpcSitDown GetRootAsINpcSitDown(ByteBuffer _bb)
		{
			return INpcSitDown.GetRootAsINpcSitDown(_bb, default(INpcSitDown));
		}

		// Token: 0x06033767 RID: 210791 RVA: 0x006EFCB0 File Offset: 0x006EDEB0
		public static INpcSitDown GetRootAsINpcSitDown(ByteBuffer _bb, INpcSitDown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033768 RID: 210792 RVA: 0x006EFCCD File Offset: 0x006EDECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033769 RID: 210793 RVA: 0x006EFCDC File Offset: 0x006EDEDC
		public INpcSitDown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D843 RID: 55363
		// (get) Token: 0x0603376A RID: 210794 RVA: 0x006EFCEC File Offset: 0x006EDEEC
		public ENpcLeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcLeisureInteract.SitDown;
				}
				return (ENpcLeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D844 RID: 55364
		// (get) Token: 0x0603376B RID: 210795 RVA: 0x006EFD28 File Offset: 0x006EDF28
		public bool KeepState
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D845 RID: 55365
		// (get) Token: 0x0603376C RID: 210796 RVA: 0x006EFD68 File Offset: 0x006EDF68
		public IMontageId? MontageId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D846 RID: 55366
		// (get) Token: 0x0603376D RID: 210797 RVA: 0x006EFDC8 File Offset: 0x006EDFC8
		public int PosEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D847 RID: 55367
		// (get) Token: 0x0603376E RID: 210798 RVA: 0x006EFE08 File Offset: 0x006EE008
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D848 RID: 55368
		// (get) Token: 0x0603376F RID: 210799 RVA: 0x006EFE4C File Offset: 0x006EE04C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033770 RID: 210800 RVA: 0x006EFE89 File Offset: 0x006EE089
		public static Offset<INpcSitDown> CreateINpcSitDown(FlatBufferBuilder builder, ENpcLeisureInteract Type = ENpcLeisureInteract.SitDown, bool KeepState = false, Offset<IMontageId> MontageIdOffset = default(Offset<IMontageId>), int PosEntityId = 0, float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			INpcSitDown.AddDuration(builder, Duration);
			INpcSitDown.AddPosEntityId(builder, PosEntityId);
			INpcSitDown.AddMontageId(builder, MontageIdOffset);
			INpcSitDown.AddNullMask(builder, NullMask);
			INpcSitDown.AddKeepState(builder, KeepState);
			INpcSitDown.AddType(builder, Type);
			return INpcSitDown.EndINpcSitDown(builder);
		}

		// Token: 0x06033771 RID: 210801 RVA: 0x006EFEC5 File Offset: 0x006EE0C5
		public static void StartINpcSitDown(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06033772 RID: 210802 RVA: 0x006EFECE File Offset: 0x006EE0CE
		public static void AddType(FlatBufferBuilder builder, ENpcLeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033773 RID: 210803 RVA: 0x006EFED9 File Offset: 0x006EE0D9
		public static void AddKeepState(FlatBufferBuilder builder, bool keepState)
		{
			builder.AddBool(1, keepState, false);
		}

		// Token: 0x06033774 RID: 210804 RVA: 0x006EFEE4 File Offset: 0x006EE0E4
		public static void AddMontageId(FlatBufferBuilder builder, Offset<IMontageId> montageIdOffset)
		{
			builder.AddOffset(2, montageIdOffset.Value, 0);
		}

		// Token: 0x06033775 RID: 210805 RVA: 0x006EFEF4 File Offset: 0x006EE0F4
		public static void AddPosEntityId(FlatBufferBuilder builder, int posEntityId)
		{
			builder.AddInt(3, posEntityId, 0);
		}

		// Token: 0x06033776 RID: 210806 RVA: 0x006EFEFF File Offset: 0x006EE0FF
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x06033777 RID: 210807 RVA: 0x006EFF12 File Offset: 0x006EE112
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06033778 RID: 210808 RVA: 0x006EFF1D File Offset: 0x006EE11D
		public static Offset<INpcSitDown> EndINpcSitDown(FlatBufferBuilder builder)
		{
			return new Offset<INpcSitDown>(builder.EndTable());
		}

		// Token: 0x06033779 RID: 210809 RVA: 0x006EFF2C File Offset: 0x006EE12C
		public INpcSitDownT UnPack()
		{
			INpcSitDownT npcSitDownT = new INpcSitDownT();
			this.UnPackTo(npcSitDownT);
			return npcSitDownT;
		}

		// Token: 0x0603377A RID: 210810 RVA: 0x006EFF48 File Offset: 0x006EE148
		public void UnPackTo(INpcSitDownT _o)
		{
			_o.Type = this.Type;
			_o.KeepState = this.KeepState;
			_o.MontageId = ((this.MontageId != null) ? this.MontageId.Value.UnPack() : null);
			_o.PosEntityId = this.PosEntityId;
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603377B RID: 210811 RVA: 0x006EFFC0 File Offset: 0x006EE1C0
		public static Offset<INpcSitDown> Pack(FlatBufferBuilder builder, INpcSitDownT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSitDown>);
			}
			Offset<IMontageId> montageIdOffset = (_o.MontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.MontageId);
			return INpcSitDown.CreateINpcSitDown(builder, _o.Type, _o.KeepState, montageIdOffset, _o.PosEntityId, _o.Duration, _o.NullMask);
		}

		// Token: 0x04012415 RID: 74773
		private Table __p;
	}
}

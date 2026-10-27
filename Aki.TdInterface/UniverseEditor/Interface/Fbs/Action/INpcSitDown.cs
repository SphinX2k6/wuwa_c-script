using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE2 RID: 27618
	public struct INpcSitDown : IFlatbufferObject
	{
		// Token: 0x1700CD36 RID: 52534
		// (get) Token: 0x06030848 RID: 198728 RVA: 0x0069637E File Offset: 0x0069457E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030849 RID: 198729 RVA: 0x0069638B File Offset: 0x0069458B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603084A RID: 198730 RVA: 0x00696394 File Offset: 0x00694594
		public static INpcSitDown GetRootAsINpcSitDown(ByteBuffer _bb)
		{
			return INpcSitDown.GetRootAsINpcSitDown(_bb, default(INpcSitDown));
		}

		// Token: 0x0603084B RID: 198731 RVA: 0x006963B0 File Offset: 0x006945B0
		public static INpcSitDown GetRootAsINpcSitDown(ByteBuffer _bb, INpcSitDown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603084C RID: 198732 RVA: 0x006963CD File Offset: 0x006945CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603084D RID: 198733 RVA: 0x006963DC File Offset: 0x006945DC
		public INpcSitDown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD37 RID: 52535
		// (get) Token: 0x0603084E RID: 198734 RVA: 0x006963EC File Offset: 0x006945EC
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

		// Token: 0x1700CD38 RID: 52536
		// (get) Token: 0x0603084F RID: 198735 RVA: 0x00696428 File Offset: 0x00694628
		public bool KeepState
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD39 RID: 52537
		// (get) Token: 0x06030850 RID: 198736 RVA: 0x00696468 File Offset: 0x00694668
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

		// Token: 0x1700CD3A RID: 52538
		// (get) Token: 0x06030851 RID: 198737 RVA: 0x006964C8 File Offset: 0x006946C8
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

		// Token: 0x1700CD3B RID: 52539
		// (get) Token: 0x06030852 RID: 198738 RVA: 0x00696508 File Offset: 0x00694708
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

		// Token: 0x1700CD3C RID: 52540
		// (get) Token: 0x06030853 RID: 198739 RVA: 0x0069654C File Offset: 0x0069474C
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

		// Token: 0x06030854 RID: 198740 RVA: 0x00696589 File Offset: 0x00694789
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

		// Token: 0x06030855 RID: 198741 RVA: 0x006965C5 File Offset: 0x006947C5
		public static void StartINpcSitDown(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06030856 RID: 198742 RVA: 0x006965CE File Offset: 0x006947CE
		public static void AddType(FlatBufferBuilder builder, ENpcLeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030857 RID: 198743 RVA: 0x006965D9 File Offset: 0x006947D9
		public static void AddKeepState(FlatBufferBuilder builder, bool keepState)
		{
			builder.AddBool(1, keepState, false);
		}

		// Token: 0x06030858 RID: 198744 RVA: 0x006965E4 File Offset: 0x006947E4
		public static void AddMontageId(FlatBufferBuilder builder, Offset<IMontageId> montageIdOffset)
		{
			builder.AddOffset(2, montageIdOffset.Value, 0);
		}

		// Token: 0x06030859 RID: 198745 RVA: 0x006965F4 File Offset: 0x006947F4
		public static void AddPosEntityId(FlatBufferBuilder builder, int posEntityId)
		{
			builder.AddInt(3, posEntityId, 0);
		}

		// Token: 0x0603085A RID: 198746 RVA: 0x006965FF File Offset: 0x006947FF
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x0603085B RID: 198747 RVA: 0x00696612 File Offset: 0x00694812
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0603085C RID: 198748 RVA: 0x0069661D File Offset: 0x0069481D
		public static Offset<INpcSitDown> EndINpcSitDown(FlatBufferBuilder builder)
		{
			return new Offset<INpcSitDown>(builder.EndTable());
		}

		// Token: 0x0603085D RID: 198749 RVA: 0x0069662C File Offset: 0x0069482C
		public INpcSitDownT UnPack()
		{
			INpcSitDownT npcSitDownT = new INpcSitDownT();
			this.UnPackTo(npcSitDownT);
			return npcSitDownT;
		}

		// Token: 0x0603085E RID: 198750 RVA: 0x00696648 File Offset: 0x00694848
		public void UnPackTo(INpcSitDownT _o)
		{
			_o.Type = this.Type;
			_o.KeepState = this.KeepState;
			_o.MontageId = ((this.MontageId != null) ? this.MontageId.Value.UnPack() : null);
			_o.PosEntityId = this.PosEntityId;
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603085F RID: 198751 RVA: 0x006966C0 File Offset: 0x006948C0
		public static Offset<INpcSitDown> Pack(FlatBufferBuilder builder, INpcSitDownT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSitDown>);
			}
			Offset<IMontageId> montageIdOffset = (_o.MontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.MontageId);
			return INpcSitDown.CreateINpcSitDown(builder, _o.Type, _o.KeepState, montageIdOffset, _o.PosEntityId, _o.Duration, _o.NullMask);
		}

		// Token: 0x040114C6 RID: 70854
		private Table __p;
	}
}

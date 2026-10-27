using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060CB RID: 24779
	public struct IActorInitialMontage : IFlatbufferObject
	{
		// Token: 0x1700B694 RID: 46740
		// (get) Token: 0x0602A4F2 RID: 173298 RVA: 0x005D4B9B File Offset: 0x005D2D9B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A4F3 RID: 173299 RVA: 0x005D4BA8 File Offset: 0x005D2DA8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A4F4 RID: 173300 RVA: 0x005D4BB0 File Offset: 0x005D2DB0
		public static IActorInitialMontage GetRootAsIActorInitialMontage(ByteBuffer _bb)
		{
			return IActorInitialMontage.GetRootAsIActorInitialMontage(_bb, default(IActorInitialMontage));
		}

		// Token: 0x0602A4F5 RID: 173301 RVA: 0x005D4BCC File Offset: 0x005D2DCC
		public static IActorInitialMontage GetRootAsIActorInitialMontage(ByteBuffer _bb, IActorInitialMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A4F6 RID: 173302 RVA: 0x005D4BE9 File Offset: 0x005D2DE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A4F7 RID: 173303 RVA: 0x005D4BF8 File Offset: 0x005D2DF8
		public IActorInitialMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B695 RID: 46741
		// (get) Token: 0x0602A4F8 RID: 173304 RVA: 0x005D4C08 File Offset: 0x005D2E08
		public IMontageId? MontageId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602A4F9 RID: 173305 RVA: 0x005D4C65 File Offset: 0x005D2E65
		public static Offset<IActorInitialMontage> CreateIActorInitialMontage(FlatBufferBuilder builder, Offset<IMontageId> MontageIdOffset = default(Offset<IMontageId>))
		{
			builder.StartTable(1);
			IActorInitialMontage.AddMontageId(builder, MontageIdOffset);
			return IActorInitialMontage.EndIActorInitialMontage(builder);
		}

		// Token: 0x0602A4FA RID: 173306 RVA: 0x005D4C7B File Offset: 0x005D2E7B
		public static void StartIActorInitialMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A4FB RID: 173307 RVA: 0x005D4C84 File Offset: 0x005D2E84
		public static void AddMontageId(FlatBufferBuilder builder, Offset<IMontageId> montageIdOffset)
		{
			builder.AddOffset(0, montageIdOffset.Value, 0);
		}

		// Token: 0x0602A4FC RID: 173308 RVA: 0x005D4C94 File Offset: 0x005D2E94
		public static Offset<IActorInitialMontage> EndIActorInitialMontage(FlatBufferBuilder builder)
		{
			return new Offset<IActorInitialMontage>(builder.EndTable());
		}

		// Token: 0x0602A4FD RID: 173309 RVA: 0x005D4CA4 File Offset: 0x005D2EA4
		public IActorInitialMontageT UnPack()
		{
			IActorInitialMontageT actorInitialMontageT = new IActorInitialMontageT();
			this.UnPackTo(actorInitialMontageT);
			return actorInitialMontageT;
		}

		// Token: 0x0602A4FE RID: 173310 RVA: 0x005D4CC0 File Offset: 0x005D2EC0
		public void UnPackTo(IActorInitialMontageT _o)
		{
			_o.MontageId = ((this.MontageId != null) ? this.MontageId.Value.UnPack() : null);
		}

		// Token: 0x0602A4FF RID: 173311 RVA: 0x005D4CFC File Offset: 0x005D2EFC
		public static Offset<IActorInitialMontage> Pack(FlatBufferBuilder builder, IActorInitialMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorInitialMontage>);
			}
			Offset<IMontageId> montageIdOffset = (_o.MontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.MontageId);
			return IActorInitialMontage.CreateIActorInitialMontage(builder, montageIdOffset);
		}

		// Token: 0x04010476 RID: 66678
		private Table __p;
	}
}

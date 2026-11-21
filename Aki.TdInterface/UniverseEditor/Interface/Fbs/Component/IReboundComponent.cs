using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E12 RID: 24082
	public struct IReboundComponent : IFlatbufferObject
	{
		// Token: 0x1700B183 RID: 45443
		// (get) Token: 0x06028367 RID: 164711 RVA: 0x0057FDE3 File Offset: 0x0057DFE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028368 RID: 164712 RVA: 0x0057FDF0 File Offset: 0x0057DFF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028369 RID: 164713 RVA: 0x0057FDF8 File Offset: 0x0057DFF8
		public static IReboundComponent GetRootAsIReboundComponent(ByteBuffer _bb)
		{
			return IReboundComponent.GetRootAsIReboundComponent(_bb, default(IReboundComponent));
		}

		// Token: 0x0602836A RID: 164714 RVA: 0x0057FE14 File Offset: 0x0057E014
		public static IReboundComponent GetRootAsIReboundComponent(ByteBuffer _bb, IReboundComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602836B RID: 164715 RVA: 0x0057FE31 File Offset: 0x0057E031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602836C RID: 164716 RVA: 0x0057FE40 File Offset: 0x0057E040
		public IReboundComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B184 RID: 45444
		// (get) Token: 0x0602836D RID: 164717 RVA: 0x0057FE50 File Offset: 0x0057E050
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B185 RID: 45445
		// (get) Token: 0x0602836E RID: 164718 RVA: 0x0057FE90 File Offset: 0x0057E090
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B186 RID: 45446
		// (get) Token: 0x0602836F RID: 164719 RVA: 0x0057FED0 File Offset: 0x0057E0D0
		public IForwardFrontRebound? Option
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IForwardFrontRebound?(default(IForwardFrontRebound).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B187 RID: 45447
		// (get) Token: 0x06028370 RID: 164720 RVA: 0x0057FF30 File Offset: 0x0057E130
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028371 RID: 164721 RVA: 0x0057FF6D File Offset: 0x0057E16D
		public static Offset<IReboundComponent> CreateIReboundComponent(FlatBufferBuilder builder, bool Disabled = false, long BulletId = 0L, Offset<IForwardFrontRebound> OptionOffset = default(Offset<IForwardFrontRebound>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IReboundComponent.AddBulletId(builder, BulletId);
			IReboundComponent.AddOption(builder, OptionOffset);
			IReboundComponent.AddNullMask(builder, NullMask);
			IReboundComponent.AddDisabled(builder, Disabled);
			return IReboundComponent.EndIReboundComponent(builder);
		}

		// Token: 0x06028372 RID: 164722 RVA: 0x0057FF99 File Offset: 0x0057E199
		public static void StartIReboundComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028373 RID: 164723 RVA: 0x0057FFA2 File Offset: 0x0057E1A2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028374 RID: 164724 RVA: 0x0057FFAD File Offset: 0x0057E1AD
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06028375 RID: 164725 RVA: 0x0057FFB9 File Offset: 0x0057E1B9
		public static void AddOption(FlatBufferBuilder builder, Offset<IForwardFrontRebound> optionOffset)
		{
			builder.AddOffset(2, optionOffset.Value, 0);
		}

		// Token: 0x06028376 RID: 164726 RVA: 0x0057FFC9 File Offset: 0x0057E1C9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06028377 RID: 164727 RVA: 0x0057FFD4 File Offset: 0x0057E1D4
		public static Offset<IReboundComponent> EndIReboundComponent(FlatBufferBuilder builder)
		{
			return new Offset<IReboundComponent>(builder.EndTable());
		}

		// Token: 0x06028378 RID: 164728 RVA: 0x0057FFE4 File Offset: 0x0057E1E4
		public IReboundComponentT UnPack()
		{
			IReboundComponentT reboundComponentT = new IReboundComponentT();
			this.UnPackTo(reboundComponentT);
			return reboundComponentT;
		}

		// Token: 0x06028379 RID: 164729 RVA: 0x00580000 File Offset: 0x0057E200
		public void UnPackTo(IReboundComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.BulletId = this.BulletId;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602837A RID: 164730 RVA: 0x00580060 File Offset: 0x0057E260
		public static Offset<IReboundComponent> Pack(FlatBufferBuilder builder, IReboundComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReboundComponent>);
			}
			Offset<IForwardFrontRebound> optionOffset = (_o.Option == null) ? default(Offset<IForwardFrontRebound>) : IForwardFrontRebound.Pack(builder, _o.Option);
			return IReboundComponent.CreateIReboundComponent(builder, _o.Disabled, _o.BulletId, optionOffset, _o.NullMask);
		}

		// Token: 0x0400F9F4 RID: 63988
		private Table __p;
	}
}

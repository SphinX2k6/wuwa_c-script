using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DC RID: 22748
	public struct IGroupFinishSilence : IFlatbufferObject
	{
		// Token: 0x1700A4F4 RID: 42228
		// (get) Token: 0x06024F10 RID: 151312 RVA: 0x005125EC File Offset: 0x005107EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024F11 RID: 151313 RVA: 0x005125F9 File Offset: 0x005107F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024F12 RID: 151314 RVA: 0x00512600 File Offset: 0x00510800
		public static IGroupFinishSilence GetRootAsIGroupFinishSilence(ByteBuffer _bb)
		{
			return IGroupFinishSilence.GetRootAsIGroupFinishSilence(_bb, default(IGroupFinishSilence));
		}

		// Token: 0x06024F13 RID: 151315 RVA: 0x0051261C File Offset: 0x0051081C
		public static IGroupFinishSilence GetRootAsIGroupFinishSilence(ByteBuffer _bb, IGroupFinishSilence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024F14 RID: 151316 RVA: 0x00512639 File Offset: 0x00510839
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024F15 RID: 151317 RVA: 0x00512648 File Offset: 0x00510848
		public IGroupFinishSilence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4F5 RID: 42229
		// (get) Token: 0x06024F16 RID: 151318 RVA: 0x00512658 File Offset: 0x00510858
		public EGroupFinishConfig Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupFinishConfig.Silence;
				}
				return (EGroupFinishConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A4F6 RID: 42230
		// (get) Token: 0x06024F17 RID: 151319 RVA: 0x00512694 File Offset: 0x00510894
		public IEntityState? SwitchSpecifiedStatus
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024F18 RID: 151320 RVA: 0x005126F1 File Offset: 0x005108F1
		public static Offset<IGroupFinishSilence> CreateIGroupFinishSilence(FlatBufferBuilder builder, EGroupFinishConfig Type = EGroupFinishConfig.Silence, Offset<IEntityState> SwitchSpecifiedStatusOffset = default(Offset<IEntityState>))
		{
			builder.StartTable(2);
			IGroupFinishSilence.AddSwitchSpecifiedStatus(builder, SwitchSpecifiedStatusOffset);
			IGroupFinishSilence.AddType(builder, Type);
			return IGroupFinishSilence.EndIGroupFinishSilence(builder);
		}

		// Token: 0x06024F19 RID: 151321 RVA: 0x0051270E File Offset: 0x0051090E
		public static void StartIGroupFinishSilence(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024F1A RID: 151322 RVA: 0x00512717 File Offset: 0x00510917
		public static void AddType(FlatBufferBuilder builder, EGroupFinishConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024F1B RID: 151323 RVA: 0x00512722 File Offset: 0x00510922
		public static void AddSwitchSpecifiedStatus(FlatBufferBuilder builder, Offset<IEntityState> switchSpecifiedStatusOffset)
		{
			builder.AddOffset(1, switchSpecifiedStatusOffset.Value, 0);
		}

		// Token: 0x06024F1C RID: 151324 RVA: 0x00512732 File Offset: 0x00510932
		public static Offset<IGroupFinishSilence> EndIGroupFinishSilence(FlatBufferBuilder builder)
		{
			return new Offset<IGroupFinishSilence>(builder.EndTable());
		}

		// Token: 0x06024F1D RID: 151325 RVA: 0x00512740 File Offset: 0x00510940
		public IGroupFinishSilenceT UnPack()
		{
			IGroupFinishSilenceT groupFinishSilenceT = new IGroupFinishSilenceT();
			this.UnPackTo(groupFinishSilenceT);
			return groupFinishSilenceT;
		}

		// Token: 0x06024F1E RID: 151326 RVA: 0x0051275C File Offset: 0x0051095C
		public void UnPackTo(IGroupFinishSilenceT _o)
		{
			_o.Type = this.Type;
			_o.SwitchSpecifiedStatus = ((this.SwitchSpecifiedStatus != null) ? this.SwitchSpecifiedStatus.Value.UnPack() : null);
		}

		// Token: 0x06024F1F RID: 151327 RVA: 0x005127A4 File Offset: 0x005109A4
		public static Offset<IGroupFinishSilence> Pack(FlatBufferBuilder builder, IGroupFinishSilenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupFinishSilence>);
			}
			Offset<IEntityState> switchSpecifiedStatusOffset = (_o.SwitchSpecifiedStatus == null) ? default(Offset<IEntityState>) : IEntityState.Pack(builder, _o.SwitchSpecifiedStatus);
			return IGroupFinishSilence.CreateIGroupFinishSilence(builder, _o.Type, switchSpecifiedStatusOffset);
		}

		// Token: 0x0400F15D RID: 61789
		private Table __p;
	}
}

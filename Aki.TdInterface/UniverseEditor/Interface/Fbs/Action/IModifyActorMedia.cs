using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB8 RID: 27320
	public struct IModifyActorMedia : IFlatbufferObject
	{
		// Token: 0x1700CAB8 RID: 51896
		// (get) Token: 0x0602FE06 RID: 196102 RVA: 0x006833B2 File Offset: 0x006815B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FE07 RID: 196103 RVA: 0x006833BF File Offset: 0x006815BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FE08 RID: 196104 RVA: 0x006833C8 File Offset: 0x006815C8
		public static IModifyActorMedia GetRootAsIModifyActorMedia(ByteBuffer _bb)
		{
			return IModifyActorMedia.GetRootAsIModifyActorMedia(_bb, default(IModifyActorMedia));
		}

		// Token: 0x0602FE09 RID: 196105 RVA: 0x006833E4 File Offset: 0x006815E4
		public static IModifyActorMedia GetRootAsIModifyActorMedia(ByteBuffer _bb, IModifyActorMedia obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FE0A RID: 196106 RVA: 0x00683401 File Offset: 0x00681601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FE0B RID: 196107 RVA: 0x00683410 File Offset: 0x00681610
		public IModifyActorMedia __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAB9 RID: 51897
		// (get) Token: 0x0602FE0C RID: 196108 RVA: 0x00683420 File Offset: 0x00681620
		public IChangeMediaPlayDa? Config
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IChangeMediaPlayDa?(default(IChangeMediaPlayDa).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602FE0D RID: 196109 RVA: 0x0068347D File Offset: 0x0068167D
		public static Offset<IModifyActorMedia> CreateIModifyActorMedia(FlatBufferBuilder builder, Offset<IChangeMediaPlayDa> ConfigOffset = default(Offset<IChangeMediaPlayDa>))
		{
			builder.StartTable(1);
			IModifyActorMedia.AddConfig(builder, ConfigOffset);
			return IModifyActorMedia.EndIModifyActorMedia(builder);
		}

		// Token: 0x0602FE0E RID: 196110 RVA: 0x00683493 File Offset: 0x00681693
		public static void StartIModifyActorMedia(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FE0F RID: 196111 RVA: 0x0068349C File Offset: 0x0068169C
		public static void AddConfig(FlatBufferBuilder builder, Offset<IChangeMediaPlayDa> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x0602FE10 RID: 196112 RVA: 0x006834AC File Offset: 0x006816AC
		public static Offset<IModifyActorMedia> EndIModifyActorMedia(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMedia>(builder.EndTable());
		}

		// Token: 0x0602FE11 RID: 196113 RVA: 0x006834BC File Offset: 0x006816BC
		public IModifyActorMediaT UnPack()
		{
			IModifyActorMediaT modifyActorMediaT = new IModifyActorMediaT();
			this.UnPackTo(modifyActorMediaT);
			return modifyActorMediaT;
		}

		// Token: 0x0602FE12 RID: 196114 RVA: 0x006834D8 File Offset: 0x006816D8
		public void UnPackTo(IModifyActorMediaT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x0602FE13 RID: 196115 RVA: 0x00683514 File Offset: 0x00681714
		public static Offset<IModifyActorMedia> Pack(FlatBufferBuilder builder, IModifyActorMediaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMedia>);
			}
			Offset<IChangeMediaPlayDa> configOffset = (_o.Config == null) ? default(Offset<IChangeMediaPlayDa>) : IChangeMediaPlayDa.Pack(builder, _o.Config);
			return IModifyActorMedia.CreateIModifyActorMedia(builder, configOffset);
		}

		// Token: 0x040112F8 RID: 70392
		private Table __p;
	}
}

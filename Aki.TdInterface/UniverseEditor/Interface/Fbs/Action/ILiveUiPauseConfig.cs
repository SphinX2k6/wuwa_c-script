using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007145 RID: 28997
	public struct ILiveUiPauseConfig : IFlatbufferObject
	{
		// Token: 0x1700D440 RID: 54336
		// (get) Token: 0x060325FE RID: 206334 RVA: 0x006CF68D File Offset: 0x006CD88D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060325FF RID: 206335 RVA: 0x006CF69A File Offset: 0x006CD89A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032600 RID: 206336 RVA: 0x006CF6A4 File Offset: 0x006CD8A4
		public static ILiveUiPauseConfig GetRootAsILiveUiPauseConfig(ByteBuffer _bb)
		{
			return ILiveUiPauseConfig.GetRootAsILiveUiPauseConfig(_bb, default(ILiveUiPauseConfig));
		}

		// Token: 0x06032601 RID: 206337 RVA: 0x006CF6C0 File Offset: 0x006CD8C0
		public static ILiveUiPauseConfig GetRootAsILiveUiPauseConfig(ByteBuffer _bb, ILiveUiPauseConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032602 RID: 206338 RVA: 0x006CF6DD File Offset: 0x006CD8DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032603 RID: 206339 RVA: 0x006CF6EC File Offset: 0x006CD8EC
		public ILiveUiPauseConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D441 RID: 54337
		// (get) Token: 0x06032604 RID: 206340 RVA: 0x006CF6FC File Offset: 0x006CD8FC
		public ELiveUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveUiType.Start;
				}
				return (ELiveUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032605 RID: 206341 RVA: 0x006CF738 File Offset: 0x006CD938
		public static Offset<ILiveUiPauseConfig> CreateILiveUiPauseConfig(FlatBufferBuilder builder, ELiveUiType Type = ELiveUiType.Start)
		{
			builder.StartTable(1);
			ILiveUiPauseConfig.AddType(builder, Type);
			return ILiveUiPauseConfig.EndILiveUiPauseConfig(builder);
		}

		// Token: 0x06032606 RID: 206342 RVA: 0x006CF74E File Offset: 0x006CD94E
		public static void StartILiveUiPauseConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032607 RID: 206343 RVA: 0x006CF757 File Offset: 0x006CD957
		public static void AddType(FlatBufferBuilder builder, ELiveUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032608 RID: 206344 RVA: 0x006CF762 File Offset: 0x006CD962
		public static Offset<ILiveUiPauseConfig> EndILiveUiPauseConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveUiPauseConfig>(builder.EndTable());
		}

		// Token: 0x06032609 RID: 206345 RVA: 0x006CF770 File Offset: 0x006CD970
		public ILiveUiPauseConfigT UnPack()
		{
			ILiveUiPauseConfigT liveUiPauseConfigT = new ILiveUiPauseConfigT();
			this.UnPackTo(liveUiPauseConfigT);
			return liveUiPauseConfigT;
		}

		// Token: 0x0603260A RID: 206346 RVA: 0x006CF78B File Offset: 0x006CD98B
		public void UnPackTo(ILiveUiPauseConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603260B RID: 206347 RVA: 0x006CF79C File Offset: 0x006CD99C
		public static Offset<ILiveUiPauseConfig> Pack(FlatBufferBuilder builder, ILiveUiPauseConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveUiPauseConfig>);
			}
			return ILiveUiPauseConfig.CreateILiveUiPauseConfig(builder, _o.Type);
		}

		// Token: 0x0401212F RID: 74031
		private Table __p;
	}
}

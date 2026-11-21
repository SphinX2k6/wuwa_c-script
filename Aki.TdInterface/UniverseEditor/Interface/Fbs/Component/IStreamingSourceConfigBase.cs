using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FE4 RID: 24548
	public struct IStreamingSourceConfigBase : IFlatbufferObject
	{
		// Token: 0x1700B606 RID: 46598
		// (get) Token: 0x060295BE RID: 169406 RVA: 0x005A5728 File Offset: 0x005A3928
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060295BF RID: 169407 RVA: 0x005A5735 File Offset: 0x005A3935
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060295C0 RID: 169408 RVA: 0x005A573C File Offset: 0x005A393C
		public static IStreamingSourceConfigBase GetRootAsIStreamingSourceConfigBase(ByteBuffer _bb)
		{
			return IStreamingSourceConfigBase.GetRootAsIStreamingSourceConfigBase(_bb, default(IStreamingSourceConfigBase));
		}

		// Token: 0x060295C1 RID: 169409 RVA: 0x005A5758 File Offset: 0x005A3958
		public static IStreamingSourceConfigBase GetRootAsIStreamingSourceConfigBase(ByteBuffer _bb, IStreamingSourceConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060295C2 RID: 169410 RVA: 0x005A5775 File Offset: 0x005A3975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060295C3 RID: 169411 RVA: 0x005A5784 File Offset: 0x005A3984
		public IStreamingSourceConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B607 RID: 46599
		// (get) Token: 0x060295C4 RID: 169412 RVA: 0x005A5794 File Offset: 0x005A3994
		public EStreamingSourceMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStreamingSourceMode.Fixed;
				}
				return (EStreamingSourceMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060295C5 RID: 169413 RVA: 0x005A57D0 File Offset: 0x005A39D0
		public static Offset<IStreamingSourceConfigBase> CreateIStreamingSourceConfigBase(FlatBufferBuilder builder, EStreamingSourceMode Type = EStreamingSourceMode.Fixed)
		{
			builder.StartTable(1);
			IStreamingSourceConfigBase.AddType(builder, Type);
			return IStreamingSourceConfigBase.EndIStreamingSourceConfigBase(builder);
		}

		// Token: 0x060295C6 RID: 169414 RVA: 0x005A57E6 File Offset: 0x005A39E6
		public static void StartIStreamingSourceConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060295C7 RID: 169415 RVA: 0x005A57EF File Offset: 0x005A39EF
		public static void AddType(FlatBufferBuilder builder, EStreamingSourceMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060295C8 RID: 169416 RVA: 0x005A57FA File Offset: 0x005A39FA
		public static Offset<IStreamingSourceConfigBase> EndIStreamingSourceConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingSourceConfigBase>(builder.EndTable());
		}

		// Token: 0x060295C9 RID: 169417 RVA: 0x005A5808 File Offset: 0x005A3A08
		public IStreamingSourceConfigBaseT UnPack()
		{
			IStreamingSourceConfigBaseT streamingSourceConfigBaseT = new IStreamingSourceConfigBaseT();
			this.UnPackTo(streamingSourceConfigBaseT);
			return streamingSourceConfigBaseT;
		}

		// Token: 0x060295CA RID: 169418 RVA: 0x005A5823 File Offset: 0x005A3A23
		public void UnPackTo(IStreamingSourceConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060295CB RID: 169419 RVA: 0x005A5834 File Offset: 0x005A3A34
		public static Offset<IStreamingSourceConfigBase> Pack(FlatBufferBuilder builder, IStreamingSourceConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingSourceConfigBase>);
			}
			return IStreamingSourceConfigBase.CreateIStreamingSourceConfigBase(builder, _o.Type);
		}

		// Token: 0x0400FD02 RID: 64770
		private Table __p;
	}
}

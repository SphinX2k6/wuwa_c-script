using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D7 RID: 22999
	public struct IStreamingSourceConfigBase : IFlatbufferObject
	{
		// Token: 0x1700ACCE RID: 44238
		// (get) Token: 0x06027046 RID: 159814 RVA: 0x0055E764 File Offset: 0x0055C964
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027047 RID: 159815 RVA: 0x0055E771 File Offset: 0x0055C971
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027048 RID: 159816 RVA: 0x0055E778 File Offset: 0x0055C978
		public static IStreamingSourceConfigBase GetRootAsIStreamingSourceConfigBase(ByteBuffer _bb)
		{
			return IStreamingSourceConfigBase.GetRootAsIStreamingSourceConfigBase(_bb, default(IStreamingSourceConfigBase));
		}

		// Token: 0x06027049 RID: 159817 RVA: 0x0055E794 File Offset: 0x0055C994
		public static IStreamingSourceConfigBase GetRootAsIStreamingSourceConfigBase(ByteBuffer _bb, IStreamingSourceConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602704A RID: 159818 RVA: 0x0055E7B1 File Offset: 0x0055C9B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602704B RID: 159819 RVA: 0x0055E7C0 File Offset: 0x0055C9C0
		public IStreamingSourceConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACCF RID: 44239
		// (get) Token: 0x0602704C RID: 159820 RVA: 0x0055E7D0 File Offset: 0x0055C9D0
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

		// Token: 0x0602704D RID: 159821 RVA: 0x0055E80C File Offset: 0x0055CA0C
		public static Offset<IStreamingSourceConfigBase> CreateIStreamingSourceConfigBase(FlatBufferBuilder builder, EStreamingSourceMode Type = EStreamingSourceMode.Fixed)
		{
			builder.StartTable(1);
			IStreamingSourceConfigBase.AddType(builder, Type);
			return IStreamingSourceConfigBase.EndIStreamingSourceConfigBase(builder);
		}

		// Token: 0x0602704E RID: 159822 RVA: 0x0055E822 File Offset: 0x0055CA22
		public static void StartIStreamingSourceConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602704F RID: 159823 RVA: 0x0055E82B File Offset: 0x0055CA2B
		public static void AddType(FlatBufferBuilder builder, EStreamingSourceMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027050 RID: 159824 RVA: 0x0055E836 File Offset: 0x0055CA36
		public static Offset<IStreamingSourceConfigBase> EndIStreamingSourceConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingSourceConfigBase>(builder.EndTable());
		}

		// Token: 0x06027051 RID: 159825 RVA: 0x0055E844 File Offset: 0x0055CA44
		public IStreamingSourceConfigBaseT UnPack()
		{
			IStreamingSourceConfigBaseT streamingSourceConfigBaseT = new IStreamingSourceConfigBaseT();
			this.UnPackTo(streamingSourceConfigBaseT);
			return streamingSourceConfigBaseT;
		}

		// Token: 0x06027052 RID: 159826 RVA: 0x0055E85F File Offset: 0x0055CA5F
		public void UnPackTo(IStreamingSourceConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027053 RID: 159827 RVA: 0x0055E870 File Offset: 0x0055CA70
		public static Offset<IStreamingSourceConfigBase> Pack(FlatBufferBuilder builder, IStreamingSourceConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingSourceConfigBase>);
			}
			return IStreamingSourceConfigBase.CreateIStreamingSourceConfigBase(builder, _o.Type);
		}

		// Token: 0x0400F00B RID: 61451
		private Table __p;
	}
}

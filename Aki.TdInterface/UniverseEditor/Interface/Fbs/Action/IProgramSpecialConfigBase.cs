using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB0 RID: 28080
	public struct IProgramSpecialConfigBase : IFlatbufferObject
	{
		// Token: 0x1700D164 RID: 53604
		// (get) Token: 0x06031997 RID: 203159 RVA: 0x006B89A2 File Offset: 0x006B6BA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031998 RID: 203160 RVA: 0x006B89AF File Offset: 0x006B6BAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031999 RID: 203161 RVA: 0x006B89B8 File Offset: 0x006B6BB8
		public static IProgramSpecialConfigBase GetRootAsIProgramSpecialConfigBase(ByteBuffer _bb)
		{
			return IProgramSpecialConfigBase.GetRootAsIProgramSpecialConfigBase(_bb, default(IProgramSpecialConfigBase));
		}

		// Token: 0x0603199A RID: 203162 RVA: 0x006B89D4 File Offset: 0x006B6BD4
		public static IProgramSpecialConfigBase GetRootAsIProgramSpecialConfigBase(ByteBuffer _bb, IProgramSpecialConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603199B RID: 203163 RVA: 0x006B89F1 File Offset: 0x006B6BF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603199C RID: 203164 RVA: 0x006B8A00 File Offset: 0x006B6C00
		public IProgramSpecialConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D165 RID: 53605
		// (get) Token: 0x0603199D RID: 203165 RVA: 0x006B8A10 File Offset: 0x006B6C10
		public EPlayMovieProgramSpecialConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
				}
				return (EPlayMovieProgramSpecialConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603199E RID: 203166 RVA: 0x006B8A4C File Offset: 0x006B6C4C
		public static Offset<IProgramSpecialConfigBase> CreateIProgramSpecialConfigBase(FlatBufferBuilder builder, EPlayMovieProgramSpecialConfigType Type = EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial)
		{
			builder.StartTable(1);
			IProgramSpecialConfigBase.AddType(builder, Type);
			return IProgramSpecialConfigBase.EndIProgramSpecialConfigBase(builder);
		}

		// Token: 0x0603199F RID: 203167 RVA: 0x006B8A62 File Offset: 0x006B6C62
		public static void StartIProgramSpecialConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060319A0 RID: 203168 RVA: 0x006B8A6B File Offset: 0x006B6C6B
		public static void AddType(FlatBufferBuilder builder, EPlayMovieProgramSpecialConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060319A1 RID: 203169 RVA: 0x006B8A76 File Offset: 0x006B6C76
		public static Offset<IProgramSpecialConfigBase> EndIProgramSpecialConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IProgramSpecialConfigBase>(builder.EndTable());
		}

		// Token: 0x060319A2 RID: 203170 RVA: 0x006B8A84 File Offset: 0x006B6C84
		public IProgramSpecialConfigBaseT UnPack()
		{
			IProgramSpecialConfigBaseT programSpecialConfigBaseT = new IProgramSpecialConfigBaseT();
			this.UnPackTo(programSpecialConfigBaseT);
			return programSpecialConfigBaseT;
		}

		// Token: 0x060319A3 RID: 203171 RVA: 0x006B8A9F File Offset: 0x006B6C9F
		public void UnPackTo(IProgramSpecialConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060319A4 RID: 203172 RVA: 0x006B8AB0 File Offset: 0x006B6CB0
		public static Offset<IProgramSpecialConfigBase> Pack(FlatBufferBuilder builder, IProgramSpecialConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProgramSpecialConfigBase>);
			}
			return IProgramSpecialConfigBase.CreateIProgramSpecialConfigBase(builder, _o.Type);
		}

		// Token: 0x04011787 RID: 71559
		private Table __p;
	}
}

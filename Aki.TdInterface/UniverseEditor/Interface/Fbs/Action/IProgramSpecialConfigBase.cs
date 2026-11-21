using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200752B RID: 29995
	public struct IProgramSpecialConfigBase : IFlatbufferObject
	{
		// Token: 0x1700DCAC RID: 56492
		// (get) Token: 0x06034993 RID: 215443 RVA: 0x0071408A File Offset: 0x0071228A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034994 RID: 215444 RVA: 0x00714097 File Offset: 0x00712297
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034995 RID: 215445 RVA: 0x007140A0 File Offset: 0x007122A0
		public static IProgramSpecialConfigBase GetRootAsIProgramSpecialConfigBase(ByteBuffer _bb)
		{
			return IProgramSpecialConfigBase.GetRootAsIProgramSpecialConfigBase(_bb, default(IProgramSpecialConfigBase));
		}

		// Token: 0x06034996 RID: 215446 RVA: 0x007140BC File Offset: 0x007122BC
		public static IProgramSpecialConfigBase GetRootAsIProgramSpecialConfigBase(ByteBuffer _bb, IProgramSpecialConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034997 RID: 215447 RVA: 0x007140D9 File Offset: 0x007122D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034998 RID: 215448 RVA: 0x007140E8 File Offset: 0x007122E8
		public IProgramSpecialConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCAD RID: 56493
		// (get) Token: 0x06034999 RID: 215449 RVA: 0x007140F8 File Offset: 0x007122F8
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

		// Token: 0x0603499A RID: 215450 RVA: 0x00714134 File Offset: 0x00712334
		public static Offset<IProgramSpecialConfigBase> CreateIProgramSpecialConfigBase(FlatBufferBuilder builder, EPlayMovieProgramSpecialConfigType Type = EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial)
		{
			builder.StartTable(1);
			IProgramSpecialConfigBase.AddType(builder, Type);
			return IProgramSpecialConfigBase.EndIProgramSpecialConfigBase(builder);
		}

		// Token: 0x0603499B RID: 215451 RVA: 0x0071414A File Offset: 0x0071234A
		public static void StartIProgramSpecialConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603499C RID: 215452 RVA: 0x00714153 File Offset: 0x00712353
		public static void AddType(FlatBufferBuilder builder, EPlayMovieProgramSpecialConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603499D RID: 215453 RVA: 0x0071415E File Offset: 0x0071235E
		public static Offset<IProgramSpecialConfigBase> EndIProgramSpecialConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IProgramSpecialConfigBase>(builder.EndTable());
		}

		// Token: 0x0603499E RID: 215454 RVA: 0x0071416C File Offset: 0x0071236C
		public IProgramSpecialConfigBaseT UnPack()
		{
			IProgramSpecialConfigBaseT programSpecialConfigBaseT = new IProgramSpecialConfigBaseT();
			this.UnPackTo(programSpecialConfigBaseT);
			return programSpecialConfigBaseT;
		}

		// Token: 0x0603499F RID: 215455 RVA: 0x00714187 File Offset: 0x00712387
		public void UnPackTo(IProgramSpecialConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060349A0 RID: 215456 RVA: 0x00714198 File Offset: 0x00712398
		public static Offset<IProgramSpecialConfigBase> Pack(FlatBufferBuilder builder, IProgramSpecialConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProgramSpecialConfigBase>);
			}
			return IProgramSpecialConfigBase.CreateIProgramSpecialConfigBase(builder, _o.Type);
		}

		// Token: 0x04012703 RID: 75523
		private Table __p;
	}
}

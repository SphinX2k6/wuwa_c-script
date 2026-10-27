using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200482F RID: 18479
	public struct IBuffDurationInstant : IFlatbufferObject
	{
		// Token: 0x1700849F RID: 33951
		// (get) Token: 0x0601C903 RID: 116995 RVA: 0x0040A0BA File Offset: 0x004082BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C904 RID: 116996 RVA: 0x0040A0C7 File Offset: 0x004082C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C905 RID: 116997 RVA: 0x0040A0D0 File Offset: 0x004082D0
		public static IBuffDurationInstant GetRootAsIBuffDurationInstant(ByteBuffer _bb)
		{
			return IBuffDurationInstant.GetRootAsIBuffDurationInstant(_bb, default(IBuffDurationInstant));
		}

		// Token: 0x0601C906 RID: 116998 RVA: 0x0040A0EC File Offset: 0x004082EC
		public static IBuffDurationInstant GetRootAsIBuffDurationInstant(ByteBuffer _bb, IBuffDurationInstant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C907 RID: 116999 RVA: 0x0040A109 File Offset: 0x00408309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C908 RID: 117000 RVA: 0x0040A118 File Offset: 0x00408318
		public IBuffDurationInstant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084A0 RID: 33952
		// (get) Token: 0x0601C909 RID: 117001 RVA: 0x0040A128 File Offset: 0x00408328
		public EBuffDurationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffDurationType.Instant;
				}
				return (EBuffDurationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C90A RID: 117002 RVA: 0x0040A164 File Offset: 0x00408364
		public static Offset<IBuffDurationInstant> CreateIBuffDurationInstant(FlatBufferBuilder builder, EBuffDurationType Type = EBuffDurationType.Instant)
		{
			builder.StartTable(1);
			IBuffDurationInstant.AddType(builder, Type);
			return IBuffDurationInstant.EndIBuffDurationInstant(builder);
		}

		// Token: 0x0601C90B RID: 117003 RVA: 0x0040A17A File Offset: 0x0040837A
		public static void StartIBuffDurationInstant(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C90C RID: 117004 RVA: 0x0040A183 File Offset: 0x00408383
		public static void AddType(FlatBufferBuilder builder, EBuffDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C90D RID: 117005 RVA: 0x0040A18E File Offset: 0x0040838E
		public static Offset<IBuffDurationInstant> EndIBuffDurationInstant(FlatBufferBuilder builder)
		{
			return new Offset<IBuffDurationInstant>(builder.EndTable());
		}

		// Token: 0x0601C90E RID: 117006 RVA: 0x0040A19C File Offset: 0x0040839C
		public IBuffDurationInstantT UnPack()
		{
			IBuffDurationInstantT buffDurationInstantT = new IBuffDurationInstantT();
			this.UnPackTo(buffDurationInstantT);
			return buffDurationInstantT;
		}

		// Token: 0x0601C90F RID: 117007 RVA: 0x0040A1B7 File Offset: 0x004083B7
		public void UnPackTo(IBuffDurationInstantT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C910 RID: 117008 RVA: 0x0040A1C8 File Offset: 0x004083C8
		public static Offset<IBuffDurationInstant> Pack(FlatBufferBuilder builder, IBuffDurationInstantT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffDurationInstant>);
			}
			return IBuffDurationInstant.CreateIBuffDurationInstant(builder, _o.Type);
		}

		// Token: 0x0400CD5C RID: 52572
		private Table __p;
	}
}

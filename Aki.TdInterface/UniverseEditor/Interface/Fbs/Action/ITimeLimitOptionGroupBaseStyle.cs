using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BC6 RID: 31686
	public struct ITimeLimitOptionGroupBaseStyle : IFlatbufferObject
	{
		// Token: 0x1700ED67 RID: 60775
		// (get) Token: 0x060391D2 RID: 233938 RVA: 0x007B7F87 File Offset: 0x007B6187
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060391D3 RID: 233939 RVA: 0x007B7F94 File Offset: 0x007B6194
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060391D4 RID: 233940 RVA: 0x007B7F9C File Offset: 0x007B619C
		public static ITimeLimitOptionGroupBaseStyle GetRootAsITimeLimitOptionGroupBaseStyle(ByteBuffer _bb)
		{
			return ITimeLimitOptionGroupBaseStyle.GetRootAsITimeLimitOptionGroupBaseStyle(_bb, default(ITimeLimitOptionGroupBaseStyle));
		}

		// Token: 0x060391D5 RID: 233941 RVA: 0x007B7FB8 File Offset: 0x007B61B8
		public static ITimeLimitOptionGroupBaseStyle GetRootAsITimeLimitOptionGroupBaseStyle(ByteBuffer _bb, ITimeLimitOptionGroupBaseStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060391D6 RID: 233942 RVA: 0x007B7FD5 File Offset: 0x007B61D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060391D7 RID: 233943 RVA: 0x007B7FE4 File Offset: 0x007B61E4
		public ITimeLimitOptionGroupBaseStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED68 RID: 60776
		// (get) Token: 0x060391D8 RID: 233944 RVA: 0x007B7FF4 File Offset: 0x007B61F4
		public ETimeLimitOptionGroupStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeLimitOptionGroupStyle.Default;
				}
				return (ETimeLimitOptionGroupStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060391D9 RID: 233945 RVA: 0x007B8030 File Offset: 0x007B6230
		public static Offset<ITimeLimitOptionGroupBaseStyle> CreateITimeLimitOptionGroupBaseStyle(FlatBufferBuilder builder, ETimeLimitOptionGroupStyle Type = ETimeLimitOptionGroupStyle.Default)
		{
			builder.StartTable(1);
			ITimeLimitOptionGroupBaseStyle.AddType(builder, Type);
			return ITimeLimitOptionGroupBaseStyle.EndITimeLimitOptionGroupBaseStyle(builder);
		}

		// Token: 0x060391DA RID: 233946 RVA: 0x007B8046 File Offset: 0x007B6246
		public static void StartITimeLimitOptionGroupBaseStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060391DB RID: 233947 RVA: 0x007B804F File Offset: 0x007B624F
		public static void AddType(FlatBufferBuilder builder, ETimeLimitOptionGroupStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060391DC RID: 233948 RVA: 0x007B805A File Offset: 0x007B625A
		public static Offset<ITimeLimitOptionGroupBaseStyle> EndITimeLimitOptionGroupBaseStyle(FlatBufferBuilder builder)
		{
			return new Offset<ITimeLimitOptionGroupBaseStyle>(builder.EndTable());
		}

		// Token: 0x060391DD RID: 233949 RVA: 0x007B8068 File Offset: 0x007B6268
		public ITimeLimitOptionGroupBaseStyleT UnPack()
		{
			ITimeLimitOptionGroupBaseStyleT timeLimitOptionGroupBaseStyleT = new ITimeLimitOptionGroupBaseStyleT();
			this.UnPackTo(timeLimitOptionGroupBaseStyleT);
			return timeLimitOptionGroupBaseStyleT;
		}

		// Token: 0x060391DE RID: 233950 RVA: 0x007B8083 File Offset: 0x007B6283
		public void UnPackTo(ITimeLimitOptionGroupBaseStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060391DF RID: 233951 RVA: 0x007B8094 File Offset: 0x007B6294
		public static Offset<ITimeLimitOptionGroupBaseStyle> Pack(FlatBufferBuilder builder, ITimeLimitOptionGroupBaseStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeLimitOptionGroupBaseStyle>);
			}
			return ITimeLimitOptionGroupBaseStyle.CreateITimeLimitOptionGroupBaseStyle(builder, _o.Type);
		}

		// Token: 0x0401324D RID: 78413
		private Table __p;
	}
}

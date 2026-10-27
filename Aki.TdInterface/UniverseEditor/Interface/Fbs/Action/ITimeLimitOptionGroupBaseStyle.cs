using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073DC RID: 29660
	public struct ITimeLimitOptionGroupBaseStyle : IFlatbufferObject
	{
		// Token: 0x1700E152 RID: 57682
		// (get) Token: 0x06035E1F RID: 220703 RVA: 0x00755813 File Offset: 0x00753A13
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E20 RID: 220704 RVA: 0x00755820 File Offset: 0x00753A20
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E21 RID: 220705 RVA: 0x00755828 File Offset: 0x00753A28
		public static ITimeLimitOptionGroupBaseStyle GetRootAsITimeLimitOptionGroupBaseStyle(ByteBuffer _bb)
		{
			return ITimeLimitOptionGroupBaseStyle.GetRootAsITimeLimitOptionGroupBaseStyle(_bb, default(ITimeLimitOptionGroupBaseStyle));
		}

		// Token: 0x06035E22 RID: 220706 RVA: 0x00755844 File Offset: 0x00753A44
		public static ITimeLimitOptionGroupBaseStyle GetRootAsITimeLimitOptionGroupBaseStyle(ByteBuffer _bb, ITimeLimitOptionGroupBaseStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E23 RID: 220707 RVA: 0x00755861 File Offset: 0x00753A61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E24 RID: 220708 RVA: 0x00755870 File Offset: 0x00753A70
		public ITimeLimitOptionGroupBaseStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E153 RID: 57683
		// (get) Token: 0x06035E25 RID: 220709 RVA: 0x00755880 File Offset: 0x00753A80
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

		// Token: 0x06035E26 RID: 220710 RVA: 0x007558BC File Offset: 0x00753ABC
		public static Offset<ITimeLimitOptionGroupBaseStyle> CreateITimeLimitOptionGroupBaseStyle(FlatBufferBuilder builder, ETimeLimitOptionGroupStyle Type = ETimeLimitOptionGroupStyle.Default)
		{
			builder.StartTable(1);
			ITimeLimitOptionGroupBaseStyle.AddType(builder, Type);
			return ITimeLimitOptionGroupBaseStyle.EndITimeLimitOptionGroupBaseStyle(builder);
		}

		// Token: 0x06035E27 RID: 220711 RVA: 0x007558D2 File Offset: 0x00753AD2
		public static void StartITimeLimitOptionGroupBaseStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035E28 RID: 220712 RVA: 0x007558DB File Offset: 0x00753ADB
		public static void AddType(FlatBufferBuilder builder, ETimeLimitOptionGroupStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035E29 RID: 220713 RVA: 0x007558E6 File Offset: 0x00753AE6
		public static Offset<ITimeLimitOptionGroupBaseStyle> EndITimeLimitOptionGroupBaseStyle(FlatBufferBuilder builder)
		{
			return new Offset<ITimeLimitOptionGroupBaseStyle>(builder.EndTable());
		}

		// Token: 0x06035E2A RID: 220714 RVA: 0x007558F4 File Offset: 0x00753AF4
		public ITimeLimitOptionGroupBaseStyleT UnPack()
		{
			ITimeLimitOptionGroupBaseStyleT timeLimitOptionGroupBaseStyleT = new ITimeLimitOptionGroupBaseStyleT();
			this.UnPackTo(timeLimitOptionGroupBaseStyleT);
			return timeLimitOptionGroupBaseStyleT;
		}

		// Token: 0x06035E2B RID: 220715 RVA: 0x0075590F File Offset: 0x00753B0F
		public void UnPackTo(ITimeLimitOptionGroupBaseStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035E2C RID: 220716 RVA: 0x00755920 File Offset: 0x00753B20
		public static Offset<ITimeLimitOptionGroupBaseStyle> Pack(FlatBufferBuilder builder, ITimeLimitOptionGroupBaseStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeLimitOptionGroupBaseStyle>);
			}
			return ITimeLimitOptionGroupBaseStyle.CreateITimeLimitOptionGroupBaseStyle(builder, _o.Type);
		}

		// Token: 0x04012231 RID: 74289
		private Table __p;
	}
}

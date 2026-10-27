using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200414E RID: 16718
	public struct ISunSpiritProcess : IFlatbufferObject
	{
		// Token: 0x1700767D RID: 30333
		// (get) Token: 0x060188CC RID: 100556 RVA: 0x00389F71 File Offset: 0x00388171
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060188CD RID: 100557 RVA: 0x00389F7E File Offset: 0x0038817E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060188CE RID: 100558 RVA: 0x00389F88 File Offset: 0x00388188
		public static ISunSpiritProcess GetRootAsISunSpiritProcess(ByteBuffer _bb)
		{
			return ISunSpiritProcess.GetRootAsISunSpiritProcess(_bb, default(ISunSpiritProcess));
		}

		// Token: 0x060188CF RID: 100559 RVA: 0x00389FA4 File Offset: 0x003881A4
		public static ISunSpiritProcess GetRootAsISunSpiritProcess(ByteBuffer _bb, ISunSpiritProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060188D0 RID: 100560 RVA: 0x00389FC1 File Offset: 0x003881C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060188D1 RID: 100561 RVA: 0x00389FD0 File Offset: 0x003881D0
		public ISunSpiritProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700767E RID: 30334
		// (get) Token: 0x060188D2 RID: 100562 RVA: 0x00389FE0 File Offset: 0x003881E0
		public int LauncherId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700767F RID: 30335
		// (get) Token: 0x060188D3 RID: 100563 RVA: 0x0038A01C File Offset: 0x0038821C
		public bool IsRecycle
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007680 RID: 30336
		// (get) Token: 0x060188D4 RID: 100564 RVA: 0x0038A05C File Offset: 0x0038825C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060188D5 RID: 100565 RVA: 0x0038A098 File Offset: 0x00388298
		public static Offset<ISunSpiritProcess> CreateISunSpiritProcess(FlatBufferBuilder builder, int LauncherId = 0, bool IsRecycle = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISunSpiritProcess.AddLauncherId(builder, LauncherId);
			ISunSpiritProcess.AddNullMask(builder, NullMask);
			ISunSpiritProcess.AddIsRecycle(builder, IsRecycle);
			return ISunSpiritProcess.EndISunSpiritProcess(builder);
		}

		// Token: 0x060188D6 RID: 100566 RVA: 0x0038A0BC File Offset: 0x003882BC
		public static void StartISunSpiritProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060188D7 RID: 100567 RVA: 0x0038A0C5 File Offset: 0x003882C5
		public static void AddLauncherId(FlatBufferBuilder builder, int launcherId)
		{
			builder.AddInt(0, launcherId, 0);
		}

		// Token: 0x060188D8 RID: 100568 RVA: 0x0038A0D0 File Offset: 0x003882D0
		public static void AddIsRecycle(FlatBufferBuilder builder, bool isRecycle)
		{
			builder.AddBool(1, isRecycle, false);
		}

		// Token: 0x060188D9 RID: 100569 RVA: 0x0038A0DB File Offset: 0x003882DB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060188DA RID: 100570 RVA: 0x0038A0E6 File Offset: 0x003882E6
		public static Offset<ISunSpiritProcess> EndISunSpiritProcess(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritProcess>(builder.EndTable());
		}

		// Token: 0x060188DB RID: 100571 RVA: 0x0038A0F4 File Offset: 0x003882F4
		public ISunSpiritProcessT UnPack()
		{
			ISunSpiritProcessT sunSpiritProcessT = new ISunSpiritProcessT();
			this.UnPackTo(sunSpiritProcessT);
			return sunSpiritProcessT;
		}

		// Token: 0x060188DC RID: 100572 RVA: 0x0038A10F File Offset: 0x0038830F
		public void UnPackTo(ISunSpiritProcessT _o)
		{
			_o.LauncherId = this.LauncherId;
			_o.IsRecycle = this.IsRecycle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060188DD RID: 100573 RVA: 0x0038A138 File Offset: 0x00388338
		public static Offset<ISunSpiritProcess> Pack(FlatBufferBuilder builder, ISunSpiritProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritProcess>);
			}
			return ISunSpiritProcess.CreateISunSpiritProcess(builder, _o.LauncherId, _o.IsRecycle, _o.NullMask);
		}

		// Token: 0x0400BD67 RID: 48487
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200507B RID: 20603
	public struct IDefaultAttachTiming : IFlatbufferObject
	{
		// Token: 0x17009578 RID: 38264
		// (get) Token: 0x06021071 RID: 135281 RVA: 0x00496811 File Offset: 0x00494A11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021072 RID: 135282 RVA: 0x0049681E File Offset: 0x00494A1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021073 RID: 135283 RVA: 0x00496828 File Offset: 0x00494A28
		public static IDefaultAttachTiming GetRootAsIDefaultAttachTiming(ByteBuffer _bb)
		{
			return IDefaultAttachTiming.GetRootAsIDefaultAttachTiming(_bb, default(IDefaultAttachTiming));
		}

		// Token: 0x06021074 RID: 135284 RVA: 0x00496844 File Offset: 0x00494A44
		public static IDefaultAttachTiming GetRootAsIDefaultAttachTiming(ByteBuffer _bb, IDefaultAttachTiming obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021075 RID: 135285 RVA: 0x00496861 File Offset: 0x00494A61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021076 RID: 135286 RVA: 0x00496870 File Offset: 0x00494A70
		public IDefaultAttachTiming __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009579 RID: 38265
		// (get) Token: 0x06021077 RID: 135287 RVA: 0x00496880 File Offset: 0x00494A80
		public EAttachTimingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachTimingType.Default;
				}
				return (EAttachTimingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021078 RID: 135288 RVA: 0x004968BC File Offset: 0x00494ABC
		public static Offset<IDefaultAttachTiming> CreateIDefaultAttachTiming(FlatBufferBuilder builder, EAttachTimingType Type = EAttachTimingType.Default)
		{
			builder.StartTable(1);
			IDefaultAttachTiming.AddType(builder, Type);
			return IDefaultAttachTiming.EndIDefaultAttachTiming(builder);
		}

		// Token: 0x06021079 RID: 135289 RVA: 0x004968D2 File Offset: 0x00494AD2
		public static void StartIDefaultAttachTiming(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602107A RID: 135290 RVA: 0x004968DB File Offset: 0x00494ADB
		public static void AddType(FlatBufferBuilder builder, EAttachTimingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602107B RID: 135291 RVA: 0x004968E6 File Offset: 0x00494AE6
		public static Offset<IDefaultAttachTiming> EndIDefaultAttachTiming(FlatBufferBuilder builder)
		{
			return new Offset<IDefaultAttachTiming>(builder.EndTable());
		}

		// Token: 0x0602107C RID: 135292 RVA: 0x004968F4 File Offset: 0x00494AF4
		public IDefaultAttachTimingT UnPack()
		{
			IDefaultAttachTimingT defaultAttachTimingT = new IDefaultAttachTimingT();
			this.UnPackTo(defaultAttachTimingT);
			return defaultAttachTimingT;
		}

		// Token: 0x0602107D RID: 135293 RVA: 0x0049690F File Offset: 0x00494B0F
		public void UnPackTo(IDefaultAttachTimingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602107E RID: 135294 RVA: 0x00496920 File Offset: 0x00494B20
		public static Offset<IDefaultAttachTiming> Pack(FlatBufferBuilder builder, IDefaultAttachTimingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDefaultAttachTiming>);
			}
			return IDefaultAttachTiming.CreateIDefaultAttachTiming(builder, _o.Type);
		}

		// Token: 0x0400E07E RID: 57470
		private Table __p;
	}
}

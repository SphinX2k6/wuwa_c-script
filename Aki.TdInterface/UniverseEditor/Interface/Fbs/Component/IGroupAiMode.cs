using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058BB RID: 22715
	public struct IGroupAiMode : IFlatbufferObject
	{
		// Token: 0x1700A4B5 RID: 42165
		// (get) Token: 0x06024E02 RID: 151042 RVA: 0x00510726 File Offset: 0x0050E926
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024E03 RID: 151043 RVA: 0x00510733 File Offset: 0x0050E933
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024E04 RID: 151044 RVA: 0x0051073C File Offset: 0x0050E93C
		public static IGroupAiMode GetRootAsIGroupAiMode(ByteBuffer _bb)
		{
			return IGroupAiMode.GetRootAsIGroupAiMode(_bb, default(IGroupAiMode));
		}

		// Token: 0x06024E05 RID: 151045 RVA: 0x00510758 File Offset: 0x0050E958
		public static IGroupAiMode GetRootAsIGroupAiMode(ByteBuffer _bb, IGroupAiMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024E06 RID: 151046 RVA: 0x00510775 File Offset: 0x0050E975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024E07 RID: 151047 RVA: 0x00510784 File Offset: 0x0050E984
		public IGroupAiMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4B6 RID: 42166
		// (get) Token: 0x06024E08 RID: 151048 RVA: 0x00510794 File Offset: 0x0050E994
		public EGroupAiMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupAiMode.Default;
				}
				return (EGroupAiMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024E09 RID: 151049 RVA: 0x005107D0 File Offset: 0x0050E9D0
		public static Offset<IGroupAiMode> CreateIGroupAiMode(FlatBufferBuilder builder, EGroupAiMode Type = EGroupAiMode.Default)
		{
			builder.StartTable(1);
			IGroupAiMode.AddType(builder, Type);
			return IGroupAiMode.EndIGroupAiMode(builder);
		}

		// Token: 0x06024E0A RID: 151050 RVA: 0x005107E6 File Offset: 0x0050E9E6
		public static void StartIGroupAiMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024E0B RID: 151051 RVA: 0x005107EF File Offset: 0x0050E9EF
		public static void AddType(FlatBufferBuilder builder, EGroupAiMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024E0C RID: 151052 RVA: 0x005107FA File Offset: 0x0050E9FA
		public static Offset<IGroupAiMode> EndIGroupAiMode(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiMode>(builder.EndTable());
		}

		// Token: 0x06024E0D RID: 151053 RVA: 0x00510808 File Offset: 0x0050EA08
		public IGroupAiModeT UnPack()
		{
			IGroupAiModeT groupAiModeT = new IGroupAiModeT();
			this.UnPackTo(groupAiModeT);
			return groupAiModeT;
		}

		// Token: 0x06024E0E RID: 151054 RVA: 0x00510823 File Offset: 0x0050EA23
		public void UnPackTo(IGroupAiModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024E0F RID: 151055 RVA: 0x00510834 File Offset: 0x0050EA34
		public static Offset<IGroupAiMode> Pack(FlatBufferBuilder builder, IGroupAiModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiMode>);
			}
			return IGroupAiMode.CreateIGroupAiMode(builder, _o.Type);
		}

		// Token: 0x0400F12C RID: 61740
		private Table __p;
	}
}

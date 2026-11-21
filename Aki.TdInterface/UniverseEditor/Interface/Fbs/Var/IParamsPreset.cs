using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EAD RID: 16045
	public struct IParamsPreset : IFlatbufferObject
	{
		// Token: 0x17006C9A RID: 27802
		// (get) Token: 0x06015B28 RID: 88872 RVA: 0x0031FD20 File Offset: 0x0031DF20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015B29 RID: 88873 RVA: 0x0031FD2D File Offset: 0x0031DF2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015B2A RID: 88874 RVA: 0x0031FD34 File Offset: 0x0031DF34
		public static IParamsPreset GetRootAsIParamsPreset(ByteBuffer _bb)
		{
			return IParamsPreset.GetRootAsIParamsPreset(_bb, default(IParamsPreset));
		}

		// Token: 0x06015B2B RID: 88875 RVA: 0x0031FD50 File Offset: 0x0031DF50
		public static IParamsPreset GetRootAsIParamsPreset(ByteBuffer _bb, IParamsPreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015B2C RID: 88876 RVA: 0x0031FD6D File Offset: 0x0031DF6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015B2D RID: 88877 RVA: 0x0031FD7C File Offset: 0x0031DF7C
		public IParamsPreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C9B RID: 27803
		// (get) Token: 0x06015B2E RID: 88878 RVA: 0x0031FD8C File Offset: 0x0031DF8C
		public EParamsPreset Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EParamsPreset.Decal;
				}
				return (EParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015B2F RID: 88879 RVA: 0x0031FDC8 File Offset: 0x0031DFC8
		public static Offset<IParamsPreset> CreateIParamsPreset(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal)
		{
			builder.StartTable(1);
			IParamsPreset.AddType(builder, Type);
			return IParamsPreset.EndIParamsPreset(builder);
		}

		// Token: 0x06015B30 RID: 88880 RVA: 0x0031FDDE File Offset: 0x0031DFDE
		public static void StartIParamsPreset(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015B31 RID: 88881 RVA: 0x0031FDE7 File Offset: 0x0031DFE7
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015B32 RID: 88882 RVA: 0x0031FDF2 File Offset: 0x0031DFF2
		public static Offset<IParamsPreset> EndIParamsPreset(FlatBufferBuilder builder)
		{
			return new Offset<IParamsPreset>(builder.EndTable());
		}

		// Token: 0x06015B33 RID: 88883 RVA: 0x0031FE00 File Offset: 0x0031E000
		public IParamsPresetT UnPack()
		{
			IParamsPresetT paramsPresetT = new IParamsPresetT();
			this.UnPackTo(paramsPresetT);
			return paramsPresetT;
		}

		// Token: 0x06015B34 RID: 88884 RVA: 0x0031FE1B File Offset: 0x0031E01B
		public void UnPackTo(IParamsPresetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015B35 RID: 88885 RVA: 0x0031FE2C File Offset: 0x0031E02C
		public static Offset<IParamsPreset> Pack(FlatBufferBuilder builder, IParamsPresetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParamsPreset>);
			}
			return IParamsPreset.CreateIParamsPreset(builder, _o.Type);
		}

		// Token: 0x0400B8A4 RID: 47268
		private Table __p;
	}
}

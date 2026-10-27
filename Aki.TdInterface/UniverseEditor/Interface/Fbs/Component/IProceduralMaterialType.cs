using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200578A RID: 22410
	public struct IProceduralMaterialType : IFlatbufferObject
	{
		// Token: 0x1700A729 RID: 42793
		// (get) Token: 0x06025927 RID: 153895 RVA: 0x0052EC4B File Offset: 0x0052CE4B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025928 RID: 153896 RVA: 0x0052EC58 File Offset: 0x0052CE58
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025929 RID: 153897 RVA: 0x0052EC60 File Offset: 0x0052CE60
		public static IProceduralMaterialType GetRootAsIProceduralMaterialType(ByteBuffer _bb)
		{
			return IProceduralMaterialType.GetRootAsIProceduralMaterialType(_bb, default(IProceduralMaterialType));
		}

		// Token: 0x0602592A RID: 153898 RVA: 0x0052EC7C File Offset: 0x0052CE7C
		public static IProceduralMaterialType GetRootAsIProceduralMaterialType(ByteBuffer _bb, IProceduralMaterialType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602592B RID: 153899 RVA: 0x0052EC99 File Offset: 0x0052CE99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602592C RID: 153900 RVA: 0x0052ECA8 File Offset: 0x0052CEA8
		public IProceduralMaterialType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A72A RID: 42794
		// (get) Token: 0x0602592D RID: 153901 RVA: 0x0052ECB8 File Offset: 0x0052CEB8
		public EProceduralMaterialType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProceduralMaterialType.CustomPrimitiveData;
				}
				return (EProceduralMaterialType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602592E RID: 153902 RVA: 0x0052ECF4 File Offset: 0x0052CEF4
		public static Offset<IProceduralMaterialType> CreateIProceduralMaterialType(FlatBufferBuilder builder, EProceduralMaterialType Type = EProceduralMaterialType.CustomPrimitiveData)
		{
			builder.StartTable(1);
			IProceduralMaterialType.AddType(builder, Type);
			return IProceduralMaterialType.EndIProceduralMaterialType(builder);
		}

		// Token: 0x0602592F RID: 153903 RVA: 0x0052ED0A File Offset: 0x0052CF0A
		public static void StartIProceduralMaterialType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025930 RID: 153904 RVA: 0x0052ED13 File Offset: 0x0052CF13
		public static void AddType(FlatBufferBuilder builder, EProceduralMaterialType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025931 RID: 153905 RVA: 0x0052ED1E File Offset: 0x0052CF1E
		public static Offset<IProceduralMaterialType> EndIProceduralMaterialType(FlatBufferBuilder builder)
		{
			return new Offset<IProceduralMaterialType>(builder.EndTable());
		}

		// Token: 0x06025932 RID: 153906 RVA: 0x0052ED2C File Offset: 0x0052CF2C
		public IProceduralMaterialTypeT UnPack()
		{
			IProceduralMaterialTypeT proceduralMaterialTypeT = new IProceduralMaterialTypeT();
			this.UnPackTo(proceduralMaterialTypeT);
			return proceduralMaterialTypeT;
		}

		// Token: 0x06025933 RID: 153907 RVA: 0x0052ED47 File Offset: 0x0052CF47
		public void UnPackTo(IProceduralMaterialTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025934 RID: 153908 RVA: 0x0052ED58 File Offset: 0x0052CF58
		public static Offset<IProceduralMaterialType> Pack(FlatBufferBuilder builder, IProceduralMaterialTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProceduralMaterialType>);
			}
			return IProceduralMaterialType.CreateIProceduralMaterialType(builder, _o.Type);
		}

		// Token: 0x0400EC39 RID: 60473
		private Table __p;
	}
}

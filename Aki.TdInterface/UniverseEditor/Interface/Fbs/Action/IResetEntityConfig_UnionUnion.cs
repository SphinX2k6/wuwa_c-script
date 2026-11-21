using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007607 RID: 30215
	public class IResetEntityConfig_UnionUnion
	{
		// Token: 0x1700DE06 RID: 56838
		// (get) Token: 0x0603503B RID: 217147 RVA: 0x0071F3ED File Offset: 0x0071D5ED
		// (set) Token: 0x0603503C RID: 217148 RVA: 0x0071F3F5 File Offset: 0x0071D5F5
		public IResetEntityConfig_Union Type { get; set; }

		// Token: 0x1700DE07 RID: 56839
		// (get) Token: 0x0603503D RID: 217149 RVA: 0x0071F3FE File Offset: 0x0071D5FE
		// (set) Token: 0x0603503E RID: 217150 RVA: 0x0071F406 File Offset: 0x0071D606
		public object Value { get; set; }

		// Token: 0x0603503F RID: 217151 RVA: 0x0071F40F File Offset: 0x0071D60F
		public IResetEntityConfig_UnionUnion()
		{
			this.Type = IResetEntityConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035040 RID: 217152 RVA: 0x0071F425 File Offset: 0x0071D625
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035041 RID: 217153 RVA: 0x0071F437 File Offset: 0x0071D637
		public IResetEntityConfigT AsIResetEntityConfig()
		{
			return this.As<IResetEntityConfigT>();
		}

		// Token: 0x06035042 RID: 217154 RVA: 0x0071F43F File Offset: 0x0071D63F
		public static IResetEntityConfig_UnionUnion FromIResetEntityConfig(IResetEntityConfigT _iresetentityconfig)
		{
			return new IResetEntityConfig_UnionUnion
			{
				Type = IResetEntityConfig_Union.IResetEntityConfig,
				Value = _iresetentityconfig
			};
		}

		// Token: 0x06035043 RID: 217155 RVA: 0x0071F454 File Offset: 0x0071D654
		public IResetTeleControlEntityT AsIResetTeleControlEntity()
		{
			return this.As<IResetTeleControlEntityT>();
		}

		// Token: 0x06035044 RID: 217156 RVA: 0x0071F45C File Offset: 0x0071D65C
		public static IResetEntityConfig_UnionUnion FromIResetTeleControlEntity(IResetTeleControlEntityT _iresettelecontrolentity)
		{
			return new IResetEntityConfig_UnionUnion
			{
				Type = IResetEntityConfig_Union.IResetTeleControlEntity,
				Value = _iresettelecontrolentity
			};
		}

		// Token: 0x06035045 RID: 217157 RVA: 0x0071F471 File Offset: 0x0071D671
		public IJigsawItemEntityT AsIJigsawItemEntity()
		{
			return this.As<IJigsawItemEntityT>();
		}

		// Token: 0x06035046 RID: 217158 RVA: 0x0071F479 File Offset: 0x0071D679
		public static IResetEntityConfig_UnionUnion FromIJigsawItemEntity(IJigsawItemEntityT _ijigsawitementity)
		{
			return new IResetEntityConfig_UnionUnion
			{
				Type = IResetEntityConfig_Union.IJigsawItemEntity,
				Value = _ijigsawitementity
			};
		}

		// Token: 0x06035047 RID: 217159 RVA: 0x0071F490 File Offset: 0x0071D690
		public static int Pack(FlatBufferBuilder builder, IResetEntityConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IResetEntityConfig_Union.IResetEntityConfig:
				return IResetEntityConfig.Pack(builder, _o.AsIResetEntityConfig()).Value;
			case IResetEntityConfig_Union.IResetTeleControlEntity:
				return IResetTeleControlEntity.Pack(builder, _o.AsIResetTeleControlEntity()).Value;
			case IResetEntityConfig_Union.IJigsawItemEntity:
				return IJigsawItemEntity.Pack(builder, _o.AsIJigsawItemEntity()).Value;
			default:
				return 0;
			}
		}
	}
}

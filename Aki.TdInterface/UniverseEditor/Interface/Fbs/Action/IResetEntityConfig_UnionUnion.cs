using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E83 RID: 28291
	public class IResetEntityConfig_UnionUnion
	{
		// Token: 0x1700D2AF RID: 53935
		// (get) Token: 0x06031FFB RID: 204795 RVA: 0x006C36B9 File Offset: 0x006C18B9
		// (set) Token: 0x06031FFC RID: 204796 RVA: 0x006C36C1 File Offset: 0x006C18C1
		public IResetEntityConfig_Union Type { get; set; }

		// Token: 0x1700D2B0 RID: 53936
		// (get) Token: 0x06031FFD RID: 204797 RVA: 0x006C36CA File Offset: 0x006C18CA
		// (set) Token: 0x06031FFE RID: 204798 RVA: 0x006C36D2 File Offset: 0x006C18D2
		public object Value { get; set; }

		// Token: 0x06031FFF RID: 204799 RVA: 0x006C36DB File Offset: 0x006C18DB
		public IResetEntityConfig_UnionUnion()
		{
			this.Type = IResetEntityConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032000 RID: 204800 RVA: 0x006C36F1 File Offset: 0x006C18F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032001 RID: 204801 RVA: 0x006C3703 File Offset: 0x006C1903
		public IResetEntityConfigT AsIResetEntityConfig()
		{
			return this.As<IResetEntityConfigT>();
		}

		// Token: 0x06032002 RID: 204802 RVA: 0x006C370B File Offset: 0x006C190B
		public static IResetEntityConfig_UnionUnion FromIResetEntityConfig(IResetEntityConfigT _iresetentityconfig)
		{
			return new IResetEntityConfig_UnionUnion
			{
				Type = IResetEntityConfig_Union.IResetEntityConfig,
				Value = _iresetentityconfig
			};
		}

		// Token: 0x06032003 RID: 204803 RVA: 0x006C3720 File Offset: 0x006C1920
		public IResetTeleControlEntityT AsIResetTeleControlEntity()
		{
			return this.As<IResetTeleControlEntityT>();
		}

		// Token: 0x06032004 RID: 204804 RVA: 0x006C3728 File Offset: 0x006C1928
		public static IResetEntityConfig_UnionUnion FromIResetTeleControlEntity(IResetTeleControlEntityT _iresettelecontrolentity)
		{
			return new IResetEntityConfig_UnionUnion
			{
				Type = IResetEntityConfig_Union.IResetTeleControlEntity,
				Value = _iresettelecontrolentity
			};
		}

		// Token: 0x06032005 RID: 204805 RVA: 0x006C373D File Offset: 0x006C193D
		public IJigsawItemEntityT AsIJigsawItemEntity()
		{
			return this.As<IJigsawItemEntityT>();
		}

		// Token: 0x06032006 RID: 204806 RVA: 0x006C3745 File Offset: 0x006C1945
		public static IResetEntityConfig_UnionUnion FromIJigsawItemEntity(IJigsawItemEntityT _ijigsawitementity)
		{
			return new IResetEntityConfig_UnionUnion
			{
				Type = IResetEntityConfig_Union.IJigsawItemEntity,
				Value = _ijigsawitementity
			};
		}

		// Token: 0x06032007 RID: 204807 RVA: 0x006C375C File Offset: 0x006C195C
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

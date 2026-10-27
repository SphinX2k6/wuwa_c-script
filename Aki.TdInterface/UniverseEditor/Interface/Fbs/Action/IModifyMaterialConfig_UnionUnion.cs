using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC2 RID: 27330
	public class IModifyMaterialConfig_UnionUnion
	{
		// Token: 0x1700CAC7 RID: 51911
		// (get) Token: 0x0602FE52 RID: 196178 RVA: 0x00683DFD File Offset: 0x00681FFD
		// (set) Token: 0x0602FE53 RID: 196179 RVA: 0x00683E05 File Offset: 0x00682005
		public IModifyMaterialConfig_Union Type { get; set; }

		// Token: 0x1700CAC8 RID: 51912
		// (get) Token: 0x0602FE54 RID: 196180 RVA: 0x00683E0E File Offset: 0x0068200E
		// (set) Token: 0x0602FE55 RID: 196181 RVA: 0x00683E16 File Offset: 0x00682016
		public object Value { get; set; }

		// Token: 0x0602FE56 RID: 196182 RVA: 0x00683E1F File Offset: 0x0068201F
		public IModifyMaterialConfig_UnionUnion()
		{
			this.Type = IModifyMaterialConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FE57 RID: 196183 RVA: 0x00683E35 File Offset: 0x00682035
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FE58 RID: 196184 RVA: 0x00683E47 File Offset: 0x00682047
		public IModifyMaterialConfigT AsIModifyMaterialConfig()
		{
			return this.As<IModifyMaterialConfigT>();
		}

		// Token: 0x0602FE59 RID: 196185 RVA: 0x00683E4F File Offset: 0x0068204F
		public static IModifyMaterialConfig_UnionUnion FromIModifyMaterialConfig(IModifyMaterialConfigT _imodifymaterialconfig)
		{
			return new IModifyMaterialConfig_UnionUnion
			{
				Type = IModifyMaterialConfig_Union.IModifyMaterialConfig,
				Value = _imodifymaterialconfig
			};
		}

		// Token: 0x0602FE5A RID: 196186 RVA: 0x00683E64 File Offset: 0x00682064
		public IChangeActorMaterialDataT AsIChangeActorMaterialData()
		{
			return this.As<IChangeActorMaterialDataT>();
		}

		// Token: 0x0602FE5B RID: 196187 RVA: 0x00683E6C File Offset: 0x0068206C
		public static IModifyMaterialConfig_UnionUnion FromIChangeActorMaterialData(IChangeActorMaterialDataT _ichangeactormaterialdata)
		{
			return new IModifyMaterialConfig_UnionUnion
			{
				Type = IModifyMaterialConfig_Union.IChangeActorMaterialData,
				Value = _ichangeactormaterialdata
			};
		}

		// Token: 0x0602FE5C RID: 196188 RVA: 0x00683E81 File Offset: 0x00682081
		public IChangeActorMPCT AsIChangeActorMPC()
		{
			return this.As<IChangeActorMPCT>();
		}

		// Token: 0x0602FE5D RID: 196189 RVA: 0x00683E89 File Offset: 0x00682089
		public static IModifyMaterialConfig_UnionUnion FromIChangeActorMPC(IChangeActorMPCT _ichangeactormpc)
		{
			return new IModifyMaterialConfig_UnionUnion
			{
				Type = IModifyMaterialConfig_Union.IChangeActorMPC,
				Value = _ichangeactormpc
			};
		}

		// Token: 0x0602FE5E RID: 196190 RVA: 0x00683EA0 File Offset: 0x006820A0
		public static int Pack(FlatBufferBuilder builder, IModifyMaterialConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IModifyMaterialConfig_Union.IModifyMaterialConfig:
				return IModifyMaterialConfig.Pack(builder, _o.AsIModifyMaterialConfig()).Value;
			case IModifyMaterialConfig_Union.IChangeActorMaterialData:
				return IChangeActorMaterialData.Pack(builder, _o.AsIChangeActorMaterialData()).Value;
			case IModifyMaterialConfig_Union.IChangeActorMPC:
				return IChangeActorMPC.Pack(builder, _o.AsIChangeActorMPC()).Value;
			default:
				return 0;
			}
		}
	}
}

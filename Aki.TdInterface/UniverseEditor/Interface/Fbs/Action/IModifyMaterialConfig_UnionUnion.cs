using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F6 RID: 29174
	public class IModifyMaterialConfig_UnionUnion
	{
		// Token: 0x1700D58F RID: 54671
		// (get) Token: 0x06032C08 RID: 207880 RVA: 0x006DB0A1 File Offset: 0x006D92A1
		// (set) Token: 0x06032C09 RID: 207881 RVA: 0x006DB0A9 File Offset: 0x006D92A9
		public IModifyMaterialConfig_Union Type { get; set; }

		// Token: 0x1700D590 RID: 54672
		// (get) Token: 0x06032C0A RID: 207882 RVA: 0x006DB0B2 File Offset: 0x006D92B2
		// (set) Token: 0x06032C0B RID: 207883 RVA: 0x006DB0BA File Offset: 0x006D92BA
		public object Value { get; set; }

		// Token: 0x06032C0C RID: 207884 RVA: 0x006DB0C3 File Offset: 0x006D92C3
		public IModifyMaterialConfig_UnionUnion()
		{
			this.Type = IModifyMaterialConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032C0D RID: 207885 RVA: 0x006DB0D9 File Offset: 0x006D92D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032C0E RID: 207886 RVA: 0x006DB0EB File Offset: 0x006D92EB
		public IModifyMaterialConfigT AsIModifyMaterialConfig()
		{
			return this.As<IModifyMaterialConfigT>();
		}

		// Token: 0x06032C0F RID: 207887 RVA: 0x006DB0F3 File Offset: 0x006D92F3
		public static IModifyMaterialConfig_UnionUnion FromIModifyMaterialConfig(IModifyMaterialConfigT _imodifymaterialconfig)
		{
			return new IModifyMaterialConfig_UnionUnion
			{
				Type = IModifyMaterialConfig_Union.IModifyMaterialConfig,
				Value = _imodifymaterialconfig
			};
		}

		// Token: 0x06032C10 RID: 207888 RVA: 0x006DB108 File Offset: 0x006D9308
		public IChangeActorMaterialDataT AsIChangeActorMaterialData()
		{
			return this.As<IChangeActorMaterialDataT>();
		}

		// Token: 0x06032C11 RID: 207889 RVA: 0x006DB110 File Offset: 0x006D9310
		public static IModifyMaterialConfig_UnionUnion FromIChangeActorMaterialData(IChangeActorMaterialDataT _ichangeactormaterialdata)
		{
			return new IModifyMaterialConfig_UnionUnion
			{
				Type = IModifyMaterialConfig_Union.IChangeActorMaterialData,
				Value = _ichangeactormaterialdata
			};
		}

		// Token: 0x06032C12 RID: 207890 RVA: 0x006DB125 File Offset: 0x006D9325
		public IChangeActorMPCT AsIChangeActorMPC()
		{
			return this.As<IChangeActorMPCT>();
		}

		// Token: 0x06032C13 RID: 207891 RVA: 0x006DB12D File Offset: 0x006D932D
		public static IModifyMaterialConfig_UnionUnion FromIChangeActorMPC(IChangeActorMPCT _ichangeactormpc)
		{
			return new IModifyMaterialConfig_UnionUnion
			{
				Type = IModifyMaterialConfig_Union.IChangeActorMPC,
				Value = _ichangeactormpc
			};
		}

		// Token: 0x06032C14 RID: 207892 RVA: 0x006DB144 File Offset: 0x006D9344
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

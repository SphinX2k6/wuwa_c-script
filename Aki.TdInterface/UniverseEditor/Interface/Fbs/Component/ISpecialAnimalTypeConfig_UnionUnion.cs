using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F7C RID: 24444
	public class ISpecialAnimalTypeConfig_UnionUnion
	{
		// Token: 0x1700B506 RID: 46342
		// (get) Token: 0x0602917F RID: 168319 RVA: 0x0059CB31 File Offset: 0x0059AD31
		// (set) Token: 0x06029180 RID: 168320 RVA: 0x0059CB39 File Offset: 0x0059AD39
		public ISpecialAnimalTypeConfig_Union Type { get; set; }

		// Token: 0x1700B507 RID: 46343
		// (get) Token: 0x06029181 RID: 168321 RVA: 0x0059CB42 File Offset: 0x0059AD42
		// (set) Token: 0x06029182 RID: 168322 RVA: 0x0059CB4A File Offset: 0x0059AD4A
		public object Value { get; set; }

		// Token: 0x06029183 RID: 168323 RVA: 0x0059CB53 File Offset: 0x0059AD53
		public ISpecialAnimalTypeConfig_UnionUnion()
		{
			this.Type = ISpecialAnimalTypeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029184 RID: 168324 RVA: 0x0059CB69 File Offset: 0x0059AD69
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029185 RID: 168325 RVA: 0x0059CB7B File Offset: 0x0059AD7B
		public ISpecialAnimalTypeConfigT AsISpecialAnimalTypeConfig()
		{
			return this.As<ISpecialAnimalTypeConfigT>();
		}

		// Token: 0x06029186 RID: 168326 RVA: 0x0059CB83 File Offset: 0x0059AD83
		public static ISpecialAnimalTypeConfig_UnionUnion FromISpecialAnimalTypeConfig(ISpecialAnimalTypeConfigT _ispecialanimaltypeconfig)
		{
			return new ISpecialAnimalTypeConfig_UnionUnion
			{
				Type = ISpecialAnimalTypeConfig_Union.ISpecialAnimalTypeConfig,
				Value = _ispecialanimaltypeconfig
			};
		}

		// Token: 0x06029187 RID: 168327 RVA: 0x0059CB98 File Offset: 0x0059AD98
		public ICollectAnimalConfigT AsICollectAnimalConfig()
		{
			return this.As<ICollectAnimalConfigT>();
		}

		// Token: 0x06029188 RID: 168328 RVA: 0x0059CBA0 File Offset: 0x0059ADA0
		public static ISpecialAnimalTypeConfig_UnionUnion FromICollectAnimalConfig(ICollectAnimalConfigT _icollectanimalconfig)
		{
			return new ISpecialAnimalTypeConfig_UnionUnion
			{
				Type = ISpecialAnimalTypeConfig_Union.ICollectAnimalConfig,
				Value = _icollectanimalconfig
			};
		}

		// Token: 0x06029189 RID: 168329 RVA: 0x0059CBB8 File Offset: 0x0059ADB8
		public static int Pack(FlatBufferBuilder builder, ISpecialAnimalTypeConfig_UnionUnion _o)
		{
			ISpecialAnimalTypeConfig_Union type = _o.Type;
			if (type == ISpecialAnimalTypeConfig_Union.ISpecialAnimalTypeConfig)
			{
				return ISpecialAnimalTypeConfig.Pack(builder, _o.AsISpecialAnimalTypeConfig()).Value;
			}
			if (type != ISpecialAnimalTypeConfig_Union.ICollectAnimalConfig)
			{
				return 0;
			}
			return ICollectAnimalConfig.Pack(builder, _o.AsICollectAnimalConfig()).Value;
		}
	}
}

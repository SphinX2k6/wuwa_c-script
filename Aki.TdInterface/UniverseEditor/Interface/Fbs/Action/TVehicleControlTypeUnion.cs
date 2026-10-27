using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077FF RID: 30719
	public class TVehicleControlTypeUnion
	{
		// Token: 0x1700E6ED RID: 59117
		// (get) Token: 0x06037B64 RID: 228196 RVA: 0x007883E6 File Offset: 0x007865E6
		// (set) Token: 0x06037B65 RID: 228197 RVA: 0x007883EE File Offset: 0x007865EE
		public TVehicleControlType Type { get; set; }

		// Token: 0x1700E6EE RID: 59118
		// (get) Token: 0x06037B66 RID: 228198 RVA: 0x007883F7 File Offset: 0x007865F7
		// (set) Token: 0x06037B67 RID: 228199 RVA: 0x007883FF File Offset: 0x007865FF
		public object Value { get; set; }

		// Token: 0x06037B68 RID: 228200 RVA: 0x00788408 File Offset: 0x00786608
		public TVehicleControlTypeUnion()
		{
			this.Type = TVehicleControlType.NONE;
			this.Value = null;
		}

		// Token: 0x06037B69 RID: 228201 RVA: 0x0078841E File Offset: 0x0078661E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037B6A RID: 228202 RVA: 0x00788430 File Offset: 0x00786630
		public IVehicleEnterPathMoveT AsIVehicleEnterPathMove()
		{
			return this.As<IVehicleEnterPathMoveT>();
		}

		// Token: 0x06037B6B RID: 228203 RVA: 0x00788438 File Offset: 0x00786638
		public static TVehicleControlTypeUnion FromIVehicleEnterPathMove(IVehicleEnterPathMoveT _ivehicleenterpathmove)
		{
			return new TVehicleControlTypeUnion
			{
				Type = TVehicleControlType.IVehicleEnterPathMove,
				Value = _ivehicleenterpathmove
			};
		}

		// Token: 0x06037B6C RID: 228204 RVA: 0x0078844D File Offset: 0x0078664D
		public IVehicleExitPathMoveT AsIVehicleExitPathMove()
		{
			return this.As<IVehicleExitPathMoveT>();
		}

		// Token: 0x06037B6D RID: 228205 RVA: 0x00788455 File Offset: 0x00786655
		public static TVehicleControlTypeUnion FromIVehicleExitPathMove(IVehicleExitPathMoveT _ivehicleexitpathmove)
		{
			return new TVehicleControlTypeUnion
			{
				Type = TVehicleControlType.IVehicleExitPathMove,
				Value = _ivehicleexitpathmove
			};
		}

		// Token: 0x06037B6E RID: 228206 RVA: 0x0078846C File Offset: 0x0078666C
		public static int Pack(FlatBufferBuilder builder, TVehicleControlTypeUnion _o)
		{
			TVehicleControlType type = _o.Type;
			if (type == TVehicleControlType.IVehicleEnterPathMove)
			{
				return IVehicleEnterPathMove.Pack(builder, _o.AsIVehicleEnterPathMove()).Value;
			}
			if (type != TVehicleControlType.IVehicleExitPathMove)
			{
				return 0;
			}
			return IVehicleExitPathMove.Pack(builder, _o.AsIVehicleExitPathMove()).Value;
		}
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053AD RID: 21421
	public class IAirWallSpawnMode_UnionUnion
	{
		// Token: 0x1700978D RID: 38797
		// (get) Token: 0x060216FF RID: 136959 RVA: 0x0049CF9D File Offset: 0x0049B19D
		// (set) Token: 0x06021700 RID: 136960 RVA: 0x0049CFA5 File Offset: 0x0049B1A5
		public IAirWallSpawnMode_Union Type { get; set; }

		// Token: 0x1700978E RID: 38798
		// (get) Token: 0x06021701 RID: 136961 RVA: 0x0049CFAE File Offset: 0x0049B1AE
		// (set) Token: 0x06021702 RID: 136962 RVA: 0x0049CFB6 File Offset: 0x0049B1B6
		public object Value { get; set; }

		// Token: 0x06021703 RID: 136963 RVA: 0x0049CFBF File Offset: 0x0049B1BF
		public IAirWallSpawnMode_UnionUnion()
		{
			this.Type = IAirWallSpawnMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021704 RID: 136964 RVA: 0x0049CFD5 File Offset: 0x0049B1D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021705 RID: 136965 RVA: 0x0049CFE7 File Offset: 0x0049B1E7
		public IAirWallSpawnModeT AsIAirWallSpawnMode()
		{
			return this.As<IAirWallSpawnModeT>();
		}

		// Token: 0x06021706 RID: 136966 RVA: 0x0049CFEF File Offset: 0x0049B1EF
		public static IAirWallSpawnMode_UnionUnion FromIAirWallSpawnMode(IAirWallSpawnModeT _iairwallspawnmode)
		{
			return new IAirWallSpawnMode_UnionUnion
			{
				Type = IAirWallSpawnMode_Union.IAirWallSpawnMode,
				Value = _iairwallspawnmode
			};
		}

		// Token: 0x06021707 RID: 136967 RVA: 0x0049D004 File Offset: 0x0049B204
		public IAirWallWholeSpawnModeT AsIAirWallWholeSpawnMode()
		{
			return this.As<IAirWallWholeSpawnModeT>();
		}

		// Token: 0x06021708 RID: 136968 RVA: 0x0049D00C File Offset: 0x0049B20C
		public static IAirWallSpawnMode_UnionUnion FromIAirWallWholeSpawnMode(IAirWallWholeSpawnModeT _iairwallwholespawnmode)
		{
			return new IAirWallSpawnMode_UnionUnion
			{
				Type = IAirWallSpawnMode_Union.IAirWallWholeSpawnMode,
				Value = _iairwallwholespawnmode
			};
		}

		// Token: 0x06021709 RID: 136969 RVA: 0x0049D024 File Offset: 0x0049B224
		public static int Pack(FlatBufferBuilder builder, IAirWallSpawnMode_UnionUnion _o)
		{
			IAirWallSpawnMode_Union type = _o.Type;
			if (type == IAirWallSpawnMode_Union.IAirWallSpawnMode)
			{
				return IAirWallSpawnMode.Pack(builder, _o.AsIAirWallSpawnMode()).Value;
			}
			if (type != IAirWallSpawnMode_Union.IAirWallWholeSpawnMode)
			{
				return 0;
			}
			return IAirWallWholeSpawnMode.Pack(builder, _o.AsIAirWallWholeSpawnMode()).Value;
		}
	}
}

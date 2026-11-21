using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C2 RID: 22722
	public class IGroupAiMode_UnionUnion
	{
		// Token: 0x1700A4BB RID: 42171
		// (get) Token: 0x06024E26 RID: 151078 RVA: 0x00510A15 File Offset: 0x0050EC15
		// (set) Token: 0x06024E27 RID: 151079 RVA: 0x00510A1D File Offset: 0x0050EC1D
		public IGroupAiMode_Union Type { get; set; }

		// Token: 0x1700A4BC RID: 42172
		// (get) Token: 0x06024E28 RID: 151080 RVA: 0x00510A26 File Offset: 0x0050EC26
		// (set) Token: 0x06024E29 RID: 151081 RVA: 0x00510A2E File Offset: 0x0050EC2E
		public object Value { get; set; }

		// Token: 0x06024E2A RID: 151082 RVA: 0x00510A37 File Offset: 0x0050EC37
		public IGroupAiMode_UnionUnion()
		{
			this.Type = IGroupAiMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024E2B RID: 151083 RVA: 0x00510A4D File Offset: 0x0050EC4D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024E2C RID: 151084 RVA: 0x00510A5F File Offset: 0x0050EC5F
		public IGroupAiModeT AsIGroupAiMode()
		{
			return this.As<IGroupAiModeT>();
		}

		// Token: 0x06024E2D RID: 151085 RVA: 0x00510A67 File Offset: 0x0050EC67
		public static IGroupAiMode_UnionUnion FromIGroupAiMode(IGroupAiModeT _igroupaimode)
		{
			return new IGroupAiMode_UnionUnion
			{
				Type = IGroupAiMode_Union.IGroupAiMode,
				Value = _igroupaimode
			};
		}

		// Token: 0x06024E2E RID: 151086 RVA: 0x00510A7C File Offset: 0x0050EC7C
		public IGroupAiModeDefaultT AsIGroupAiModeDefault()
		{
			return this.As<IGroupAiModeDefaultT>();
		}

		// Token: 0x06024E2F RID: 151087 RVA: 0x00510A84 File Offset: 0x0050EC84
		public static IGroupAiMode_UnionUnion FromIGroupAiModeDefault(IGroupAiModeDefaultT _igroupaimodedefault)
		{
			return new IGroupAiMode_UnionUnion
			{
				Type = IGroupAiMode_Union.IGroupAiModeDefault,
				Value = _igroupaimodedefault
			};
		}

		// Token: 0x06024E30 RID: 151088 RVA: 0x00510A99 File Offset: 0x0050EC99
		public IGroupAiPatrolT AsIGroupAiPatrol()
		{
			return this.As<IGroupAiPatrolT>();
		}

		// Token: 0x06024E31 RID: 151089 RVA: 0x00510AA1 File Offset: 0x0050ECA1
		public static IGroupAiMode_UnionUnion FromIGroupAiPatrol(IGroupAiPatrolT _igroupaipatrol)
		{
			return new IGroupAiMode_UnionUnion
			{
				Type = IGroupAiMode_Union.IGroupAiPatrol,
				Value = _igroupaipatrol
			};
		}

		// Token: 0x06024E32 RID: 151090 RVA: 0x00510AB6 File Offset: 0x0050ECB6
		public IGroupAiMonsterEcologyT AsIGroupAiMonsterEcology()
		{
			return this.As<IGroupAiMonsterEcologyT>();
		}

		// Token: 0x06024E33 RID: 151091 RVA: 0x00510ABE File Offset: 0x0050ECBE
		public static IGroupAiMode_UnionUnion FromIGroupAiMonsterEcology(IGroupAiMonsterEcologyT _igroupaimonsterecology)
		{
			return new IGroupAiMode_UnionUnion
			{
				Type = IGroupAiMode_Union.IGroupAiMonsterEcology,
				Value = _igroupaimonsterecology
			};
		}

		// Token: 0x06024E34 RID: 151092 RVA: 0x00510AD4 File Offset: 0x0050ECD4
		public static int Pack(FlatBufferBuilder builder, IGroupAiMode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGroupAiMode_Union.IGroupAiMode:
				return IGroupAiMode.Pack(builder, _o.AsIGroupAiMode()).Value;
			case IGroupAiMode_Union.IGroupAiModeDefault:
				return IGroupAiModeDefault.Pack(builder, _o.AsIGroupAiModeDefault()).Value;
			case IGroupAiMode_Union.IGroupAiPatrol:
				return IGroupAiPatrol.Pack(builder, _o.AsIGroupAiPatrol()).Value;
			case IGroupAiMode_Union.IGroupAiMonsterEcology:
				return IGroupAiMonsterEcology.Pack(builder, _o.AsIGroupAiMonsterEcology()).Value;
			default:
				return 0;
			}
		}
	}
}

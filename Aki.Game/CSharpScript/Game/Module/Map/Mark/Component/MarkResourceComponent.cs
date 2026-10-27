using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Base;

namespace CSharpScript.Game.Module.Map.Mark.Component
{
	// Token: 0x020054CF RID: 21711
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkResourceComponent : MapComponent
	{
		// Token: 0x060376D9 RID: 227033 RVA: 0x00D2A373 File Offset: 0x00D28573
		public MarkResourceComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17008503 RID: 34051
		// (get) Token: 0x060376DA RID: 227034 RVA: 0x00D2A37C File Offset: 0x00D2857C
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.MarkResource;
			}
		}

		// Token: 0x17008504 RID: 34052
		// (get) Token: 0x060376DC RID: 227036 RVA: 0x00D2A39C File Offset: 0x00D2859C
		// (set) Token: 0x060376DB RID: 227035 RVA: 0x00D2A380 File Offset: 0x00D28580
		public string TopRightIconPath
		{
			get
			{
				OneOf<Vector2D, bool, int, string, float> oneOf;
				if (base.PropertyMap.TryGetValue(0, out oneOf))
				{
					return oneOf.AsT4;
				}
				return string.Empty;
			}
			set
			{
				base.PropertyMap[0] = value;
			}
		}

		// Token: 0x17008505 RID: 34053
		// (get) Token: 0x060376DE RID: 227038 RVA: 0x00D2A3E4 File Offset: 0x00D285E4
		// (set) Token: 0x060376DD RID: 227037 RVA: 0x00D2A3CB File Offset: 0x00D285CB
		public float RangeSize
		{
			get
			{
				OneOf<Vector2D, bool, int, string, float> oneOf;
				if (base.PropertyMap.TryGetValue(2, out oneOf))
				{
					return oneOf.AsT5;
				}
				return 0f;
			}
			set
			{
				base.PropertyMap[2] = value;
			}
		}

		// Token: 0x17008506 RID: 34054
		// (get) Token: 0x060376E0 RID: 227040 RVA: 0x00D2A42C File Offset: 0x00D2862C
		// (set) Token: 0x060376DF RID: 227039 RVA: 0x00D2A413 File Offset: 0x00D28613
		public bool RangeSetAsFirstChild
		{
			get
			{
				OneOf<Vector2D, bool, int, string, float> oneOf;
				return base.PropertyMap.TryGetValue(6, out oneOf) && oneOf.AsT2;
			}
			set
			{
				base.PropertyMap[6] = value;
			}
		}

		// Token: 0x17008507 RID: 34055
		// (get) Token: 0x060376E2 RID: 227042 RVA: 0x00D2A470 File Offset: 0x00D28670
		// (set) Token: 0x060376E1 RID: 227041 RVA: 0x00D2A457 File Offset: 0x00D28657
		public Vector2D OutOfBoundDirection
		{
			get
			{
				OneOf<Vector2D, bool, int, string, float> oneOf;
				if (base.PropertyMap.TryGetValue(3, out oneOf))
				{
					return oneOf.AsT1;
				}
				return new Vector2D();
			}
			set
			{
				base.PropertyMap[3] = value;
			}
		}

		// Token: 0x17008508 RID: 34056
		// (get) Token: 0x060376E3 RID: 227043 RVA: 0x00D2A49F File Offset: 0x00D2869F
		public bool IsOutOfBoundDirectionDirty
		{
			get
			{
				return base.PropertyMap.IsDirty(3);
			}
		}

		// Token: 0x060376E4 RID: 227044 RVA: 0x00D2A4B2 File Offset: 0x00D286B2
		public void SetOutOfBoundDirectionClean()
		{
			base.PropertyMap.CleanDirty(3);
		}

		// Token: 0x17008509 RID: 34057
		// (get) Token: 0x060376E6 RID: 227046 RVA: 0x00D2A4E0 File Offset: 0x00D286E0
		// (set) Token: 0x060376E5 RID: 227045 RVA: 0x00D2A4C5 File Offset: 0x00D286C5
		public string ChildIconPath
		{
			get
			{
				OneOf<Vector2D, bool, int, string, float> oneOf;
				if (base.PropertyMap.TryGetValue(4, out oneOf))
				{
					return oneOf.AsT4;
				}
				return string.Empty;
			}
			set
			{
				base.PropertyMap[4] = value;
			}
		}

		// Token: 0x1700850A RID: 34058
		// (get) Token: 0x060376E7 RID: 227047 RVA: 0x00D2A50F File Offset: 0x00D2870F
		public bool IsChildIconPathDirty
		{
			get
			{
				return base.PropertyMap.IsDirty(4);
			}
		}

		// Token: 0x060376E8 RID: 227048 RVA: 0x00D2A522 File Offset: 0x00D28722
		public void SetChildIconPathClean()
		{
			base.PropertyMap.CleanDirty(4);
		}

		// Token: 0x0200B73E RID: 46910
		[NullableContext(0)]
		private enum EPropertyType
		{
			// Token: 0x040377D1 RID: 227281
			TopRightIconPath,
			// Token: 0x040377D2 RID: 227282
			RangeResourceId,
			// Token: 0x040377D3 RID: 227283
			RangeSize,
			// Token: 0x040377D4 RID: 227284
			OutOfBoundDirection,
			// Token: 0x040377D5 RID: 227285
			ChildIconPath,
			// Token: 0x040377D6 RID: 227286
			EnableVerticalPointer,
			// Token: 0x040377D7 RID: 227287
			RangeSetAsFirstChild
		}
	}
}

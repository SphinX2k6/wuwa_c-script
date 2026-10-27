using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Map.CopyPrototypeTest.TestMap.ProtoTest_CC.Gameplay_CC.Blueprints.Test2to3
{
	// Token: 0x02003E4C RID: 15948
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(5, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 5)]
	[UnrealObjectPath("/Game/Aki/Map/CopyPrototypeTest/TestMap/ProtoTest_CC/Gameplay_CC/Blueprints/Test2to3/ST_2to3Options.ST_2to3Options")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 5)]
	public struct ST_2to3Options : IEqualityOperators<ST_2to3Options, ST_2to3Options, bool>, IEquatable<ST_2to3Options>, IUnrealScriptStruct
	{
		// Token: 0x0602817F RID: 164223 RVA: 0x009A3CC8 File Offset: 0x009A1EC8
		public ST_2to3Options(bool SimpleAct, bool PlaySeq, bool MakeCanBeFound, bool ShowActors, bool HideActors)
		{
			this.SimpleAct = SimpleAct;
			this.PlaySeq = PlaySeq;
			this.MakeCanBeFound = MakeCanBeFound;
			this.ShowActors = ShowActors;
			this.HideActors = HideActors;
		}

		// Token: 0x06028180 RID: 164224 RVA: 0x009A3CF0 File Offset: 0x009A1EF0
		public static bool operator ==(ST_2to3Options left, ST_2to3Options right)
		{
			return left.SimpleAct == right.SimpleAct && left.PlaySeq == right.PlaySeq && left.MakeCanBeFound == right.MakeCanBeFound && left.ShowActors == right.ShowActors && left.HideActors == right.HideActors;
		}

		// Token: 0x06028181 RID: 164225 RVA: 0x009A3D45 File Offset: 0x009A1F45
		public static bool operator !=(ST_2to3Options left, ST_2to3Options right)
		{
			return !(left == right);
		}

		// Token: 0x06028182 RID: 164226 RVA: 0x009A3D51 File Offset: 0x009A1F51
		public bool Equals(ST_2to3Options other)
		{
			return this == other;
		}

		// Token: 0x06028183 RID: 164227 RVA: 0x009A3D60 File Offset: 0x009A1F60
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is ST_2to3Options)
			{
				ST_2to3Options other = (ST_2to3Options)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06028184 RID: 164228 RVA: 0x009A3D85 File Offset: 0x009A1F85
		public override int GetHashCode()
		{
			return HashCode.Combine<bool, bool, bool, bool, bool>(this.SimpleAct, this.PlaySeq, this.MakeCanBeFound, this.ShowActors, this.HideActors);
		}

		// Token: 0x06028185 RID: 164229 RVA: 0x009A3DAA File Offset: 0x009A1FAA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (ST_2to3Options._ScriptStructPtr != 0) ? ST_2to3Options._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Map/CopyPrototypeTest/TestMap/ProtoTest_CC/Gameplay_CC/Blueprints/Test2to3/ST_2to3Options.ST_2to3Options", ref ST_2to3Options._ScriptStructPtr);
		}

		// Token: 0x04014657 RID: 83543
		[FieldOffset(0)]
		public bool SimpleAct;

		// Token: 0x04014658 RID: 83544
		[FieldOffset(1)]
		public bool PlaySeq;

		// Token: 0x04014659 RID: 83545
		[FieldOffset(2)]
		public bool MakeCanBeFound;

		// Token: 0x0401465A RID: 83546
		[FieldOffset(3)]
		public bool ShowActors;

		// Token: 0x0401465B RID: 83547
		[FieldOffset(4)]
		public bool HideActors;

		// Token: 0x0401465C RID: 83548
		public const string __ObjectPath = "/Game/Aki/Map/CopyPrototypeTest/TestMap/ProtoTest_CC/Gameplay_CC/Blueprints/Test2to3/ST_2to3Options.ST_2to3Options";

		// Token: 0x0401465D RID: 83549
		private static IntPtr _ScriptStructPtr;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007969 RID: 31081
	public class ISplineMoveTargetType_UnionUnion
	{
		// Token: 0x1700E3EC RID: 58348
		// (get) Token: 0x06036BC4 RID: 224196 RVA: 0x00752915 File Offset: 0x00750B15
		// (set) Token: 0x06036BC5 RID: 224197 RVA: 0x0075291D File Offset: 0x00750B1D
		public ISplineMoveTargetType_Union Type { get; set; }

		// Token: 0x1700E3ED RID: 58349
		// (get) Token: 0x06036BC6 RID: 224198 RVA: 0x00752926 File Offset: 0x00750B26
		// (set) Token: 0x06036BC7 RID: 224199 RVA: 0x0075292E File Offset: 0x00750B2E
		public object Value { get; set; }

		// Token: 0x06036BC8 RID: 224200 RVA: 0x00752937 File Offset: 0x00750B37
		public ISplineMoveTargetType_UnionUnion()
		{
			this.Type = ISplineMoveTargetType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036BC9 RID: 224201 RVA: 0x0075294D File Offset: 0x00750B4D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036BCA RID: 224202 RVA: 0x0075295F File Offset: 0x00750B5F
		public ISplineMoveTargetTypeT AsISplineMoveTargetType()
		{
			return this.As<ISplineMoveTargetTypeT>();
		}

		// Token: 0x06036BCB RID: 224203 RVA: 0x00752967 File Offset: 0x00750B67
		public static ISplineMoveTargetType_UnionUnion FromISplineMoveTargetType(ISplineMoveTargetTypeT _isplinemovetargettype)
		{
			return new ISplineMoveTargetType_UnionUnion
			{
				Type = ISplineMoveTargetType_Union.ISplineMoveTargetType,
				Value = _isplinemovetargettype
			};
		}

		// Token: 0x06036BCC RID: 224204 RVA: 0x0075297C File Offset: 0x00750B7C
		public IEntitySplineMoveTargetT AsIEntitySplineMoveTarget()
		{
			return this.As<IEntitySplineMoveTargetT>();
		}

		// Token: 0x06036BCD RID: 224205 RVA: 0x00752984 File Offset: 0x00750B84
		public static ISplineMoveTargetType_UnionUnion FromIEntitySplineMoveTarget(IEntitySplineMoveTargetT _ientitysplinemovetarget)
		{
			return new ISplineMoveTargetType_UnionUnion
			{
				Type = ISplineMoveTargetType_Union.IEntitySplineMoveTarget,
				Value = _ientitysplinemovetarget
			};
		}

		// Token: 0x06036BCE RID: 224206 RVA: 0x00752999 File Offset: 0x00750B99
		public IPlayerSplineMoveTargetT AsIPlayerSplineMoveTarget()
		{
			return this.As<IPlayerSplineMoveTargetT>();
		}

		// Token: 0x06036BCF RID: 224207 RVA: 0x007529A1 File Offset: 0x00750BA1
		public static ISplineMoveTargetType_UnionUnion FromIPlayerSplineMoveTarget(IPlayerSplineMoveTargetT _iplayersplinemovetarget)
		{
			return new ISplineMoveTargetType_UnionUnion
			{
				Type = ISplineMoveTargetType_Union.IPlayerSplineMoveTarget,
				Value = _iplayersplinemovetarget
			};
		}

		// Token: 0x06036BD0 RID: 224208 RVA: 0x007529B6 File Offset: 0x00750BB6
		public IAssistCharacterSplineMoveTargetT AsIAssistCharacterSplineMoveTarget()
		{
			return this.As<IAssistCharacterSplineMoveTargetT>();
		}

		// Token: 0x06036BD1 RID: 224209 RVA: 0x007529BE File Offset: 0x00750BBE
		public static ISplineMoveTargetType_UnionUnion FromIAssistCharacterSplineMoveTarget(IAssistCharacterSplineMoveTargetT _iassistcharactersplinemovetarget)
		{
			return new ISplineMoveTargetType_UnionUnion
			{
				Type = ISplineMoveTargetType_Union.IAssistCharacterSplineMoveTarget,
				Value = _iassistcharactersplinemovetarget
			};
		}

		// Token: 0x06036BD2 RID: 224210 RVA: 0x007529D4 File Offset: 0x00750BD4
		public static int Pack(FlatBufferBuilder builder, ISplineMoveTargetType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISplineMoveTargetType_Union.ISplineMoveTargetType:
				return ISplineMoveTargetType.Pack(builder, _o.AsISplineMoveTargetType()).Value;
			case ISplineMoveTargetType_Union.IEntitySplineMoveTarget:
				return IEntitySplineMoveTarget.Pack(builder, _o.AsIEntitySplineMoveTarget()).Value;
			case ISplineMoveTargetType_Union.IPlayerSplineMoveTarget:
				return IPlayerSplineMoveTarget.Pack(builder, _o.AsIPlayerSplineMoveTarget()).Value;
			case ISplineMoveTargetType_Union.IAssistCharacterSplineMoveTarget:
				return IAssistCharacterSplineMoveTarget.Pack(builder, _o.AsIAssistCharacterSplineMoveTarget()).Value;
			default:
				return 0;
			}
		}
	}
}

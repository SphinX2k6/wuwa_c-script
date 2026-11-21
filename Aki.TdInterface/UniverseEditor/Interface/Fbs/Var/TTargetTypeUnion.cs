using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F62 RID: 16226
	public class TTargetTypeUnion
	{
		// Token: 0x17006DC5 RID: 28101
		// (get) Token: 0x06016151 RID: 90449 RVA: 0x0032B647 File Offset: 0x00329847
		// (set) Token: 0x06016152 RID: 90450 RVA: 0x0032B64F File Offset: 0x0032984F
		public TTargetType Type { get; set; }

		// Token: 0x17006DC6 RID: 28102
		// (get) Token: 0x06016153 RID: 90451 RVA: 0x0032B658 File Offset: 0x00329858
		// (set) Token: 0x06016154 RID: 90452 RVA: 0x0032B660 File Offset: 0x00329860
		public object Value { get; set; }

		// Token: 0x06016155 RID: 90453 RVA: 0x0032B669 File Offset: 0x00329869
		public TTargetTypeUnion()
		{
			this.Type = TTargetType.NONE;
			this.Value = null;
		}

		// Token: 0x06016156 RID: 90454 RVA: 0x0032B67F File Offset: 0x0032987F
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016157 RID: 90455 RVA: 0x0032B691 File Offset: 0x00329891
		public ITargetLevelEntityT AsITargetLevelEntity()
		{
			return this.As<ITargetLevelEntityT>();
		}

		// Token: 0x06016158 RID: 90456 RVA: 0x0032B699 File Offset: 0x00329899
		public static TTargetTypeUnion FromITargetLevelEntity(ITargetLevelEntityT _itargetlevelentity)
		{
			return new TTargetTypeUnion
			{
				Type = TTargetType.ITargetLevelEntity,
				Value = _itargetlevelentity
			};
		}

		// Token: 0x06016159 RID: 90457 RVA: 0x0032B6AE File Offset: 0x003298AE
		public ITargetPlayT AsITargetPlay()
		{
			return this.As<ITargetPlayT>();
		}

		// Token: 0x0601615A RID: 90458 RVA: 0x0032B6B6 File Offset: 0x003298B6
		public static TTargetTypeUnion FromITargetPlay(ITargetPlayT _itargetplay)
		{
			return new TTargetTypeUnion
			{
				Type = TTargetType.ITargetPlay,
				Value = _itargetplay
			};
		}

		// Token: 0x0601615B RID: 90459 RVA: 0x0032B6CC File Offset: 0x003298CC
		public static int Pack(FlatBufferBuilder builder, TTargetTypeUnion _o)
		{
			TTargetType type = _o.Type;
			if (type == TTargetType.ITargetLevelEntity)
			{
				return ITargetLevelEntity.Pack(builder, _o.AsITargetLevelEntity()).Value;
			}
			if (type != TTargetType.ITargetPlay)
			{
				return 0;
			}
			return ITargetPlay.Pack(builder, _o.AsITargetPlay()).Value;
		}
	}
}

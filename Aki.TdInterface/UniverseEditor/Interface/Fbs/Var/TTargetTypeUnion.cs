using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B5A RID: 15194
	public class TTargetTypeUnion
	{
		// Token: 0x17006826 RID: 26662
		// (get) Token: 0x06014C87 RID: 85127 RVA: 0x003050AF File Offset: 0x003032AF
		// (set) Token: 0x06014C88 RID: 85128 RVA: 0x003050B7 File Offset: 0x003032B7
		public TTargetType Type { get; set; }

		// Token: 0x17006827 RID: 26663
		// (get) Token: 0x06014C89 RID: 85129 RVA: 0x003050C0 File Offset: 0x003032C0
		// (set) Token: 0x06014C8A RID: 85130 RVA: 0x003050C8 File Offset: 0x003032C8
		public object Value { get; set; }

		// Token: 0x06014C8B RID: 85131 RVA: 0x003050D1 File Offset: 0x003032D1
		public TTargetTypeUnion()
		{
			this.Type = TTargetType.NONE;
			this.Value = null;
		}

		// Token: 0x06014C8C RID: 85132 RVA: 0x003050E7 File Offset: 0x003032E7
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014C8D RID: 85133 RVA: 0x003050F9 File Offset: 0x003032F9
		public ITargetLevelEntityT AsITargetLevelEntity()
		{
			return this.As<ITargetLevelEntityT>();
		}

		// Token: 0x06014C8E RID: 85134 RVA: 0x00305101 File Offset: 0x00303301
		public static TTargetTypeUnion FromITargetLevelEntity(ITargetLevelEntityT _itargetlevelentity)
		{
			return new TTargetTypeUnion
			{
				Type = TTargetType.ITargetLevelEntity,
				Value = _itargetlevelentity
			};
		}

		// Token: 0x06014C8F RID: 85135 RVA: 0x00305116 File Offset: 0x00303316
		public ITargetPlayT AsITargetPlay()
		{
			return this.As<ITargetPlayT>();
		}

		// Token: 0x06014C90 RID: 85136 RVA: 0x0030511E File Offset: 0x0030331E
		public static TTargetTypeUnion FromITargetPlay(ITargetPlayT _itargetplay)
		{
			return new TTargetTypeUnion
			{
				Type = TTargetType.ITargetPlay,
				Value = _itargetplay
			};
		}

		// Token: 0x06014C91 RID: 85137 RVA: 0x00305134 File Offset: 0x00303334
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

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007792 RID: 30610
	public struct ISetBehaviorIsPaused : IFlatbufferObject
	{
		// Token: 0x1700E049 RID: 57417
		// (get) Token: 0x06035BAC RID: 220076 RVA: 0x00732FCE File Offset: 0x007311CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035BAD RID: 220077 RVA: 0x00732FDB File Offset: 0x007311DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035BAE RID: 220078 RVA: 0x00732FE4 File Offset: 0x007311E4
		public static ISetBehaviorIsPaused GetRootAsISetBehaviorIsPaused(ByteBuffer _bb)
		{
			return ISetBehaviorIsPaused.GetRootAsISetBehaviorIsPaused(_bb, default(ISetBehaviorIsPaused));
		}

		// Token: 0x06035BAF RID: 220079 RVA: 0x00733000 File Offset: 0x00731200
		public static ISetBehaviorIsPaused GetRootAsISetBehaviorIsPaused(ByteBuffer _bb, ISetBehaviorIsPaused obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035BB0 RID: 220080 RVA: 0x0073301D File Offset: 0x0073121D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035BB1 RID: 220081 RVA: 0x0073302C File Offset: 0x0073122C
		public ISetBehaviorIsPaused __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E04A RID: 57418
		// (get) Token: 0x06035BB2 RID: 220082 RVA: 0x0073303C File Offset: 0x0073123C
		public bool IsPaused
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06035BB3 RID: 220083 RVA: 0x0073307B File Offset: 0x0073127B
		public static Offset<ISetBehaviorIsPaused> CreateISetBehaviorIsPaused(FlatBufferBuilder builder, bool IsPaused = false)
		{
			builder.StartTable(1);
			ISetBehaviorIsPaused.AddIsPaused(builder, IsPaused);
			return ISetBehaviorIsPaused.EndISetBehaviorIsPaused(builder);
		}

		// Token: 0x06035BB4 RID: 220084 RVA: 0x00733091 File Offset: 0x00731291
		public static void StartISetBehaviorIsPaused(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035BB5 RID: 220085 RVA: 0x0073309A File Offset: 0x0073129A
		public static void AddIsPaused(FlatBufferBuilder builder, bool isPaused)
		{
			builder.AddBool(0, isPaused, false);
		}

		// Token: 0x06035BB6 RID: 220086 RVA: 0x007330A5 File Offset: 0x007312A5
		public static Offset<ISetBehaviorIsPaused> EndISetBehaviorIsPaused(FlatBufferBuilder builder)
		{
			return new Offset<ISetBehaviorIsPaused>(builder.EndTable());
		}

		// Token: 0x06035BB7 RID: 220087 RVA: 0x007330B4 File Offset: 0x007312B4
		public ISetBehaviorIsPausedT UnPack()
		{
			ISetBehaviorIsPausedT setBehaviorIsPausedT = new ISetBehaviorIsPausedT();
			this.UnPackTo(setBehaviorIsPausedT);
			return setBehaviorIsPausedT;
		}

		// Token: 0x06035BB8 RID: 220088 RVA: 0x007330CF File Offset: 0x007312CF
		public void UnPackTo(ISetBehaviorIsPausedT _o)
		{
			_o.IsPaused = this.IsPaused;
		}

		// Token: 0x06035BB9 RID: 220089 RVA: 0x007330E0 File Offset: 0x007312E0
		public static Offset<ISetBehaviorIsPaused> Pack(FlatBufferBuilder builder, ISetBehaviorIsPausedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBehaviorIsPaused>);
			}
			return ISetBehaviorIsPaused.CreateISetBehaviorIsPaused(builder, _o.IsPaused);
		}

		// Token: 0x040129B9 RID: 76217
		private Table __p;
	}
}

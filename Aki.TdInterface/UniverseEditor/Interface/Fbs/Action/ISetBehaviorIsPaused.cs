using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC9 RID: 28617
	public struct ISetBehaviorIsPaused : IFlatbufferObject
	{
		// Token: 0x1700D475 RID: 54389
		// (get) Token: 0x06032946 RID: 207174 RVA: 0x006D338A File Offset: 0x006D158A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032947 RID: 207175 RVA: 0x006D3397 File Offset: 0x006D1597
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032948 RID: 207176 RVA: 0x006D33A0 File Offset: 0x006D15A0
		public static ISetBehaviorIsPaused GetRootAsISetBehaviorIsPaused(ByteBuffer _bb)
		{
			return ISetBehaviorIsPaused.GetRootAsISetBehaviorIsPaused(_bb, default(ISetBehaviorIsPaused));
		}

		// Token: 0x06032949 RID: 207177 RVA: 0x006D33BC File Offset: 0x006D15BC
		public static ISetBehaviorIsPaused GetRootAsISetBehaviorIsPaused(ByteBuffer _bb, ISetBehaviorIsPaused obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603294A RID: 207178 RVA: 0x006D33D9 File Offset: 0x006D15D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603294B RID: 207179 RVA: 0x006D33E8 File Offset: 0x006D15E8
		public ISetBehaviorIsPaused __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D476 RID: 54390
		// (get) Token: 0x0603294C RID: 207180 RVA: 0x006D33F8 File Offset: 0x006D15F8
		public bool IsPaused
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0603294D RID: 207181 RVA: 0x006D3437 File Offset: 0x006D1637
		public static Offset<ISetBehaviorIsPaused> CreateISetBehaviorIsPaused(FlatBufferBuilder builder, bool IsPaused = false)
		{
			builder.StartTable(1);
			ISetBehaviorIsPaused.AddIsPaused(builder, IsPaused);
			return ISetBehaviorIsPaused.EndISetBehaviorIsPaused(builder);
		}

		// Token: 0x0603294E RID: 207182 RVA: 0x006D344D File Offset: 0x006D164D
		public static void StartISetBehaviorIsPaused(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603294F RID: 207183 RVA: 0x006D3456 File Offset: 0x006D1656
		public static void AddIsPaused(FlatBufferBuilder builder, bool isPaused)
		{
			builder.AddBool(0, isPaused, false);
		}

		// Token: 0x06032950 RID: 207184 RVA: 0x006D3461 File Offset: 0x006D1661
		public static Offset<ISetBehaviorIsPaused> EndISetBehaviorIsPaused(FlatBufferBuilder builder)
		{
			return new Offset<ISetBehaviorIsPaused>(builder.EndTable());
		}

		// Token: 0x06032951 RID: 207185 RVA: 0x006D3470 File Offset: 0x006D1670
		public ISetBehaviorIsPausedT UnPack()
		{
			ISetBehaviorIsPausedT setBehaviorIsPausedT = new ISetBehaviorIsPausedT();
			this.UnPackTo(setBehaviorIsPausedT);
			return setBehaviorIsPausedT;
		}

		// Token: 0x06032952 RID: 207186 RVA: 0x006D348B File Offset: 0x006D168B
		public void UnPackTo(ISetBehaviorIsPausedT _o)
		{
			_o.IsPaused = this.IsPaused;
		}

		// Token: 0x06032953 RID: 207187 RVA: 0x006D349C File Offset: 0x006D169C
		public static Offset<ISetBehaviorIsPaused> Pack(FlatBufferBuilder builder, ISetBehaviorIsPausedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBehaviorIsPaused>);
			}
			return ISetBehaviorIsPaused.CreateISetBehaviorIsPaused(builder, _o.IsPaused);
		}

		// Token: 0x040119D4 RID: 72148
		private Table __p;
	}
}

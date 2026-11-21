using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D46 RID: 27974
	public struct IEnterPatrolState : IFlatbufferObject
	{
		// Token: 0x1700CD36 RID: 52534
		// (get) Token: 0x0603040B RID: 197643 RVA: 0x0068F232 File Offset: 0x0068D432
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603040C RID: 197644 RVA: 0x0068F23F File Offset: 0x0068D43F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603040D RID: 197645 RVA: 0x0068F248 File Offset: 0x0068D448
		public static IEnterPatrolState GetRootAsIEnterPatrolState(ByteBuffer _bb)
		{
			return IEnterPatrolState.GetRootAsIEnterPatrolState(_bb, default(IEnterPatrolState));
		}

		// Token: 0x0603040E RID: 197646 RVA: 0x0068F264 File Offset: 0x0068D464
		public static IEnterPatrolState GetRootAsIEnterPatrolState(ByteBuffer _bb, IEnterPatrolState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603040F RID: 197647 RVA: 0x0068F281 File Offset: 0x0068D481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030410 RID: 197648 RVA: 0x0068F290 File Offset: 0x0068D490
		public IEnterPatrolState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030411 RID: 197649 RVA: 0x0068F2A0 File Offset: 0x0068D4A0
		public static void StartIEnterPatrolState(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06030412 RID: 197650 RVA: 0x0068F2A9 File Offset: 0x0068D4A9
		public static Offset<IEnterPatrolState> EndIEnterPatrolState(FlatBufferBuilder builder)
		{
			return new Offset<IEnterPatrolState>(builder.EndTable());
		}

		// Token: 0x06030413 RID: 197651 RVA: 0x0068F2B8 File Offset: 0x0068D4B8
		public IEnterPatrolStateT UnPack()
		{
			IEnterPatrolStateT enterPatrolStateT = new IEnterPatrolStateT();
			this.UnPackTo(enterPatrolStateT);
			return enterPatrolStateT;
		}

		// Token: 0x06030414 RID: 197652 RVA: 0x0068F2D3 File Offset: 0x0068D4D3
		public void UnPackTo(IEnterPatrolStateT _o)
		{
		}

		// Token: 0x06030415 RID: 197653 RVA: 0x0068F2D8 File Offset: 0x0068D4D8
		public static Offset<IEnterPatrolState> Pack(FlatBufferBuilder builder, IEnterPatrolStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterPatrolState>);
			}
			IEnterPatrolState.StartIEnterPatrolState(builder);
			return IEnterPatrolState.EndIEnterPatrolState(builder);
		}

		// Token: 0x04011BBD RID: 72637
		private Table __p;
	}
}

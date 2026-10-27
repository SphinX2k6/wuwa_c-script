using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066CC RID: 26316
	public struct IEnterPatrolState : IFlatbufferObject
	{
		// Token: 0x1700C385 RID: 50053
		// (get) Token: 0x0602DBEE RID: 187374 RVA: 0x00641F7E File Offset: 0x0064017E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DBEF RID: 187375 RVA: 0x00641F8B File Offset: 0x0064018B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DBF0 RID: 187376 RVA: 0x00641F94 File Offset: 0x00640194
		public static IEnterPatrolState GetRootAsIEnterPatrolState(ByteBuffer _bb)
		{
			return IEnterPatrolState.GetRootAsIEnterPatrolState(_bb, default(IEnterPatrolState));
		}

		// Token: 0x0602DBF1 RID: 187377 RVA: 0x00641FB0 File Offset: 0x006401B0
		public static IEnterPatrolState GetRootAsIEnterPatrolState(ByteBuffer _bb, IEnterPatrolState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DBF2 RID: 187378 RVA: 0x00641FCD File Offset: 0x006401CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DBF3 RID: 187379 RVA: 0x00641FDC File Offset: 0x006401DC
		public IEnterPatrolState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602DBF4 RID: 187380 RVA: 0x00641FEC File Offset: 0x006401EC
		public static void StartIEnterPatrolState(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602DBF5 RID: 187381 RVA: 0x00641FF5 File Offset: 0x006401F5
		public static Offset<IEnterPatrolState> EndIEnterPatrolState(FlatBufferBuilder builder)
		{
			return new Offset<IEnterPatrolState>(builder.EndTable());
		}

		// Token: 0x0602DBF6 RID: 187382 RVA: 0x00642004 File Offset: 0x00640204
		public IEnterPatrolStateT UnPack()
		{
			IEnterPatrolStateT enterPatrolStateT = new IEnterPatrolStateT();
			this.UnPackTo(enterPatrolStateT);
			return enterPatrolStateT;
		}

		// Token: 0x0602DBF7 RID: 187383 RVA: 0x0064201F File Offset: 0x0064021F
		public void UnPackTo(IEnterPatrolStateT _o)
		{
		}

		// Token: 0x0602DBF8 RID: 187384 RVA: 0x00642024 File Offset: 0x00640224
		public static Offset<IEnterPatrolState> Pack(FlatBufferBuilder builder, IEnterPatrolStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterPatrolState>);
			}
			IEnterPatrolState.StartIEnterPatrolState(builder);
			return IEnterPatrolState.EndIEnterPatrolState(builder);
		}

		// Token: 0x04010D97 RID: 69015
		private Table __p;
	}
}

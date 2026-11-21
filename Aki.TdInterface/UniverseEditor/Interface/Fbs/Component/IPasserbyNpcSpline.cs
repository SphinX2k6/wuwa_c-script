using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CCC RID: 23756
	public struct IPasserbyNpcSpline : IFlatbufferObject
	{
		// Token: 0x1700AE88 RID: 44680
		// (get) Token: 0x060276D5 RID: 161493 RVA: 0x005657F0 File Offset: 0x005639F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060276D6 RID: 161494 RVA: 0x005657FD File Offset: 0x005639FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060276D7 RID: 161495 RVA: 0x00565804 File Offset: 0x00563A04
		public static IPasserbyNpcSpline GetRootAsIPasserbyNpcSpline(ByteBuffer _bb)
		{
			return IPasserbyNpcSpline.GetRootAsIPasserbyNpcSpline(_bb, default(IPasserbyNpcSpline));
		}

		// Token: 0x060276D8 RID: 161496 RVA: 0x00565820 File Offset: 0x00563A20
		public static IPasserbyNpcSpline GetRootAsIPasserbyNpcSpline(ByteBuffer _bb, IPasserbyNpcSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060276D9 RID: 161497 RVA: 0x0056583D File Offset: 0x00563A3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060276DA RID: 161498 RVA: 0x0056584C File Offset: 0x00563A4C
		public IPasserbyNpcSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE89 RID: 44681
		// (get) Token: 0x060276DB RID: 161499 RVA: 0x0056585C File Offset: 0x00563A5C
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE8A RID: 44682
		// (get) Token: 0x060276DC RID: 161500 RVA: 0x00565898 File Offset: 0x00563A98
		public int SpawnWeight
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE8B RID: 44683
		// (get) Token: 0x060276DD RID: 161501 RVA: 0x005658D4 File Offset: 0x00563AD4
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AE8C RID: 44684
		// (get) Token: 0x060276DE RID: 161502 RVA: 0x00565914 File Offset: 0x00563B14
		public IPasserbyNpcMoveState? MoveState
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcMoveState?(default(IPasserbyNpcMoveState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AE8D RID: 44685
		// (get) Token: 0x060276DF RID: 161503 RVA: 0x00565974 File Offset: 0x00563B74
		public bool IsIkEnabled
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AE8E RID: 44686
		// (get) Token: 0x060276E0 RID: 161504 RVA: 0x005659B4 File Offset: 0x00563BB4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060276E1 RID: 161505 RVA: 0x005659F1 File Offset: 0x00563BF1
		public static Offset<IPasserbyNpcSpline> CreateIPasserbyNpcSpline(FlatBufferBuilder builder, int SplineEntityId = 0, int SpawnWeight = 0, bool IsLoop = false, Offset<IPasserbyNpcMoveState> MoveStateOffset = default(Offset<IPasserbyNpcMoveState>), bool IsIkEnabled = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IPasserbyNpcSpline.AddMoveState(builder, MoveStateOffset);
			IPasserbyNpcSpline.AddSpawnWeight(builder, SpawnWeight);
			IPasserbyNpcSpline.AddSplineEntityId(builder, SplineEntityId);
			IPasserbyNpcSpline.AddNullMask(builder, NullMask);
			IPasserbyNpcSpline.AddIsIkEnabled(builder, IsIkEnabled);
			IPasserbyNpcSpline.AddIsLoop(builder, IsLoop);
			return IPasserbyNpcSpline.EndIPasserbyNpcSpline(builder);
		}

		// Token: 0x060276E2 RID: 161506 RVA: 0x00565A2D File Offset: 0x00563C2D
		public static void StartIPasserbyNpcSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060276E3 RID: 161507 RVA: 0x00565A36 File Offset: 0x00563C36
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(0, splineEntityId, 0);
		}

		// Token: 0x060276E4 RID: 161508 RVA: 0x00565A41 File Offset: 0x00563C41
		public static void AddSpawnWeight(FlatBufferBuilder builder, int spawnWeight)
		{
			builder.AddInt(1, spawnWeight, 0);
		}

		// Token: 0x060276E5 RID: 161509 RVA: 0x00565A4C File Offset: 0x00563C4C
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(2, isLoop, false);
		}

		// Token: 0x060276E6 RID: 161510 RVA: 0x00565A57 File Offset: 0x00563C57
		public static void AddMoveState(FlatBufferBuilder builder, Offset<IPasserbyNpcMoveState> moveStateOffset)
		{
			builder.AddOffset(3, moveStateOffset.Value, 0);
		}

		// Token: 0x060276E7 RID: 161511 RVA: 0x00565A67 File Offset: 0x00563C67
		public static void AddIsIkEnabled(FlatBufferBuilder builder, bool isIkEnabled)
		{
			builder.AddBool(4, isIkEnabled, false);
		}

		// Token: 0x060276E8 RID: 161512 RVA: 0x00565A72 File Offset: 0x00563C72
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060276E9 RID: 161513 RVA: 0x00565A7D File Offset: 0x00563C7D
		public static Offset<IPasserbyNpcSpline> EndIPasserbyNpcSpline(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSpline>(builder.EndTable());
		}

		// Token: 0x060276EA RID: 161514 RVA: 0x00565A8C File Offset: 0x00563C8C
		public IPasserbyNpcSplineT UnPack()
		{
			IPasserbyNpcSplineT passerbyNpcSplineT = new IPasserbyNpcSplineT();
			this.UnPackTo(passerbyNpcSplineT);
			return passerbyNpcSplineT;
		}

		// Token: 0x060276EB RID: 161515 RVA: 0x00565AA8 File Offset: 0x00563CA8
		public void UnPackTo(IPasserbyNpcSplineT _o)
		{
			_o.SplineEntityId = this.SplineEntityId;
			_o.SpawnWeight = this.SpawnWeight;
			_o.IsLoop = this.IsLoop;
			_o.MoveState = ((this.MoveState != null) ? this.MoveState.Value.UnPack() : null);
			_o.IsIkEnabled = this.IsIkEnabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060276EC RID: 161516 RVA: 0x00565B20 File Offset: 0x00563D20
		public static Offset<IPasserbyNpcSpline> Pack(FlatBufferBuilder builder, IPasserbyNpcSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSpline>);
			}
			Offset<IPasserbyNpcMoveState> moveStateOffset = (_o.MoveState == null) ? default(Offset<IPasserbyNpcMoveState>) : IPasserbyNpcMoveState.Pack(builder, _o.MoveState);
			return IPasserbyNpcSpline.CreateIPasserbyNpcSpline(builder, _o.SplineEntityId, _o.SpawnWeight, _o.IsLoop, moveStateOffset, _o.IsIkEnabled, _o.NullMask);
		}

		// Token: 0x0400F7F6 RID: 63478
		private Table __p;
	}
}

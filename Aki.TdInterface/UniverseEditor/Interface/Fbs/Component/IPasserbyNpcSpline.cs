using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E0 RID: 22240
	public struct IPasserbyNpcSpline : IFlatbufferObject
	{
		// Token: 0x1700A58A RID: 42378
		// (get) Token: 0x06025284 RID: 152196 RVA: 0x00521034 File Offset: 0x0051F234
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025285 RID: 152197 RVA: 0x00521041 File Offset: 0x0051F241
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025286 RID: 152198 RVA: 0x00521048 File Offset: 0x0051F248
		public static IPasserbyNpcSpline GetRootAsIPasserbyNpcSpline(ByteBuffer _bb)
		{
			return IPasserbyNpcSpline.GetRootAsIPasserbyNpcSpline(_bb, default(IPasserbyNpcSpline));
		}

		// Token: 0x06025287 RID: 152199 RVA: 0x00521064 File Offset: 0x0051F264
		public static IPasserbyNpcSpline GetRootAsIPasserbyNpcSpline(ByteBuffer _bb, IPasserbyNpcSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025288 RID: 152200 RVA: 0x00521081 File Offset: 0x0051F281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025289 RID: 152201 RVA: 0x00521090 File Offset: 0x0051F290
		public IPasserbyNpcSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A58B RID: 42379
		// (get) Token: 0x0602528A RID: 152202 RVA: 0x005210A0 File Offset: 0x0051F2A0
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

		// Token: 0x1700A58C RID: 42380
		// (get) Token: 0x0602528B RID: 152203 RVA: 0x005210DC File Offset: 0x0051F2DC
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

		// Token: 0x1700A58D RID: 42381
		// (get) Token: 0x0602528C RID: 152204 RVA: 0x00521118 File Offset: 0x0051F318
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A58E RID: 42382
		// (get) Token: 0x0602528D RID: 152205 RVA: 0x00521158 File Offset: 0x0051F358
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

		// Token: 0x1700A58F RID: 42383
		// (get) Token: 0x0602528E RID: 152206 RVA: 0x005211B8 File Offset: 0x0051F3B8
		public bool IsIkEnabled
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A590 RID: 42384
		// (get) Token: 0x0602528F RID: 152207 RVA: 0x005211F8 File Offset: 0x0051F3F8
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

		// Token: 0x06025290 RID: 152208 RVA: 0x00521235 File Offset: 0x0051F435
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

		// Token: 0x06025291 RID: 152209 RVA: 0x00521271 File Offset: 0x0051F471
		public static void StartIPasserbyNpcSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06025292 RID: 152210 RVA: 0x0052127A File Offset: 0x0051F47A
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(0, splineEntityId, 0);
		}

		// Token: 0x06025293 RID: 152211 RVA: 0x00521285 File Offset: 0x0051F485
		public static void AddSpawnWeight(FlatBufferBuilder builder, int spawnWeight)
		{
			builder.AddInt(1, spawnWeight, 0);
		}

		// Token: 0x06025294 RID: 152212 RVA: 0x00521290 File Offset: 0x0051F490
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(2, isLoop, false);
		}

		// Token: 0x06025295 RID: 152213 RVA: 0x0052129B File Offset: 0x0051F49B
		public static void AddMoveState(FlatBufferBuilder builder, Offset<IPasserbyNpcMoveState> moveStateOffset)
		{
			builder.AddOffset(3, moveStateOffset.Value, 0);
		}

		// Token: 0x06025296 RID: 152214 RVA: 0x005212AB File Offset: 0x0051F4AB
		public static void AddIsIkEnabled(FlatBufferBuilder builder, bool isIkEnabled)
		{
			builder.AddBool(4, isIkEnabled, false);
		}

		// Token: 0x06025297 RID: 152215 RVA: 0x005212B6 File Offset: 0x0051F4B6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06025298 RID: 152216 RVA: 0x005212C1 File Offset: 0x0051F4C1
		public static Offset<IPasserbyNpcSpline> EndIPasserbyNpcSpline(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSpline>(builder.EndTable());
		}

		// Token: 0x06025299 RID: 152217 RVA: 0x005212D0 File Offset: 0x0051F4D0
		public IPasserbyNpcSplineT UnPack()
		{
			IPasserbyNpcSplineT passerbyNpcSplineT = new IPasserbyNpcSplineT();
			this.UnPackTo(passerbyNpcSplineT);
			return passerbyNpcSplineT;
		}

		// Token: 0x0602529A RID: 152218 RVA: 0x005212EC File Offset: 0x0051F4EC
		public void UnPackTo(IPasserbyNpcSplineT _o)
		{
			_o.SplineEntityId = this.SplineEntityId;
			_o.SpawnWeight = this.SpawnWeight;
			_o.IsLoop = this.IsLoop;
			_o.MoveState = ((this.MoveState != null) ? this.MoveState.Value.UnPack() : null);
			_o.IsIkEnabled = this.IsIkEnabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602529B RID: 152219 RVA: 0x00521364 File Offset: 0x0051F564
		public static Offset<IPasserbyNpcSpline> Pack(FlatBufferBuilder builder, IPasserbyNpcSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSpline>);
			}
			Offset<IPasserbyNpcMoveState> moveStateOffset = (_o.MoveState == null) ? default(Offset<IPasserbyNpcMoveState>) : IPasserbyNpcMoveState.Pack(builder, _o.MoveState);
			return IPasserbyNpcSpline.CreateIPasserbyNpcSpline(builder, _o.SplineEntityId, _o.SpawnWeight, _o.IsLoop, moveStateOffset, _o.IsIkEnabled, _o.NullMask);
		}

		// Token: 0x0400EB2C RID: 60204
		private Table __p;
	}
}

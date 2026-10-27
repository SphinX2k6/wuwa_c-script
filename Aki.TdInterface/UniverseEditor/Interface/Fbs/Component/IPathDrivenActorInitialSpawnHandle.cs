using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056EC RID: 22252
	public struct IPathDrivenActorInitialSpawnHandle : IFlatbufferObject
	{
		// Token: 0x1700A5A8 RID: 42408
		// (get) Token: 0x06025302 RID: 152322 RVA: 0x00522013 File Offset: 0x00520213
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025303 RID: 152323 RVA: 0x00522020 File Offset: 0x00520220
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025304 RID: 152324 RVA: 0x00522028 File Offset: 0x00520228
		public static IPathDrivenActorInitialSpawnHandle GetRootAsIPathDrivenActorInitialSpawnHandle(ByteBuffer _bb)
		{
			return IPathDrivenActorInitialSpawnHandle.GetRootAsIPathDrivenActorInitialSpawnHandle(_bb, default(IPathDrivenActorInitialSpawnHandle));
		}

		// Token: 0x06025305 RID: 152325 RVA: 0x00522044 File Offset: 0x00520244
		public static IPathDrivenActorInitialSpawnHandle GetRootAsIPathDrivenActorInitialSpawnHandle(ByteBuffer _bb, IPathDrivenActorInitialSpawnHandle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025306 RID: 152326 RVA: 0x00522061 File Offset: 0x00520261
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025307 RID: 152327 RVA: 0x00522070 File Offset: 0x00520270
		public IPathDrivenActorInitialSpawnHandle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5A9 RID: 42409
		// (get) Token: 0x06025308 RID: 152328 RVA: 0x00522080 File Offset: 0x00520280
		public int Index
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

		// Token: 0x1700A5AA RID: 42410
		// (get) Token: 0x06025309 RID: 152329 RVA: 0x005220BC File Offset: 0x005202BC
		public EPathDrivenActorInitialSpawnHandleType HandleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation;
				}
				return (EPathDrivenActorInitialSpawnHandleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602530A RID: 152330 RVA: 0x005220F8 File Offset: 0x005202F8
		public static Offset<IPathDrivenActorInitialSpawnHandle> CreateIPathDrivenActorInitialSpawnHandle(FlatBufferBuilder builder, int Index = 0, EPathDrivenActorInitialSpawnHandleType HandleType = EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation)
		{
			builder.StartTable(2);
			IPathDrivenActorInitialSpawnHandle.AddIndex(builder, Index);
			IPathDrivenActorInitialSpawnHandle.AddHandleType(builder, HandleType);
			return IPathDrivenActorInitialSpawnHandle.EndIPathDrivenActorInitialSpawnHandle(builder);
		}

		// Token: 0x0602530B RID: 152331 RVA: 0x00522115 File Offset: 0x00520315
		public static void StartIPathDrivenActorInitialSpawnHandle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602530C RID: 152332 RVA: 0x0052211E File Offset: 0x0052031E
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		// Token: 0x0602530D RID: 152333 RVA: 0x00522129 File Offset: 0x00520329
		public static void AddHandleType(FlatBufferBuilder builder, EPathDrivenActorInitialSpawnHandleType handleType)
		{
			builder.AddByte(1, (byte)handleType, 0);
		}

		// Token: 0x0602530E RID: 152334 RVA: 0x00522134 File Offset: 0x00520334
		public static Offset<IPathDrivenActorInitialSpawnHandle> EndIPathDrivenActorInitialSpawnHandle(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorInitialSpawnHandle>(builder.EndTable());
		}

		// Token: 0x0602530F RID: 152335 RVA: 0x00522144 File Offset: 0x00520344
		public IPathDrivenActorInitialSpawnHandleT UnPack()
		{
			IPathDrivenActorInitialSpawnHandleT pathDrivenActorInitialSpawnHandleT = new IPathDrivenActorInitialSpawnHandleT();
			this.UnPackTo(pathDrivenActorInitialSpawnHandleT);
			return pathDrivenActorInitialSpawnHandleT;
		}

		// Token: 0x06025310 RID: 152336 RVA: 0x0052215F File Offset: 0x0052035F
		public void UnPackTo(IPathDrivenActorInitialSpawnHandleT _o)
		{
			_o.Index = this.Index;
			_o.HandleType = this.HandleType;
		}

		// Token: 0x06025311 RID: 152337 RVA: 0x0052217C File Offset: 0x0052037C
		public static Offset<IPathDrivenActorInitialSpawnHandle> Pack(FlatBufferBuilder builder, IPathDrivenActorInitialSpawnHandleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathDrivenActorInitialSpawnHandle>);
			}
			return IPathDrivenActorInitialSpawnHandle.CreateIPathDrivenActorInitialSpawnHandle(builder, _o.Index, _o.HandleType);
		}

		// Token: 0x0400EB3D RID: 60221
		private Table __p;
	}
}

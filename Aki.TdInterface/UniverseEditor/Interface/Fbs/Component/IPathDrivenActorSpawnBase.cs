using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F5 RID: 22261
	public struct IPathDrivenActorSpawnBase : IFlatbufferObject
	{
		// Token: 0x1700A5B2 RID: 42418
		// (get) Token: 0x06025336 RID: 152374 RVA: 0x00522486 File Offset: 0x00520686
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025337 RID: 152375 RVA: 0x00522493 File Offset: 0x00520693
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025338 RID: 152376 RVA: 0x0052249C File Offset: 0x0052069C
		public static IPathDrivenActorSpawnBase GetRootAsIPathDrivenActorSpawnBase(ByteBuffer _bb)
		{
			return IPathDrivenActorSpawnBase.GetRootAsIPathDrivenActorSpawnBase(_bb, default(IPathDrivenActorSpawnBase));
		}

		// Token: 0x06025339 RID: 152377 RVA: 0x005224B8 File Offset: 0x005206B8
		public static IPathDrivenActorSpawnBase GetRootAsIPathDrivenActorSpawnBase(ByteBuffer _bb, IPathDrivenActorSpawnBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602533A RID: 152378 RVA: 0x005224D5 File Offset: 0x005206D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602533B RID: 152379 RVA: 0x005224E4 File Offset: 0x005206E4
		public IPathDrivenActorSpawnBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5B3 RID: 42419
		// (get) Token: 0x0602533C RID: 152380 RVA: 0x005224F4 File Offset: 0x005206F4
		public EPathDrivenActorSpawnType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPathDrivenActorSpawnType.IntervalSplineSpawn;
				}
				return (EPathDrivenActorSpawnType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602533D RID: 152381 RVA: 0x00522530 File Offset: 0x00520730
		public static Offset<IPathDrivenActorSpawnBase> CreateIPathDrivenActorSpawnBase(FlatBufferBuilder builder, EPathDrivenActorSpawnType Type = EPathDrivenActorSpawnType.IntervalSplineSpawn)
		{
			builder.StartTable(1);
			IPathDrivenActorSpawnBase.AddType(builder, Type);
			return IPathDrivenActorSpawnBase.EndIPathDrivenActorSpawnBase(builder);
		}

		// Token: 0x0602533E RID: 152382 RVA: 0x00522546 File Offset: 0x00520746
		public static void StartIPathDrivenActorSpawnBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602533F RID: 152383 RVA: 0x0052254F File Offset: 0x0052074F
		public static void AddType(FlatBufferBuilder builder, EPathDrivenActorSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025340 RID: 152384 RVA: 0x0052255A File Offset: 0x0052075A
		public static Offset<IPathDrivenActorSpawnBase> EndIPathDrivenActorSpawnBase(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorSpawnBase>(builder.EndTable());
		}

		// Token: 0x06025341 RID: 152385 RVA: 0x00522568 File Offset: 0x00520768
		public IPathDrivenActorSpawnBaseT UnPack()
		{
			IPathDrivenActorSpawnBaseT pathDrivenActorSpawnBaseT = new IPathDrivenActorSpawnBaseT();
			this.UnPackTo(pathDrivenActorSpawnBaseT);
			return pathDrivenActorSpawnBaseT;
		}

		// Token: 0x06025342 RID: 152386 RVA: 0x00522583 File Offset: 0x00520783
		public void UnPackTo(IPathDrivenActorSpawnBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025343 RID: 152387 RVA: 0x00522594 File Offset: 0x00520794
		public static Offset<IPathDrivenActorSpawnBase> Pack(FlatBufferBuilder builder, IPathDrivenActorSpawnBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathDrivenActorSpawnBase>);
			}
			return IPathDrivenActorSpawnBase.CreateIPathDrivenActorSpawnBase(builder, _o.Type);
		}

		// Token: 0x0400EB48 RID: 60232
		private Table __p;
	}
}

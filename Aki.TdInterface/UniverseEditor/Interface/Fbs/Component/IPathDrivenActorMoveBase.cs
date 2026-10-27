using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056EF RID: 22255
	public struct IPathDrivenActorMoveBase : IFlatbufferObject
	{
		// Token: 0x1700A5AD RID: 42413
		// (get) Token: 0x06025318 RID: 152344 RVA: 0x00522212 File Offset: 0x00520412
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025319 RID: 152345 RVA: 0x0052221F File Offset: 0x0052041F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602531A RID: 152346 RVA: 0x00522228 File Offset: 0x00520428
		public static IPathDrivenActorMoveBase GetRootAsIPathDrivenActorMoveBase(ByteBuffer _bb)
		{
			return IPathDrivenActorMoveBase.GetRootAsIPathDrivenActorMoveBase(_bb, default(IPathDrivenActorMoveBase));
		}

		// Token: 0x0602531B RID: 152347 RVA: 0x00522244 File Offset: 0x00520444
		public static IPathDrivenActorMoveBase GetRootAsIPathDrivenActorMoveBase(ByteBuffer _bb, IPathDrivenActorMoveBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602531C RID: 152348 RVA: 0x00522261 File Offset: 0x00520461
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602531D RID: 152349 RVA: 0x00522270 File Offset: 0x00520470
		public IPathDrivenActorMoveBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5AE RID: 42414
		// (get) Token: 0x0602531E RID: 152350 RVA: 0x00522280 File Offset: 0x00520480
		public EPathDrivenActorMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPathDrivenActorMoveType.Spline;
				}
				return (EPathDrivenActorMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602531F RID: 152351 RVA: 0x005222BC File Offset: 0x005204BC
		public static Offset<IPathDrivenActorMoveBase> CreateIPathDrivenActorMoveBase(FlatBufferBuilder builder, EPathDrivenActorMoveType Type = EPathDrivenActorMoveType.Spline)
		{
			builder.StartTable(1);
			IPathDrivenActorMoveBase.AddType(builder, Type);
			return IPathDrivenActorMoveBase.EndIPathDrivenActorMoveBase(builder);
		}

		// Token: 0x06025320 RID: 152352 RVA: 0x005222D2 File Offset: 0x005204D2
		public static void StartIPathDrivenActorMoveBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025321 RID: 152353 RVA: 0x005222DB File Offset: 0x005204DB
		public static void AddType(FlatBufferBuilder builder, EPathDrivenActorMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025322 RID: 152354 RVA: 0x005222E6 File Offset: 0x005204E6
		public static Offset<IPathDrivenActorMoveBase> EndIPathDrivenActorMoveBase(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorMoveBase>(builder.EndTable());
		}

		// Token: 0x06025323 RID: 152355 RVA: 0x005222F4 File Offset: 0x005204F4
		public IPathDrivenActorMoveBaseT UnPack()
		{
			IPathDrivenActorMoveBaseT pathDrivenActorMoveBaseT = new IPathDrivenActorMoveBaseT();
			this.UnPackTo(pathDrivenActorMoveBaseT);
			return pathDrivenActorMoveBaseT;
		}

		// Token: 0x06025324 RID: 152356 RVA: 0x0052230F File Offset: 0x0052050F
		public void UnPackTo(IPathDrivenActorMoveBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025325 RID: 152357 RVA: 0x00522320 File Offset: 0x00520520
		public static Offset<IPathDrivenActorMoveBase> Pack(FlatBufferBuilder builder, IPathDrivenActorMoveBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathDrivenActorMoveBase>);
			}
			return IPathDrivenActorMoveBase.CreateIPathDrivenActorMoveBase(builder, _o.Type);
		}

		// Token: 0x0400EB40 RID: 60224
		private Table __p;
	}
}

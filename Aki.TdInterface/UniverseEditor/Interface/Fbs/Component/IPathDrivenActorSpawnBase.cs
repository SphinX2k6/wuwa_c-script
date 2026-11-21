using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CE4 RID: 23780
	public struct IPathDrivenActorSpawnBase : IFlatbufferObject
	{
		// Token: 0x1700AEB5 RID: 44725
		// (get) Token: 0x0602779D RID: 161693 RVA: 0x00566ED2 File Offset: 0x005650D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602779E RID: 161694 RVA: 0x00566EDF File Offset: 0x005650DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602779F RID: 161695 RVA: 0x00566EE8 File Offset: 0x005650E8
		public static IPathDrivenActorSpawnBase GetRootAsIPathDrivenActorSpawnBase(ByteBuffer _bb)
		{
			return IPathDrivenActorSpawnBase.GetRootAsIPathDrivenActorSpawnBase(_bb, default(IPathDrivenActorSpawnBase));
		}

		// Token: 0x060277A0 RID: 161696 RVA: 0x00566F04 File Offset: 0x00565104
		public static IPathDrivenActorSpawnBase GetRootAsIPathDrivenActorSpawnBase(ByteBuffer _bb, IPathDrivenActorSpawnBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060277A1 RID: 161697 RVA: 0x00566F21 File Offset: 0x00565121
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060277A2 RID: 161698 RVA: 0x00566F30 File Offset: 0x00565130
		public IPathDrivenActorSpawnBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEB6 RID: 44726
		// (get) Token: 0x060277A3 RID: 161699 RVA: 0x00566F40 File Offset: 0x00565140
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

		// Token: 0x060277A4 RID: 161700 RVA: 0x00566F7C File Offset: 0x0056517C
		public static Offset<IPathDrivenActorSpawnBase> CreateIPathDrivenActorSpawnBase(FlatBufferBuilder builder, EPathDrivenActorSpawnType Type = EPathDrivenActorSpawnType.IntervalSplineSpawn)
		{
			builder.StartTable(1);
			IPathDrivenActorSpawnBase.AddType(builder, Type);
			return IPathDrivenActorSpawnBase.EndIPathDrivenActorSpawnBase(builder);
		}

		// Token: 0x060277A5 RID: 161701 RVA: 0x00566F92 File Offset: 0x00565192
		public static void StartIPathDrivenActorSpawnBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060277A6 RID: 161702 RVA: 0x00566F9B File Offset: 0x0056519B
		public static void AddType(FlatBufferBuilder builder, EPathDrivenActorSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060277A7 RID: 161703 RVA: 0x00566FA6 File Offset: 0x005651A6
		public static Offset<IPathDrivenActorSpawnBase> EndIPathDrivenActorSpawnBase(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorSpawnBase>(builder.EndTable());
		}

		// Token: 0x060277A8 RID: 161704 RVA: 0x00566FB4 File Offset: 0x005651B4
		public IPathDrivenActorSpawnBaseT UnPack()
		{
			IPathDrivenActorSpawnBaseT pathDrivenActorSpawnBaseT = new IPathDrivenActorSpawnBaseT();
			this.UnPackTo(pathDrivenActorSpawnBaseT);
			return pathDrivenActorSpawnBaseT;
		}

		// Token: 0x060277A9 RID: 161705 RVA: 0x00566FCF File Offset: 0x005651CF
		public void UnPackTo(IPathDrivenActorSpawnBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060277AA RID: 161706 RVA: 0x00566FE0 File Offset: 0x005651E0
		public static Offset<IPathDrivenActorSpawnBase> Pack(FlatBufferBuilder builder, IPathDrivenActorSpawnBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathDrivenActorSpawnBase>);
			}
			return IPathDrivenActorSpawnBase.CreateIPathDrivenActorSpawnBase(builder, _o.Type);
		}

		// Token: 0x0400F815 RID: 63509
		private Table __p;
	}
}

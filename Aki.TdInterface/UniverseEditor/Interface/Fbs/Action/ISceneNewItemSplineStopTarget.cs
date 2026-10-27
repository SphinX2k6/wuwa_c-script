using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F45 RID: 28485
	public struct ISceneNewItemSplineStopTarget : IFlatbufferObject
	{
		// Token: 0x1700D3AF RID: 54191
		// (get) Token: 0x06032533 RID: 206131 RVA: 0x006CBD02 File Offset: 0x006C9F02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032534 RID: 206132 RVA: 0x006CBD0F File Offset: 0x006C9F0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032535 RID: 206133 RVA: 0x006CBD18 File Offset: 0x006C9F18
		public static ISceneNewItemSplineStopTarget GetRootAsISceneNewItemSplineStopTarget(ByteBuffer _bb)
		{
			return ISceneNewItemSplineStopTarget.GetRootAsISceneNewItemSplineStopTarget(_bb, default(ISceneNewItemSplineStopTarget));
		}

		// Token: 0x06032536 RID: 206134 RVA: 0x006CBD34 File Offset: 0x006C9F34
		public static ISceneNewItemSplineStopTarget GetRootAsISceneNewItemSplineStopTarget(ByteBuffer _bb, ISceneNewItemSplineStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032537 RID: 206135 RVA: 0x006CBD51 File Offset: 0x006C9F51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032538 RID: 206136 RVA: 0x006CBD60 File Offset: 0x006C9F60
		public ISceneNewItemSplineStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3B0 RID: 54192
		// (get) Token: 0x06032539 RID: 206137 RVA: 0x006CBD70 File Offset: 0x006C9F70
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3B1 RID: 54193
		// (get) Token: 0x0603253A RID: 206138 RVA: 0x006CBDAC File Offset: 0x006C9FAC
		public int EntityId
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

		// Token: 0x0603253B RID: 206139 RVA: 0x006CBDE8 File Offset: 0x006C9FE8
		public static Offset<ISceneNewItemSplineStopTarget> CreateISceneNewItemSplineStopTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, int EntityId = 0)
		{
			builder.StartTable(2);
			ISceneNewItemSplineStopTarget.AddEntityId(builder, EntityId);
			ISceneNewItemSplineStopTarget.AddType(builder, Type);
			return ISceneNewItemSplineStopTarget.EndISceneNewItemSplineStopTarget(builder);
		}

		// Token: 0x0603253C RID: 206140 RVA: 0x006CBE05 File Offset: 0x006CA005
		public static void StartISceneNewItemSplineStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603253D RID: 206141 RVA: 0x006CBE0E File Offset: 0x006CA00E
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603253E RID: 206142 RVA: 0x006CBE19 File Offset: 0x006CA019
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0603253F RID: 206143 RVA: 0x006CBE24 File Offset: 0x006CA024
		public static Offset<ISceneNewItemSplineStopTarget> EndISceneNewItemSplineStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<ISceneNewItemSplineStopTarget>(builder.EndTable());
		}

		// Token: 0x06032540 RID: 206144 RVA: 0x006CBE34 File Offset: 0x006CA034
		public ISceneNewItemSplineStopTargetT UnPack()
		{
			ISceneNewItemSplineStopTargetT sceneNewItemSplineStopTargetT = new ISceneNewItemSplineStopTargetT();
			this.UnPackTo(sceneNewItemSplineStopTargetT);
			return sceneNewItemSplineStopTargetT;
		}

		// Token: 0x06032541 RID: 206145 RVA: 0x006CBE4F File Offset: 0x006CA04F
		public void UnPackTo(ISceneNewItemSplineStopTargetT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06032542 RID: 206146 RVA: 0x006CBE6C File Offset: 0x006CA06C
		public static Offset<ISceneNewItemSplineStopTarget> Pack(FlatBufferBuilder builder, ISceneNewItemSplineStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneNewItemSplineStopTarget>);
			}
			return ISceneNewItemSplineStopTarget.CreateISceneNewItemSplineStopTarget(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0401193C RID: 71996
		private Table __p;
	}
}

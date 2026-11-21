using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076CC RID: 30412
	public struct ISceneNewItemSplineStopTarget : IFlatbufferObject
	{
		// Token: 0x1700DF0B RID: 57099
		// (get) Token: 0x0603558B RID: 218507 RVA: 0x00727C6A File Offset: 0x00725E6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603558C RID: 218508 RVA: 0x00727C77 File Offset: 0x00725E77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603558D RID: 218509 RVA: 0x00727C80 File Offset: 0x00725E80
		public static ISceneNewItemSplineStopTarget GetRootAsISceneNewItemSplineStopTarget(ByteBuffer _bb)
		{
			return ISceneNewItemSplineStopTarget.GetRootAsISceneNewItemSplineStopTarget(_bb, default(ISceneNewItemSplineStopTarget));
		}

		// Token: 0x0603558E RID: 218510 RVA: 0x00727C9C File Offset: 0x00725E9C
		public static ISceneNewItemSplineStopTarget GetRootAsISceneNewItemSplineStopTarget(ByteBuffer _bb, ISceneNewItemSplineStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603558F RID: 218511 RVA: 0x00727CB9 File Offset: 0x00725EB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035590 RID: 218512 RVA: 0x00727CC8 File Offset: 0x00725EC8
		public ISceneNewItemSplineStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF0C RID: 57100
		// (get) Token: 0x06035591 RID: 218513 RVA: 0x00727CD8 File Offset: 0x00725ED8
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

		// Token: 0x1700DF0D RID: 57101
		// (get) Token: 0x06035592 RID: 218514 RVA: 0x00727D14 File Offset: 0x00725F14
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

		// Token: 0x06035593 RID: 218515 RVA: 0x00727D50 File Offset: 0x00725F50
		public static Offset<ISceneNewItemSplineStopTarget> CreateISceneNewItemSplineStopTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, int EntityId = 0)
		{
			builder.StartTable(2);
			ISceneNewItemSplineStopTarget.AddEntityId(builder, EntityId);
			ISceneNewItemSplineStopTarget.AddType(builder, Type);
			return ISceneNewItemSplineStopTarget.EndISceneNewItemSplineStopTarget(builder);
		}

		// Token: 0x06035594 RID: 218516 RVA: 0x00727D6D File Offset: 0x00725F6D
		public static void StartISceneNewItemSplineStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035595 RID: 218517 RVA: 0x00727D76 File Offset: 0x00725F76
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035596 RID: 218518 RVA: 0x00727D81 File Offset: 0x00725F81
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06035597 RID: 218519 RVA: 0x00727D8C File Offset: 0x00725F8C
		public static Offset<ISceneNewItemSplineStopTarget> EndISceneNewItemSplineStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<ISceneNewItemSplineStopTarget>(builder.EndTable());
		}

		// Token: 0x06035598 RID: 218520 RVA: 0x00727D9C File Offset: 0x00725F9C
		public ISceneNewItemSplineStopTargetT UnPack()
		{
			ISceneNewItemSplineStopTargetT sceneNewItemSplineStopTargetT = new ISceneNewItemSplineStopTargetT();
			this.UnPackTo(sceneNewItemSplineStopTargetT);
			return sceneNewItemSplineStopTargetT;
		}

		// Token: 0x06035599 RID: 218521 RVA: 0x00727DB7 File Offset: 0x00725FB7
		public void UnPackTo(ISceneNewItemSplineStopTargetT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0603559A RID: 218522 RVA: 0x00727DD4 File Offset: 0x00725FD4
		public static Offset<ISceneNewItemSplineStopTarget> Pack(FlatBufferBuilder builder, ISceneNewItemSplineStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneNewItemSplineStopTarget>);
			}
			return ISceneNewItemSplineStopTarget.CreateISceneNewItemSplineStopTarget(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x040128C4 RID: 75972
		private Table __p;
	}
}

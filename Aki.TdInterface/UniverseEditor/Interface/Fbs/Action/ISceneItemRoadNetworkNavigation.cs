using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C9 RID: 30409
	public struct ISceneItemRoadNetworkNavigation : IFlatbufferObject
	{
		// Token: 0x1700DF06 RID: 57094
		// (get) Token: 0x06035575 RID: 218485 RVA: 0x00727A6C File Offset: 0x00725C6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035576 RID: 218486 RVA: 0x00727A79 File Offset: 0x00725C79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035577 RID: 218487 RVA: 0x00727A80 File Offset: 0x00725C80
		public static ISceneItemRoadNetworkNavigation GetRootAsISceneItemRoadNetworkNavigation(ByteBuffer _bb)
		{
			return ISceneItemRoadNetworkNavigation.GetRootAsISceneItemRoadNetworkNavigation(_bb, default(ISceneItemRoadNetworkNavigation));
		}

		// Token: 0x06035578 RID: 218488 RVA: 0x00727A9C File Offset: 0x00725C9C
		public static ISceneItemRoadNetworkNavigation GetRootAsISceneItemRoadNetworkNavigation(ByteBuffer _bb, ISceneItemRoadNetworkNavigation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035579 RID: 218489 RVA: 0x00727AB9 File Offset: 0x00725CB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603557A RID: 218490 RVA: 0x00727AC8 File Offset: 0x00725CC8
		public ISceneItemRoadNetworkNavigation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF07 RID: 57095
		// (get) Token: 0x0603557B RID: 218491 RVA: 0x00727AD8 File Offset: 0x00725CD8
		public ERoadNetworkNavigationTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoadNetworkNavigationTarget.SceneItem;
				}
				return (ERoadNetworkNavigationTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DF08 RID: 57096
		// (get) Token: 0x0603557C RID: 218492 RVA: 0x00727B14 File Offset: 0x00725D14
		public int TargetId
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

		// Token: 0x0603557D RID: 218493 RVA: 0x00727B50 File Offset: 0x00725D50
		public static Offset<ISceneItemRoadNetworkNavigation> CreateISceneItemRoadNetworkNavigation(FlatBufferBuilder builder, ERoadNetworkNavigationTarget Type = ERoadNetworkNavigationTarget.SceneItem, int TargetId = 0)
		{
			builder.StartTable(2);
			ISceneItemRoadNetworkNavigation.AddTargetId(builder, TargetId);
			ISceneItemRoadNetworkNavigation.AddType(builder, Type);
			return ISceneItemRoadNetworkNavigation.EndISceneItemRoadNetworkNavigation(builder);
		}

		// Token: 0x0603557E RID: 218494 RVA: 0x00727B6D File Offset: 0x00725D6D
		public static void StartISceneItemRoadNetworkNavigation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603557F RID: 218495 RVA: 0x00727B76 File Offset: 0x00725D76
		public static void AddType(FlatBufferBuilder builder, ERoadNetworkNavigationTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035580 RID: 218496 RVA: 0x00727B81 File Offset: 0x00725D81
		public static void AddTargetId(FlatBufferBuilder builder, int targetId)
		{
			builder.AddInt(1, targetId, 0);
		}

		// Token: 0x06035581 RID: 218497 RVA: 0x00727B8C File Offset: 0x00725D8C
		public static Offset<ISceneItemRoadNetworkNavigation> EndISceneItemRoadNetworkNavigation(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemRoadNetworkNavigation>(builder.EndTable());
		}

		// Token: 0x06035582 RID: 218498 RVA: 0x00727B9C File Offset: 0x00725D9C
		public ISceneItemRoadNetworkNavigationT UnPack()
		{
			ISceneItemRoadNetworkNavigationT sceneItemRoadNetworkNavigationT = new ISceneItemRoadNetworkNavigationT();
			this.UnPackTo(sceneItemRoadNetworkNavigationT);
			return sceneItemRoadNetworkNavigationT;
		}

		// Token: 0x06035583 RID: 218499 RVA: 0x00727BB7 File Offset: 0x00725DB7
		public void UnPackTo(ISceneItemRoadNetworkNavigationT _o)
		{
			_o.Type = this.Type;
			_o.TargetId = this.TargetId;
		}

		// Token: 0x06035584 RID: 218500 RVA: 0x00727BD4 File Offset: 0x00725DD4
		public static Offset<ISceneItemRoadNetworkNavigation> Pack(FlatBufferBuilder builder, ISceneItemRoadNetworkNavigationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemRoadNetworkNavigation>);
			}
			return ISceneItemRoadNetworkNavigation.CreateISceneItemRoadNetworkNavigation(builder, _o.Type, _o.TargetId);
		}

		// Token: 0x040128C1 RID: 75969
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F42 RID: 28482
	public struct ISceneItemRoadNetworkNavigation : IFlatbufferObject
	{
		// Token: 0x1700D3AA RID: 54186
		// (get) Token: 0x0603251D RID: 206109 RVA: 0x006CBB04 File Offset: 0x006C9D04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603251E RID: 206110 RVA: 0x006CBB11 File Offset: 0x006C9D11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603251F RID: 206111 RVA: 0x006CBB18 File Offset: 0x006C9D18
		public static ISceneItemRoadNetworkNavigation GetRootAsISceneItemRoadNetworkNavigation(ByteBuffer _bb)
		{
			return ISceneItemRoadNetworkNavigation.GetRootAsISceneItemRoadNetworkNavigation(_bb, default(ISceneItemRoadNetworkNavigation));
		}

		// Token: 0x06032520 RID: 206112 RVA: 0x006CBB34 File Offset: 0x006C9D34
		public static ISceneItemRoadNetworkNavigation GetRootAsISceneItemRoadNetworkNavigation(ByteBuffer _bb, ISceneItemRoadNetworkNavigation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032521 RID: 206113 RVA: 0x006CBB51 File Offset: 0x006C9D51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032522 RID: 206114 RVA: 0x006CBB60 File Offset: 0x006C9D60
		public ISceneItemRoadNetworkNavigation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3AB RID: 54187
		// (get) Token: 0x06032523 RID: 206115 RVA: 0x006CBB70 File Offset: 0x006C9D70
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

		// Token: 0x1700D3AC RID: 54188
		// (get) Token: 0x06032524 RID: 206116 RVA: 0x006CBBAC File Offset: 0x006C9DAC
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

		// Token: 0x06032525 RID: 206117 RVA: 0x006CBBE8 File Offset: 0x006C9DE8
		public static Offset<ISceneItemRoadNetworkNavigation> CreateISceneItemRoadNetworkNavigation(FlatBufferBuilder builder, ERoadNetworkNavigationTarget Type = ERoadNetworkNavigationTarget.SceneItem, int TargetId = 0)
		{
			builder.StartTable(2);
			ISceneItemRoadNetworkNavigation.AddTargetId(builder, TargetId);
			ISceneItemRoadNetworkNavigation.AddType(builder, Type);
			return ISceneItemRoadNetworkNavigation.EndISceneItemRoadNetworkNavigation(builder);
		}

		// Token: 0x06032526 RID: 206118 RVA: 0x006CBC05 File Offset: 0x006C9E05
		public static void StartISceneItemRoadNetworkNavigation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032527 RID: 206119 RVA: 0x006CBC0E File Offset: 0x006C9E0E
		public static void AddType(FlatBufferBuilder builder, ERoadNetworkNavigationTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032528 RID: 206120 RVA: 0x006CBC19 File Offset: 0x006C9E19
		public static void AddTargetId(FlatBufferBuilder builder, int targetId)
		{
			builder.AddInt(1, targetId, 0);
		}

		// Token: 0x06032529 RID: 206121 RVA: 0x006CBC24 File Offset: 0x006C9E24
		public static Offset<ISceneItemRoadNetworkNavigation> EndISceneItemRoadNetworkNavigation(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemRoadNetworkNavigation>(builder.EndTable());
		}

		// Token: 0x0603252A RID: 206122 RVA: 0x006CBC34 File Offset: 0x006C9E34
		public ISceneItemRoadNetworkNavigationT UnPack()
		{
			ISceneItemRoadNetworkNavigationT sceneItemRoadNetworkNavigationT = new ISceneItemRoadNetworkNavigationT();
			this.UnPackTo(sceneItemRoadNetworkNavigationT);
			return sceneItemRoadNetworkNavigationT;
		}

		// Token: 0x0603252B RID: 206123 RVA: 0x006CBC4F File Offset: 0x006C9E4F
		public void UnPackTo(ISceneItemRoadNetworkNavigationT _o)
		{
			_o.Type = this.Type;
			_o.TargetId = this.TargetId;
		}

		// Token: 0x0603252C RID: 206124 RVA: 0x006CBC6C File Offset: 0x006C9E6C
		public static Offset<ISceneItemRoadNetworkNavigation> Pack(FlatBufferBuilder builder, ISceneItemRoadNetworkNavigationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemRoadNetworkNavigation>);
			}
			return ISceneItemRoadNetworkNavigation.CreateISceneItemRoadNetworkNavigation(builder, _o.Type, _o.TargetId);
		}

		// Token: 0x04011939 RID: 71993
		private Table __p;
	}
}

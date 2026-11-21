using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007657 RID: 30295
	public struct IRoadNetworkNavigationTarget : IFlatbufferObject
	{
		// Token: 0x1700DE77 RID: 56951
		// (get) Token: 0x06035279 RID: 217721 RVA: 0x00722E0A File Offset: 0x0072100A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603527A RID: 217722 RVA: 0x00722E17 File Offset: 0x00721017
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603527B RID: 217723 RVA: 0x00722E20 File Offset: 0x00721020
		public static IRoadNetworkNavigationTarget GetRootAsIRoadNetworkNavigationTarget(ByteBuffer _bb)
		{
			return IRoadNetworkNavigationTarget.GetRootAsIRoadNetworkNavigationTarget(_bb, default(IRoadNetworkNavigationTarget));
		}

		// Token: 0x0603527C RID: 217724 RVA: 0x00722E3C File Offset: 0x0072103C
		public static IRoadNetworkNavigationTarget GetRootAsIRoadNetworkNavigationTarget(ByteBuffer _bb, IRoadNetworkNavigationTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603527D RID: 217725 RVA: 0x00722E59 File Offset: 0x00721059
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603527E RID: 217726 RVA: 0x00722E68 File Offset: 0x00721068
		public IRoadNetworkNavigationTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE78 RID: 56952
		// (get) Token: 0x0603527F RID: 217727 RVA: 0x00722E78 File Offset: 0x00721078
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

		// Token: 0x06035280 RID: 217728 RVA: 0x00722EB4 File Offset: 0x007210B4
		public static Offset<IRoadNetworkNavigationTarget> CreateIRoadNetworkNavigationTarget(FlatBufferBuilder builder, ERoadNetworkNavigationTarget Type = ERoadNetworkNavigationTarget.SceneItem)
		{
			builder.StartTable(1);
			IRoadNetworkNavigationTarget.AddType(builder, Type);
			return IRoadNetworkNavigationTarget.EndIRoadNetworkNavigationTarget(builder);
		}

		// Token: 0x06035281 RID: 217729 RVA: 0x00722ECA File Offset: 0x007210CA
		public static void StartIRoadNetworkNavigationTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035282 RID: 217730 RVA: 0x00722ED3 File Offset: 0x007210D3
		public static void AddType(FlatBufferBuilder builder, ERoadNetworkNavigationTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035283 RID: 217731 RVA: 0x00722EDE File Offset: 0x007210DE
		public static Offset<IRoadNetworkNavigationTarget> EndIRoadNetworkNavigationTarget(FlatBufferBuilder builder)
		{
			return new Offset<IRoadNetworkNavigationTarget>(builder.EndTable());
		}

		// Token: 0x06035284 RID: 217732 RVA: 0x00722EEC File Offset: 0x007210EC
		public IRoadNetworkNavigationTargetT UnPack()
		{
			IRoadNetworkNavigationTargetT roadNetworkNavigationTargetT = new IRoadNetworkNavigationTargetT();
			this.UnPackTo(roadNetworkNavigationTargetT);
			return roadNetworkNavigationTargetT;
		}

		// Token: 0x06035285 RID: 217733 RVA: 0x00722F07 File Offset: 0x00721107
		public void UnPackTo(IRoadNetworkNavigationTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035286 RID: 217734 RVA: 0x00722F18 File Offset: 0x00721118
		public static Offset<IRoadNetworkNavigationTarget> Pack(FlatBufferBuilder builder, IRoadNetworkNavigationTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoadNetworkNavigationTarget>);
			}
			return IRoadNetworkNavigationTarget.CreateIRoadNetworkNavigationTarget(builder, _o.Type);
		}

		// Token: 0x0401284C RID: 75852
		private Table __p;
	}
}

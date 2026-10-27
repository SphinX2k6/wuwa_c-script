using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED3 RID: 28371
	public struct IRoadNetworkNavigationTarget : IFlatbufferObject
	{
		// Token: 0x1700D320 RID: 54048
		// (get) Token: 0x06032239 RID: 205369 RVA: 0x006C70D6 File Offset: 0x006C52D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603223A RID: 205370 RVA: 0x006C70E3 File Offset: 0x006C52E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603223B RID: 205371 RVA: 0x006C70EC File Offset: 0x006C52EC
		public static IRoadNetworkNavigationTarget GetRootAsIRoadNetworkNavigationTarget(ByteBuffer _bb)
		{
			return IRoadNetworkNavigationTarget.GetRootAsIRoadNetworkNavigationTarget(_bb, default(IRoadNetworkNavigationTarget));
		}

		// Token: 0x0603223C RID: 205372 RVA: 0x006C7108 File Offset: 0x006C5308
		public static IRoadNetworkNavigationTarget GetRootAsIRoadNetworkNavigationTarget(ByteBuffer _bb, IRoadNetworkNavigationTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603223D RID: 205373 RVA: 0x006C7125 File Offset: 0x006C5325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603223E RID: 205374 RVA: 0x006C7134 File Offset: 0x006C5334
		public IRoadNetworkNavigationTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D321 RID: 54049
		// (get) Token: 0x0603223F RID: 205375 RVA: 0x006C7144 File Offset: 0x006C5344
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

		// Token: 0x06032240 RID: 205376 RVA: 0x006C7180 File Offset: 0x006C5380
		public static Offset<IRoadNetworkNavigationTarget> CreateIRoadNetworkNavigationTarget(FlatBufferBuilder builder, ERoadNetworkNavigationTarget Type = ERoadNetworkNavigationTarget.SceneItem)
		{
			builder.StartTable(1);
			IRoadNetworkNavigationTarget.AddType(builder, Type);
			return IRoadNetworkNavigationTarget.EndIRoadNetworkNavigationTarget(builder);
		}

		// Token: 0x06032241 RID: 205377 RVA: 0x006C7196 File Offset: 0x006C5396
		public static void StartIRoadNetworkNavigationTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032242 RID: 205378 RVA: 0x006C719F File Offset: 0x006C539F
		public static void AddType(FlatBufferBuilder builder, ERoadNetworkNavigationTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032243 RID: 205379 RVA: 0x006C71AA File Offset: 0x006C53AA
		public static Offset<IRoadNetworkNavigationTarget> EndIRoadNetworkNavigationTarget(FlatBufferBuilder builder)
		{
			return new Offset<IRoadNetworkNavigationTarget>(builder.EndTable());
		}

		// Token: 0x06032244 RID: 205380 RVA: 0x006C71B8 File Offset: 0x006C53B8
		public IRoadNetworkNavigationTargetT UnPack()
		{
			IRoadNetworkNavigationTargetT roadNetworkNavigationTargetT = new IRoadNetworkNavigationTargetT();
			this.UnPackTo(roadNetworkNavigationTargetT);
			return roadNetworkNavigationTargetT;
		}

		// Token: 0x06032245 RID: 205381 RVA: 0x006C71D3 File Offset: 0x006C53D3
		public void UnPackTo(IRoadNetworkNavigationTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032246 RID: 205382 RVA: 0x006C71E4 File Offset: 0x006C53E4
		public static Offset<IRoadNetworkNavigationTarget> Pack(FlatBufferBuilder builder, IRoadNetworkNavigationTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoadNetworkNavigationTarget>);
			}
			return IRoadNetworkNavigationTarget.CreateIRoadNetworkNavigationTarget(builder, _o.Type);
		}

		// Token: 0x040118C7 RID: 71879
		private Table __p;
	}
}

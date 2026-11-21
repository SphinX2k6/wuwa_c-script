using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005379 RID: 21369
	public struct IAdsortTransform : IFlatbufferObject
	{
		// Token: 0x170096E8 RID: 38632
		// (get) Token: 0x0602149D RID: 136349 RVA: 0x00497D82 File Offset: 0x00495F82
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602149E RID: 136350 RVA: 0x00497D8F File Offset: 0x00495F8F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602149F RID: 136351 RVA: 0x00497D98 File Offset: 0x00495F98
		public static IAdsortTransform GetRootAsIAdsortTransform(ByteBuffer _bb)
		{
			return IAdsortTransform.GetRootAsIAdsortTransform(_bb, default(IAdsortTransform));
		}

		// Token: 0x060214A0 RID: 136352 RVA: 0x00497DB4 File Offset: 0x00495FB4
		public static IAdsortTransform GetRootAsIAdsortTransform(ByteBuffer _bb, IAdsortTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060214A1 RID: 136353 RVA: 0x00497DD1 File Offset: 0x00495FD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060214A2 RID: 136354 RVA: 0x00497DE0 File Offset: 0x00495FE0
		public IAdsortTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096E9 RID: 38633
		// (get) Token: 0x060214A3 RID: 136355 RVA: 0x00497DF0 File Offset: 0x00495FF0
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170096EA RID: 38634
		// (get) Token: 0x060214A4 RID: 136356 RVA: 0x00497E50 File Offset: 0x00496050
		public IVectorInfo? Rot
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060214A5 RID: 136357 RVA: 0x00497EAD File Offset: 0x004960AD
		public static Offset<IAdsortTransform> CreateIAdsortTransform(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IAdsortTransform.AddRot(builder, RotOffset);
			IAdsortTransform.AddPos(builder, PosOffset);
			return IAdsortTransform.EndIAdsortTransform(builder);
		}

		// Token: 0x060214A6 RID: 136358 RVA: 0x00497ECA File Offset: 0x004960CA
		public static void StartIAdsortTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060214A7 RID: 136359 RVA: 0x00497ED3 File Offset: 0x004960D3
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x060214A8 RID: 136360 RVA: 0x00497EE3 File Offset: 0x004960E3
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x060214A9 RID: 136361 RVA: 0x00497EF3 File Offset: 0x004960F3
		public static Offset<IAdsortTransform> EndIAdsortTransform(FlatBufferBuilder builder)
		{
			return new Offset<IAdsortTransform>(builder.EndTable());
		}

		// Token: 0x060214AA RID: 136362 RVA: 0x00497F00 File Offset: 0x00496100
		public IAdsortTransformT UnPack()
		{
			IAdsortTransformT adsortTransformT = new IAdsortTransformT();
			this.UnPackTo(adsortTransformT);
			return adsortTransformT;
		}

		// Token: 0x060214AB RID: 136363 RVA: 0x00497F1C File Offset: 0x0049611C
		public void UnPackTo(IAdsortTransformT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x060214AC RID: 136364 RVA: 0x00497F88 File Offset: 0x00496188
		public static Offset<IAdsortTransform> Pack(FlatBufferBuilder builder, IAdsortTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdsortTransform>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return IAdsortTransform.CreateIAdsortTransform(builder, posOffset, rotOffset);
		}

		// Token: 0x0400E78B RID: 59275
		private Table __p;
	}
}

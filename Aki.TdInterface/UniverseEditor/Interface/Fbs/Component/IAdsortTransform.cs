using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E68 RID: 20072
	public struct IAdsortTransform : IFlatbufferObject
	{
		// Token: 0x17008FAF RID: 36783
		// (get) Token: 0x0601F852 RID: 129106 RVA: 0x00463D6A File Offset: 0x00461F6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F853 RID: 129107 RVA: 0x00463D77 File Offset: 0x00461F77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F854 RID: 129108 RVA: 0x00463D80 File Offset: 0x00461F80
		public static IAdsortTransform GetRootAsIAdsortTransform(ByteBuffer _bb)
		{
			return IAdsortTransform.GetRootAsIAdsortTransform(_bb, default(IAdsortTransform));
		}

		// Token: 0x0601F855 RID: 129109 RVA: 0x00463D9C File Offset: 0x00461F9C
		public static IAdsortTransform GetRootAsIAdsortTransform(ByteBuffer _bb, IAdsortTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F856 RID: 129110 RVA: 0x00463DB9 File Offset: 0x00461FB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F857 RID: 129111 RVA: 0x00463DC8 File Offset: 0x00461FC8
		public IAdsortTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FB0 RID: 36784
		// (get) Token: 0x0601F858 RID: 129112 RVA: 0x00463DD8 File Offset: 0x00461FD8
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

		// Token: 0x17008FB1 RID: 36785
		// (get) Token: 0x0601F859 RID: 129113 RVA: 0x00463E38 File Offset: 0x00462038
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

		// Token: 0x0601F85A RID: 129114 RVA: 0x00463E95 File Offset: 0x00462095
		public static Offset<IAdsortTransform> CreateIAdsortTransform(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IAdsortTransform.AddRot(builder, RotOffset);
			IAdsortTransform.AddPos(builder, PosOffset);
			return IAdsortTransform.EndIAdsortTransform(builder);
		}

		// Token: 0x0601F85B RID: 129115 RVA: 0x00463EB2 File Offset: 0x004620B2
		public static void StartIAdsortTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F85C RID: 129116 RVA: 0x00463EBB File Offset: 0x004620BB
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x0601F85D RID: 129117 RVA: 0x00463ECB File Offset: 0x004620CB
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x0601F85E RID: 129118 RVA: 0x00463EDB File Offset: 0x004620DB
		public static Offset<IAdsortTransform> EndIAdsortTransform(FlatBufferBuilder builder)
		{
			return new Offset<IAdsortTransform>(builder.EndTable());
		}

		// Token: 0x0601F85F RID: 129119 RVA: 0x00463EE8 File Offset: 0x004620E8
		public IAdsortTransformT UnPack()
		{
			IAdsortTransformT adsortTransformT = new IAdsortTransformT();
			this.UnPackTo(adsortTransformT);
			return adsortTransformT;
		}

		// Token: 0x0601F860 RID: 129120 RVA: 0x00463F04 File Offset: 0x00462104
		public void UnPackTo(IAdsortTransformT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x0601F861 RID: 129121 RVA: 0x00463F70 File Offset: 0x00462170
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

		// Token: 0x0400DC11 RID: 56337
		private Table __p;
	}
}

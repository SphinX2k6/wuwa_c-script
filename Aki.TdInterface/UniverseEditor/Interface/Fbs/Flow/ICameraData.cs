using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004727 RID: 18215
	public struct ICameraData : IFlatbufferObject
	{
		// Token: 0x1700828D RID: 33421
		// (get) Token: 0x0601BFC5 RID: 114629 RVA: 0x003F749F File Offset: 0x003F569F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BFC6 RID: 114630 RVA: 0x003F74AC File Offset: 0x003F56AC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BFC7 RID: 114631 RVA: 0x003F74B4 File Offset: 0x003F56B4
		public static ICameraData GetRootAsICameraData(ByteBuffer _bb)
		{
			return ICameraData.GetRootAsICameraData(_bb, default(ICameraData));
		}

		// Token: 0x0601BFC8 RID: 114632 RVA: 0x003F74D0 File Offset: 0x003F56D0
		public static ICameraData GetRootAsICameraData(ByteBuffer _bb, ICameraData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BFC9 RID: 114633 RVA: 0x003F74ED File Offset: 0x003F56ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BFCA RID: 114634 RVA: 0x003F74FC File Offset: 0x003F56FC
		public ICameraData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700828E RID: 33422
		// (get) Token: 0x0601BFCB RID: 114635 RVA: 0x003F750C File Offset: 0x003F570C
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

		// Token: 0x1700828F RID: 33423
		// (get) Token: 0x0601BFCC RID: 114636 RVA: 0x003F756C File Offset: 0x003F576C
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

		// Token: 0x0601BFCD RID: 114637 RVA: 0x003F75C9 File Offset: 0x003F57C9
		public static Offset<ICameraData> CreateICameraData(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ICameraData.AddRot(builder, RotOffset);
			ICameraData.AddPos(builder, PosOffset);
			return ICameraData.EndICameraData(builder);
		}

		// Token: 0x0601BFCE RID: 114638 RVA: 0x003F75E6 File Offset: 0x003F57E6
		public static void StartICameraData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BFCF RID: 114639 RVA: 0x003F75EF File Offset: 0x003F57EF
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x0601BFD0 RID: 114640 RVA: 0x003F75FF File Offset: 0x003F57FF
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x0601BFD1 RID: 114641 RVA: 0x003F760F File Offset: 0x003F580F
		public static Offset<ICameraData> EndICameraData(FlatBufferBuilder builder)
		{
			return new Offset<ICameraData>(builder.EndTable());
		}

		// Token: 0x0601BFD2 RID: 114642 RVA: 0x003F761C File Offset: 0x003F581C
		public ICameraDataT UnPack()
		{
			ICameraDataT cameraDataT = new ICameraDataT();
			this.UnPackTo(cameraDataT);
			return cameraDataT;
		}

		// Token: 0x0601BFD3 RID: 114643 RVA: 0x003F7638 File Offset: 0x003F5838
		public void UnPackTo(ICameraDataT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x0601BFD4 RID: 114644 RVA: 0x003F76A4 File Offset: 0x003F58A4
		public static Offset<ICameraData> Pack(FlatBufferBuilder builder, ICameraDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraData>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return ICameraData.CreateICameraData(builder, posOffset, rotOffset);
		}

		// Token: 0x0400CA00 RID: 51712
		private Table __p;
	}
}

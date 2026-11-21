using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B8F RID: 19343
	public struct ICameraData : IFlatbufferObject
	{
		// Token: 0x170088CE RID: 35022
		// (get) Token: 0x0601D79A RID: 120730 RVA: 0x0042373B File Offset: 0x0042193B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D79B RID: 120731 RVA: 0x00423748 File Offset: 0x00421948
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D79C RID: 120732 RVA: 0x00423750 File Offset: 0x00421950
		public static ICameraData GetRootAsICameraData(ByteBuffer _bb)
		{
			return ICameraData.GetRootAsICameraData(_bb, default(ICameraData));
		}

		// Token: 0x0601D79D RID: 120733 RVA: 0x0042376C File Offset: 0x0042196C
		public static ICameraData GetRootAsICameraData(ByteBuffer _bb, ICameraData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D79E RID: 120734 RVA: 0x00423789 File Offset: 0x00421989
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D79F RID: 120735 RVA: 0x00423798 File Offset: 0x00421998
		public ICameraData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088CF RID: 35023
		// (get) Token: 0x0601D7A0 RID: 120736 RVA: 0x004237A8 File Offset: 0x004219A8
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

		// Token: 0x170088D0 RID: 35024
		// (get) Token: 0x0601D7A1 RID: 120737 RVA: 0x00423808 File Offset: 0x00421A08
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

		// Token: 0x0601D7A2 RID: 120738 RVA: 0x00423865 File Offset: 0x00421A65
		public static Offset<ICameraData> CreateICameraData(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ICameraData.AddRot(builder, RotOffset);
			ICameraData.AddPos(builder, PosOffset);
			return ICameraData.EndICameraData(builder);
		}

		// Token: 0x0601D7A3 RID: 120739 RVA: 0x00423882 File Offset: 0x00421A82
		public static void StartICameraData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D7A4 RID: 120740 RVA: 0x0042388B File Offset: 0x00421A8B
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x0601D7A5 RID: 120741 RVA: 0x0042389B File Offset: 0x00421A9B
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x0601D7A6 RID: 120742 RVA: 0x004238AB File Offset: 0x00421AAB
		public static Offset<ICameraData> EndICameraData(FlatBufferBuilder builder)
		{
			return new Offset<ICameraData>(builder.EndTable());
		}

		// Token: 0x0601D7A7 RID: 120743 RVA: 0x004238B8 File Offset: 0x00421AB8
		public ICameraDataT UnPack()
		{
			ICameraDataT cameraDataT = new ICameraDataT();
			this.UnPackTo(cameraDataT);
			return cameraDataT;
		}

		// Token: 0x0601D7A8 RID: 120744 RVA: 0x004238D4 File Offset: 0x00421AD4
		public void UnPackTo(ICameraDataT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x0601D7A9 RID: 120745 RVA: 0x00423940 File Offset: 0x00421B40
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

		// Token: 0x0400D42F RID: 54319
		private Table __p;
	}
}

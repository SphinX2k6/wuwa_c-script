using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD9 RID: 28121
	public struct IFaceToPos : IFlatbufferObject
	{
		// Token: 0x1700CE1F RID: 52767
		// (get) Token: 0x060308A7 RID: 198823 RVA: 0x00697880 File Offset: 0x00695A80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060308A8 RID: 198824 RVA: 0x0069788D File Offset: 0x00695A8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060308A9 RID: 198825 RVA: 0x00697894 File Offset: 0x00695A94
		public static IFaceToPos GetRootAsIFaceToPos(ByteBuffer _bb)
		{
			return IFaceToPos.GetRootAsIFaceToPos(_bb, default(IFaceToPos));
		}

		// Token: 0x060308AA RID: 198826 RVA: 0x006978B0 File Offset: 0x00695AB0
		public static IFaceToPos GetRootAsIFaceToPos(ByteBuffer _bb, IFaceToPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060308AB RID: 198827 RVA: 0x006978CD File Offset: 0x00695ACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060308AC RID: 198828 RVA: 0x006978DC File Offset: 0x00695ADC
		public IFaceToPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE20 RID: 52768
		// (get) Token: 0x060308AD RID: 198829 RVA: 0x006978EC File Offset: 0x00695AEC
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

		// Token: 0x060308AE RID: 198830 RVA: 0x00697949 File Offset: 0x00695B49
		public static Offset<IFaceToPos> CreateIFaceToPos(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(1);
			IFaceToPos.AddPos(builder, PosOffset);
			return IFaceToPos.EndIFaceToPos(builder);
		}

		// Token: 0x060308AF RID: 198831 RVA: 0x0069795F File Offset: 0x00695B5F
		public static void StartIFaceToPos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060308B0 RID: 198832 RVA: 0x00697968 File Offset: 0x00695B68
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x060308B1 RID: 198833 RVA: 0x00697978 File Offset: 0x00695B78
		public static Offset<IFaceToPos> EndIFaceToPos(FlatBufferBuilder builder)
		{
			return new Offset<IFaceToPos>(builder.EndTable());
		}

		// Token: 0x060308B2 RID: 198834 RVA: 0x00697988 File Offset: 0x00695B88
		public IFaceToPosT UnPack()
		{
			IFaceToPosT faceToPosT = new IFaceToPosT();
			this.UnPackTo(faceToPosT);
			return faceToPosT;
		}

		// Token: 0x060308B3 RID: 198835 RVA: 0x006979A4 File Offset: 0x00695BA4
		public void UnPackTo(IFaceToPosT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x060308B4 RID: 198836 RVA: 0x006979E0 File Offset: 0x00695BE0
		public static Offset<IFaceToPos> Pack(FlatBufferBuilder builder, IFaceToPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceToPos>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IFaceToPos.CreateIFaceToPos(builder, posOffset);
		}

		// Token: 0x04011C7E RID: 72830
		private Table __p;
	}
}

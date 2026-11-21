using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A1 RID: 22689
	public struct IGraph3dNodeNormal : IFlatbufferObject
	{
		// Token: 0x1700A46E RID: 42094
		// (get) Token: 0x06024CCC RID: 150732 RVA: 0x0050D988 File Offset: 0x0050BB88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024CCD RID: 150733 RVA: 0x0050D995 File Offset: 0x0050BB95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024CCE RID: 150734 RVA: 0x0050D99C File Offset: 0x0050BB9C
		public static IGraph3dNodeNormal GetRootAsIGraph3dNodeNormal(ByteBuffer _bb)
		{
			return IGraph3dNodeNormal.GetRootAsIGraph3dNodeNormal(_bb, default(IGraph3dNodeNormal));
		}

		// Token: 0x06024CCF RID: 150735 RVA: 0x0050D9B8 File Offset: 0x0050BBB8
		public static IGraph3dNodeNormal GetRootAsIGraph3dNodeNormal(ByteBuffer _bb, IGraph3dNodeNormal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024CD0 RID: 150736 RVA: 0x0050D9D5 File Offset: 0x0050BBD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024CD1 RID: 150737 RVA: 0x0050D9E4 File Offset: 0x0050BBE4
		public IGraph3dNodeNormal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A46F RID: 42095
		// (get) Token: 0x06024CD2 RID: 150738 RVA: 0x0050D9F4 File Offset: 0x0050BBF4
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A470 RID: 42096
		// (get) Token: 0x06024CD3 RID: 150739 RVA: 0x0050DA30 File Offset: 0x0050BC30
		public IVectorInfo? Position
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

		// Token: 0x06024CD4 RID: 150740 RVA: 0x0050DA8D File Offset: 0x0050BC8D
		public static Offset<IGraph3dNodeNormal> CreateIGraph3dNodeNormal(FlatBufferBuilder builder, int Id = 0, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IGraph3dNodeNormal.AddPosition(builder, PositionOffset);
			IGraph3dNodeNormal.AddId(builder, Id);
			return IGraph3dNodeNormal.EndIGraph3dNodeNormal(builder);
		}

		// Token: 0x06024CD5 RID: 150741 RVA: 0x0050DAAA File Offset: 0x0050BCAA
		public static void StartIGraph3dNodeNormal(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024CD6 RID: 150742 RVA: 0x0050DAB3 File Offset: 0x0050BCB3
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06024CD7 RID: 150743 RVA: 0x0050DABE File Offset: 0x0050BCBE
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06024CD8 RID: 150744 RVA: 0x0050DACE File Offset: 0x0050BCCE
		public static Offset<IGraph3dNodeNormal> EndIGraph3dNodeNormal(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dNodeNormal>(builder.EndTable());
		}

		// Token: 0x06024CD9 RID: 150745 RVA: 0x0050DADC File Offset: 0x0050BCDC
		public IGraph3dNodeNormalT UnPack()
		{
			IGraph3dNodeNormalT graph3dNodeNormalT = new IGraph3dNodeNormalT();
			this.UnPackTo(graph3dNodeNormalT);
			return graph3dNodeNormalT;
		}

		// Token: 0x06024CDA RID: 150746 RVA: 0x0050DAF8 File Offset: 0x0050BCF8
		public void UnPackTo(IGraph3dNodeNormalT _o)
		{
			_o.Id = this.Id;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x06024CDB RID: 150747 RVA: 0x0050DB40 File Offset: 0x0050BD40
		public static Offset<IGraph3dNodeNormal> Pack(FlatBufferBuilder builder, IGraph3dNodeNormalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dNodeNormal>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return IGraph3dNodeNormal.CreateIGraph3dNodeNormal(builder, _o.Id, positionOffset);
		}

		// Token: 0x0400F104 RID: 61700
		private Table __p;
	}
}

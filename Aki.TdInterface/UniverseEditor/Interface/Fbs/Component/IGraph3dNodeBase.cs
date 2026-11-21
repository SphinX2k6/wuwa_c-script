using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200589E RID: 22686
	public struct IGraph3dNodeBase : IFlatbufferObject
	{
		// Token: 0x1700A469 RID: 42089
		// (get) Token: 0x06024CB6 RID: 150710 RVA: 0x0050D6FB File Offset: 0x0050B8FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024CB7 RID: 150711 RVA: 0x0050D708 File Offset: 0x0050B908
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024CB8 RID: 150712 RVA: 0x0050D710 File Offset: 0x0050B910
		public static IGraph3dNodeBase GetRootAsIGraph3dNodeBase(ByteBuffer _bb)
		{
			return IGraph3dNodeBase.GetRootAsIGraph3dNodeBase(_bb, default(IGraph3dNodeBase));
		}

		// Token: 0x06024CB9 RID: 150713 RVA: 0x0050D72C File Offset: 0x0050B92C
		public static IGraph3dNodeBase GetRootAsIGraph3dNodeBase(ByteBuffer _bb, IGraph3dNodeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024CBA RID: 150714 RVA: 0x0050D749 File Offset: 0x0050B949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024CBB RID: 150715 RVA: 0x0050D758 File Offset: 0x0050B958
		public IGraph3dNodeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A46A RID: 42090
		// (get) Token: 0x06024CBC RID: 150716 RVA: 0x0050D768 File Offset: 0x0050B968
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

		// Token: 0x1700A46B RID: 42091
		// (get) Token: 0x06024CBD RID: 150717 RVA: 0x0050D7A4 File Offset: 0x0050B9A4
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

		// Token: 0x06024CBE RID: 150718 RVA: 0x0050D801 File Offset: 0x0050BA01
		public static Offset<IGraph3dNodeBase> CreateIGraph3dNodeBase(FlatBufferBuilder builder, int Id = 0, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IGraph3dNodeBase.AddPosition(builder, PositionOffset);
			IGraph3dNodeBase.AddId(builder, Id);
			return IGraph3dNodeBase.EndIGraph3dNodeBase(builder);
		}

		// Token: 0x06024CBF RID: 150719 RVA: 0x0050D81E File Offset: 0x0050BA1E
		public static void StartIGraph3dNodeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024CC0 RID: 150720 RVA: 0x0050D827 File Offset: 0x0050BA27
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06024CC1 RID: 150721 RVA: 0x0050D832 File Offset: 0x0050BA32
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06024CC2 RID: 150722 RVA: 0x0050D842 File Offset: 0x0050BA42
		public static Offset<IGraph3dNodeBase> EndIGraph3dNodeBase(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dNodeBase>(builder.EndTable());
		}

		// Token: 0x06024CC3 RID: 150723 RVA: 0x0050D850 File Offset: 0x0050BA50
		public IGraph3dNodeBaseT UnPack()
		{
			IGraph3dNodeBaseT graph3dNodeBaseT = new IGraph3dNodeBaseT();
			this.UnPackTo(graph3dNodeBaseT);
			return graph3dNodeBaseT;
		}

		// Token: 0x06024CC4 RID: 150724 RVA: 0x0050D86C File Offset: 0x0050BA6C
		public void UnPackTo(IGraph3dNodeBaseT _o)
		{
			_o.Id = this.Id;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x06024CC5 RID: 150725 RVA: 0x0050D8B4 File Offset: 0x0050BAB4
		public static Offset<IGraph3dNodeBase> Pack(FlatBufferBuilder builder, IGraph3dNodeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dNodeBase>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return IGraph3dNodeBase.CreateIGraph3dNodeBase(builder, _o.Id, positionOffset);
		}

		// Token: 0x0400F101 RID: 61697
		private Table __p;
	}
}

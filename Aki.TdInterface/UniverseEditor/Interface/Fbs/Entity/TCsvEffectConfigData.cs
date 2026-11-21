using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C5E RID: 19550
	public struct TCsvEffectConfigData : IFlatbufferObject
	{
		// Token: 0x17008AAE RID: 35502
		// (get) Token: 0x0601DFE1 RID: 122849 RVA: 0x00434648 File Offset: 0x00432848
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DFE2 RID: 122850 RVA: 0x00434655 File Offset: 0x00432855
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DFE3 RID: 122851 RVA: 0x0043465C File Offset: 0x0043285C
		public static TCsvEffectConfigData GetRootAsTCsvEffectConfigData(ByteBuffer _bb)
		{
			return TCsvEffectConfigData.GetRootAsTCsvEffectConfigData(_bb, default(TCsvEffectConfigData));
		}

		// Token: 0x0601DFE4 RID: 122852 RVA: 0x00434678 File Offset: 0x00432878
		public static TCsvEffectConfigData GetRootAsTCsvEffectConfigData(ByteBuffer _bb, TCsvEffectConfigData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DFE5 RID: 122853 RVA: 0x00434695 File Offset: 0x00432895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DFE6 RID: 122854 RVA: 0x004346A4 File Offset: 0x004328A4
		public TCsvEffectConfigData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AAF RID: 35503
		// (get) Token: 0x0601DFE7 RID: 122855 RVA: 0x004346B4 File Offset: 0x004328B4
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

		// Token: 0x17008AB0 RID: 35504
		// (get) Token: 0x0601DFE8 RID: 122856 RVA: 0x004346F0 File Offset: 0x004328F0
		public IEffectConfigBase_Union DataType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return IEffectConfigBase_Union.NONE;
				}
				return (IEffectConfigBase_Union)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DFE9 RID: 122857 RVA: 0x0043472C File Offset: 0x0043292C
		public TTable? Data<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DFEA RID: 122858 RVA: 0x00434770 File Offset: 0x00432970
		public IEffectConfigBase DataAsIEffectConfigBase()
		{
			return this.Data<IEffectConfigBase>().Value;
		}

		// Token: 0x0601DFEB RID: 122859 RVA: 0x0043478C File Offset: 0x0043298C
		public IEffectConfigMonsterDeath DataAsIEffectConfigMonsterDeath()
		{
			return this.Data<IEffectConfigMonsterDeath>().Value;
		}

		// Token: 0x0601DFEC RID: 122860 RVA: 0x004347A8 File Offset: 0x004329A8
		public IEffectConfigMonsterDeathGroup DataAsIEffectConfigMonsterDeathGroup()
		{
			return this.Data<IEffectConfigMonsterDeathGroup>().Value;
		}

		// Token: 0x0601DFED RID: 122861 RVA: 0x004347C3 File Offset: 0x004329C3
		public static Offset<TCsvEffectConfigData> CreateTCsvEffectConfigData(FlatBufferBuilder builder, int Id = 0, IEffectConfigBase_Union Data_type = IEffectConfigBase_Union.NONE, int DataOffset = 0)
		{
			builder.StartTable(3);
			TCsvEffectConfigData.AddData(builder, DataOffset);
			TCsvEffectConfigData.AddId(builder, Id);
			TCsvEffectConfigData.AddDataType(builder, Data_type);
			return TCsvEffectConfigData.EndTCsvEffectConfigData(builder);
		}

		// Token: 0x0601DFEE RID: 122862 RVA: 0x004347E7 File Offset: 0x004329E7
		public static void StartTCsvEffectConfigData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DFEF RID: 122863 RVA: 0x004347F0 File Offset: 0x004329F0
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601DFF0 RID: 122864 RVA: 0x004347FB File Offset: 0x004329FB
		public static void AddDataType(FlatBufferBuilder builder, IEffectConfigBase_Union dataType)
		{
			builder.AddByte(1, (byte)dataType, 0);
		}

		// Token: 0x0601DFF1 RID: 122865 RVA: 0x00434806 File Offset: 0x00432A06
		public static void AddData(FlatBufferBuilder builder, int dataOffset)
		{
			builder.AddOffset(2, dataOffset, 0);
		}

		// Token: 0x0601DFF2 RID: 122866 RVA: 0x00434811 File Offset: 0x00432A11
		public static Offset<TCsvEffectConfigData> EndTCsvEffectConfigData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvEffectConfigData>(builder.EndTable());
		}

		// Token: 0x0601DFF3 RID: 122867 RVA: 0x00434820 File Offset: 0x00432A20
		public TCsvEffectConfigDataT UnPack()
		{
			TCsvEffectConfigDataT tcsvEffectConfigDataT = new TCsvEffectConfigDataT();
			this.UnPackTo(tcsvEffectConfigDataT);
			return tcsvEffectConfigDataT;
		}

		// Token: 0x0601DFF4 RID: 122868 RVA: 0x0043483C File Offset: 0x00432A3C
		public void UnPackTo(TCsvEffectConfigDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = new IEffectConfigBase_UnionUnion();
			_o.Data.Type = this.DataType;
			switch (this.DataType)
			{
			case IEffectConfigBase_Union.IEffectConfigBase:
				_o.Data.Value = ((this.Data<IEffectConfigBase>() != null) ? this.Data<IEffectConfigBase>().Value.UnPack() : null);
				return;
			case IEffectConfigBase_Union.IEffectConfigMonsterDeath:
				_o.Data.Value = ((this.Data<IEffectConfigMonsterDeath>() != null) ? this.Data<IEffectConfigMonsterDeath>().Value.UnPack() : null);
				return;
			case IEffectConfigBase_Union.IEffectConfigMonsterDeathGroup:
				_o.Data.Value = ((this.Data<IEffectConfigMonsterDeathGroup>() != null) ? this.Data<IEffectConfigMonsterDeathGroup>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601DFF5 RID: 122869 RVA: 0x00434930 File Offset: 0x00432B30
		public static Offset<TCsvEffectConfigData> Pack(FlatBufferBuilder builder, TCsvEffectConfigDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvEffectConfigData>);
			}
			IEffectConfigBase_Union data_type = (_o.Data == null) ? IEffectConfigBase_Union.NONE : _o.Data.Type;
			int dataOffset = (_o.Data == null) ? 0 : IEffectConfigBase_UnionUnion.Pack(builder, _o.Data);
			return TCsvEffectConfigData.CreateTCsvEffectConfigData(builder, _o.Id, data_type, dataOffset);
		}

		// Token: 0x0400D6C8 RID: 54984
		private Table __p;
	}
}

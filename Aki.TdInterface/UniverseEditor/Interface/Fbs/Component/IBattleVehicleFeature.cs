using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005430 RID: 21552
	public struct IBattleVehicleFeature : IFlatbufferObject
	{
		// Token: 0x17009904 RID: 39172
		// (get) Token: 0x06021C90 RID: 138384 RVA: 0x004A8704 File Offset: 0x004A6904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021C91 RID: 138385 RVA: 0x004A8711 File Offset: 0x004A6911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021C92 RID: 138386 RVA: 0x004A8718 File Offset: 0x004A6918
		public static IBattleVehicleFeature GetRootAsIBattleVehicleFeature(ByteBuffer _bb)
		{
			return IBattleVehicleFeature.GetRootAsIBattleVehicleFeature(_bb, default(IBattleVehicleFeature));
		}

		// Token: 0x06021C93 RID: 138387 RVA: 0x004A8734 File Offset: 0x004A6934
		public static IBattleVehicleFeature GetRootAsIBattleVehicleFeature(ByteBuffer _bb, IBattleVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021C94 RID: 138388 RVA: 0x004A8751 File Offset: 0x004A6951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021C95 RID: 138389 RVA: 0x004A8760 File Offset: 0x004A6960
		public IBattleVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009905 RID: 39173
		// (get) Token: 0x06021C96 RID: 138390 RVA: 0x004A8770 File Offset: 0x004A6970
		public EVehicleFeatureFlag Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleFeatureFlag.None;
				}
				return (EVehicleFeatureFlag)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021C97 RID: 138391 RVA: 0x004A87AC File Offset: 0x004A69AC
		public static Offset<IBattleVehicleFeature> CreateIBattleVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None)
		{
			builder.StartTable(1);
			IBattleVehicleFeature.AddType(builder, Type);
			return IBattleVehicleFeature.EndIBattleVehicleFeature(builder);
		}

		// Token: 0x06021C98 RID: 138392 RVA: 0x004A87C2 File Offset: 0x004A69C2
		public static void StartIBattleVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021C99 RID: 138393 RVA: 0x004A87CB File Offset: 0x004A69CB
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021C9A RID: 138394 RVA: 0x004A87D6 File Offset: 0x004A69D6
		public static Offset<IBattleVehicleFeature> EndIBattleVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IBattleVehicleFeature>(builder.EndTable());
		}

		// Token: 0x06021C9B RID: 138395 RVA: 0x004A87E4 File Offset: 0x004A69E4
		public IBattleVehicleFeatureT UnPack()
		{
			IBattleVehicleFeatureT battleVehicleFeatureT = new IBattleVehicleFeatureT();
			this.UnPackTo(battleVehicleFeatureT);
			return battleVehicleFeatureT;
		}

		// Token: 0x06021C9C RID: 138396 RVA: 0x004A87FF File Offset: 0x004A69FF
		public void UnPackTo(IBattleVehicleFeatureT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021C9D RID: 138397 RVA: 0x004A8810 File Offset: 0x004A6A10
		public static Offset<IBattleVehicleFeature> Pack(FlatBufferBuilder builder, IBattleVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleVehicleFeature>);
			}
			return IBattleVehicleFeature.CreateIBattleVehicleFeature(builder, _o.Type);
		}

		// Token: 0x0400E8E6 RID: 59622
		private Table __p;
	}
}

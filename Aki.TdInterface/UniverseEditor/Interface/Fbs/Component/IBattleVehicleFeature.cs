using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EFE RID: 20222
	public struct IBattleVehicleFeature : IFlatbufferObject
	{
		// Token: 0x17009182 RID: 37250
		// (get) Token: 0x0601FF20 RID: 130848 RVA: 0x00472370 File Offset: 0x00470570
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FF21 RID: 130849 RVA: 0x0047237D File Offset: 0x0047057D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FF22 RID: 130850 RVA: 0x00472384 File Offset: 0x00470584
		public static IBattleVehicleFeature GetRootAsIBattleVehicleFeature(ByteBuffer _bb)
		{
			return IBattleVehicleFeature.GetRootAsIBattleVehicleFeature(_bb, default(IBattleVehicleFeature));
		}

		// Token: 0x0601FF23 RID: 130851 RVA: 0x004723A0 File Offset: 0x004705A0
		public static IBattleVehicleFeature GetRootAsIBattleVehicleFeature(ByteBuffer _bb, IBattleVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FF24 RID: 130852 RVA: 0x004723BD File Offset: 0x004705BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FF25 RID: 130853 RVA: 0x004723CC File Offset: 0x004705CC
		public IBattleVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009183 RID: 37251
		// (get) Token: 0x0601FF26 RID: 130854 RVA: 0x004723DC File Offset: 0x004705DC
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

		// Token: 0x0601FF27 RID: 130855 RVA: 0x00472418 File Offset: 0x00470618
		public static Offset<IBattleVehicleFeature> CreateIBattleVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None)
		{
			builder.StartTable(1);
			IBattleVehicleFeature.AddType(builder, Type);
			return IBattleVehicleFeature.EndIBattleVehicleFeature(builder);
		}

		// Token: 0x0601FF28 RID: 130856 RVA: 0x0047242E File Offset: 0x0047062E
		public static void StartIBattleVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FF29 RID: 130857 RVA: 0x00472437 File Offset: 0x00470637
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FF2A RID: 130858 RVA: 0x00472442 File Offset: 0x00470642
		public static Offset<IBattleVehicleFeature> EndIBattleVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IBattleVehicleFeature>(builder.EndTable());
		}

		// Token: 0x0601FF2B RID: 130859 RVA: 0x00472450 File Offset: 0x00470650
		public IBattleVehicleFeatureT UnPack()
		{
			IBattleVehicleFeatureT battleVehicleFeatureT = new IBattleVehicleFeatureT();
			this.UnPackTo(battleVehicleFeatureT);
			return battleVehicleFeatureT;
		}

		// Token: 0x0601FF2C RID: 130860 RVA: 0x0047246B File Offset: 0x0047066B
		public void UnPackTo(IBattleVehicleFeatureT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FF2D RID: 130861 RVA: 0x0047247C File Offset: 0x0047067C
		public static Offset<IBattleVehicleFeature> Pack(FlatBufferBuilder builder, IBattleVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleVehicleFeature>);
			}
			return IBattleVehicleFeature.CreateIBattleVehicleFeature(builder, _o.Type);
		}

		// Token: 0x0400DD37 RID: 56631
		private Table __p;
	}
}

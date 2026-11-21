using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A9 RID: 21417
	public struct IAirWallSpawnMode : IFlatbufferObject
	{
		// Token: 0x1700978A RID: 38794
		// (get) Token: 0x060216ED RID: 136941 RVA: 0x0049CE27 File Offset: 0x0049B027
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060216EE RID: 136942 RVA: 0x0049CE34 File Offset: 0x0049B034
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060216EF RID: 136943 RVA: 0x0049CE3C File Offset: 0x0049B03C
		public static IAirWallSpawnMode GetRootAsIAirWallSpawnMode(ByteBuffer _bb)
		{
			return IAirWallSpawnMode.GetRootAsIAirWallSpawnMode(_bb, default(IAirWallSpawnMode));
		}

		// Token: 0x060216F0 RID: 136944 RVA: 0x0049CE58 File Offset: 0x0049B058
		public static IAirWallSpawnMode GetRootAsIAirWallSpawnMode(ByteBuffer _bb, IAirWallSpawnMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060216F1 RID: 136945 RVA: 0x0049CE75 File Offset: 0x0049B075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060216F2 RID: 136946 RVA: 0x0049CE84 File Offset: 0x0049B084
		public IAirWallSpawnMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700978B RID: 38795
		// (get) Token: 0x060216F3 RID: 136947 RVA: 0x0049CE94 File Offset: 0x0049B094
		public EAirWallSpawnMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAirWallSpawnMode.Whole;
				}
				return (EAirWallSpawnMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060216F4 RID: 136948 RVA: 0x0049CED0 File Offset: 0x0049B0D0
		public static Offset<IAirWallSpawnMode> CreateIAirWallSpawnMode(FlatBufferBuilder builder, EAirWallSpawnMode Type = EAirWallSpawnMode.Whole)
		{
			builder.StartTable(1);
			IAirWallSpawnMode.AddType(builder, Type);
			return IAirWallSpawnMode.EndIAirWallSpawnMode(builder);
		}

		// Token: 0x060216F5 RID: 136949 RVA: 0x0049CEE6 File Offset: 0x0049B0E6
		public static void StartIAirWallSpawnMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060216F6 RID: 136950 RVA: 0x0049CEEF File Offset: 0x0049B0EF
		public static void AddType(FlatBufferBuilder builder, EAirWallSpawnMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060216F7 RID: 136951 RVA: 0x0049CEFA File Offset: 0x0049B0FA
		public static Offset<IAirWallSpawnMode> EndIAirWallSpawnMode(FlatBufferBuilder builder)
		{
			return new Offset<IAirWallSpawnMode>(builder.EndTable());
		}

		// Token: 0x060216F8 RID: 136952 RVA: 0x0049CF08 File Offset: 0x0049B108
		public IAirWallSpawnModeT UnPack()
		{
			IAirWallSpawnModeT airWallSpawnModeT = new IAirWallSpawnModeT();
			this.UnPackTo(airWallSpawnModeT);
			return airWallSpawnModeT;
		}

		// Token: 0x060216F9 RID: 136953 RVA: 0x0049CF23 File Offset: 0x0049B123
		public void UnPackTo(IAirWallSpawnModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060216FA RID: 136954 RVA: 0x0049CF34 File Offset: 0x0049B134
		public static Offset<IAirWallSpawnMode> Pack(FlatBufferBuilder builder, IAirWallSpawnModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirWallSpawnMode>);
			}
			return IAirWallSpawnMode.CreateIAirWallSpawnMode(builder, _o.Type);
		}

		// Token: 0x0400E7E9 RID: 59369
		private Table __p;
	}
}

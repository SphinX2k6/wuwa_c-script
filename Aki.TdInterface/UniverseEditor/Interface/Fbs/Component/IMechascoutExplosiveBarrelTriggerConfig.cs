using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ABC RID: 23228
	public struct IMechascoutExplosiveBarrelTriggerConfig : IFlatbufferObject
	{
		// Token: 0x1700A948 RID: 43336
		// (get) Token: 0x06026163 RID: 156003 RVA: 0x00537CA4 File Offset: 0x00535EA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026164 RID: 156004 RVA: 0x00537CB1 File Offset: 0x00535EB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026165 RID: 156005 RVA: 0x00537CB8 File Offset: 0x00535EB8
		public static IMechascoutExplosiveBarrelTriggerConfig GetRootAsIMechascoutExplosiveBarrelTriggerConfig(ByteBuffer _bb)
		{
			return IMechascoutExplosiveBarrelTriggerConfig.GetRootAsIMechascoutExplosiveBarrelTriggerConfig(_bb, default(IMechascoutExplosiveBarrelTriggerConfig));
		}

		// Token: 0x06026166 RID: 156006 RVA: 0x00537CD4 File Offset: 0x00535ED4
		public static IMechascoutExplosiveBarrelTriggerConfig GetRootAsIMechascoutExplosiveBarrelTriggerConfig(ByteBuffer _bb, IMechascoutExplosiveBarrelTriggerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026167 RID: 156007 RVA: 0x00537CF1 File Offset: 0x00535EF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026168 RID: 156008 RVA: 0x00537D00 File Offset: 0x00535F00
		public IMechascoutExplosiveBarrelTriggerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A949 RID: 43337
		// (get) Token: 0x06026169 RID: 156009 RVA: 0x00537D10 File Offset: 0x00535F10
		public ETeleCtrlTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleCtrlTriggerType.MechascoutJavelin;
				}
				return (ETeleCtrlTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602616A RID: 156010 RVA: 0x00537D4C File Offset: 0x00535F4C
		public static Offset<IMechascoutExplosiveBarrelTriggerConfig> CreateIMechascoutExplosiveBarrelTriggerConfig(FlatBufferBuilder builder, ETeleCtrlTriggerType Type = ETeleCtrlTriggerType.MechascoutJavelin)
		{
			builder.StartTable(1);
			IMechascoutExplosiveBarrelTriggerConfig.AddType(builder, Type);
			return IMechascoutExplosiveBarrelTriggerConfig.EndIMechascoutExplosiveBarrelTriggerConfig(builder);
		}

		// Token: 0x0602616B RID: 156011 RVA: 0x00537D62 File Offset: 0x00535F62
		public static void StartIMechascoutExplosiveBarrelTriggerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602616C RID: 156012 RVA: 0x00537D6B File Offset: 0x00535F6B
		public static void AddType(FlatBufferBuilder builder, ETeleCtrlTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602616D RID: 156013 RVA: 0x00537D76 File Offset: 0x00535F76
		public static Offset<IMechascoutExplosiveBarrelTriggerConfig> EndIMechascoutExplosiveBarrelTriggerConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMechascoutExplosiveBarrelTriggerConfig>(builder.EndTable());
		}

		// Token: 0x0602616E RID: 156014 RVA: 0x00537D84 File Offset: 0x00535F84
		public IMechascoutExplosiveBarrelTriggerConfigT UnPack()
		{
			IMechascoutExplosiveBarrelTriggerConfigT mechascoutExplosiveBarrelTriggerConfigT = new IMechascoutExplosiveBarrelTriggerConfigT();
			this.UnPackTo(mechascoutExplosiveBarrelTriggerConfigT);
			return mechascoutExplosiveBarrelTriggerConfigT;
		}

		// Token: 0x0602616F RID: 156015 RVA: 0x00537D9F File Offset: 0x00535F9F
		public void UnPackTo(IMechascoutExplosiveBarrelTriggerConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026170 RID: 156016 RVA: 0x00537DB0 File Offset: 0x00535FB0
		public static Offset<IMechascoutExplosiveBarrelTriggerConfig> Pack(FlatBufferBuilder builder, IMechascoutExplosiveBarrelTriggerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechascoutExplosiveBarrelTriggerConfig>);
			}
			return IMechascoutExplosiveBarrelTriggerConfig.CreateIMechascoutExplosiveBarrelTriggerConfig(builder, _o.Type);
		}

		// Token: 0x0400F467 RID: 62567
		private Table __p;
	}
}

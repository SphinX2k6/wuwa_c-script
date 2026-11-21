using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005370 RID: 21360
	public struct IAdsorbAddBuff : IFlatbufferObject
	{
		// Token: 0x170096CB RID: 38603
		// (get) Token: 0x0602143B RID: 136251 RVA: 0x0049715A File Offset: 0x0049535A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602143C RID: 136252 RVA: 0x00497167 File Offset: 0x00495367
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602143D RID: 136253 RVA: 0x00497170 File Offset: 0x00495370
		public static IAdsorbAddBuff GetRootAsIAdsorbAddBuff(ByteBuffer _bb)
		{
			return IAdsorbAddBuff.GetRootAsIAdsorbAddBuff(_bb, default(IAdsorbAddBuff));
		}

		// Token: 0x0602143E RID: 136254 RVA: 0x0049718C File Offset: 0x0049538C
		public static IAdsorbAddBuff GetRootAsIAdsorbAddBuff(ByteBuffer _bb, IAdsorbAddBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602143F RID: 136255 RVA: 0x004971A9 File Offset: 0x004953A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021440 RID: 136256 RVA: 0x004971B8 File Offset: 0x004953B8
		public IAdsorbAddBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096CC RID: 38604
		// (get) Token: 0x06021441 RID: 136257 RVA: 0x004971C8 File Offset: 0x004953C8
		public EBuffProducerMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffProducerMode.Immediate;
				}
				return (EBuffProducerMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170096CD RID: 38605
		// (get) Token: 0x06021442 RID: 136258 RVA: 0x00497204 File Offset: 0x00495404
		public int Speed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021443 RID: 136259 RVA: 0x00497240 File Offset: 0x00495440
		public static Offset<IAdsorbAddBuff> CreateIAdsorbAddBuff(FlatBufferBuilder builder, EBuffProducerMode Type = EBuffProducerMode.Immediate, int Speed = 0)
		{
			builder.StartTable(2);
			IAdsorbAddBuff.AddSpeed(builder, Speed);
			IAdsorbAddBuff.AddType(builder, Type);
			return IAdsorbAddBuff.EndIAdsorbAddBuff(builder);
		}

		// Token: 0x06021444 RID: 136260 RVA: 0x0049725D File Offset: 0x0049545D
		public static void StartIAdsorbAddBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021445 RID: 136261 RVA: 0x00497266 File Offset: 0x00495466
		public static void AddType(FlatBufferBuilder builder, EBuffProducerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021446 RID: 136262 RVA: 0x00497271 File Offset: 0x00495471
		public static void AddSpeed(FlatBufferBuilder builder, int speed)
		{
			builder.AddInt(1, speed, 0);
		}

		// Token: 0x06021447 RID: 136263 RVA: 0x0049727C File Offset: 0x0049547C
		public static Offset<IAdsorbAddBuff> EndIAdsorbAddBuff(FlatBufferBuilder builder)
		{
			return new Offset<IAdsorbAddBuff>(builder.EndTable());
		}

		// Token: 0x06021448 RID: 136264 RVA: 0x0049728C File Offset: 0x0049548C
		public IAdsorbAddBuffT UnPack()
		{
			IAdsorbAddBuffT adsorbAddBuffT = new IAdsorbAddBuffT();
			this.UnPackTo(adsorbAddBuffT);
			return adsorbAddBuffT;
		}

		// Token: 0x06021449 RID: 136265 RVA: 0x004972A7 File Offset: 0x004954A7
		public void UnPackTo(IAdsorbAddBuffT _o)
		{
			_o.Type = this.Type;
			_o.Speed = this.Speed;
		}

		// Token: 0x0602144A RID: 136266 RVA: 0x004972C4 File Offset: 0x004954C4
		public static Offset<IAdsorbAddBuff> Pack(FlatBufferBuilder builder, IAdsorbAddBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdsorbAddBuff>);
			}
			return IAdsorbAddBuff.CreateIAdsorbAddBuff(builder, _o.Type, _o.Speed);
		}

		// Token: 0x0400E77B RID: 59259
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F2A RID: 24362
	public struct ISkyboxDistanceTrigger : IFlatbufferObject
	{
		// Token: 0x1700B453 RID: 46163
		// (get) Token: 0x06028E9E RID: 167582 RVA: 0x005970D1 File Offset: 0x005952D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E9F RID: 167583 RVA: 0x005970DE File Offset: 0x005952DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028EA0 RID: 167584 RVA: 0x005970E8 File Offset: 0x005952E8
		public static ISkyboxDistanceTrigger GetRootAsISkyboxDistanceTrigger(ByteBuffer _bb)
		{
			return ISkyboxDistanceTrigger.GetRootAsISkyboxDistanceTrigger(_bb, default(ISkyboxDistanceTrigger));
		}

		// Token: 0x06028EA1 RID: 167585 RVA: 0x00597104 File Offset: 0x00595304
		public static ISkyboxDistanceTrigger GetRootAsISkyboxDistanceTrigger(ByteBuffer _bb, ISkyboxDistanceTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028EA2 RID: 167586 RVA: 0x00597121 File Offset: 0x00595321
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028EA3 RID: 167587 RVA: 0x00597130 File Offset: 0x00595330
		public ISkyboxDistanceTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B454 RID: 46164
		// (get) Token: 0x06028EA4 RID: 167588 RVA: 0x00597140 File Offset: 0x00595340
		public ETriggerMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerMode.Distance;
				}
				return (ETriggerMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B455 RID: 46165
		// (get) Token: 0x06028EA5 RID: 167589 RVA: 0x0059717C File Offset: 0x0059537C
		public float Distance
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028EA6 RID: 167590 RVA: 0x005971BC File Offset: 0x005953BC
		public static Offset<ISkyboxDistanceTrigger> CreateISkyboxDistanceTrigger(FlatBufferBuilder builder, ETriggerMode Type = ETriggerMode.Distance, float Distance = 0f)
		{
			builder.StartTable(2);
			ISkyboxDistanceTrigger.AddDistance(builder, Distance);
			ISkyboxDistanceTrigger.AddType(builder, Type);
			return ISkyboxDistanceTrigger.EndISkyboxDistanceTrigger(builder);
		}

		// Token: 0x06028EA7 RID: 167591 RVA: 0x005971D9 File Offset: 0x005953D9
		public static void StartISkyboxDistanceTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028EA8 RID: 167592 RVA: 0x005971E2 File Offset: 0x005953E2
		public static void AddType(FlatBufferBuilder builder, ETriggerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028EA9 RID: 167593 RVA: 0x005971ED File Offset: 0x005953ED
		public static void AddDistance(FlatBufferBuilder builder, float distance)
		{
			builder.AddFloat(1, distance, 0.0);
		}

		// Token: 0x06028EAA RID: 167594 RVA: 0x00597200 File Offset: 0x00595400
		public static Offset<ISkyboxDistanceTrigger> EndISkyboxDistanceTrigger(FlatBufferBuilder builder)
		{
			return new Offset<ISkyboxDistanceTrigger>(builder.EndTable());
		}

		// Token: 0x06028EAB RID: 167595 RVA: 0x00597210 File Offset: 0x00595410
		public ISkyboxDistanceTriggerT UnPack()
		{
			ISkyboxDistanceTriggerT skyboxDistanceTriggerT = new ISkyboxDistanceTriggerT();
			this.UnPackTo(skyboxDistanceTriggerT);
			return skyboxDistanceTriggerT;
		}

		// Token: 0x06028EAC RID: 167596 RVA: 0x0059722B File Offset: 0x0059542B
		public void UnPackTo(ISkyboxDistanceTriggerT _o)
		{
			_o.Type = this.Type;
			_o.Distance = this.Distance;
		}

		// Token: 0x06028EAD RID: 167597 RVA: 0x00597248 File Offset: 0x00595448
		public static Offset<ISkyboxDistanceTrigger> Pack(FlatBufferBuilder builder, ISkyboxDistanceTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkyboxDistanceTrigger>);
			}
			return ISkyboxDistanceTrigger.CreateISkyboxDistanceTrigger(builder, _o.Type, _o.Distance);
		}

		// Token: 0x0400FBC6 RID: 64454
		private Table __p;
	}
}

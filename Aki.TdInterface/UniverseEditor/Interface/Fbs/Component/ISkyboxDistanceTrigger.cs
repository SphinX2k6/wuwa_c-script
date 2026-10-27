using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200591D RID: 22813
	public struct ISkyboxDistanceTrigger : IFlatbufferObject
	{
		// Token: 0x1700AB1F RID: 43807
		// (get) Token: 0x06026934 RID: 158004 RVA: 0x00550465 File Offset: 0x0054E665
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026935 RID: 158005 RVA: 0x00550472 File Offset: 0x0054E672
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026936 RID: 158006 RVA: 0x0055047C File Offset: 0x0054E67C
		public static ISkyboxDistanceTrigger GetRootAsISkyboxDistanceTrigger(ByteBuffer _bb)
		{
			return ISkyboxDistanceTrigger.GetRootAsISkyboxDistanceTrigger(_bb, default(ISkyboxDistanceTrigger));
		}

		// Token: 0x06026937 RID: 158007 RVA: 0x00550498 File Offset: 0x0054E698
		public static ISkyboxDistanceTrigger GetRootAsISkyboxDistanceTrigger(ByteBuffer _bb, ISkyboxDistanceTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026938 RID: 158008 RVA: 0x005504B5 File Offset: 0x0054E6B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026939 RID: 158009 RVA: 0x005504C4 File Offset: 0x0054E6C4
		public ISkyboxDistanceTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB20 RID: 43808
		// (get) Token: 0x0602693A RID: 158010 RVA: 0x005504D4 File Offset: 0x0054E6D4
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

		// Token: 0x1700AB21 RID: 43809
		// (get) Token: 0x0602693B RID: 158011 RVA: 0x00550510 File Offset: 0x0054E710
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

		// Token: 0x0602693C RID: 158012 RVA: 0x00550550 File Offset: 0x0054E750
		public static Offset<ISkyboxDistanceTrigger> CreateISkyboxDistanceTrigger(FlatBufferBuilder builder, ETriggerMode Type = ETriggerMode.Distance, float Distance = 0f)
		{
			builder.StartTable(2);
			ISkyboxDistanceTrigger.AddDistance(builder, Distance);
			ISkyboxDistanceTrigger.AddType(builder, Type);
			return ISkyboxDistanceTrigger.EndISkyboxDistanceTrigger(builder);
		}

		// Token: 0x0602693D RID: 158013 RVA: 0x0055056D File Offset: 0x0054E76D
		public static void StartISkyboxDistanceTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602693E RID: 158014 RVA: 0x00550576 File Offset: 0x0054E776
		public static void AddType(FlatBufferBuilder builder, ETriggerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602693F RID: 158015 RVA: 0x00550581 File Offset: 0x0054E781
		public static void AddDistance(FlatBufferBuilder builder, float distance)
		{
			builder.AddFloat(1, distance, 0.0);
		}

		// Token: 0x06026940 RID: 158016 RVA: 0x00550594 File Offset: 0x0054E794
		public static Offset<ISkyboxDistanceTrigger> EndISkyboxDistanceTrigger(FlatBufferBuilder builder)
		{
			return new Offset<ISkyboxDistanceTrigger>(builder.EndTable());
		}

		// Token: 0x06026941 RID: 158017 RVA: 0x005505A4 File Offset: 0x0054E7A4
		public ISkyboxDistanceTriggerT UnPack()
		{
			ISkyboxDistanceTriggerT skyboxDistanceTriggerT = new ISkyboxDistanceTriggerT();
			this.UnPackTo(skyboxDistanceTriggerT);
			return skyboxDistanceTriggerT;
		}

		// Token: 0x06026942 RID: 158018 RVA: 0x005505BF File Offset: 0x0054E7BF
		public void UnPackTo(ISkyboxDistanceTriggerT _o)
		{
			_o.Type = this.Type;
			_o.Distance = this.Distance;
		}

		// Token: 0x06026943 RID: 158019 RVA: 0x005505DC File Offset: 0x0054E7DC
		public static Offset<ISkyboxDistanceTrigger> Pack(FlatBufferBuilder builder, ISkyboxDistanceTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkyboxDistanceTrigger>);
			}
			return ISkyboxDistanceTrigger.CreateISkyboxDistanceTrigger(builder, _o.Type, _o.Distance);
		}

		// Token: 0x0400EED1 RID: 61137
		private Table __p;
	}
}

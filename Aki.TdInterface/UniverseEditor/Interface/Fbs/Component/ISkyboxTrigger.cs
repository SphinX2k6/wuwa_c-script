using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005923 RID: 22819
	public struct ISkyboxTrigger : IFlatbufferObject
	{
		// Token: 0x1700AB27 RID: 43815
		// (get) Token: 0x0602695C RID: 158044 RVA: 0x005507ED File Offset: 0x0054E9ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602695D RID: 158045 RVA: 0x005507FA File Offset: 0x0054E9FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602695E RID: 158046 RVA: 0x00550804 File Offset: 0x0054EA04
		public static ISkyboxTrigger GetRootAsISkyboxTrigger(ByteBuffer _bb)
		{
			return ISkyboxTrigger.GetRootAsISkyboxTrigger(_bb, default(ISkyboxTrigger));
		}

		// Token: 0x0602695F RID: 158047 RVA: 0x00550820 File Offset: 0x0054EA20
		public static ISkyboxTrigger GetRootAsISkyboxTrigger(ByteBuffer _bb, ISkyboxTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026960 RID: 158048 RVA: 0x0055083D File Offset: 0x0054EA3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026961 RID: 158049 RVA: 0x0055084C File Offset: 0x0054EA4C
		public ISkyboxTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB28 RID: 43816
		// (get) Token: 0x06026962 RID: 158050 RVA: 0x0055085C File Offset: 0x0054EA5C
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

		// Token: 0x06026963 RID: 158051 RVA: 0x00550898 File Offset: 0x0054EA98
		public static Offset<ISkyboxTrigger> CreateISkyboxTrigger(FlatBufferBuilder builder, ETriggerMode Type = ETriggerMode.Distance)
		{
			builder.StartTable(1);
			ISkyboxTrigger.AddType(builder, Type);
			return ISkyboxTrigger.EndISkyboxTrigger(builder);
		}

		// Token: 0x06026964 RID: 158052 RVA: 0x005508AE File Offset: 0x0054EAAE
		public static void StartISkyboxTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026965 RID: 158053 RVA: 0x005508B7 File Offset: 0x0054EAB7
		public static void AddType(FlatBufferBuilder builder, ETriggerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026966 RID: 158054 RVA: 0x005508C2 File Offset: 0x0054EAC2
		public static Offset<ISkyboxTrigger> EndISkyboxTrigger(FlatBufferBuilder builder)
		{
			return new Offset<ISkyboxTrigger>(builder.EndTable());
		}

		// Token: 0x06026967 RID: 158055 RVA: 0x005508D0 File Offset: 0x0054EAD0
		public ISkyboxTriggerT UnPack()
		{
			ISkyboxTriggerT skyboxTriggerT = new ISkyboxTriggerT();
			this.UnPackTo(skyboxTriggerT);
			return skyboxTriggerT;
		}

		// Token: 0x06026968 RID: 158056 RVA: 0x005508EB File Offset: 0x0054EAEB
		public void UnPackTo(ISkyboxTriggerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026969 RID: 158057 RVA: 0x005508FC File Offset: 0x0054EAFC
		public static Offset<ISkyboxTrigger> Pack(FlatBufferBuilder builder, ISkyboxTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkyboxTrigger>);
			}
			return ISkyboxTrigger.CreateISkyboxTrigger(builder, _o.Type);
		}

		// Token: 0x0400EED6 RID: 61142
		private Table __p;
	}
}

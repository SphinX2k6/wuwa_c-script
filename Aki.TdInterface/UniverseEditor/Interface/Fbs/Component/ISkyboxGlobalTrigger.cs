using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005920 RID: 22816
	public struct ISkyboxGlobalTrigger : IFlatbufferObject
	{
		// Token: 0x1700AB24 RID: 43812
		// (get) Token: 0x0602694A RID: 158026 RVA: 0x00550676 File Offset: 0x0054E876
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602694B RID: 158027 RVA: 0x00550683 File Offset: 0x0054E883
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602694C RID: 158028 RVA: 0x0055068C File Offset: 0x0054E88C
		public static ISkyboxGlobalTrigger GetRootAsISkyboxGlobalTrigger(ByteBuffer _bb)
		{
			return ISkyboxGlobalTrigger.GetRootAsISkyboxGlobalTrigger(_bb, default(ISkyboxGlobalTrigger));
		}

		// Token: 0x0602694D RID: 158029 RVA: 0x005506A8 File Offset: 0x0054E8A8
		public static ISkyboxGlobalTrigger GetRootAsISkyboxGlobalTrigger(ByteBuffer _bb, ISkyboxGlobalTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602694E RID: 158030 RVA: 0x005506C5 File Offset: 0x0054E8C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602694F RID: 158031 RVA: 0x005506D4 File Offset: 0x0054E8D4
		public ISkyboxGlobalTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB25 RID: 43813
		// (get) Token: 0x06026950 RID: 158032 RVA: 0x005506E4 File Offset: 0x0054E8E4
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

		// Token: 0x06026951 RID: 158033 RVA: 0x00550720 File Offset: 0x0054E920
		public static Offset<ISkyboxGlobalTrigger> CreateISkyboxGlobalTrigger(FlatBufferBuilder builder, ETriggerMode Type = ETriggerMode.Distance)
		{
			builder.StartTable(1);
			ISkyboxGlobalTrigger.AddType(builder, Type);
			return ISkyboxGlobalTrigger.EndISkyboxGlobalTrigger(builder);
		}

		// Token: 0x06026952 RID: 158034 RVA: 0x00550736 File Offset: 0x0054E936
		public static void StartISkyboxGlobalTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026953 RID: 158035 RVA: 0x0055073F File Offset: 0x0054E93F
		public static void AddType(FlatBufferBuilder builder, ETriggerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026954 RID: 158036 RVA: 0x0055074A File Offset: 0x0054E94A
		public static Offset<ISkyboxGlobalTrigger> EndISkyboxGlobalTrigger(FlatBufferBuilder builder)
		{
			return new Offset<ISkyboxGlobalTrigger>(builder.EndTable());
		}

		// Token: 0x06026955 RID: 158037 RVA: 0x00550758 File Offset: 0x0054E958
		public ISkyboxGlobalTriggerT UnPack()
		{
			ISkyboxGlobalTriggerT skyboxGlobalTriggerT = new ISkyboxGlobalTriggerT();
			this.UnPackTo(skyboxGlobalTriggerT);
			return skyboxGlobalTriggerT;
		}

		// Token: 0x06026956 RID: 158038 RVA: 0x00550773 File Offset: 0x0054E973
		public void UnPackTo(ISkyboxGlobalTriggerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026957 RID: 158039 RVA: 0x00550784 File Offset: 0x0054E984
		public static Offset<ISkyboxGlobalTrigger> Pack(FlatBufferBuilder builder, ISkyboxGlobalTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkyboxGlobalTrigger>);
			}
			return ISkyboxGlobalTrigger.CreateISkyboxGlobalTrigger(builder, _o.Type);
		}

		// Token: 0x0400EED4 RID: 61140
		private Table __p;
	}
}

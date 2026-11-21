using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F2D RID: 24365
	public struct ISkyboxGlobalTrigger : IFlatbufferObject
	{
		// Token: 0x1700B458 RID: 46168
		// (get) Token: 0x06028EB4 RID: 167604 RVA: 0x005972E2 File Offset: 0x005954E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028EB5 RID: 167605 RVA: 0x005972EF File Offset: 0x005954EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028EB6 RID: 167606 RVA: 0x005972F8 File Offset: 0x005954F8
		public static ISkyboxGlobalTrigger GetRootAsISkyboxGlobalTrigger(ByteBuffer _bb)
		{
			return ISkyboxGlobalTrigger.GetRootAsISkyboxGlobalTrigger(_bb, default(ISkyboxGlobalTrigger));
		}

		// Token: 0x06028EB7 RID: 167607 RVA: 0x00597314 File Offset: 0x00595514
		public static ISkyboxGlobalTrigger GetRootAsISkyboxGlobalTrigger(ByteBuffer _bb, ISkyboxGlobalTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028EB8 RID: 167608 RVA: 0x00597331 File Offset: 0x00595531
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028EB9 RID: 167609 RVA: 0x00597340 File Offset: 0x00595540
		public ISkyboxGlobalTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B459 RID: 46169
		// (get) Token: 0x06028EBA RID: 167610 RVA: 0x00597350 File Offset: 0x00595550
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

		// Token: 0x06028EBB RID: 167611 RVA: 0x0059738C File Offset: 0x0059558C
		public static Offset<ISkyboxGlobalTrigger> CreateISkyboxGlobalTrigger(FlatBufferBuilder builder, ETriggerMode Type = ETriggerMode.Distance)
		{
			builder.StartTable(1);
			ISkyboxGlobalTrigger.AddType(builder, Type);
			return ISkyboxGlobalTrigger.EndISkyboxGlobalTrigger(builder);
		}

		// Token: 0x06028EBC RID: 167612 RVA: 0x005973A2 File Offset: 0x005955A2
		public static void StartISkyboxGlobalTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028EBD RID: 167613 RVA: 0x005973AB File Offset: 0x005955AB
		public static void AddType(FlatBufferBuilder builder, ETriggerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028EBE RID: 167614 RVA: 0x005973B6 File Offset: 0x005955B6
		public static Offset<ISkyboxGlobalTrigger> EndISkyboxGlobalTrigger(FlatBufferBuilder builder)
		{
			return new Offset<ISkyboxGlobalTrigger>(builder.EndTable());
		}

		// Token: 0x06028EBF RID: 167615 RVA: 0x005973C4 File Offset: 0x005955C4
		public ISkyboxGlobalTriggerT UnPack()
		{
			ISkyboxGlobalTriggerT skyboxGlobalTriggerT = new ISkyboxGlobalTriggerT();
			this.UnPackTo(skyboxGlobalTriggerT);
			return skyboxGlobalTriggerT;
		}

		// Token: 0x06028EC0 RID: 167616 RVA: 0x005973DF File Offset: 0x005955DF
		public void UnPackTo(ISkyboxGlobalTriggerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028EC1 RID: 167617 RVA: 0x005973F0 File Offset: 0x005955F0
		public static Offset<ISkyboxGlobalTrigger> Pack(FlatBufferBuilder builder, ISkyboxGlobalTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkyboxGlobalTrigger>);
			}
			return ISkyboxGlobalTrigger.CreateISkyboxGlobalTrigger(builder, _o.Type);
		}

		// Token: 0x0400FBC9 RID: 64457
		private Table __p;
	}
}

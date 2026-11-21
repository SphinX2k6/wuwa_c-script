using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F30 RID: 24368
	public struct ISkyboxTrigger : IFlatbufferObject
	{
		// Token: 0x1700B45B RID: 46171
		// (get) Token: 0x06028EC6 RID: 167622 RVA: 0x00597459 File Offset: 0x00595659
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028EC7 RID: 167623 RVA: 0x00597466 File Offset: 0x00595666
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028EC8 RID: 167624 RVA: 0x00597470 File Offset: 0x00595670
		public static ISkyboxTrigger GetRootAsISkyboxTrigger(ByteBuffer _bb)
		{
			return ISkyboxTrigger.GetRootAsISkyboxTrigger(_bb, default(ISkyboxTrigger));
		}

		// Token: 0x06028EC9 RID: 167625 RVA: 0x0059748C File Offset: 0x0059568C
		public static ISkyboxTrigger GetRootAsISkyboxTrigger(ByteBuffer _bb, ISkyboxTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028ECA RID: 167626 RVA: 0x005974A9 File Offset: 0x005956A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028ECB RID: 167627 RVA: 0x005974B8 File Offset: 0x005956B8
		public ISkyboxTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B45C RID: 46172
		// (get) Token: 0x06028ECC RID: 167628 RVA: 0x005974C8 File Offset: 0x005956C8
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

		// Token: 0x06028ECD RID: 167629 RVA: 0x00597504 File Offset: 0x00595704
		public static Offset<ISkyboxTrigger> CreateISkyboxTrigger(FlatBufferBuilder builder, ETriggerMode Type = ETriggerMode.Distance)
		{
			builder.StartTable(1);
			ISkyboxTrigger.AddType(builder, Type);
			return ISkyboxTrigger.EndISkyboxTrigger(builder);
		}

		// Token: 0x06028ECE RID: 167630 RVA: 0x0059751A File Offset: 0x0059571A
		public static void StartISkyboxTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028ECF RID: 167631 RVA: 0x00597523 File Offset: 0x00595723
		public static void AddType(FlatBufferBuilder builder, ETriggerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028ED0 RID: 167632 RVA: 0x0059752E File Offset: 0x0059572E
		public static Offset<ISkyboxTrigger> EndISkyboxTrigger(FlatBufferBuilder builder)
		{
			return new Offset<ISkyboxTrigger>(builder.EndTable());
		}

		// Token: 0x06028ED1 RID: 167633 RVA: 0x0059753C File Offset: 0x0059573C
		public ISkyboxTriggerT UnPack()
		{
			ISkyboxTriggerT skyboxTriggerT = new ISkyboxTriggerT();
			this.UnPackTo(skyboxTriggerT);
			return skyboxTriggerT;
		}

		// Token: 0x06028ED2 RID: 167634 RVA: 0x00597557 File Offset: 0x00595757
		public void UnPackTo(ISkyboxTriggerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028ED3 RID: 167635 RVA: 0x00597568 File Offset: 0x00595768
		public static Offset<ISkyboxTrigger> Pack(FlatBufferBuilder builder, ISkyboxTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkyboxTrigger>);
			}
			return ISkyboxTrigger.CreateISkyboxTrigger(builder, _o.Type);
		}

		// Token: 0x0400FBCB RID: 64459
		private Table __p;
	}
}

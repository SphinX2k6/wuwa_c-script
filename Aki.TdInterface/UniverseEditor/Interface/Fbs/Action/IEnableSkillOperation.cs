using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CFE RID: 27902
	public struct IEnableSkillOperation : IFlatbufferObject
	{
		// Token: 0x1700CCC0 RID: 52416
		// (get) Token: 0x060301E8 RID: 197096 RVA: 0x0068B914 File Offset: 0x00689B14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060301E9 RID: 197097 RVA: 0x0068B921 File Offset: 0x00689B21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060301EA RID: 197098 RVA: 0x0068B928 File Offset: 0x00689B28
		public static IEnableSkillOperation GetRootAsIEnableSkillOperation(ByteBuffer _bb)
		{
			return IEnableSkillOperation.GetRootAsIEnableSkillOperation(_bb, default(IEnableSkillOperation));
		}

		// Token: 0x060301EB RID: 197099 RVA: 0x0068B944 File Offset: 0x00689B44
		public static IEnableSkillOperation GetRootAsIEnableSkillOperation(ByteBuffer _bb, IEnableSkillOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060301EC RID: 197100 RVA: 0x0068B961 File Offset: 0x00689B61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060301ED RID: 197101 RVA: 0x0068B970 File Offset: 0x00689B70
		public IEnableSkillOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCC1 RID: 52417
		// (get) Token: 0x060301EE RID: 197102 RVA: 0x0068B980 File Offset: 0x00689B80
		public ESkillOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillOperationType.Enable;
				}
				return (ESkillOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060301EF RID: 197103 RVA: 0x0068B9BC File Offset: 0x00689BBC
		public static Offset<IEnableSkillOperation> CreateIEnableSkillOperation(FlatBufferBuilder builder, ESkillOperationType Type = ESkillOperationType.Enable)
		{
			builder.StartTable(1);
			IEnableSkillOperation.AddType(builder, Type);
			return IEnableSkillOperation.EndIEnableSkillOperation(builder);
		}

		// Token: 0x060301F0 RID: 197104 RVA: 0x0068B9D2 File Offset: 0x00689BD2
		public static void StartIEnableSkillOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060301F1 RID: 197105 RVA: 0x0068B9DB File Offset: 0x00689BDB
		public static void AddType(FlatBufferBuilder builder, ESkillOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060301F2 RID: 197106 RVA: 0x0068B9E6 File Offset: 0x00689BE6
		public static Offset<IEnableSkillOperation> EndIEnableSkillOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSkillOperation>(builder.EndTable());
		}

		// Token: 0x060301F3 RID: 197107 RVA: 0x0068B9F4 File Offset: 0x00689BF4
		public IEnableSkillOperationT UnPack()
		{
			IEnableSkillOperationT enableSkillOperationT = new IEnableSkillOperationT();
			this.UnPackTo(enableSkillOperationT);
			return enableSkillOperationT;
		}

		// Token: 0x060301F4 RID: 197108 RVA: 0x0068BA0F File Offset: 0x00689C0F
		public void UnPackTo(IEnableSkillOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060301F5 RID: 197109 RVA: 0x0068BA20 File Offset: 0x00689C20
		public static Offset<IEnableSkillOperation> Pack(FlatBufferBuilder builder, IEnableSkillOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSkillOperation>);
			}
			return IEnableSkillOperation.CreateIEnableSkillOperation(builder, _o.Type);
		}

		// Token: 0x04011B61 RID: 72545
		private Table __p;
	}
}

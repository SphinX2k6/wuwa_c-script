using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078FC RID: 30972
	public struct ISkillOperationType : IFlatbufferObject
	{
		// Token: 0x1700E33E RID: 58174
		// (get) Token: 0x06036895 RID: 223381 RVA: 0x0074CF5E File Offset: 0x0074B15E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036896 RID: 223382 RVA: 0x0074CF6B File Offset: 0x0074B16B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036897 RID: 223383 RVA: 0x0074CF74 File Offset: 0x0074B174
		public static ISkillOperationType GetRootAsISkillOperationType(ByteBuffer _bb)
		{
			return ISkillOperationType.GetRootAsISkillOperationType(_bb, default(ISkillOperationType));
		}

		// Token: 0x06036898 RID: 223384 RVA: 0x0074CF90 File Offset: 0x0074B190
		public static ISkillOperationType GetRootAsISkillOperationType(ByteBuffer _bb, ISkillOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036899 RID: 223385 RVA: 0x0074CFAD File Offset: 0x0074B1AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603689A RID: 223386 RVA: 0x0074CFBC File Offset: 0x0074B1BC
		public ISkillOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E33F RID: 58175
		// (get) Token: 0x0603689B RID: 223387 RVA: 0x0074CFCC File Offset: 0x0074B1CC
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

		// Token: 0x0603689C RID: 223388 RVA: 0x0074D008 File Offset: 0x0074B208
		public static Offset<ISkillOperationType> CreateISkillOperationType(FlatBufferBuilder builder, ESkillOperationType Type = ESkillOperationType.Enable)
		{
			builder.StartTable(1);
			ISkillOperationType.AddType(builder, Type);
			return ISkillOperationType.EndISkillOperationType(builder);
		}

		// Token: 0x0603689D RID: 223389 RVA: 0x0074D01E File Offset: 0x0074B21E
		public static void StartISkillOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603689E RID: 223390 RVA: 0x0074D027 File Offset: 0x0074B227
		public static void AddType(FlatBufferBuilder builder, ESkillOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603689F RID: 223391 RVA: 0x0074D032 File Offset: 0x0074B232
		public static Offset<ISkillOperationType> EndISkillOperationType(FlatBufferBuilder builder)
		{
			return new Offset<ISkillOperationType>(builder.EndTable());
		}

		// Token: 0x060368A0 RID: 223392 RVA: 0x0074D040 File Offset: 0x0074B240
		public ISkillOperationTypeT UnPack()
		{
			ISkillOperationTypeT skillOperationTypeT = new ISkillOperationTypeT();
			this.UnPackTo(skillOperationTypeT);
			return skillOperationTypeT;
		}

		// Token: 0x060368A1 RID: 223393 RVA: 0x0074D05B File Offset: 0x0074B25B
		public void UnPackTo(ISkillOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060368A2 RID: 223394 RVA: 0x0074D06C File Offset: 0x0074B26C
		public static Offset<ISkillOperationType> Pack(FlatBufferBuilder builder, ISkillOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillOperationType>);
			}
			return ISkillOperationType.CreateISkillOperationType(builder, _o.Type);
		}

		// Token: 0x04012BB7 RID: 76727
		private Table __p;
	}
}

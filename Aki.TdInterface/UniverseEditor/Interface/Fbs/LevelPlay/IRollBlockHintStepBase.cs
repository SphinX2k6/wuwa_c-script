using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004581 RID: 17793
	public struct IRollBlockHintStepBase : IFlatbufferObject
	{
		// Token: 0x17007E6F RID: 32367
		// (get) Token: 0x0601AE01 RID: 110081 RVA: 0x003D605D File Offset: 0x003D425D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AE02 RID: 110082 RVA: 0x003D606A File Offset: 0x003D426A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AE03 RID: 110083 RVA: 0x003D6074 File Offset: 0x003D4274
		public static IRollBlockHintStepBase GetRootAsIRollBlockHintStepBase(ByteBuffer _bb)
		{
			return IRollBlockHintStepBase.GetRootAsIRollBlockHintStepBase(_bb, default(IRollBlockHintStepBase));
		}

		// Token: 0x0601AE04 RID: 110084 RVA: 0x003D6090 File Offset: 0x003D4290
		public static IRollBlockHintStepBase GetRootAsIRollBlockHintStepBase(ByteBuffer _bb, IRollBlockHintStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AE05 RID: 110085 RVA: 0x003D60AD File Offset: 0x003D42AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AE06 RID: 110086 RVA: 0x003D60BC File Offset: 0x003D42BC
		public IRollBlockHintStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E70 RID: 32368
		// (get) Token: 0x0601AE07 RID: 110087 RVA: 0x003D60CC File Offset: 0x003D42CC
		public ERollBlockHintStepType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockHintStepType.Roll;
				}
				return (ERollBlockHintStepType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AE08 RID: 110088 RVA: 0x003D6108 File Offset: 0x003D4308
		public static Offset<IRollBlockHintStepBase> CreateIRollBlockHintStepBase(FlatBufferBuilder builder, ERollBlockHintStepType Type = ERollBlockHintStepType.Roll)
		{
			builder.StartTable(1);
			IRollBlockHintStepBase.AddType(builder, Type);
			return IRollBlockHintStepBase.EndIRollBlockHintStepBase(builder);
		}

		// Token: 0x0601AE09 RID: 110089 RVA: 0x003D611E File Offset: 0x003D431E
		public static void StartIRollBlockHintStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AE0A RID: 110090 RVA: 0x003D6127 File Offset: 0x003D4327
		public static void AddType(FlatBufferBuilder builder, ERollBlockHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AE0B RID: 110091 RVA: 0x003D6132 File Offset: 0x003D4332
		public static Offset<IRollBlockHintStepBase> EndIRollBlockHintStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockHintStepBase>(builder.EndTable());
		}

		// Token: 0x0601AE0C RID: 110092 RVA: 0x003D6140 File Offset: 0x003D4340
		public IRollBlockHintStepBaseT UnPack()
		{
			IRollBlockHintStepBaseT rollBlockHintStepBaseT = new IRollBlockHintStepBaseT();
			this.UnPackTo(rollBlockHintStepBaseT);
			return rollBlockHintStepBaseT;
		}

		// Token: 0x0601AE0D RID: 110093 RVA: 0x003D615B File Offset: 0x003D435B
		public void UnPackTo(IRollBlockHintStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AE0E RID: 110094 RVA: 0x003D616C File Offset: 0x003D436C
		public static Offset<IRollBlockHintStepBase> Pack(FlatBufferBuilder builder, IRollBlockHintStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockHintStepBase>);
			}
			return IRollBlockHintStepBase.CreateIRollBlockHintStepBase(builder, _o.Type);
		}

		// Token: 0x0400C636 RID: 50742
		private Table __p;
	}
}

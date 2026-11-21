using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049E9 RID: 18921
	public struct IRollBlockHintStepBase : IFlatbufferObject
	{
		// Token: 0x170084B0 RID: 33968
		// (get) Token: 0x0601C5D6 RID: 116182 RVA: 0x004022F9 File Offset: 0x004004F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C5D7 RID: 116183 RVA: 0x00402306 File Offset: 0x00400506
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C5D8 RID: 116184 RVA: 0x00402310 File Offset: 0x00400510
		public static IRollBlockHintStepBase GetRootAsIRollBlockHintStepBase(ByteBuffer _bb)
		{
			return IRollBlockHintStepBase.GetRootAsIRollBlockHintStepBase(_bb, default(IRollBlockHintStepBase));
		}

		// Token: 0x0601C5D9 RID: 116185 RVA: 0x0040232C File Offset: 0x0040052C
		public static IRollBlockHintStepBase GetRootAsIRollBlockHintStepBase(ByteBuffer _bb, IRollBlockHintStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C5DA RID: 116186 RVA: 0x00402349 File Offset: 0x00400549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C5DB RID: 116187 RVA: 0x00402358 File Offset: 0x00400558
		public IRollBlockHintStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084B1 RID: 33969
		// (get) Token: 0x0601C5DC RID: 116188 RVA: 0x00402368 File Offset: 0x00400568
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

		// Token: 0x0601C5DD RID: 116189 RVA: 0x004023A4 File Offset: 0x004005A4
		public static Offset<IRollBlockHintStepBase> CreateIRollBlockHintStepBase(FlatBufferBuilder builder, ERollBlockHintStepType Type = ERollBlockHintStepType.Roll)
		{
			builder.StartTable(1);
			IRollBlockHintStepBase.AddType(builder, Type);
			return IRollBlockHintStepBase.EndIRollBlockHintStepBase(builder);
		}

		// Token: 0x0601C5DE RID: 116190 RVA: 0x004023BA File Offset: 0x004005BA
		public static void StartIRollBlockHintStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C5DF RID: 116191 RVA: 0x004023C3 File Offset: 0x004005C3
		public static void AddType(FlatBufferBuilder builder, ERollBlockHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C5E0 RID: 116192 RVA: 0x004023CE File Offset: 0x004005CE
		public static Offset<IRollBlockHintStepBase> EndIRollBlockHintStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockHintStepBase>(builder.EndTable());
		}

		// Token: 0x0601C5E1 RID: 116193 RVA: 0x004023DC File Offset: 0x004005DC
		public IRollBlockHintStepBaseT UnPack()
		{
			IRollBlockHintStepBaseT rollBlockHintStepBaseT = new IRollBlockHintStepBaseT();
			this.UnPackTo(rollBlockHintStepBaseT);
			return rollBlockHintStepBaseT;
		}

		// Token: 0x0601C5E2 RID: 116194 RVA: 0x004023F7 File Offset: 0x004005F7
		public void UnPackTo(IRollBlockHintStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C5E3 RID: 116195 RVA: 0x00402408 File Offset: 0x00400608
		public static Offset<IRollBlockHintStepBase> Pack(FlatBufferBuilder builder, IRollBlockHintStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockHintStepBase>);
			}
			return IRollBlockHintStepBase.CreateIRollBlockHintStepBase(builder, _o.Type);
		}

		// Token: 0x0400D065 RID: 53349
		private Table __p;
	}
}

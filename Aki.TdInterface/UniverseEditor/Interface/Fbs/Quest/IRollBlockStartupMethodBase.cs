using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040F1 RID: 16625
	public struct IRollBlockStartupMethodBase : IFlatbufferObject
	{
		// Token: 0x1700752D RID: 29997
		// (get) Token: 0x060183AB RID: 99243 RVA: 0x0037D022 File Offset: 0x0037B222
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060183AC RID: 99244 RVA: 0x0037D02F File Offset: 0x0037B22F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060183AD RID: 99245 RVA: 0x0037D038 File Offset: 0x0037B238
		public static IRollBlockStartupMethodBase GetRootAsIRollBlockStartupMethodBase(ByteBuffer _bb)
		{
			return IRollBlockStartupMethodBase.GetRootAsIRollBlockStartupMethodBase(_bb, default(IRollBlockStartupMethodBase));
		}

		// Token: 0x060183AE RID: 99246 RVA: 0x0037D054 File Offset: 0x0037B254
		public static IRollBlockStartupMethodBase GetRootAsIRollBlockStartupMethodBase(ByteBuffer _bb, IRollBlockStartupMethodBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060183AF RID: 99247 RVA: 0x0037D071 File Offset: 0x0037B271
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060183B0 RID: 99248 RVA: 0x0037D080 File Offset: 0x0037B280
		public IRollBlockStartupMethodBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700752E RID: 29998
		// (get) Token: 0x060183B1 RID: 99249 RVA: 0x0037D090 File Offset: 0x0037B290
		public ERollBlockLaunchMethod Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockLaunchMethod.Interact;
				}
				return (ERollBlockLaunchMethod)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060183B2 RID: 99250 RVA: 0x0037D0CC File Offset: 0x0037B2CC
		public static Offset<IRollBlockStartupMethodBase> CreateIRollBlockStartupMethodBase(FlatBufferBuilder builder, ERollBlockLaunchMethod Type = ERollBlockLaunchMethod.Interact)
		{
			builder.StartTable(1);
			IRollBlockStartupMethodBase.AddType(builder, Type);
			return IRollBlockStartupMethodBase.EndIRollBlockStartupMethodBase(builder);
		}

		// Token: 0x060183B3 RID: 99251 RVA: 0x0037D0E2 File Offset: 0x0037B2E2
		public static void StartIRollBlockStartupMethodBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060183B4 RID: 99252 RVA: 0x0037D0EB File Offset: 0x0037B2EB
		public static void AddType(FlatBufferBuilder builder, ERollBlockLaunchMethod type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060183B5 RID: 99253 RVA: 0x0037D0F6 File Offset: 0x0037B2F6
		public static Offset<IRollBlockStartupMethodBase> EndIRollBlockStartupMethodBase(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockStartupMethodBase>(builder.EndTable());
		}

		// Token: 0x060183B6 RID: 99254 RVA: 0x0037D104 File Offset: 0x0037B304
		public IRollBlockStartupMethodBaseT UnPack()
		{
			IRollBlockStartupMethodBaseT rollBlockStartupMethodBaseT = new IRollBlockStartupMethodBaseT();
			this.UnPackTo(rollBlockStartupMethodBaseT);
			return rollBlockStartupMethodBaseT;
		}

		// Token: 0x060183B7 RID: 99255 RVA: 0x0037D11F File Offset: 0x0037B31F
		public void UnPackTo(IRollBlockStartupMethodBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060183B8 RID: 99256 RVA: 0x0037D130 File Offset: 0x0037B330
		public static Offset<IRollBlockStartupMethodBase> Pack(FlatBufferBuilder builder, IRollBlockStartupMethodBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockStartupMethodBase>);
			}
			return IRollBlockStartupMethodBase.CreateIRollBlockStartupMethodBase(builder, _o.Type);
		}

		// Token: 0x0400BC88 RID: 48264
		private Table __p;
	}
}

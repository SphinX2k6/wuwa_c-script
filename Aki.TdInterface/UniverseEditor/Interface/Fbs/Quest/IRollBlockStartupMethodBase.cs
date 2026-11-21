using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004532 RID: 17714
	public struct IRollBlockStartupMethodBase : IFlatbufferObject
	{
		// Token: 0x17007B33 RID: 31539
		// (get) Token: 0x06019A4C RID: 105036 RVA: 0x003A6F72 File Offset: 0x003A5172
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019A4D RID: 105037 RVA: 0x003A6F7F File Offset: 0x003A517F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019A4E RID: 105038 RVA: 0x003A6F88 File Offset: 0x003A5188
		public static IRollBlockStartupMethodBase GetRootAsIRollBlockStartupMethodBase(ByteBuffer _bb)
		{
			return IRollBlockStartupMethodBase.GetRootAsIRollBlockStartupMethodBase(_bb, default(IRollBlockStartupMethodBase));
		}

		// Token: 0x06019A4F RID: 105039 RVA: 0x003A6FA4 File Offset: 0x003A51A4
		public static IRollBlockStartupMethodBase GetRootAsIRollBlockStartupMethodBase(ByteBuffer _bb, IRollBlockStartupMethodBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019A50 RID: 105040 RVA: 0x003A6FC1 File Offset: 0x003A51C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019A51 RID: 105041 RVA: 0x003A6FD0 File Offset: 0x003A51D0
		public IRollBlockStartupMethodBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B34 RID: 31540
		// (get) Token: 0x06019A52 RID: 105042 RVA: 0x003A6FE0 File Offset: 0x003A51E0
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

		// Token: 0x06019A53 RID: 105043 RVA: 0x003A701C File Offset: 0x003A521C
		public static Offset<IRollBlockStartupMethodBase> CreateIRollBlockStartupMethodBase(FlatBufferBuilder builder, ERollBlockLaunchMethod Type = ERollBlockLaunchMethod.Interact)
		{
			builder.StartTable(1);
			IRollBlockStartupMethodBase.AddType(builder, Type);
			return IRollBlockStartupMethodBase.EndIRollBlockStartupMethodBase(builder);
		}

		// Token: 0x06019A54 RID: 105044 RVA: 0x003A7032 File Offset: 0x003A5232
		public static void StartIRollBlockStartupMethodBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019A55 RID: 105045 RVA: 0x003A703B File Offset: 0x003A523B
		public static void AddType(FlatBufferBuilder builder, ERollBlockLaunchMethod type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019A56 RID: 105046 RVA: 0x003A7046 File Offset: 0x003A5246
		public static Offset<IRollBlockStartupMethodBase> EndIRollBlockStartupMethodBase(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockStartupMethodBase>(builder.EndTable());
		}

		// Token: 0x06019A57 RID: 105047 RVA: 0x003A7054 File Offset: 0x003A5254
		public IRollBlockStartupMethodBaseT UnPack()
		{
			IRollBlockStartupMethodBaseT rollBlockStartupMethodBaseT = new IRollBlockStartupMethodBaseT();
			this.UnPackTo(rollBlockStartupMethodBaseT);
			return rollBlockStartupMethodBaseT;
		}

		// Token: 0x06019A58 RID: 105048 RVA: 0x003A706F File Offset: 0x003A526F
		public void UnPackTo(IRollBlockStartupMethodBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019A59 RID: 105049 RVA: 0x003A7080 File Offset: 0x003A5280
		public static Offset<IRollBlockStartupMethodBase> Pack(FlatBufferBuilder builder, IRollBlockStartupMethodBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockStartupMethodBase>);
			}
			return IRollBlockStartupMethodBase.CreateIRollBlockStartupMethodBase(builder, _o.Type);
		}

		// Token: 0x0400C671 RID: 50801
		private Table __p;
	}
}

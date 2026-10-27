using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040EE RID: 16622
	public struct IRollBlockLaunchMethodRange : IFlatbufferObject
	{
		// Token: 0x17007528 RID: 29992
		// (get) Token: 0x06018395 RID: 99221 RVA: 0x0037CE22 File Offset: 0x0037B022
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018396 RID: 99222 RVA: 0x0037CE2F File Offset: 0x0037B02F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018397 RID: 99223 RVA: 0x0037CE38 File Offset: 0x0037B038
		public static IRollBlockLaunchMethodRange GetRootAsIRollBlockLaunchMethodRange(ByteBuffer _bb)
		{
			return IRollBlockLaunchMethodRange.GetRootAsIRollBlockLaunchMethodRange(_bb, default(IRollBlockLaunchMethodRange));
		}

		// Token: 0x06018398 RID: 99224 RVA: 0x0037CE54 File Offset: 0x0037B054
		public static IRollBlockLaunchMethodRange GetRootAsIRollBlockLaunchMethodRange(ByteBuffer _bb, IRollBlockLaunchMethodRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018399 RID: 99225 RVA: 0x0037CE71 File Offset: 0x0037B071
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601839A RID: 99226 RVA: 0x0037CE80 File Offset: 0x0037B080
		public IRollBlockLaunchMethodRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007529 RID: 29993
		// (get) Token: 0x0601839B RID: 99227 RVA: 0x0037CE90 File Offset: 0x0037B090
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

		// Token: 0x1700752A RID: 29994
		// (get) Token: 0x0601839C RID: 99228 RVA: 0x0037CECC File Offset: 0x0037B0CC
		public int TargetId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601839D RID: 99229 RVA: 0x0037CF08 File Offset: 0x0037B108
		public static Offset<IRollBlockLaunchMethodRange> CreateIRollBlockLaunchMethodRange(FlatBufferBuilder builder, ERollBlockLaunchMethod Type = ERollBlockLaunchMethod.Interact, int TargetId = 0)
		{
			builder.StartTable(2);
			IRollBlockLaunchMethodRange.AddTargetId(builder, TargetId);
			IRollBlockLaunchMethodRange.AddType(builder, Type);
			return IRollBlockLaunchMethodRange.EndIRollBlockLaunchMethodRange(builder);
		}

		// Token: 0x0601839E RID: 99230 RVA: 0x0037CF25 File Offset: 0x0037B125
		public static void StartIRollBlockLaunchMethodRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601839F RID: 99231 RVA: 0x0037CF2E File Offset: 0x0037B12E
		public static void AddType(FlatBufferBuilder builder, ERollBlockLaunchMethod type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060183A0 RID: 99232 RVA: 0x0037CF39 File Offset: 0x0037B139
		public static void AddTargetId(FlatBufferBuilder builder, int targetId)
		{
			builder.AddInt(1, targetId, 0);
		}

		// Token: 0x060183A1 RID: 99233 RVA: 0x0037CF44 File Offset: 0x0037B144
		public static Offset<IRollBlockLaunchMethodRange> EndIRollBlockLaunchMethodRange(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockLaunchMethodRange>(builder.EndTable());
		}

		// Token: 0x060183A2 RID: 99234 RVA: 0x0037CF54 File Offset: 0x0037B154
		public IRollBlockLaunchMethodRangeT UnPack()
		{
			IRollBlockLaunchMethodRangeT rollBlockLaunchMethodRangeT = new IRollBlockLaunchMethodRangeT();
			this.UnPackTo(rollBlockLaunchMethodRangeT);
			return rollBlockLaunchMethodRangeT;
		}

		// Token: 0x060183A3 RID: 99235 RVA: 0x0037CF6F File Offset: 0x0037B16F
		public void UnPackTo(IRollBlockLaunchMethodRangeT _o)
		{
			_o.Type = this.Type;
			_o.TargetId = this.TargetId;
		}

		// Token: 0x060183A4 RID: 99236 RVA: 0x0037CF8C File Offset: 0x0037B18C
		public static Offset<IRollBlockLaunchMethodRange> Pack(FlatBufferBuilder builder, IRollBlockLaunchMethodRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockLaunchMethodRange>);
			}
			return IRollBlockLaunchMethodRange.CreateIRollBlockLaunchMethodRange(builder, _o.Type, _o.TargetId);
		}

		// Token: 0x0400BC85 RID: 48261
		private Table __p;
	}
}

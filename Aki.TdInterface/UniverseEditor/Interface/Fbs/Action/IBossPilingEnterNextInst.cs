using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006215 RID: 25109
	public struct IBossPilingEnterNextInst : IFlatbufferObject
	{
		// Token: 0x1700BB21 RID: 47905
		// (get) Token: 0x0602B47F RID: 177279 RVA: 0x005F622E File Offset: 0x005F442E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B480 RID: 177280 RVA: 0x005F623B File Offset: 0x005F443B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B481 RID: 177281 RVA: 0x005F6244 File Offset: 0x005F4444
		public static IBossPilingEnterNextInst GetRootAsIBossPilingEnterNextInst(ByteBuffer _bb)
		{
			return IBossPilingEnterNextInst.GetRootAsIBossPilingEnterNextInst(_bb, default(IBossPilingEnterNextInst));
		}

		// Token: 0x0602B482 RID: 177282 RVA: 0x005F6260 File Offset: 0x005F4460
		public static IBossPilingEnterNextInst GetRootAsIBossPilingEnterNextInst(ByteBuffer _bb, IBossPilingEnterNextInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B483 RID: 177283 RVA: 0x005F627D File Offset: 0x005F447D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B484 RID: 177284 RVA: 0x005F628C File Offset: 0x005F448C
		public IBossPilingEnterNextInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602B485 RID: 177285 RVA: 0x005F629C File Offset: 0x005F449C
		public static void StartIBossPilingEnterNextInst(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602B486 RID: 177286 RVA: 0x005F62A5 File Offset: 0x005F44A5
		public static Offset<IBossPilingEnterNextInst> EndIBossPilingEnterNextInst(FlatBufferBuilder builder)
		{
			return new Offset<IBossPilingEnterNextInst>(builder.EndTable());
		}

		// Token: 0x0602B487 RID: 177287 RVA: 0x005F62B4 File Offset: 0x005F44B4
		public IBossPilingEnterNextInstT UnPack()
		{
			IBossPilingEnterNextInstT bossPilingEnterNextInstT = new IBossPilingEnterNextInstT();
			this.UnPackTo(bossPilingEnterNextInstT);
			return bossPilingEnterNextInstT;
		}

		// Token: 0x0602B488 RID: 177288 RVA: 0x005F62CF File Offset: 0x005F44CF
		public void UnPackTo(IBossPilingEnterNextInstT _o)
		{
		}

		// Token: 0x0602B489 RID: 177289 RVA: 0x005F62D4 File Offset: 0x005F44D4
		public static Offset<IBossPilingEnterNextInst> Pack(FlatBufferBuilder builder, IBossPilingEnterNextInstT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBossPilingEnterNextInst>);
			}
			IBossPilingEnterNextInst.StartIBossPilingEnterNextInst(builder);
			return IBossPilingEnterNextInst.EndIBossPilingEnterNextInst(builder);
		}

		// Token: 0x04010755 RID: 67413
		private Table __p;
	}
}

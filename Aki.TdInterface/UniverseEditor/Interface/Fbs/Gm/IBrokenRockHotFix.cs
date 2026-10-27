using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200463C RID: 17980
	public struct IBrokenRockHotFix : IFlatbufferObject
	{
		// Token: 0x17007F96 RID: 32662
		// (get) Token: 0x0601B3B7 RID: 111543 RVA: 0x003E04FE File Offset: 0x003DE6FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B3B8 RID: 111544 RVA: 0x003E050B File Offset: 0x003DE70B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B3B9 RID: 111545 RVA: 0x003E0514 File Offset: 0x003DE714
		public static IBrokenRockHotFix GetRootAsIBrokenRockHotFix(ByteBuffer _bb)
		{
			return IBrokenRockHotFix.GetRootAsIBrokenRockHotFix(_bb, default(IBrokenRockHotFix));
		}

		// Token: 0x0601B3BA RID: 111546 RVA: 0x003E0530 File Offset: 0x003DE730
		public static IBrokenRockHotFix GetRootAsIBrokenRockHotFix(ByteBuffer _bb, IBrokenRockHotFix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B3BB RID: 111547 RVA: 0x003E054D File Offset: 0x003DE74D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B3BC RID: 111548 RVA: 0x003E055C File Offset: 0x003DE75C
		public IBrokenRockHotFix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F97 RID: 32663
		// (get) Token: 0x0601B3BD RID: 111549 RVA: 0x003E056C File Offset: 0x003DE76C
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B3BE RID: 111550 RVA: 0x003E05A8 File Offset: 0x003DE7A8
		public static Offset<IBrokenRockHotFix> CreateIBrokenRockHotFix(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IBrokenRockHotFix.AddType(builder, Type);
			return IBrokenRockHotFix.EndIBrokenRockHotFix(builder);
		}

		// Token: 0x0601B3BF RID: 111551 RVA: 0x003E05BE File Offset: 0x003DE7BE
		public static void StartIBrokenRockHotFix(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B3C0 RID: 111552 RVA: 0x003E05C7 File Offset: 0x003DE7C7
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B3C1 RID: 111553 RVA: 0x003E05D2 File Offset: 0x003DE7D2
		public static Offset<IBrokenRockHotFix> EndIBrokenRockHotFix(FlatBufferBuilder builder)
		{
			return new Offset<IBrokenRockHotFix>(builder.EndTable());
		}

		// Token: 0x0601B3C2 RID: 111554 RVA: 0x003E05E0 File Offset: 0x003DE7E0
		public IBrokenRockHotFixT UnPack()
		{
			IBrokenRockHotFixT brokenRockHotFixT = new IBrokenRockHotFixT();
			this.UnPackTo(brokenRockHotFixT);
			return brokenRockHotFixT;
		}

		// Token: 0x0601B3C3 RID: 111555 RVA: 0x003E05FB File Offset: 0x003DE7FB
		public void UnPackTo(IBrokenRockHotFixT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B3C4 RID: 111556 RVA: 0x003E060C File Offset: 0x003DE80C
		public static Offset<IBrokenRockHotFix> Pack(FlatBufferBuilder builder, IBrokenRockHotFixT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBrokenRockHotFix>);
			}
			return IBrokenRockHotFix.CreateIBrokenRockHotFix(builder, _o.Type);
		}

		// Token: 0x0400C7B3 RID: 51123
		private Table __p;
	}
}

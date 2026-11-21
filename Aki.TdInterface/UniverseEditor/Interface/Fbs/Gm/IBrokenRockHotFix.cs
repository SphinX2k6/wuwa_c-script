using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AA4 RID: 19108
	public struct IBrokenRockHotFix : IFlatbufferObject
	{
		// Token: 0x170085D7 RID: 34263
		// (get) Token: 0x0601CB8C RID: 117644 RVA: 0x0040C79A File Offset: 0x0040A99A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CB8D RID: 117645 RVA: 0x0040C7A7 File Offset: 0x0040A9A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CB8E RID: 117646 RVA: 0x0040C7B0 File Offset: 0x0040A9B0
		public static IBrokenRockHotFix GetRootAsIBrokenRockHotFix(ByteBuffer _bb)
		{
			return IBrokenRockHotFix.GetRootAsIBrokenRockHotFix(_bb, default(IBrokenRockHotFix));
		}

		// Token: 0x0601CB8F RID: 117647 RVA: 0x0040C7CC File Offset: 0x0040A9CC
		public static IBrokenRockHotFix GetRootAsIBrokenRockHotFix(ByteBuffer _bb, IBrokenRockHotFix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CB90 RID: 117648 RVA: 0x0040C7E9 File Offset: 0x0040A9E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CB91 RID: 117649 RVA: 0x0040C7F8 File Offset: 0x0040A9F8
		public IBrokenRockHotFix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085D8 RID: 34264
		// (get) Token: 0x0601CB92 RID: 117650 RVA: 0x0040C808 File Offset: 0x0040AA08
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

		// Token: 0x0601CB93 RID: 117651 RVA: 0x0040C844 File Offset: 0x0040AA44
		public static Offset<IBrokenRockHotFix> CreateIBrokenRockHotFix(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IBrokenRockHotFix.AddType(builder, Type);
			return IBrokenRockHotFix.EndIBrokenRockHotFix(builder);
		}

		// Token: 0x0601CB94 RID: 117652 RVA: 0x0040C85A File Offset: 0x0040AA5A
		public static void StartIBrokenRockHotFix(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CB95 RID: 117653 RVA: 0x0040C863 File Offset: 0x0040AA63
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CB96 RID: 117654 RVA: 0x0040C86E File Offset: 0x0040AA6E
		public static Offset<IBrokenRockHotFix> EndIBrokenRockHotFix(FlatBufferBuilder builder)
		{
			return new Offset<IBrokenRockHotFix>(builder.EndTable());
		}

		// Token: 0x0601CB97 RID: 117655 RVA: 0x0040C87C File Offset: 0x0040AA7C
		public IBrokenRockHotFixT UnPack()
		{
			IBrokenRockHotFixT brokenRockHotFixT = new IBrokenRockHotFixT();
			this.UnPackTo(brokenRockHotFixT);
			return brokenRockHotFixT;
		}

		// Token: 0x0601CB98 RID: 117656 RVA: 0x0040C897 File Offset: 0x0040AA97
		public void UnPackTo(IBrokenRockHotFixT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CB99 RID: 117657 RVA: 0x0040C8A8 File Offset: 0x0040AAA8
		public static Offset<IBrokenRockHotFix> Pack(FlatBufferBuilder builder, IBrokenRockHotFixT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBrokenRockHotFix>);
			}
			return IBrokenRockHotFix.CreateIBrokenRockHotFix(builder, _o.Type);
		}

		// Token: 0x0400D1E2 RID: 53730
		private Table __p;
	}
}

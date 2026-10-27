using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DCE RID: 28110
	public struct IPromptStyleBattle2 : IFlatbufferObject
	{
		// Token: 0x1700D194 RID: 53652
		// (get) Token: 0x06031A6F RID: 203375 RVA: 0x006B9E91 File Offset: 0x006B8091
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A70 RID: 203376 RVA: 0x006B9E9E File Offset: 0x006B809E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A71 RID: 203377 RVA: 0x006B9EA8 File Offset: 0x006B80A8
		public static IPromptStyleBattle2 GetRootAsIPromptStyleBattle2(ByteBuffer _bb)
		{
			return IPromptStyleBattle2.GetRootAsIPromptStyleBattle2(_bb, default(IPromptStyleBattle2));
		}

		// Token: 0x06031A72 RID: 203378 RVA: 0x006B9EC4 File Offset: 0x006B80C4
		public static IPromptStyleBattle2 GetRootAsIPromptStyleBattle2(ByteBuffer _bb, IPromptStyleBattle2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A73 RID: 203379 RVA: 0x006B9EE1 File Offset: 0x006B80E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A74 RID: 203380 RVA: 0x006B9EF0 File Offset: 0x006B80F0
		public IPromptStyleBattle2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D195 RID: 53653
		// (get) Token: 0x06031A75 RID: 203381 RVA: 0x006B9F00 File Offset: 0x006B8100
		public EPromptStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPromptStyle.Default;
				}
				return (EPromptStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031A76 RID: 203382 RVA: 0x006B9F3C File Offset: 0x006B813C
		public static Offset<IPromptStyleBattle2> CreateIPromptStyleBattle2(FlatBufferBuilder builder, EPromptStyle Type = EPromptStyle.Default)
		{
			builder.StartTable(1);
			IPromptStyleBattle2.AddType(builder, Type);
			return IPromptStyleBattle2.EndIPromptStyleBattle2(builder);
		}

		// Token: 0x06031A77 RID: 203383 RVA: 0x006B9F52 File Offset: 0x006B8152
		public static void StartIPromptStyleBattle2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031A78 RID: 203384 RVA: 0x006B9F5B File Offset: 0x006B815B
		public static void AddType(FlatBufferBuilder builder, EPromptStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031A79 RID: 203385 RVA: 0x006B9F66 File Offset: 0x006B8166
		public static Offset<IPromptStyleBattle2> EndIPromptStyleBattle2(FlatBufferBuilder builder)
		{
			return new Offset<IPromptStyleBattle2>(builder.EndTable());
		}

		// Token: 0x06031A7A RID: 203386 RVA: 0x006B9F74 File Offset: 0x006B8174
		public IPromptStyleBattle2T UnPack()
		{
			IPromptStyleBattle2T promptStyleBattle2T = new IPromptStyleBattle2T();
			this.UnPackTo(promptStyleBattle2T);
			return promptStyleBattle2T;
		}

		// Token: 0x06031A7B RID: 203387 RVA: 0x006B9F8F File Offset: 0x006B818F
		public void UnPackTo(IPromptStyleBattle2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031A7C RID: 203388 RVA: 0x006B9FA0 File Offset: 0x006B81A0
		public static Offset<IPromptStyleBattle2> Pack(FlatBufferBuilder builder, IPromptStyleBattle2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptStyleBattle2>);
			}
			return IPromptStyleBattle2.CreateIPromptStyleBattle2(builder, _o.Type);
		}

		// Token: 0x040117B0 RID: 71600
		private Table __p;
	}
}

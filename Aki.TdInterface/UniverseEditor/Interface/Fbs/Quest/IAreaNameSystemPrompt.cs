using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004124 RID: 16676
	public struct IAreaNameSystemPrompt : IFlatbufferObject
	{
		// Token: 0x170070F2 RID: 28914
		// (get) Token: 0x06016E27 RID: 93735 RVA: 0x003446F2 File Offset: 0x003428F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016E28 RID: 93736 RVA: 0x003446FF File Offset: 0x003428FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016E29 RID: 93737 RVA: 0x00344708 File Offset: 0x00342908
		public static IAreaNameSystemPrompt GetRootAsIAreaNameSystemPrompt(ByteBuffer _bb)
		{
			return IAreaNameSystemPrompt.GetRootAsIAreaNameSystemPrompt(_bb, default(IAreaNameSystemPrompt));
		}

		// Token: 0x06016E2A RID: 93738 RVA: 0x00344724 File Offset: 0x00342924
		public static IAreaNameSystemPrompt GetRootAsIAreaNameSystemPrompt(ByteBuffer _bb, IAreaNameSystemPrompt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016E2B RID: 93739 RVA: 0x00344741 File Offset: 0x00342941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016E2C RID: 93740 RVA: 0x00344750 File Offset: 0x00342950
		public IAreaNameSystemPrompt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070F3 RID: 28915
		// (get) Token: 0x06016E2D RID: 93741 RVA: 0x00344760 File Offset: 0x00342960
		public ESystemPromptType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemPromptType.AreaName;
				}
				return (ESystemPromptType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016E2E RID: 93742 RVA: 0x0034479C File Offset: 0x0034299C
		public static Offset<IAreaNameSystemPrompt> CreateIAreaNameSystemPrompt(FlatBufferBuilder builder, ESystemPromptType Type = ESystemPromptType.AreaName)
		{
			builder.StartTable(1);
			IAreaNameSystemPrompt.AddType(builder, Type);
			return IAreaNameSystemPrompt.EndIAreaNameSystemPrompt(builder);
		}

		// Token: 0x06016E2F RID: 93743 RVA: 0x003447B2 File Offset: 0x003429B2
		public static void StartIAreaNameSystemPrompt(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016E30 RID: 93744 RVA: 0x003447BB File Offset: 0x003429BB
		public static void AddType(FlatBufferBuilder builder, ESystemPromptType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016E31 RID: 93745 RVA: 0x003447C6 File Offset: 0x003429C6
		public static Offset<IAreaNameSystemPrompt> EndIAreaNameSystemPrompt(FlatBufferBuilder builder)
		{
			return new Offset<IAreaNameSystemPrompt>(builder.EndTable());
		}

		// Token: 0x06016E32 RID: 93746 RVA: 0x003447D4 File Offset: 0x003429D4
		public IAreaNameSystemPromptT UnPack()
		{
			IAreaNameSystemPromptT areaNameSystemPromptT = new IAreaNameSystemPromptT();
			this.UnPackTo(areaNameSystemPromptT);
			return areaNameSystemPromptT;
		}

		// Token: 0x06016E33 RID: 93747 RVA: 0x003447EF File Offset: 0x003429EF
		public void UnPackTo(IAreaNameSystemPromptT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016E34 RID: 93748 RVA: 0x00344800 File Offset: 0x00342A00
		public static Offset<IAreaNameSystemPrompt> Pack(FlatBufferBuilder builder, IAreaNameSystemPromptT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaNameSystemPrompt>);
			}
			return IAreaNameSystemPrompt.CreateIAreaNameSystemPrompt(builder, _o.Type);
		}

		// Token: 0x0400BF6E RID: 49006
		private Table __p;
	}
}

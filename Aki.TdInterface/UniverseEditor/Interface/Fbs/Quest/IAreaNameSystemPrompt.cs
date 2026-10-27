using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D0D RID: 15629
	public struct IAreaNameSystemPrompt : IFlatbufferObject
	{
		// Token: 0x17006B38 RID: 27448
		// (get) Token: 0x060158EF RID: 88303 RVA: 0x0031D47A File Offset: 0x0031B67A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060158F0 RID: 88304 RVA: 0x0031D487 File Offset: 0x0031B687
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060158F1 RID: 88305 RVA: 0x0031D490 File Offset: 0x0031B690
		public static IAreaNameSystemPrompt GetRootAsIAreaNameSystemPrompt(ByteBuffer _bb)
		{
			return IAreaNameSystemPrompt.GetRootAsIAreaNameSystemPrompt(_bb, default(IAreaNameSystemPrompt));
		}

		// Token: 0x060158F2 RID: 88306 RVA: 0x0031D4AC File Offset: 0x0031B6AC
		public static IAreaNameSystemPrompt GetRootAsIAreaNameSystemPrompt(ByteBuffer _bb, IAreaNameSystemPrompt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060158F3 RID: 88307 RVA: 0x0031D4C9 File Offset: 0x0031B6C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060158F4 RID: 88308 RVA: 0x0031D4D8 File Offset: 0x0031B6D8
		public IAreaNameSystemPrompt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B39 RID: 27449
		// (get) Token: 0x060158F5 RID: 88309 RVA: 0x0031D4E8 File Offset: 0x0031B6E8
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

		// Token: 0x060158F6 RID: 88310 RVA: 0x0031D524 File Offset: 0x0031B724
		public static Offset<IAreaNameSystemPrompt> CreateIAreaNameSystemPrompt(FlatBufferBuilder builder, ESystemPromptType Type = ESystemPromptType.AreaName)
		{
			builder.StartTable(1);
			IAreaNameSystemPrompt.AddType(builder, Type);
			return IAreaNameSystemPrompt.EndIAreaNameSystemPrompt(builder);
		}

		// Token: 0x060158F7 RID: 88311 RVA: 0x0031D53A File Offset: 0x0031B73A
		public static void StartIAreaNameSystemPrompt(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060158F8 RID: 88312 RVA: 0x0031D543 File Offset: 0x0031B743
		public static void AddType(FlatBufferBuilder builder, ESystemPromptType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060158F9 RID: 88313 RVA: 0x0031D54E File Offset: 0x0031B74E
		public static Offset<IAreaNameSystemPrompt> EndIAreaNameSystemPrompt(FlatBufferBuilder builder)
		{
			return new Offset<IAreaNameSystemPrompt>(builder.EndTable());
		}

		// Token: 0x060158FA RID: 88314 RVA: 0x0031D55C File Offset: 0x0031B75C
		public IAreaNameSystemPromptT UnPack()
		{
			IAreaNameSystemPromptT areaNameSystemPromptT = new IAreaNameSystemPromptT();
			this.UnPackTo(areaNameSystemPromptT);
			return areaNameSystemPromptT;
		}

		// Token: 0x060158FB RID: 88315 RVA: 0x0031D577 File Offset: 0x0031B777
		public void UnPackTo(IAreaNameSystemPromptT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060158FC RID: 88316 RVA: 0x0031D588 File Offset: 0x0031B788
		public static Offset<IAreaNameSystemPrompt> Pack(FlatBufferBuilder builder, IAreaNameSystemPromptT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaNameSystemPrompt>);
			}
			return IAreaNameSystemPrompt.CreateIAreaNameSystemPrompt(builder, _o.Type);
		}

		// Token: 0x0400B5C1 RID: 46529
		private Table __p;
	}
}

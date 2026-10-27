using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004172 RID: 16754
	public struct ISystemPromptType : IFlatbufferObject
	{
		// Token: 0x170076A8 RID: 30376
		// (get) Token: 0x060189C7 RID: 100807 RVA: 0x0038B890 File Offset: 0x00389A90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060189C8 RID: 100808 RVA: 0x0038B89D File Offset: 0x00389A9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060189C9 RID: 100809 RVA: 0x0038B8A4 File Offset: 0x00389AA4
		public static ISystemPromptType GetRootAsISystemPromptType(ByteBuffer _bb)
		{
			return ISystemPromptType.GetRootAsISystemPromptType(_bb, default(ISystemPromptType));
		}

		// Token: 0x060189CA RID: 100810 RVA: 0x0038B8C0 File Offset: 0x00389AC0
		public static ISystemPromptType GetRootAsISystemPromptType(ByteBuffer _bb, ISystemPromptType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060189CB RID: 100811 RVA: 0x0038B8DD File Offset: 0x00389ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060189CC RID: 100812 RVA: 0x0038B8EC File Offset: 0x00389AEC
		public ISystemPromptType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076A9 RID: 30377
		// (get) Token: 0x060189CD RID: 100813 RVA: 0x0038B8FC File Offset: 0x00389AFC
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

		// Token: 0x060189CE RID: 100814 RVA: 0x0038B938 File Offset: 0x00389B38
		public static Offset<ISystemPromptType> CreateISystemPromptType(FlatBufferBuilder builder, ESystemPromptType Type = ESystemPromptType.AreaName)
		{
			builder.StartTable(1);
			ISystemPromptType.AddType(builder, Type);
			return ISystemPromptType.EndISystemPromptType(builder);
		}

		// Token: 0x060189CF RID: 100815 RVA: 0x0038B94E File Offset: 0x00389B4E
		public static void StartISystemPromptType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060189D0 RID: 100816 RVA: 0x0038B957 File Offset: 0x00389B57
		public static void AddType(FlatBufferBuilder builder, ESystemPromptType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060189D1 RID: 100817 RVA: 0x0038B962 File Offset: 0x00389B62
		public static Offset<ISystemPromptType> EndISystemPromptType(FlatBufferBuilder builder)
		{
			return new Offset<ISystemPromptType>(builder.EndTable());
		}

		// Token: 0x060189D2 RID: 100818 RVA: 0x0038B970 File Offset: 0x00389B70
		public ISystemPromptTypeT UnPack()
		{
			ISystemPromptTypeT systemPromptTypeT = new ISystemPromptTypeT();
			this.UnPackTo(systemPromptTypeT);
			return systemPromptTypeT;
		}

		// Token: 0x060189D3 RID: 100819 RVA: 0x0038B98B File Offset: 0x00389B8B
		public void UnPackTo(ISystemPromptTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060189D4 RID: 100820 RVA: 0x0038B99C File Offset: 0x00389B9C
		public static Offset<ISystemPromptType> Pack(FlatBufferBuilder builder, ISystemPromptTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemPromptType>);
			}
			return ISystemPromptType.CreateISystemPromptType(builder, _o.Type);
		}

		// Token: 0x0400BD8D RID: 48525
		private Table __p;
	}
}

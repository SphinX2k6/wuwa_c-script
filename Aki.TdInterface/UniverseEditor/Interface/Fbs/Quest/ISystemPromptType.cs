using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045B6 RID: 17846
	public struct ISystemPromptType : IFlatbufferObject
	{
		// Token: 0x17007CB7 RID: 31927
		// (get) Token: 0x0601A08F RID: 106639 RVA: 0x003B5E4C File Offset: 0x003B404C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A090 RID: 106640 RVA: 0x003B5E59 File Offset: 0x003B4059
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A091 RID: 106641 RVA: 0x003B5E60 File Offset: 0x003B4060
		public static ISystemPromptType GetRootAsISystemPromptType(ByteBuffer _bb)
		{
			return ISystemPromptType.GetRootAsISystemPromptType(_bb, default(ISystemPromptType));
		}

		// Token: 0x0601A092 RID: 106642 RVA: 0x003B5E7C File Offset: 0x003B407C
		public static ISystemPromptType GetRootAsISystemPromptType(ByteBuffer _bb, ISystemPromptType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A093 RID: 106643 RVA: 0x003B5E99 File Offset: 0x003B4099
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A094 RID: 106644 RVA: 0x003B5EA8 File Offset: 0x003B40A8
		public ISystemPromptType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CB8 RID: 31928
		// (get) Token: 0x0601A095 RID: 106645 RVA: 0x003B5EB8 File Offset: 0x003B40B8
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

		// Token: 0x0601A096 RID: 106646 RVA: 0x003B5EF4 File Offset: 0x003B40F4
		public static Offset<ISystemPromptType> CreateISystemPromptType(FlatBufferBuilder builder, ESystemPromptType Type = ESystemPromptType.AreaName)
		{
			builder.StartTable(1);
			ISystemPromptType.AddType(builder, Type);
			return ISystemPromptType.EndISystemPromptType(builder);
		}

		// Token: 0x0601A097 RID: 106647 RVA: 0x003B5F0A File Offset: 0x003B410A
		public static void StartISystemPromptType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A098 RID: 106648 RVA: 0x003B5F13 File Offset: 0x003B4113
		public static void AddType(FlatBufferBuilder builder, ESystemPromptType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A099 RID: 106649 RVA: 0x003B5F1E File Offset: 0x003B411E
		public static Offset<ISystemPromptType> EndISystemPromptType(FlatBufferBuilder builder)
		{
			return new Offset<ISystemPromptType>(builder.EndTable());
		}

		// Token: 0x0601A09A RID: 106650 RVA: 0x003B5F2C File Offset: 0x003B412C
		public ISystemPromptTypeT UnPack()
		{
			ISystemPromptTypeT systemPromptTypeT = new ISystemPromptTypeT();
			this.UnPackTo(systemPromptTypeT);
			return systemPromptTypeT;
		}

		// Token: 0x0601A09B RID: 106651 RVA: 0x003B5F47 File Offset: 0x003B4147
		public void UnPackTo(ISystemPromptTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A09C RID: 106652 RVA: 0x003B5F58 File Offset: 0x003B4158
		public static Offset<ISystemPromptType> Pack(FlatBufferBuilder builder, ISystemPromptTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemPromptType>);
			}
			return ISystemPromptType.CreateISystemPromptType(builder, _o.Type);
		}

		// Token: 0x0400C77B RID: 51067
		private Table __p;
	}
}

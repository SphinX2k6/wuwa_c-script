using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004244 RID: 16964
	public struct IUseSkillCheckBase : IFlatbufferObject
	{
		// Token: 0x17007873 RID: 30835
		// (get) Token: 0x0601916B RID: 102763 RVA: 0x0039BA87 File Offset: 0x00399C87
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601916C RID: 102764 RVA: 0x0039BA94 File Offset: 0x00399C94
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601916D RID: 102765 RVA: 0x0039BA9C File Offset: 0x00399C9C
		public static IUseSkillCheckBase GetRootAsIUseSkillCheckBase(ByteBuffer _bb)
		{
			return IUseSkillCheckBase.GetRootAsIUseSkillCheckBase(_bb, default(IUseSkillCheckBase));
		}

		// Token: 0x0601916E RID: 102766 RVA: 0x0039BAB8 File Offset: 0x00399CB8
		public static IUseSkillCheckBase GetRootAsIUseSkillCheckBase(ByteBuffer _bb, IUseSkillCheckBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601916F RID: 102767 RVA: 0x0039BAD5 File Offset: 0x00399CD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019170 RID: 102768 RVA: 0x0039BAE4 File Offset: 0x00399CE4
		public IUseSkillCheckBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007874 RID: 30836
		// (get) Token: 0x06019171 RID: 102769 RVA: 0x0039BAF4 File Offset: 0x00399CF4
		public EUseSkillCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUseSkillCheckType.CheckSkillGenre;
				}
				return (EUseSkillCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019172 RID: 102770 RVA: 0x0039BB30 File Offset: 0x00399D30
		public static Offset<IUseSkillCheckBase> CreateIUseSkillCheckBase(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre)
		{
			builder.StartTable(1);
			IUseSkillCheckBase.AddType(builder, Type);
			return IUseSkillCheckBase.EndIUseSkillCheckBase(builder);
		}

		// Token: 0x06019173 RID: 102771 RVA: 0x0039BB46 File Offset: 0x00399D46
		public static void StartIUseSkillCheckBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019174 RID: 102772 RVA: 0x0039BB4F File Offset: 0x00399D4F
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019175 RID: 102773 RVA: 0x0039BB5A File Offset: 0x00399D5A
		public static Offset<IUseSkillCheckBase> EndIUseSkillCheckBase(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckBase>(builder.EndTable());
		}

		// Token: 0x06019176 RID: 102774 RVA: 0x0039BB68 File Offset: 0x00399D68
		public IUseSkillCheckBaseT UnPack()
		{
			IUseSkillCheckBaseT useSkillCheckBaseT = new IUseSkillCheckBaseT();
			this.UnPackTo(useSkillCheckBaseT);
			return useSkillCheckBaseT;
		}

		// Token: 0x06019177 RID: 102775 RVA: 0x0039BB83 File Offset: 0x00399D83
		public void UnPackTo(IUseSkillCheckBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019178 RID: 102776 RVA: 0x0039BB94 File Offset: 0x00399D94
		public static Offset<IUseSkillCheckBase> Pack(FlatBufferBuilder builder, IUseSkillCheckBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckBase>);
			}
			return IUseSkillCheckBase.CreateIUseSkillCheckBase(builder, _o.Type);
		}

		// Token: 0x0400BEC8 RID: 48840
		private Table __p;
	}
}

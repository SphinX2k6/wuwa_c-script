using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D9B RID: 28059
	public struct IPreloadPhantomCharacterForSkill : IFlatbufferObject
	{
		// Token: 0x1700D14B RID: 53579
		// (get) Token: 0x0603190D RID: 203021 RVA: 0x006B7BCD File Offset: 0x006B5DCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603190E RID: 203022 RVA: 0x006B7BDA File Offset: 0x006B5DDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603190F RID: 203023 RVA: 0x006B7BE4 File Offset: 0x006B5DE4
		public static IPreloadPhantomCharacterForSkill GetRootAsIPreloadPhantomCharacterForSkill(ByteBuffer _bb)
		{
			return IPreloadPhantomCharacterForSkill.GetRootAsIPreloadPhantomCharacterForSkill(_bb, default(IPreloadPhantomCharacterForSkill));
		}

		// Token: 0x06031910 RID: 203024 RVA: 0x006B7C00 File Offset: 0x006B5E00
		public static IPreloadPhantomCharacterForSkill GetRootAsIPreloadPhantomCharacterForSkill(ByteBuffer _bb, IPreloadPhantomCharacterForSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031911 RID: 203025 RVA: 0x006B7C1D File Offset: 0x006B5E1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031912 RID: 203026 RVA: 0x006B7C2C File Offset: 0x006B5E2C
		public IPreloadPhantomCharacterForSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D14C RID: 53580
		// (get) Token: 0x06031913 RID: 203027 RVA: 0x006B7C3C File Offset: 0x006B5E3C
		public EPreloadObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return (EPreloadObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D14D RID: 53581
		// (get) Token: 0x06031914 RID: 203028 RVA: 0x006B7C78 File Offset: 0x006B5E78
		public int Id
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

		// Token: 0x06031915 RID: 203029 RVA: 0x006B7CB4 File Offset: 0x006B5EB4
		public static Offset<IPreloadPhantomCharacterForSkill> CreateIPreloadPhantomCharacterForSkill(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill, int Id = 0)
		{
			builder.StartTable(2);
			IPreloadPhantomCharacterForSkill.AddId(builder, Id);
			IPreloadPhantomCharacterForSkill.AddType(builder, Type);
			return IPreloadPhantomCharacterForSkill.EndIPreloadPhantomCharacterForSkill(builder);
		}

		// Token: 0x06031916 RID: 203030 RVA: 0x006B7CD1 File Offset: 0x006B5ED1
		public static void StartIPreloadPhantomCharacterForSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031917 RID: 203031 RVA: 0x006B7CDA File Offset: 0x006B5EDA
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031918 RID: 203032 RVA: 0x006B7CE5 File Offset: 0x006B5EE5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06031919 RID: 203033 RVA: 0x006B7CF0 File Offset: 0x006B5EF0
		public static Offset<IPreloadPhantomCharacterForSkill> EndIPreloadPhantomCharacterForSkill(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadPhantomCharacterForSkill>(builder.EndTable());
		}

		// Token: 0x0603191A RID: 203034 RVA: 0x006B7D00 File Offset: 0x006B5F00
		public IPreloadPhantomCharacterForSkillT UnPack()
		{
			IPreloadPhantomCharacterForSkillT preloadPhantomCharacterForSkillT = new IPreloadPhantomCharacterForSkillT();
			this.UnPackTo(preloadPhantomCharacterForSkillT);
			return preloadPhantomCharacterForSkillT;
		}

		// Token: 0x0603191B RID: 203035 RVA: 0x006B7D1B File Offset: 0x006B5F1B
		public void UnPackTo(IPreloadPhantomCharacterForSkillT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0603191C RID: 203036 RVA: 0x006B7D38 File Offset: 0x006B5F38
		public static Offset<IPreloadPhantomCharacterForSkill> Pack(FlatBufferBuilder builder, IPreloadPhantomCharacterForSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadPhantomCharacterForSkill>);
			}
			return IPreloadPhantomCharacterForSkill.CreateIPreloadPhantomCharacterForSkill(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401176E RID: 71534
		private Table __p;
	}
}

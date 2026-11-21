using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007516 RID: 29974
	public struct IPreloadPhantomCharacterForSkill : IFlatbufferObject
	{
		// Token: 0x1700DC93 RID: 56467
		// (get) Token: 0x06034909 RID: 215305 RVA: 0x007132B5 File Offset: 0x007114B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603490A RID: 215306 RVA: 0x007132C2 File Offset: 0x007114C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603490B RID: 215307 RVA: 0x007132CC File Offset: 0x007114CC
		public static IPreloadPhantomCharacterForSkill GetRootAsIPreloadPhantomCharacterForSkill(ByteBuffer _bb)
		{
			return IPreloadPhantomCharacterForSkill.GetRootAsIPreloadPhantomCharacterForSkill(_bb, default(IPreloadPhantomCharacterForSkill));
		}

		// Token: 0x0603490C RID: 215308 RVA: 0x007132E8 File Offset: 0x007114E8
		public static IPreloadPhantomCharacterForSkill GetRootAsIPreloadPhantomCharacterForSkill(ByteBuffer _bb, IPreloadPhantomCharacterForSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603490D RID: 215309 RVA: 0x00713305 File Offset: 0x00711505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603490E RID: 215310 RVA: 0x00713314 File Offset: 0x00711514
		public IPreloadPhantomCharacterForSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC94 RID: 56468
		// (get) Token: 0x0603490F RID: 215311 RVA: 0x00713324 File Offset: 0x00711524
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

		// Token: 0x1700DC95 RID: 56469
		// (get) Token: 0x06034910 RID: 215312 RVA: 0x00713360 File Offset: 0x00711560
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

		// Token: 0x06034911 RID: 215313 RVA: 0x0071339C File Offset: 0x0071159C
		public static Offset<IPreloadPhantomCharacterForSkill> CreateIPreloadPhantomCharacterForSkill(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill, int Id = 0)
		{
			builder.StartTable(2);
			IPreloadPhantomCharacterForSkill.AddId(builder, Id);
			IPreloadPhantomCharacterForSkill.AddType(builder, Type);
			return IPreloadPhantomCharacterForSkill.EndIPreloadPhantomCharacterForSkill(builder);
		}

		// Token: 0x06034912 RID: 215314 RVA: 0x007133B9 File Offset: 0x007115B9
		public static void StartIPreloadPhantomCharacterForSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034913 RID: 215315 RVA: 0x007133C2 File Offset: 0x007115C2
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034914 RID: 215316 RVA: 0x007133CD File Offset: 0x007115CD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06034915 RID: 215317 RVA: 0x007133D8 File Offset: 0x007115D8
		public static Offset<IPreloadPhantomCharacterForSkill> EndIPreloadPhantomCharacterForSkill(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadPhantomCharacterForSkill>(builder.EndTable());
		}

		// Token: 0x06034916 RID: 215318 RVA: 0x007133E8 File Offset: 0x007115E8
		public IPreloadPhantomCharacterForSkillT UnPack()
		{
			IPreloadPhantomCharacterForSkillT preloadPhantomCharacterForSkillT = new IPreloadPhantomCharacterForSkillT();
			this.UnPackTo(preloadPhantomCharacterForSkillT);
			return preloadPhantomCharacterForSkillT;
		}

		// Token: 0x06034917 RID: 215319 RVA: 0x00713403 File Offset: 0x00711603
		public void UnPackTo(IPreloadPhantomCharacterForSkillT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06034918 RID: 215320 RVA: 0x00713420 File Offset: 0x00711620
		public static Offset<IPreloadPhantomCharacterForSkill> Pack(FlatBufferBuilder builder, IPreloadPhantomCharacterForSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadPhantomCharacterForSkill>);
			}
			return IPreloadPhantomCharacterForSkill.CreateIPreloadPhantomCharacterForSkill(builder, _o.Type, _o.Id);
		}

		// Token: 0x040126EA RID: 75498
		private Table __p;
	}
}

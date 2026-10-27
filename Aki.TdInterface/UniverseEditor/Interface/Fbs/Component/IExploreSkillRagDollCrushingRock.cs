using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005201 RID: 20993
	public struct IExploreSkillRagDollCrushingRock : IFlatbufferObject
	{
		// Token: 0x170099CB RID: 39371
		// (get) Token: 0x060221C2 RID: 139714 RVA: 0x004BBE27 File Offset: 0x004BA027
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060221C3 RID: 139715 RVA: 0x004BBE34 File Offset: 0x004BA034
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060221C4 RID: 139716 RVA: 0x004BBE3C File Offset: 0x004BA03C
		public static IExploreSkillRagDollCrushingRock GetRootAsIExploreSkillRagDollCrushingRock(ByteBuffer _bb)
		{
			return IExploreSkillRagDollCrushingRock.GetRootAsIExploreSkillRagDollCrushingRock(_bb, default(IExploreSkillRagDollCrushingRock));
		}

		// Token: 0x060221C5 RID: 139717 RVA: 0x004BBE58 File Offset: 0x004BA058
		public static IExploreSkillRagDollCrushingRock GetRootAsIExploreSkillRagDollCrushingRock(ByteBuffer _bb, IExploreSkillRagDollCrushingRock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060221C6 RID: 139718 RVA: 0x004BBE75 File Offset: 0x004BA075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060221C7 RID: 139719 RVA: 0x004BBE84 File Offset: 0x004BA084
		public IExploreSkillRagDollCrushingRock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099CC RID: 39372
		// (get) Token: 0x060221C8 RID: 139720 RVA: 0x004BBE94 File Offset: 0x004BA094
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060221C9 RID: 139721 RVA: 0x004BBED0 File Offset: 0x004BA0D0
		public static Offset<IExploreSkillRagDollCrushingRock> CreateIExploreSkillRagDollCrushingRock(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant)
		{
			builder.StartTable(1);
			IExploreSkillRagDollCrushingRock.AddType(builder, Type);
			return IExploreSkillRagDollCrushingRock.EndIExploreSkillRagDollCrushingRock(builder);
		}

		// Token: 0x060221CA RID: 139722 RVA: 0x004BBEE6 File Offset: 0x004BA0E6
		public static void StartIExploreSkillRagDollCrushingRock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060221CB RID: 139723 RVA: 0x004BBEEF File Offset: 0x004BA0EF
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060221CC RID: 139724 RVA: 0x004BBEFA File Offset: 0x004BA0FA
		public static Offset<IExploreSkillRagDollCrushingRock> EndIExploreSkillRagDollCrushingRock(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillRagDollCrushingRock>(builder.EndTable());
		}

		// Token: 0x060221CD RID: 139725 RVA: 0x004BBF08 File Offset: 0x004BA108
		public IExploreSkillRagDollCrushingRockT UnPack()
		{
			IExploreSkillRagDollCrushingRockT exploreSkillRagDollCrushingRockT = new IExploreSkillRagDollCrushingRockT();
			this.UnPackTo(exploreSkillRagDollCrushingRockT);
			return exploreSkillRagDollCrushingRockT;
		}

		// Token: 0x060221CE RID: 139726 RVA: 0x004BBF23 File Offset: 0x004BA123
		public void UnPackTo(IExploreSkillRagDollCrushingRockT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060221CF RID: 139727 RVA: 0x004BBF34 File Offset: 0x004BA134
		public static Offset<IExploreSkillRagDollCrushingRock> Pack(FlatBufferBuilder builder, IExploreSkillRagDollCrushingRockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillRagDollCrushingRock>);
			}
			return IExploreSkillRagDollCrushingRock.CreateIExploreSkillRagDollCrushingRock(builder, _o.Type);
		}

		// Token: 0x0400E334 RID: 58164
		private Table __p;
	}
}

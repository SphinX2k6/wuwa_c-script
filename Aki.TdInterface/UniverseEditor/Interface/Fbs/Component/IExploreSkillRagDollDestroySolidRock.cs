using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005204 RID: 20996
	public struct IExploreSkillRagDollDestroySolidRock : IFlatbufferObject
	{
		// Token: 0x170099CE RID: 39374
		// (get) Token: 0x060221D4 RID: 139732 RVA: 0x004BBF9D File Offset: 0x004BA19D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060221D5 RID: 139733 RVA: 0x004BBFAA File Offset: 0x004BA1AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060221D6 RID: 139734 RVA: 0x004BBFB4 File Offset: 0x004BA1B4
		public static IExploreSkillRagDollDestroySolidRock GetRootAsIExploreSkillRagDollDestroySolidRock(ByteBuffer _bb)
		{
			return IExploreSkillRagDollDestroySolidRock.GetRootAsIExploreSkillRagDollDestroySolidRock(_bb, default(IExploreSkillRagDollDestroySolidRock));
		}

		// Token: 0x060221D7 RID: 139735 RVA: 0x004BBFD0 File Offset: 0x004BA1D0
		public static IExploreSkillRagDollDestroySolidRock GetRootAsIExploreSkillRagDollDestroySolidRock(ByteBuffer _bb, IExploreSkillRagDollDestroySolidRock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060221D8 RID: 139736 RVA: 0x004BBFED File Offset: 0x004BA1ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060221D9 RID: 139737 RVA: 0x004BBFFC File Offset: 0x004BA1FC
		public IExploreSkillRagDollDestroySolidRock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099CF RID: 39375
		// (get) Token: 0x060221DA RID: 139738 RVA: 0x004BC00C File Offset: 0x004BA20C
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

		// Token: 0x060221DB RID: 139739 RVA: 0x004BC048 File Offset: 0x004BA248
		public static Offset<IExploreSkillRagDollDestroySolidRock> CreateIExploreSkillRagDollDestroySolidRock(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant)
		{
			builder.StartTable(1);
			IExploreSkillRagDollDestroySolidRock.AddType(builder, Type);
			return IExploreSkillRagDollDestroySolidRock.EndIExploreSkillRagDollDestroySolidRock(builder);
		}

		// Token: 0x060221DC RID: 139740 RVA: 0x004BC05E File Offset: 0x004BA25E
		public static void StartIExploreSkillRagDollDestroySolidRock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060221DD RID: 139741 RVA: 0x004BC067 File Offset: 0x004BA267
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060221DE RID: 139742 RVA: 0x004BC072 File Offset: 0x004BA272
		public static Offset<IExploreSkillRagDollDestroySolidRock> EndIExploreSkillRagDollDestroySolidRock(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillRagDollDestroySolidRock>(builder.EndTable());
		}

		// Token: 0x060221DF RID: 139743 RVA: 0x004BC080 File Offset: 0x004BA280
		public IExploreSkillRagDollDestroySolidRockT UnPack()
		{
			IExploreSkillRagDollDestroySolidRockT exploreSkillRagDollDestroySolidRockT = new IExploreSkillRagDollDestroySolidRockT();
			this.UnPackTo(exploreSkillRagDollDestroySolidRockT);
			return exploreSkillRagDollDestroySolidRockT;
		}

		// Token: 0x060221E0 RID: 139744 RVA: 0x004BC09B File Offset: 0x004BA29B
		public void UnPackTo(IExploreSkillRagDollDestroySolidRockT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060221E1 RID: 139745 RVA: 0x004BC0AC File Offset: 0x004BA2AC
		public static Offset<IExploreSkillRagDollDestroySolidRock> Pack(FlatBufferBuilder builder, IExploreSkillRagDollDestroySolidRockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillRagDollDestroySolidRock>);
			}
			return IExploreSkillRagDollDestroySolidRock.CreateIExploreSkillRagDollDestroySolidRock(builder, _o.Type);
		}

		// Token: 0x0400E336 RID: 58166
		private Table __p;
	}
}

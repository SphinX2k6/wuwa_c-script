using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200576C RID: 22380
	public struct IExploreSkillRagDollDestroySolidRock : IFlatbufferObject
	{
		// Token: 0x1700A1CA RID: 41418
		// (get) Token: 0x0602416A RID: 147818 RVA: 0x004F6A61 File Offset: 0x004F4C61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602416B RID: 147819 RVA: 0x004F6A6E File Offset: 0x004F4C6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602416C RID: 147820 RVA: 0x004F6A78 File Offset: 0x004F4C78
		public static IExploreSkillRagDollDestroySolidRock GetRootAsIExploreSkillRagDollDestroySolidRock(ByteBuffer _bb)
		{
			return IExploreSkillRagDollDestroySolidRock.GetRootAsIExploreSkillRagDollDestroySolidRock(_bb, default(IExploreSkillRagDollDestroySolidRock));
		}

		// Token: 0x0602416D RID: 147821 RVA: 0x004F6A94 File Offset: 0x004F4C94
		public static IExploreSkillRagDollDestroySolidRock GetRootAsIExploreSkillRagDollDestroySolidRock(ByteBuffer _bb, IExploreSkillRagDollDestroySolidRock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602416E RID: 147822 RVA: 0x004F6AB1 File Offset: 0x004F4CB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602416F RID: 147823 RVA: 0x004F6AC0 File Offset: 0x004F4CC0
		public IExploreSkillRagDollDestroySolidRock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1CB RID: 41419
		// (get) Token: 0x06024170 RID: 147824 RVA: 0x004F6AD0 File Offset: 0x004F4CD0
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

		// Token: 0x06024171 RID: 147825 RVA: 0x004F6B0C File Offset: 0x004F4D0C
		public static Offset<IExploreSkillRagDollDestroySolidRock> CreateIExploreSkillRagDollDestroySolidRock(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant)
		{
			builder.StartTable(1);
			IExploreSkillRagDollDestroySolidRock.AddType(builder, Type);
			return IExploreSkillRagDollDestroySolidRock.EndIExploreSkillRagDollDestroySolidRock(builder);
		}

		// Token: 0x06024172 RID: 147826 RVA: 0x004F6B22 File Offset: 0x004F4D22
		public static void StartIExploreSkillRagDollDestroySolidRock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024173 RID: 147827 RVA: 0x004F6B2B File Offset: 0x004F4D2B
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024174 RID: 147828 RVA: 0x004F6B36 File Offset: 0x004F4D36
		public static Offset<IExploreSkillRagDollDestroySolidRock> EndIExploreSkillRagDollDestroySolidRock(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillRagDollDestroySolidRock>(builder.EndTable());
		}

		// Token: 0x06024175 RID: 147829 RVA: 0x004F6B44 File Offset: 0x004F4D44
		public IExploreSkillRagDollDestroySolidRockT UnPack()
		{
			IExploreSkillRagDollDestroySolidRockT exploreSkillRagDollDestroySolidRockT = new IExploreSkillRagDollDestroySolidRockT();
			this.UnPackTo(exploreSkillRagDollDestroySolidRockT);
			return exploreSkillRagDollDestroySolidRockT;
		}

		// Token: 0x06024176 RID: 147830 RVA: 0x004F6B5F File Offset: 0x004F4D5F
		public void UnPackTo(IExploreSkillRagDollDestroySolidRockT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024177 RID: 147831 RVA: 0x004F6B70 File Offset: 0x004F4D70
		public static Offset<IExploreSkillRagDollDestroySolidRock> Pack(FlatBufferBuilder builder, IExploreSkillRagDollDestroySolidRockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillRagDollDestroySolidRock>);
			}
			return IExploreSkillRagDollDestroySolidRock.CreateIExploreSkillRagDollDestroySolidRock(builder, _o.Type);
		}

		// Token: 0x0400EF3C RID: 61244
		private Table __p;
	}
}

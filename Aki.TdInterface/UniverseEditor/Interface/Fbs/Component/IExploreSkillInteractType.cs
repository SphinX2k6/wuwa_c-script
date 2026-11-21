using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005754 RID: 22356
	public struct IExploreSkillInteractType : IFlatbufferObject
	{
		// Token: 0x1700A19D RID: 41373
		// (get) Token: 0x0602407A RID: 147578 RVA: 0x004F4D2F File Offset: 0x004F2F2F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602407B RID: 147579 RVA: 0x004F4D3C File Offset: 0x004F2F3C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602407C RID: 147580 RVA: 0x004F4D44 File Offset: 0x004F2F44
		public static IExploreSkillInteractType GetRootAsIExploreSkillInteractType(ByteBuffer _bb)
		{
			return IExploreSkillInteractType.GetRootAsIExploreSkillInteractType(_bb, default(IExploreSkillInteractType));
		}

		// Token: 0x0602407D RID: 147581 RVA: 0x004F4D60 File Offset: 0x004F2F60
		public static IExploreSkillInteractType GetRootAsIExploreSkillInteractType(ByteBuffer _bb, IExploreSkillInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602407E RID: 147582 RVA: 0x004F4D7D File Offset: 0x004F2F7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602407F RID: 147583 RVA: 0x004F4D8C File Offset: 0x004F2F8C
		public IExploreSkillInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A19E RID: 41374
		// (get) Token: 0x06024080 RID: 147584 RVA: 0x004F4D9C File Offset: 0x004F2F9C
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

		// Token: 0x06024081 RID: 147585 RVA: 0x004F4DD8 File Offset: 0x004F2FD8
		public static Offset<IExploreSkillInteractType> CreateIExploreSkillInteractType(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant)
		{
			builder.StartTable(1);
			IExploreSkillInteractType.AddType(builder, Type);
			return IExploreSkillInteractType.EndIExploreSkillInteractType(builder);
		}

		// Token: 0x06024082 RID: 147586 RVA: 0x004F4DEE File Offset: 0x004F2FEE
		public static void StartIExploreSkillInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024083 RID: 147587 RVA: 0x004F4DF7 File Offset: 0x004F2FF7
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024084 RID: 147588 RVA: 0x004F4E02 File Offset: 0x004F3002
		public static Offset<IExploreSkillInteractType> EndIExploreSkillInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillInteractType>(builder.EndTable());
		}

		// Token: 0x06024085 RID: 147589 RVA: 0x004F4E10 File Offset: 0x004F3010
		public IExploreSkillInteractTypeT UnPack()
		{
			IExploreSkillInteractTypeT exploreSkillInteractTypeT = new IExploreSkillInteractTypeT();
			this.UnPackTo(exploreSkillInteractTypeT);
			return exploreSkillInteractTypeT;
		}

		// Token: 0x06024086 RID: 147590 RVA: 0x004F4E2B File Offset: 0x004F302B
		public void UnPackTo(IExploreSkillInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024087 RID: 147591 RVA: 0x004F4E3C File Offset: 0x004F303C
		public static Offset<IExploreSkillInteractType> Pack(FlatBufferBuilder builder, IExploreSkillInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillInteractType>);
			}
			return IExploreSkillInteractType.CreateIExploreSkillInteractType(builder, _o.Type);
		}

		// Token: 0x0400EF0F RID: 61199
		private Table __p;
	}
}

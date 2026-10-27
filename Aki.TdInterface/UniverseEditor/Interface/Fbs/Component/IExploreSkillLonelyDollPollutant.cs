using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051F2 RID: 20978
	public struct IExploreSkillLonelyDollPollutant : IFlatbufferObject
	{
		// Token: 0x170099A6 RID: 39334
		// (get) Token: 0x0602211E RID: 139550 RVA: 0x004BA88D File Offset: 0x004B8A8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602211F RID: 139551 RVA: 0x004BA89A File Offset: 0x004B8A9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022120 RID: 139552 RVA: 0x004BA8A4 File Offset: 0x004B8AA4
		public static IExploreSkillLonelyDollPollutant GetRootAsIExploreSkillLonelyDollPollutant(ByteBuffer _bb)
		{
			return IExploreSkillLonelyDollPollutant.GetRootAsIExploreSkillLonelyDollPollutant(_bb, default(IExploreSkillLonelyDollPollutant));
		}

		// Token: 0x06022121 RID: 139553 RVA: 0x004BA8C0 File Offset: 0x004B8AC0
		public static IExploreSkillLonelyDollPollutant GetRootAsIExploreSkillLonelyDollPollutant(ByteBuffer _bb, IExploreSkillLonelyDollPollutant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022122 RID: 139554 RVA: 0x004BA8DD File Offset: 0x004B8ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022123 RID: 139555 RVA: 0x004BA8EC File Offset: 0x004B8AEC
		public IExploreSkillLonelyDollPollutant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099A7 RID: 39335
		// (get) Token: 0x06022124 RID: 139556 RVA: 0x004BA8FC File Offset: 0x004B8AFC
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

		// Token: 0x06022125 RID: 139557 RVA: 0x004BA938 File Offset: 0x004B8B38
		public static Offset<IExploreSkillLonelyDollPollutant> CreateIExploreSkillLonelyDollPollutant(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant)
		{
			builder.StartTable(1);
			IExploreSkillLonelyDollPollutant.AddType(builder, Type);
			return IExploreSkillLonelyDollPollutant.EndIExploreSkillLonelyDollPollutant(builder);
		}

		// Token: 0x06022126 RID: 139558 RVA: 0x004BA94E File Offset: 0x004B8B4E
		public static void StartIExploreSkillLonelyDollPollutant(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022127 RID: 139559 RVA: 0x004BA957 File Offset: 0x004B8B57
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022128 RID: 139560 RVA: 0x004BA962 File Offset: 0x004B8B62
		public static Offset<IExploreSkillLonelyDollPollutant> EndIExploreSkillLonelyDollPollutant(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillLonelyDollPollutant>(builder.EndTable());
		}

		// Token: 0x06022129 RID: 139561 RVA: 0x004BA970 File Offset: 0x004B8B70
		public IExploreSkillLonelyDollPollutantT UnPack()
		{
			IExploreSkillLonelyDollPollutantT exploreSkillLonelyDollPollutantT = new IExploreSkillLonelyDollPollutantT();
			this.UnPackTo(exploreSkillLonelyDollPollutantT);
			return exploreSkillLonelyDollPollutantT;
		}

		// Token: 0x0602212A RID: 139562 RVA: 0x004BA98B File Offset: 0x004B8B8B
		public void UnPackTo(IExploreSkillLonelyDollPollutantT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602212B RID: 139563 RVA: 0x004BA99C File Offset: 0x004B8B9C
		public static Offset<IExploreSkillLonelyDollPollutant> Pack(FlatBufferBuilder builder, IExploreSkillLonelyDollPollutantT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillLonelyDollPollutant>);
			}
			return IExploreSkillLonelyDollPollutant.CreateIExploreSkillLonelyDollPollutant(builder, _o.Type);
		}

		// Token: 0x0400E31F RID: 58143
		private Table __p;
	}
}

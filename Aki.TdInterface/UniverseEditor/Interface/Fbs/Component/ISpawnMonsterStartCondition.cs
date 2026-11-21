using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F6F RID: 24431
	public struct ISpawnMonsterStartCondition : IFlatbufferObject
	{
		// Token: 0x1700B4F3 RID: 46323
		// (get) Token: 0x06029121 RID: 168225 RVA: 0x0059C093 File Offset: 0x0059A293
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029122 RID: 168226 RVA: 0x0059C0A0 File Offset: 0x0059A2A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029123 RID: 168227 RVA: 0x0059C0A8 File Offset: 0x0059A2A8
		public static ISpawnMonsterStartCondition GetRootAsISpawnMonsterStartCondition(ByteBuffer _bb)
		{
			return ISpawnMonsterStartCondition.GetRootAsISpawnMonsterStartCondition(_bb, default(ISpawnMonsterStartCondition));
		}

		// Token: 0x06029124 RID: 168228 RVA: 0x0059C0C4 File Offset: 0x0059A2C4
		public static ISpawnMonsterStartCondition GetRootAsISpawnMonsterStartCondition(ByteBuffer _bb, ISpawnMonsterStartCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029125 RID: 168229 RVA: 0x0059C0E1 File Offset: 0x0059A2E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029126 RID: 168230 RVA: 0x0059C0F0 File Offset: 0x0059A2F0
		public ISpawnMonsterStartCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4F4 RID: 46324
		// (get) Token: 0x06029127 RID: 168231 RVA: 0x0059C100 File Offset: 0x0059A300
		public ESpawnMonsterStartCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterStartCondition.Immediate;
				}
				return (ESpawnMonsterStartCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029128 RID: 168232 RVA: 0x0059C13C File Offset: 0x0059A33C
		public static Offset<ISpawnMonsterStartCondition> CreateISpawnMonsterStartCondition(FlatBufferBuilder builder, ESpawnMonsterStartCondition Type = ESpawnMonsterStartCondition.Immediate)
		{
			builder.StartTable(1);
			ISpawnMonsterStartCondition.AddType(builder, Type);
			return ISpawnMonsterStartCondition.EndISpawnMonsterStartCondition(builder);
		}

		// Token: 0x06029129 RID: 168233 RVA: 0x0059C152 File Offset: 0x0059A352
		public static void StartISpawnMonsterStartCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602912A RID: 168234 RVA: 0x0059C15B File Offset: 0x0059A35B
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterStartCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602912B RID: 168235 RVA: 0x0059C166 File Offset: 0x0059A366
		public static Offset<ISpawnMonsterStartCondition> EndISpawnMonsterStartCondition(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterStartCondition>(builder.EndTable());
		}

		// Token: 0x0602912C RID: 168236 RVA: 0x0059C174 File Offset: 0x0059A374
		public ISpawnMonsterStartConditionT UnPack()
		{
			ISpawnMonsterStartConditionT spawnMonsterStartConditionT = new ISpawnMonsterStartConditionT();
			this.UnPackTo(spawnMonsterStartConditionT);
			return spawnMonsterStartConditionT;
		}

		// Token: 0x0602912D RID: 168237 RVA: 0x0059C18F File Offset: 0x0059A38F
		public void UnPackTo(ISpawnMonsterStartConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602912E RID: 168238 RVA: 0x0059C1A0 File Offset: 0x0059A3A0
		public static Offset<ISpawnMonsterStartCondition> Pack(FlatBufferBuilder builder, ISpawnMonsterStartConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterStartCondition>);
			}
			return ISpawnMonsterStartCondition.CreateISpawnMonsterStartCondition(builder, _o.Type);
		}

		// Token: 0x0400FC3B RID: 64571
		private Table __p;
	}
}

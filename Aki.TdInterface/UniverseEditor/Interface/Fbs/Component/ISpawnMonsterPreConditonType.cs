using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005959 RID: 22873
	public struct ISpawnMonsterPreConditonType : IFlatbufferObject
	{
		// Token: 0x1700ABB5 RID: 43957
		// (get) Token: 0x06026B7B RID: 158587 RVA: 0x00554E88 File Offset: 0x00553088
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026B7C RID: 158588 RVA: 0x00554E95 File Offset: 0x00553095
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026B7D RID: 158589 RVA: 0x00554E9C File Offset: 0x0055309C
		public static ISpawnMonsterPreConditonType GetRootAsISpawnMonsterPreConditonType(ByteBuffer _bb)
		{
			return ISpawnMonsterPreConditonType.GetRootAsISpawnMonsterPreConditonType(_bb, default(ISpawnMonsterPreConditonType));
		}

		// Token: 0x06026B7E RID: 158590 RVA: 0x00554EB8 File Offset: 0x005530B8
		public static ISpawnMonsterPreConditonType GetRootAsISpawnMonsterPreConditonType(ByteBuffer _bb, ISpawnMonsterPreConditonType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026B7F RID: 158591 RVA: 0x00554ED5 File Offset: 0x005530D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026B80 RID: 158592 RVA: 0x00554EE4 File Offset: 0x005530E4
		public ISpawnMonsterPreConditonType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABB6 RID: 43958
		// (get) Token: 0x06026B81 RID: 158593 RVA: 0x00554EF4 File Offset: 0x005530F4
		public ESpawnMonsterPreCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterPreCondition.DependOnPreceding;
				}
				return (ESpawnMonsterPreCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026B82 RID: 158594 RVA: 0x00554F30 File Offset: 0x00553130
		public static Offset<ISpawnMonsterPreConditonType> CreateISpawnMonsterPreConditonType(FlatBufferBuilder builder, ESpawnMonsterPreCondition Type = ESpawnMonsterPreCondition.DependOnPreceding)
		{
			builder.StartTable(1);
			ISpawnMonsterPreConditonType.AddType(builder, Type);
			return ISpawnMonsterPreConditonType.EndISpawnMonsterPreConditonType(builder);
		}

		// Token: 0x06026B83 RID: 158595 RVA: 0x00554F46 File Offset: 0x00553146
		public static void StartISpawnMonsterPreConditonType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026B84 RID: 158596 RVA: 0x00554F4F File Offset: 0x0055314F
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterPreCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026B85 RID: 158597 RVA: 0x00554F5A File Offset: 0x0055315A
		public static Offset<ISpawnMonsterPreConditonType> EndISpawnMonsterPreConditonType(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterPreConditonType>(builder.EndTable());
		}

		// Token: 0x06026B86 RID: 158598 RVA: 0x00554F68 File Offset: 0x00553168
		public ISpawnMonsterPreConditonTypeT UnPack()
		{
			ISpawnMonsterPreConditonTypeT spawnMonsterPreConditonTypeT = new ISpawnMonsterPreConditonTypeT();
			this.UnPackTo(spawnMonsterPreConditonTypeT);
			return spawnMonsterPreConditonTypeT;
		}

		// Token: 0x06026B87 RID: 158599 RVA: 0x00554F83 File Offset: 0x00553183
		public void UnPackTo(ISpawnMonsterPreConditonTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026B88 RID: 158600 RVA: 0x00554F94 File Offset: 0x00553194
		public static Offset<ISpawnMonsterPreConditonType> Pack(FlatBufferBuilder builder, ISpawnMonsterPreConditonTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterPreConditonType>);
			}
			return ISpawnMonsterPreConditonType.CreateISpawnMonsterPreConditonType(builder, _o.Type);
		}

		// Token: 0x0400EF3B RID: 61243
		private Table __p;
	}
}

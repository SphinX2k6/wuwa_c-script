using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200778C RID: 30604
	public struct ISetBattleTagType : IFlatbufferObject
	{
		// Token: 0x1700E044 RID: 57412
		// (get) Token: 0x06035B8A RID: 220042 RVA: 0x00732CCC File Offset: 0x00730ECC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B8B RID: 220043 RVA: 0x00732CD9 File Offset: 0x00730ED9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B8C RID: 220044 RVA: 0x00732CE0 File Offset: 0x00730EE0
		public static ISetBattleTagType GetRootAsISetBattleTagType(ByteBuffer _bb)
		{
			return ISetBattleTagType.GetRootAsISetBattleTagType(_bb, default(ISetBattleTagType));
		}

		// Token: 0x06035B8D RID: 220045 RVA: 0x00732CFC File Offset: 0x00730EFC
		public static ISetBattleTagType GetRootAsISetBattleTagType(ByteBuffer _bb, ISetBattleTagType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B8E RID: 220046 RVA: 0x00732D19 File Offset: 0x00730F19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B8F RID: 220047 RVA: 0x00732D28 File Offset: 0x00730F28
		public ISetBattleTagType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E045 RID: 57413
		// (get) Token: 0x06035B90 RID: 220048 RVA: 0x00732D38 File Offset: 0x00730F38
		public ESetBattleTagType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetBattleTagType.BattleMonsterLanding;
				}
				return (ESetBattleTagType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035B91 RID: 220049 RVA: 0x00732D74 File Offset: 0x00730F74
		public static Offset<ISetBattleTagType> CreateISetBattleTagType(FlatBufferBuilder builder, ESetBattleTagType Type = ESetBattleTagType.BattleMonsterLanding)
		{
			builder.StartTable(1);
			ISetBattleTagType.AddType(builder, Type);
			return ISetBattleTagType.EndISetBattleTagType(builder);
		}

		// Token: 0x06035B92 RID: 220050 RVA: 0x00732D8A File Offset: 0x00730F8A
		public static void StartISetBattleTagType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035B93 RID: 220051 RVA: 0x00732D93 File Offset: 0x00730F93
		public static void AddType(FlatBufferBuilder builder, ESetBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035B94 RID: 220052 RVA: 0x00732D9E File Offset: 0x00730F9E
		public static Offset<ISetBattleTagType> EndISetBattleTagType(FlatBufferBuilder builder)
		{
			return new Offset<ISetBattleTagType>(builder.EndTable());
		}

		// Token: 0x06035B95 RID: 220053 RVA: 0x00732DAC File Offset: 0x00730FAC
		public ISetBattleTagTypeT UnPack()
		{
			ISetBattleTagTypeT setBattleTagTypeT = new ISetBattleTagTypeT();
			this.UnPackTo(setBattleTagTypeT);
			return setBattleTagTypeT;
		}

		// Token: 0x06035B96 RID: 220054 RVA: 0x00732DC7 File Offset: 0x00730FC7
		public void UnPackTo(ISetBattleTagTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035B97 RID: 220055 RVA: 0x00732DD8 File Offset: 0x00730FD8
		public static Offset<ISetBattleTagType> Pack(FlatBufferBuilder builder, ISetBattleTagTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBattleTagType>);
			}
			return ISetBattleTagType.CreateISetBattleTagType(builder, _o.Type);
		}

		// Token: 0x040129AF RID: 76207
		private Table __p;
	}
}

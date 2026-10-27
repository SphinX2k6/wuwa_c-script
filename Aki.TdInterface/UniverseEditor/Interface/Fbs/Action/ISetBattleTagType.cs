using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC3 RID: 28611
	public struct ISetBattleTagType : IFlatbufferObject
	{
		// Token: 0x1700D470 RID: 54384
		// (get) Token: 0x06032924 RID: 207140 RVA: 0x006D3088 File Offset: 0x006D1288
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032925 RID: 207141 RVA: 0x006D3095 File Offset: 0x006D1295
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032926 RID: 207142 RVA: 0x006D309C File Offset: 0x006D129C
		public static ISetBattleTagType GetRootAsISetBattleTagType(ByteBuffer _bb)
		{
			return ISetBattleTagType.GetRootAsISetBattleTagType(_bb, default(ISetBattleTagType));
		}

		// Token: 0x06032927 RID: 207143 RVA: 0x006D30B8 File Offset: 0x006D12B8
		public static ISetBattleTagType GetRootAsISetBattleTagType(ByteBuffer _bb, ISetBattleTagType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032928 RID: 207144 RVA: 0x006D30D5 File Offset: 0x006D12D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032929 RID: 207145 RVA: 0x006D30E4 File Offset: 0x006D12E4
		public ISetBattleTagType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D471 RID: 54385
		// (get) Token: 0x0603292A RID: 207146 RVA: 0x006D30F4 File Offset: 0x006D12F4
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

		// Token: 0x0603292B RID: 207147 RVA: 0x006D3130 File Offset: 0x006D1330
		public static Offset<ISetBattleTagType> CreateISetBattleTagType(FlatBufferBuilder builder, ESetBattleTagType Type = ESetBattleTagType.BattleMonsterLanding)
		{
			builder.StartTable(1);
			ISetBattleTagType.AddType(builder, Type);
			return ISetBattleTagType.EndISetBattleTagType(builder);
		}

		// Token: 0x0603292C RID: 207148 RVA: 0x006D3146 File Offset: 0x006D1346
		public static void StartISetBattleTagType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603292D RID: 207149 RVA: 0x006D314F File Offset: 0x006D134F
		public static void AddType(FlatBufferBuilder builder, ESetBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603292E RID: 207150 RVA: 0x006D315A File Offset: 0x006D135A
		public static Offset<ISetBattleTagType> EndISetBattleTagType(FlatBufferBuilder builder)
		{
			return new Offset<ISetBattleTagType>(builder.EndTable());
		}

		// Token: 0x0603292F RID: 207151 RVA: 0x006D3168 File Offset: 0x006D1368
		public ISetBattleTagTypeT UnPack()
		{
			ISetBattleTagTypeT setBattleTagTypeT = new ISetBattleTagTypeT();
			this.UnPackTo(setBattleTagTypeT);
			return setBattleTagTypeT;
		}

		// Token: 0x06032930 RID: 207152 RVA: 0x006D3183 File Offset: 0x006D1383
		public void UnPackTo(ISetBattleTagTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032931 RID: 207153 RVA: 0x006D3194 File Offset: 0x006D1394
		public static Offset<ISetBattleTagType> Pack(FlatBufferBuilder builder, ISetBattleTagTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBattleTagType>);
			}
			return ISetBattleTagType.CreateISetBattleTagType(builder, _o.Type);
		}

		// Token: 0x040119CA RID: 72138
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C17 RID: 27671
	public struct IDetectBattleMonsterOnGround : IFlatbufferObject
	{
		// Token: 0x1700CAD5 RID: 51925
		// (get) Token: 0x0602F9F7 RID: 195063 RVA: 0x0067D349 File Offset: 0x0067B549
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F9F8 RID: 195064 RVA: 0x0067D356 File Offset: 0x0067B556
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F9F9 RID: 195065 RVA: 0x0067D360 File Offset: 0x0067B560
		public static IDetectBattleMonsterOnGround GetRootAsIDetectBattleMonsterOnGround(ByteBuffer _bb)
		{
			return IDetectBattleMonsterOnGround.GetRootAsIDetectBattleMonsterOnGround(_bb, default(IDetectBattleMonsterOnGround));
		}

		// Token: 0x0602F9FA RID: 195066 RVA: 0x0067D37C File Offset: 0x0067B57C
		public static IDetectBattleMonsterOnGround GetRootAsIDetectBattleMonsterOnGround(ByteBuffer _bb, IDetectBattleMonsterOnGround obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F9FB RID: 195067 RVA: 0x0067D399 File Offset: 0x0067B599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F9FC RID: 195068 RVA: 0x0067D3A8 File Offset: 0x0067B5A8
		public IDetectBattleMonsterOnGround __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAD6 RID: 51926
		// (get) Token: 0x0602F9FD RID: 195069 RVA: 0x0067D3B8 File Offset: 0x0067B5B8
		public EDetectBattleTagType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDetectBattleTagType.MonsterOnTheGround;
				}
				return (EDetectBattleTagType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F9FE RID: 195070 RVA: 0x0067D3F4 File Offset: 0x0067B5F4
		public static Offset<IDetectBattleMonsterOnGround> CreateIDetectBattleMonsterOnGround(FlatBufferBuilder builder, EDetectBattleTagType Type = EDetectBattleTagType.MonsterOnTheGround)
		{
			builder.StartTable(1);
			IDetectBattleMonsterOnGround.AddType(builder, Type);
			return IDetectBattleMonsterOnGround.EndIDetectBattleMonsterOnGround(builder);
		}

		// Token: 0x0602F9FF RID: 195071 RVA: 0x0067D40A File Offset: 0x0067B60A
		public static void StartIDetectBattleMonsterOnGround(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FA00 RID: 195072 RVA: 0x0067D413 File Offset: 0x0067B613
		public static void AddType(FlatBufferBuilder builder, EDetectBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FA01 RID: 195073 RVA: 0x0067D41E File Offset: 0x0067B61E
		public static Offset<IDetectBattleMonsterOnGround> EndIDetectBattleMonsterOnGround(FlatBufferBuilder builder)
		{
			return new Offset<IDetectBattleMonsterOnGround>(builder.EndTable());
		}

		// Token: 0x0602FA02 RID: 195074 RVA: 0x0067D42C File Offset: 0x0067B62C
		public IDetectBattleMonsterOnGroundT UnPack()
		{
			IDetectBattleMonsterOnGroundT detectBattleMonsterOnGroundT = new IDetectBattleMonsterOnGroundT();
			this.UnPackTo(detectBattleMonsterOnGroundT);
			return detectBattleMonsterOnGroundT;
		}

		// Token: 0x0602FA03 RID: 195075 RVA: 0x0067D447 File Offset: 0x0067B647
		public void UnPackTo(IDetectBattleMonsterOnGroundT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FA04 RID: 195076 RVA: 0x0067D458 File Offset: 0x0067B658
		public static Offset<IDetectBattleMonsterOnGround> Pack(FlatBufferBuilder builder, IDetectBattleMonsterOnGroundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectBattleMonsterOnGround>);
			}
			return IDetectBattleMonsterOnGround.CreateIDetectBattleMonsterOnGround(builder, _o.Type);
		}

		// Token: 0x04011A1C RID: 72220
		private Table __p;
	}
}

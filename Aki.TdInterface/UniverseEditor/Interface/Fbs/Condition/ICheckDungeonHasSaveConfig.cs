using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E9C RID: 20124
	public struct ICheckDungeonHasSaveConfig : IFlatbufferObject
	{
		// Token: 0x17008F8D RID: 36749
		// (get) Token: 0x0601F2F7 RID: 127735 RVA: 0x00459368 File Offset: 0x00457568
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F2F8 RID: 127736 RVA: 0x00459375 File Offset: 0x00457575
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F2F9 RID: 127737 RVA: 0x0045937C File Offset: 0x0045757C
		public static ICheckDungeonHasSaveConfig GetRootAsICheckDungeonHasSaveConfig(ByteBuffer _bb)
		{
			return ICheckDungeonHasSaveConfig.GetRootAsICheckDungeonHasSaveConfig(_bb, default(ICheckDungeonHasSaveConfig));
		}

		// Token: 0x0601F2FA RID: 127738 RVA: 0x00459398 File Offset: 0x00457598
		public static ICheckDungeonHasSaveConfig GetRootAsICheckDungeonHasSaveConfig(ByteBuffer _bb, ICheckDungeonHasSaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F2FB RID: 127739 RVA: 0x004593B5 File Offset: 0x004575B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F2FC RID: 127740 RVA: 0x004593C4 File Offset: 0x004575C4
		public ICheckDungeonHasSaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F8E RID: 36750
		// (get) Token: 0x0601F2FD RID: 127741 RVA: 0x004593D4 File Offset: 0x004575D4
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008F8F RID: 36751
		// (get) Token: 0x0601F2FE RID: 127742 RVA: 0x00459410 File Offset: 0x00457610
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008F90 RID: 36752
		// (get) Token: 0x0601F2FF RID: 127743 RVA: 0x0045944C File Offset: 0x0045764C
		public bool IsHasSaveConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F300 RID: 127744 RVA: 0x0045948B File Offset: 0x0045768B
		public static Offset<ICheckDungeonHasSaveConfig> CreateICheckDungeonHasSaveConfig(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int DungeonId = 0, bool IsHasSaveConfig = false)
		{
			builder.StartTable(3);
			ICheckDungeonHasSaveConfig.AddDungeonId(builder, DungeonId);
			ICheckDungeonHasSaveConfig.AddIsHasSaveConfig(builder, IsHasSaveConfig);
			ICheckDungeonHasSaveConfig.AddType(builder, Type);
			return ICheckDungeonHasSaveConfig.EndICheckDungeonHasSaveConfig(builder);
		}

		// Token: 0x0601F301 RID: 127745 RVA: 0x004594AF File Offset: 0x004576AF
		public static void StartICheckDungeonHasSaveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F302 RID: 127746 RVA: 0x004594B8 File Offset: 0x004576B8
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F303 RID: 127747 RVA: 0x004594C3 File Offset: 0x004576C3
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601F304 RID: 127748 RVA: 0x004594CE File Offset: 0x004576CE
		public static void AddIsHasSaveConfig(FlatBufferBuilder builder, bool isHasSaveConfig)
		{
			builder.AddBool(2, isHasSaveConfig, false);
		}

		// Token: 0x0601F305 RID: 127749 RVA: 0x004594D9 File Offset: 0x004576D9
		public static Offset<ICheckDungeonHasSaveConfig> EndICheckDungeonHasSaveConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDungeonHasSaveConfig>(builder.EndTable());
		}

		// Token: 0x0601F306 RID: 127750 RVA: 0x004594E8 File Offset: 0x004576E8
		public ICheckDungeonHasSaveConfigT UnPack()
		{
			ICheckDungeonHasSaveConfigT checkDungeonHasSaveConfigT = new ICheckDungeonHasSaveConfigT();
			this.UnPackTo(checkDungeonHasSaveConfigT);
			return checkDungeonHasSaveConfigT;
		}

		// Token: 0x0601F307 RID: 127751 RVA: 0x00459503 File Offset: 0x00457703
		public void UnPackTo(ICheckDungeonHasSaveConfigT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.IsHasSaveConfig = this.IsHasSaveConfig;
		}

		// Token: 0x0601F308 RID: 127752 RVA: 0x0045952C File Offset: 0x0045772C
		public static Offset<ICheckDungeonHasSaveConfig> Pack(FlatBufferBuilder builder, ICheckDungeonHasSaveConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDungeonHasSaveConfig>);
			}
			return ICheckDungeonHasSaveConfig.CreateICheckDungeonHasSaveConfig(builder, _o.Type, _o.DungeonId, _o.IsHasSaveConfig);
		}

		// Token: 0x0400DCDF RID: 56543
		private Table __p;
	}
}

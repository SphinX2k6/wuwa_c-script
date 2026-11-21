using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D1 RID: 17105
	public struct IHardBattleModeSetting : IFlatbufferObject
	{
		// Token: 0x17007524 RID: 29988
		// (get) Token: 0x06018017 RID: 98327 RVA: 0x0036D5CD File Offset: 0x0036B7CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018018 RID: 98328 RVA: 0x0036D5DA File Offset: 0x0036B7DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018019 RID: 98329 RVA: 0x0036D5E4 File Offset: 0x0036B7E4
		public static IHardBattleModeSetting GetRootAsIHardBattleModeSetting(ByteBuffer _bb)
		{
			return IHardBattleModeSetting.GetRootAsIHardBattleModeSetting(_bb, default(IHardBattleModeSetting));
		}

		// Token: 0x0601801A RID: 98330 RVA: 0x0036D600 File Offset: 0x0036B800
		public static IHardBattleModeSetting GetRootAsIHardBattleModeSetting(ByteBuffer _bb, IHardBattleModeSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601801B RID: 98331 RVA: 0x0036D61D File Offset: 0x0036B81D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601801C RID: 98332 RVA: 0x0036D62C File Offset: 0x0036B82C
		public IHardBattleModeSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007525 RID: 29989
		// (get) Token: 0x0601801D RID: 98333 RVA: 0x0036D63C File Offset: 0x0036B83C
		public bool CanOpenHardBattleMode
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007526 RID: 29990
		// (get) Token: 0x0601801E RID: 98334 RVA: 0x0036D67C File Offset: 0x0036B87C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601801F RID: 98335 RVA: 0x0036D6B8 File Offset: 0x0036B8B8
		public static Offset<IHardBattleModeSetting> CreateIHardBattleModeSetting(FlatBufferBuilder builder, bool CanOpenHardBattleMode = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IHardBattleModeSetting.AddNullMask(builder, NullMask);
			IHardBattleModeSetting.AddCanOpenHardBattleMode(builder, CanOpenHardBattleMode);
			return IHardBattleModeSetting.EndIHardBattleModeSetting(builder);
		}

		// Token: 0x06018020 RID: 98336 RVA: 0x0036D6D5 File Offset: 0x0036B8D5
		public static void StartIHardBattleModeSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018021 RID: 98337 RVA: 0x0036D6DE File Offset: 0x0036B8DE
		public static void AddCanOpenHardBattleMode(FlatBufferBuilder builder, bool canOpenHardBattleMode)
		{
			builder.AddBool(0, canOpenHardBattleMode, false);
		}

		// Token: 0x06018022 RID: 98338 RVA: 0x0036D6E9 File Offset: 0x0036B8E9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06018023 RID: 98339 RVA: 0x0036D6F4 File Offset: 0x0036B8F4
		public static Offset<IHardBattleModeSetting> EndIHardBattleModeSetting(FlatBufferBuilder builder)
		{
			return new Offset<IHardBattleModeSetting>(builder.EndTable());
		}

		// Token: 0x06018024 RID: 98340 RVA: 0x0036D704 File Offset: 0x0036B904
		public IHardBattleModeSettingT UnPack()
		{
			IHardBattleModeSettingT hardBattleModeSettingT = new IHardBattleModeSettingT();
			this.UnPackTo(hardBattleModeSettingT);
			return hardBattleModeSettingT;
		}

		// Token: 0x06018025 RID: 98341 RVA: 0x0036D71F File Offset: 0x0036B91F
		public void UnPackTo(IHardBattleModeSettingT _o)
		{
			_o.CanOpenHardBattleMode = this.CanOpenHardBattleMode;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018026 RID: 98342 RVA: 0x0036D73C File Offset: 0x0036B93C
		public static Offset<IHardBattleModeSetting> Pack(FlatBufferBuilder builder, IHardBattleModeSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHardBattleModeSetting>);
			}
			return IHardBattleModeSetting.CreateIHardBattleModeSetting(builder, _o.CanOpenHardBattleMode, _o.NullMask);
		}

		// Token: 0x0400C237 RID: 49719
		private Table __p;
	}
}

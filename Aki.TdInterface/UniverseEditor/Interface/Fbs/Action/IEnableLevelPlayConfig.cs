using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE6 RID: 27878
	public struct IEnableLevelPlayConfig : IFlatbufferObject
	{
		// Token: 0x1700CC76 RID: 52342
		// (get) Token: 0x060300E8 RID: 196840 RVA: 0x00689C53 File Offset: 0x00687E53
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060300E9 RID: 196841 RVA: 0x00689C60 File Offset: 0x00687E60
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060300EA RID: 196842 RVA: 0x00689C68 File Offset: 0x00687E68
		public static IEnableLevelPlayConfig GetRootAsIEnableLevelPlayConfig(ByteBuffer _bb)
		{
			return IEnableLevelPlayConfig.GetRootAsIEnableLevelPlayConfig(_bb, default(IEnableLevelPlayConfig));
		}

		// Token: 0x060300EB RID: 196843 RVA: 0x00689C84 File Offset: 0x00687E84
		public static IEnableLevelPlayConfig GetRootAsIEnableLevelPlayConfig(ByteBuffer _bb, IEnableLevelPlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060300EC RID: 196844 RVA: 0x00689CA1 File Offset: 0x00687EA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060300ED RID: 196845 RVA: 0x00689CB0 File Offset: 0x00687EB0
		public IEnableLevelPlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC77 RID: 52343
		// (get) Token: 0x060300EE RID: 196846 RVA: 0x00689CC0 File Offset: 0x00687EC0
		public int LevelPlayId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC78 RID: 52344
		// (get) Token: 0x060300EF RID: 196847 RVA: 0x00689CFC File Offset: 0x00687EFC
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060300F0 RID: 196848 RVA: 0x00689D3B File Offset: 0x00687F3B
		public static Offset<IEnableLevelPlayConfig> CreateIEnableLevelPlayConfig(FlatBufferBuilder builder, int LevelPlayId = 0, bool Enable = false)
		{
			builder.StartTable(2);
			IEnableLevelPlayConfig.AddLevelPlayId(builder, LevelPlayId);
			IEnableLevelPlayConfig.AddEnable(builder, Enable);
			return IEnableLevelPlayConfig.EndIEnableLevelPlayConfig(builder);
		}

		// Token: 0x060300F1 RID: 196849 RVA: 0x00689D58 File Offset: 0x00687F58
		public static void StartIEnableLevelPlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060300F2 RID: 196850 RVA: 0x00689D61 File Offset: 0x00687F61
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(0, levelPlayId, 0);
		}

		// Token: 0x060300F3 RID: 196851 RVA: 0x00689D6C File Offset: 0x00687F6C
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(1, enable, false);
		}

		// Token: 0x060300F4 RID: 196852 RVA: 0x00689D77 File Offset: 0x00687F77
		public static Offset<IEnableLevelPlayConfig> EndIEnableLevelPlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEnableLevelPlayConfig>(builder.EndTable());
		}

		// Token: 0x060300F5 RID: 196853 RVA: 0x00689D84 File Offset: 0x00687F84
		public IEnableLevelPlayConfigT UnPack()
		{
			IEnableLevelPlayConfigT enableLevelPlayConfigT = new IEnableLevelPlayConfigT();
			this.UnPackTo(enableLevelPlayConfigT);
			return enableLevelPlayConfigT;
		}

		// Token: 0x060300F6 RID: 196854 RVA: 0x00689D9F File Offset: 0x00687F9F
		public void UnPackTo(IEnableLevelPlayConfigT _o)
		{
			_o.LevelPlayId = this.LevelPlayId;
			_o.Enable = this.Enable;
		}

		// Token: 0x060300F7 RID: 196855 RVA: 0x00689DBC File Offset: 0x00687FBC
		public static Offset<IEnableLevelPlayConfig> Pack(FlatBufferBuilder builder, IEnableLevelPlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableLevelPlayConfig>);
			}
			return IEnableLevelPlayConfig.CreateIEnableLevelPlayConfig(builder, _o.LevelPlayId, _o.Enable);
		}

		// Token: 0x04011B38 RID: 72504
		private Table __p;
	}
}

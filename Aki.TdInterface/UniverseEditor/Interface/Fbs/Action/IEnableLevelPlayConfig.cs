using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006672 RID: 26226
	public struct IEnableLevelPlayConfig : IFlatbufferObject
	{
		// Token: 0x1700C2D3 RID: 49875
		// (get) Token: 0x0602D8FF RID: 186623 RVA: 0x0063CEB7 File Offset: 0x0063B0B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D900 RID: 186624 RVA: 0x0063CEC4 File Offset: 0x0063B0C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D901 RID: 186625 RVA: 0x0063CECC File Offset: 0x0063B0CC
		public static IEnableLevelPlayConfig GetRootAsIEnableLevelPlayConfig(ByteBuffer _bb)
		{
			return IEnableLevelPlayConfig.GetRootAsIEnableLevelPlayConfig(_bb, default(IEnableLevelPlayConfig));
		}

		// Token: 0x0602D902 RID: 186626 RVA: 0x0063CEE8 File Offset: 0x0063B0E8
		public static IEnableLevelPlayConfig GetRootAsIEnableLevelPlayConfig(ByteBuffer _bb, IEnableLevelPlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D903 RID: 186627 RVA: 0x0063CF05 File Offset: 0x0063B105
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D904 RID: 186628 RVA: 0x0063CF14 File Offset: 0x0063B114
		public IEnableLevelPlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2D4 RID: 49876
		// (get) Token: 0x0602D905 RID: 186629 RVA: 0x0063CF24 File Offset: 0x0063B124
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

		// Token: 0x1700C2D5 RID: 49877
		// (get) Token: 0x0602D906 RID: 186630 RVA: 0x0063CF60 File Offset: 0x0063B160
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D907 RID: 186631 RVA: 0x0063CF9F File Offset: 0x0063B19F
		public static Offset<IEnableLevelPlayConfig> CreateIEnableLevelPlayConfig(FlatBufferBuilder builder, int LevelPlayId = 0, bool Enable = false)
		{
			builder.StartTable(2);
			IEnableLevelPlayConfig.AddLevelPlayId(builder, LevelPlayId);
			IEnableLevelPlayConfig.AddEnable(builder, Enable);
			return IEnableLevelPlayConfig.EndIEnableLevelPlayConfig(builder);
		}

		// Token: 0x0602D908 RID: 186632 RVA: 0x0063CFBC File Offset: 0x0063B1BC
		public static void StartIEnableLevelPlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D909 RID: 186633 RVA: 0x0063CFC5 File Offset: 0x0063B1C5
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(0, levelPlayId, 0);
		}

		// Token: 0x0602D90A RID: 186634 RVA: 0x0063CFD0 File Offset: 0x0063B1D0
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(1, enable, false);
		}

		// Token: 0x0602D90B RID: 186635 RVA: 0x0063CFDB File Offset: 0x0063B1DB
		public static Offset<IEnableLevelPlayConfig> EndIEnableLevelPlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEnableLevelPlayConfig>(builder.EndTable());
		}

		// Token: 0x0602D90C RID: 186636 RVA: 0x0063CFE8 File Offset: 0x0063B1E8
		public IEnableLevelPlayConfigT UnPack()
		{
			IEnableLevelPlayConfigT enableLevelPlayConfigT = new IEnableLevelPlayConfigT();
			this.UnPackTo(enableLevelPlayConfigT);
			return enableLevelPlayConfigT;
		}

		// Token: 0x0602D90D RID: 186637 RVA: 0x0063D003 File Offset: 0x0063B203
		public void UnPackTo(IEnableLevelPlayConfigT _o)
		{
			_o.LevelPlayId = this.LevelPlayId;
			_o.Enable = this.Enable;
		}

		// Token: 0x0602D90E RID: 186638 RVA: 0x0063D020 File Offset: 0x0063B220
		public static Offset<IEnableLevelPlayConfig> Pack(FlatBufferBuilder builder, IEnableLevelPlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableLevelPlayConfig>);
			}
			return IEnableLevelPlayConfig.CreateIEnableLevelPlayConfig(builder, _o.LevelPlayId, _o.Enable);
		}

		// Token: 0x04010D1A RID: 68890
		private Table __p;
	}
}

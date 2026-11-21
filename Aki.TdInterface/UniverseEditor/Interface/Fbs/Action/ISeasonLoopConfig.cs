using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200770B RID: 30475
	public struct ISeasonLoopConfig : IFlatbufferObject
	{
		// Token: 0x1700DF7F RID: 57215
		// (get) Token: 0x06035783 RID: 219011 RVA: 0x0072B714 File Offset: 0x00729914
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035784 RID: 219012 RVA: 0x0072B721 File Offset: 0x00729921
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035785 RID: 219013 RVA: 0x0072B728 File Offset: 0x00729928
		public static ISeasonLoopConfig GetRootAsISeasonLoopConfig(ByteBuffer _bb)
		{
			return ISeasonLoopConfig.GetRootAsISeasonLoopConfig(_bb, default(ISeasonLoopConfig));
		}

		// Token: 0x06035786 RID: 219014 RVA: 0x0072B744 File Offset: 0x00729944
		public static ISeasonLoopConfig GetRootAsISeasonLoopConfig(ByteBuffer _bb, ISeasonLoopConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035787 RID: 219015 RVA: 0x0072B761 File Offset: 0x00729961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035788 RID: 219016 RVA: 0x0072B770 File Offset: 0x00729970
		public ISeasonLoopConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF80 RID: 57216
		// (get) Token: 0x06035789 RID: 219017 RVA: 0x0072B780 File Offset: 0x00729980
		public float HoldTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DF81 RID: 57217
		// (get) Token: 0x0603578A RID: 219018 RVA: 0x0072B7C0 File Offset: 0x007299C0
		public float SwitchTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603578B RID: 219019 RVA: 0x0072B800 File Offset: 0x00729A00
		public static Offset<ISeasonLoopConfig> CreateISeasonLoopConfig(FlatBufferBuilder builder, float HoldTime = 0f, float SwitchTime = 0f)
		{
			builder.StartTable(2);
			ISeasonLoopConfig.AddSwitchTime(builder, SwitchTime);
			ISeasonLoopConfig.AddHoldTime(builder, HoldTime);
			return ISeasonLoopConfig.EndISeasonLoopConfig(builder);
		}

		// Token: 0x0603578C RID: 219020 RVA: 0x0072B81D File Offset: 0x00729A1D
		public static void StartISeasonLoopConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603578D RID: 219021 RVA: 0x0072B826 File Offset: 0x00729A26
		public static void AddHoldTime(FlatBufferBuilder builder, float holdTime)
		{
			builder.AddFloat(0, holdTime, 0.0);
		}

		// Token: 0x0603578E RID: 219022 RVA: 0x0072B839 File Offset: 0x00729A39
		public static void AddSwitchTime(FlatBufferBuilder builder, float switchTime)
		{
			builder.AddFloat(1, switchTime, 0.0);
		}

		// Token: 0x0603578F RID: 219023 RVA: 0x0072B84C File Offset: 0x00729A4C
		public static Offset<ISeasonLoopConfig> EndISeasonLoopConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISeasonLoopConfig>(builder.EndTable());
		}

		// Token: 0x06035790 RID: 219024 RVA: 0x0072B85C File Offset: 0x00729A5C
		public ISeasonLoopConfigT UnPack()
		{
			ISeasonLoopConfigT seasonLoopConfigT = new ISeasonLoopConfigT();
			this.UnPackTo(seasonLoopConfigT);
			return seasonLoopConfigT;
		}

		// Token: 0x06035791 RID: 219025 RVA: 0x0072B877 File Offset: 0x00729A77
		public void UnPackTo(ISeasonLoopConfigT _o)
		{
			_o.HoldTime = this.HoldTime;
			_o.SwitchTime = this.SwitchTime;
		}

		// Token: 0x06035792 RID: 219026 RVA: 0x0072B894 File Offset: 0x00729A94
		public static Offset<ISeasonLoopConfig> Pack(FlatBufferBuilder builder, ISeasonLoopConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeasonLoopConfig>);
			}
			return ISeasonLoopConfig.CreateISeasonLoopConfig(builder, _o.HoldTime, _o.SwitchTime);
		}

		// Token: 0x04012924 RID: 76068
		private Table __p;
	}
}

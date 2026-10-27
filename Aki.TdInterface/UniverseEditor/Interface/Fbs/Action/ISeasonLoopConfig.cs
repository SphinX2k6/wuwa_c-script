using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F51 RID: 28497
	public struct ISeasonLoopConfig : IFlatbufferObject
	{
		// Token: 0x1700D3C0 RID: 54208
		// (get) Token: 0x06032583 RID: 206211 RVA: 0x006CC458 File Offset: 0x006CA658
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032584 RID: 206212 RVA: 0x006CC465 File Offset: 0x006CA665
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032585 RID: 206213 RVA: 0x006CC46C File Offset: 0x006CA66C
		public static ISeasonLoopConfig GetRootAsISeasonLoopConfig(ByteBuffer _bb)
		{
			return ISeasonLoopConfig.GetRootAsISeasonLoopConfig(_bb, default(ISeasonLoopConfig));
		}

		// Token: 0x06032586 RID: 206214 RVA: 0x006CC488 File Offset: 0x006CA688
		public static ISeasonLoopConfig GetRootAsISeasonLoopConfig(ByteBuffer _bb, ISeasonLoopConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032587 RID: 206215 RVA: 0x006CC4A5 File Offset: 0x006CA6A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032588 RID: 206216 RVA: 0x006CC4B4 File Offset: 0x006CA6B4
		public ISeasonLoopConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3C1 RID: 54209
		// (get) Token: 0x06032589 RID: 206217 RVA: 0x006CC4C4 File Offset: 0x006CA6C4
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

		// Token: 0x1700D3C2 RID: 54210
		// (get) Token: 0x0603258A RID: 206218 RVA: 0x006CC504 File Offset: 0x006CA704
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

		// Token: 0x0603258B RID: 206219 RVA: 0x006CC544 File Offset: 0x006CA744
		public static Offset<ISeasonLoopConfig> CreateISeasonLoopConfig(FlatBufferBuilder builder, float HoldTime = 0f, float SwitchTime = 0f)
		{
			builder.StartTable(2);
			ISeasonLoopConfig.AddSwitchTime(builder, SwitchTime);
			ISeasonLoopConfig.AddHoldTime(builder, HoldTime);
			return ISeasonLoopConfig.EndISeasonLoopConfig(builder);
		}

		// Token: 0x0603258C RID: 206220 RVA: 0x006CC561 File Offset: 0x006CA761
		public static void StartISeasonLoopConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603258D RID: 206221 RVA: 0x006CC56A File Offset: 0x006CA76A
		public static void AddHoldTime(FlatBufferBuilder builder, float holdTime)
		{
			builder.AddFloat(0, holdTime, 0.0);
		}

		// Token: 0x0603258E RID: 206222 RVA: 0x006CC57D File Offset: 0x006CA77D
		public static void AddSwitchTime(FlatBufferBuilder builder, float switchTime)
		{
			builder.AddFloat(1, switchTime, 0.0);
		}

		// Token: 0x0603258F RID: 206223 RVA: 0x006CC590 File Offset: 0x006CA790
		public static Offset<ISeasonLoopConfig> EndISeasonLoopConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISeasonLoopConfig>(builder.EndTable());
		}

		// Token: 0x06032590 RID: 206224 RVA: 0x006CC5A0 File Offset: 0x006CA7A0
		public ISeasonLoopConfigT UnPack()
		{
			ISeasonLoopConfigT seasonLoopConfigT = new ISeasonLoopConfigT();
			this.UnPackTo(seasonLoopConfigT);
			return seasonLoopConfigT;
		}

		// Token: 0x06032591 RID: 206225 RVA: 0x006CC5BB File Offset: 0x006CA7BB
		public void UnPackTo(ISeasonLoopConfigT _o)
		{
			_o.HoldTime = this.HoldTime;
			_o.SwitchTime = this.SwitchTime;
		}

		// Token: 0x06032592 RID: 206226 RVA: 0x006CC5D8 File Offset: 0x006CA7D8
		public static Offset<ISeasonLoopConfig> Pack(FlatBufferBuilder builder, ISeasonLoopConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeasonLoopConfig>);
			}
			return ISeasonLoopConfig.CreateISeasonLoopConfig(builder, _o.HoldTime, _o.SwitchTime);
		}

		// Token: 0x0401194C RID: 72012
		private Table __p;
	}
}

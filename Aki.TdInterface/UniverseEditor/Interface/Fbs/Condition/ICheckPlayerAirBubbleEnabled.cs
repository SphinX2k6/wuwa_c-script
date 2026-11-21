using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FAA RID: 20394
	public struct ICheckPlayerAirBubbleEnabled : IFlatbufferObject
	{
		// Token: 0x170091DE RID: 37342
		// (get) Token: 0x0601FC87 RID: 130183 RVA: 0x0046A88C File Offset: 0x00468A8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FC88 RID: 130184 RVA: 0x0046A899 File Offset: 0x00468A99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FC89 RID: 130185 RVA: 0x0046A8A0 File Offset: 0x00468AA0
		public static ICheckPlayerAirBubbleEnabled GetRootAsICheckPlayerAirBubbleEnabled(ByteBuffer _bb)
		{
			return ICheckPlayerAirBubbleEnabled.GetRootAsICheckPlayerAirBubbleEnabled(_bb, default(ICheckPlayerAirBubbleEnabled));
		}

		// Token: 0x0601FC8A RID: 130186 RVA: 0x0046A8BC File Offset: 0x00468ABC
		public static ICheckPlayerAirBubbleEnabled GetRootAsICheckPlayerAirBubbleEnabled(ByteBuffer _bb, ICheckPlayerAirBubbleEnabled obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FC8B RID: 130187 RVA: 0x0046A8D9 File Offset: 0x00468AD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FC8C RID: 130188 RVA: 0x0046A8E8 File Offset: 0x00468AE8
		public ICheckPlayerAirBubbleEnabled __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091DF RID: 37343
		// (get) Token: 0x0601FC8D RID: 130189 RVA: 0x0046A8F8 File Offset: 0x00468AF8
		public EExploreSkillConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillConditionType.PlayerAirBubbleEnabled;
				}
				return (EExploreSkillConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091E0 RID: 37344
		// (get) Token: 0x0601FC8E RID: 130190 RVA: 0x0046A934 File Offset: 0x00468B34
		public bool IsEnabled
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FC8F RID: 130191 RVA: 0x0046A973 File Offset: 0x00468B73
		public static Offset<ICheckPlayerAirBubbleEnabled> CreateICheckPlayerAirBubbleEnabled(FlatBufferBuilder builder, EExploreSkillConditionType Type = EExploreSkillConditionType.PlayerAirBubbleEnabled, bool IsEnabled = false)
		{
			builder.StartTable(2);
			ICheckPlayerAirBubbleEnabled.AddIsEnabled(builder, IsEnabled);
			ICheckPlayerAirBubbleEnabled.AddType(builder, Type);
			return ICheckPlayerAirBubbleEnabled.EndICheckPlayerAirBubbleEnabled(builder);
		}

		// Token: 0x0601FC90 RID: 130192 RVA: 0x0046A990 File Offset: 0x00468B90
		public static void StartICheckPlayerAirBubbleEnabled(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FC91 RID: 130193 RVA: 0x0046A999 File Offset: 0x00468B99
		public static void AddType(FlatBufferBuilder builder, EExploreSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FC92 RID: 130194 RVA: 0x0046A9A4 File Offset: 0x00468BA4
		public static void AddIsEnabled(FlatBufferBuilder builder, bool isEnabled)
		{
			builder.AddBool(1, isEnabled, false);
		}

		// Token: 0x0601FC93 RID: 130195 RVA: 0x0046A9AF File Offset: 0x00468BAF
		public static Offset<ICheckPlayerAirBubbleEnabled> EndICheckPlayerAirBubbleEnabled(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerAirBubbleEnabled>(builder.EndTable());
		}

		// Token: 0x0601FC94 RID: 130196 RVA: 0x0046A9BC File Offset: 0x00468BBC
		public ICheckPlayerAirBubbleEnabledT UnPack()
		{
			ICheckPlayerAirBubbleEnabledT checkPlayerAirBubbleEnabledT = new ICheckPlayerAirBubbleEnabledT();
			this.UnPackTo(checkPlayerAirBubbleEnabledT);
			return checkPlayerAirBubbleEnabledT;
		}

		// Token: 0x0601FC95 RID: 130197 RVA: 0x0046A9D7 File Offset: 0x00468BD7
		public void UnPackTo(ICheckPlayerAirBubbleEnabledT _o)
		{
			_o.Type = this.Type;
			_o.IsEnabled = this.IsEnabled;
		}

		// Token: 0x0601FC96 RID: 130198 RVA: 0x0046A9F4 File Offset: 0x00468BF4
		public static Offset<ICheckPlayerAirBubbleEnabled> Pack(FlatBufferBuilder builder, ICheckPlayerAirBubbleEnabledT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerAirBubbleEnabled>);
			}
			return ICheckPlayerAirBubbleEnabled.CreateICheckPlayerAirBubbleEnabled(builder, _o.Type, _o.IsEnabled);
		}

		// Token: 0x0400DE4A RID: 56906
		private Table __p;
	}
}

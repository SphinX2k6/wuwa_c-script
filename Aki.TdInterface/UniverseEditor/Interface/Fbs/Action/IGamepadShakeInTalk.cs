using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006873 RID: 26739
	public struct IGamepadShakeInTalk : IFlatbufferObject
	{
		// Token: 0x1700C69A RID: 50842
		// (get) Token: 0x0602EA19 RID: 191001 RVA: 0x0065C030 File Offset: 0x0065A230
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA1A RID: 191002 RVA: 0x0065C03D File Offset: 0x0065A23D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA1B RID: 191003 RVA: 0x0065C044 File Offset: 0x0065A244
		public static IGamepadShakeInTalk GetRootAsIGamepadShakeInTalk(ByteBuffer _bb)
		{
			return IGamepadShakeInTalk.GetRootAsIGamepadShakeInTalk(_bb, default(IGamepadShakeInTalk));
		}

		// Token: 0x0602EA1C RID: 191004 RVA: 0x0065C060 File Offset: 0x0065A260
		public static IGamepadShakeInTalk GetRootAsIGamepadShakeInTalk(ByteBuffer _bb, IGamepadShakeInTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA1D RID: 191005 RVA: 0x0065C07D File Offset: 0x0065A27D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA1E RID: 191006 RVA: 0x0065C08C File Offset: 0x0065A28C
		public IGamepadShakeInTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C69B RID: 50843
		// (get) Token: 0x0602EA1F RID: 191007 RVA: 0x0065C09C File Offset: 0x0065A29C
		public float DelayTime
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

		// Token: 0x1700C69C RID: 50844
		// (get) Token: 0x0602EA20 RID: 191008 RVA: 0x0065C0DC File Offset: 0x0065A2DC
		public IGamepadShakeOptions? Options
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IGamepadShakeOptions?(default(IGamepadShakeOptions).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602EA21 RID: 191009 RVA: 0x0065C139 File Offset: 0x0065A339
		public static Offset<IGamepadShakeInTalk> CreateIGamepadShakeInTalk(FlatBufferBuilder builder, float DelayTime = 0f, Offset<IGamepadShakeOptions> OptionsOffset = default(Offset<IGamepadShakeOptions>))
		{
			builder.StartTable(2);
			IGamepadShakeInTalk.AddOptions(builder, OptionsOffset);
			IGamepadShakeInTalk.AddDelayTime(builder, DelayTime);
			return IGamepadShakeInTalk.EndIGamepadShakeInTalk(builder);
		}

		// Token: 0x0602EA22 RID: 191010 RVA: 0x0065C156 File Offset: 0x0065A356
		public static void StartIGamepadShakeInTalk(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EA23 RID: 191011 RVA: 0x0065C15F File Offset: 0x0065A35F
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(0, delayTime, 0.0);
		}

		// Token: 0x0602EA24 RID: 191012 RVA: 0x0065C172 File Offset: 0x0065A372
		public static void AddOptions(FlatBufferBuilder builder, Offset<IGamepadShakeOptions> optionsOffset)
		{
			builder.AddOffset(1, optionsOffset.Value, 0);
		}

		// Token: 0x0602EA25 RID: 191013 RVA: 0x0065C182 File Offset: 0x0065A382
		public static Offset<IGamepadShakeInTalk> EndIGamepadShakeInTalk(FlatBufferBuilder builder)
		{
			return new Offset<IGamepadShakeInTalk>(builder.EndTable());
		}

		// Token: 0x0602EA26 RID: 191014 RVA: 0x0065C190 File Offset: 0x0065A390
		public IGamepadShakeInTalkT UnPack()
		{
			IGamepadShakeInTalkT gamepadShakeInTalkT = new IGamepadShakeInTalkT();
			this.UnPackTo(gamepadShakeInTalkT);
			return gamepadShakeInTalkT;
		}

		// Token: 0x0602EA27 RID: 191015 RVA: 0x0065C1AC File Offset: 0x0065A3AC
		public void UnPackTo(IGamepadShakeInTalkT _o)
		{
			_o.DelayTime = this.DelayTime;
			_o.Options = ((this.Options != null) ? this.Options.Value.UnPack() : null);
		}

		// Token: 0x0602EA28 RID: 191016 RVA: 0x0065C1F4 File Offset: 0x0065A3F4
		public static Offset<IGamepadShakeInTalk> Pack(FlatBufferBuilder builder, IGamepadShakeInTalkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGamepadShakeInTalk>);
			}
			Offset<IGamepadShakeOptions> optionsOffset = (_o.Options == null) ? default(Offset<IGamepadShakeOptions>) : IGamepadShakeOptions.Pack(builder, _o.Options);
			return IGamepadShakeInTalk.CreateIGamepadShakeInTalk(builder, _o.DelayTime, optionsOffset);
		}

		// Token: 0x04010FCA RID: 69578
		private Table __p;
	}
}

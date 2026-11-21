using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F14 RID: 28436
	public struct IGamepadShakeInTalk : IFlatbufferObject
	{
		// Token: 0x1700D080 RID: 53376
		// (get) Token: 0x06031353 RID: 201555 RVA: 0x006AB0B0 File Offset: 0x006A92B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031354 RID: 201556 RVA: 0x006AB0BD File Offset: 0x006A92BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031355 RID: 201557 RVA: 0x006AB0C4 File Offset: 0x006A92C4
		public static IGamepadShakeInTalk GetRootAsIGamepadShakeInTalk(ByteBuffer _bb)
		{
			return IGamepadShakeInTalk.GetRootAsIGamepadShakeInTalk(_bb, default(IGamepadShakeInTalk));
		}

		// Token: 0x06031356 RID: 201558 RVA: 0x006AB0E0 File Offset: 0x006A92E0
		public static IGamepadShakeInTalk GetRootAsIGamepadShakeInTalk(ByteBuffer _bb, IGamepadShakeInTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031357 RID: 201559 RVA: 0x006AB0FD File Offset: 0x006A92FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031358 RID: 201560 RVA: 0x006AB10C File Offset: 0x006A930C
		public IGamepadShakeInTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D081 RID: 53377
		// (get) Token: 0x06031359 RID: 201561 RVA: 0x006AB11C File Offset: 0x006A931C
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

		// Token: 0x1700D082 RID: 53378
		// (get) Token: 0x0603135A RID: 201562 RVA: 0x006AB15C File Offset: 0x006A935C
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

		// Token: 0x0603135B RID: 201563 RVA: 0x006AB1B9 File Offset: 0x006A93B9
		public static Offset<IGamepadShakeInTalk> CreateIGamepadShakeInTalk(FlatBufferBuilder builder, float DelayTime = 0f, Offset<IGamepadShakeOptions> OptionsOffset = default(Offset<IGamepadShakeOptions>))
		{
			builder.StartTable(2);
			IGamepadShakeInTalk.AddOptions(builder, OptionsOffset);
			IGamepadShakeInTalk.AddDelayTime(builder, DelayTime);
			return IGamepadShakeInTalk.EndIGamepadShakeInTalk(builder);
		}

		// Token: 0x0603135C RID: 201564 RVA: 0x006AB1D6 File Offset: 0x006A93D6
		public static void StartIGamepadShakeInTalk(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603135D RID: 201565 RVA: 0x006AB1DF File Offset: 0x006A93DF
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(0, delayTime, 0.0);
		}

		// Token: 0x0603135E RID: 201566 RVA: 0x006AB1F2 File Offset: 0x006A93F2
		public static void AddOptions(FlatBufferBuilder builder, Offset<IGamepadShakeOptions> optionsOffset)
		{
			builder.AddOffset(1, optionsOffset.Value, 0);
		}

		// Token: 0x0603135F RID: 201567 RVA: 0x006AB202 File Offset: 0x006A9402
		public static Offset<IGamepadShakeInTalk> EndIGamepadShakeInTalk(FlatBufferBuilder builder)
		{
			return new Offset<IGamepadShakeInTalk>(builder.EndTable());
		}

		// Token: 0x06031360 RID: 201568 RVA: 0x006AB210 File Offset: 0x006A9410
		public IGamepadShakeInTalkT UnPack()
		{
			IGamepadShakeInTalkT gamepadShakeInTalkT = new IGamepadShakeInTalkT();
			this.UnPackTo(gamepadShakeInTalkT);
			return gamepadShakeInTalkT;
		}

		// Token: 0x06031361 RID: 201569 RVA: 0x006AB22C File Offset: 0x006A942C
		public void UnPackTo(IGamepadShakeInTalkT _o)
		{
			_o.DelayTime = this.DelayTime;
			_o.Options = ((this.Options != null) ? this.Options.Value.UnPack() : null);
		}

		// Token: 0x06031362 RID: 201570 RVA: 0x006AB274 File Offset: 0x006A9474
		public static Offset<IGamepadShakeInTalk> Pack(FlatBufferBuilder builder, IGamepadShakeInTalkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGamepadShakeInTalk>);
			}
			Offset<IGamepadShakeOptions> optionsOffset = (_o.Options == null) ? default(Offset<IGamepadShakeOptions>) : IGamepadShakeOptions.Pack(builder, _o.Options);
			return IGamepadShakeInTalk.CreateIGamepadShakeInTalk(builder, _o.DelayTime, optionsOffset);
		}

		// Token: 0x04011E1F RID: 73247
		private Table __p;
	}
}

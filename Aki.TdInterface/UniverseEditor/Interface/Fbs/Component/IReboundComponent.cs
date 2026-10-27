using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580B RID: 22539
	public struct IReboundComponent : IFlatbufferObject
	{
		// Token: 0x1700A85F RID: 43103
		// (get) Token: 0x06025E47 RID: 155207 RVA: 0x00539C57 File Offset: 0x00537E57
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025E48 RID: 155208 RVA: 0x00539C64 File Offset: 0x00537E64
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025E49 RID: 155209 RVA: 0x00539C6C File Offset: 0x00537E6C
		public static IReboundComponent GetRootAsIReboundComponent(ByteBuffer _bb)
		{
			return IReboundComponent.GetRootAsIReboundComponent(_bb, default(IReboundComponent));
		}

		// Token: 0x06025E4A RID: 155210 RVA: 0x00539C88 File Offset: 0x00537E88
		public static IReboundComponent GetRootAsIReboundComponent(ByteBuffer _bb, IReboundComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025E4B RID: 155211 RVA: 0x00539CA5 File Offset: 0x00537EA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025E4C RID: 155212 RVA: 0x00539CB4 File Offset: 0x00537EB4
		public IReboundComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A860 RID: 43104
		// (get) Token: 0x06025E4D RID: 155213 RVA: 0x00539CC4 File Offset: 0x00537EC4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A861 RID: 43105
		// (get) Token: 0x06025E4E RID: 155214 RVA: 0x00539D04 File Offset: 0x00537F04
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A862 RID: 43106
		// (get) Token: 0x06025E4F RID: 155215 RVA: 0x00539D44 File Offset: 0x00537F44
		public IForwardFrontRebound? Option
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IForwardFrontRebound?(default(IForwardFrontRebound).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A863 RID: 43107
		// (get) Token: 0x06025E50 RID: 155216 RVA: 0x00539DA4 File Offset: 0x00537FA4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025E51 RID: 155217 RVA: 0x00539DE1 File Offset: 0x00537FE1
		public static Offset<IReboundComponent> CreateIReboundComponent(FlatBufferBuilder builder, bool Disabled = false, long BulletId = 0L, Offset<IForwardFrontRebound> OptionOffset = default(Offset<IForwardFrontRebound>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IReboundComponent.AddBulletId(builder, BulletId);
			IReboundComponent.AddOption(builder, OptionOffset);
			IReboundComponent.AddNullMask(builder, NullMask);
			IReboundComponent.AddDisabled(builder, Disabled);
			return IReboundComponent.EndIReboundComponent(builder);
		}

		// Token: 0x06025E52 RID: 155218 RVA: 0x00539E0D File Offset: 0x0053800D
		public static void StartIReboundComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025E53 RID: 155219 RVA: 0x00539E16 File Offset: 0x00538016
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025E54 RID: 155220 RVA: 0x00539E21 File Offset: 0x00538021
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06025E55 RID: 155221 RVA: 0x00539E2D File Offset: 0x0053802D
		public static void AddOption(FlatBufferBuilder builder, Offset<IForwardFrontRebound> optionOffset)
		{
			builder.AddOffset(2, optionOffset.Value, 0);
		}

		// Token: 0x06025E56 RID: 155222 RVA: 0x00539E3D File Offset: 0x0053803D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025E57 RID: 155223 RVA: 0x00539E48 File Offset: 0x00538048
		public static Offset<IReboundComponent> EndIReboundComponent(FlatBufferBuilder builder)
		{
			return new Offset<IReboundComponent>(builder.EndTable());
		}

		// Token: 0x06025E58 RID: 155224 RVA: 0x00539E58 File Offset: 0x00538058
		public IReboundComponentT UnPack()
		{
			IReboundComponentT reboundComponentT = new IReboundComponentT();
			this.UnPackTo(reboundComponentT);
			return reboundComponentT;
		}

		// Token: 0x06025E59 RID: 155225 RVA: 0x00539E74 File Offset: 0x00538074
		public void UnPackTo(IReboundComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.BulletId = this.BulletId;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025E5A RID: 155226 RVA: 0x00539ED4 File Offset: 0x005380D4
		public static Offset<IReboundComponent> Pack(FlatBufferBuilder builder, IReboundComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReboundComponent>);
			}
			Offset<IForwardFrontRebound> optionOffset = (_o.Option == null) ? default(Offset<IForwardFrontRebound>) : IForwardFrontRebound.Pack(builder, _o.Option);
			return IReboundComponent.CreateIReboundComponent(builder, _o.Disabled, _o.BulletId, optionOffset, _o.NullMask);
		}

		// Token: 0x0400ED09 RID: 60681
		private Table __p;
	}
}

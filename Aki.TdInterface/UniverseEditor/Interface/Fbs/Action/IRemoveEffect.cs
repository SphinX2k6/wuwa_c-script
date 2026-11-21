using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C1 RID: 30145
	public struct IRemoveEffect : IFlatbufferObject
	{
		// Token: 0x1700DDA1 RID: 56737
		// (get) Token: 0x06034E2C RID: 216620 RVA: 0x0071B9F2 File Offset: 0x00719BF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034E2D RID: 216621 RVA: 0x0071B9FF File Offset: 0x00719BFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034E2E RID: 216622 RVA: 0x0071BA08 File Offset: 0x00719C08
		public static IRemoveEffect GetRootAsIRemoveEffect(ByteBuffer _bb)
		{
			return IRemoveEffect.GetRootAsIRemoveEffect(_bb, default(IRemoveEffect));
		}

		// Token: 0x06034E2F RID: 216623 RVA: 0x0071BA24 File Offset: 0x00719C24
		public static IRemoveEffect GetRootAsIRemoveEffect(ByteBuffer _bb, IRemoveEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034E30 RID: 216624 RVA: 0x0071BA41 File Offset: 0x00719C41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034E31 RID: 216625 RVA: 0x0071BA50 File Offset: 0x00719C50
		public IRemoveEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDA2 RID: 56738
		// (get) Token: 0x06034E32 RID: 216626 RVA: 0x0071BA60 File Offset: 0x00719C60
		public IRemoveScreenEffect? RemoveEffectConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IRemoveScreenEffect?(default(IRemoveScreenEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06034E33 RID: 216627 RVA: 0x0071BABD File Offset: 0x00719CBD
		public static Offset<IRemoveEffect> CreateIRemoveEffect(FlatBufferBuilder builder, Offset<IRemoveScreenEffect> RemoveEffectConfigOffset = default(Offset<IRemoveScreenEffect>))
		{
			builder.StartTable(1);
			IRemoveEffect.AddRemoveEffectConfig(builder, RemoveEffectConfigOffset);
			return IRemoveEffect.EndIRemoveEffect(builder);
		}

		// Token: 0x06034E34 RID: 216628 RVA: 0x0071BAD3 File Offset: 0x00719CD3
		public static void StartIRemoveEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034E35 RID: 216629 RVA: 0x0071BADC File Offset: 0x00719CDC
		public static void AddRemoveEffectConfig(FlatBufferBuilder builder, Offset<IRemoveScreenEffect> removeEffectConfigOffset)
		{
			builder.AddOffset(0, removeEffectConfigOffset.Value, 0);
		}

		// Token: 0x06034E36 RID: 216630 RVA: 0x0071BAEC File Offset: 0x00719CEC
		public static Offset<IRemoveEffect> EndIRemoveEffect(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveEffect>(builder.EndTable());
		}

		// Token: 0x06034E37 RID: 216631 RVA: 0x0071BAFC File Offset: 0x00719CFC
		public IRemoveEffectT UnPack()
		{
			IRemoveEffectT removeEffectT = new IRemoveEffectT();
			this.UnPackTo(removeEffectT);
			return removeEffectT;
		}

		// Token: 0x06034E38 RID: 216632 RVA: 0x0071BB18 File Offset: 0x00719D18
		public void UnPackTo(IRemoveEffectT _o)
		{
			_o.RemoveEffectConfig = ((this.RemoveEffectConfig != null) ? this.RemoveEffectConfig.Value.UnPack() : null);
		}

		// Token: 0x06034E39 RID: 216633 RVA: 0x0071BB54 File Offset: 0x00719D54
		public static Offset<IRemoveEffect> Pack(FlatBufferBuilder builder, IRemoveEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveEffect>);
			}
			Offset<IRemoveScreenEffect> removeEffectConfigOffset = (_o.RemoveEffectConfig == null) ? default(Offset<IRemoveScreenEffect>) : IRemoveScreenEffect.Pack(builder, _o.RemoveEffectConfig);
			return IRemoveEffect.CreateIRemoveEffect(builder, removeEffectConfigOffset);
		}

		// Token: 0x040127A7 RID: 75687
		private Table __p;
	}
}

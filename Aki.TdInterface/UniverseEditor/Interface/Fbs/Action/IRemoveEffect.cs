using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E43 RID: 28227
	public struct IRemoveEffect : IFlatbufferObject
	{
		// Token: 0x1700D252 RID: 53842
		// (get) Token: 0x06031E16 RID: 204310 RVA: 0x006C006A File Offset: 0x006BE26A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031E17 RID: 204311 RVA: 0x006C0077 File Offset: 0x006BE277
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031E18 RID: 204312 RVA: 0x006C0080 File Offset: 0x006BE280
		public static IRemoveEffect GetRootAsIRemoveEffect(ByteBuffer _bb)
		{
			return IRemoveEffect.GetRootAsIRemoveEffect(_bb, default(IRemoveEffect));
		}

		// Token: 0x06031E19 RID: 204313 RVA: 0x006C009C File Offset: 0x006BE29C
		public static IRemoveEffect GetRootAsIRemoveEffect(ByteBuffer _bb, IRemoveEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E1A RID: 204314 RVA: 0x006C00B9 File Offset: 0x006BE2B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E1B RID: 204315 RVA: 0x006C00C8 File Offset: 0x006BE2C8
		public IRemoveEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D253 RID: 53843
		// (get) Token: 0x06031E1C RID: 204316 RVA: 0x006C00D8 File Offset: 0x006BE2D8
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

		// Token: 0x06031E1D RID: 204317 RVA: 0x006C0135 File Offset: 0x006BE335
		public static Offset<IRemoveEffect> CreateIRemoveEffect(FlatBufferBuilder builder, Offset<IRemoveScreenEffect> RemoveEffectConfigOffset = default(Offset<IRemoveScreenEffect>))
		{
			builder.StartTable(1);
			IRemoveEffect.AddRemoveEffectConfig(builder, RemoveEffectConfigOffset);
			return IRemoveEffect.EndIRemoveEffect(builder);
		}

		// Token: 0x06031E1E RID: 204318 RVA: 0x006C014B File Offset: 0x006BE34B
		public static void StartIRemoveEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031E1F RID: 204319 RVA: 0x006C0154 File Offset: 0x006BE354
		public static void AddRemoveEffectConfig(FlatBufferBuilder builder, Offset<IRemoveScreenEffect> removeEffectConfigOffset)
		{
			builder.AddOffset(0, removeEffectConfigOffset.Value, 0);
		}

		// Token: 0x06031E20 RID: 204320 RVA: 0x006C0164 File Offset: 0x006BE364
		public static Offset<IRemoveEffect> EndIRemoveEffect(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveEffect>(builder.EndTable());
		}

		// Token: 0x06031E21 RID: 204321 RVA: 0x006C0174 File Offset: 0x006BE374
		public IRemoveEffectT UnPack()
		{
			IRemoveEffectT removeEffectT = new IRemoveEffectT();
			this.UnPackTo(removeEffectT);
			return removeEffectT;
		}

		// Token: 0x06031E22 RID: 204322 RVA: 0x006C0190 File Offset: 0x006BE390
		public void UnPackTo(IRemoveEffectT _o)
		{
			_o.RemoveEffectConfig = ((this.RemoveEffectConfig != null) ? this.RemoveEffectConfig.Value.UnPack() : null);
		}

		// Token: 0x06031E23 RID: 204323 RVA: 0x006C01CC File Offset: 0x006BE3CC
		public static Offset<IRemoveEffect> Pack(FlatBufferBuilder builder, IRemoveEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveEffect>);
			}
			Offset<IRemoveScreenEffect> removeEffectConfigOffset = (_o.RemoveEffectConfig == null) ? default(Offset<IRemoveScreenEffect>) : IRemoveScreenEffect.Pack(builder, _o.RemoveEffectConfig);
			return IRemoveEffect.CreateIRemoveEffect(builder, removeEffectConfigOffset);
		}

		// Token: 0x04011827 RID: 71719
		private Table __p;
	}
}

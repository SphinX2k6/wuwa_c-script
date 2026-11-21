using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A23 RID: 23075
	public struct IItemLockingConfig : IFlatbufferObject
	{
		// Token: 0x1700A7B8 RID: 42936
		// (get) Token: 0x06025B22 RID: 154402 RVA: 0x0052ADA0 File Offset: 0x00528FA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025B23 RID: 154403 RVA: 0x0052ADAD File Offset: 0x00528FAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025B24 RID: 154404 RVA: 0x0052ADB4 File Offset: 0x00528FB4
		public static IItemLockingConfig GetRootAsIItemLockingConfig(ByteBuffer _bb)
		{
			return IItemLockingConfig.GetRootAsIItemLockingConfig(_bb, default(IItemLockingConfig));
		}

		// Token: 0x06025B25 RID: 154405 RVA: 0x0052ADD0 File Offset: 0x00528FD0
		public static IItemLockingConfig GetRootAsIItemLockingConfig(ByteBuffer _bb, IItemLockingConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025B26 RID: 154406 RVA: 0x0052ADED File Offset: 0x00528FED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025B27 RID: 154407 RVA: 0x0052ADFC File Offset: 0x00528FFC
		public IItemLockingConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7B9 RID: 42937
		// (get) Token: 0x06025B28 RID: 154408 RVA: 0x0052AE0C File Offset: 0x0052900C
		public string EffectPath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025B29 RID: 154409 RVA: 0x0052AE43 File Offset: 0x00529043
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06025B2A RID: 154410 RVA: 0x0052AE52 File Offset: 0x00529052
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A7BA RID: 42938
		// (get) Token: 0x06025B2B RID: 154411 RVA: 0x0052AE60 File Offset: 0x00529060
		public ETeleControlLockingPerform TeleControlPerform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETeleControlLockingPerform.RightMatch;
				}
				return (ETeleControlLockingPerform)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A7BB RID: 42939
		// (get) Token: 0x06025B2C RID: 154412 RVA: 0x0052AE9C File Offset: 0x0052909C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025B2D RID: 154413 RVA: 0x0052AED8 File Offset: 0x005290D8
		public static Offset<IItemLockingConfig> CreateIItemLockingConfig(FlatBufferBuilder builder, StringOffset EffectPathOffset = default(StringOffset), ETeleControlLockingPerform TeleControlPerform = ETeleControlLockingPerform.RightMatch, byte NullMask = 0)
		{
			builder.StartTable(3);
			IItemLockingConfig.AddEffectPath(builder, EffectPathOffset);
			IItemLockingConfig.AddNullMask(builder, NullMask);
			IItemLockingConfig.AddTeleControlPerform(builder, TeleControlPerform);
			return IItemLockingConfig.EndIItemLockingConfig(builder);
		}

		// Token: 0x06025B2E RID: 154414 RVA: 0x0052AEFC File Offset: 0x005290FC
		public static void StartIItemLockingConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025B2F RID: 154415 RVA: 0x0052AF05 File Offset: 0x00529105
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(0, effectPathOffset.Value, 0);
		}

		// Token: 0x06025B30 RID: 154416 RVA: 0x0052AF15 File Offset: 0x00529115
		public static void AddTeleControlPerform(FlatBufferBuilder builder, ETeleControlLockingPerform teleControlPerform)
		{
			builder.AddByte(1, (byte)teleControlPerform, 0);
		}

		// Token: 0x06025B31 RID: 154417 RVA: 0x0052AF20 File Offset: 0x00529120
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06025B32 RID: 154418 RVA: 0x0052AF2B File Offset: 0x0052912B
		public static Offset<IItemLockingConfig> EndIItemLockingConfig(FlatBufferBuilder builder)
		{
			return new Offset<IItemLockingConfig>(builder.EndTable());
		}

		// Token: 0x06025B33 RID: 154419 RVA: 0x0052AF38 File Offset: 0x00529138
		public IItemLockingConfigT UnPack()
		{
			IItemLockingConfigT itemLockingConfigT = new IItemLockingConfigT();
			this.UnPackTo(itemLockingConfigT);
			return itemLockingConfigT;
		}

		// Token: 0x06025B34 RID: 154420 RVA: 0x0052AF53 File Offset: 0x00529153
		public void UnPackTo(IItemLockingConfigT _o)
		{
			_o.EffectPath = this.EffectPath;
			_o.TeleControlPerform = this.TeleControlPerform;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025B35 RID: 154421 RVA: 0x0052AF7C File Offset: 0x0052917C
		public static Offset<IItemLockingConfig> Pack(FlatBufferBuilder builder, IItemLockingConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemLockingConfig>);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			return IItemLockingConfig.CreateIItemLockingConfig(builder, effectPathOffset, _o.TeleControlPerform, _o.NullMask);
		}

		// Token: 0x0400F369 RID: 62313
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200605C RID: 24668
	public struct ITeleportSceneEffect : IFlatbufferObject
	{
		// Token: 0x1700B721 RID: 46881
		// (get) Token: 0x06029A7E RID: 170622 RVA: 0x005AFD21 File Offset: 0x005ADF21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029A7F RID: 170623 RVA: 0x005AFD2E File Offset: 0x005ADF2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029A80 RID: 170624 RVA: 0x005AFD38 File Offset: 0x005ADF38
		public static ITeleportSceneEffect GetRootAsITeleportSceneEffect(ByteBuffer _bb)
		{
			return ITeleportSceneEffect.GetRootAsITeleportSceneEffect(_bb, default(ITeleportSceneEffect));
		}

		// Token: 0x06029A81 RID: 170625 RVA: 0x005AFD54 File Offset: 0x005ADF54
		public static ITeleportSceneEffect GetRootAsITeleportSceneEffect(ByteBuffer _bb, ITeleportSceneEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029A82 RID: 170626 RVA: 0x005AFD71 File Offset: 0x005ADF71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029A83 RID: 170627 RVA: 0x005AFD80 File Offset: 0x005ADF80
		public ITeleportSceneEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B722 RID: 46882
		// (get) Token: 0x06029A84 RID: 170628 RVA: 0x005AFD90 File Offset: 0x005ADF90
		public string WorldEffectPath
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

		// Token: 0x06029A85 RID: 170629 RVA: 0x005AFDC7 File Offset: 0x005ADFC7
		public Span<byte> GetWorldEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029A86 RID: 170630 RVA: 0x005AFDD6 File Offset: 0x005ADFD6
		public byte[] GetWorldEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B723 RID: 46883
		// (get) Token: 0x06029A87 RID: 170631 RVA: 0x005AFDE4 File Offset: 0x005ADFE4
		public string ScreenEffectPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029A88 RID: 170632 RVA: 0x005AFE1B File Offset: 0x005AE01B
		public Span<byte> GetScreenEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029A89 RID: 170633 RVA: 0x005AFE2A File Offset: 0x005AE02A
		public byte[] GetScreenEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06029A8A RID: 170634 RVA: 0x005AFE38 File Offset: 0x005AE038
		public static Offset<ITeleportSceneEffect> CreateITeleportSceneEffect(FlatBufferBuilder builder, StringOffset WorldEffectPathOffset = default(StringOffset), StringOffset ScreenEffectPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITeleportSceneEffect.AddScreenEffectPath(builder, ScreenEffectPathOffset);
			ITeleportSceneEffect.AddWorldEffectPath(builder, WorldEffectPathOffset);
			return ITeleportSceneEffect.EndITeleportSceneEffect(builder);
		}

		// Token: 0x06029A8B RID: 170635 RVA: 0x005AFE55 File Offset: 0x005AE055
		public static void StartITeleportSceneEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029A8C RID: 170636 RVA: 0x005AFE5E File Offset: 0x005AE05E
		public static void AddWorldEffectPath(FlatBufferBuilder builder, StringOffset worldEffectPathOffset)
		{
			builder.AddOffset(0, worldEffectPathOffset.Value, 0);
		}

		// Token: 0x06029A8D RID: 170637 RVA: 0x005AFE6E File Offset: 0x005AE06E
		public static void AddScreenEffectPath(FlatBufferBuilder builder, StringOffset screenEffectPathOffset)
		{
			builder.AddOffset(1, screenEffectPathOffset.Value, 0);
		}

		// Token: 0x06029A8E RID: 170638 RVA: 0x005AFE7E File Offset: 0x005AE07E
		public static Offset<ITeleportSceneEffect> EndITeleportSceneEffect(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportSceneEffect>(builder.EndTable());
		}

		// Token: 0x06029A8F RID: 170639 RVA: 0x005AFE8C File Offset: 0x005AE08C
		public ITeleportSceneEffectT UnPack()
		{
			ITeleportSceneEffectT teleportSceneEffectT = new ITeleportSceneEffectT();
			this.UnPackTo(teleportSceneEffectT);
			return teleportSceneEffectT;
		}

		// Token: 0x06029A90 RID: 170640 RVA: 0x005AFEA7 File Offset: 0x005AE0A7
		public void UnPackTo(ITeleportSceneEffectT _o)
		{
			_o.WorldEffectPath = this.WorldEffectPath;
			_o.ScreenEffectPath = this.ScreenEffectPath;
		}

		// Token: 0x06029A91 RID: 170641 RVA: 0x005AFEC4 File Offset: 0x005AE0C4
		public static Offset<ITeleportSceneEffect> Pack(FlatBufferBuilder builder, ITeleportSceneEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportSceneEffect>);
			}
			StringOffset worldEffectPathOffset = (_o.WorldEffectPath == null) ? default(StringOffset) : builder.CreateString(_o.WorldEffectPath);
			StringOffset screenEffectPathOffset = (_o.ScreenEffectPath == null) ? default(StringOffset) : builder.CreateString(_o.ScreenEffectPath);
			return ITeleportSceneEffect.CreateITeleportSceneEffect(builder, worldEffectPathOffset, screenEffectPathOffset);
		}

		// Token: 0x0400FDCC RID: 64972
		private Table __p;
	}
}

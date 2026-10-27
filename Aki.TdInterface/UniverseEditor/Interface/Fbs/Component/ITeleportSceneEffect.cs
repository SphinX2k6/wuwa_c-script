using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A4F RID: 23119
	public struct ITeleportSceneEffect : IFlatbufferObject
	{
		// Token: 0x1700ADE9 RID: 44521
		// (get) Token: 0x06027506 RID: 161030 RVA: 0x00568D15 File Offset: 0x00566F15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027507 RID: 161031 RVA: 0x00568D22 File Offset: 0x00566F22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027508 RID: 161032 RVA: 0x00568D2C File Offset: 0x00566F2C
		public static ITeleportSceneEffect GetRootAsITeleportSceneEffect(ByteBuffer _bb)
		{
			return ITeleportSceneEffect.GetRootAsITeleportSceneEffect(_bb, default(ITeleportSceneEffect));
		}

		// Token: 0x06027509 RID: 161033 RVA: 0x00568D48 File Offset: 0x00566F48
		public static ITeleportSceneEffect GetRootAsITeleportSceneEffect(ByteBuffer _bb, ITeleportSceneEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602750A RID: 161034 RVA: 0x00568D65 File Offset: 0x00566F65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602750B RID: 161035 RVA: 0x00568D74 File Offset: 0x00566F74
		public ITeleportSceneEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADEA RID: 44522
		// (get) Token: 0x0602750C RID: 161036 RVA: 0x00568D84 File Offset: 0x00566F84
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

		// Token: 0x0602750D RID: 161037 RVA: 0x00568DBB File Offset: 0x00566FBB
		public Span<byte> GetWorldEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602750E RID: 161038 RVA: 0x00568DCA File Offset: 0x00566FCA
		public byte[] GetWorldEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700ADEB RID: 44523
		// (get) Token: 0x0602750F RID: 161039 RVA: 0x00568DD8 File Offset: 0x00566FD8
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

		// Token: 0x06027510 RID: 161040 RVA: 0x00568E0F File Offset: 0x0056700F
		public Span<byte> GetScreenEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027511 RID: 161041 RVA: 0x00568E1E File Offset: 0x0056701E
		public byte[] GetScreenEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06027512 RID: 161042 RVA: 0x00568E2C File Offset: 0x0056702C
		public static Offset<ITeleportSceneEffect> CreateITeleportSceneEffect(FlatBufferBuilder builder, StringOffset WorldEffectPathOffset = default(StringOffset), StringOffset ScreenEffectPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITeleportSceneEffect.AddScreenEffectPath(builder, ScreenEffectPathOffset);
			ITeleportSceneEffect.AddWorldEffectPath(builder, WorldEffectPathOffset);
			return ITeleportSceneEffect.EndITeleportSceneEffect(builder);
		}

		// Token: 0x06027513 RID: 161043 RVA: 0x00568E49 File Offset: 0x00567049
		public static void StartITeleportSceneEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027514 RID: 161044 RVA: 0x00568E52 File Offset: 0x00567052
		public static void AddWorldEffectPath(FlatBufferBuilder builder, StringOffset worldEffectPathOffset)
		{
			builder.AddOffset(0, worldEffectPathOffset.Value, 0);
		}

		// Token: 0x06027515 RID: 161045 RVA: 0x00568E62 File Offset: 0x00567062
		public static void AddScreenEffectPath(FlatBufferBuilder builder, StringOffset screenEffectPathOffset)
		{
			builder.AddOffset(1, screenEffectPathOffset.Value, 0);
		}

		// Token: 0x06027516 RID: 161046 RVA: 0x00568E72 File Offset: 0x00567072
		public static Offset<ITeleportSceneEffect> EndITeleportSceneEffect(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportSceneEffect>(builder.EndTable());
		}

		// Token: 0x06027517 RID: 161047 RVA: 0x00568E80 File Offset: 0x00567080
		public ITeleportSceneEffectT UnPack()
		{
			ITeleportSceneEffectT teleportSceneEffectT = new ITeleportSceneEffectT();
			this.UnPackTo(teleportSceneEffectT);
			return teleportSceneEffectT;
		}

		// Token: 0x06027518 RID: 161048 RVA: 0x00568E9B File Offset: 0x0056709B
		public void UnPackTo(ITeleportSceneEffectT _o)
		{
			_o.WorldEffectPath = this.WorldEffectPath;
			_o.ScreenEffectPath = this.ScreenEffectPath;
		}

		// Token: 0x06027519 RID: 161049 RVA: 0x00568EB8 File Offset: 0x005670B8
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

		// Token: 0x0400F0D5 RID: 61653
		private Table __p;
	}
}

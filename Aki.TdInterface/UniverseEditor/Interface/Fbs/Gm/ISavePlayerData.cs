using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004687 RID: 18055
	public struct ISavePlayerData : IFlatbufferObject
	{
		// Token: 0x17008030 RID: 32816
		// (get) Token: 0x0601B691 RID: 112273 RVA: 0x003E5115 File Offset: 0x003E3315
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B692 RID: 112274 RVA: 0x003E5122 File Offset: 0x003E3322
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B693 RID: 112275 RVA: 0x003E512C File Offset: 0x003E332C
		public static ISavePlayerData GetRootAsISavePlayerData(ByteBuffer _bb)
		{
			return ISavePlayerData.GetRootAsISavePlayerData(_bb, default(ISavePlayerData));
		}

		// Token: 0x0601B694 RID: 112276 RVA: 0x003E5148 File Offset: 0x003E3348
		public static ISavePlayerData GetRootAsISavePlayerData(ByteBuffer _bb, ISavePlayerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B695 RID: 112277 RVA: 0x003E5165 File Offset: 0x003E3365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B696 RID: 112278 RVA: 0x003E5174 File Offset: 0x003E3374
		public ISavePlayerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008031 RID: 32817
		// (get) Token: 0x0601B697 RID: 112279 RVA: 0x003E5184 File Offset: 0x003E3384
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B698 RID: 112280 RVA: 0x003E51C0 File Offset: 0x003E33C0
		public static Offset<ISavePlayerData> CreateISavePlayerData(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			ISavePlayerData.AddType(builder, Type);
			return ISavePlayerData.EndISavePlayerData(builder);
		}

		// Token: 0x0601B699 RID: 112281 RVA: 0x003E51D6 File Offset: 0x003E33D6
		public static void StartISavePlayerData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B69A RID: 112282 RVA: 0x003E51DF File Offset: 0x003E33DF
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B69B RID: 112283 RVA: 0x003E51EA File Offset: 0x003E33EA
		public static Offset<ISavePlayerData> EndISavePlayerData(FlatBufferBuilder builder)
		{
			return new Offset<ISavePlayerData>(builder.EndTable());
		}

		// Token: 0x0601B69C RID: 112284 RVA: 0x003E51F8 File Offset: 0x003E33F8
		public ISavePlayerDataT UnPack()
		{
			ISavePlayerDataT savePlayerDataT = new ISavePlayerDataT();
			this.UnPackTo(savePlayerDataT);
			return savePlayerDataT;
		}

		// Token: 0x0601B69D RID: 112285 RVA: 0x003E5213 File Offset: 0x003E3413
		public void UnPackTo(ISavePlayerDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B69E RID: 112286 RVA: 0x003E5224 File Offset: 0x003E3424
		public static Offset<ISavePlayerData> Pack(FlatBufferBuilder builder, ISavePlayerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISavePlayerData>);
			}
			return ISavePlayerData.CreateISavePlayerData(builder, _o.Type);
		}

		// Token: 0x0400C848 RID: 51272
		private Table __p;
	}
}

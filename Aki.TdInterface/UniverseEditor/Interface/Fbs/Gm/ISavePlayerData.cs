using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AEF RID: 19183
	public struct ISavePlayerData : IFlatbufferObject
	{
		// Token: 0x17008671 RID: 34417
		// (get) Token: 0x0601CE66 RID: 118374 RVA: 0x004113B1 File Offset: 0x0040F5B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE67 RID: 118375 RVA: 0x004113BE File Offset: 0x0040F5BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE68 RID: 118376 RVA: 0x004113C8 File Offset: 0x0040F5C8
		public static ISavePlayerData GetRootAsISavePlayerData(ByteBuffer _bb)
		{
			return ISavePlayerData.GetRootAsISavePlayerData(_bb, default(ISavePlayerData));
		}

		// Token: 0x0601CE69 RID: 118377 RVA: 0x004113E4 File Offset: 0x0040F5E4
		public static ISavePlayerData GetRootAsISavePlayerData(ByteBuffer _bb, ISavePlayerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE6A RID: 118378 RVA: 0x00411401 File Offset: 0x0040F601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE6B RID: 118379 RVA: 0x00411410 File Offset: 0x0040F610
		public ISavePlayerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008672 RID: 34418
		// (get) Token: 0x0601CE6C RID: 118380 RVA: 0x00411420 File Offset: 0x0040F620
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

		// Token: 0x0601CE6D RID: 118381 RVA: 0x0041145C File Offset: 0x0040F65C
		public static Offset<ISavePlayerData> CreateISavePlayerData(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			ISavePlayerData.AddType(builder, Type);
			return ISavePlayerData.EndISavePlayerData(builder);
		}

		// Token: 0x0601CE6E RID: 118382 RVA: 0x00411472 File Offset: 0x0040F672
		public static void StartISavePlayerData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CE6F RID: 118383 RVA: 0x0041147B File Offset: 0x0040F67B
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CE70 RID: 118384 RVA: 0x00411486 File Offset: 0x0040F686
		public static Offset<ISavePlayerData> EndISavePlayerData(FlatBufferBuilder builder)
		{
			return new Offset<ISavePlayerData>(builder.EndTable());
		}

		// Token: 0x0601CE71 RID: 118385 RVA: 0x00411494 File Offset: 0x0040F694
		public ISavePlayerDataT UnPack()
		{
			ISavePlayerDataT savePlayerDataT = new ISavePlayerDataT();
			this.UnPackTo(savePlayerDataT);
			return savePlayerDataT;
		}

		// Token: 0x0601CE72 RID: 118386 RVA: 0x004114AF File Offset: 0x0040F6AF
		public void UnPackTo(ISavePlayerDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CE73 RID: 118387 RVA: 0x004114C0 File Offset: 0x0040F6C0
		public static Offset<ISavePlayerData> Pack(FlatBufferBuilder builder, ISavePlayerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISavePlayerData>);
			}
			return ISavePlayerData.CreateISavePlayerData(builder, _o.Type);
		}

		// Token: 0x0400D277 RID: 53879
		private Table __p;
	}
}

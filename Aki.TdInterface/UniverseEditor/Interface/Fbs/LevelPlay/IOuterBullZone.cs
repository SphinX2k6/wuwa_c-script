using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200499E RID: 18846
	public struct IOuterBullZone : IFlatbufferObject
	{
		// Token: 0x170083EA RID: 33770
		// (get) Token: 0x0601C224 RID: 115236 RVA: 0x003F9839 File Offset: 0x003F7A39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C225 RID: 115237 RVA: 0x003F9846 File Offset: 0x003F7A46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C226 RID: 115238 RVA: 0x003F9850 File Offset: 0x003F7A50
		public static IOuterBullZone GetRootAsIOuterBullZone(ByteBuffer _bb)
		{
			return IOuterBullZone.GetRootAsIOuterBullZone(_bb, default(IOuterBullZone));
		}

		// Token: 0x0601C227 RID: 115239 RVA: 0x003F986C File Offset: 0x003F7A6C
		public static IOuterBullZone GetRootAsIOuterBullZone(ByteBuffer _bb, IOuterBullZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C228 RID: 115240 RVA: 0x003F9889 File Offset: 0x003F7A89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C229 RID: 115241 RVA: 0x003F9898 File Offset: 0x003F7A98
		public IOuterBullZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083EB RID: 33771
		// (get) Token: 0x0601C22A RID: 115242 RVA: 0x003F98A8 File Offset: 0x003F7AA8
		public EDartboardZoneType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartboardZoneType.CenterBull;
				}
				return (EDartboardZoneType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C22B RID: 115243 RVA: 0x003F98E4 File Offset: 0x003F7AE4
		public static Offset<IOuterBullZone> CreateIOuterBullZone(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull)
		{
			builder.StartTable(1);
			IOuterBullZone.AddType(builder, Type);
			return IOuterBullZone.EndIOuterBullZone(builder);
		}

		// Token: 0x0601C22C RID: 115244 RVA: 0x003F98FA File Offset: 0x003F7AFA
		public static void StartIOuterBullZone(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C22D RID: 115245 RVA: 0x003F9903 File Offset: 0x003F7B03
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C22E RID: 115246 RVA: 0x003F990E File Offset: 0x003F7B0E
		public static Offset<IOuterBullZone> EndIOuterBullZone(FlatBufferBuilder builder)
		{
			return new Offset<IOuterBullZone>(builder.EndTable());
		}

		// Token: 0x0601C22F RID: 115247 RVA: 0x003F991C File Offset: 0x003F7B1C
		public IOuterBullZoneT UnPack()
		{
			IOuterBullZoneT outerBullZoneT = new IOuterBullZoneT();
			this.UnPackTo(outerBullZoneT);
			return outerBullZoneT;
		}

		// Token: 0x0601C230 RID: 115248 RVA: 0x003F9937 File Offset: 0x003F7B37
		public void UnPackTo(IOuterBullZoneT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C231 RID: 115249 RVA: 0x003F9948 File Offset: 0x003F7B48
		public static Offset<IOuterBullZone> Pack(FlatBufferBuilder builder, IOuterBullZoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOuterBullZone>);
			}
			return IOuterBullZone.CreateIOuterBullZone(builder, _o.Type);
		}

		// Token: 0x0400CFE9 RID: 53225
		private Table __p;
	}
}

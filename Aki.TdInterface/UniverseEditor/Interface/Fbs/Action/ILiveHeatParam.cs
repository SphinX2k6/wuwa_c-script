using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F7 RID: 28919
	public struct ILiveHeatParam : IFlatbufferObject
	{
		// Token: 0x1700D3C6 RID: 54214
		// (get) Token: 0x0603238C RID: 205708 RVA: 0x006CAF06 File Offset: 0x006C9106
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603238D RID: 205709 RVA: 0x006CAF13 File Offset: 0x006C9113
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603238E RID: 205710 RVA: 0x006CAF1C File Offset: 0x006C911C
		public static ILiveHeatParam GetRootAsILiveHeatParam(ByteBuffer _bb)
		{
			return ILiveHeatParam.GetRootAsILiveHeatParam(_bb, default(ILiveHeatParam));
		}

		// Token: 0x0603238F RID: 205711 RVA: 0x006CAF38 File Offset: 0x006C9138
		public static ILiveHeatParam GetRootAsILiveHeatParam(ByteBuffer _bb, ILiveHeatParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032390 RID: 205712 RVA: 0x006CAF55 File Offset: 0x006C9155
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032391 RID: 205713 RVA: 0x006CAF64 File Offset: 0x006C9164
		public ILiveHeatParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3C7 RID: 54215
		// (get) Token: 0x06032392 RID: 205714 RVA: 0x006CAF74 File Offset: 0x006C9174
		public ELiveParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveParamType.Heat;
				}
				return (ELiveParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3C8 RID: 54216
		// (get) Token: 0x06032393 RID: 205715 RVA: 0x006CAFB0 File Offset: 0x006C91B0
		public int MinHeat
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3C9 RID: 54217
		// (get) Token: 0x06032394 RID: 205716 RVA: 0x006CAFEC File Offset: 0x006C91EC
		public int MaxHeat
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032395 RID: 205717 RVA: 0x006CB028 File Offset: 0x006C9228
		public static Offset<ILiveHeatParam> CreateILiveHeatParam(FlatBufferBuilder builder, ELiveParamType Type = ELiveParamType.Heat, int MinHeat = 0, int MaxHeat = 0)
		{
			builder.StartTable(3);
			ILiveHeatParam.AddMaxHeat(builder, MaxHeat);
			ILiveHeatParam.AddMinHeat(builder, MinHeat);
			ILiveHeatParam.AddType(builder, Type);
			return ILiveHeatParam.EndILiveHeatParam(builder);
		}

		// Token: 0x06032396 RID: 205718 RVA: 0x006CB04C File Offset: 0x006C924C
		public static void StartILiveHeatParam(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032397 RID: 205719 RVA: 0x006CB055 File Offset: 0x006C9255
		public static void AddType(FlatBufferBuilder builder, ELiveParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032398 RID: 205720 RVA: 0x006CB060 File Offset: 0x006C9260
		public static void AddMinHeat(FlatBufferBuilder builder, int minHeat)
		{
			builder.AddInt(1, minHeat, 0);
		}

		// Token: 0x06032399 RID: 205721 RVA: 0x006CB06B File Offset: 0x006C926B
		public static void AddMaxHeat(FlatBufferBuilder builder, int maxHeat)
		{
			builder.AddInt(2, maxHeat, 0);
		}

		// Token: 0x0603239A RID: 205722 RVA: 0x006CB076 File Offset: 0x006C9276
		public static Offset<ILiveHeatParam> EndILiveHeatParam(FlatBufferBuilder builder)
		{
			return new Offset<ILiveHeatParam>(builder.EndTable());
		}

		// Token: 0x0603239B RID: 205723 RVA: 0x006CB084 File Offset: 0x006C9284
		public ILiveHeatParamT UnPack()
		{
			ILiveHeatParamT liveHeatParamT = new ILiveHeatParamT();
			this.UnPackTo(liveHeatParamT);
			return liveHeatParamT;
		}

		// Token: 0x0603239C RID: 205724 RVA: 0x006CB09F File Offset: 0x006C929F
		public void UnPackTo(ILiveHeatParamT _o)
		{
			_o.Type = this.Type;
			_o.MinHeat = this.MinHeat;
			_o.MaxHeat = this.MaxHeat;
		}

		// Token: 0x0603239D RID: 205725 RVA: 0x006CB0C8 File Offset: 0x006C92C8
		public static Offset<ILiveHeatParam> Pack(FlatBufferBuilder builder, ILiveHeatParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveHeatParam>);
			}
			return ILiveHeatParam.CreateILiveHeatParam(builder, _o.Type, _o.MinHeat, _o.MaxHeat);
		}

		// Token: 0x040120C7 RID: 73927
		private Table __p;
	}
}

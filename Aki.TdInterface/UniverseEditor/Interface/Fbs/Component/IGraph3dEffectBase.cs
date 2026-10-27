using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200530F RID: 21263
	public struct IGraph3dEffectBase : IFlatbufferObject
	{
		// Token: 0x17009C23 RID: 39971
		// (get) Token: 0x06022BC6 RID: 142278 RVA: 0x004D0210 File Offset: 0x004CE410
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022BC7 RID: 142279 RVA: 0x004D021D File Offset: 0x004CE41D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022BC8 RID: 142280 RVA: 0x004D0224 File Offset: 0x004CE424
		public static IGraph3dEffectBase GetRootAsIGraph3dEffectBase(ByteBuffer _bb)
		{
			return IGraph3dEffectBase.GetRootAsIGraph3dEffectBase(_bb, default(IGraph3dEffectBase));
		}

		// Token: 0x06022BC9 RID: 142281 RVA: 0x004D0240 File Offset: 0x004CE440
		public static IGraph3dEffectBase GetRootAsIGraph3dEffectBase(ByteBuffer _bb, IGraph3dEffectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022BCA RID: 142282 RVA: 0x004D025D File Offset: 0x004CE45D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022BCB RID: 142283 RVA: 0x004D026C File Offset: 0x004CE46C
		public IGraph3dEffectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C24 RID: 39972
		// (get) Token: 0x06022BCC RID: 142284 RVA: 0x004D027C File Offset: 0x004CE47C
		public EGraph3dEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGraph3dEffectType.FireBoxFish;
				}
				return (EGraph3dEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022BCD RID: 142285 RVA: 0x004D02B8 File Offset: 0x004CE4B8
		public static Offset<IGraph3dEffectBase> CreateIGraph3dEffectBase(FlatBufferBuilder builder, EGraph3dEffectType Type = EGraph3dEffectType.FireBoxFish)
		{
			builder.StartTable(1);
			IGraph3dEffectBase.AddType(builder, Type);
			return IGraph3dEffectBase.EndIGraph3dEffectBase(builder);
		}

		// Token: 0x06022BCE RID: 142286 RVA: 0x004D02CE File Offset: 0x004CE4CE
		public static void StartIGraph3dEffectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022BCF RID: 142287 RVA: 0x004D02D7 File Offset: 0x004CE4D7
		public static void AddType(FlatBufferBuilder builder, EGraph3dEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022BD0 RID: 142288 RVA: 0x004D02E2 File Offset: 0x004CE4E2
		public static Offset<IGraph3dEffectBase> EndIGraph3dEffectBase(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dEffectBase>(builder.EndTable());
		}

		// Token: 0x06022BD1 RID: 142289 RVA: 0x004D02F0 File Offset: 0x004CE4F0
		public IGraph3dEffectBaseT UnPack()
		{
			IGraph3dEffectBaseT graph3dEffectBaseT = new IGraph3dEffectBaseT();
			this.UnPackTo(graph3dEffectBaseT);
			return graph3dEffectBaseT;
		}

		// Token: 0x06022BD2 RID: 142290 RVA: 0x004D030B File Offset: 0x004CE50B
		public void UnPackTo(IGraph3dEffectBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022BD3 RID: 142291 RVA: 0x004D031C File Offset: 0x004CE51C
		public static Offset<IGraph3dEffectBase> Pack(FlatBufferBuilder builder, IGraph3dEffectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dEffectBase>);
			}
			return IGraph3dEffectBase.CreateIGraph3dEffectBase(builder, _o.Type);
		}

		// Token: 0x0400E4C4 RID: 58564
		private Table __p;
	}
}

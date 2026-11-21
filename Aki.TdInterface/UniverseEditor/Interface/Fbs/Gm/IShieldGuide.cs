using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B01 RID: 19201
	public struct IShieldGuide : IFlatbufferObject
	{
		// Token: 0x17008697 RID: 34455
		// (get) Token: 0x0601CEFE RID: 118526 RVA: 0x00412278 File Offset: 0x00410478
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CEFF RID: 118527 RVA: 0x00412285 File Offset: 0x00410485
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CF00 RID: 118528 RVA: 0x0041228C File Offset: 0x0041048C
		public static IShieldGuide GetRootAsIShieldGuide(ByteBuffer _bb)
		{
			return IShieldGuide.GetRootAsIShieldGuide(_bb, default(IShieldGuide));
		}

		// Token: 0x0601CF01 RID: 118529 RVA: 0x004122A8 File Offset: 0x004104A8
		public static IShieldGuide GetRootAsIShieldGuide(ByteBuffer _bb, IShieldGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CF02 RID: 118530 RVA: 0x004122C5 File Offset: 0x004104C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CF03 RID: 118531 RVA: 0x004122D4 File Offset: 0x004104D4
		public IShieldGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008698 RID: 34456
		// (get) Token: 0x0601CF04 RID: 118532 RVA: 0x004122E4 File Offset: 0x004104E4
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

		// Token: 0x17008699 RID: 34457
		// (get) Token: 0x0601CF05 RID: 118533 RVA: 0x00412320 File Offset: 0x00410520
		public bool IsShield
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CF06 RID: 118534 RVA: 0x0041235F File Offset: 0x0041055F
		public static Offset<IShieldGuide> CreateIShieldGuide(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, bool IsShield = false)
		{
			builder.StartTable(2);
			IShieldGuide.AddIsShield(builder, IsShield);
			IShieldGuide.AddType(builder, Type);
			return IShieldGuide.EndIShieldGuide(builder);
		}

		// Token: 0x0601CF07 RID: 118535 RVA: 0x0041237C File Offset: 0x0041057C
		public static void StartIShieldGuide(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CF08 RID: 118536 RVA: 0x00412385 File Offset: 0x00410585
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CF09 RID: 118537 RVA: 0x00412390 File Offset: 0x00410590
		public static void AddIsShield(FlatBufferBuilder builder, bool isShield)
		{
			builder.AddBool(1, isShield, false);
		}

		// Token: 0x0601CF0A RID: 118538 RVA: 0x0041239B File Offset: 0x0041059B
		public static Offset<IShieldGuide> EndIShieldGuide(FlatBufferBuilder builder)
		{
			return new Offset<IShieldGuide>(builder.EndTable());
		}

		// Token: 0x0601CF0B RID: 118539 RVA: 0x004123A8 File Offset: 0x004105A8
		public IShieldGuideT UnPack()
		{
			IShieldGuideT shieldGuideT = new IShieldGuideT();
			this.UnPackTo(shieldGuideT);
			return shieldGuideT;
		}

		// Token: 0x0601CF0C RID: 118540 RVA: 0x004123C3 File Offset: 0x004105C3
		public void UnPackTo(IShieldGuideT _o)
		{
			_o.Type = this.Type;
			_o.IsShield = this.IsShield;
		}

		// Token: 0x0601CF0D RID: 118541 RVA: 0x004123E0 File Offset: 0x004105E0
		public static Offset<IShieldGuide> Pack(FlatBufferBuilder builder, IShieldGuideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShieldGuide>);
			}
			return IShieldGuide.CreateIShieldGuide(builder, _o.Type, _o.IsShield);
		}

		// Token: 0x0400D28D RID: 53901
		private Table __p;
	}
}

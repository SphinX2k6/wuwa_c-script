using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004699 RID: 18073
	public struct IShieldGuide : IFlatbufferObject
	{
		// Token: 0x17008056 RID: 32854
		// (get) Token: 0x0601B729 RID: 112425 RVA: 0x003E5FDC File Offset: 0x003E41DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B72A RID: 112426 RVA: 0x003E5FE9 File Offset: 0x003E41E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B72B RID: 112427 RVA: 0x003E5FF0 File Offset: 0x003E41F0
		public static IShieldGuide GetRootAsIShieldGuide(ByteBuffer _bb)
		{
			return IShieldGuide.GetRootAsIShieldGuide(_bb, default(IShieldGuide));
		}

		// Token: 0x0601B72C RID: 112428 RVA: 0x003E600C File Offset: 0x003E420C
		public static IShieldGuide GetRootAsIShieldGuide(ByteBuffer _bb, IShieldGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B72D RID: 112429 RVA: 0x003E6029 File Offset: 0x003E4229
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B72E RID: 112430 RVA: 0x003E6038 File Offset: 0x003E4238
		public IShieldGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008057 RID: 32855
		// (get) Token: 0x0601B72F RID: 112431 RVA: 0x003E6048 File Offset: 0x003E4248
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

		// Token: 0x17008058 RID: 32856
		// (get) Token: 0x0601B730 RID: 112432 RVA: 0x003E6084 File Offset: 0x003E4284
		public bool IsShield
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B731 RID: 112433 RVA: 0x003E60C3 File Offset: 0x003E42C3
		public static Offset<IShieldGuide> CreateIShieldGuide(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, bool IsShield = false)
		{
			builder.StartTable(2);
			IShieldGuide.AddIsShield(builder, IsShield);
			IShieldGuide.AddType(builder, Type);
			return IShieldGuide.EndIShieldGuide(builder);
		}

		// Token: 0x0601B732 RID: 112434 RVA: 0x003E60E0 File Offset: 0x003E42E0
		public static void StartIShieldGuide(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B733 RID: 112435 RVA: 0x003E60E9 File Offset: 0x003E42E9
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B734 RID: 112436 RVA: 0x003E60F4 File Offset: 0x003E42F4
		public static void AddIsShield(FlatBufferBuilder builder, bool isShield)
		{
			builder.AddBool(1, isShield, false);
		}

		// Token: 0x0601B735 RID: 112437 RVA: 0x003E60FF File Offset: 0x003E42FF
		public static Offset<IShieldGuide> EndIShieldGuide(FlatBufferBuilder builder)
		{
			return new Offset<IShieldGuide>(builder.EndTable());
		}

		// Token: 0x0601B736 RID: 112438 RVA: 0x003E610C File Offset: 0x003E430C
		public IShieldGuideT UnPack()
		{
			IShieldGuideT shieldGuideT = new IShieldGuideT();
			this.UnPackTo(shieldGuideT);
			return shieldGuideT;
		}

		// Token: 0x0601B737 RID: 112439 RVA: 0x003E6127 File Offset: 0x003E4327
		public void UnPackTo(IShieldGuideT _o)
		{
			_o.Type = this.Type;
			_o.IsShield = this.IsShield;
		}

		// Token: 0x0601B738 RID: 112440 RVA: 0x003E6144 File Offset: 0x003E4344
		public static Offset<IShieldGuide> Pack(FlatBufferBuilder builder, IShieldGuideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShieldGuide>);
			}
			return IShieldGuide.CreateIShieldGuide(builder, _o.Type, _o.IsShield);
		}

		// Token: 0x0400C85E RID: 51294
		private Table __p;
	}
}

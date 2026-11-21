using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B9A RID: 23450
	public struct INoiseRemovalBoarderBase : IFlatbufferObject
	{
		// Token: 0x1700AB6A RID: 43882
		// (get) Token: 0x06026A6F RID: 158319 RVA: 0x0054AC40 File Offset: 0x00548E40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026A70 RID: 158320 RVA: 0x0054AC4D File Offset: 0x00548E4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026A71 RID: 158321 RVA: 0x0054AC54 File Offset: 0x00548E54
		public static INoiseRemovalBoarderBase GetRootAsINoiseRemovalBoarderBase(ByteBuffer _bb)
		{
			return INoiseRemovalBoarderBase.GetRootAsINoiseRemovalBoarderBase(_bb, default(INoiseRemovalBoarderBase));
		}

		// Token: 0x06026A72 RID: 158322 RVA: 0x0054AC70 File Offset: 0x00548E70
		public static INoiseRemovalBoarderBase GetRootAsINoiseRemovalBoarderBase(ByteBuffer _bb, INoiseRemovalBoarderBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026A73 RID: 158323 RVA: 0x0054AC8D File Offset: 0x00548E8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026A74 RID: 158324 RVA: 0x0054AC9C File Offset: 0x00548E9C
		public INoiseRemovalBoarderBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB6B RID: 43883
		// (get) Token: 0x06026A75 RID: 158325 RVA: 0x0054ACAC File Offset: 0x00548EAC
		public ENoiseRemovalBoarderShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENoiseRemovalBoarderShape.Box;
				}
				return (ENoiseRemovalBoarderShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026A76 RID: 158326 RVA: 0x0054ACE8 File Offset: 0x00548EE8
		public static Offset<INoiseRemovalBoarderBase> CreateINoiseRemovalBoarderBase(FlatBufferBuilder builder, ENoiseRemovalBoarderShape Type = ENoiseRemovalBoarderShape.Box)
		{
			builder.StartTable(1);
			INoiseRemovalBoarderBase.AddType(builder, Type);
			return INoiseRemovalBoarderBase.EndINoiseRemovalBoarderBase(builder);
		}

		// Token: 0x06026A77 RID: 158327 RVA: 0x0054ACFE File Offset: 0x00548EFE
		public static void StartINoiseRemovalBoarderBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026A78 RID: 158328 RVA: 0x0054AD07 File Offset: 0x00548F07
		public static void AddType(FlatBufferBuilder builder, ENoiseRemovalBoarderShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026A79 RID: 158329 RVA: 0x0054AD12 File Offset: 0x00548F12
		public static Offset<INoiseRemovalBoarderBase> EndINoiseRemovalBoarderBase(FlatBufferBuilder builder)
		{
			return new Offset<INoiseRemovalBoarderBase>(builder.EndTable());
		}

		// Token: 0x06026A7A RID: 158330 RVA: 0x0054AD20 File Offset: 0x00548F20
		public INoiseRemovalBoarderBaseT UnPack()
		{
			INoiseRemovalBoarderBaseT noiseRemovalBoarderBaseT = new INoiseRemovalBoarderBaseT();
			this.UnPackTo(noiseRemovalBoarderBaseT);
			return noiseRemovalBoarderBaseT;
		}

		// Token: 0x06026A7B RID: 158331 RVA: 0x0054AD3B File Offset: 0x00548F3B
		public void UnPackTo(INoiseRemovalBoarderBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026A7C RID: 158332 RVA: 0x0054AD4C File Offset: 0x00548F4C
		public static Offset<INoiseRemovalBoarderBase> Pack(FlatBufferBuilder builder, INoiseRemovalBoarderBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoiseRemovalBoarderBase>);
			}
			return INoiseRemovalBoarderBase.CreateINoiseRemovalBoarderBase(builder, _o.Type);
		}

		// Token: 0x0400F5D7 RID: 62935
		private Table __p;
	}
}

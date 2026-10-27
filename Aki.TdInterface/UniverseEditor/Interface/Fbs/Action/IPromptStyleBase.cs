using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC5 RID: 28101
	public struct IPromptStyleBase : IFlatbufferObject
	{
		// Token: 0x1700D18C RID: 53644
		// (get) Token: 0x06031A39 RID: 203321 RVA: 0x006B99DC File Offset: 0x006B7BDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A3A RID: 203322 RVA: 0x006B99E9 File Offset: 0x006B7BE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A3B RID: 203323 RVA: 0x006B99F0 File Offset: 0x006B7BF0
		public static IPromptStyleBase GetRootAsIPromptStyleBase(ByteBuffer _bb)
		{
			return IPromptStyleBase.GetRootAsIPromptStyleBase(_bb, default(IPromptStyleBase));
		}

		// Token: 0x06031A3C RID: 203324 RVA: 0x006B9A0C File Offset: 0x006B7C0C
		public static IPromptStyleBase GetRootAsIPromptStyleBase(ByteBuffer _bb, IPromptStyleBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A3D RID: 203325 RVA: 0x006B9A29 File Offset: 0x006B7C29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A3E RID: 203326 RVA: 0x006B9A38 File Offset: 0x006B7C38
		public IPromptStyleBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D18D RID: 53645
		// (get) Token: 0x06031A3F RID: 203327 RVA: 0x006B9A48 File Offset: 0x006B7C48
		public EPromptStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPromptStyle.Default;
				}
				return (EPromptStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031A40 RID: 203328 RVA: 0x006B9A84 File Offset: 0x006B7C84
		public static Offset<IPromptStyleBase> CreateIPromptStyleBase(FlatBufferBuilder builder, EPromptStyle Type = EPromptStyle.Default)
		{
			builder.StartTable(1);
			IPromptStyleBase.AddType(builder, Type);
			return IPromptStyleBase.EndIPromptStyleBase(builder);
		}

		// Token: 0x06031A41 RID: 203329 RVA: 0x006B9A9A File Offset: 0x006B7C9A
		public static void StartIPromptStyleBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031A42 RID: 203330 RVA: 0x006B9AA3 File Offset: 0x006B7CA3
		public static void AddType(FlatBufferBuilder builder, EPromptStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031A43 RID: 203331 RVA: 0x006B9AAE File Offset: 0x006B7CAE
		public static Offset<IPromptStyleBase> EndIPromptStyleBase(FlatBufferBuilder builder)
		{
			return new Offset<IPromptStyleBase>(builder.EndTable());
		}

		// Token: 0x06031A44 RID: 203332 RVA: 0x006B9ABC File Offset: 0x006B7CBC
		public IPromptStyleBaseT UnPack()
		{
			IPromptStyleBaseT promptStyleBaseT = new IPromptStyleBaseT();
			this.UnPackTo(promptStyleBaseT);
			return promptStyleBaseT;
		}

		// Token: 0x06031A45 RID: 203333 RVA: 0x006B9AD7 File Offset: 0x006B7CD7
		public void UnPackTo(IPromptStyleBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031A46 RID: 203334 RVA: 0x006B9AE8 File Offset: 0x006B7CE8
		public static Offset<IPromptStyleBase> Pack(FlatBufferBuilder builder, IPromptStyleBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptStyleBase>);
			}
			return IPromptStyleBase.CreateIPromptStyleBase(builder, _o.Type);
		}

		// Token: 0x040117A3 RID: 71587
		private Table __p;
	}
}

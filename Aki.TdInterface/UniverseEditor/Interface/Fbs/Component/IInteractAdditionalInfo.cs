using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B7 RID: 22967
	public struct IInteractAdditionalInfo : IFlatbufferObject
	{
		// Token: 0x1700A6BE RID: 42686
		// (get) Token: 0x06025737 RID: 153399 RVA: 0x00523084 File Offset: 0x00521284
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025738 RID: 153400 RVA: 0x00523091 File Offset: 0x00521291
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025739 RID: 153401 RVA: 0x00523098 File Offset: 0x00521298
		public static IInteractAdditionalInfo GetRootAsIInteractAdditionalInfo(ByteBuffer _bb)
		{
			return IInteractAdditionalInfo.GetRootAsIInteractAdditionalInfo(_bb, default(IInteractAdditionalInfo));
		}

		// Token: 0x0602573A RID: 153402 RVA: 0x005230B4 File Offset: 0x005212B4
		public static IInteractAdditionalInfo GetRootAsIInteractAdditionalInfo(ByteBuffer _bb, IInteractAdditionalInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602573B RID: 153403 RVA: 0x005230D1 File Offset: 0x005212D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602573C RID: 153404 RVA: 0x005230E0 File Offset: 0x005212E0
		public IInteractAdditionalInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6BF RID: 42687
		// (get) Token: 0x0602573D RID: 153405 RVA: 0x005230F0 File Offset: 0x005212F0
		public EInteractAdditionalInfoType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractAdditionalInfoType.FishingPoint;
				}
				return (EInteractAdditionalInfoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602573E RID: 153406 RVA: 0x0052312C File Offset: 0x0052132C
		public static Offset<IInteractAdditionalInfo> CreateIInteractAdditionalInfo(FlatBufferBuilder builder, EInteractAdditionalInfoType Type = EInteractAdditionalInfoType.FishingPoint)
		{
			builder.StartTable(1);
			IInteractAdditionalInfo.AddType(builder, Type);
			return IInteractAdditionalInfo.EndIInteractAdditionalInfo(builder);
		}

		// Token: 0x0602573F RID: 153407 RVA: 0x00523142 File Offset: 0x00521342
		public static void StartIInteractAdditionalInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025740 RID: 153408 RVA: 0x0052314B File Offset: 0x0052134B
		public static void AddType(FlatBufferBuilder builder, EInteractAdditionalInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025741 RID: 153409 RVA: 0x00523156 File Offset: 0x00521356
		public static Offset<IInteractAdditionalInfo> EndIInteractAdditionalInfo(FlatBufferBuilder builder)
		{
			return new Offset<IInteractAdditionalInfo>(builder.EndTable());
		}

		// Token: 0x06025742 RID: 153410 RVA: 0x00523164 File Offset: 0x00521364
		public IInteractAdditionalInfoT UnPack()
		{
			IInteractAdditionalInfoT interactAdditionalInfoT = new IInteractAdditionalInfoT();
			this.UnPackTo(interactAdditionalInfoT);
			return interactAdditionalInfoT;
		}

		// Token: 0x06025743 RID: 153411 RVA: 0x0052317F File Offset: 0x0052137F
		public void UnPackTo(IInteractAdditionalInfoT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025744 RID: 153412 RVA: 0x00523190 File Offset: 0x00521390
		public static Offset<IInteractAdditionalInfo> Pack(FlatBufferBuilder builder, IInteractAdditionalInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractAdditionalInfo>);
			}
			return IInteractAdditionalInfo.CreateIInteractAdditionalInfo(builder, _o.Type);
		}

		// Token: 0x0400F2B5 RID: 62133
		private Table __p;
	}
}

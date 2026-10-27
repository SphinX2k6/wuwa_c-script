using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC4 RID: 28356
	public struct IResumeSystemRewardPopup : IFlatbufferObject
	{
		// Token: 0x1700D30A RID: 54026
		// (get) Token: 0x060321D5 RID: 205269 RVA: 0x006C674D File Offset: 0x006C494D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060321D6 RID: 205270 RVA: 0x006C675A File Offset: 0x006C495A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060321D7 RID: 205271 RVA: 0x006C6764 File Offset: 0x006C4964
		public static IResumeSystemRewardPopup GetRootAsIResumeSystemRewardPopup(ByteBuffer _bb)
		{
			return IResumeSystemRewardPopup.GetRootAsIResumeSystemRewardPopup(_bb, default(IResumeSystemRewardPopup));
		}

		// Token: 0x060321D8 RID: 205272 RVA: 0x006C6780 File Offset: 0x006C4980
		public static IResumeSystemRewardPopup GetRootAsIResumeSystemRewardPopup(ByteBuffer _bb, IResumeSystemRewardPopup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060321D9 RID: 205273 RVA: 0x006C679D File Offset: 0x006C499D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060321DA RID: 205274 RVA: 0x006C67AC File Offset: 0x006C49AC
		public IResumeSystemRewardPopup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D30B RID: 54027
		// (get) Token: 0x060321DB RID: 205275 RVA: 0x006C67BC File Offset: 0x006C49BC
		public IResumeGiantDeliveryRewardPopup? SystemType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IResumeGiantDeliveryRewardPopup?(default(IResumeGiantDeliveryRewardPopup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060321DC RID: 205276 RVA: 0x006C6819 File Offset: 0x006C4A19
		public static Offset<IResumeSystemRewardPopup> CreateIResumeSystemRewardPopup(FlatBufferBuilder builder, Offset<IResumeGiantDeliveryRewardPopup> SystemTypeOffset = default(Offset<IResumeGiantDeliveryRewardPopup>))
		{
			builder.StartTable(1);
			IResumeSystemRewardPopup.AddSystemType(builder, SystemTypeOffset);
			return IResumeSystemRewardPopup.EndIResumeSystemRewardPopup(builder);
		}

		// Token: 0x060321DD RID: 205277 RVA: 0x006C682F File Offset: 0x006C4A2F
		public static void StartIResumeSystemRewardPopup(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060321DE RID: 205278 RVA: 0x006C6838 File Offset: 0x006C4A38
		public static void AddSystemType(FlatBufferBuilder builder, Offset<IResumeGiantDeliveryRewardPopup> systemTypeOffset)
		{
			builder.AddOffset(0, systemTypeOffset.Value, 0);
		}

		// Token: 0x060321DF RID: 205279 RVA: 0x006C6848 File Offset: 0x006C4A48
		public static Offset<IResumeSystemRewardPopup> EndIResumeSystemRewardPopup(FlatBufferBuilder builder)
		{
			return new Offset<IResumeSystemRewardPopup>(builder.EndTable());
		}

		// Token: 0x060321E0 RID: 205280 RVA: 0x006C6858 File Offset: 0x006C4A58
		public IResumeSystemRewardPopupT UnPack()
		{
			IResumeSystemRewardPopupT resumeSystemRewardPopupT = new IResumeSystemRewardPopupT();
			this.UnPackTo(resumeSystemRewardPopupT);
			return resumeSystemRewardPopupT;
		}

		// Token: 0x060321E1 RID: 205281 RVA: 0x006C6874 File Offset: 0x006C4A74
		public void UnPackTo(IResumeSystemRewardPopupT _o)
		{
			_o.SystemType = ((this.SystemType != null) ? this.SystemType.Value.UnPack() : null);
		}

		// Token: 0x060321E2 RID: 205282 RVA: 0x006C68B0 File Offset: 0x006C4AB0
		public static Offset<IResumeSystemRewardPopup> Pack(FlatBufferBuilder builder, IResumeSystemRewardPopupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResumeSystemRewardPopup>);
			}
			Offset<IResumeGiantDeliveryRewardPopup> systemTypeOffset = (_o.SystemType == null) ? default(Offset<IResumeGiantDeliveryRewardPopup>) : IResumeGiantDeliveryRewardPopup.Pack(builder, _o.SystemType);
			return IResumeSystemRewardPopup.CreateIResumeSystemRewardPopup(builder, systemTypeOffset);
		}

		// Token: 0x040118B5 RID: 71861
		private Table __p;
	}
}

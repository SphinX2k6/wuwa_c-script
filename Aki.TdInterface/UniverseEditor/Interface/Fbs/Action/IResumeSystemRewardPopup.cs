using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007648 RID: 30280
	public struct IResumeSystemRewardPopup : IFlatbufferObject
	{
		// Token: 0x1700DE61 RID: 56929
		// (get) Token: 0x06035215 RID: 217621 RVA: 0x00722481 File Offset: 0x00720681
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035216 RID: 217622 RVA: 0x0072248E File Offset: 0x0072068E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035217 RID: 217623 RVA: 0x00722498 File Offset: 0x00720698
		public static IResumeSystemRewardPopup GetRootAsIResumeSystemRewardPopup(ByteBuffer _bb)
		{
			return IResumeSystemRewardPopup.GetRootAsIResumeSystemRewardPopup(_bb, default(IResumeSystemRewardPopup));
		}

		// Token: 0x06035218 RID: 217624 RVA: 0x007224B4 File Offset: 0x007206B4
		public static IResumeSystemRewardPopup GetRootAsIResumeSystemRewardPopup(ByteBuffer _bb, IResumeSystemRewardPopup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035219 RID: 217625 RVA: 0x007224D1 File Offset: 0x007206D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603521A RID: 217626 RVA: 0x007224E0 File Offset: 0x007206E0
		public IResumeSystemRewardPopup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE62 RID: 56930
		// (get) Token: 0x0603521B RID: 217627 RVA: 0x007224F0 File Offset: 0x007206F0
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

		// Token: 0x0603521C RID: 217628 RVA: 0x0072254D File Offset: 0x0072074D
		public static Offset<IResumeSystemRewardPopup> CreateIResumeSystemRewardPopup(FlatBufferBuilder builder, Offset<IResumeGiantDeliveryRewardPopup> SystemTypeOffset = default(Offset<IResumeGiantDeliveryRewardPopup>))
		{
			builder.StartTable(1);
			IResumeSystemRewardPopup.AddSystemType(builder, SystemTypeOffset);
			return IResumeSystemRewardPopup.EndIResumeSystemRewardPopup(builder);
		}

		// Token: 0x0603521D RID: 217629 RVA: 0x00722563 File Offset: 0x00720763
		public static void StartIResumeSystemRewardPopup(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603521E RID: 217630 RVA: 0x0072256C File Offset: 0x0072076C
		public static void AddSystemType(FlatBufferBuilder builder, Offset<IResumeGiantDeliveryRewardPopup> systemTypeOffset)
		{
			builder.AddOffset(0, systemTypeOffset.Value, 0);
		}

		// Token: 0x0603521F RID: 217631 RVA: 0x0072257C File Offset: 0x0072077C
		public static Offset<IResumeSystemRewardPopup> EndIResumeSystemRewardPopup(FlatBufferBuilder builder)
		{
			return new Offset<IResumeSystemRewardPopup>(builder.EndTable());
		}

		// Token: 0x06035220 RID: 217632 RVA: 0x0072258C File Offset: 0x0072078C
		public IResumeSystemRewardPopupT UnPack()
		{
			IResumeSystemRewardPopupT resumeSystemRewardPopupT = new IResumeSystemRewardPopupT();
			this.UnPackTo(resumeSystemRewardPopupT);
			return resumeSystemRewardPopupT;
		}

		// Token: 0x06035221 RID: 217633 RVA: 0x007225A8 File Offset: 0x007207A8
		public void UnPackTo(IResumeSystemRewardPopupT _o)
		{
			_o.SystemType = ((this.SystemType != null) ? this.SystemType.Value.UnPack() : null);
		}

		// Token: 0x06035222 RID: 217634 RVA: 0x007225E4 File Offset: 0x007207E4
		public static Offset<IResumeSystemRewardPopup> Pack(FlatBufferBuilder builder, IResumeSystemRewardPopupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResumeSystemRewardPopup>);
			}
			Offset<IResumeGiantDeliveryRewardPopup> systemTypeOffset = (_o.SystemType == null) ? default(Offset<IResumeGiantDeliveryRewardPopup>) : IResumeGiantDeliveryRewardPopup.Pack(builder, _o.SystemType);
			return IResumeSystemRewardPopup.CreateIResumeSystemRewardPopup(builder, systemTypeOffset);
		}

		// Token: 0x0401283A RID: 75834
		private Table __p;
	}
}

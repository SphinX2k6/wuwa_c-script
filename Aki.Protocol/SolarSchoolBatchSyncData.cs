using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A3 RID: 4771
	public sealed class SolarSchoolBatchSyncData : IMessage<SolarSchoolBatchSyncData>, IMessage, IEquatable<SolarSchoolBatchSyncData>, IDeepCloneable<SolarSchoolBatchSyncData>, IBufferMessage
	{
		// Token: 0x0601976A RID: 104298 RVA: 0x003B6A20 File Offset: 0x003B4C20
		[NullableContext(1)]
		public static SolarSchoolBatchSyncData Create()
		{
			return new SolarSchoolBatchSyncData();
		}

		// Token: 0x17005625 RID: 22053
		// (get) Token: 0x0601976B RID: 104299 RVA: 0x003B6A27 File Offset: 0x003B4C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolBatchSyncData> Parser
		{
			get
			{
				return SolarSchoolBatchSyncData._parser;
			}
		}

		// Token: 0x17005626 RID: 22054
		// (get) Token: 0x0601976C RID: 104300 RVA: 0x003B6A2E File Offset: 0x003B4C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005627 RID: 22055
		// (get) Token: 0x0601976D RID: 104301 RVA: 0x003B6A31 File Offset: 0x003B4C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolBatchSyncData.Descriptor;
			}
		}

		// Token: 0x0601976E RID: 104302 RVA: 0x003B6A38 File Offset: 0x003B4C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBatchSyncData()
		{
		}

		// Token: 0x0601976F RID: 104303 RVA: 0x003B6A40 File Offset: 0x003B4C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBatchSyncData(SolarSchoolBatchSyncData other) : this()
		{
			switch (other.DataCase)
			{
			case SolarSchoolBatchSyncData.DataOneofCase.AttrChange:
				this.AttrChange = other.AttrChange.Clone();
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.UnlockNpc:
				this.UnlockNpc = other.UnlockNpc.Clone();
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.NpcFavorChange:
				this.NpcFavorChange = other.NpcFavorChange.Clone();
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.JoinInfluence:
				this.JoinInfluence = other.JoinInfluence.Clone();
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.Behave:
				this.Behave = other.Behave.Clone();
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.ItemChange:
				this.ItemChange = other.ItemChange.Clone();
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.ExamFinish:
				this.ExamFinish = other.ExamFinish.Clone();
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.ShopBuy:
				this.ShopBuy = other.ShopBuy.Clone();
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.CompleteQuest:
				this.CompleteQuest = other.CompleteQuest.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019770 RID: 104304 RVA: 0x003B6B5B File Offset: 0x003B4D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBatchSyncData Clone()
		{
			return new SolarSchoolBatchSyncData(this);
		}

		// Token: 0x17005628 RID: 22056
		// (get) Token: 0x06019771 RID: 104305 RVA: 0x003B6B63 File Offset: 0x003B4D63
		// (set) Token: 0x06019772 RID: 104306 RVA: 0x003B6B7B File Offset: 0x003B4D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttrChangeSyncDataPb AttrChange
		{
			get
			{
				if (this.dataCase_ != SolarSchoolBatchSyncData.DataOneofCase.AttrChange)
				{
					return null;
				}
				return (AttrChangeSyncDataPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SolarSchoolBatchSyncData.DataOneofCase.None : SolarSchoolBatchSyncData.DataOneofCase.AttrChange);
			}
		}

		// Token: 0x17005629 RID: 22057
		// (get) Token: 0x06019773 RID: 104307 RVA: 0x003B6B91 File Offset: 0x003B4D91
		// (set) Token: 0x06019774 RID: 104308 RVA: 0x003B6BA9 File Offset: 0x003B4DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockNpcSyncDataPb UnlockNpc
		{
			get
			{
				if (this.dataCase_ != SolarSchoolBatchSyncData.DataOneofCase.UnlockNpc)
				{
					return null;
				}
				return (UnlockNpcSyncDataPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SolarSchoolBatchSyncData.DataOneofCase.None : SolarSchoolBatchSyncData.DataOneofCase.UnlockNpc);
			}
		}

		// Token: 0x1700562A RID: 22058
		// (get) Token: 0x06019775 RID: 104309 RVA: 0x003B6BBF File Offset: 0x003B4DBF
		// (set) Token: 0x06019776 RID: 104310 RVA: 0x003B6BD7 File Offset: 0x003B4DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcFavorChangeSyncDataPb NpcFavorChange
		{
			get
			{
				if (this.dataCase_ != SolarSchoolBatchSyncData.DataOneofCase.NpcFavorChange)
				{
					return null;
				}
				return (NpcFavorChangeSyncDataPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SolarSchoolBatchSyncData.DataOneofCase.None : SolarSchoolBatchSyncData.DataOneofCase.NpcFavorChange);
			}
		}

		// Token: 0x1700562B RID: 22059
		// (get) Token: 0x06019777 RID: 104311 RVA: 0x003B6BED File Offset: 0x003B4DED
		// (set) Token: 0x06019778 RID: 104312 RVA: 0x003B6C05 File Offset: 0x003B4E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinInfluenceSyncDataPb JoinInfluence
		{
			get
			{
				if (this.dataCase_ != SolarSchoolBatchSyncData.DataOneofCase.JoinInfluence)
				{
					return null;
				}
				return (JoinInfluenceSyncDataPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SolarSchoolBatchSyncData.DataOneofCase.None : SolarSchoolBatchSyncData.DataOneofCase.JoinInfluence);
			}
		}

		// Token: 0x1700562C RID: 22060
		// (get) Token: 0x06019779 RID: 104313 RVA: 0x003B6C1B File Offset: 0x003B4E1B
		// (set) Token: 0x0601977A RID: 104314 RVA: 0x003B6C33 File Offset: 0x003B4E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaveSyncDataPb Behave
		{
			get
			{
				if (this.dataCase_ != SolarSchoolBatchSyncData.DataOneofCase.Behave)
				{
					return null;
				}
				return (BehaveSyncDataPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SolarSchoolBatchSyncData.DataOneofCase.None : SolarSchoolBatchSyncData.DataOneofCase.Behave);
			}
		}

		// Token: 0x1700562D RID: 22061
		// (get) Token: 0x0601977B RID: 104315 RVA: 0x003B6C49 File Offset: 0x003B4E49
		// (set) Token: 0x0601977C RID: 104316 RVA: 0x003B6C62 File Offset: 0x003B4E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemChangeSyncDataPb ItemChange
		{
			get
			{
				if (this.dataCase_ != SolarSchoolBatchSyncData.DataOneofCase.ItemChange)
				{
					return null;
				}
				return (ItemChangeSyncDataPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SolarSchoolBatchSyncData.DataOneofCase.None : SolarSchoolBatchSyncData.DataOneofCase.ItemChange);
			}
		}

		// Token: 0x1700562E RID: 22062
		// (get) Token: 0x0601977D RID: 104317 RVA: 0x003B6C79 File Offset: 0x003B4E79
		// (set) Token: 0x0601977E RID: 104318 RVA: 0x003B6C92 File Offset: 0x003B4E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExamFinishSyncDataPb ExamFinish
		{
			get
			{
				if (this.dataCase_ != SolarSchoolBatchSyncData.DataOneofCase.ExamFinish)
				{
					return null;
				}
				return (ExamFinishSyncDataPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SolarSchoolBatchSyncData.DataOneofCase.None : SolarSchoolBatchSyncData.DataOneofCase.ExamFinish);
			}
		}

		// Token: 0x1700562F RID: 22063
		// (get) Token: 0x0601977F RID: 104319 RVA: 0x003B6CA9 File Offset: 0x003B4EA9
		// (set) Token: 0x06019780 RID: 104320 RVA: 0x003B6CC2 File Offset: 0x003B4EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuySyncDataPb ShopBuy
		{
			get
			{
				if (this.dataCase_ != SolarSchoolBatchSyncData.DataOneofCase.ShopBuy)
				{
					return null;
				}
				return (ShopBuySyncDataPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SolarSchoolBatchSyncData.DataOneofCase.None : SolarSchoolBatchSyncData.DataOneofCase.ShopBuy);
			}
		}

		// Token: 0x17005630 RID: 22064
		// (get) Token: 0x06019781 RID: 104321 RVA: 0x003B6CD9 File Offset: 0x003B4ED9
		// (set) Token: 0x06019782 RID: 104322 RVA: 0x003B6CF2 File Offset: 0x003B4EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteQuestSyncDataPb CompleteQuest
		{
			get
			{
				if (this.dataCase_ != SolarSchoolBatchSyncData.DataOneofCase.CompleteQuest)
				{
					return null;
				}
				return (CompleteQuestSyncDataPb)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SolarSchoolBatchSyncData.DataOneofCase.None : SolarSchoolBatchSyncData.DataOneofCase.CompleteQuest);
			}
		}

		// Token: 0x17005631 RID: 22065
		// (get) Token: 0x06019783 RID: 104323 RVA: 0x003B6D09 File Offset: 0x003B4F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBatchSyncData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06019784 RID: 104324 RVA: 0x003B6D11 File Offset: 0x003B4F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = SolarSchoolBatchSyncData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06019785 RID: 104325 RVA: 0x003B6D21 File Offset: 0x003B4F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolBatchSyncData);
		}

		// Token: 0x06019786 RID: 104326 RVA: 0x003B6D30 File Offset: 0x003B4F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolBatchSyncData other)
		{
			return other != null && (other == this || (object.Equals(this.AttrChange, other.AttrChange) && object.Equals(this.UnlockNpc, other.UnlockNpc) && object.Equals(this.NpcFavorChange, other.NpcFavorChange) && object.Equals(this.JoinInfluence, other.JoinInfluence) && object.Equals(this.Behave, other.Behave) && object.Equals(this.ItemChange, other.ItemChange) && object.Equals(this.ExamFinish, other.ExamFinish) && object.Equals(this.ShopBuy, other.ShopBuy) && object.Equals(this.CompleteQuest, other.CompleteQuest) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019787 RID: 104327 RVA: 0x003B6E28 File Offset: 0x003B5028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.AttrChange)
			{
				num ^= this.AttrChange.GetHashCode();
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.UnlockNpc)
			{
				num ^= this.UnlockNpc.GetHashCode();
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.NpcFavorChange)
			{
				num ^= this.NpcFavorChange.GetHashCode();
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.JoinInfluence)
			{
				num ^= this.JoinInfluence.GetHashCode();
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.Behave)
			{
				num ^= this.Behave.GetHashCode();
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ItemChange)
			{
				num ^= this.ItemChange.GetHashCode();
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ExamFinish)
			{
				num ^= this.ExamFinish.GetHashCode();
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ShopBuy)
			{
				num ^= this.ShopBuy.GetHashCode();
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.CompleteQuest)
			{
				num ^= this.CompleteQuest.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019788 RID: 104328 RVA: 0x003B6F2A File Offset: 0x003B512A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019789 RID: 104329 RVA: 0x003B6F37 File Offset: 0x003B5137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601978A RID: 104330 RVA: 0x003B6F40 File Offset: 0x003B5140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.AttrChange)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AttrChange);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.UnlockNpc)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.UnlockNpc);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.NpcFavorChange)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.NpcFavorChange);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.JoinInfluence)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.JoinInfluence);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.Behave)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Behave);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ItemChange)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ItemChange);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ExamFinish)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ExamFinish);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ShopBuy)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ShopBuy);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.CompleteQuest)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CompleteQuest);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601978B RID: 104331 RVA: 0x003B706C File Offset: 0x003B526C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.AttrChange)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AttrChange);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.UnlockNpc)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnlockNpc);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.NpcFavorChange)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcFavorChange);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.JoinInfluence)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JoinInfluence);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.Behave)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Behave);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ItemChange)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemChange);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ExamFinish)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ExamFinish);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ShopBuy)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShopBuy);
			}
			if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.CompleteQuest)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CompleteQuest);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601978C RID: 104332 RVA: 0x003B7178 File Offset: 0x003B5378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolBatchSyncData other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.DataCase)
			{
			case SolarSchoolBatchSyncData.DataOneofCase.AttrChange:
				if (this.AttrChange == null)
				{
					this.AttrChange = new AttrChangeSyncDataPb();
				}
				this.AttrChange.MergeFrom(other.AttrChange);
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.UnlockNpc:
				if (this.UnlockNpc == null)
				{
					this.UnlockNpc = new UnlockNpcSyncDataPb();
				}
				this.UnlockNpc.MergeFrom(other.UnlockNpc);
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.NpcFavorChange:
				if (this.NpcFavorChange == null)
				{
					this.NpcFavorChange = new NpcFavorChangeSyncDataPb();
				}
				this.NpcFavorChange.MergeFrom(other.NpcFavorChange);
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.JoinInfluence:
				if (this.JoinInfluence == null)
				{
					this.JoinInfluence = new JoinInfluenceSyncDataPb();
				}
				this.JoinInfluence.MergeFrom(other.JoinInfluence);
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.Behave:
				if (this.Behave == null)
				{
					this.Behave = new BehaveSyncDataPb();
				}
				this.Behave.MergeFrom(other.Behave);
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.ItemChange:
				if (this.ItemChange == null)
				{
					this.ItemChange = new ItemChangeSyncDataPb();
				}
				this.ItemChange.MergeFrom(other.ItemChange);
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.ExamFinish:
				if (this.ExamFinish == null)
				{
					this.ExamFinish = new ExamFinishSyncDataPb();
				}
				this.ExamFinish.MergeFrom(other.ExamFinish);
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.ShopBuy:
				if (this.ShopBuy == null)
				{
					this.ShopBuy = new ShopBuySyncDataPb();
				}
				this.ShopBuy.MergeFrom(other.ShopBuy);
				break;
			case SolarSchoolBatchSyncData.DataOneofCase.CompleteQuest:
				if (this.CompleteQuest == null)
				{
					this.CompleteQuest = new CompleteQuestSyncDataPb();
				}
				this.CompleteQuest.MergeFrom(other.CompleteQuest);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601978D RID: 104333 RVA: 0x003B734B File Offset: 0x003B554B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601978E RID: 104334 RVA: 0x003B7354 File Offset: 0x003B5554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 50U)
				{
					if (num <= 34U)
					{
						if (num == 18U)
						{
							AttrChangeSyncDataPb attrChangeSyncDataPb = new AttrChangeSyncDataPb();
							if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.AttrChange)
							{
								attrChangeSyncDataPb.MergeFrom(this.AttrChange);
							}
							input.ReadMessage(attrChangeSyncDataPb);
							this.AttrChange = attrChangeSyncDataPb;
							continue;
						}
						if (num == 34U)
						{
							UnlockNpcSyncDataPb unlockNpcSyncDataPb = new UnlockNpcSyncDataPb();
							if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.UnlockNpc)
							{
								unlockNpcSyncDataPb.MergeFrom(this.UnlockNpc);
							}
							input.ReadMessage(unlockNpcSyncDataPb);
							this.UnlockNpc = unlockNpcSyncDataPb;
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							NpcFavorChangeSyncDataPb npcFavorChangeSyncDataPb = new NpcFavorChangeSyncDataPb();
							if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.NpcFavorChange)
							{
								npcFavorChangeSyncDataPb.MergeFrom(this.NpcFavorChange);
							}
							input.ReadMessage(npcFavorChangeSyncDataPb);
							this.NpcFavorChange = npcFavorChangeSyncDataPb;
							continue;
						}
						if (num == 50U)
						{
							JoinInfluenceSyncDataPb joinInfluenceSyncDataPb = new JoinInfluenceSyncDataPb();
							if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.JoinInfluence)
							{
								joinInfluenceSyncDataPb.MergeFrom(this.JoinInfluence);
							}
							input.ReadMessage(joinInfluenceSyncDataPb);
							this.JoinInfluence = joinInfluenceSyncDataPb;
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 66U)
					{
						BehaveSyncDataPb behaveSyncDataPb = new BehaveSyncDataPb();
						if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.Behave)
						{
							behaveSyncDataPb.MergeFrom(this.Behave);
						}
						input.ReadMessage(behaveSyncDataPb);
						this.Behave = behaveSyncDataPb;
						continue;
					}
					if (num == 90U)
					{
						ItemChangeSyncDataPb itemChangeSyncDataPb = new ItemChangeSyncDataPb();
						if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ItemChange)
						{
							itemChangeSyncDataPb.MergeFrom(this.ItemChange);
						}
						input.ReadMessage(itemChangeSyncDataPb);
						this.ItemChange = itemChangeSyncDataPb;
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						ExamFinishSyncDataPb examFinishSyncDataPb = new ExamFinishSyncDataPb();
						if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ExamFinish)
						{
							examFinishSyncDataPb.MergeFrom(this.ExamFinish);
						}
						input.ReadMessage(examFinishSyncDataPb);
						this.ExamFinish = examFinishSyncDataPb;
						continue;
					}
					if (num == 106U)
					{
						ShopBuySyncDataPb shopBuySyncDataPb = new ShopBuySyncDataPb();
						if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.ShopBuy)
						{
							shopBuySyncDataPb.MergeFrom(this.ShopBuy);
						}
						input.ReadMessage(shopBuySyncDataPb);
						this.ShopBuy = shopBuySyncDataPb;
						continue;
					}
					if (num == 114U)
					{
						CompleteQuestSyncDataPb completeQuestSyncDataPb = new CompleteQuestSyncDataPb();
						if (this.dataCase_ == SolarSchoolBatchSyncData.DataOneofCase.CompleteQuest)
						{
							completeQuestSyncDataPb.MergeFrom(this.CompleteQuest);
						}
						input.ReadMessage(completeQuestSyncDataPb);
						this.CompleteQuest = completeQuestSyncDataPb;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009684 RID: 38532
		private static readonly MessageParser<SolarSchoolBatchSyncData> _parser = new MessageParser<SolarSchoolBatchSyncData>(() => new SolarSchoolBatchSyncData());

		// Token: 0x04009685 RID: 38533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009686 RID: 38534
		public const int AttrChangeFieldNumber = 2;

		// Token: 0x04009687 RID: 38535
		public const int UnlockNpcFieldNumber = 4;

		// Token: 0x04009688 RID: 38536
		public const int NpcFavorChangeFieldNumber = 5;

		// Token: 0x04009689 RID: 38537
		public const int JoinInfluenceFieldNumber = 6;

		// Token: 0x0400968A RID: 38538
		public const int BehaveFieldNumber = 8;

		// Token: 0x0400968B RID: 38539
		public const int ItemChangeFieldNumber = 11;

		// Token: 0x0400968C RID: 38540
		public const int ExamFinishFieldNumber = 12;

		// Token: 0x0400968D RID: 38541
		public const int ShopBuyFieldNumber = 13;

		// Token: 0x0400968E RID: 38542
		public const int CompleteQuestFieldNumber = 14;

		// Token: 0x0400968F RID: 38543
		private object data_;

		// Token: 0x04009690 RID: 38544
		private SolarSchoolBatchSyncData.DataOneofCase dataCase_;

		// Token: 0x02001A32 RID: 6706
		public enum DataOneofCase
		{
			// Token: 0x0400CF83 RID: 53123
			None,
			// Token: 0x0400CF84 RID: 53124
			AttrChange = 2,
			// Token: 0x0400CF85 RID: 53125
			UnlockNpc = 4,
			// Token: 0x0400CF86 RID: 53126
			NpcFavorChange,
			// Token: 0x0400CF87 RID: 53127
			JoinInfluence,
			// Token: 0x0400CF88 RID: 53128
			Behave = 8,
			// Token: 0x0400CF89 RID: 53129
			ItemChange = 11,
			// Token: 0x0400CF8A RID: 53130
			ExamFinish,
			// Token: 0x0400CF8B RID: 53131
			ShopBuy,
			// Token: 0x0400CF8C RID: 53132
			CompleteQuest
		}
	}
}

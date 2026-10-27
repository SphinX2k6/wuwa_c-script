using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000604 RID: 1540
	[NetMessage(EMessageId.FlowServerSkipNotify)]
	public sealed class FlowServerSkipNotify : IMessage<FlowServerSkipNotify>, IMessage, IEquatable<FlowServerSkipNotify>, IDeepCloneable<FlowServerSkipNotify>, IBufferMessage
	{
		// Token: 0x06008E69 RID: 36457 RVA: 0x001591ED File Offset: 0x001573ED
		[NullableContext(1)]
		public static FlowServerSkipNotify Create()
		{
			return new FlowServerSkipNotify();
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06008E6A RID: 36458 RVA: 0x001591F4 File Offset: 0x001573F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06008E6B RID: 36459 RVA: 0x001591F7 File Offset: 0x001573F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowServerSkipNotify.Descriptor;
			}
		}

		// Token: 0x06008E6C RID: 36460 RVA: 0x001591FE File Offset: 0x001573FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowServerSkipNotify()
		{
		}

		// Token: 0x06008E6D RID: 36461 RVA: 0x00159214 File Offset: 0x00157414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowServerSkipNotify(FlowServerSkipNotify other) : this()
		{
			this.flowListName_ = other.flowListName_;
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this.fadeOutScreen_ = other.fadeOutScreen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E6E RID: 36462 RVA: 0x00159268 File Offset: 0x00157468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowServerSkipNotify Clone()
		{
			return new FlowServerSkipNotify(this);
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x06008E6F RID: 36463 RVA: 0x00159270 File Offset: 0x00157470
		// (set) Token: 0x06008E70 RID: 36464 RVA: 0x00159278 File Offset: 0x00157478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FlowListName
		{
			get
			{
				return this.flowListName_;
			}
			set
			{
				this.flowListName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06008E71 RID: 36465 RVA: 0x0015928B File Offset: 0x0015748B
		// (set) Token: 0x06008E72 RID: 36466 RVA: 0x00159293 File Offset: 0x00157493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FlowId
		{
			get
			{
				return this.flowId_;
			}
			set
			{
				this.flowId_ = value;
			}
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06008E73 RID: 36467 RVA: 0x0015929C File Offset: 0x0015749C
		// (set) Token: 0x06008E74 RID: 36468 RVA: 0x001592A4 File Offset: 0x001574A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateId
		{
			get
			{
				return this.stateId_;
			}
			set
			{
				this.stateId_ = value;
			}
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06008E75 RID: 36469 RVA: 0x001592AD File Offset: 0x001574AD
		// (set) Token: 0x06008E76 RID: 36470 RVA: 0x001592B5 File Offset: 0x001574B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FadeOutScreen
		{
			get
			{
				return this.fadeOutScreen_;
			}
			set
			{
				this.fadeOutScreen_ = value;
			}
		}

		// Token: 0x06008E77 RID: 36471 RVA: 0x001592BE File Offset: 0x001574BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowServerSkipNotify);
		}

		// Token: 0x06008E78 RID: 36472 RVA: 0x001592CC File Offset: 0x001574CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowServerSkipNotify other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && this.FadeOutScreen == other.FadeOutScreen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E79 RID: 36473 RVA: 0x0015933C File Offset: 0x0015753C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowListName.Length != 0)
			{
				num ^= this.FlowListName.GetHashCode();
			}
			if (this.FlowId != 0)
			{
				num ^= this.FlowId.GetHashCode();
			}
			if (this.StateId != 0)
			{
				num ^= this.StateId.GetHashCode();
			}
			if (this.FadeOutScreen)
			{
				num ^= this.FadeOutScreen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E7A RID: 36474 RVA: 0x001593C8 File Offset: 0x001575C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E7B RID: 36475 RVA: 0x001593D5 File Offset: 0x001575D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E7C RID: 36476 RVA: 0x001593E0 File Offset: 0x001575E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StateId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StateId);
			}
			if (this.FlowListName.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.FlowListName);
			}
			if (this.FlowId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.FlowId);
			}
			if (this.FadeOutScreen)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.FadeOutScreen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E7D RID: 36477 RVA: 0x00159478 File Offset: 0x00157678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowListName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowListName);
			}
			if (this.FlowId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlowId);
			}
			if (this.StateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateId);
			}
			if (this.FadeOutScreen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x001594F8 File Offset: 0x001576F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowServerSkipNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowListName.Length != 0)
			{
				this.FlowListName = other.FlowListName;
			}
			if (other.FlowId != 0)
			{
				this.FlowId = other.FlowId;
			}
			if (other.StateId != 0)
			{
				this.StateId = other.StateId;
			}
			if (other.FadeOutScreen)
			{
				this.FadeOutScreen = other.FadeOutScreen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x00159575 File Offset: 0x00157775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E80 RID: 36480 RVA: 0x00159580 File Offset: 0x00157780
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
				if (num <= 42U)
				{
					if (num == 16U)
					{
						this.StateId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.FlowListName = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.FlowId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.FadeOutScreen = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004554 RID: 17748
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004555 RID: 17749
		public const int FlowListNameFieldNumber = 5;

		// Token: 0x04004556 RID: 17750
		private string flowListName_ = "";

		// Token: 0x04004557 RID: 17751
		public const int FlowIdFieldNumber = 6;

		// Token: 0x04004558 RID: 17752
		private int flowId_;

		// Token: 0x04004559 RID: 17753
		public const int StateIdFieldNumber = 2;

		// Token: 0x0400455A RID: 17754
		private int stateId_;

		// Token: 0x0400455B RID: 17755
		public const int FadeOutScreenFieldNumber = 10;

		// Token: 0x0400455C RID: 17756
		private bool fadeOutScreen_;
	}
}

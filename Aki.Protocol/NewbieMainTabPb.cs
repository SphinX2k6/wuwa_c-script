using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B01 RID: 2817
	public sealed class NewbieMainTabPb : IMessage<NewbieMainTabPb>, IMessage, IEquatable<NewbieMainTabPb>, IDeepCloneable<NewbieMainTabPb>, IBufferMessage
	{
		// Token: 0x0600F507 RID: 62727 RVA: 0x0023C3FC File Offset: 0x0023A5FC
		[NullableContext(1)]
		public static NewbieMainTabPb Create()
		{
			return new NewbieMainTabPb();
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0600F508 RID: 62728 RVA: 0x0023C403 File Offset: 0x0023A603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewbieMainTabPb> Parser
		{
			get
			{
				return NewbieMainTabPb._parser;
			}
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600F509 RID: 62729 RVA: 0x0023C40A File Offset: 0x0023A60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600F50A RID: 62730 RVA: 0x0023C40D File Offset: 0x0023A60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieMainTabPb.Descriptor;
			}
		}

		// Token: 0x0600F50B RID: 62731 RVA: 0x0023C414 File Offset: 0x0023A614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTabPb()
		{
		}

		// Token: 0x0600F50C RID: 62732 RVA: 0x0023C427 File Offset: 0x0023A627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTabPb(NewbieMainTabPb other) : this()
		{
			this.tabId_ = other.tabId_;
			this.completedTaskIds_ = other.completedTaskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F50D RID: 62733 RVA: 0x0023C45D File Offset: 0x0023A65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTabPb Clone()
		{
			return new NewbieMainTabPb(this);
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600F50E RID: 62734 RVA: 0x0023C465 File Offset: 0x0023A665
		// (set) Token: 0x0600F50F RID: 62735 RVA: 0x0023C46D File Offset: 0x0023A66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TabId
		{
			get
			{
				return this.tabId_;
			}
			set
			{
				this.tabId_ = value;
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600F510 RID: 62736 RVA: 0x0023C476 File Offset: 0x0023A676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompletedTaskIds
		{
			get
			{
				return this.completedTaskIds_;
			}
		}

		// Token: 0x0600F511 RID: 62737 RVA: 0x0023C47E File Offset: 0x0023A67E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieMainTabPb);
		}

		// Token: 0x0600F512 RID: 62738 RVA: 0x0023C48C File Offset: 0x0023A68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieMainTabPb other)
		{
			return other != null && (other == this || (this.TabId == other.TabId && this.completedTaskIds_.Equals(other.completedTaskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F513 RID: 62739 RVA: 0x0023C4DC File Offset: 0x0023A6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TabId != 0)
			{
				num ^= this.TabId.GetHashCode();
			}
			num ^= this.completedTaskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F514 RID: 62740 RVA: 0x0023C529 File Offset: 0x0023A729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F515 RID: 62741 RVA: 0x0023C536 File Offset: 0x0023A736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F516 RID: 62742 RVA: 0x0023C540 File Offset: 0x0023A740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TabId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TabId);
			}
			this.completedTaskIds_.WriteTo(ref output, NewbieMainTabPb._repeated_completedTaskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F517 RID: 62743 RVA: 0x0023C590 File Offset: 0x0023A790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TabId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TabId);
			}
			num += this.completedTaskIds_.CalculateSize(NewbieMainTabPb._repeated_completedTaskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F518 RID: 62744 RVA: 0x0023C5E4 File Offset: 0x0023A7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieMainTabPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TabId != 0)
			{
				this.TabId = other.TabId;
			}
			this.completedTaskIds_.Add(other.completedTaskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F519 RID: 62745 RVA: 0x0023C631 File Offset: 0x0023A831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F51A RID: 62746 RVA: 0x0023C63C File Offset: 0x0023A83C
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.completedTaskIds_.AddEntriesFrom(ref input, NewbieMainTabPb._repeated_completedTaskIds_codec);
					}
				}
				else
				{
					this.TabId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040062EA RID: 25322
		private static readonly MessageParser<NewbieMainTabPb> _parser = new MessageParser<NewbieMainTabPb>(() => new NewbieMainTabPb());

		// Token: 0x040062EB RID: 25323
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062EC RID: 25324
		public const int TabIdFieldNumber = 1;

		// Token: 0x040062ED RID: 25325
		private int tabId_;

		// Token: 0x040062EE RID: 25326
		public const int CompletedTaskIdsFieldNumber = 2;

		// Token: 0x040062EF RID: 25327
		private static readonly FieldCodec<int> _repeated_completedTaskIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040062F0 RID: 25328
		private readonly RepeatedField<int> completedTaskIds_ = new RepeatedField<int>();
	}
}

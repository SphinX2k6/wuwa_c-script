using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005EF RID: 1519
	[NetMessage(EMessageId.FlowServerSkipNotify)]
	public sealed class FlowServerSkipNotify : IMessage<FlowServerSkipNotify>, IMessage, IEquatable<FlowServerSkipNotify>, IDeepCloneable<FlowServerSkipNotify>, IBufferMessage
	{
		// Token: 0x06008D01 RID: 36097 RVA: 0x001565E9 File Offset: 0x001547E9
		[NullableContext(1)]
		public static FlowServerSkipNotify Create()
		{
			return new FlowServerSkipNotify();
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06008D02 RID: 36098 RVA: 0x001565F0 File Offset: 0x001547F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06008D03 RID: 36099 RVA: 0x001565F3 File Offset: 0x001547F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowServerSkipNotify.Descriptor;
			}
		}

		// Token: 0x06008D04 RID: 36100 RVA: 0x001565FA File Offset: 0x001547FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowServerSkipNotify()
		{
		}

		// Token: 0x06008D05 RID: 36101 RVA: 0x00156610 File Offset: 0x00154810
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

		// Token: 0x06008D06 RID: 36102 RVA: 0x00156664 File Offset: 0x00154864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowServerSkipNotify Clone()
		{
			return new FlowServerSkipNotify(this);
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06008D07 RID: 36103 RVA: 0x0015666C File Offset: 0x0015486C
		// (set) Token: 0x06008D08 RID: 36104 RVA: 0x00156674 File Offset: 0x00154874
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

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06008D09 RID: 36105 RVA: 0x00156687 File Offset: 0x00154887
		// (set) Token: 0x06008D0A RID: 36106 RVA: 0x0015668F File Offset: 0x0015488F
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

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06008D0B RID: 36107 RVA: 0x00156698 File Offset: 0x00154898
		// (set) Token: 0x06008D0C RID: 36108 RVA: 0x001566A0 File Offset: 0x001548A0
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

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06008D0D RID: 36109 RVA: 0x001566A9 File Offset: 0x001548A9
		// (set) Token: 0x06008D0E RID: 36110 RVA: 0x001566B1 File Offset: 0x001548B1
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

		// Token: 0x06008D0F RID: 36111 RVA: 0x001566BA File Offset: 0x001548BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowServerSkipNotify);
		}

		// Token: 0x06008D10 RID: 36112 RVA: 0x001566C8 File Offset: 0x001548C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowServerSkipNotify other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && this.FadeOutScreen == other.FadeOutScreen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D11 RID: 36113 RVA: 0x00156738 File Offset: 0x00154938
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

		// Token: 0x06008D12 RID: 36114 RVA: 0x001567C4 File Offset: 0x001549C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D13 RID: 36115 RVA: 0x001567D1 File Offset: 0x001549D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D14 RID: 36116 RVA: 0x001567DC File Offset: 0x001549DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StateId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.StateId);
			}
			if (this.FlowListName.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.FlowListName);
			}
			if (this.FlowId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.FlowId);
			}
			if (this.FadeOutScreen)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.FadeOutScreen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D15 RID: 36117 RVA: 0x00156874 File Offset: 0x00154A74
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

		// Token: 0x06008D16 RID: 36118 RVA: 0x001568F4 File Offset: 0x00154AF4
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

		// Token: 0x06008D17 RID: 36119 RVA: 0x00156971 File Offset: 0x00154B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D18 RID: 36120 RVA: 0x0015697C File Offset: 0x00154B7C
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
				if (num <= 82U)
				{
					if (num == 56U)
					{
						this.StateId = input.ReadInt32();
						continue;
					}
					if (num == 82U)
					{
						this.FlowListName = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.FlowId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.FadeOutScreen = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400454A RID: 17738
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400454B RID: 17739
		public const int FlowListNameFieldNumber = 10;

		// Token: 0x0400454C RID: 17740
		private string flowListName_ = "";

		// Token: 0x0400454D RID: 17741
		public const int FlowIdFieldNumber = 13;

		// Token: 0x0400454E RID: 17742
		private int flowId_;

		// Token: 0x0400454F RID: 17743
		public const int StateIdFieldNumber = 7;

		// Token: 0x04004550 RID: 17744
		private int stateId_;

		// Token: 0x04004551 RID: 17745
		public const int FadeOutScreenFieldNumber = 15;

		// Token: 0x04004552 RID: 17746
		private bool fadeOutScreen_;
	}
}

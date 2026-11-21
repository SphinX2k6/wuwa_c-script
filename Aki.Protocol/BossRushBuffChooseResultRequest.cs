using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D4 RID: 468
	[NetMessage(EMessageId.BossRushBuffChooseResultRequest)]
	public sealed class BossRushBuffChooseResultRequest : IMessage<BossRushBuffChooseResultRequest>, IMessage, IEquatable<BossRushBuffChooseResultRequest>, IDeepCloneable<BossRushBuffChooseResultRequest>, IBufferMessage
	{
		// Token: 0x06003563 RID: 13667 RVA: 0x0008691D File Offset: 0x00084B1D
		[NullableContext(1)]
		public static BossRushBuffChooseResultRequest Create()
		{
			return new BossRushBuffChooseResultRequest();
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x00086924 File Offset: 0x00084B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06003565 RID: 13669 RVA: 0x00086927 File Offset: 0x00084B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushBuffChooseResultRequest.Descriptor;
			}
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x0008692E File Offset: 0x00084B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultRequest()
		{
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x00086936 File Offset: 0x00084B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultRequest(BossRushBuffChooseResultRequest other) : this()
		{
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x0008695B File Offset: 0x00084B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultRequest Clone()
		{
			return new BossRushBuffChooseResultRequest(this);
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06003569 RID: 13673 RVA: 0x00086963 File Offset: 0x00084B63
		// (set) Token: 0x0600356A RID: 13674 RVA: 0x0008696B File Offset: 0x00084B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x00086974 File Offset: 0x00084B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushBuffChooseResultRequest);
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x00086982 File Offset: 0x00084B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushBuffChooseResultRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x000869B0 File Offset: 0x00084BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x000869EF File Offset: 0x00084BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x000869FC File Offset: 0x00084BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x00086A05 File Offset: 0x00084C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x00086A38 File Offset: 0x00084C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00086A76 File Offset: 0x00084C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushBuffChooseResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x00086AA7 File Offset: 0x00084CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x00086AB0 File Offset: 0x00084CB0
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002AA0 RID: 10912
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AA1 RID: 10913
		public const int IndexFieldNumber = 5;

		// Token: 0x04002AA2 RID: 10914
		private int index_;
	}
}

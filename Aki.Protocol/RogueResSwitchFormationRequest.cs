using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF8 RID: 4088
	[NetMessage(EMessageId.RogueResSwitchFormationRequest)]
	public sealed class RogueResSwitchFormationRequest : IMessage<RogueResSwitchFormationRequest>, IMessage, IEquatable<RogueResSwitchFormationRequest>, IDeepCloneable<RogueResSwitchFormationRequest>, IBufferMessage
	{
		// Token: 0x06015E4C RID: 89676 RVA: 0x0032FC2D File Offset: 0x0032DE2D
		[NullableContext(1)]
		public static RogueResSwitchFormationRequest Create()
		{
			return new RogueResSwitchFormationRequest();
		}

		// Token: 0x17004937 RID: 18743
		// (get) Token: 0x06015E4D RID: 89677 RVA: 0x0032FC34 File Offset: 0x0032DE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004938 RID: 18744
		// (get) Token: 0x06015E4E RID: 89678 RVA: 0x0032FC37 File Offset: 0x0032DE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResSwitchFormationRequest.Descriptor;
			}
		}

		// Token: 0x06015E4F RID: 89679 RVA: 0x0032FC3E File Offset: 0x0032DE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationRequest()
		{
		}

		// Token: 0x06015E50 RID: 89680 RVA: 0x0032FC46 File Offset: 0x0032DE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationRequest(RogueResSwitchFormationRequest other) : this()
		{
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E51 RID: 89681 RVA: 0x0032FC6B File Offset: 0x0032DE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationRequest Clone()
		{
			return new RogueResSwitchFormationRequest(this);
		}

		// Token: 0x17004939 RID: 18745
		// (get) Token: 0x06015E52 RID: 89682 RVA: 0x0032FC73 File Offset: 0x0032DE73
		// (set) Token: 0x06015E53 RID: 89683 RVA: 0x0032FC7B File Offset: 0x0032DE7B
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

		// Token: 0x06015E54 RID: 89684 RVA: 0x0032FC84 File Offset: 0x0032DE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResSwitchFormationRequest);
		}

		// Token: 0x06015E55 RID: 89685 RVA: 0x0032FC92 File Offset: 0x0032DE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResSwitchFormationRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E56 RID: 89686 RVA: 0x0032FCC0 File Offset: 0x0032DEC0
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

		// Token: 0x06015E57 RID: 89687 RVA: 0x0032FCFF File Offset: 0x0032DEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E58 RID: 89688 RVA: 0x0032FD0C File Offset: 0x0032DF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E59 RID: 89689 RVA: 0x0032FD15 File Offset: 0x0032DF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015E5A RID: 89690 RVA: 0x0032FD48 File Offset: 0x0032DF48
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

		// Token: 0x06015E5B RID: 89691 RVA: 0x0032FD86 File Offset: 0x0032DF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResSwitchFormationRequest other)
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

		// Token: 0x06015E5C RID: 89692 RVA: 0x0032FDB7 File Offset: 0x0032DFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E5D RID: 89693 RVA: 0x0032FDC0 File Offset: 0x0032DFC0
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083EF RID: 33775
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083F0 RID: 33776
		public const int IndexFieldNumber = 12;

		// Token: 0x040083F1 RID: 33777
		private int index_;
	}
}

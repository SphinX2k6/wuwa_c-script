using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECB RID: 3787
	[NetMessage(EMessageId.ReceivedSilentFirstAwardRequest)]
	public sealed class ReceivedSilentFirstAwardRequest : IMessage<ReceivedSilentFirstAwardRequest>, IMessage, IEquatable<ReceivedSilentFirstAwardRequest>, IDeepCloneable<ReceivedSilentFirstAwardRequest>, IBufferMessage
	{
		// Token: 0x060144D7 RID: 83159 RVA: 0x002F3531 File Offset: 0x002F1731
		[NullableContext(1)]
		public static ReceivedSilentFirstAwardRequest Create()
		{
			return new ReceivedSilentFirstAwardRequest();
		}

		// Token: 0x1700437C RID: 17276
		// (get) Token: 0x060144D8 RID: 83160 RVA: 0x002F3538 File Offset: 0x002F1738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700437D RID: 17277
		// (get) Token: 0x060144D9 RID: 83161 RVA: 0x002F353B File Offset: 0x002F173B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceivedSilentFirstAwardRequest.Descriptor;
			}
		}

		// Token: 0x060144DA RID: 83162 RVA: 0x002F3542 File Offset: 0x002F1742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardRequest()
		{
		}

		// Token: 0x060144DB RID: 83163 RVA: 0x002F354A File Offset: 0x002F174A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardRequest(ReceivedSilentFirstAwardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060144DC RID: 83164 RVA: 0x002F356F File Offset: 0x002F176F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardRequest Clone()
		{
			return new ReceivedSilentFirstAwardRequest(this);
		}

		// Token: 0x1700437E RID: 17278
		// (get) Token: 0x060144DD RID: 83165 RVA: 0x002F3577 File Offset: 0x002F1777
		// (set) Token: 0x060144DE RID: 83166 RVA: 0x002F357F File Offset: 0x002F177F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x060144DF RID: 83167 RVA: 0x002F3588 File Offset: 0x002F1788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceivedSilentFirstAwardRequest);
		}

		// Token: 0x060144E0 RID: 83168 RVA: 0x002F3596 File Offset: 0x002F1796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceivedSilentFirstAwardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060144E1 RID: 83169 RVA: 0x002F35C4 File Offset: 0x002F17C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060144E2 RID: 83170 RVA: 0x002F3603 File Offset: 0x002F1803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060144E3 RID: 83171 RVA: 0x002F3610 File Offset: 0x002F1810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060144E4 RID: 83172 RVA: 0x002F3619 File Offset: 0x002F1819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060144E5 RID: 83173 RVA: 0x002F364C File Offset: 0x002F184C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060144E6 RID: 83174 RVA: 0x002F368A File Offset: 0x002F188A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReceivedSilentFirstAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060144E7 RID: 83175 RVA: 0x002F36BB File Offset: 0x002F18BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060144E8 RID: 83176 RVA: 0x002F36C4 File Offset: 0x002F18C4
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B52 RID: 31570
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B53 RID: 31571
		public const int IdFieldNumber = 9;

		// Token: 0x04007B54 RID: 31572
		private int id_;
	}
}

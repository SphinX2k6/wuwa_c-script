using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001701 RID: 5889
	[NetMessage(EMessageId.CombatMessagePrefixInfoRequest)]
	public sealed class CombatMessagePrefixInfoRequest : IMessage<CombatMessagePrefixInfoRequest>, IMessage, IEquatable<CombatMessagePrefixInfoRequest>, IDeepCloneable<CombatMessagePrefixInfoRequest>, IBufferMessage
	{
		// Token: 0x0601D6C0 RID: 120512 RVA: 0x00441D5D File Offset: 0x0043FF5D
		[NullableContext(1)]
		public static CombatMessagePrefixInfoRequest Create()
		{
			return new CombatMessagePrefixInfoRequest();
		}

		// Token: 0x17006382 RID: 25474
		// (get) Token: 0x0601D6C1 RID: 120513 RVA: 0x00441D64 File Offset: 0x0043FF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006383 RID: 25475
		// (get) Token: 0x0601D6C2 RID: 120514 RVA: 0x00441D67 File Offset: 0x0043FF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMessagePrefixInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601D6C3 RID: 120515 RVA: 0x00441D6E File Offset: 0x0043FF6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoRequest()
		{
		}

		// Token: 0x0601D6C4 RID: 120516 RVA: 0x00441D81 File Offset: 0x0043FF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoRequest(CombatMessagePrefixInfoRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D6C5 RID: 120517 RVA: 0x00441DA6 File Offset: 0x0043FFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoRequest Clone()
		{
			return new CombatMessagePrefixInfoRequest(this);
		}

		// Token: 0x17006384 RID: 25476
		// (get) Token: 0x0601D6C6 RID: 120518 RVA: 0x00441DAE File Offset: 0x0043FFAE
		// (set) Token: 0x0601D6C7 RID: 120519 RVA: 0x00441DB6 File Offset: 0x0043FFB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601D6C8 RID: 120520 RVA: 0x00441DC9 File Offset: 0x0043FFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMessagePrefixInfoRequest);
		}

		// Token: 0x0601D6C9 RID: 120521 RVA: 0x00441DD7 File Offset: 0x0043FFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMessagePrefixInfoRequest other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D6CA RID: 120522 RVA: 0x00441E0C File Offset: 0x0044000C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id.Length != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D6CB RID: 120523 RVA: 0x00441E4D File Offset: 0x0044004D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D6CC RID: 120524 RVA: 0x00441E5A File Offset: 0x0044005A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D6CD RID: 120525 RVA: 0x00441E63 File Offset: 0x00440063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D6CE RID: 120526 RVA: 0x00441E9C File Offset: 0x0044009C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D6CF RID: 120527 RVA: 0x00441EDF File Offset: 0x004400DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatMessagePrefixInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id.Length != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D6D0 RID: 120528 RVA: 0x00441F15 File Offset: 0x00440115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D6D1 RID: 120529 RVA: 0x00441F20 File Offset: 0x00440120
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadString();
				}
			}
		}

		// Token: 0x0400C73D RID: 51005
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C73E RID: 51006
		public const int IdFieldNumber = 8;

		// Token: 0x0400C73F RID: 51007
		private string id_ = "";
	}
}

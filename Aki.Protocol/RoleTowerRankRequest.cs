using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DA RID: 4314
	[NetMessage(EMessageId.RoleTowerRankRequest)]
	public sealed class RoleTowerRankRequest : IMessage<RoleTowerRankRequest>, IMessage, IEquatable<RoleTowerRankRequest>, IDeepCloneable<RoleTowerRankRequest>, IBufferMessage
	{
		// Token: 0x06017114 RID: 94484 RVA: 0x0035B721 File Offset: 0x00359921
		[NullableContext(1)]
		public static RoleTowerRankRequest Create()
		{
			return new RoleTowerRankRequest();
		}

		// Token: 0x17004D75 RID: 19829
		// (get) Token: 0x06017115 RID: 94485 RVA: 0x0035B728 File Offset: 0x00359928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D76 RID: 19830
		// (get) Token: 0x06017116 RID: 94486 RVA: 0x0035B72B File Offset: 0x0035992B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRankRequest.Descriptor;
			}
		}

		// Token: 0x06017117 RID: 94487 RVA: 0x0035B732 File Offset: 0x00359932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRequest()
		{
		}

		// Token: 0x06017118 RID: 94488 RVA: 0x0035B73A File Offset: 0x0035993A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRequest(RoleTowerRankRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017119 RID: 94489 RVA: 0x0035B75F File Offset: 0x0035995F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRequest Clone()
		{
			return new RoleTowerRankRequest(this);
		}

		// Token: 0x17004D77 RID: 19831
		// (get) Token: 0x0601711A RID: 94490 RVA: 0x0035B767 File Offset: 0x00359967
		// (set) Token: 0x0601711B RID: 94491 RVA: 0x0035B76F File Offset: 0x0035996F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x0601711C RID: 94492 RVA: 0x0035B778 File Offset: 0x00359978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRankRequest);
		}

		// Token: 0x0601711D RID: 94493 RVA: 0x0035B786 File Offset: 0x00359986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRankRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601711E RID: 94494 RVA: 0x0035B7B4 File Offset: 0x003599B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601711F RID: 94495 RVA: 0x0035B7F3 File Offset: 0x003599F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017120 RID: 94496 RVA: 0x0035B800 File Offset: 0x00359A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017121 RID: 94497 RVA: 0x0035B809 File Offset: 0x00359A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017122 RID: 94498 RVA: 0x0035B83C File Offset: 0x00359A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017123 RID: 94499 RVA: 0x0035B87A File Offset: 0x00359A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRankRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017124 RID: 94500 RVA: 0x0035B8AB File Offset: 0x00359AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017125 RID: 94501 RVA: 0x0035B8B4 File Offset: 0x00359AB4
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008A25 RID: 35365
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A26 RID: 35366
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04008A27 RID: 35367
		private int activityId_;
	}
}

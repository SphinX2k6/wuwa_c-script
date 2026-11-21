using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001715 RID: 5909
	[NetMessage(EMessageId.GetDebugInfoNotify)]
	public sealed class GetDebugInfoNotify : IMessage<GetDebugInfoNotify>, IMessage, IEquatable<GetDebugInfoNotify>, IDeepCloneable<GetDebugInfoNotify>, IBufferMessage
	{
		// Token: 0x0601DABE RID: 121534 RVA: 0x0045A7AD File Offset: 0x004589AD
		[NullableContext(1)]
		public static GetDebugInfoNotify Create()
		{
			return new GetDebugInfoNotify();
		}

		// Token: 0x1700650A RID: 25866
		// (get) Token: 0x0601DABF RID: 121535 RVA: 0x0045A7B4 File Offset: 0x004589B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700650B RID: 25867
		// (get) Token: 0x0601DAC0 RID: 121536 RVA: 0x0045A7B7 File Offset: 0x004589B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDebugInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601DAC1 RID: 121537 RVA: 0x0045A7BE File Offset: 0x004589BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDebugInfoNotify()
		{
		}

		// Token: 0x0601DAC2 RID: 121538 RVA: 0x0045A7D1 File Offset: 0x004589D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDebugInfoNotify(GetDebugInfoNotify other) : this()
		{
			this.logId_ = other.logId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DAC3 RID: 121539 RVA: 0x0045A7F6 File Offset: 0x004589F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDebugInfoNotify Clone()
		{
			return new GetDebugInfoNotify(this);
		}

		// Token: 0x1700650C RID: 25868
		// (get) Token: 0x0601DAC4 RID: 121540 RVA: 0x0045A7FE File Offset: 0x004589FE
		// (set) Token: 0x0601DAC5 RID: 121541 RVA: 0x0045A806 File Offset: 0x00458A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LogId
		{
			get
			{
				return this.logId_;
			}
			set
			{
				this.logId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601DAC6 RID: 121542 RVA: 0x0045A819 File Offset: 0x00458A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDebugInfoNotify);
		}

		// Token: 0x0601DAC7 RID: 121543 RVA: 0x0045A827 File Offset: 0x00458A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDebugInfoNotify other)
		{
			return other != null && (other == this || (!(this.LogId != other.LogId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DAC8 RID: 121544 RVA: 0x0045A85C File Offset: 0x00458A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId.Length != 0)
			{
				num ^= this.LogId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DAC9 RID: 121545 RVA: 0x0045A89D File Offset: 0x00458A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DACA RID: 121546 RVA: 0x0045A8AA File Offset: 0x00458AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DACB RID: 121547 RVA: 0x0045A8B3 File Offset: 0x00458AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LogId.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DACC RID: 121548 RVA: 0x0045A8EC File Offset: 0x00458AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LogId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DACD RID: 121549 RVA: 0x0045A92F File Offset: 0x00458B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDebugInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId.Length != 0)
			{
				this.LogId = other.LogId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DACE RID: 121550 RVA: 0x0045A965 File Offset: 0x00458B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DACF RID: 121551 RVA: 0x0045A970 File Offset: 0x00458B70
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LogId = input.ReadString();
				}
			}
		}

		// Token: 0x0400C8FC RID: 51452
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C8FD RID: 51453
		public const int LogIdFieldNumber = 13;

		// Token: 0x0400C8FE RID: 51454
		private string logId_ = "";
	}
}

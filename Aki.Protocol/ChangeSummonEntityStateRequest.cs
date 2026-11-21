using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000269 RID: 617
	[NetMessage(EMessageId.ChangeSummonEntityStateRequest)]
	public sealed class ChangeSummonEntityStateRequest : IMessage<ChangeSummonEntityStateRequest>, IMessage, IEquatable<ChangeSummonEntityStateRequest>, IDeepCloneable<ChangeSummonEntityStateRequest>, IBufferMessage
	{
		// Token: 0x06004158 RID: 16728 RVA: 0x000A09D2 File Offset: 0x0009EBD2
		[NullableContext(1)]
		public static ChangeSummonEntityStateRequest Create()
		{
			return new ChangeSummonEntityStateRequest();
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x000A09D9 File Offset: 0x0009EBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x0600415A RID: 16730 RVA: 0x000A09DC File Offset: 0x0009EBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeSummonEntityStateRequest.Descriptor;
			}
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x000A09E3 File Offset: 0x0009EBE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateRequest()
		{
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x000A09EB File Offset: 0x0009EBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateRequest(ChangeSummonEntityStateRequest other) : this()
		{
			this.summonEntityId_ = other.summonEntityId_;
			this.tagId_ = other.tagId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x000A0A1C File Offset: 0x0009EC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateRequest Clone()
		{
			return new ChangeSummonEntityStateRequest(this);
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x0600415E RID: 16734 RVA: 0x000A0A24 File Offset: 0x0009EC24
		// (set) Token: 0x0600415F RID: 16735 RVA: 0x000A0A2C File Offset: 0x0009EC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonEntityId
		{
			get
			{
				return this.summonEntityId_;
			}
			set
			{
				this.summonEntityId_ = value;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06004160 RID: 16736 RVA: 0x000A0A35 File Offset: 0x0009EC35
		// (set) Token: 0x06004161 RID: 16737 RVA: 0x000A0A3D File Offset: 0x0009EC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TagId
		{
			get
			{
				return this.tagId_;
			}
			set
			{
				this.tagId_ = value;
			}
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x000A0A46 File Offset: 0x0009EC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeSummonEntityStateRequest);
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x000A0A54 File Offset: 0x0009EC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeSummonEntityStateRequest other)
		{
			return other != null && (other == this || (this.SummonEntityId == other.SummonEntityId && this.TagId == other.TagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x000A0A94 File Offset: 0x0009EC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonEntityId != 0L)
			{
				num ^= this.SummonEntityId.GetHashCode();
			}
			if (this.TagId != 0)
			{
				num ^= this.TagId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x000A0AEC File Offset: 0x0009ECEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x000A0AF9 File Offset: 0x0009ECF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x000A0B04 File Offset: 0x0009ED04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SummonEntityId);
			}
			if (this.TagId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x000A0B60 File Offset: 0x0009ED60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonEntityId);
			}
			if (this.TagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x000A0BB8 File Offset: 0x0009EDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeSummonEntityStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonEntityId != 0L)
			{
				this.SummonEntityId = other.SummonEntityId;
			}
			if (other.TagId != 0)
			{
				this.TagId = other.TagId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x000A0C08 File Offset: 0x0009EE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x000A0C14 File Offset: 0x0009EE14
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
				if (num != 24U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TagId = input.ReadInt32();
					}
				}
				else
				{
					this.SummonEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002DF9 RID: 11769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DFA RID: 11770
		public const int SummonEntityIdFieldNumber = 3;

		// Token: 0x04002DFB RID: 11771
		private long summonEntityId_;

		// Token: 0x04002DFC RID: 11772
		public const int TagIdFieldNumber = 7;

		// Token: 0x04002DFD RID: 11773
		private int tagId_;
	}
}

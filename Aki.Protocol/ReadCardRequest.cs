using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E86 RID: 3718
	[NetMessage(EMessageId.ReadCardRequest)]
	public sealed class ReadCardRequest : IMessage<ReadCardRequest>, IMessage, IEquatable<ReadCardRequest>, IDeepCloneable<ReadCardRequest>, IBufferMessage
	{
		// Token: 0x06013FE5 RID: 81893 RVA: 0x002E9E8A File Offset: 0x002E808A
		[NullableContext(1)]
		public static ReadCardRequest Create()
		{
			return new ReadCardRequest();
		}

		// Token: 0x17004287 RID: 17031
		// (get) Token: 0x06013FE6 RID: 81894 RVA: 0x002E9E91 File Offset: 0x002E8091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004288 RID: 17032
		// (get) Token: 0x06013FE7 RID: 81895 RVA: 0x002E9E94 File Offset: 0x002E8094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReadCardRequest.Descriptor;
			}
		}

		// Token: 0x06013FE8 RID: 81896 RVA: 0x002E9E9B File Offset: 0x002E809B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardRequest()
		{
		}

		// Token: 0x06013FE9 RID: 81897 RVA: 0x002E9EA3 File Offset: 0x002E80A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardRequest(ReadCardRequest other) : this()
		{
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013FEA RID: 81898 RVA: 0x002E9EC8 File Offset: 0x002E80C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardRequest Clone()
		{
			return new ReadCardRequest(this);
		}

		// Token: 0x17004289 RID: 17033
		// (get) Token: 0x06013FEB RID: 81899 RVA: 0x002E9ED0 File Offset: 0x002E80D0
		// (set) Token: 0x06013FEC RID: 81900 RVA: 0x002E9ED8 File Offset: 0x002E80D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardId
		{
			get
			{
				return this.cardId_;
			}
			set
			{
				this.cardId_ = value;
			}
		}

		// Token: 0x06013FED RID: 81901 RVA: 0x002E9EE1 File Offset: 0x002E80E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReadCardRequest);
		}

		// Token: 0x06013FEE RID: 81902 RVA: 0x002E9EEF File Offset: 0x002E80EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReadCardRequest other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013FEF RID: 81903 RVA: 0x002E9F20 File Offset: 0x002E8120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013FF0 RID: 81904 RVA: 0x002E9F5F File Offset: 0x002E815F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013FF1 RID: 81905 RVA: 0x002E9F6C File Offset: 0x002E816C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013FF2 RID: 81906 RVA: 0x002E9F75 File Offset: 0x002E8175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013FF3 RID: 81907 RVA: 0x002E9FA8 File Offset: 0x002E81A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013FF4 RID: 81908 RVA: 0x002E9FE6 File Offset: 0x002E81E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReadCardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013FF5 RID: 81909 RVA: 0x002EA017 File Offset: 0x002E8217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013FF6 RID: 81910 RVA: 0x002EA020 File Offset: 0x002E8220
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007A7E RID: 31358
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A7F RID: 31359
		public const int CardIdFieldNumber = 10;

		// Token: 0x04007A80 RID: 31360
		private int cardId_;
	}
}

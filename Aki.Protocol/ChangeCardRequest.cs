using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000245 RID: 581
	[NetMessage(EMessageId.ChangeCardRequest)]
	public sealed class ChangeCardRequest : IMessage<ChangeCardRequest>, IMessage, IEquatable<ChangeCardRequest>, IDeepCloneable<ChangeCardRequest>, IBufferMessage
	{
		// Token: 0x06003E45 RID: 15941 RVA: 0x00099BD6 File Offset: 0x00097DD6
		[NullableContext(1)]
		public static ChangeCardRequest Create()
		{
			return new ChangeCardRequest();
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x00099BDD File Offset: 0x00097DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06003E47 RID: 15943 RVA: 0x00099BE0 File Offset: 0x00097DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeCardRequest.Descriptor;
			}
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x00099BE7 File Offset: 0x00097DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardRequest()
		{
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x00099BEF File Offset: 0x00097DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardRequest(ChangeCardRequest other) : this()
		{
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x00099C14 File Offset: 0x00097E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardRequest Clone()
		{
			return new ChangeCardRequest(this);
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06003E4B RID: 15947 RVA: 0x00099C1C File Offset: 0x00097E1C
		// (set) Token: 0x06003E4C RID: 15948 RVA: 0x00099C24 File Offset: 0x00097E24
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

		// Token: 0x06003E4D RID: 15949 RVA: 0x00099C2D File Offset: 0x00097E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeCardRequest);
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x00099C3B File Offset: 0x00097E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeCardRequest other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x00099C6C File Offset: 0x00097E6C
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

		// Token: 0x06003E50 RID: 15952 RVA: 0x00099CAB File Offset: 0x00097EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00099CB8 File Offset: 0x00097EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x00099CC1 File Offset: 0x00097EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x00099CF4 File Offset: 0x00097EF4
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

		// Token: 0x06003E54 RID: 15956 RVA: 0x00099D32 File Offset: 0x00097F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeCardRequest other)
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

		// Token: 0x06003E55 RID: 15957 RVA: 0x00099D63 File Offset: 0x00097F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x00099D6C File Offset: 0x00097F6C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002CD7 RID: 11479
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CD8 RID: 11480
		public const int CardIdFieldNumber = 3;

		// Token: 0x04002CD9 RID: 11481
		private int cardId_;
	}
}

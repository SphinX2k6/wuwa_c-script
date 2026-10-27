using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E96 RID: 3734
	[NetMessage(EMessageId.ReadCardRequest)]
	public sealed class ReadCardRequest : IMessage<ReadCardRequest>, IMessage, IEquatable<ReadCardRequest>, IDeepCloneable<ReadCardRequest>, IBufferMessage
	{
		// Token: 0x060140CA RID: 82122 RVA: 0x002EB546 File Offset: 0x002E9746
		[NullableContext(1)]
		public static ReadCardRequest Create()
		{
			return new ReadCardRequest();
		}

		// Token: 0x170042B1 RID: 17073
		// (get) Token: 0x060140CB RID: 82123 RVA: 0x002EB54D File Offset: 0x002E974D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042B2 RID: 17074
		// (get) Token: 0x060140CC RID: 82124 RVA: 0x002EB550 File Offset: 0x002E9750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReadCardRequest.Descriptor;
			}
		}

		// Token: 0x060140CD RID: 82125 RVA: 0x002EB557 File Offset: 0x002E9757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardRequest()
		{
		}

		// Token: 0x060140CE RID: 82126 RVA: 0x002EB55F File Offset: 0x002E975F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardRequest(ReadCardRequest other) : this()
		{
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060140CF RID: 82127 RVA: 0x002EB584 File Offset: 0x002E9784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardRequest Clone()
		{
			return new ReadCardRequest(this);
		}

		// Token: 0x170042B3 RID: 17075
		// (get) Token: 0x060140D0 RID: 82128 RVA: 0x002EB58C File Offset: 0x002E978C
		// (set) Token: 0x060140D1 RID: 82129 RVA: 0x002EB594 File Offset: 0x002E9794
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

		// Token: 0x060140D2 RID: 82130 RVA: 0x002EB59D File Offset: 0x002E979D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReadCardRequest);
		}

		// Token: 0x060140D3 RID: 82131 RVA: 0x002EB5AB File Offset: 0x002E97AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReadCardRequest other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060140D4 RID: 82132 RVA: 0x002EB5DC File Offset: 0x002E97DC
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

		// Token: 0x060140D5 RID: 82133 RVA: 0x002EB61B File Offset: 0x002E981B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060140D6 RID: 82134 RVA: 0x002EB628 File Offset: 0x002E9828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060140D7 RID: 82135 RVA: 0x002EB631 File Offset: 0x002E9831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060140D8 RID: 82136 RVA: 0x002EB664 File Offset: 0x002E9864
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

		// Token: 0x060140D9 RID: 82137 RVA: 0x002EB6A2 File Offset: 0x002E98A2
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

		// Token: 0x060140DA RID: 82138 RVA: 0x002EB6D3 File Offset: 0x002E98D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060140DB RID: 82139 RVA: 0x002EB6DC File Offset: 0x002E98DC
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007A54 RID: 31316
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A55 RID: 31317
		public const int CardIdFieldNumber = 14;

		// Token: 0x04007A56 RID: 31318
		private int cardId_;
	}
}

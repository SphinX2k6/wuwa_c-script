using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000074 RID: 116
	[NetMessage(EMessageId.ActionOperationScreenSuccessRequest)]
	public sealed class ActionOperationScreenSuccessRequest : IMessage<ActionOperationScreenSuccessRequest>, IMessage, IEquatable<ActionOperationScreenSuccessRequest>, IDeepCloneable<ActionOperationScreenSuccessRequest>, IBufferMessage
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x0003E855 File Offset: 0x0003CA55
		[NullableContext(1)]
		public static ActionOperationScreenSuccessRequest Create()
		{
			return new ActionOperationScreenSuccessRequest();
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x0003E85C File Offset: 0x0003CA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0003E85F File Offset: 0x0003CA5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionOperationScreenSuccessRequest.Descriptor;
			}
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0003E866 File Offset: 0x0003CA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessRequest()
		{
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x0003E86E File Offset: 0x0003CA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessRequest(ActionOperationScreenSuccessRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x0003E8AB File Offset: 0x0003CAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessRequest Clone()
		{
			return new ActionOperationScreenSuccessRequest(this);
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0003E8B3 File Offset: 0x0003CAB3
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x0003E8BB File Offset: 0x0003CABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x0003E8C4 File Offset: 0x0003CAC4
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x0003E8CC File Offset: 0x0003CACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0003E8D5 File Offset: 0x0003CAD5
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x0003E8DD File Offset: 0x0003CADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionScreenOperationType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0003E8E6 File Offset: 0x0003CAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionOperationScreenSuccessRequest);
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x0003E8F4 File Offset: 0x0003CAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionOperationScreenSuccessRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x0003E950 File Offset: 0x0003CB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.Type != ActionScreenOperationType.Close)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x0003E9C7 File Offset: 0x0003CBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x0003E9D4 File Offset: 0x0003CBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x0003E9E0 File Offset: 0x0003CBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != ActionScreenOperationType.Close)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Type);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IncId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x0003EA58 File Offset: 0x0003CC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.Type != ActionScreenOperationType.Close)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x0003EAC8 File Offset: 0x0003CCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionOperationScreenSuccessRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Type != ActionScreenOperationType.Close)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x0003EB2C File Offset: 0x0003CD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0003EB38 File Offset: 0x0003CD38
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
					if (num != 40U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlayerId = input.ReadInt32();
						}
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (ActionScreenOperationType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400214D RID: 8525
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400214E RID: 8526
		public const int PlayerIdFieldNumber = 8;

		// Token: 0x0400214F RID: 8527
		private int playerId_;

		// Token: 0x04002150 RID: 8528
		public const int IncIdFieldNumber = 5;

		// Token: 0x04002151 RID: 8529
		private int incId_;

		// Token: 0x04002152 RID: 8530
		public const int TypeFieldNumber = 3;

		// Token: 0x04002153 RID: 8531
		private ActionScreenOperationType type_;
	}
}

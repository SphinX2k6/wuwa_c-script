using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000111 RID: 273
	[NetMessage(EMessageId.AreaTerminalPinOperationRequest)]
	public sealed class AreaTerminalPinOperationRequest : IMessage<AreaTerminalPinOperationRequest>, IMessage, IEquatable<AreaTerminalPinOperationRequest>, IDeepCloneable<AreaTerminalPinOperationRequest>, IBufferMessage
	{
		// Token: 0x060025D8 RID: 9688 RVA: 0x000650AE File Offset: 0x000632AE
		[NullableContext(1)]
		public static AreaTerminalPinOperationRequest Create()
		{
			return new AreaTerminalPinOperationRequest();
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x000650B5 File Offset: 0x000632B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000650B8 File Offset: 0x000632B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaTerminalPinOperationRequest.Descriptor;
			}
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x000650BF File Offset: 0x000632BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationRequest()
		{
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x000650C7 File Offset: 0x000632C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationRequest(AreaTerminalPinOperationRequest other) : this()
		{
			this.id_ = other.id_;
			this.opType_ = other.opType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x000650F8 File Offset: 0x000632F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationRequest Clone()
		{
			return new AreaTerminalPinOperationRequest(this);
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x00065100 File Offset: 0x00063300
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x00065108 File Offset: 0x00063308
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

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x00065111 File Offset: 0x00063311
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x00065119 File Offset: 0x00063319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OpType
		{
			get
			{
				return this.opType_;
			}
			set
			{
				this.opType_ = value;
			}
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00065122 File Offset: 0x00063322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaTerminalPinOperationRequest);
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x00065130 File Offset: 0x00063330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaTerminalPinOperationRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.OpType == other.OpType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00065170 File Offset: 0x00063370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.OpType)
			{
				num ^= this.OpType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x000651C8 File Offset: 0x000633C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x000651D5 File Offset: 0x000633D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x000651E0 File Offset: 0x000633E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.OpType)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.OpType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x0006523C File Offset: 0x0006343C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.OpType)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00065288 File Offset: 0x00063488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AreaTerminalPinOperationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.OpType)
			{
				this.OpType = other.OpType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x000652D8 File Offset: 0x000634D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x000652E4 File Offset: 0x000634E4
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
				if (num != 16U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OpType = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400263B RID: 9787
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400263C RID: 9788
		public const int IdFieldNumber = 2;

		// Token: 0x0400263D RID: 9789
		private int id_;

		// Token: 0x0400263E RID: 9790
		public const int OpTypeFieldNumber = 9;

		// Token: 0x0400263F RID: 9791
		private bool opType_;
	}
}

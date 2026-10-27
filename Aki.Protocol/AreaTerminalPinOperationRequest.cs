using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010F RID: 271
	[NetMessage(EMessageId.AreaTerminalPinOperationRequest)]
	public sealed class AreaTerminalPinOperationRequest : IMessage<AreaTerminalPinOperationRequest>, IMessage, IEquatable<AreaTerminalPinOperationRequest>, IDeepCloneable<AreaTerminalPinOperationRequest>, IBufferMessage
	{
		// Token: 0x06002579 RID: 9593 RVA: 0x0006408A File Offset: 0x0006228A
		[NullableContext(1)]
		public static AreaTerminalPinOperationRequest Create()
		{
			return new AreaTerminalPinOperationRequest();
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x00064091 File Offset: 0x00062291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x00064094 File Offset: 0x00062294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaTerminalPinOperationRequest.Descriptor;
			}
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x0006409B File Offset: 0x0006229B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationRequest()
		{
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000640A3 File Offset: 0x000622A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationRequest(AreaTerminalPinOperationRequest other) : this()
		{
			this.id_ = other.id_;
			this.opType_ = other.opType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000640D4 File Offset: 0x000622D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationRequest Clone()
		{
			return new AreaTerminalPinOperationRequest(this);
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x000640DC File Offset: 0x000622DC
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x000640E4 File Offset: 0x000622E4
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

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x000640ED File Offset: 0x000622ED
		// (set) Token: 0x06002582 RID: 9602 RVA: 0x000640F5 File Offset: 0x000622F5
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

		// Token: 0x06002583 RID: 9603 RVA: 0x000640FE File Offset: 0x000622FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaTerminalPinOperationRequest);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x0006410C File Offset: 0x0006230C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaTerminalPinOperationRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.OpType == other.OpType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x0006414C File Offset: 0x0006234C
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

		// Token: 0x06002586 RID: 9606 RVA: 0x000641A4 File Offset: 0x000623A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x000641B1 File Offset: 0x000623B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x000641BC File Offset: 0x000623BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpType)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.OpType);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00064218 File Offset: 0x00062418
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

		// Token: 0x0600258A RID: 9610 RVA: 0x00064264 File Offset: 0x00062464
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

		// Token: 0x0600258B RID: 9611 RVA: 0x000642B4 File Offset: 0x000624B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x000642C0 File Offset: 0x000624C0
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.OpType = input.ReadBool();
				}
			}
		}

		// Token: 0x040025D0 RID: 9680
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025D1 RID: 9681
		public const int IdFieldNumber = 12;

		// Token: 0x040025D2 RID: 9682
		private int id_;

		// Token: 0x040025D3 RID: 9683
		public const int OpTypeFieldNumber = 9;

		// Token: 0x040025D4 RID: 9684
		private bool opType_;
	}
}

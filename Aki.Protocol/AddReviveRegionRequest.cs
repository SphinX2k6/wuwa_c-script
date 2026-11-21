using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AD RID: 173
	[NetMessage(EMessageId.AddReviveRegionRequest)]
	public sealed class AddReviveRegionRequest : IMessage<AddReviveRegionRequest>, IMessage, IEquatable<AddReviveRegionRequest>, IDeepCloneable<AddReviveRegionRequest>, IBufferMessage
	{
		// Token: 0x06001D78 RID: 7544 RVA: 0x0005140F File Offset: 0x0004F60F
		[NullableContext(1)]
		public static AddReviveRegionRequest Create()
		{
			return new AddReviveRegionRequest();
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x00051416 File Offset: 0x0004F616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x00051419 File Offset: 0x0004F619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddReviveRegionRequest.Descriptor;
			}
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00051420 File Offset: 0x0004F620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionRequest()
		{
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00051428 File Offset: 0x0004F628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionRequest(AddReviveRegionRequest other) : this()
		{
			this.reviveId_ = other.reviveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0005144D File Offset: 0x0004F64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionRequest Clone()
		{
			return new AddReviveRegionRequest(this);
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00051455 File Offset: 0x0004F655
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0005145D File Offset: 0x0004F65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReviveId
		{
			get
			{
				return this.reviveId_;
			}
			set
			{
				this.reviveId_ = value;
			}
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00051466 File Offset: 0x0004F666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddReviveRegionRequest);
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00051474 File Offset: 0x0004F674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddReviveRegionRequest other)
		{
			return other != null && (other == this || (this.ReviveId == other.ReviveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x000514A4 File Offset: 0x0004F6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReviveId != 0)
			{
				num ^= this.ReviveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000514E3 File Offset: 0x0004F6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x000514F0 File Offset: 0x0004F6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x000514F9 File Offset: 0x0004F6F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReviveId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ReviveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0005152C File Offset: 0x0004F72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReviveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReviveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0005156A File Offset: 0x0004F76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddReviveRegionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReviveId != 0)
			{
				this.ReviveId = other.ReviveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0005159B File Offset: 0x0004F79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x000515A4 File Offset: 0x0004F7A4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ReviveId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002371 RID: 9073
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002372 RID: 9074
		public const int ReviveIdFieldNumber = 2;

		// Token: 0x04002373 RID: 9075
		private int reviveId_;
	}
}

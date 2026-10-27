using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AC RID: 172
	[NetMessage(EMessageId.AddReviveRegionRequest)]
	public sealed class AddReviveRegionRequest : IMessage<AddReviveRegionRequest>, IMessage, IEquatable<AddReviveRegionRequest>, IDeepCloneable<AddReviveRegionRequest>, IBufferMessage
	{
		// Token: 0x06001D2F RID: 7471 RVA: 0x0005075B File Offset: 0x0004E95B
		[NullableContext(1)]
		public static AddReviveRegionRequest Create()
		{
			return new AddReviveRegionRequest();
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00050762 File Offset: 0x0004E962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00050765 File Offset: 0x0004E965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddReviveRegionRequest.Descriptor;
			}
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0005076C File Offset: 0x0004E96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionRequest()
		{
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00050774 File Offset: 0x0004E974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionRequest(AddReviveRegionRequest other) : this()
		{
			this.reviveId_ = other.reviveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00050799 File Offset: 0x0004E999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionRequest Clone()
		{
			return new AddReviveRegionRequest(this);
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x000507A1 File Offset: 0x0004E9A1
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x000507A9 File Offset: 0x0004E9A9
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

		// Token: 0x06001D37 RID: 7479 RVA: 0x000507B2 File Offset: 0x0004E9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddReviveRegionRequest);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x000507C0 File Offset: 0x0004E9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddReviveRegionRequest other)
		{
			return other != null && (other == this || (this.ReviveId == other.ReviveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x000507F0 File Offset: 0x0004E9F0
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

		// Token: 0x06001D3A RID: 7482 RVA: 0x0005082F File Offset: 0x0004EA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0005083C File Offset: 0x0004EA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00050845 File Offset: 0x0004EA45
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

		// Token: 0x06001D3D RID: 7485 RVA: 0x00050878 File Offset: 0x0004EA78
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

		// Token: 0x06001D3E RID: 7486 RVA: 0x000508B6 File Offset: 0x0004EAB6
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

		// Token: 0x06001D3F RID: 7487 RVA: 0x000508E7 File Offset: 0x0004EAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x000508F0 File Offset: 0x0004EAF0
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

		// Token: 0x0400230E RID: 8974
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400230F RID: 8975
		public const int ReviveIdFieldNumber = 2;

		// Token: 0x04002310 RID: 8976
		private int reviveId_;
	}
}

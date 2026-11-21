using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001EB RID: 491
	[NetMessage(EMessageId.BtForcedOccupationRequest)]
	public sealed class BtForcedOccupationRequest : IMessage<BtForcedOccupationRequest>, IMessage, IEquatable<BtForcedOccupationRequest>, IDeepCloneable<BtForcedOccupationRequest>, IBufferMessage
	{
		// Token: 0x06003732 RID: 14130 RVA: 0x0008A731 File Offset: 0x00088931
		[NullableContext(1)]
		public static BtForcedOccupationRequest Create()
		{
			return new BtForcedOccupationRequest();
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06003733 RID: 14131 RVA: 0x0008A738 File Offset: 0x00088938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06003734 RID: 14132 RVA: 0x0008A73B File Offset: 0x0008893B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtForcedOccupationRequest.Descriptor;
			}
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x0008A742 File Offset: 0x00088942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationRequest()
		{
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x0008A74A File Offset: 0x0008894A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationRequest(BtForcedOccupationRequest other) : this()
		{
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x0008A76F File Offset: 0x0008896F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationRequest Clone()
		{
			return new BtForcedOccupationRequest(this);
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06003738 RID: 14136 RVA: 0x0008A777 File Offset: 0x00088977
		// (set) Token: 0x06003739 RID: 14137 RVA: 0x0008A77F File Offset: 0x0008897F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x0008A788 File Offset: 0x00088988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtForcedOccupationRequest);
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x0008A796 File Offset: 0x00088996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtForcedOccupationRequest other)
		{
			return other != null && (other == this || (this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x0008A7C4 File Offset: 0x000889C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x0008A803 File Offset: 0x00088A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x0008A810 File Offset: 0x00088A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x0008A819 File Offset: 0x00088A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x0008A84C File Offset: 0x00088A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x0008A88A File Offset: 0x00088A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtForcedOccupationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x0008A8BB File Offset: 0x00088ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x0008A8C4 File Offset: 0x00088AC4
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
					this.TreeIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002B28 RID: 11048
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B29 RID: 11049
		public const int TreeIncIdFieldNumber = 3;

		// Token: 0x04002B2A RID: 11050
		private long treeIncId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F17 RID: 3863
	[NetMessage(EMessageId.RenjuExitMatchedActionRequest)]
	public sealed class RenjuExitMatchedActionRequest : IMessage<RenjuExitMatchedActionRequest>, IMessage, IEquatable<RenjuExitMatchedActionRequest>, IDeepCloneable<RenjuExitMatchedActionRequest>, IBufferMessage
	{
		// Token: 0x06014AE0 RID: 84704 RVA: 0x00300626 File Offset: 0x002FE826
		[NullableContext(1)]
		public static RenjuExitMatchedActionRequest Create()
		{
			return new RenjuExitMatchedActionRequest();
		}

		// Token: 0x170044BD RID: 17597
		// (get) Token: 0x06014AE1 RID: 84705 RVA: 0x0030062D File Offset: 0x002FE82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044BE RID: 17598
		// (get) Token: 0x06014AE2 RID: 84706 RVA: 0x00300630 File Offset: 0x002FE830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuExitMatchedActionRequest.Descriptor;
			}
		}

		// Token: 0x06014AE3 RID: 84707 RVA: 0x00300637 File Offset: 0x002FE837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionRequest()
		{
		}

		// Token: 0x06014AE4 RID: 84708 RVA: 0x0030063F File Offset: 0x002FE83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionRequest(RenjuExitMatchedActionRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014AE5 RID: 84709 RVA: 0x00300664 File Offset: 0x002FE864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionRequest Clone()
		{
			return new RenjuExitMatchedActionRequest(this);
		}

		// Token: 0x170044BF RID: 17599
		// (get) Token: 0x06014AE6 RID: 84710 RVA: 0x0030066C File Offset: 0x002FE86C
		// (set) Token: 0x06014AE7 RID: 84711 RVA: 0x00300674 File Offset: 0x002FE874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06014AE8 RID: 84712 RVA: 0x0030067D File Offset: 0x002FE87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuExitMatchedActionRequest);
		}

		// Token: 0x06014AE9 RID: 84713 RVA: 0x0030068B File Offset: 0x002FE88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuExitMatchedActionRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014AEA RID: 84714 RVA: 0x003006BC File Offset: 0x002FE8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014AEB RID: 84715 RVA: 0x003006FB File Offset: 0x002FE8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014AEC RID: 84716 RVA: 0x00300708 File Offset: 0x002FE908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014AED RID: 84717 RVA: 0x00300711 File Offset: 0x002FE911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014AEE RID: 84718 RVA: 0x00300744 File Offset: 0x002FE944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014AEF RID: 84719 RVA: 0x00300782 File Offset: 0x002FE982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenjuExitMatchedActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014AF0 RID: 84720 RVA: 0x003007B3 File Offset: 0x002FE9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014AF1 RID: 84721 RVA: 0x003007BC File Offset: 0x002FE9BC
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007D06 RID: 32006
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D07 RID: 32007
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04007D08 RID: 32008
		private long entityId_;
	}
}

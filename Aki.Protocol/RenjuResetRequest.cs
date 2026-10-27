using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F19 RID: 3865
	[NetMessage(EMessageId.RenjuResetRequest)]
	public sealed class RenjuResetRequest : IMessage<RenjuResetRequest>, IMessage, IEquatable<RenjuResetRequest>, IDeepCloneable<RenjuResetRequest>, IBufferMessage
	{
		// Token: 0x06014B04 RID: 84740 RVA: 0x003009E1 File Offset: 0x002FEBE1
		[NullableContext(1)]
		public static RenjuResetRequest Create()
		{
			return new RenjuResetRequest();
		}

		// Token: 0x170044C3 RID: 17603
		// (get) Token: 0x06014B05 RID: 84741 RVA: 0x003009E8 File Offset: 0x002FEBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044C4 RID: 17604
		// (get) Token: 0x06014B06 RID: 84742 RVA: 0x003009EB File Offset: 0x002FEBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuResetRequest.Descriptor;
			}
		}

		// Token: 0x06014B07 RID: 84743 RVA: 0x003009F2 File Offset: 0x002FEBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetRequest()
		{
		}

		// Token: 0x06014B08 RID: 84744 RVA: 0x003009FA File Offset: 0x002FEBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetRequest(RenjuResetRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B09 RID: 84745 RVA: 0x00300A1F File Offset: 0x002FEC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetRequest Clone()
		{
			return new RenjuResetRequest(this);
		}

		// Token: 0x170044C5 RID: 17605
		// (get) Token: 0x06014B0A RID: 84746 RVA: 0x00300A27 File Offset: 0x002FEC27
		// (set) Token: 0x06014B0B RID: 84747 RVA: 0x00300A2F File Offset: 0x002FEC2F
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

		// Token: 0x06014B0C RID: 84748 RVA: 0x00300A38 File Offset: 0x002FEC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuResetRequest);
		}

		// Token: 0x06014B0D RID: 84749 RVA: 0x00300A46 File Offset: 0x002FEC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuResetRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B0E RID: 84750 RVA: 0x00300A74 File Offset: 0x002FEC74
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

		// Token: 0x06014B0F RID: 84751 RVA: 0x00300AB3 File Offset: 0x002FECB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B10 RID: 84752 RVA: 0x00300AC0 File Offset: 0x002FECC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B11 RID: 84753 RVA: 0x00300AC9 File Offset: 0x002FECC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B12 RID: 84754 RVA: 0x00300AFC File Offset: 0x002FECFC
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

		// Token: 0x06014B13 RID: 84755 RVA: 0x00300B3A File Offset: 0x002FED3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenjuResetRequest other)
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

		// Token: 0x06014B14 RID: 84756 RVA: 0x00300B6B File Offset: 0x002FED6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B15 RID: 84757 RVA: 0x00300B74 File Offset: 0x002FED74
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007D0C RID: 32012
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D0D RID: 32013
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04007D0E RID: 32014
		private long entityId_;
	}
}

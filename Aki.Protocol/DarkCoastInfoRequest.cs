using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039D RID: 925
	[NetMessage(EMessageId.DarkCoastInfoRequest)]
	public sealed class DarkCoastInfoRequest : IMessage<DarkCoastInfoRequest>, IMessage, IEquatable<DarkCoastInfoRequest>, IDeepCloneable<DarkCoastInfoRequest>, IBufferMessage
	{
		// Token: 0x06005B6A RID: 23402 RVA: 0x000DE8EC File Offset: 0x000DCAEC
		[NullableContext(1)]
		public static DarkCoastInfoRequest Create()
		{
			return new DarkCoastInfoRequest();
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06005B6B RID: 23403 RVA: 0x000DE8F3 File Offset: 0x000DCAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06005B6C RID: 23404 RVA: 0x000DE8F6 File Offset: 0x000DCAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkCoastInfoRequest.Descriptor;
			}
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x000DE8FD File Offset: 0x000DCAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkCoastInfoRequest()
		{
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x000DE905 File Offset: 0x000DCB05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkCoastInfoRequest(DarkCoastInfoRequest other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x000DE92A File Offset: 0x000DCB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkCoastInfoRequest Clone()
		{
			return new DarkCoastInfoRequest(this);
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06005B70 RID: 23408 RVA: 0x000DE932 File Offset: 0x000DCB32
		// (set) Token: 0x06005B71 RID: 23409 RVA: 0x000DE93A File Offset: 0x000DCB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x000DE943 File Offset: 0x000DCB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkCoastInfoRequest);
		}

		// Token: 0x06005B73 RID: 23411 RVA: 0x000DE951 File Offset: 0x000DCB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkCoastInfoRequest other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B74 RID: 23412 RVA: 0x000DE980 File Offset: 0x000DCB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x000DE9BF File Offset: 0x000DCBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x000DE9CC File Offset: 0x000DCBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x000DE9D5 File Offset: 0x000DCBD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x000DEA08 File Offset: 0x000DCC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B79 RID: 23417 RVA: 0x000DEA46 File Offset: 0x000DCC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkCoastInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x000DEA77 File Offset: 0x000DCC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x000DEA80 File Offset: 0x000DCC80
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
					this.DragonPoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003653 RID: 13907
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003654 RID: 13908
		public const int DragonPoolIdFieldNumber = 14;

		// Token: 0x04003655 RID: 13909
		private int dragonPoolId_;
	}
}

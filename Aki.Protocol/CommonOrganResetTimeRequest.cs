using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C2 RID: 706
	[NetMessage(EMessageId.CommonOrganResetTimeRequest)]
	public sealed class CommonOrganResetTimeRequest : IMessage<CommonOrganResetTimeRequest>, IMessage, IEquatable<CommonOrganResetTimeRequest>, IDeepCloneable<CommonOrganResetTimeRequest>, IBufferMessage
	{
		// Token: 0x060048F7 RID: 18679 RVA: 0x000B328C File Offset: 0x000B148C
		[NullableContext(1)]
		public static CommonOrganResetTimeRequest Create()
		{
			return new CommonOrganResetTimeRequest();
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060048F8 RID: 18680 RVA: 0x000B3293 File Offset: 0x000B1493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060048F9 RID: 18681 RVA: 0x000B3296 File Offset: 0x000B1496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonOrganResetTimeRequest.Descriptor;
			}
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x000B329D File Offset: 0x000B149D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeRequest()
		{
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x000B32A5 File Offset: 0x000B14A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeRequest(CommonOrganResetTimeRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x000B32CA File Offset: 0x000B14CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeRequest Clone()
		{
			return new CommonOrganResetTimeRequest(this);
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060048FD RID: 18685 RVA: 0x000B32D2 File Offset: 0x000B14D2
		// (set) Token: 0x060048FE RID: 18686 RVA: 0x000B32DA File Offset: 0x000B14DA
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

		// Token: 0x060048FF RID: 18687 RVA: 0x000B32E3 File Offset: 0x000B14E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonOrganResetTimeRequest);
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x000B32F1 File Offset: 0x000B14F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonOrganResetTimeRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x000B3320 File Offset: 0x000B1520
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

		// Token: 0x06004902 RID: 18690 RVA: 0x000B335F File Offset: 0x000B155F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x000B336C File Offset: 0x000B156C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x000B3375 File Offset: 0x000B1575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x000B33A8 File Offset: 0x000B15A8
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

		// Token: 0x06004906 RID: 18694 RVA: 0x000B33E6 File Offset: 0x000B15E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonOrganResetTimeRequest other)
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

		// Token: 0x06004907 RID: 18695 RVA: 0x000B3417 File Offset: 0x000B1617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x000B3420 File Offset: 0x000B1620
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003065 RID: 12389
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003066 RID: 12390
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04003067 RID: 12391
		private long entityId_;
	}
}

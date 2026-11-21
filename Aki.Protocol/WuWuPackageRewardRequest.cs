using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200159B RID: 5531
	[NetMessage(EMessageId.WuWuPackageRewardRequest)]
	public sealed class WuWuPackageRewardRequest : IMessage<WuWuPackageRewardRequest>, IMessage, IEquatable<WuWuPackageRewardRequest>, IDeepCloneable<WuWuPackageRewardRequest>, IBufferMessage
	{
		// Token: 0x0601D480 RID: 119936 RVA: 0x0043D5FF File Offset: 0x0043B7FF
		[NullableContext(1)]
		public static WuWuPackageRewardRequest Create()
		{
			return new WuWuPackageRewardRequest();
		}

		// Token: 0x17006316 RID: 25366
		// (get) Token: 0x0601D481 RID: 119937 RVA: 0x0043D606 File Offset: 0x0043B806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006317 RID: 25367
		// (get) Token: 0x0601D482 RID: 119938 RVA: 0x0043D609 File Offset: 0x0043B809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuPackageRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601D483 RID: 119939 RVA: 0x0043D610 File Offset: 0x0043B810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardRequest()
		{
		}

		// Token: 0x0601D484 RID: 119940 RVA: 0x0043D618 File Offset: 0x0043B818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardRequest(WuWuPackageRewardRequest other) : this()
		{
			this.wrapId_ = other.wrapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D485 RID: 119941 RVA: 0x0043D63D File Offset: 0x0043B83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardRequest Clone()
		{
			return new WuWuPackageRewardRequest(this);
		}

		// Token: 0x17006318 RID: 25368
		// (get) Token: 0x0601D486 RID: 119942 RVA: 0x0043D645 File Offset: 0x0043B845
		// (set) Token: 0x0601D487 RID: 119943 RVA: 0x0043D64D File Offset: 0x0043B84D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WrapId
		{
			get
			{
				return this.wrapId_;
			}
			set
			{
				this.wrapId_ = value;
			}
		}

		// Token: 0x0601D488 RID: 119944 RVA: 0x0043D656 File Offset: 0x0043B856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuPackageRewardRequest);
		}

		// Token: 0x0601D489 RID: 119945 RVA: 0x0043D664 File Offset: 0x0043B864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuPackageRewardRequest other)
		{
			return other != null && (other == this || (this.WrapId == other.WrapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D48A RID: 119946 RVA: 0x0043D694 File Offset: 0x0043B894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WrapId != 0)
			{
				num ^= this.WrapId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D48B RID: 119947 RVA: 0x0043D6D3 File Offset: 0x0043B8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D48C RID: 119948 RVA: 0x0043D6E0 File Offset: 0x0043B8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D48D RID: 119949 RVA: 0x0043D6E9 File Offset: 0x0043B8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WrapId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WrapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D48E RID: 119950 RVA: 0x0043D71C File Offset: 0x0043B91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WrapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WrapId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D48F RID: 119951 RVA: 0x0043D75A File Offset: 0x0043B95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuPackageRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WrapId != 0)
			{
				this.WrapId = other.WrapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D490 RID: 119952 RVA: 0x0043D78B File Offset: 0x0043B98B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D491 RID: 119953 RVA: 0x0043D794 File Offset: 0x0043B994
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WrapId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A7F8 RID: 43000
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A7F9 RID: 43001
		public const int WrapIdFieldNumber = 1;

		// Token: 0x0400A7FA RID: 43002
		private int wrapId_;
	}
}

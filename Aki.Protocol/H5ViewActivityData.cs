using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072E RID: 1838
	public sealed class H5ViewActivityData : IMessage<H5ViewActivityData>, IMessage, IEquatable<H5ViewActivityData>, IDeepCloneable<H5ViewActivityData>, IBufferMessage
	{
		// Token: 0x0600A6CC RID: 42700 RVA: 0x00191D72 File Offset: 0x0018FF72
		[NullableContext(1)]
		public static H5ViewActivityData Create()
		{
			return new H5ViewActivityData();
		}

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x0600A6CD RID: 42701 RVA: 0x00191D79 File Offset: 0x0018FF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x0600A6CE RID: 42702 RVA: 0x00191D7C File Offset: 0x0018FF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5ViewActivityData.Descriptor;
			}
		}

		// Token: 0x0600A6CF RID: 42703 RVA: 0x00191D83 File Offset: 0x0018FF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityData()
		{
		}

		// Token: 0x0600A6D0 RID: 42704 RVA: 0x00191D8B File Offset: 0x0018FF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityData(H5ViewActivityData other) : this()
		{
			this.redDot_ = other.redDot_;
			this.allRewardClaimed_ = other.allRewardClaimed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6D1 RID: 42705 RVA: 0x00191DBC File Offset: 0x0018FFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityData Clone()
		{
			return new H5ViewActivityData(this);
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x0600A6D2 RID: 42706 RVA: 0x00191DC4 File Offset: 0x0018FFC4
		// (set) Token: 0x0600A6D3 RID: 42707 RVA: 0x00191DCC File Offset: 0x0018FFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RedDot
		{
			get
			{
				return this.redDot_;
			}
			set
			{
				this.redDot_ = value;
			}
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x0600A6D4 RID: 42708 RVA: 0x00191DD5 File Offset: 0x0018FFD5
		// (set) Token: 0x0600A6D5 RID: 42709 RVA: 0x00191DDD File Offset: 0x0018FFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AllRewardClaimed
		{
			get
			{
				return this.allRewardClaimed_;
			}
			set
			{
				this.allRewardClaimed_ = value;
			}
		}

		// Token: 0x0600A6D6 RID: 42710 RVA: 0x00191DE6 File Offset: 0x0018FFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5ViewActivityData);
		}

		// Token: 0x0600A6D7 RID: 42711 RVA: 0x00191DF4 File Offset: 0x0018FFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5ViewActivityData other)
		{
			return other != null && (other == this || (this.RedDot == other.RedDot && this.AllRewardClaimed == other.AllRewardClaimed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6D8 RID: 42712 RVA: 0x00191E34 File Offset: 0x00190034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RedDot)
			{
				num ^= this.RedDot.GetHashCode();
			}
			if (this.AllRewardClaimed)
			{
				num ^= this.AllRewardClaimed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6D9 RID: 42713 RVA: 0x00191E8C File Offset: 0x0019008C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A6DA RID: 42714 RVA: 0x00191E99 File Offset: 0x00190099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6DB RID: 42715 RVA: 0x00191EA4 File Offset: 0x001900A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RedDot)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.RedDot);
			}
			if (this.AllRewardClaimed)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.AllRewardClaimed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6DC RID: 42716 RVA: 0x00191EFC File Offset: 0x001900FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RedDot)
			{
				num += 2;
			}
			if (this.AllRewardClaimed)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A6DD RID: 42717 RVA: 0x00191F3C File Offset: 0x0019013C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5ViewActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RedDot)
			{
				this.RedDot = other.RedDot;
			}
			if (other.AllRewardClaimed)
			{
				this.AllRewardClaimed = other.AllRewardClaimed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A6DE RID: 42718 RVA: 0x00191F8C File Offset: 0x0019018C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6DF RID: 42719 RVA: 0x00191F98 File Offset: 0x00190198
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AllRewardClaimed = input.ReadBool();
					}
				}
				else
				{
					this.RedDot = input.ReadBool();
				}
			}
		}

		// Token: 0x04004C69 RID: 19561
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C6A RID: 19562
		public const int RedDotFieldNumber = 1;

		// Token: 0x04004C6B RID: 19563
		private bool redDot_;

		// Token: 0x04004C6C RID: 19564
		public const int AllRewardClaimedFieldNumber = 2;

		// Token: 0x04004C6D RID: 19565
		private bool allRewardClaimed_;
	}
}

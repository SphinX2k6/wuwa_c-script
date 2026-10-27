using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B2 RID: 5298
	public sealed class UseItemProgress : IMessage<UseItemProgress>, IMessage, IEquatable<UseItemProgress>, IDeepCloneable<UseItemProgress>, IBufferMessage
	{
		// Token: 0x0601C047 RID: 114759 RVA: 0x0040CA93 File Offset: 0x0040AC93
		[NullableContext(1)]
		public static UseItemProgress Create()
		{
			return new UseItemProgress();
		}

		// Token: 0x17005E6B RID: 24171
		// (get) Token: 0x0601C048 RID: 114760 RVA: 0x0040CA9A File Offset: 0x0040AC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E6C RID: 24172
		// (get) Token: 0x0601C049 RID: 114761 RVA: 0x0040CA9D File Offset: 0x0040AC9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseItemProgress.Descriptor;
			}
		}

		// Token: 0x0601C04A RID: 114762 RVA: 0x0040CAA4 File Offset: 0x0040ACA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemProgress()
		{
		}

		// Token: 0x0601C04B RID: 114763 RVA: 0x0040CAAC File Offset: 0x0040ACAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemProgress(UseItemProgress other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C04C RID: 114764 RVA: 0x0040CADD File Offset: 0x0040ACDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemProgress Clone()
		{
			return new UseItemProgress(this);
		}

		// Token: 0x17005E6D RID: 24173
		// (get) Token: 0x0601C04D RID: 114765 RVA: 0x0040CAE5 File Offset: 0x0040ACE5
		// (set) Token: 0x0601C04E RID: 114766 RVA: 0x0040CAED File Offset: 0x0040ACED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17005E6E RID: 24174
		// (get) Token: 0x0601C04F RID: 114767 RVA: 0x0040CAF6 File Offset: 0x0040ACF6
		// (set) Token: 0x0601C050 RID: 114768 RVA: 0x0040CAFE File Offset: 0x0040ACFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x0601C051 RID: 114769 RVA: 0x0040CB07 File Offset: 0x0040AD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseItemProgress);
		}

		// Token: 0x0601C052 RID: 114770 RVA: 0x0040CB15 File Offset: 0x0040AD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseItemProgress other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C053 RID: 114771 RVA: 0x0040CB54 File Offset: 0x0040AD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C054 RID: 114772 RVA: 0x0040CBAC File Offset: 0x0040ADAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C055 RID: 114773 RVA: 0x0040CBB9 File Offset: 0x0040ADB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C056 RID: 114774 RVA: 0x0040CBC4 File Offset: 0x0040ADC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C057 RID: 114775 RVA: 0x0040CC1C File Offset: 0x0040AE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C058 RID: 114776 RVA: 0x0040CC74 File Offset: 0x0040AE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseItemProgress other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C059 RID: 114777 RVA: 0x0040CCC4 File Offset: 0x0040AEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C05A RID: 114778 RVA: 0x0040CCD0 File Offset: 0x0040AED0
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A0E7 RID: 41191
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0E8 RID: 41192
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400A0E9 RID: 41193
		private int itemId_;

		// Token: 0x0400A0EA RID: 41194
		public const int CountFieldNumber = 2;

		// Token: 0x0400A0EB RID: 41195
		private int count_;
	}
}

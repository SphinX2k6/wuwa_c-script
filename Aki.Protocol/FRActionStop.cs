using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000640 RID: 1600
	public sealed class FRActionStop : IMessage<FRActionStop>, IMessage, IEquatable<FRActionStop>, IDeepCloneable<FRActionStop>, IBufferMessage
	{
		// Token: 0x06009361 RID: 37729 RVA: 0x00164908 File Offset: 0x00162B08
		[NullableContext(1)]
		public static FRActionStop Create()
		{
			return new FRActionStop();
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06009362 RID: 37730 RVA: 0x0016490F File Offset: 0x00162B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06009363 RID: 37731 RVA: 0x00164912 File Offset: 0x00162B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRActionStop.Descriptor;
			}
		}

		// Token: 0x06009364 RID: 37732 RVA: 0x00164919 File Offset: 0x00162B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStop()
		{
		}

		// Token: 0x06009365 RID: 37733 RVA: 0x0016492C File Offset: 0x00162B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStop(FRActionStop other) : this()
		{
			this.textKey_ = other.textKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009366 RID: 37734 RVA: 0x00164951 File Offset: 0x00162B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStop Clone()
		{
			return new FRActionStop(this);
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06009367 RID: 37735 RVA: 0x00164959 File Offset: 0x00162B59
		// (set) Token: 0x06009368 RID: 37736 RVA: 0x00164961 File Offset: 0x00162B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TextKey
		{
			get
			{
				return this.textKey_;
			}
			set
			{
				this.textKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06009369 RID: 37737 RVA: 0x00164974 File Offset: 0x00162B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRActionStop);
		}

		// Token: 0x0600936A RID: 37738 RVA: 0x00164982 File Offset: 0x00162B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRActionStop other)
		{
			return other != null && (other == this || (!(this.TextKey != other.TextKey) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600936B RID: 37739 RVA: 0x001649B8 File Offset: 0x00162BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TextKey.Length != 0)
			{
				num ^= this.TextKey.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600936C RID: 37740 RVA: 0x001649F9 File Offset: 0x00162BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600936D RID: 37741 RVA: 0x00164A06 File Offset: 0x00162C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600936E RID: 37742 RVA: 0x00164A0F File Offset: 0x00162C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TextKey.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TextKey);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600936F RID: 37743 RVA: 0x00164A48 File Offset: 0x00162C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TextKey.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TextKey);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009370 RID: 37744 RVA: 0x00164A8B File Offset: 0x00162C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRActionStop other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TextKey.Length != 0)
			{
				this.TextKey = other.TextKey;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009371 RID: 37745 RVA: 0x00164AC1 File Offset: 0x00162CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009372 RID: 37746 RVA: 0x00164ACC File Offset: 0x00162CCC
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TextKey = input.ReadString();
				}
			}
		}

		// Token: 0x040046E4 RID: 18148
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046E5 RID: 18149
		public const int TextKeyFieldNumber = 1;

		// Token: 0x040046E6 RID: 18150
		private string textKey_ = "";
	}
}

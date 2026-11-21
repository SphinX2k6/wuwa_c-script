using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062C RID: 1580
	public sealed class FRActionStop : IMessage<FRActionStop>, IMessage, IEquatable<FRActionStop>, IDeepCloneable<FRActionStop>, IBufferMessage
	{
		// Token: 0x0600920B RID: 37387 RVA: 0x00161EDC File Offset: 0x001600DC
		[NullableContext(1)]
		public static FRActionStop Create()
		{
			return new FRActionStop();
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x0600920C RID: 37388 RVA: 0x00161EE3 File Offset: 0x001600E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x0600920D RID: 37389 RVA: 0x00161EE6 File Offset: 0x001600E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRActionStop.Descriptor;
			}
		}

		// Token: 0x0600920E RID: 37390 RVA: 0x00161EED File Offset: 0x001600ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStop()
		{
		}

		// Token: 0x0600920F RID: 37391 RVA: 0x00161F00 File Offset: 0x00160100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStop(FRActionStop other) : this()
		{
			this.textKey_ = other.textKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x00161F25 File Offset: 0x00160125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionStop Clone()
		{
			return new FRActionStop(this);
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06009211 RID: 37393 RVA: 0x00161F2D File Offset: 0x0016012D
		// (set) Token: 0x06009212 RID: 37394 RVA: 0x00161F35 File Offset: 0x00160135
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

		// Token: 0x06009213 RID: 37395 RVA: 0x00161F48 File Offset: 0x00160148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRActionStop);
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x00161F56 File Offset: 0x00160156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRActionStop other)
		{
			return other != null && (other == this || (!(this.TextKey != other.TextKey) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x00161F8C File Offset: 0x0016018C
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

		// Token: 0x06009216 RID: 37398 RVA: 0x00161FCD File Offset: 0x001601CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x00161FDA File Offset: 0x001601DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009218 RID: 37400 RVA: 0x00161FE3 File Offset: 0x001601E3
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

		// Token: 0x06009219 RID: 37401 RVA: 0x0016201C File Offset: 0x0016021C
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

		// Token: 0x0600921A RID: 37402 RVA: 0x0016205F File Offset: 0x0016025F
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

		// Token: 0x0600921B RID: 37403 RVA: 0x00162095 File Offset: 0x00160295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600921C RID: 37404 RVA: 0x001620A0 File Offset: 0x001602A0
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

		// Token: 0x040046DD RID: 18141
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046DE RID: 18142
		public const int TextKeyFieldNumber = 1;

		// Token: 0x040046DF RID: 18143
		private string textKey_ = "";
	}
}

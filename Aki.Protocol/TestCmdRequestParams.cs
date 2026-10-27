using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001350 RID: 4944
	public sealed class TestCmdRequestParams : IMessage<TestCmdRequestParams>, IMessage, IEquatable<TestCmdRequestParams>, IDeepCloneable<TestCmdRequestParams>, IBufferMessage
	{
		// Token: 0x0601A444 RID: 107588 RVA: 0x003D0E75 File Offset: 0x003CF075
		[NullableContext(1)]
		public static TestCmdRequestParams Create()
		{
			return new TestCmdRequestParams();
		}

		// Token: 0x1700589E RID: 22686
		// (get) Token: 0x0601A445 RID: 107589 RVA: 0x003D0E7C File Offset: 0x003CF07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700589F RID: 22687
		// (get) Token: 0x0601A446 RID: 107590 RVA: 0x003D0E7F File Offset: 0x003CF07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestCmdRequestParams.Descriptor;
			}
		}

		// Token: 0x0601A447 RID: 107591 RVA: 0x003D0E86 File Offset: 0x003CF086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdRequestParams()
		{
		}

		// Token: 0x0601A448 RID: 107592 RVA: 0x003D0E99 File Offset: 0x003CF099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdRequestParams(TestCmdRequestParams other) : this()
		{
			this.messageId_ = other.messageId_;
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A449 RID: 107593 RVA: 0x003D0ECA File Offset: 0x003CF0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdRequestParams Clone()
		{
			return new TestCmdRequestParams(this);
		}

		// Token: 0x170058A0 RID: 22688
		// (get) Token: 0x0601A44A RID: 107594 RVA: 0x003D0ED2 File Offset: 0x003CF0D2
		// (set) Token: 0x0601A44B RID: 107595 RVA: 0x003D0EDA File Offset: 0x003CF0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MessageId
		{
			get
			{
				return this.messageId_;
			}
			set
			{
				this.messageId_ = value;
			}
		}

		// Token: 0x170058A1 RID: 22689
		// (get) Token: 0x0601A44C RID: 107596 RVA: 0x003D0EE3 File Offset: 0x003CF0E3
		// (set) Token: 0x0601A44D RID: 107597 RVA: 0x003D0EEB File Offset: 0x003CF0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x0601A44E RID: 107598 RVA: 0x003D0EFE File Offset: 0x003CF0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestCmdRequestParams);
		}

		// Token: 0x0601A44F RID: 107599 RVA: 0x003D0F0C File Offset: 0x003CF10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestCmdRequestParams other)
		{
			return other != null && (other == this || (this.MessageId == other.MessageId && !(this.Data != other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A450 RID: 107600 RVA: 0x003D0F5C File Offset: 0x003CF15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MessageId != 0)
			{
				num ^= this.MessageId.GetHashCode();
			}
			if (this.Data.Length != 0)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A451 RID: 107601 RVA: 0x003D0FB6 File Offset: 0x003CF1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A452 RID: 107602 RVA: 0x003D0FC3 File Offset: 0x003CF1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A453 RID: 107603 RVA: 0x003D0FCC File Offset: 0x003CF1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MessageId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MessageId);
			}
			if (this.Data.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A454 RID: 107604 RVA: 0x003D102C File Offset: 0x003CF22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MessageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MessageId);
			}
			if (this.Data.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A455 RID: 107605 RVA: 0x003D1088 File Offset: 0x003CF288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TestCmdRequestParams other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MessageId != 0)
			{
				this.MessageId = other.MessageId;
			}
			if (other.Data.Length != 0)
			{
				this.Data = other.Data;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A456 RID: 107606 RVA: 0x003D10DD File Offset: 0x003CF2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A457 RID: 107607 RVA: 0x003D10E8 File Offset: 0x003CF2E8
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Data = input.ReadBytes();
					}
				}
				else
				{
					this.MessageId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009931 RID: 39217
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009932 RID: 39218
		public const int MessageIdFieldNumber = 1;

		// Token: 0x04009933 RID: 39219
		private int messageId_;

		// Token: 0x04009934 RID: 39220
		public const int DataFieldNumber = 2;

		// Token: 0x04009935 RID: 39221
		private ByteString data_ = ByteString.Empty;
	}
}

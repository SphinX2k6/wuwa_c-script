using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C3 RID: 5059
	public sealed class TestCmdRequestParams : IMessage<TestCmdRequestParams>, IMessage, IEquatable<TestCmdRequestParams>, IDeepCloneable<TestCmdRequestParams>, IBufferMessage
	{
		// Token: 0x0601AECB RID: 110283 RVA: 0x003EBFA4 File Offset: 0x003EA1A4
		[NullableContext(1)]
		public static TestCmdRequestParams Create()
		{
			return new TestCmdRequestParams();
		}

		// Token: 0x17005B31 RID: 23345
		// (get) Token: 0x0601AECC RID: 110284 RVA: 0x003EBFAB File Offset: 0x003EA1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B32 RID: 23346
		// (get) Token: 0x0601AECD RID: 110285 RVA: 0x003EBFAE File Offset: 0x003EA1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestCmdRequestParams.Descriptor;
			}
		}

		// Token: 0x0601AECE RID: 110286 RVA: 0x003EBFB5 File Offset: 0x003EA1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdRequestParams()
		{
		}

		// Token: 0x0601AECF RID: 110287 RVA: 0x003EBFC8 File Offset: 0x003EA1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdRequestParams(TestCmdRequestParams other) : this()
		{
			this.messageId_ = other.messageId_;
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AED0 RID: 110288 RVA: 0x003EBFF9 File Offset: 0x003EA1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdRequestParams Clone()
		{
			return new TestCmdRequestParams(this);
		}

		// Token: 0x17005B33 RID: 23347
		// (get) Token: 0x0601AED1 RID: 110289 RVA: 0x003EC001 File Offset: 0x003EA201
		// (set) Token: 0x0601AED2 RID: 110290 RVA: 0x003EC009 File Offset: 0x003EA209
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

		// Token: 0x17005B34 RID: 23348
		// (get) Token: 0x0601AED3 RID: 110291 RVA: 0x003EC012 File Offset: 0x003EA212
		// (set) Token: 0x0601AED4 RID: 110292 RVA: 0x003EC01A File Offset: 0x003EA21A
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

		// Token: 0x0601AED5 RID: 110293 RVA: 0x003EC02D File Offset: 0x003EA22D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestCmdRequestParams);
		}

		// Token: 0x0601AED6 RID: 110294 RVA: 0x003EC03C File Offset: 0x003EA23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestCmdRequestParams other)
		{
			return other != null && (other == this || (this.MessageId == other.MessageId && !(this.Data != other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AED7 RID: 110295 RVA: 0x003EC08C File Offset: 0x003EA28C
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

		// Token: 0x0601AED8 RID: 110296 RVA: 0x003EC0E6 File Offset: 0x003EA2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AED9 RID: 110297 RVA: 0x003EC0F3 File Offset: 0x003EA2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AEDA RID: 110298 RVA: 0x003EC0FC File Offset: 0x003EA2FC
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

		// Token: 0x0601AEDB RID: 110299 RVA: 0x003EC15C File Offset: 0x003EA35C
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

		// Token: 0x0601AEDC RID: 110300 RVA: 0x003EC1B8 File Offset: 0x003EA3B8
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

		// Token: 0x0601AEDD RID: 110301 RVA: 0x003EC20D File Offset: 0x003EA40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AEDE RID: 110302 RVA: 0x003EC218 File Offset: 0x003EA418
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

		// Token: 0x04009D73 RID: 40307
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D74 RID: 40308
		public const int MessageIdFieldNumber = 1;

		// Token: 0x04009D75 RID: 40309
		private int messageId_;

		// Token: 0x04009D76 RID: 40310
		public const int DataFieldNumber = 2;

		// Token: 0x04009D77 RID: 40311
		private ByteString data_ = ByteString.Empty;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134D RID: 4941
	public sealed class TestCmdCompleteParams : IMessage<TestCmdCompleteParams>, IMessage, IEquatable<TestCmdCompleteParams>, IDeepCloneable<TestCmdCompleteParams>, IBufferMessage
	{
		// Token: 0x0601A406 RID: 107526 RVA: 0x003D051C File Offset: 0x003CE71C
		[NullableContext(1)]
		public static TestCmdCompleteParams Create()
		{
			return new TestCmdCompleteParams();
		}

		// Token: 0x17005891 RID: 22673
		// (get) Token: 0x0601A407 RID: 107527 RVA: 0x003D0523 File Offset: 0x003CE723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005892 RID: 22674
		// (get) Token: 0x0601A408 RID: 107528 RVA: 0x003D0526 File Offset: 0x003CE726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestCmdCompleteParams.Descriptor;
			}
		}

		// Token: 0x0601A409 RID: 107529 RVA: 0x003D052D File Offset: 0x003CE72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdCompleteParams()
		{
		}

		// Token: 0x0601A40A RID: 107530 RVA: 0x003D0535 File Offset: 0x003CE735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdCompleteParams(TestCmdCompleteParams other) : this()
		{
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A40B RID: 107531 RVA: 0x003D055A File Offset: 0x003CE75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdCompleteParams Clone()
		{
			return new TestCmdCompleteParams(this);
		}

		// Token: 0x17005893 RID: 22675
		// (get) Token: 0x0601A40C RID: 107532 RVA: 0x003D0562 File Offset: 0x003CE762
		// (set) Token: 0x0601A40D RID: 107533 RVA: 0x003D056A File Offset: 0x003CE76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x0601A40E RID: 107534 RVA: 0x003D0573 File Offset: 0x003CE773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestCmdCompleteParams);
		}

		// Token: 0x0601A40F RID: 107535 RVA: 0x003D0581 File Offset: 0x003CE781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestCmdCompleteParams other)
		{
			return other != null && (other == this || (this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A410 RID: 107536 RVA: 0x003D05B0 File Offset: 0x003CE7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Result)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A411 RID: 107537 RVA: 0x003D05EF File Offset: 0x003CE7EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A412 RID: 107538 RVA: 0x003D05FC File Offset: 0x003CE7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A413 RID: 107539 RVA: 0x003D0605 File Offset: 0x003CE805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Result)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A414 RID: 107540 RVA: 0x003D0638 File Offset: 0x003CE838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Result)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A415 RID: 107541 RVA: 0x003D066A File Offset: 0x003CE86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TestCmdCompleteParams other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Result)
			{
				this.Result = other.Result;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A416 RID: 107542 RVA: 0x003D069B File Offset: 0x003CE89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A417 RID: 107543 RVA: 0x003D06A4 File Offset: 0x003CE8A4
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
					this.Result = input.ReadBool();
				}
			}
		}

		// Token: 0x04009922 RID: 39202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009923 RID: 39203
		public const int ResultFieldNumber = 1;

		// Token: 0x04009924 RID: 39204
		private bool result_;
	}
}

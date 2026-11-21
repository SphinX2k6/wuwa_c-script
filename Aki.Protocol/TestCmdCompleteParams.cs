using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C0 RID: 5056
	public sealed class TestCmdCompleteParams : IMessage<TestCmdCompleteParams>, IMessage, IEquatable<TestCmdCompleteParams>, IDeepCloneable<TestCmdCompleteParams>, IBufferMessage
	{
		// Token: 0x0601AE8D RID: 110221 RVA: 0x003EB64C File Offset: 0x003E984C
		[NullableContext(1)]
		public static TestCmdCompleteParams Create()
		{
			return new TestCmdCompleteParams();
		}

		// Token: 0x17005B24 RID: 23332
		// (get) Token: 0x0601AE8E RID: 110222 RVA: 0x003EB653 File Offset: 0x003E9853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B25 RID: 23333
		// (get) Token: 0x0601AE8F RID: 110223 RVA: 0x003EB656 File Offset: 0x003E9856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestCmdCompleteParams.Descriptor;
			}
		}

		// Token: 0x0601AE90 RID: 110224 RVA: 0x003EB65D File Offset: 0x003E985D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdCompleteParams()
		{
		}

		// Token: 0x0601AE91 RID: 110225 RVA: 0x003EB665 File Offset: 0x003E9865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdCompleteParams(TestCmdCompleteParams other) : this()
		{
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE92 RID: 110226 RVA: 0x003EB68A File Offset: 0x003E988A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdCompleteParams Clone()
		{
			return new TestCmdCompleteParams(this);
		}

		// Token: 0x17005B26 RID: 23334
		// (get) Token: 0x0601AE93 RID: 110227 RVA: 0x003EB692 File Offset: 0x003E9892
		// (set) Token: 0x0601AE94 RID: 110228 RVA: 0x003EB69A File Offset: 0x003E989A
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

		// Token: 0x0601AE95 RID: 110229 RVA: 0x003EB6A3 File Offset: 0x003E98A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestCmdCompleteParams);
		}

		// Token: 0x0601AE96 RID: 110230 RVA: 0x003EB6B1 File Offset: 0x003E98B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestCmdCompleteParams other)
		{
			return other != null && (other == this || (this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE97 RID: 110231 RVA: 0x003EB6E0 File Offset: 0x003E98E0
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

		// Token: 0x0601AE98 RID: 110232 RVA: 0x003EB71F File Offset: 0x003E991F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE99 RID: 110233 RVA: 0x003EB72C File Offset: 0x003E992C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE9A RID: 110234 RVA: 0x003EB735 File Offset: 0x003E9935
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

		// Token: 0x0601AE9B RID: 110235 RVA: 0x003EB768 File Offset: 0x003E9968
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

		// Token: 0x0601AE9C RID: 110236 RVA: 0x003EB79A File Offset: 0x003E999A
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

		// Token: 0x0601AE9D RID: 110237 RVA: 0x003EB7CB File Offset: 0x003E99CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE9E RID: 110238 RVA: 0x003EB7D4 File Offset: 0x003E99D4
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

		// Token: 0x04009D64 RID: 40292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D65 RID: 40293
		public const int ResultFieldNumber = 1;

		// Token: 0x04009D66 RID: 40294
		private bool result_;
	}
}

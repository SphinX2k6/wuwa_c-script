using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134E RID: 4942
	public sealed class TestCmdGmParams : IMessage<TestCmdGmParams>, IMessage, IEquatable<TestCmdGmParams>, IDeepCloneable<TestCmdGmParams>, IBufferMessage
	{
		// Token: 0x0601A418 RID: 107544 RVA: 0x003D06E8 File Offset: 0x003CE8E8
		[NullableContext(1)]
		public static TestCmdGmParams Create()
		{
			return new TestCmdGmParams();
		}

		// Token: 0x17005894 RID: 22676
		// (get) Token: 0x0601A419 RID: 107545 RVA: 0x003D06EF File Offset: 0x003CE8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005895 RID: 22677
		// (get) Token: 0x0601A41A RID: 107546 RVA: 0x003D06F2 File Offset: 0x003CE8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestCmdGmParams.Descriptor;
			}
		}

		// Token: 0x0601A41B RID: 107547 RVA: 0x003D06F9 File Offset: 0x003CE8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdGmParams()
		{
		}

		// Token: 0x0601A41C RID: 107548 RVA: 0x003D0717 File Offset: 0x003CE917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdGmParams(TestCmdGmParams other) : this()
		{
			this.funcName_ = other.funcName_;
			this.args_ = other.args_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A41D RID: 107549 RVA: 0x003D074D File Offset: 0x003CE94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdGmParams Clone()
		{
			return new TestCmdGmParams(this);
		}

		// Token: 0x17005896 RID: 22678
		// (get) Token: 0x0601A41E RID: 107550 RVA: 0x003D0755 File Offset: 0x003CE955
		// (set) Token: 0x0601A41F RID: 107551 RVA: 0x003D075D File Offset: 0x003CE95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FuncName
		{
			get
			{
				return this.funcName_;
			}
			set
			{
				this.funcName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005897 RID: 22679
		// (get) Token: 0x0601A420 RID: 107552 RVA: 0x003D0770 File Offset: 0x003CE970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Args
		{
			get
			{
				return this.args_;
			}
		}

		// Token: 0x0601A421 RID: 107553 RVA: 0x003D0778 File Offset: 0x003CE978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestCmdGmParams);
		}

		// Token: 0x0601A422 RID: 107554 RVA: 0x003D0788 File Offset: 0x003CE988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestCmdGmParams other)
		{
			return other != null && (other == this || (!(this.FuncName != other.FuncName) && this.args_.Equals(other.args_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A423 RID: 107555 RVA: 0x003D07DC File Offset: 0x003CE9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FuncName.Length != 0)
			{
				num ^= this.FuncName.GetHashCode();
			}
			num ^= this.args_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A424 RID: 107556 RVA: 0x003D082B File Offset: 0x003CEA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A425 RID: 107557 RVA: 0x003D0838 File Offset: 0x003CEA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A426 RID: 107558 RVA: 0x003D0844 File Offset: 0x003CEA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FuncName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.FuncName);
			}
			this.args_.WriteTo(ref output, TestCmdGmParams._repeated_args_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A427 RID: 107559 RVA: 0x003D0898 File Offset: 0x003CEA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FuncName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FuncName);
			}
			num += this.args_.CalculateSize(TestCmdGmParams._repeated_args_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A428 RID: 107560 RVA: 0x003D08F0 File Offset: 0x003CEAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TestCmdGmParams other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FuncName.Length != 0)
			{
				this.FuncName = other.FuncName;
			}
			this.args_.Add(other.args_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A429 RID: 107561 RVA: 0x003D0942 File Offset: 0x003CEB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A42A RID: 107562 RVA: 0x003D094C File Offset: 0x003CEB4C
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.args_.AddEntriesFrom(ref input, TestCmdGmParams._repeated_args_codec);
					}
				}
				else
				{
					this.FuncName = input.ReadString();
				}
			}
		}

		// Token: 0x04009925 RID: 39205
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009926 RID: 39206
		public const int FuncNameFieldNumber = 1;

		// Token: 0x04009927 RID: 39207
		private string funcName_ = "";

		// Token: 0x04009928 RID: 39208
		public const int ArgsFieldNumber = 2;

		// Token: 0x04009929 RID: 39209
		private static readonly FieldCodec<string> _repeated_args_codec = FieldCodec.ForString(18U);

		// Token: 0x0400992A RID: 39210
		private readonly RepeatedField<string> args_ = new RepeatedField<string>();
	}
}

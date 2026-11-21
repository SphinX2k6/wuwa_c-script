using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C1 RID: 5057
	public sealed class TestCmdGmParams : IMessage<TestCmdGmParams>, IMessage, IEquatable<TestCmdGmParams>, IDeepCloneable<TestCmdGmParams>, IBufferMessage
	{
		// Token: 0x0601AE9F RID: 110239 RVA: 0x003EB818 File Offset: 0x003E9A18
		[NullableContext(1)]
		public static TestCmdGmParams Create()
		{
			return new TestCmdGmParams();
		}

		// Token: 0x17005B27 RID: 23335
		// (get) Token: 0x0601AEA0 RID: 110240 RVA: 0x003EB81F File Offset: 0x003E9A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B28 RID: 23336
		// (get) Token: 0x0601AEA1 RID: 110241 RVA: 0x003EB822 File Offset: 0x003E9A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestCmdGmParams.Descriptor;
			}
		}

		// Token: 0x0601AEA2 RID: 110242 RVA: 0x003EB829 File Offset: 0x003E9A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdGmParams()
		{
		}

		// Token: 0x0601AEA3 RID: 110243 RVA: 0x003EB847 File Offset: 0x003E9A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdGmParams(TestCmdGmParams other) : this()
		{
			this.funcName_ = other.funcName_;
			this.args_ = other.args_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AEA4 RID: 110244 RVA: 0x003EB87D File Offset: 0x003E9A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdGmParams Clone()
		{
			return new TestCmdGmParams(this);
		}

		// Token: 0x17005B29 RID: 23337
		// (get) Token: 0x0601AEA5 RID: 110245 RVA: 0x003EB885 File Offset: 0x003E9A85
		// (set) Token: 0x0601AEA6 RID: 110246 RVA: 0x003EB88D File Offset: 0x003E9A8D
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

		// Token: 0x17005B2A RID: 23338
		// (get) Token: 0x0601AEA7 RID: 110247 RVA: 0x003EB8A0 File Offset: 0x003E9AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Args
		{
			get
			{
				return this.args_;
			}
		}

		// Token: 0x0601AEA8 RID: 110248 RVA: 0x003EB8A8 File Offset: 0x003E9AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestCmdGmParams);
		}

		// Token: 0x0601AEA9 RID: 110249 RVA: 0x003EB8B8 File Offset: 0x003E9AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestCmdGmParams other)
		{
			return other != null && (other == this || (!(this.FuncName != other.FuncName) && this.args_.Equals(other.args_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AEAA RID: 110250 RVA: 0x003EB90C File Offset: 0x003E9B0C
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

		// Token: 0x0601AEAB RID: 110251 RVA: 0x003EB95B File Offset: 0x003E9B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AEAC RID: 110252 RVA: 0x003EB968 File Offset: 0x003E9B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AEAD RID: 110253 RVA: 0x003EB974 File Offset: 0x003E9B74
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

		// Token: 0x0601AEAE RID: 110254 RVA: 0x003EB9C8 File Offset: 0x003E9BC8
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

		// Token: 0x0601AEAF RID: 110255 RVA: 0x003EBA20 File Offset: 0x003E9C20
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

		// Token: 0x0601AEB0 RID: 110256 RVA: 0x003EBA72 File Offset: 0x003E9C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AEB1 RID: 110257 RVA: 0x003EBA7C File Offset: 0x003E9C7C
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

		// Token: 0x04009D67 RID: 40295
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D68 RID: 40296
		public const int FuncNameFieldNumber = 1;

		// Token: 0x04009D69 RID: 40297
		private string funcName_ = "";

		// Token: 0x04009D6A RID: 40298
		public const int ArgsFieldNumber = 2;

		// Token: 0x04009D6B RID: 40299
		private static readonly FieldCodec<string> _repeated_args_codec = FieldCodec.ForString(18U);

		// Token: 0x04009D6C RID: 40300
		private readonly RepeatedField<string> args_ = new RepeatedField<string>();
	}
}

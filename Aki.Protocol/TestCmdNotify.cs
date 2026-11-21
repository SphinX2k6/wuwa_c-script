using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C2 RID: 5058
	[NetMessage(EMessageId.TestCmdNotify)]
	public sealed class TestCmdNotify : IMessage<TestCmdNotify>, IMessage, IEquatable<TestCmdNotify>, IDeepCloneable<TestCmdNotify>, IBufferMessage
	{
		// Token: 0x0601AEB3 RID: 110259 RVA: 0x003EBAE7 File Offset: 0x003E9CE7
		[NullableContext(1)]
		public static TestCmdNotify Create()
		{
			return new TestCmdNotify();
		}

		// Token: 0x17005B2B RID: 23339
		// (get) Token: 0x0601AEB4 RID: 110260 RVA: 0x003EBAEE File Offset: 0x003E9CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B2C RID: 23340
		// (get) Token: 0x0601AEB5 RID: 110261 RVA: 0x003EBAF1 File Offset: 0x003E9CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestCmdNotify.Descriptor;
			}
		}

		// Token: 0x0601AEB6 RID: 110262 RVA: 0x003EBAF8 File Offset: 0x003E9CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdNotify()
		{
		}

		// Token: 0x0601AEB7 RID: 110263 RVA: 0x003EBB00 File Offset: 0x003E9D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdNotify(TestCmdNotify other) : this()
		{
			TestCmdNotify.CmdOneofCase cmdCase = other.CmdCase;
			if (cmdCase != TestCmdNotify.CmdOneofCase.Complete)
			{
				if (cmdCase != TestCmdNotify.CmdOneofCase.Request)
				{
					if (cmdCase == TestCmdNotify.CmdOneofCase.Gm)
					{
						this.Gm = other.Gm.Clone();
					}
				}
				else
				{
					this.Request = other.Request.Clone();
				}
			}
			else
			{
				this.Complete = other.Complete.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AEB8 RID: 110264 RVA: 0x003EBB71 File Offset: 0x003E9D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdNotify Clone()
		{
			return new TestCmdNotify(this);
		}

		// Token: 0x17005B2D RID: 23341
		// (get) Token: 0x0601AEB9 RID: 110265 RVA: 0x003EBB79 File Offset: 0x003E9D79
		// (set) Token: 0x0601AEBA RID: 110266 RVA: 0x003EBB91 File Offset: 0x003E9D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdRequestParams Request
		{
			get
			{
				if (this.cmdCase_ != TestCmdNotify.CmdOneofCase.Request)
				{
					return null;
				}
				return (TestCmdRequestParams)this.cmd_;
			}
			set
			{
				this.cmd_ = value;
				this.cmdCase_ = ((value == null) ? TestCmdNotify.CmdOneofCase.None : TestCmdNotify.CmdOneofCase.Request);
			}
		}

		// Token: 0x17005B2E RID: 23342
		// (get) Token: 0x0601AEBB RID: 110267 RVA: 0x003EBBA7 File Offset: 0x003E9DA7
		// (set) Token: 0x0601AEBC RID: 110268 RVA: 0x003EBBC0 File Offset: 0x003E9DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdGmParams Gm
		{
			get
			{
				if (this.cmdCase_ != TestCmdNotify.CmdOneofCase.Gm)
				{
					return null;
				}
				return (TestCmdGmParams)this.cmd_;
			}
			set
			{
				this.cmd_ = value;
				this.cmdCase_ = ((value == null) ? TestCmdNotify.CmdOneofCase.None : TestCmdNotify.CmdOneofCase.Gm);
			}
		}

		// Token: 0x17005B2F RID: 23343
		// (get) Token: 0x0601AEBD RID: 110269 RVA: 0x003EBBD7 File Offset: 0x003E9DD7
		// (set) Token: 0x0601AEBE RID: 110270 RVA: 0x003EBBEF File Offset: 0x003E9DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdCompleteParams Complete
		{
			get
			{
				if (this.cmdCase_ != TestCmdNotify.CmdOneofCase.Complete)
				{
					return null;
				}
				return (TestCmdCompleteParams)this.cmd_;
			}
			set
			{
				this.cmd_ = value;
				this.cmdCase_ = ((value == null) ? TestCmdNotify.CmdOneofCase.None : TestCmdNotify.CmdOneofCase.Complete);
			}
		}

		// Token: 0x17005B30 RID: 23344
		// (get) Token: 0x0601AEBF RID: 110271 RVA: 0x003EBC05 File Offset: 0x003E9E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdNotify.CmdOneofCase CmdCase
		{
			get
			{
				return this.cmdCase_;
			}
		}

		// Token: 0x0601AEC0 RID: 110272 RVA: 0x003EBC0D File Offset: 0x003E9E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCmd()
		{
			this.cmdCase_ = TestCmdNotify.CmdOneofCase.None;
			this.cmd_ = null;
		}

		// Token: 0x0601AEC1 RID: 110273 RVA: 0x003EBC1D File Offset: 0x003E9E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestCmdNotify);
		}

		// Token: 0x0601AEC2 RID: 110274 RVA: 0x003EBC2C File Offset: 0x003E9E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestCmdNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Request, other.Request) && object.Equals(this.Gm, other.Gm) && object.Equals(this.Complete, other.Complete) && this.CmdCase == other.CmdCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AEC3 RID: 110275 RVA: 0x003EBCA4 File Offset: 0x003E9EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Request)
			{
				num ^= this.Request.GetHashCode();
			}
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Gm)
			{
				num ^= this.Gm.GetHashCode();
			}
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Complete)
			{
				num ^= this.Complete.GetHashCode();
			}
			num ^= (int)this.cmdCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AEC4 RID: 110276 RVA: 0x003EBD19 File Offset: 0x003E9F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AEC5 RID: 110277 RVA: 0x003EBD26 File Offset: 0x003E9F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AEC6 RID: 110278 RVA: 0x003EBD30 File Offset: 0x003E9F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Complete)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Complete);
			}
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Request)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Request);
			}
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Gm)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Gm);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AEC7 RID: 110279 RVA: 0x003EBDAC File Offset: 0x003E9FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Request)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Request);
			}
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Gm)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Gm);
			}
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Complete)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Complete);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AEC8 RID: 110280 RVA: 0x003EBE20 File Offset: 0x003EA020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TestCmdNotify other)
		{
			if (other == null)
			{
				return;
			}
			TestCmdNotify.CmdOneofCase cmdCase = other.CmdCase;
			if (cmdCase != TestCmdNotify.CmdOneofCase.Complete)
			{
				if (cmdCase != TestCmdNotify.CmdOneofCase.Request)
				{
					if (cmdCase == TestCmdNotify.CmdOneofCase.Gm)
					{
						if (this.Gm == null)
						{
							this.Gm = new TestCmdGmParams();
						}
						this.Gm.MergeFrom(other.Gm);
					}
				}
				else
				{
					if (this.Request == null)
					{
						this.Request = new TestCmdRequestParams();
					}
					this.Request.MergeFrom(other.Request);
				}
			}
			else
			{
				if (this.Complete == null)
				{
					this.Complete = new TestCmdCompleteParams();
				}
				this.Complete.MergeFrom(other.Complete);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AEC9 RID: 110281 RVA: 0x003EBECE File Offset: 0x003EA0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AECA RID: 110282 RVA: 0x003EBED8 File Offset: 0x003EA0D8
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
				if (num != 34U)
				{
					if (num != 42U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							TestCmdGmParams testCmdGmParams = new TestCmdGmParams();
							if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Gm)
							{
								testCmdGmParams.MergeFrom(this.Gm);
							}
							input.ReadMessage(testCmdGmParams);
							this.Gm = testCmdGmParams;
						}
					}
					else
					{
						TestCmdRequestParams testCmdRequestParams = new TestCmdRequestParams();
						if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Request)
						{
							testCmdRequestParams.MergeFrom(this.Request);
						}
						input.ReadMessage(testCmdRequestParams);
						this.Request = testCmdRequestParams;
					}
				}
				else
				{
					TestCmdCompleteParams testCmdCompleteParams = new TestCmdCompleteParams();
					if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Complete)
					{
						testCmdCompleteParams.MergeFrom(this.Complete);
					}
					input.ReadMessage(testCmdCompleteParams);
					this.Complete = testCmdCompleteParams;
				}
			}
		}

		// Token: 0x04009D6D RID: 40301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D6E RID: 40302
		public const int RequestFieldNumber = 5;

		// Token: 0x04009D6F RID: 40303
		public const int GmFieldNumber = 15;

		// Token: 0x04009D70 RID: 40304
		public const int CompleteFieldNumber = 4;

		// Token: 0x04009D71 RID: 40305
		private object cmd_;

		// Token: 0x04009D72 RID: 40306
		private TestCmdNotify.CmdOneofCase cmdCase_;

		// Token: 0x02001A5E RID: 6750
		public enum CmdOneofCase
		{
			// Token: 0x0400CFDA RID: 53210
			None,
			// Token: 0x0400CFDB RID: 53211
			Request = 5,
			// Token: 0x0400CFDC RID: 53212
			Gm = 15,
			// Token: 0x0400CFDD RID: 53213
			Complete = 4
		}
	}
}

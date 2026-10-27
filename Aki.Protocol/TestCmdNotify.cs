using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134F RID: 4943
	[NetMessage(EMessageId.TestCmdNotify)]
	public sealed class TestCmdNotify : IMessage<TestCmdNotify>, IMessage, IEquatable<TestCmdNotify>, IDeepCloneable<TestCmdNotify>, IBufferMessage
	{
		// Token: 0x0601A42C RID: 107564 RVA: 0x003D09B7 File Offset: 0x003CEBB7
		[NullableContext(1)]
		public static TestCmdNotify Create()
		{
			return new TestCmdNotify();
		}

		// Token: 0x17005898 RID: 22680
		// (get) Token: 0x0601A42D RID: 107565 RVA: 0x003D09BE File Offset: 0x003CEBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005899 RID: 22681
		// (get) Token: 0x0601A42E RID: 107566 RVA: 0x003D09C1 File Offset: 0x003CEBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestCmdNotify.Descriptor;
			}
		}

		// Token: 0x0601A42F RID: 107567 RVA: 0x003D09C8 File Offset: 0x003CEBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdNotify()
		{
		}

		// Token: 0x0601A430 RID: 107568 RVA: 0x003D09D0 File Offset: 0x003CEBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdNotify(TestCmdNotify other) : this()
		{
			TestCmdNotify.CmdOneofCase cmdCase = other.CmdCase;
			if (cmdCase != TestCmdNotify.CmdOneofCase.Complete)
			{
				if (cmdCase != TestCmdNotify.CmdOneofCase.Gm)
				{
					if (cmdCase == TestCmdNotify.CmdOneofCase.Request)
					{
						this.Request = other.Request.Clone();
					}
				}
				else
				{
					this.Gm = other.Gm.Clone();
				}
			}
			else
			{
				this.Complete = other.Complete.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A431 RID: 107569 RVA: 0x003D0A40 File Offset: 0x003CEC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdNotify Clone()
		{
			return new TestCmdNotify(this);
		}

		// Token: 0x1700589A RID: 22682
		// (get) Token: 0x0601A432 RID: 107570 RVA: 0x003D0A48 File Offset: 0x003CEC48
		// (set) Token: 0x0601A433 RID: 107571 RVA: 0x003D0A61 File Offset: 0x003CEC61
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

		// Token: 0x1700589B RID: 22683
		// (get) Token: 0x0601A434 RID: 107572 RVA: 0x003D0A78 File Offset: 0x003CEC78
		// (set) Token: 0x0601A435 RID: 107573 RVA: 0x003D0A91 File Offset: 0x003CEC91
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

		// Token: 0x1700589C RID: 22684
		// (get) Token: 0x0601A436 RID: 107574 RVA: 0x003D0AA8 File Offset: 0x003CECA8
		// (set) Token: 0x0601A437 RID: 107575 RVA: 0x003D0AC0 File Offset: 0x003CECC0
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

		// Token: 0x1700589D RID: 22685
		// (get) Token: 0x0601A438 RID: 107576 RVA: 0x003D0AD6 File Offset: 0x003CECD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestCmdNotify.CmdOneofCase CmdCase
		{
			get
			{
				return this.cmdCase_;
			}
		}

		// Token: 0x0601A439 RID: 107577 RVA: 0x003D0ADE File Offset: 0x003CECDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCmd()
		{
			this.cmdCase_ = TestCmdNotify.CmdOneofCase.None;
			this.cmd_ = null;
		}

		// Token: 0x0601A43A RID: 107578 RVA: 0x003D0AEE File Offset: 0x003CECEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestCmdNotify);
		}

		// Token: 0x0601A43B RID: 107579 RVA: 0x003D0AFC File Offset: 0x003CECFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestCmdNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Request, other.Request) && object.Equals(this.Gm, other.Gm) && object.Equals(this.Complete, other.Complete) && this.CmdCase == other.CmdCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A43C RID: 107580 RVA: 0x003D0B74 File Offset: 0x003CED74
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

		// Token: 0x0601A43D RID: 107581 RVA: 0x003D0BEA File Offset: 0x003CEDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A43E RID: 107582 RVA: 0x003D0BF7 File Offset: 0x003CEDF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A43F RID: 107583 RVA: 0x003D0C00 File Offset: 0x003CEE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Complete)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Complete);
			}
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Gm)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Gm);
			}
			if (this.cmdCase_ == TestCmdNotify.CmdOneofCase.Request)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Request);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A440 RID: 107584 RVA: 0x003D0C7C File Offset: 0x003CEE7C
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

		// Token: 0x0601A441 RID: 107585 RVA: 0x003D0CF0 File Offset: 0x003CEEF0
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
				if (cmdCase != TestCmdNotify.CmdOneofCase.Gm)
				{
					if (cmdCase == TestCmdNotify.CmdOneofCase.Request)
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
					if (this.Gm == null)
					{
						this.Gm = new TestCmdGmParams();
					}
					this.Gm.MergeFrom(other.Gm);
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

		// Token: 0x0601A442 RID: 107586 RVA: 0x003D0D9D File Offset: 0x003CEF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A443 RID: 107587 RVA: 0x003D0DA8 File Offset: 0x003CEFA8
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
				if (num != 58U)
				{
					if (num != 106U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x0400992B RID: 39211
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400992C RID: 39212
		public const int RequestFieldNumber = 15;

		// Token: 0x0400992D RID: 39213
		public const int GmFieldNumber = 13;

		// Token: 0x0400992E RID: 39214
		public const int CompleteFieldNumber = 7;

		// Token: 0x0400992F RID: 39215
		private object cmd_;

		// Token: 0x04009930 RID: 39216
		private TestCmdNotify.CmdOneofCase cmdCase_;

		// Token: 0x020019BC RID: 6588
		public enum CmdOneofCase
		{
			// Token: 0x0400CA6F RID: 51823
			None,
			// Token: 0x0400CA70 RID: 51824
			Request = 15,
			// Token: 0x0400CA71 RID: 51825
			Gm = 13,
			// Token: 0x0400CA72 RID: 51826
			Complete = 7
		}
	}
}

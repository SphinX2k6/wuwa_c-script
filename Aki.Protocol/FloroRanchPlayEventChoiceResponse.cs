using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A6 RID: 1446
	[NetMessage(EMessageId.FloroRanchPlayEventChoiceResponse)]
	public sealed class FloroRanchPlayEventChoiceResponse : IMessage<FloroRanchPlayEventChoiceResponse>, IMessage, IEquatable<FloroRanchPlayEventChoiceResponse>, IDeepCloneable<FloroRanchPlayEventChoiceResponse>, IBufferMessage
	{
		// Token: 0x06008621 RID: 34337 RVA: 0x00143514 File Offset: 0x00141714
		[NullableContext(1)]
		public static FloroRanchPlayEventChoiceResponse Create()
		{
			return new FloroRanchPlayEventChoiceResponse();
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06008622 RID: 34338 RVA: 0x0014351B File Offset: 0x0014171B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x06008623 RID: 34339 RVA: 0x0014351E File Offset: 0x0014171E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayEventChoiceResponse.Descriptor;
			}
		}

		// Token: 0x06008624 RID: 34340 RVA: 0x00143525 File Offset: 0x00141725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceResponse()
		{
		}

		// Token: 0x06008625 RID: 34341 RVA: 0x00143530 File Offset: 0x00141730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceResponse(FloroRanchPlayEventChoiceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.update_ = ((other.update_ != null) ? other.update_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008626 RID: 34342 RVA: 0x0014357C File Offset: 0x0014177C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceResponse Clone()
		{
			return new FloroRanchPlayEventChoiceResponse(this);
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06008627 RID: 34343 RVA: 0x00143584 File Offset: 0x00141784
		// (set) Token: 0x06008628 RID: 34344 RVA: 0x0014358C File Offset: 0x0014178C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06008629 RID: 34345 RVA: 0x00143595 File Offset: 0x00141795
		// (set) Token: 0x0600862A RID: 34346 RVA: 0x0014359D File Offset: 0x0014179D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayInfo Update
		{
			get
			{
				return this.update_;
			}
			set
			{
				this.update_ = value;
			}
		}

		// Token: 0x0600862B RID: 34347 RVA: 0x001435A6 File Offset: 0x001417A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayEventChoiceResponse);
		}

		// Token: 0x0600862C RID: 34348 RVA: 0x001435B4 File Offset: 0x001417B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayEventChoiceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Update, other.Update) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600862D RID: 34349 RVA: 0x00143604 File Offset: 0x00141804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.update_ != null)
			{
				num ^= this.Update.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600862E RID: 34350 RVA: 0x0014365F File Offset: 0x0014185F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600862F RID: 34351 RVA: 0x0014366C File Offset: 0x0014186C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008630 RID: 34352 RVA: 0x00143678 File Offset: 0x00141878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.update_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Update);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008631 RID: 34353 RVA: 0x001436D0 File Offset: 0x001418D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.update_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Update);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008632 RID: 34354 RVA: 0x00143728 File Offset: 0x00141928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayEventChoiceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.update_ != null)
			{
				if (this.update_ == null)
				{
					this.Update = new FloroRanchPlayInfo();
				}
				this.Update.MergeFrom(other.Update);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008633 RID: 34355 RVA: 0x00143790 File Offset: 0x00141990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008634 RID: 34356 RVA: 0x0014379C File Offset: 0x0014199C
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.update_ == null)
						{
							this.Update = new FloroRanchPlayInfo();
						}
						input.ReadMessage(this.Update);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040042BF RID: 17087
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042C0 RID: 17088
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040042C1 RID: 17089
		private ErrorCode errorCode_;

		// Token: 0x040042C2 RID: 17090
		public const int UpdateFieldNumber = 11;

		// Token: 0x040042C3 RID: 17091
		private FloroRanchPlayInfo update_;
	}
}

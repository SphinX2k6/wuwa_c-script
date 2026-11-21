using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081F RID: 2079
	[NetMessage(EMessageId.InteractiveUpdateResponse)]
	public sealed class InteractiveUpdateResponse : IMessage<InteractiveUpdateResponse>, IMessage, IEquatable<InteractiveUpdateResponse>, IDeepCloneable<InteractiveUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600BA38 RID: 47672 RVA: 0x001BC105 File Offset: 0x001BA305
		[NullableContext(1)]
		public static InteractiveUpdateResponse Create()
		{
			return new InteractiveUpdateResponse();
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x0600BA39 RID: 47673 RVA: 0x001BC10C File Offset: 0x001BA30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x0600BA3A RID: 47674 RVA: 0x001BC10F File Offset: 0x001BA30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractiveUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600BA3B RID: 47675 RVA: 0x001BC116 File Offset: 0x001BA316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateResponse()
		{
		}

		// Token: 0x0600BA3C RID: 47676 RVA: 0x001BC11E File Offset: 0x001BA31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateResponse(InteractiveUpdateResponse other) : this()
		{
			this.code_ = other.code_;
			this.interactiveId_ = other.interactiveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA3D RID: 47677 RVA: 0x001BC14F File Offset: 0x001BA34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateResponse Clone()
		{
			return new InteractiveUpdateResponse(this);
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x0600BA3E RID: 47678 RVA: 0x001BC157 File Offset: 0x001BA357
		// (set) Token: 0x0600BA3F RID: 47679 RVA: 0x001BC15F File Offset: 0x001BA35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x0600BA40 RID: 47680 RVA: 0x001BC168 File Offset: 0x001BA368
		// (set) Token: 0x0600BA41 RID: 47681 RVA: 0x001BC170 File Offset: 0x001BA370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InteractiveId
		{
			get
			{
				return this.interactiveId_;
			}
			set
			{
				this.interactiveId_ = value;
			}
		}

		// Token: 0x0600BA42 RID: 47682 RVA: 0x001BC179 File Offset: 0x001BA379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractiveUpdateResponse);
		}

		// Token: 0x0600BA43 RID: 47683 RVA: 0x001BC187 File Offset: 0x001BA387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractiveUpdateResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.InteractiveId == other.InteractiveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA44 RID: 47684 RVA: 0x001BC1C8 File Offset: 0x001BA3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.InteractiveId != 0)
			{
				num ^= this.InteractiveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA45 RID: 47685 RVA: 0x001BC226 File Offset: 0x001BA426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA46 RID: 47686 RVA: 0x001BC233 File Offset: 0x001BA433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA47 RID: 47687 RVA: 0x001BC23C File Offset: 0x001BA43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this.InteractiveId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.InteractiveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA48 RID: 47688 RVA: 0x001BC298 File Offset: 0x001BA498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.InteractiveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InteractiveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA49 RID: 47689 RVA: 0x001BC2F0 File Offset: 0x001BA4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractiveUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.InteractiveId != 0)
			{
				this.InteractiveId = other.InteractiveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA4A RID: 47690 RVA: 0x001BC340 File Offset: 0x001BA540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA4B RID: 47691 RVA: 0x001BC34C File Offset: 0x001BA54C
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
				if (num != 72U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InteractiveId = input.ReadInt32();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005247 RID: 21063
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005248 RID: 21064
		public const int CodeFieldNumber = 9;

		// Token: 0x04005249 RID: 21065
		private ErrorCode code_;

		// Token: 0x0400524A RID: 21066
		public const int InteractiveIdFieldNumber = 13;

		// Token: 0x0400524B RID: 21067
		private int interactiveId_;
	}
}

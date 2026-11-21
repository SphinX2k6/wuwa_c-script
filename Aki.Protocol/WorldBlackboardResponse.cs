using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200158D RID: 5517
	[NetMessage(EMessageId.WorldBlackboardResponse)]
	public sealed class WorldBlackboardResponse : IMessage<WorldBlackboardResponse>, IMessage, IEquatable<WorldBlackboardResponse>, IDeepCloneable<WorldBlackboardResponse>, IBufferMessage
	{
		// Token: 0x0601D342 RID: 119618 RVA: 0x0043A4DD File Offset: 0x004386DD
		[NullableContext(1)]
		public static WorldBlackboardResponse Create()
		{
			return new WorldBlackboardResponse();
		}

		// Token: 0x170062CB RID: 25291
		// (get) Token: 0x0601D343 RID: 119619 RVA: 0x0043A4E4 File Offset: 0x004386E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062CC RID: 25292
		// (get) Token: 0x0601D344 RID: 119620 RVA: 0x0043A4E7 File Offset: 0x004386E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldBlackboardResponse.Descriptor;
			}
		}

		// Token: 0x0601D345 RID: 119621 RVA: 0x0043A4EE File Offset: 0x004386EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardResponse()
		{
		}

		// Token: 0x0601D346 RID: 119622 RVA: 0x0043A4F6 File Offset: 0x004386F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardResponse(WorldBlackboardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D347 RID: 119623 RVA: 0x0043A51B File Offset: 0x0043871B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardResponse Clone()
		{
			return new WorldBlackboardResponse(this);
		}

		// Token: 0x170062CD RID: 25293
		// (get) Token: 0x0601D348 RID: 119624 RVA: 0x0043A523 File Offset: 0x00438723
		// (set) Token: 0x0601D349 RID: 119625 RVA: 0x0043A52B File Offset: 0x0043872B
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

		// Token: 0x0601D34A RID: 119626 RVA: 0x0043A534 File Offset: 0x00438734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldBlackboardResponse);
		}

		// Token: 0x0601D34B RID: 119627 RVA: 0x0043A542 File Offset: 0x00438742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldBlackboardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D34C RID: 119628 RVA: 0x0043A570 File Offset: 0x00438770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D34D RID: 119629 RVA: 0x0043A5B5 File Offset: 0x004387B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D34E RID: 119630 RVA: 0x0043A5C2 File Offset: 0x004387C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D34F RID: 119631 RVA: 0x0043A5CB File Offset: 0x004387CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D350 RID: 119632 RVA: 0x0043A600 File Offset: 0x00438800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D351 RID: 119633 RVA: 0x0043A63E File Offset: 0x0043883E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldBlackboardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D352 RID: 119634 RVA: 0x0043A66F File Offset: 0x0043886F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D353 RID: 119635 RVA: 0x0043A678 File Offset: 0x00438878
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A78B RID: 42891
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A78C RID: 42892
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400A78D RID: 42893
		private ErrorCode errorCode_;
	}
}

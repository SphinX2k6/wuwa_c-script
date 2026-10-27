using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA7 RID: 3751
	[NetMessage(EMessageId.RecallExploreSkillRouletteSetResponse)]
	public sealed class RecallExploreSkillRouletteSetResponse : IMessage<RecallExploreSkillRouletteSetResponse>, IMessage, IEquatable<RecallExploreSkillRouletteSetResponse>, IDeepCloneable<RecallExploreSkillRouletteSetResponse>, IBufferMessage
	{
		// Token: 0x06014218 RID: 82456 RVA: 0x002EDF0D File Offset: 0x002EC10D
		[NullableContext(1)]
		public static RecallExploreSkillRouletteSetResponse Create()
		{
			return new RecallExploreSkillRouletteSetResponse();
		}

		// Token: 0x170042F4 RID: 17140
		// (get) Token: 0x06014219 RID: 82457 RVA: 0x002EDF14 File Offset: 0x002EC114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042F5 RID: 17141
		// (get) Token: 0x0601421A RID: 82458 RVA: 0x002EDF17 File Offset: 0x002EC117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallExploreSkillRouletteSetResponse.Descriptor;
			}
		}

		// Token: 0x0601421B RID: 82459 RVA: 0x002EDF1E File Offset: 0x002EC11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetResponse()
		{
		}

		// Token: 0x0601421C RID: 82460 RVA: 0x002EDF26 File Offset: 0x002EC126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetResponse(RecallExploreSkillRouletteSetResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601421D RID: 82461 RVA: 0x002EDF4B File Offset: 0x002EC14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetResponse Clone()
		{
			return new RecallExploreSkillRouletteSetResponse(this);
		}

		// Token: 0x170042F6 RID: 17142
		// (get) Token: 0x0601421E RID: 82462 RVA: 0x002EDF53 File Offset: 0x002EC153
		// (set) Token: 0x0601421F RID: 82463 RVA: 0x002EDF5B File Offset: 0x002EC15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x06014220 RID: 82464 RVA: 0x002EDF64 File Offset: 0x002EC164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallExploreSkillRouletteSetResponse);
		}

		// Token: 0x06014221 RID: 82465 RVA: 0x002EDF72 File Offset: 0x002EC172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallExploreSkillRouletteSetResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014222 RID: 82466 RVA: 0x002EDFA0 File Offset: 0x002EC1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014223 RID: 82467 RVA: 0x002EDFE5 File Offset: 0x002EC1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014224 RID: 82468 RVA: 0x002EDFF2 File Offset: 0x002EC1F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014225 RID: 82469 RVA: 0x002EDFFB File Offset: 0x002EC1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014226 RID: 82470 RVA: 0x002EE030 File Offset: 0x002EC230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014227 RID: 82471 RVA: 0x002EE06E File Offset: 0x002EC26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallExploreSkillRouletteSetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014228 RID: 82472 RVA: 0x002EE09F File Offset: 0x002EC29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014229 RID: 82473 RVA: 0x002EE0A8 File Offset: 0x002EC2A8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007AA4 RID: 31396
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AA5 RID: 31397
		public const int ErrorIdFieldNumber = 9;

		// Token: 0x04007AA6 RID: 31398
		private ErrorCode errorId_;
	}
}

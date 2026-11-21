using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200004F RID: 79
	[NetMessage(EMessageId.AcceptFocusWaitQuestResponse)]
	public sealed class AcceptFocusWaitQuestResponse : IMessage<AcceptFocusWaitQuestResponse>, IMessage, IEquatable<AcceptFocusWaitQuestResponse>, IDeepCloneable<AcceptFocusWaitQuestResponse>, IBufferMessage
	{
		// Token: 0x060014EE RID: 5358 RVA: 0x00037E91 File Offset: 0x00036091
		[NullableContext(1)]
		public static AcceptFocusWaitQuestResponse Create()
		{
			return new AcceptFocusWaitQuestResponse();
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x00037E98 File Offset: 0x00036098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00037E9B File Offset: 0x0003609B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptFocusWaitQuestResponse.Descriptor;
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00037EA2 File Offset: 0x000360A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestResponse()
		{
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00037EAA File Offset: 0x000360AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestResponse(AcceptFocusWaitQuestResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00037ECF File Offset: 0x000360CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestResponse Clone()
		{
			return new AcceptFocusWaitQuestResponse(this);
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00037ED7 File Offset: 0x000360D7
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x00037EDF File Offset: 0x000360DF
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

		// Token: 0x060014F6 RID: 5366 RVA: 0x00037EE8 File Offset: 0x000360E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptFocusWaitQuestResponse);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00037EF6 File Offset: 0x000360F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptFocusWaitQuestResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00037F24 File Offset: 0x00036124
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

		// Token: 0x060014F9 RID: 5369 RVA: 0x00037F69 File Offset: 0x00036169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00037F76 File Offset: 0x00036176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00037F7F File Offset: 0x0003617F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00037FB4 File Offset: 0x000361B4
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

		// Token: 0x060014FD RID: 5373 RVA: 0x00037FF2 File Offset: 0x000361F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptFocusWaitQuestResponse other)
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

		// Token: 0x060014FE RID: 5374 RVA: 0x00038023 File Offset: 0x00036223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0003802C File Offset: 0x0003622C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040020CC RID: 8396
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020CD RID: 8397
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040020CE RID: 8398
		private ErrorCode errorCode_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000585 RID: 1413
	[NetMessage(EMessageId.FishingSkillBaitResponse)]
	public sealed class FishingSkillBaitResponse : IMessage<FishingSkillBaitResponse>, IMessage, IEquatable<FishingSkillBaitResponse>, IDeepCloneable<FishingSkillBaitResponse>, IBufferMessage
	{
		// Token: 0x0600832C RID: 33580 RVA: 0x0013C2ED File Offset: 0x0013A4ED
		[NullableContext(1)]
		public static FishingSkillBaitResponse Create()
		{
			return new FishingSkillBaitResponse();
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x0600832D RID: 33581 RVA: 0x0013C2F4 File Offset: 0x0013A4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x0600832E RID: 33582 RVA: 0x0013C2F7 File Offset: 0x0013A4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillBaitResponse.Descriptor;
			}
		}

		// Token: 0x0600832F RID: 33583 RVA: 0x0013C2FE File Offset: 0x0013A4FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitResponse()
		{
		}

		// Token: 0x06008330 RID: 33584 RVA: 0x0013C306 File Offset: 0x0013A506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitResponse(FishingSkillBaitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008331 RID: 33585 RVA: 0x0013C32B File Offset: 0x0013A52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitResponse Clone()
		{
			return new FishingSkillBaitResponse(this);
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06008332 RID: 33586 RVA: 0x0013C333 File Offset: 0x0013A533
		// (set) Token: 0x06008333 RID: 33587 RVA: 0x0013C33B File Offset: 0x0013A53B
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

		// Token: 0x06008334 RID: 33588 RVA: 0x0013C344 File Offset: 0x0013A544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillBaitResponse);
		}

		// Token: 0x06008335 RID: 33589 RVA: 0x0013C352 File Offset: 0x0013A552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillBaitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008336 RID: 33590 RVA: 0x0013C380 File Offset: 0x0013A580
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

		// Token: 0x06008337 RID: 33591 RVA: 0x0013C3C5 File Offset: 0x0013A5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008338 RID: 33592 RVA: 0x0013C3D2 File Offset: 0x0013A5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008339 RID: 33593 RVA: 0x0013C3DB File Offset: 0x0013A5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600833A RID: 33594 RVA: 0x0013C410 File Offset: 0x0013A610
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

		// Token: 0x0600833B RID: 33595 RVA: 0x0013C44E File Offset: 0x0013A64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkillBaitResponse other)
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

		// Token: 0x0600833C RID: 33596 RVA: 0x0013C47F File Offset: 0x0013A67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600833D RID: 33597 RVA: 0x0013C488 File Offset: 0x0013A688
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400416C RID: 16748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400416D RID: 16749
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400416E RID: 16750
		private ErrorCode errorCode_;
	}
}

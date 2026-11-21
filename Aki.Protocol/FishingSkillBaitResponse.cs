using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000570 RID: 1392
	[NetMessage(EMessageId.FishingSkillBaitResponse)]
	public sealed class FishingSkillBaitResponse : IMessage<FishingSkillBaitResponse>, IMessage, IEquatable<FishingSkillBaitResponse>, IDeepCloneable<FishingSkillBaitResponse>, IBufferMessage
	{
		// Token: 0x060081C4 RID: 33220 RVA: 0x001396E1 File Offset: 0x001378E1
		[NullableContext(1)]
		public static FishingSkillBaitResponse Create()
		{
			return new FishingSkillBaitResponse();
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x060081C5 RID: 33221 RVA: 0x001396E8 File Offset: 0x001378E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x060081C6 RID: 33222 RVA: 0x001396EB File Offset: 0x001378EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillBaitResponse.Descriptor;
			}
		}

		// Token: 0x060081C7 RID: 33223 RVA: 0x001396F2 File Offset: 0x001378F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitResponse()
		{
		}

		// Token: 0x060081C8 RID: 33224 RVA: 0x001396FA File Offset: 0x001378FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitResponse(FishingSkillBaitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081C9 RID: 33225 RVA: 0x0013971F File Offset: 0x0013791F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitResponse Clone()
		{
			return new FishingSkillBaitResponse(this);
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x060081CA RID: 33226 RVA: 0x00139727 File Offset: 0x00137927
		// (set) Token: 0x060081CB RID: 33227 RVA: 0x0013972F File Offset: 0x0013792F
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

		// Token: 0x060081CC RID: 33228 RVA: 0x00139738 File Offset: 0x00137938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillBaitResponse);
		}

		// Token: 0x060081CD RID: 33229 RVA: 0x00139746 File Offset: 0x00137946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillBaitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081CE RID: 33230 RVA: 0x00139774 File Offset: 0x00137974
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

		// Token: 0x060081CF RID: 33231 RVA: 0x001397B9 File Offset: 0x001379B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060081D0 RID: 33232 RVA: 0x001397C6 File Offset: 0x001379C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081D1 RID: 33233 RVA: 0x001397CF File Offset: 0x001379CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x00139804 File Offset: 0x00137A04
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

		// Token: 0x060081D3 RID: 33235 RVA: 0x00139842 File Offset: 0x00137A42
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

		// Token: 0x060081D4 RID: 33236 RVA: 0x00139873 File Offset: 0x00137A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081D5 RID: 33237 RVA: 0x0013987C File Offset: 0x00137A7C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004162 RID: 16738
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004163 RID: 16739
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04004164 RID: 16740
		private ErrorCode errorCode_;
	}
}

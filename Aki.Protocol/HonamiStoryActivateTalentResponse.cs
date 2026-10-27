using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075D RID: 1885
	[NetMessage(EMessageId.HonamiStoryActivateTalentResponse)]
	public sealed class HonamiStoryActivateTalentResponse : IMessage<HonamiStoryActivateTalentResponse>, IMessage, IEquatable<HonamiStoryActivateTalentResponse>, IDeepCloneable<HonamiStoryActivateTalentResponse>, IBufferMessage
	{
		// Token: 0x0600AAA0 RID: 43680 RVA: 0x0019A7B9 File Offset: 0x001989B9
		[NullableContext(1)]
		public static HonamiStoryActivateTalentResponse Create()
		{
			return new HonamiStoryActivateTalentResponse();
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x0600AAA1 RID: 43681 RVA: 0x0019A7C0 File Offset: 0x001989C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x0600AAA2 RID: 43682 RVA: 0x0019A7C3 File Offset: 0x001989C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryActivateTalentResponse.Descriptor;
			}
		}

		// Token: 0x0600AAA3 RID: 43683 RVA: 0x0019A7CA File Offset: 0x001989CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentResponse()
		{
		}

		// Token: 0x0600AAA4 RID: 43684 RVA: 0x0019A7D2 File Offset: 0x001989D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentResponse(HonamiStoryActivateTalentResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAA5 RID: 43685 RVA: 0x0019A803 File Offset: 0x00198A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentResponse Clone()
		{
			return new HonamiStoryActivateTalentResponse(this);
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x0600AAA6 RID: 43686 RVA: 0x0019A80B File Offset: 0x00198A0B
		// (set) Token: 0x0600AAA7 RID: 43687 RVA: 0x0019A813 File Offset: 0x00198A13
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

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x0600AAA8 RID: 43688 RVA: 0x0019A81C File Offset: 0x00198A1C
		// (set) Token: 0x0600AAA9 RID: 43689 RVA: 0x0019A824 File Offset: 0x00198A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalentId
		{
			get
			{
				return this.talentId_;
			}
			set
			{
				this.talentId_ = value;
			}
		}

		// Token: 0x0600AAAA RID: 43690 RVA: 0x0019A82D File Offset: 0x00198A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryActivateTalentResponse);
		}

		// Token: 0x0600AAAB RID: 43691 RVA: 0x0019A83B File Offset: 0x00198A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryActivateTalentResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AAAC RID: 43692 RVA: 0x0019A87C File Offset: 0x00198A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.TalentId != 0)
			{
				num ^= this.TalentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AAAD RID: 43693 RVA: 0x0019A8DA File Offset: 0x00198ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AAAE RID: 43694 RVA: 0x0019A8E7 File Offset: 0x00198AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAAF RID: 43695 RVA: 0x0019A8F0 File Offset: 0x00198AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.TalentId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AAB0 RID: 43696 RVA: 0x0019A94C File Offset: 0x00198B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.TalentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AAB1 RID: 43697 RVA: 0x0019A9A4 File Offset: 0x00198BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryActivateTalentResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.TalentId != 0)
			{
				this.TalentId = other.TalentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AAB2 RID: 43698 RVA: 0x0019A9F4 File Offset: 0x00198BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAB3 RID: 43699 RVA: 0x0019AA00 File Offset: 0x00198C00
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
				if (num != 104U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TalentId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004D85 RID: 19845
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D86 RID: 19846
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04004D87 RID: 19847
		private ErrorCode errorCode_;

		// Token: 0x04004D88 RID: 19848
		public const int TalentIdFieldNumber = 14;

		// Token: 0x04004D89 RID: 19849
		private int talentId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5C RID: 2652
	[NetMessage(EMessageId.MotorFightTalentUpRequest)]
	public sealed class MotorFightTalentUpRequest : IMessage<MotorFightTalentUpRequest>, IMessage, IEquatable<MotorFightTalentUpRequest>, IDeepCloneable<MotorFightTalentUpRequest>, IBufferMessage
	{
		// Token: 0x0600E7AE RID: 59310 RVA: 0x0021DF29 File Offset: 0x0021C129
		[NullableContext(1)]
		public static MotorFightTalentUpRequest Create()
		{
			return new MotorFightTalentUpRequest();
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x0600E7AF RID: 59311 RVA: 0x0021DF30 File Offset: 0x0021C130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x0600E7B0 RID: 59312 RVA: 0x0021DF33 File Offset: 0x0021C133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTalentUpRequest.Descriptor;
			}
		}

		// Token: 0x0600E7B1 RID: 59313 RVA: 0x0021DF3A File Offset: 0x0021C13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpRequest()
		{
		}

		// Token: 0x0600E7B2 RID: 59314 RVA: 0x0021DF42 File Offset: 0x0021C142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpRequest(MotorFightTalentUpRequest other) : this()
		{
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E7B3 RID: 59315 RVA: 0x0021DF67 File Offset: 0x0021C167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpRequest Clone()
		{
			return new MotorFightTalentUpRequest(this);
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x0600E7B4 RID: 59316 RVA: 0x0021DF6F File Offset: 0x0021C16F
		// (set) Token: 0x0600E7B5 RID: 59317 RVA: 0x0021DF77 File Offset: 0x0021C177
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

		// Token: 0x0600E7B6 RID: 59318 RVA: 0x0021DF80 File Offset: 0x0021C180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTalentUpRequest);
		}

		// Token: 0x0600E7B7 RID: 59319 RVA: 0x0021DF8E File Offset: 0x0021C18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTalentUpRequest other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7B8 RID: 59320 RVA: 0x0021DFBC File Offset: 0x0021C1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600E7B9 RID: 59321 RVA: 0x0021DFFB File Offset: 0x0021C1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E7BA RID: 59322 RVA: 0x0021E008 File Offset: 0x0021C208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7BB RID: 59323 RVA: 0x0021E011 File Offset: 0x0021C211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E7BC RID: 59324 RVA: 0x0021E044 File Offset: 0x0021C244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600E7BD RID: 59325 RVA: 0x0021E082 File Offset: 0x0021C282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightTalentUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalentId != 0)
			{
				this.TalentId = other.TalentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E7BE RID: 59326 RVA: 0x0021E0B3 File Offset: 0x0021C2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7BF RID: 59327 RVA: 0x0021E0BC File Offset: 0x0021C2BC
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
					this.TalentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005ECA RID: 24266
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005ECB RID: 24267
		public const int TalentIdFieldNumber = 9;

		// Token: 0x04005ECC RID: 24268
		private int talentId_;
	}
}

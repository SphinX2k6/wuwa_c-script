using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000749 RID: 1865
	[NetMessage(EMessageId.HonamiStoryActivateTalentResponse)]
	public sealed class HonamiStoryActivateTalentResponse : IMessage<HonamiStoryActivateTalentResponse>, IMessage, IEquatable<HonamiStoryActivateTalentResponse>, IDeepCloneable<HonamiStoryActivateTalentResponse>, IBufferMessage
	{
		// Token: 0x0600A94A RID: 43338 RVA: 0x00197D91 File Offset: 0x00195F91
		[NullableContext(1)]
		public static HonamiStoryActivateTalentResponse Create()
		{
			return new HonamiStoryActivateTalentResponse();
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x0600A94B RID: 43339 RVA: 0x00197D98 File Offset: 0x00195F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x0600A94C RID: 43340 RVA: 0x00197D9B File Offset: 0x00195F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryActivateTalentResponse.Descriptor;
			}
		}

		// Token: 0x0600A94D RID: 43341 RVA: 0x00197DA2 File Offset: 0x00195FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentResponse()
		{
		}

		// Token: 0x0600A94E RID: 43342 RVA: 0x00197DAA File Offset: 0x00195FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentResponse(HonamiStoryActivateTalentResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A94F RID: 43343 RVA: 0x00197DDB File Offset: 0x00195FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentResponse Clone()
		{
			return new HonamiStoryActivateTalentResponse(this);
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x0600A950 RID: 43344 RVA: 0x00197DE3 File Offset: 0x00195FE3
		// (set) Token: 0x0600A951 RID: 43345 RVA: 0x00197DEB File Offset: 0x00195FEB
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

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x0600A952 RID: 43346 RVA: 0x00197DF4 File Offset: 0x00195FF4
		// (set) Token: 0x0600A953 RID: 43347 RVA: 0x00197DFC File Offset: 0x00195FFC
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

		// Token: 0x0600A954 RID: 43348 RVA: 0x00197E05 File Offset: 0x00196005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryActivateTalentResponse);
		}

		// Token: 0x0600A955 RID: 43349 RVA: 0x00197E13 File Offset: 0x00196013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryActivateTalentResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A956 RID: 43350 RVA: 0x00197E54 File Offset: 0x00196054
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

		// Token: 0x0600A957 RID: 43351 RVA: 0x00197EB2 File Offset: 0x001960B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A958 RID: 43352 RVA: 0x00197EBF File Offset: 0x001960BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A959 RID: 43353 RVA: 0x00197EC8 File Offset: 0x001960C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
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

		// Token: 0x0600A95A RID: 43354 RVA: 0x00197F24 File Offset: 0x00196124
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

		// Token: 0x0600A95B RID: 43355 RVA: 0x00197F7C File Offset: 0x0019617C
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

		// Token: 0x0600A95C RID: 43356 RVA: 0x00197FCC File Offset: 0x001961CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A95D RID: 43357 RVA: 0x00197FD8 File Offset: 0x001961D8
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
					if (num != 72U)
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

		// Token: 0x04004D7E RID: 19838
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D7F RID: 19839
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04004D80 RID: 19840
		private ErrorCode errorCode_;

		// Token: 0x04004D81 RID: 19841
		public const int TalentIdFieldNumber = 9;

		// Token: 0x04004D82 RID: 19842
		private int talentId_;
	}
}

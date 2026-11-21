using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E57 RID: 3671
	[NetMessage(EMessageId.RacingBetsLegMatchInfoResponse)]
	public sealed class RacingBetsLegMatchInfoResponse : IMessage<RacingBetsLegMatchInfoResponse>, IMessage, IEquatable<RacingBetsLegMatchInfoResponse>, IDeepCloneable<RacingBetsLegMatchInfoResponse>, IBufferMessage
	{
		// Token: 0x06013C0A RID: 80906 RVA: 0x002E1090 File Offset: 0x002DF290
		[NullableContext(1)]
		public static RacingBetsLegMatchInfoResponse Create()
		{
			return new RacingBetsLegMatchInfoResponse();
		}

		// Token: 0x170041B1 RID: 16817
		// (get) Token: 0x06013C0B RID: 80907 RVA: 0x002E1097 File Offset: 0x002DF297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041B2 RID: 16818
		// (get) Token: 0x06013C0C RID: 80908 RVA: 0x002E109A File Offset: 0x002DF29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsLegMatchInfoResponse.Descriptor;
			}
		}

		// Token: 0x06013C0D RID: 80909 RVA: 0x002E10A1 File Offset: 0x002DF2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoResponse()
		{
		}

		// Token: 0x06013C0E RID: 80910 RVA: 0x002E10AC File Offset: 0x002DF2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoResponse(RacingBetsLegMatchInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.legInfo_ = ((other.legInfo_ != null) ? other.legInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013C0F RID: 80911 RVA: 0x002E10F8 File Offset: 0x002DF2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoResponse Clone()
		{
			return new RacingBetsLegMatchInfoResponse(this);
		}

		// Token: 0x170041B3 RID: 16819
		// (get) Token: 0x06013C10 RID: 80912 RVA: 0x002E1100 File Offset: 0x002DF300
		// (set) Token: 0x06013C11 RID: 80913 RVA: 0x002E1108 File Offset: 0x002DF308
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

		// Token: 0x170041B4 RID: 16820
		// (get) Token: 0x06013C12 RID: 80914 RVA: 0x002E1111 File Offset: 0x002DF311
		// (set) Token: 0x06013C13 RID: 80915 RVA: 0x002E1119 File Offset: 0x002DF319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchesInfo LegInfo
		{
			get
			{
				return this.legInfo_;
			}
			set
			{
				this.legInfo_ = value;
			}
		}

		// Token: 0x06013C14 RID: 80916 RVA: 0x002E1122 File Offset: 0x002DF322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsLegMatchInfoResponse);
		}

		// Token: 0x06013C15 RID: 80917 RVA: 0x002E1130 File Offset: 0x002DF330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsLegMatchInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.LegInfo, other.LegInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C16 RID: 80918 RVA: 0x002E1180 File Offset: 0x002DF380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.legInfo_ != null)
			{
				num ^= this.LegInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013C17 RID: 80919 RVA: 0x002E11DB File Offset: 0x002DF3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C18 RID: 80920 RVA: 0x002E11E8 File Offset: 0x002DF3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C19 RID: 80921 RVA: 0x002E11F4 File Offset: 0x002DF3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.legInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.LegInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013C1A RID: 80922 RVA: 0x002E124C File Offset: 0x002DF44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.legInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LegInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013C1B RID: 80923 RVA: 0x002E12A4 File Offset: 0x002DF4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsLegMatchInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.legInfo_ != null)
			{
				if (this.legInfo_ == null)
				{
					this.LegInfo = new RacingBetsLegMatchesInfo();
				}
				this.LegInfo.MergeFrom(other.LegInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013C1C RID: 80924 RVA: 0x002E130C File Offset: 0x002DF50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C1D RID: 80925 RVA: 0x002E1318 File Offset: 0x002DF518
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.legInfo_ == null)
						{
							this.LegInfo = new RacingBetsLegMatchesInfo();
						}
						input.ReadMessage(this.LegInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400795B RID: 31067
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400795C RID: 31068
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400795D RID: 31069
		private ErrorCode errorCode_;

		// Token: 0x0400795E RID: 31070
		public const int LegInfoFieldNumber = 12;

		// Token: 0x0400795F RID: 31071
		private RacingBetsLegMatchesInfo legInfo_;
	}
}

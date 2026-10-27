using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8A RID: 3466
	[NetMessage(EMessageId.PlayerEnterPollutionRequest)]
	public sealed class PlayerEnterPollutionRequest : IMessage<PlayerEnterPollutionRequest>, IMessage, IEquatable<PlayerEnterPollutionRequest>, IDeepCloneable<PlayerEnterPollutionRequest>, IBufferMessage
	{
		// Token: 0x06012B1C RID: 76572 RVA: 0x002BABB7 File Offset: 0x002B8DB7
		[NullableContext(1)]
		public static PlayerEnterPollutionRequest Create()
		{
			return new PlayerEnterPollutionRequest();
		}

		// Token: 0x17003E0E RID: 15886
		// (get) Token: 0x06012B1D RID: 76573 RVA: 0x002BABBE File Offset: 0x002B8DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E0F RID: 15887
		// (get) Token: 0x06012B1E RID: 76574 RVA: 0x002BABC1 File Offset: 0x002B8DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerEnterPollutionRequest.Descriptor;
			}
		}

		// Token: 0x06012B1F RID: 76575 RVA: 0x002BABC8 File Offset: 0x002B8DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionRequest()
		{
		}

		// Token: 0x06012B20 RID: 76576 RVA: 0x002BABD0 File Offset: 0x002B8DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionRequest(PlayerEnterPollutionRequest other) : this()
		{
			this.managerEntityId_ = other.managerEntityId_;
			this.rangeType_ = other.rangeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B21 RID: 76577 RVA: 0x002BAC01 File Offset: 0x002B8E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionRequest Clone()
		{
			return new PlayerEnterPollutionRequest(this);
		}

		// Token: 0x17003E10 RID: 15888
		// (get) Token: 0x06012B22 RID: 76578 RVA: 0x002BAC09 File Offset: 0x002B8E09
		// (set) Token: 0x06012B23 RID: 76579 RVA: 0x002BAC11 File Offset: 0x002B8E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ManagerEntityId
		{
			get
			{
				return this.managerEntityId_;
			}
			set
			{
				this.managerEntityId_ = value;
			}
		}

		// Token: 0x17003E11 RID: 15889
		// (get) Token: 0x06012B24 RID: 76580 RVA: 0x002BAC1A File Offset: 0x002B8E1A
		// (set) Token: 0x06012B25 RID: 76581 RVA: 0x002BAC22 File Offset: 0x002B8E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEnterOrExitPollutionRangeType RangeType
		{
			get
			{
				return this.rangeType_;
			}
			set
			{
				this.rangeType_ = value;
			}
		}

		// Token: 0x06012B26 RID: 76582 RVA: 0x002BAC2B File Offset: 0x002B8E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerEnterPollutionRequest);
		}

		// Token: 0x06012B27 RID: 76583 RVA: 0x002BAC39 File Offset: 0x002B8E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerEnterPollutionRequest other)
		{
			return other != null && (other == this || (this.ManagerEntityId == other.ManagerEntityId && this.RangeType == other.RangeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B28 RID: 76584 RVA: 0x002BAC78 File Offset: 0x002B8E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ManagerEntityId != 0L)
			{
				num ^= this.ManagerEntityId.GetHashCode();
			}
			if (this.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				num ^= this.RangeType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012B29 RID: 76585 RVA: 0x002BACD6 File Offset: 0x002B8ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B2A RID: 76586 RVA: 0x002BACE3 File Offset: 0x002B8EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B2B RID: 76587 RVA: 0x002BACEC File Offset: 0x002B8EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.RangeType);
			}
			if (this.ManagerEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.ManagerEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012B2C RID: 76588 RVA: 0x002BAD48 File Offset: 0x002B8F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ManagerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ManagerEntityId);
			}
			if (this.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RangeType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012B2D RID: 76589 RVA: 0x002BADA0 File Offset: 0x002B8FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerEnterPollutionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ManagerEntityId != 0L)
			{
				this.ManagerEntityId = other.ManagerEntityId;
			}
			if (other.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				this.RangeType = other.RangeType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012B2E RID: 76590 RVA: 0x002BADF0 File Offset: 0x002B8FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B2F RID: 76591 RVA: 0x002BADFC File Offset: 0x002B8FFC
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ManagerEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.RangeType = (PlayEnterOrExitPollutionRangeType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400740B RID: 29707
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400740C RID: 29708
		public const int ManagerEntityIdFieldNumber = 7;

		// Token: 0x0400740D RID: 29709
		private long managerEntityId_;

		// Token: 0x0400740E RID: 29710
		public const int RangeTypeFieldNumber = 6;

		// Token: 0x0400740F RID: 29711
		private PlayEnterOrExitPollutionRangeType rangeType_;
	}
}

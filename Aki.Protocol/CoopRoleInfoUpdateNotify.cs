using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FC RID: 764
	[NetMessage(EMessageId.CoopRoleInfoUpdateNotify)]
	public sealed class CoopRoleInfoUpdateNotify : IMessage<CoopRoleInfoUpdateNotify>, IMessage, IEquatable<CoopRoleInfoUpdateNotify>, IDeepCloneable<CoopRoleInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06004D47 RID: 19783 RVA: 0x000BBEC0 File Offset: 0x000BA0C0
		[NullableContext(1)]
		public static CoopRoleInfoUpdateNotify Create()
		{
			return new CoopRoleInfoUpdateNotify();
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06004D48 RID: 19784 RVA: 0x000BBEC7 File Offset: 0x000BA0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06004D49 RID: 19785 RVA: 0x000BBECA File Offset: 0x000BA0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopRoleInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x000BBED1 File Offset: 0x000BA0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfoUpdateNotify()
		{
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x000BBEDC File Offset: 0x000BA0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfoUpdateNotify(CoopRoleInfoUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			CoopRoleInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
			{
				if (dataCase != CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
				{
					if (dataCase == CoopRoleInfoUpdateNotify.DataOneofCase.PreCompleteId)
					{
						this.PreCompleteId = other.PreCompleteId;
					}
				}
				else
				{
					this.CoopTaskCompleteInfo = other.CoopTaskCompleteInfo.Clone();
				}
			}
			else
			{
				this.CoopRoleInfo = other.CoopRoleInfo.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x000BBF54 File Offset: 0x000BA154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfoUpdateNotify Clone()
		{
			return new CoopRoleInfoUpdateNotify(this);
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06004D4D RID: 19789 RVA: 0x000BBF5C File Offset: 0x000BA15C
		// (set) Token: 0x06004D4E RID: 19790 RVA: 0x000BBF64 File Offset: 0x000BA164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06004D4F RID: 19791 RVA: 0x000BBF6D File Offset: 0x000BA16D
		// (set) Token: 0x06004D50 RID: 19792 RVA: 0x000BBF85 File Offset: 0x000BA185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfo CoopRoleInfo
		{
			get
			{
				if (this.dataCase_ != CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
				{
					return null;
				}
				return (CoopRoleInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? CoopRoleInfoUpdateNotify.DataOneofCase.None : CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo);
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06004D51 RID: 19793 RVA: 0x000BBF9B File Offset: 0x000BA19B
		// (set) Token: 0x06004D52 RID: 19794 RVA: 0x000BBFB3 File Offset: 0x000BA1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopTaskCompleteInfo CoopTaskCompleteInfo
		{
			get
			{
				if (this.dataCase_ != CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
				{
					return null;
				}
				return (CoopTaskCompleteInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? CoopRoleInfoUpdateNotify.DataOneofCase.None : CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo);
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06004D53 RID: 19795 RVA: 0x000BBFC9 File Offset: 0x000BA1C9
		// (set) Token: 0x06004D54 RID: 19796 RVA: 0x000BBFE0 File Offset: 0x000BA1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreCompleteId
		{
			get
			{
				if (!this.HasPreCompleteId)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = CoopRoleInfoUpdateNotify.DataOneofCase.PreCompleteId;
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06004D55 RID: 19797 RVA: 0x000BBFF6 File Offset: 0x000BA1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPreCompleteId
		{
			get
			{
				return this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.PreCompleteId;
			}
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x000BC002 File Offset: 0x000BA202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPreCompleteId()
		{
			if (this.HasPreCompleteId)
			{
				this.ClearData();
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06004D57 RID: 19799 RVA: 0x000BC012 File Offset: 0x000BA212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleInfoUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x000BC01A File Offset: 0x000BA21A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = CoopRoleInfoUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x000BC02A File Offset: 0x000BA22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopRoleInfoUpdateNotify);
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x000BC038 File Offset: 0x000BA238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopRoleInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.CoopRoleInfo, other.CoopRoleInfo) && object.Equals(this.CoopTaskCompleteInfo, other.CoopTaskCompleteInfo) && this.PreCompleteId == other.PreCompleteId && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x000BC0BC File Offset: 0x000BA2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
			{
				num ^= this.CoopRoleInfo.GetHashCode();
			}
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
			{
				num ^= this.CoopTaskCompleteInfo.GetHashCode();
			}
			if (this.HasPreCompleteId)
			{
				num ^= this.PreCompleteId.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x000BC14B File Offset: 0x000BA34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x000BC158 File Offset: 0x000BA358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x000BC164 File Offset: 0x000BA364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CoopRoleInfo);
			}
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CoopTaskCompleteInfo);
			}
			if (this.HasPreCompleteId)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PreCompleteId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x000BC1F8 File Offset: 0x000BA3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CoopRoleInfo);
			}
			if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CoopTaskCompleteInfo);
			}
			if (this.HasPreCompleteId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreCompleteId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x000BC280 File Offset: 0x000BA480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CoopRoleInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			CoopRoleInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
			{
				if (dataCase != CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
				{
					if (dataCase == CoopRoleInfoUpdateNotify.DataOneofCase.PreCompleteId)
					{
						this.PreCompleteId = other.PreCompleteId;
					}
				}
				else
				{
					if (this.CoopTaskCompleteInfo == null)
					{
						this.CoopTaskCompleteInfo = new CoopTaskCompleteInfo();
					}
					this.CoopTaskCompleteInfo.MergeFrom(other.CoopTaskCompleteInfo);
				}
			}
			else
			{
				if (this.CoopRoleInfo == null)
				{
					this.CoopRoleInfo = new CoopRoleInfo();
				}
				this.CoopRoleInfo.MergeFrom(other.CoopRoleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x000BC32A File Offset: 0x000BA52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x000BC334 File Offset: 0x000BA534
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						CoopRoleInfo coopRoleInfo = new CoopRoleInfo();
						if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopRoleInfo)
						{
							coopRoleInfo.MergeFrom(this.CoopRoleInfo);
						}
						input.ReadMessage(coopRoleInfo);
						this.CoopRoleInfo = coopRoleInfo;
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						CoopTaskCompleteInfo coopTaskCompleteInfo = new CoopTaskCompleteInfo();
						if (this.dataCase_ == CoopRoleInfoUpdateNotify.DataOneofCase.CoopTaskCompleteInfo)
						{
							coopTaskCompleteInfo.MergeFrom(this.CoopTaskCompleteInfo);
						}
						input.ReadMessage(coopTaskCompleteInfo);
						this.CoopTaskCompleteInfo = coopTaskCompleteInfo;
						continue;
					}
					if (num == 88U)
					{
						this.PreCompleteId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003143 RID: 12611
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003144 RID: 12612
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04003145 RID: 12613
		private int activityId_;

		// Token: 0x04003146 RID: 12614
		public const int CoopRoleInfoFieldNumber = 2;

		// Token: 0x04003147 RID: 12615
		public const int CoopTaskCompleteInfoFieldNumber = 6;

		// Token: 0x04003148 RID: 12616
		public const int PreCompleteIdFieldNumber = 11;

		// Token: 0x04003149 RID: 12617
		private object data_;

		// Token: 0x0400314A RID: 12618
		private CoopRoleInfoUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x02001730 RID: 5936
		public enum DataOneofCase
		{
			// Token: 0x0400C596 RID: 50582
			None,
			// Token: 0x0400C597 RID: 50583
			CoopRoleInfo = 2,
			// Token: 0x0400C598 RID: 50584
			CoopTaskCompleteInfo = 6,
			// Token: 0x0400C599 RID: 50585
			PreCompleteId = 11
		}
	}
}

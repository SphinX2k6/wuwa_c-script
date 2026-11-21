using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000592 RID: 1426
	public sealed class FloroRanchActivityData : IMessage<FloroRanchActivityData>, IMessage, IEquatable<FloroRanchActivityData>, IDeepCloneable<FloroRanchActivityData>, IBufferMessage
	{
		// Token: 0x06008463 RID: 33891 RVA: 0x0013ED4C File Offset: 0x0013CF4C
		[NullableContext(1)]
		public static FloroRanchActivityData Create()
		{
			return new FloroRanchActivityData();
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x06008464 RID: 33892 RVA: 0x0013ED53 File Offset: 0x0013CF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06008465 RID: 33893 RVA: 0x0013ED56 File Offset: 0x0013CF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchActivityData.Descriptor;
			}
		}

		// Token: 0x06008466 RID: 33894 RVA: 0x0013ED5D File Offset: 0x0013CF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchActivityData()
		{
		}

		// Token: 0x06008467 RID: 33895 RVA: 0x0013ED68 File Offset: 0x0013CF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchActivityData(FloroRanchActivityData other) : this()
		{
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this.unSettleSubInsId_ = other.unSettleSubInsId_;
			this.stage_ = other.stage_;
			this.curWeeklyInsId_ = other.curWeeklyInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008468 RID: 33896 RVA: 0x0013EDCC File Offset: 0x0013CFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchActivityData Clone()
		{
			return new FloroRanchActivityData(this);
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06008469 RID: 33897 RVA: 0x0013EDD4 File Offset: 0x0013CFD4
		// (set) Token: 0x0600846A RID: 33898 RVA: 0x0013EDDC File Offset: 0x0013CFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayerInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x0600846B RID: 33899 RVA: 0x0013EDE5 File Offset: 0x0013CFE5
		// (set) Token: 0x0600846C RID: 33900 RVA: 0x0013EDED File Offset: 0x0013CFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnSettleSubInsId
		{
			get
			{
				return this.unSettleSubInsId_;
			}
			set
			{
				this.unSettleSubInsId_ = value;
			}
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x0600846D RID: 33901 RVA: 0x0013EDF6 File Offset: 0x0013CFF6
		// (set) Token: 0x0600846E RID: 33902 RVA: 0x0013EDFE File Offset: 0x0013CFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Stage
		{
			get
			{
				return this.stage_;
			}
			set
			{
				this.stage_ = value;
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x0600846F RID: 33903 RVA: 0x0013EE07 File Offset: 0x0013D007
		// (set) Token: 0x06008470 RID: 33904 RVA: 0x0013EE0F File Offset: 0x0013D00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurWeeklyInsId
		{
			get
			{
				return this.curWeeklyInsId_;
			}
			set
			{
				this.curWeeklyInsId_ = value;
			}
		}

		// Token: 0x06008471 RID: 33905 RVA: 0x0013EE18 File Offset: 0x0013D018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchActivityData);
		}

		// Token: 0x06008472 RID: 33906 RVA: 0x0013EE28 File Offset: 0x0013D028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchActivityData other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerInfo, other.PlayerInfo) && this.UnSettleSubInsId == other.UnSettleSubInsId && this.Stage == other.Stage && this.CurWeeklyInsId == other.CurWeeklyInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008473 RID: 33907 RVA: 0x0013EE98 File Offset: 0x0013D098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this.UnSettleSubInsId != 0)
			{
				num ^= this.UnSettleSubInsId.GetHashCode();
			}
			if (this.Stage != 0)
			{
				num ^= this.Stage.GetHashCode();
			}
			if (this.CurWeeklyInsId != 0)
			{
				num ^= this.CurWeeklyInsId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008474 RID: 33908 RVA: 0x0013EF1F File Offset: 0x0013D11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008475 RID: 33909 RVA: 0x0013EF2C File Offset: 0x0013D12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008476 RID: 33910 RVA: 0x0013EF38 File Offset: 0x0013D138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this.UnSettleSubInsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UnSettleSubInsId);
			}
			if (this.Stage != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Stage);
			}
			if (this.CurWeeklyInsId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurWeeklyInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008477 RID: 33911 RVA: 0x0013EFCC File Offset: 0x0013D1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this.UnSettleSubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnSettleSubInsId);
			}
			if (this.Stage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Stage);
			}
			if (this.CurWeeklyInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurWeeklyInsId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008478 RID: 33912 RVA: 0x0013F054 File Offset: 0x0013D254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new FloroRanchPlayerInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			if (other.UnSettleSubInsId != 0)
			{
				this.UnSettleSubInsId = other.UnSettleSubInsId;
			}
			if (other.Stage != 0)
			{
				this.Stage = other.Stage;
			}
			if (other.CurWeeklyInsId != 0)
			{
				this.CurWeeklyInsId = other.CurWeeklyInsId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008479 RID: 33913 RVA: 0x0013F0E4 File Offset: 0x0013D2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600847A RID: 33914 RVA: 0x0013F0F0 File Offset: 0x0013D2F0
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						if (this.playerInfo_ == null)
						{
							this.PlayerInfo = new FloroRanchPlayerInfo();
						}
						input.ReadMessage(this.PlayerInfo);
						continue;
					}
					if (num == 16U)
					{
						this.UnSettleSubInsId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Stage = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CurWeeklyInsId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400420E RID: 16910
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400420F RID: 16911
		public const int PlayerInfoFieldNumber = 1;

		// Token: 0x04004210 RID: 16912
		private FloroRanchPlayerInfo playerInfo_;

		// Token: 0x04004211 RID: 16913
		public const int UnSettleSubInsIdFieldNumber = 2;

		// Token: 0x04004212 RID: 16914
		private int unSettleSubInsId_;

		// Token: 0x04004213 RID: 16915
		public const int StageFieldNumber = 3;

		// Token: 0x04004214 RID: 16916
		private int stage_;

		// Token: 0x04004215 RID: 16917
		public const int CurWeeklyInsIdFieldNumber = 4;

		// Token: 0x04004216 RID: 16918
		private int curWeeklyInsId_;
	}
}

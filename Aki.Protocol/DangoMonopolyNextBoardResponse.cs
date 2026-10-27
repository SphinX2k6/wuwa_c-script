using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038A RID: 906
	[NetMessage(EMessageId.DangoMonopolyNextBoardResponse)]
	public sealed class DangoMonopolyNextBoardResponse : IMessage<DangoMonopolyNextBoardResponse>, IMessage, IEquatable<DangoMonopolyNextBoardResponse>, IDeepCloneable<DangoMonopolyNextBoardResponse>, IBufferMessage
	{
		// Token: 0x06005993 RID: 22931 RVA: 0x000DA191 File Offset: 0x000D8391
		[NullableContext(1)]
		public static DangoMonopolyNextBoardResponse Create()
		{
			return new DangoMonopolyNextBoardResponse();
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06005994 RID: 22932 RVA: 0x000DA198 File Offset: 0x000D8398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06005995 RID: 22933 RVA: 0x000DA19B File Offset: 0x000D839B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyNextBoardResponse.Descriptor;
			}
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x000DA1A2 File Offset: 0x000D83A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardResponse()
		{
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x000DA1B8 File Offset: 0x000D83B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardResponse(DangoMonopolyNextBoardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.boardId_ = other.boardId_;
			this.propertyIds_ = other.propertyIds_.Clone();
			this.boardUnlockTime_ = other.boardUnlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005998 RID: 22936 RVA: 0x000DA211 File Offset: 0x000D8411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardResponse Clone()
		{
			return new DangoMonopolyNextBoardResponse(this);
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06005999 RID: 22937 RVA: 0x000DA219 File Offset: 0x000D8419
		// (set) Token: 0x0600599A RID: 22938 RVA: 0x000DA221 File Offset: 0x000D8421
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

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x0600599B RID: 22939 RVA: 0x000DA22A File Offset: 0x000D842A
		// (set) Token: 0x0600599C RID: 22940 RVA: 0x000DA232 File Offset: 0x000D8432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoardId
		{
			get
			{
				return this.boardId_;
			}
			set
			{
				this.boardId_ = value;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x0600599D RID: 22941 RVA: 0x000DA23B File Offset: 0x000D843B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PropertyIds
		{
			get
			{
				return this.propertyIds_;
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x0600599E RID: 22942 RVA: 0x000DA243 File Offset: 0x000D8443
		// (set) Token: 0x0600599F RID: 22943 RVA: 0x000DA24B File Offset: 0x000D844B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BoardUnlockTime
		{
			get
			{
				return this.boardUnlockTime_;
			}
			set
			{
				this.boardUnlockTime_ = value;
			}
		}

		// Token: 0x060059A0 RID: 22944 RVA: 0x000DA254 File Offset: 0x000D8454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyNextBoardResponse);
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x000DA264 File Offset: 0x000D8464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyNextBoardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.BoardId == other.BoardId && this.propertyIds_.Equals(other.propertyIds_) && this.BoardUnlockTime == other.BoardUnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x000DA2D4 File Offset: 0x000D84D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.BoardId != 0)
			{
				num ^= this.BoardId.GetHashCode();
			}
			num ^= this.propertyIds_.GetHashCode();
			if (this.BoardUnlockTime != 0L)
			{
				num ^= this.BoardUnlockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x000DA359 File Offset: 0x000D8559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060059A4 RID: 22948 RVA: 0x000DA366 File Offset: 0x000D8566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059A5 RID: 22949 RVA: 0x000DA370 File Offset: 0x000D8570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.propertyIds_.WriteTo(ref output, DangoMonopolyNextBoardResponse._repeated_propertyIds_codec);
			if (this.BoardId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BoardId);
			}
			if (this.BoardUnlockTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.BoardUnlockTime);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059A6 RID: 22950 RVA: 0x000DA3F8 File Offset: 0x000D85F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.BoardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoardId);
			}
			num += this.propertyIds_.CalculateSize(DangoMonopolyNextBoardResponse._repeated_propertyIds_codec);
			if (this.BoardUnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BoardUnlockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x000DA47C File Offset: 0x000D867C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyNextBoardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.BoardId != 0)
			{
				this.BoardId = other.BoardId;
			}
			this.propertyIds_.Add(other.propertyIds_);
			if (other.BoardUnlockTime != 0L)
			{
				this.BoardUnlockTime = other.BoardUnlockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x000DA4F1 File Offset: 0x000D86F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059A9 RID: 22953 RVA: 0x000DA4FC File Offset: 0x000D86FC
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
					if (num == 16U || num == 18U)
					{
						this.propertyIds_.AddEntriesFrom(ref input, DangoMonopolyNextBoardResponse._repeated_propertyIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.BoardId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.BoardUnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400356C RID: 13676
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400356D RID: 13677
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400356E RID: 13678
		private ErrorCode errorCode_;

		// Token: 0x0400356F RID: 13679
		public const int BoardIdFieldNumber = 4;

		// Token: 0x04003570 RID: 13680
		private int boardId_;

		// Token: 0x04003571 RID: 13681
		public const int PropertyIdsFieldNumber = 2;

		// Token: 0x04003572 RID: 13682
		private static readonly FieldCodec<int> _repeated_propertyIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003573 RID: 13683
		private readonly RepeatedField<int> propertyIds_ = new RepeatedField<int>();

		// Token: 0x04003574 RID: 13684
		public const int BoardUnlockTimeFieldNumber = 10;

		// Token: 0x04003575 RID: 13685
		private long boardUnlockTime_;
	}
}

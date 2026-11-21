using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0A RID: 2570
	[NetMessage(EMessageId.MoraleTreasureBoxTraceResponse)]
	public sealed class MoraleTreasureBoxTraceResponse : IMessage<MoraleTreasureBoxTraceResponse>, IMessage, IEquatable<MoraleTreasureBoxTraceResponse>, IDeepCloneable<MoraleTreasureBoxTraceResponse>, IBufferMessage
	{
		// Token: 0x0600E124 RID: 57636 RVA: 0x0020FF6D File Offset: 0x0020E16D
		[NullableContext(1)]
		public static MoraleTreasureBoxTraceResponse Create()
		{
			return new MoraleTreasureBoxTraceResponse();
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x0600E125 RID: 57637 RVA: 0x0020FF74 File Offset: 0x0020E174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x0600E126 RID: 57638 RVA: 0x0020FF77 File Offset: 0x0020E177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoraleTreasureBoxTraceResponse.Descriptor;
			}
		}

		// Token: 0x0600E127 RID: 57639 RVA: 0x0020FF7E File Offset: 0x0020E17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceResponse()
		{
		}

		// Token: 0x0600E128 RID: 57640 RVA: 0x0020FF94 File Offset: 0x0020E194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceResponse(MoraleTreasureBoxTraceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.areaPos_ = other.areaPos_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E129 RID: 57641 RVA: 0x0020FFE1 File Offset: 0x0020E1E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceResponse Clone()
		{
			return new MoraleTreasureBoxTraceResponse(this);
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x0600E12A RID: 57642 RVA: 0x0020FFE9 File Offset: 0x0020E1E9
		// (set) Token: 0x0600E12B RID: 57643 RVA: 0x0020FFF1 File Offset: 0x0020E1F1
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

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x0600E12C RID: 57644 RVA: 0x0020FFFA File Offset: 0x0020E1FA
		// (set) Token: 0x0600E12D RID: 57645 RVA: 0x00210002 File Offset: 0x0020E202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaPos
		{
			get
			{
				return this.areaPos_;
			}
			set
			{
				this.areaPos_ = value;
			}
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x0600E12E RID: 57646 RVA: 0x0021000B File Offset: 0x0020E20B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0600E12F RID: 57647 RVA: 0x00210013 File Offset: 0x0020E213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoraleTreasureBoxTraceResponse);
		}

		// Token: 0x0600E130 RID: 57648 RVA: 0x00210024 File Offset: 0x0020E224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoraleTreasureBoxTraceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.AreaPos == other.AreaPos && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E131 RID: 57649 RVA: 0x00210084 File Offset: 0x0020E284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.AreaPos != 0)
			{
				num ^= this.AreaPos.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E132 RID: 57650 RVA: 0x002100F0 File Offset: 0x0020E2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E133 RID: 57651 RVA: 0x002100FD File Offset: 0x0020E2FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E134 RID: 57652 RVA: 0x00210108 File Offset: 0x0020E308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.AreaPos != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.AreaPos);
			}
			this.entityIds_.WriteTo(ref output, MoraleTreasureBoxTraceResponse._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E135 RID: 57653 RVA: 0x00210174 File Offset: 0x0020E374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.AreaPos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaPos);
			}
			num += this.entityIds_.CalculateSize(MoraleTreasureBoxTraceResponse._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E136 RID: 57654 RVA: 0x002101E0 File Offset: 0x0020E3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoraleTreasureBoxTraceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.AreaPos != 0)
			{
				this.AreaPos = other.AreaPos;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E137 RID: 57655 RVA: 0x00210241 File Offset: 0x0020E441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E138 RID: 57656 RVA: 0x0021024C File Offset: 0x0020E44C
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
				if (num <= 72U)
				{
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.AreaPos = input.ReadInt32();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.entityIds_.AddEntriesFrom(ref input, MoraleTreasureBoxTraceResponse._repeated_entityIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005CEE RID: 23790
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CEF RID: 23791
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04005CF0 RID: 23792
		private ErrorCode errorCode_;

		// Token: 0x04005CF1 RID: 23793
		public const int AreaPosFieldNumber = 9;

		// Token: 0x04005CF2 RID: 23794
		private int areaPos_;

		// Token: 0x04005CF3 RID: 23795
		public const int EntityIdsFieldNumber = 14;

		// Token: 0x04005CF4 RID: 23796
		private static readonly FieldCodec<int> _repeated_entityIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04005CF5 RID: 23797
		private readonly RepeatedField<int> entityIds_ = new RepeatedField<int>();
	}
}

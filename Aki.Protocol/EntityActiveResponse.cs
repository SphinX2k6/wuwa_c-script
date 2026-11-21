using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044D RID: 1101
	[NetMessage(EMessageId.EntityActiveResponse)]
	public sealed class EntityActiveResponse : IMessage<EntityActiveResponse>, IMessage, IEquatable<EntityActiveResponse>, IDeepCloneable<EntityActiveResponse>, IBufferMessage
	{
		// Token: 0x060069B6 RID: 27062 RVA: 0x000FFAA4 File Offset: 0x000FDCA4
		[NullableContext(1)]
		public static EntityActiveResponse Create()
		{
			return new EntityActiveResponse();
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060069B7 RID: 27063 RVA: 0x000FFAAB File Offset: 0x000FDCAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060069B8 RID: 27064 RVA: 0x000FFAAE File Offset: 0x000FDCAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityActiveResponse.Descriptor;
			}
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x000FFAB5 File Offset: 0x000FDCB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityActiveResponse()
		{
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x000FFAC8 File Offset: 0x000FDCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityActiveResponse(EntityActiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.componentPbs_ = other.componentPbs_.Clone();
			this.isVisible_ = other.isVisible_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.aiControlPlayerId_ = other.aiControlPlayerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x000FFB59 File Offset: 0x000FDD59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityActiveResponse Clone()
		{
			return new EntityActiveResponse(this);
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060069BC RID: 27068 RVA: 0x000FFB61 File Offset: 0x000FDD61
		// (set) Token: 0x060069BD RID: 27069 RVA: 0x000FFB69 File Offset: 0x000FDD69
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

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060069BE RID: 27070 RVA: 0x000FFB72 File Offset: 0x000FDD72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityComponentPb> ComponentPbs
		{
			get
			{
				return this.componentPbs_;
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060069BF RID: 27071 RVA: 0x000FFB7A File Offset: 0x000FDD7A
		// (set) Token: 0x060069C0 RID: 27072 RVA: 0x000FFB82 File Offset: 0x000FDD82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVisible
		{
			get
			{
				return this.isVisible_;
			}
			set
			{
				this.isVisible_ = value;
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060069C1 RID: 27073 RVA: 0x000FFB8B File Offset: 0x000FDD8B
		// (set) Token: 0x060069C2 RID: 27074 RVA: 0x000FFB93 File Offset: 0x000FDD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x060069C3 RID: 27075 RVA: 0x000FFB9C File Offset: 0x000FDD9C
		// (set) Token: 0x060069C4 RID: 27076 RVA: 0x000FFBA4 File Offset: 0x000FDDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x060069C5 RID: 27077 RVA: 0x000FFBAD File Offset: 0x000FDDAD
		// (set) Token: 0x060069C6 RID: 27078 RVA: 0x000FFBB5 File Offset: 0x000FDDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AiControlPlayerId
		{
			get
			{
				return this.aiControlPlayerId_;
			}
			set
			{
				this.aiControlPlayerId_ = value;
			}
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x000FFBBE File Offset: 0x000FDDBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityActiveResponse);
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x000FFBCC File Offset: 0x000FDDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityActiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.componentPbs_.Equals(other.componentPbs_) && this.IsVisible == other.IsVisible && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.AiControlPlayerId == other.AiControlPlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x000FFC64 File Offset: 0x000FDE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.componentPbs_.GetHashCode();
			if (this.IsVisible)
			{
				num ^= this.IsVisible.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this.AiControlPlayerId != 0)
			{
				num ^= this.AiControlPlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060069CA RID: 27082 RVA: 0x000FFD15 File Offset: 0x000FDF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060069CB RID: 27083 RVA: 0x000FFD22 File Offset: 0x000FDF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069CC RID: 27084 RVA: 0x000FFD2C File Offset: 0x000FDF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AiControlPlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.AiControlPlayerId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Rot);
			}
			if (this.IsVisible)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsVisible);
			}
			this.componentPbs_.WriteTo(ref output, EntityActiveResponse._repeated_componentPbs_codec);
			if (this.pos_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069CD RID: 27085 RVA: 0x000FFDEC File Offset: 0x000FDFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.componentPbs_.CalculateSize(EntityActiveResponse._repeated_componentPbs_codec);
			if (this.IsVisible)
			{
				num += 2;
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this.AiControlPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AiControlPlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x000FFE94 File Offset: 0x000FE094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityActiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.componentPbs_.Add(other.componentPbs_);
			if (other.IsVisible)
			{
				this.IsVisible = other.IsVisible;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Rotator();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			if (other.AiControlPlayerId != 0)
			{
				this.AiControlPlayerId = other.AiControlPlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x000FFF61 File Offset: 0x000FE161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x000FFF6C File Offset: 0x000FE16C
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
				if (num <= 82U)
				{
					if (num == 56U)
					{
						this.AiControlPlayerId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 82U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.IsVisible = input.ReadBool();
						continue;
					}
					if (num == 106U)
					{
						this.componentPbs_.AddEntriesFrom(ref input, EntityActiveResponse._repeated_componentPbs_codec);
						continue;
					}
					if (num == 122U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A72 RID: 14962
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A73 RID: 14963
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003A74 RID: 14964
		private ErrorCode errorCode_;

		// Token: 0x04003A75 RID: 14965
		public const int ComponentPbsFieldNumber = 13;

		// Token: 0x04003A76 RID: 14966
		private static readonly FieldCodec<EntityComponentPb> _repeated_componentPbs_codec = FieldCodec.ForMessage<EntityComponentPb>(106U, EntityComponentPb.Parser);

		// Token: 0x04003A77 RID: 14967
		private readonly RepeatedField<EntityComponentPb> componentPbs_ = new RepeatedField<EntityComponentPb>();

		// Token: 0x04003A78 RID: 14968
		public const int IsVisibleFieldNumber = 12;

		// Token: 0x04003A79 RID: 14969
		private bool isVisible_;

		// Token: 0x04003A7A RID: 14970
		public const int PosFieldNumber = 15;

		// Token: 0x04003A7B RID: 14971
		private Vector pos_;

		// Token: 0x04003A7C RID: 14972
		public const int RotFieldNumber = 10;

		// Token: 0x04003A7D RID: 14973
		private Rotator rot_;

		// Token: 0x04003A7E RID: 14974
		public const int AiControlPlayerIdFieldNumber = 7;

		// Token: 0x04003A7F RID: 14975
		private int aiControlPlayerId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000464 RID: 1124
	[NetMessage(EMessageId.EntityActiveResponse)]
	public sealed class EntityActiveResponse : IMessage<EntityActiveResponse>, IMessage, IEquatable<EntityActiveResponse>, IDeepCloneable<EntityActiveResponse>, IBufferMessage
	{
		// Token: 0x06006B44 RID: 27460 RVA: 0x00102B0D File Offset: 0x00100D0D
		[NullableContext(1)]
		public static EntityActiveResponse Create()
		{
			return new EntityActiveResponse();
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06006B45 RID: 27461 RVA: 0x00102B14 File Offset: 0x00100D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06006B46 RID: 27462 RVA: 0x00102B17 File Offset: 0x00100D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityActiveResponse.Descriptor;
			}
		}

		// Token: 0x06006B47 RID: 27463 RVA: 0x00102B1E File Offset: 0x00100D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityActiveResponse()
		{
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x00102B34 File Offset: 0x00100D34
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

		// Token: 0x06006B49 RID: 27465 RVA: 0x00102BC5 File Offset: 0x00100DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityActiveResponse Clone()
		{
			return new EntityActiveResponse(this);
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06006B4A RID: 27466 RVA: 0x00102BCD File Offset: 0x00100DCD
		// (set) Token: 0x06006B4B RID: 27467 RVA: 0x00102BD5 File Offset: 0x00100DD5
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

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06006B4C RID: 27468 RVA: 0x00102BDE File Offset: 0x00100DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityComponentPb> ComponentPbs
		{
			get
			{
				return this.componentPbs_;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06006B4D RID: 27469 RVA: 0x00102BE6 File Offset: 0x00100DE6
		// (set) Token: 0x06006B4E RID: 27470 RVA: 0x00102BEE File Offset: 0x00100DEE
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

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06006B4F RID: 27471 RVA: 0x00102BF7 File Offset: 0x00100DF7
		// (set) Token: 0x06006B50 RID: 27472 RVA: 0x00102BFF File Offset: 0x00100DFF
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

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06006B51 RID: 27473 RVA: 0x00102C08 File Offset: 0x00100E08
		// (set) Token: 0x06006B52 RID: 27474 RVA: 0x00102C10 File Offset: 0x00100E10
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

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06006B53 RID: 27475 RVA: 0x00102C19 File Offset: 0x00100E19
		// (set) Token: 0x06006B54 RID: 27476 RVA: 0x00102C21 File Offset: 0x00100E21
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

		// Token: 0x06006B55 RID: 27477 RVA: 0x00102C2A File Offset: 0x00100E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityActiveResponse);
		}

		// Token: 0x06006B56 RID: 27478 RVA: 0x00102C38 File Offset: 0x00100E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityActiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.componentPbs_.Equals(other.componentPbs_) && this.IsVisible == other.IsVisible && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.AiControlPlayerId == other.AiControlPlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B57 RID: 27479 RVA: 0x00102CD0 File Offset: 0x00100ED0
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

		// Token: 0x06006B58 RID: 27480 RVA: 0x00102D81 File Offset: 0x00100F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x00102D8E File Offset: 0x00100F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B5A RID: 27482 RVA: 0x00102D98 File Offset: 0x00100F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Pos);
			}
			if (this.AiControlPlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AiControlPlayerId);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Rot);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.componentPbs_.WriteTo(ref output, EntityActiveResponse._repeated_componentPbs_codec);
			if (this.IsVisible)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsVisible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B5B RID: 27483 RVA: 0x00102E58 File Offset: 0x00101058
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

		// Token: 0x06006B5C RID: 27484 RVA: 0x00102F00 File Offset: 0x00101100
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

		// Token: 0x06006B5D RID: 27485 RVA: 0x00102FCD File Offset: 0x001011CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x00102FD8 File Offset: 0x001011D8
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
				if (num <= 34U)
				{
					if (num == 18U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
					if (num == 24U)
					{
						this.AiControlPlayerId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
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
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 90U)
					{
						this.componentPbs_.AddEntriesFrom(ref input, EntityActiveResponse._repeated_componentPbs_codec);
						continue;
					}
					if (num == 96U)
					{
						this.IsVisible = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A84 RID: 14980
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A85 RID: 14981
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003A86 RID: 14982
		private ErrorCode errorCode_;

		// Token: 0x04003A87 RID: 14983
		public const int ComponentPbsFieldNumber = 11;

		// Token: 0x04003A88 RID: 14984
		private static readonly FieldCodec<EntityComponentPb> _repeated_componentPbs_codec = FieldCodec.ForMessage<EntityComponentPb>(90U, EntityComponentPb.Parser);

		// Token: 0x04003A89 RID: 14985
		private readonly RepeatedField<EntityComponentPb> componentPbs_ = new RepeatedField<EntityComponentPb>();

		// Token: 0x04003A8A RID: 14986
		public const int IsVisibleFieldNumber = 12;

		// Token: 0x04003A8B RID: 14987
		private bool isVisible_;

		// Token: 0x04003A8C RID: 14988
		public const int PosFieldNumber = 2;

		// Token: 0x04003A8D RID: 14989
		private Vector pos_;

		// Token: 0x04003A8E RID: 14990
		public const int RotFieldNumber = 4;

		// Token: 0x04003A8F RID: 14991
		private Rotator rot_;

		// Token: 0x04003A90 RID: 14992
		public const int AiControlPlayerIdFieldNumber = 3;

		// Token: 0x04003A91 RID: 14993
		private int aiControlPlayerId_;
	}
}

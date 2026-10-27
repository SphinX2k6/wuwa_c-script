using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108C RID: 4236
	public sealed class RoleMotion : IMessage<RoleMotion>, IMessage, IEquatable<RoleMotion>, IDeepCloneable<RoleMotion>, IBufferMessage
	{
		// Token: 0x06016A1E RID: 92702 RVA: 0x0034A642 File Offset: 0x00348842
		[NullableContext(1)]
		public static RoleMotion Create()
		{
			return new RoleMotion();
		}

		// Token: 0x17004BD3 RID: 19411
		// (get) Token: 0x06016A1F RID: 92703 RVA: 0x0034A649 File Offset: 0x00348849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleMotion> Parser
		{
			get
			{
				return RoleMotion._parser;
			}
		}

		// Token: 0x17004BD4 RID: 19412
		// (get) Token: 0x06016A20 RID: 92704 RVA: 0x0034A650 File Offset: 0x00348850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BD5 RID: 19413
		// (get) Token: 0x06016A21 RID: 92705 RVA: 0x0034A653 File Offset: 0x00348853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotion.Descriptor;
			}
		}

		// Token: 0x06016A22 RID: 92706 RVA: 0x0034A65A File Offset: 0x0034885A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotion()
		{
		}

		// Token: 0x06016A23 RID: 92707 RVA: 0x0034A66D File Offset: 0x0034886D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotion(RoleMotion other) : this()
		{
			this.roleId_ = other.roleId_;
			this.motionIds_ = other.motionIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A24 RID: 92708 RVA: 0x0034A6A3 File Offset: 0x003488A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotion Clone()
		{
			return new RoleMotion(this);
		}

		// Token: 0x17004BD6 RID: 19414
		// (get) Token: 0x06016A25 RID: 92709 RVA: 0x0034A6AB File Offset: 0x003488AB
		// (set) Token: 0x06016A26 RID: 92710 RVA: 0x0034A6B3 File Offset: 0x003488B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004BD7 RID: 19415
		// (get) Token: 0x06016A27 RID: 92711 RVA: 0x0034A6BC File Offset: 0x003488BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FavorItem> MotionIds
		{
			get
			{
				return this.motionIds_;
			}
		}

		// Token: 0x06016A28 RID: 92712 RVA: 0x0034A6C4 File Offset: 0x003488C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotion);
		}

		// Token: 0x06016A29 RID: 92713 RVA: 0x0034A6D4 File Offset: 0x003488D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotion other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.motionIds_.Equals(other.motionIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A2A RID: 92714 RVA: 0x0034A724 File Offset: 0x00348924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.motionIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016A2B RID: 92715 RVA: 0x0034A771 File Offset: 0x00348971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A2C RID: 92716 RVA: 0x0034A77E File Offset: 0x0034897E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A2D RID: 92717 RVA: 0x0034A788 File Offset: 0x00348988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			this.motionIds_.WriteTo(ref output, RoleMotion._repeated_motionIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A2E RID: 92718 RVA: 0x0034A7D8 File Offset: 0x003489D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.motionIds_.CalculateSize(RoleMotion._repeated_motionIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016A2F RID: 92719 RVA: 0x0034A82C File Offset: 0x00348A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleMotion other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.motionIds_.Add(other.motionIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016A30 RID: 92720 RVA: 0x0034A879 File Offset: 0x00348A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A31 RID: 92721 RVA: 0x0034A884 File Offset: 0x00348A84
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.motionIds_.AddEntriesFrom(ref input, RoleMotion._repeated_motionIds_codec);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400874E RID: 34638
		private static readonly MessageParser<RoleMotion> _parser = new MessageParser<RoleMotion>(() => new RoleMotion());

		// Token: 0x0400874F RID: 34639
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008750 RID: 34640
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008751 RID: 34641
		private int roleId_;

		// Token: 0x04008752 RID: 34642
		public const int MotionIdsFieldNumber = 2;

		// Token: 0x04008753 RID: 34643
		private static readonly FieldCodec<FavorItem> _repeated_motionIds_codec = FieldCodec.ForMessage<FavorItem>(18U, FavorItem.Parser);

		// Token: 0x04008754 RID: 34644
		private readonly RepeatedField<FavorItem> motionIds_ = new RepeatedField<FavorItem>();
	}
}

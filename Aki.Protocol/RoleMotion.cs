using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107C RID: 4220
	public sealed class RoleMotion : IMessage<RoleMotion>, IMessage, IEquatable<RoleMotion>, IDeepCloneable<RoleMotion>, IBufferMessage
	{
		// Token: 0x06016939 RID: 92473 RVA: 0x00348F6A File Offset: 0x0034716A
		[NullableContext(1)]
		public static RoleMotion Create()
		{
			return new RoleMotion();
		}

		// Token: 0x17004BA9 RID: 19369
		// (get) Token: 0x0601693A RID: 92474 RVA: 0x00348F71 File Offset: 0x00347171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleMotion> Parser
		{
			get
			{
				return RoleMotion._parser;
			}
		}

		// Token: 0x17004BAA RID: 19370
		// (get) Token: 0x0601693B RID: 92475 RVA: 0x00348F78 File Offset: 0x00347178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BAB RID: 19371
		// (get) Token: 0x0601693C RID: 92476 RVA: 0x00348F7B File Offset: 0x0034717B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotion.Descriptor;
			}
		}

		// Token: 0x0601693D RID: 92477 RVA: 0x00348F82 File Offset: 0x00347182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotion()
		{
		}

		// Token: 0x0601693E RID: 92478 RVA: 0x00348F95 File Offset: 0x00347195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotion(RoleMotion other) : this()
		{
			this.roleId_ = other.roleId_;
			this.motionIds_ = other.motionIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601693F RID: 92479 RVA: 0x00348FCB File Offset: 0x003471CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotion Clone()
		{
			return new RoleMotion(this);
		}

		// Token: 0x17004BAC RID: 19372
		// (get) Token: 0x06016940 RID: 92480 RVA: 0x00348FD3 File Offset: 0x003471D3
		// (set) Token: 0x06016941 RID: 92481 RVA: 0x00348FDB File Offset: 0x003471DB
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

		// Token: 0x17004BAD RID: 19373
		// (get) Token: 0x06016942 RID: 92482 RVA: 0x00348FE4 File Offset: 0x003471E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FavorItem> MotionIds
		{
			get
			{
				return this.motionIds_;
			}
		}

		// Token: 0x06016943 RID: 92483 RVA: 0x00348FEC File Offset: 0x003471EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotion);
		}

		// Token: 0x06016944 RID: 92484 RVA: 0x00348FFC File Offset: 0x003471FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotion other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.motionIds_.Equals(other.motionIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016945 RID: 92485 RVA: 0x0034904C File Offset: 0x0034724C
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

		// Token: 0x06016946 RID: 92486 RVA: 0x00349099 File Offset: 0x00347299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016947 RID: 92487 RVA: 0x003490A6 File Offset: 0x003472A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016948 RID: 92488 RVA: 0x003490B0 File Offset: 0x003472B0
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

		// Token: 0x06016949 RID: 92489 RVA: 0x00349100 File Offset: 0x00347300
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

		// Token: 0x0601694A RID: 92490 RVA: 0x00349154 File Offset: 0x00347354
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

		// Token: 0x0601694B RID: 92491 RVA: 0x003491A1 File Offset: 0x003473A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601694C RID: 92492 RVA: 0x003491AC File Offset: 0x003473AC
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

		// Token: 0x04008778 RID: 34680
		private static readonly MessageParser<RoleMotion> _parser = new MessageParser<RoleMotion>(() => new RoleMotion());

		// Token: 0x04008779 RID: 34681
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400877A RID: 34682
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400877B RID: 34683
		private int roleId_;

		// Token: 0x0400877C RID: 34684
		public const int MotionIdsFieldNumber = 2;

		// Token: 0x0400877D RID: 34685
		private static readonly FieldCodec<FavorItem> _repeated_motionIds_codec = FieldCodec.ForMessage<FavorItem>(18U, FavorItem.Parser);

		// Token: 0x0400877E RID: 34686
		private readonly RepeatedField<FavorItem> motionIds_ = new RepeatedField<FavorItem>();
	}
}

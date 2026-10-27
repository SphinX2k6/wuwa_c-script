using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108F RID: 4239
	[NetMessage(EMessageId.RoleMotionListNotify)]
	public sealed class RoleMotionListNotify : IMessage<RoleMotionListNotify>, IMessage, IEquatable<RoleMotionListNotify>, IDeepCloneable<RoleMotionListNotify>, IBufferMessage
	{
		// Token: 0x06016A57 RID: 92759 RVA: 0x0034AD23 File Offset: 0x00348F23
		[NullableContext(1)]
		public static RoleMotionListNotify Create()
		{
			return new RoleMotionListNotify();
		}

		// Token: 0x17004BDE RID: 19422
		// (get) Token: 0x06016A58 RID: 92760 RVA: 0x0034AD2A File Offset: 0x00348F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BDF RID: 19423
		// (get) Token: 0x06016A59 RID: 92761 RVA: 0x0034AD2D File Offset: 0x00348F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionListNotify.Descriptor;
			}
		}

		// Token: 0x06016A5A RID: 92762 RVA: 0x0034AD34 File Offset: 0x00348F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionListNotify()
		{
		}

		// Token: 0x06016A5B RID: 92763 RVA: 0x0034AD52 File Offset: 0x00348F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionListNotify(RoleMotionListNotify other) : this()
		{
			this.motionList_ = other.motionList_.Clone();
			this.roleConditionInfoMap_ = other.roleConditionInfoMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A5C RID: 92764 RVA: 0x0034AD8D File Offset: 0x00348F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionListNotify Clone()
		{
			return new RoleMotionListNotify(this);
		}

		// Token: 0x17004BE0 RID: 19424
		// (get) Token: 0x06016A5D RID: 92765 RVA: 0x0034AD95 File Offset: 0x00348F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleMotion> MotionList
		{
			get
			{
				return this.motionList_;
			}
		}

		// Token: 0x17004BE1 RID: 19425
		// (get) Token: 0x06016A5E RID: 92766 RVA: 0x0034AD9D File Offset: 0x00348F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ConditionInfo> RoleConditionInfoMap
		{
			get
			{
				return this.roleConditionInfoMap_;
			}
		}

		// Token: 0x06016A5F RID: 92767 RVA: 0x0034ADA5 File Offset: 0x00348FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionListNotify);
		}

		// Token: 0x06016A60 RID: 92768 RVA: 0x0034ADB4 File Offset: 0x00348FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionListNotify other)
		{
			return other != null && (other == this || (this.motionList_.Equals(other.motionList_) && this.RoleConditionInfoMap.Equals(other.RoleConditionInfoMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A61 RID: 92769 RVA: 0x0034AE08 File Offset: 0x00349008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motionList_.GetHashCode();
			num ^= this.RoleConditionInfoMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016A62 RID: 92770 RVA: 0x0034AE4A File Offset: 0x0034904A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A63 RID: 92771 RVA: 0x0034AE57 File Offset: 0x00349057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A64 RID: 92772 RVA: 0x0034AE60 File Offset: 0x00349060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motionList_.WriteTo(ref output, RoleMotionListNotify._repeated_motionList_codec);
			this.roleConditionInfoMap_.WriteTo(ref output, RoleMotionListNotify._map_roleConditionInfoMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A65 RID: 92773 RVA: 0x0034AE98 File Offset: 0x00349098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motionList_.CalculateSize(RoleMotionListNotify._repeated_motionList_codec);
			num += this.roleConditionInfoMap_.CalculateSize(RoleMotionListNotify._map_roleConditionInfoMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016A66 RID: 92774 RVA: 0x0034AEE4 File Offset: 0x003490E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleMotionListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.motionList_.Add(other.motionList_);
			this.roleConditionInfoMap_.MergeFrom(other.roleConditionInfoMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016A67 RID: 92775 RVA: 0x0034AF23 File Offset: 0x00349123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A68 RID: 92776 RVA: 0x0034AF2C File Offset: 0x0034912C
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
				if (num != 34U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleConditionInfoMap_.AddEntriesFrom(ref input, RoleMotionListNotify._map_roleConditionInfoMap_codec);
					}
				}
				else
				{
					this.motionList_.AddEntriesFrom(ref input, RoleMotionListNotify._repeated_motionList_codec);
				}
			}
		}

		// Token: 0x0400875C RID: 34652
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400875D RID: 34653
		public const int MotionListFieldNumber = 4;

		// Token: 0x0400875E RID: 34654
		private static readonly FieldCodec<RoleMotion> _repeated_motionList_codec = FieldCodec.ForMessage<RoleMotion>(34U, RoleMotion.Parser);

		// Token: 0x0400875F RID: 34655
		private readonly RepeatedField<RoleMotion> motionList_ = new RepeatedField<RoleMotion>();

		// Token: 0x04008760 RID: 34656
		public const int RoleConditionInfoMapFieldNumber = 5;

		// Token: 0x04008761 RID: 34657
		private static readonly MapField<int, ConditionInfo>.Codec _map_roleConditionInfoMap_codec = new MapField<int, ConditionInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ConditionInfo>(18U, ConditionInfo.Parser), 42U);

		// Token: 0x04008762 RID: 34658
		private readonly MapField<int, ConditionInfo> roleConditionInfoMap_ = new MapField<int, ConditionInfo>();
	}
}

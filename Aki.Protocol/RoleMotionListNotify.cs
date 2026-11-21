using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107F RID: 4223
	[NetMessage(EMessageId.RoleMotionListNotify)]
	public sealed class RoleMotionListNotify : IMessage<RoleMotionListNotify>, IMessage, IEquatable<RoleMotionListNotify>, IDeepCloneable<RoleMotionListNotify>, IBufferMessage
	{
		// Token: 0x06016972 RID: 92530 RVA: 0x0034964B File Offset: 0x0034784B
		[NullableContext(1)]
		public static RoleMotionListNotify Create()
		{
			return new RoleMotionListNotify();
		}

		// Token: 0x17004BB4 RID: 19380
		// (get) Token: 0x06016973 RID: 92531 RVA: 0x00349652 File Offset: 0x00347852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BB5 RID: 19381
		// (get) Token: 0x06016974 RID: 92532 RVA: 0x00349655 File Offset: 0x00347855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionListNotify.Descriptor;
			}
		}

		// Token: 0x06016975 RID: 92533 RVA: 0x0034965C File Offset: 0x0034785C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionListNotify()
		{
		}

		// Token: 0x06016976 RID: 92534 RVA: 0x0034967A File Offset: 0x0034787A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionListNotify(RoleMotionListNotify other) : this()
		{
			this.motionList_ = other.motionList_.Clone();
			this.roleConditionInfoMap_ = other.roleConditionInfoMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016977 RID: 92535 RVA: 0x003496B5 File Offset: 0x003478B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionListNotify Clone()
		{
			return new RoleMotionListNotify(this);
		}

		// Token: 0x17004BB6 RID: 19382
		// (get) Token: 0x06016978 RID: 92536 RVA: 0x003496BD File Offset: 0x003478BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleMotion> MotionList
		{
			get
			{
				return this.motionList_;
			}
		}

		// Token: 0x17004BB7 RID: 19383
		// (get) Token: 0x06016979 RID: 92537 RVA: 0x003496C5 File Offset: 0x003478C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ConditionInfo> RoleConditionInfoMap
		{
			get
			{
				return this.roleConditionInfoMap_;
			}
		}

		// Token: 0x0601697A RID: 92538 RVA: 0x003496CD File Offset: 0x003478CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionListNotify);
		}

		// Token: 0x0601697B RID: 92539 RVA: 0x003496DC File Offset: 0x003478DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionListNotify other)
		{
			return other != null && (other == this || (this.motionList_.Equals(other.motionList_) && this.RoleConditionInfoMap.Equals(other.RoleConditionInfoMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601697C RID: 92540 RVA: 0x00349730 File Offset: 0x00347930
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

		// Token: 0x0601697D RID: 92541 RVA: 0x00349772 File Offset: 0x00347972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601697E RID: 92542 RVA: 0x0034977F File Offset: 0x0034797F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601697F RID: 92543 RVA: 0x00349788 File Offset: 0x00347988
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

		// Token: 0x06016980 RID: 92544 RVA: 0x003497C0 File Offset: 0x003479C0
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

		// Token: 0x06016981 RID: 92545 RVA: 0x0034980C File Offset: 0x00347A0C
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

		// Token: 0x06016982 RID: 92546 RVA: 0x0034984B File Offset: 0x00347A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016983 RID: 92547 RVA: 0x00349854 File Offset: 0x00347A54
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
				if (num != 18U)
				{
					if (num != 58U)
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

		// Token: 0x04008786 RID: 34694
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008787 RID: 34695
		public const int MotionListFieldNumber = 2;

		// Token: 0x04008788 RID: 34696
		private static readonly FieldCodec<RoleMotion> _repeated_motionList_codec = FieldCodec.ForMessage<RoleMotion>(18U, RoleMotion.Parser);

		// Token: 0x04008789 RID: 34697
		private readonly RepeatedField<RoleMotion> motionList_ = new RepeatedField<RoleMotion>();

		// Token: 0x0400878A RID: 34698
		public const int RoleConditionInfoMapFieldNumber = 7;

		// Token: 0x0400878B RID: 34699
		private static readonly MapField<int, ConditionInfo>.Codec _map_roleConditionInfoMap_codec = new MapField<int, ConditionInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ConditionInfo>(18U, ConditionInfo.Parser), 58U);

		// Token: 0x0400878C RID: 34700
		private readonly MapField<int, ConditionInfo> roleConditionInfoMap_ = new MapField<int, ConditionInfo>();
	}
}

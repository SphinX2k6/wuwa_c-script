using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107E RID: 4222
	[NetMessage(EMessageId.RoleMotionFinishConditionNotify)]
	public sealed class RoleMotionFinishConditionNotify : IMessage<RoleMotionFinishConditionNotify>, IMessage, IEquatable<RoleMotionFinishConditionNotify>, IDeepCloneable<RoleMotionFinishConditionNotify>, IBufferMessage
	{
		// Token: 0x06016960 RID: 92512 RVA: 0x0034945C File Offset: 0x0034765C
		[NullableContext(1)]
		public static RoleMotionFinishConditionNotify Create()
		{
			return new RoleMotionFinishConditionNotify();
		}

		// Token: 0x17004BB1 RID: 19377
		// (get) Token: 0x06016961 RID: 92513 RVA: 0x00349463 File Offset: 0x00347663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BB2 RID: 19378
		// (get) Token: 0x06016962 RID: 92514 RVA: 0x00349466 File Offset: 0x00347666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionFinishConditionNotify.Descriptor;
			}
		}

		// Token: 0x06016963 RID: 92515 RVA: 0x0034946D File Offset: 0x0034766D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionFinishConditionNotify()
		{
		}

		// Token: 0x06016964 RID: 92516 RVA: 0x00349480 File Offset: 0x00347680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionFinishConditionNotify(RoleMotionFinishConditionNotify other) : this()
		{
			this.roleConditionInfoMap_ = other.roleConditionInfoMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016965 RID: 92517 RVA: 0x003494AA File Offset: 0x003476AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionFinishConditionNotify Clone()
		{
			return new RoleMotionFinishConditionNotify(this);
		}

		// Token: 0x17004BB3 RID: 19379
		// (get) Token: 0x06016966 RID: 92518 RVA: 0x003494B2 File Offset: 0x003476B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ConditionInfo> RoleConditionInfoMap
		{
			get
			{
				return this.roleConditionInfoMap_;
			}
		}

		// Token: 0x06016967 RID: 92519 RVA: 0x003494BA File Offset: 0x003476BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionFinishConditionNotify);
		}

		// Token: 0x06016968 RID: 92520 RVA: 0x003494C8 File Offset: 0x003476C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionFinishConditionNotify other)
		{
			return other != null && (other == this || (this.RoleConditionInfoMap.Equals(other.RoleConditionInfoMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016969 RID: 92521 RVA: 0x003494FC File Offset: 0x003476FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.RoleConditionInfoMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601696A RID: 92522 RVA: 0x00349530 File Offset: 0x00347730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601696B RID: 92523 RVA: 0x0034953D File Offset: 0x0034773D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601696C RID: 92524 RVA: 0x00349546 File Offset: 0x00347746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleConditionInfoMap_.WriteTo(ref output, RoleMotionFinishConditionNotify._map_roleConditionInfoMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601696D RID: 92525 RVA: 0x00349570 File Offset: 0x00347770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleConditionInfoMap_.CalculateSize(RoleMotionFinishConditionNotify._map_roleConditionInfoMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601696E RID: 92526 RVA: 0x003495A9 File Offset: 0x003477A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleMotionFinishConditionNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleConditionInfoMap_.MergeFrom(other.roleConditionInfoMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601696F RID: 92527 RVA: 0x003495D7 File Offset: 0x003477D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016970 RID: 92528 RVA: 0x003495E0 File Offset: 0x003477E0
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleConditionInfoMap_.AddEntriesFrom(ref input, RoleMotionFinishConditionNotify._map_roleConditionInfoMap_codec);
				}
			}
		}

		// Token: 0x04008782 RID: 34690
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008783 RID: 34691
		public const int RoleConditionInfoMapFieldNumber = 3;

		// Token: 0x04008784 RID: 34692
		private static readonly MapField<int, ConditionInfo>.Codec _map_roleConditionInfoMap_codec = new MapField<int, ConditionInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ConditionInfo>(18U, ConditionInfo.Parser), 26U);

		// Token: 0x04008785 RID: 34693
		private readonly MapField<int, ConditionInfo> roleConditionInfoMap_ = new MapField<int, ConditionInfo>();
	}
}

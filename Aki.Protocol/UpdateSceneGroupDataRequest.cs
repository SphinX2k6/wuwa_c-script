using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A9 RID: 5289
	[NetMessage(EMessageId.UpdateSceneGroupDataRequest)]
	public sealed class UpdateSceneGroupDataRequest : IMessage<UpdateSceneGroupDataRequest>, IMessage, IEquatable<UpdateSceneGroupDataRequest>, IDeepCloneable<UpdateSceneGroupDataRequest>, IBufferMessage
	{
		// Token: 0x0601BF87 RID: 114567 RVA: 0x0040ADF9 File Offset: 0x00408FF9
		[NullableContext(1)]
		public static UpdateSceneGroupDataRequest Create()
		{
			return new UpdateSceneGroupDataRequest();
		}

		// Token: 0x17005E41 RID: 24129
		// (get) Token: 0x0601BF88 RID: 114568 RVA: 0x0040AE00 File Offset: 0x00409000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E42 RID: 24130
		// (get) Token: 0x0601BF89 RID: 114569 RVA: 0x0040AE03 File Offset: 0x00409003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneGroupDataRequest.Descriptor;
			}
		}

		// Token: 0x0601BF8A RID: 114570 RVA: 0x0040AE0A File Offset: 0x0040900A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataRequest()
		{
		}

		// Token: 0x0601BF8B RID: 114571 RVA: 0x0040AE20 File Offset: 0x00409020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataRequest(UpdateSceneGroupDataRequest other) : this()
		{
			this.curEntId_ = other.curEntId_;
			this.entityIds_ = other.entityIds_.Clone();
			this.targetGroup_ = other.targetGroup_;
			this.isReplace_ = other.isReplace_;
			this.needReserve_ = other.needReserve_;
			this.showTips_ = other.showTips_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF8C RID: 114572 RVA: 0x0040AE91 File Offset: 0x00409091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataRequest Clone()
		{
			return new UpdateSceneGroupDataRequest(this);
		}

		// Token: 0x17005E43 RID: 24131
		// (get) Token: 0x0601BF8D RID: 114573 RVA: 0x0040AE99 File Offset: 0x00409099
		// (set) Token: 0x0601BF8E RID: 114574 RVA: 0x0040AEA1 File Offset: 0x004090A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurEntId
		{
			get
			{
				return this.curEntId_;
			}
			set
			{
				this.curEntId_ = value;
			}
		}

		// Token: 0x17005E44 RID: 24132
		// (get) Token: 0x0601BF8F RID: 114575 RVA: 0x0040AEAA File Offset: 0x004090AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x17005E45 RID: 24133
		// (get) Token: 0x0601BF90 RID: 114576 RVA: 0x0040AEB2 File Offset: 0x004090B2
		// (set) Token: 0x0601BF91 RID: 114577 RVA: 0x0040AEBA File Offset: 0x004090BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ESceneRolesGroup TargetGroup
		{
			get
			{
				return this.targetGroup_;
			}
			set
			{
				this.targetGroup_ = value;
			}
		}

		// Token: 0x17005E46 RID: 24134
		// (get) Token: 0x0601BF92 RID: 114578 RVA: 0x0040AEC3 File Offset: 0x004090C3
		// (set) Token: 0x0601BF93 RID: 114579 RVA: 0x0040AECB File Offset: 0x004090CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReplace
		{
			get
			{
				return this.isReplace_;
			}
			set
			{
				this.isReplace_ = value;
			}
		}

		// Token: 0x17005E47 RID: 24135
		// (get) Token: 0x0601BF94 RID: 114580 RVA: 0x0040AED4 File Offset: 0x004090D4
		// (set) Token: 0x0601BF95 RID: 114581 RVA: 0x0040AEDC File Offset: 0x004090DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedReserve
		{
			get
			{
				return this.needReserve_;
			}
			set
			{
				this.needReserve_ = value;
			}
		}

		// Token: 0x17005E48 RID: 24136
		// (get) Token: 0x0601BF96 RID: 114582 RVA: 0x0040AEE5 File Offset: 0x004090E5
		// (set) Token: 0x0601BF97 RID: 114583 RVA: 0x0040AEED File Offset: 0x004090ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowTips
		{
			get
			{
				return this.showTips_;
			}
			set
			{
				this.showTips_ = value;
			}
		}

		// Token: 0x0601BF98 RID: 114584 RVA: 0x0040AEF6 File Offset: 0x004090F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneGroupDataRequest);
		}

		// Token: 0x0601BF99 RID: 114585 RVA: 0x0040AF04 File Offset: 0x00409104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneGroupDataRequest other)
		{
			return other != null && (other == this || (this.CurEntId == other.CurEntId && this.entityIds_.Equals(other.entityIds_) && this.TargetGroup == other.TargetGroup && this.IsReplace == other.IsReplace && this.NeedReserve == other.NeedReserve && this.ShowTips == other.ShowTips && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF9A RID: 114586 RVA: 0x0040AF94 File Offset: 0x00409194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurEntId != 0L)
			{
				num ^= this.CurEntId.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this.TargetGroup != ESceneRolesGroup.GroupNone)
			{
				num ^= this.TargetGroup.GetHashCode();
			}
			if (this.IsReplace)
			{
				num ^= this.IsReplace.GetHashCode();
			}
			if (this.NeedReserve)
			{
				num ^= this.NeedReserve.GetHashCode();
			}
			if (this.ShowTips)
			{
				num ^= this.ShowTips.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF9B RID: 114587 RVA: 0x0040B04B File Offset: 0x0040924B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF9C RID: 114588 RVA: 0x0040B058 File Offset: 0x00409258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF9D RID: 114589 RVA: 0x0040B064 File Offset: 0x00409264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowTips)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ShowTips);
			}
			if (this.NeedReserve)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.NeedReserve);
			}
			if (this.IsReplace)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsReplace);
			}
			this.entityIds_.WriteTo(ref output, UpdateSceneGroupDataRequest._repeated_entityIds_codec);
			if (this.TargetGroup != ESceneRolesGroup.GroupNone)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.TargetGroup);
			}
			if (this.CurEntId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.CurEntId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF9E RID: 114590 RVA: 0x0040B124 File Offset: 0x00409324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurEntId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurEntId);
			}
			num += this.entityIds_.CalculateSize(UpdateSceneGroupDataRequest._repeated_entityIds_codec);
			if (this.TargetGroup != ESceneRolesGroup.GroupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TargetGroup);
			}
			if (this.IsReplace)
			{
				num += 2;
			}
			if (this.NeedReserve)
			{
				num += 2;
			}
			if (this.ShowTips)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF9F RID: 114591 RVA: 0x0040B1B4 File Offset: 0x004093B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneGroupDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurEntId != 0L)
			{
				this.CurEntId = other.CurEntId;
			}
			this.entityIds_.Add(other.entityIds_);
			if (other.TargetGroup != ESceneRolesGroup.GroupNone)
			{
				this.TargetGroup = other.TargetGroup;
			}
			if (other.IsReplace)
			{
				this.IsReplace = other.IsReplace;
			}
			if (other.NeedReserve)
			{
				this.NeedReserve = other.NeedReserve;
			}
			if (other.ShowTips)
			{
				this.ShowTips = other.ShowTips;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BFA0 RID: 114592 RVA: 0x0040B251 File Offset: 0x00409451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFA1 RID: 114593 RVA: 0x0040B25C File Offset: 0x0040945C
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
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.ShowTips = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.NeedReserve = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.IsReplace = input.ReadBool();
						continue;
					}
				}
				else if (num <= 74U)
				{
					if (num == 72U || num == 74U)
					{
						this.entityIds_.AddEntriesFrom(ref input, UpdateSceneGroupDataRequest._repeated_entityIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.TargetGroup = (ESceneRolesGroup)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.CurEntId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A0AA RID: 41130
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0AB RID: 41131
		public const int CurEntIdFieldNumber = 12;

		// Token: 0x0400A0AC RID: 41132
		private long curEntId_;

		// Token: 0x0400A0AD RID: 41133
		public const int EntityIdsFieldNumber = 9;

		// Token: 0x0400A0AE RID: 41134
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(74U);

		// Token: 0x0400A0AF RID: 41135
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();

		// Token: 0x0400A0B0 RID: 41136
		public const int TargetGroupFieldNumber = 10;

		// Token: 0x0400A0B1 RID: 41137
		private ESceneRolesGroup targetGroup_;

		// Token: 0x0400A0B2 RID: 41138
		public const int IsReplaceFieldNumber = 7;

		// Token: 0x0400A0B3 RID: 41139
		private bool isReplace_;

		// Token: 0x0400A0B4 RID: 41140
		public const int NeedReserveFieldNumber = 3;

		// Token: 0x0400A0B5 RID: 41141
		private bool needReserve_;

		// Token: 0x0400A0B6 RID: 41142
		public const int ShowTipsFieldNumber = 1;

		// Token: 0x0400A0B7 RID: 41143
		private bool showTips_;
	}
}

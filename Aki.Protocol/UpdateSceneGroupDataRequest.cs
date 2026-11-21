using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151F RID: 5407
	[NetMessage(EMessageId.UpdateSceneGroupDataRequest)]
	public sealed class UpdateSceneGroupDataRequest : IMessage<UpdateSceneGroupDataRequest>, IMessage, IEquatable<UpdateSceneGroupDataRequest>, IDeepCloneable<UpdateSceneGroupDataRequest>, IBufferMessage
	{
		// Token: 0x0601CA4E RID: 117326 RVA: 0x004268B1 File Offset: 0x00424AB1
		[NullableContext(1)]
		public static UpdateSceneGroupDataRequest Create()
		{
			return new UpdateSceneGroupDataRequest();
		}

		// Token: 0x170060E2 RID: 24802
		// (get) Token: 0x0601CA4F RID: 117327 RVA: 0x004268B8 File Offset: 0x00424AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060E3 RID: 24803
		// (get) Token: 0x0601CA50 RID: 117328 RVA: 0x004268BB File Offset: 0x00424ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneGroupDataRequest.Descriptor;
			}
		}

		// Token: 0x0601CA51 RID: 117329 RVA: 0x004268C2 File Offset: 0x00424AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataRequest()
		{
		}

		// Token: 0x0601CA52 RID: 117330 RVA: 0x004268D8 File Offset: 0x00424AD8
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

		// Token: 0x0601CA53 RID: 117331 RVA: 0x00426949 File Offset: 0x00424B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataRequest Clone()
		{
			return new UpdateSceneGroupDataRequest(this);
		}

		// Token: 0x170060E4 RID: 24804
		// (get) Token: 0x0601CA54 RID: 117332 RVA: 0x00426951 File Offset: 0x00424B51
		// (set) Token: 0x0601CA55 RID: 117333 RVA: 0x00426959 File Offset: 0x00424B59
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

		// Token: 0x170060E5 RID: 24805
		// (get) Token: 0x0601CA56 RID: 117334 RVA: 0x00426962 File Offset: 0x00424B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x170060E6 RID: 24806
		// (get) Token: 0x0601CA57 RID: 117335 RVA: 0x0042696A File Offset: 0x00424B6A
		// (set) Token: 0x0601CA58 RID: 117336 RVA: 0x00426972 File Offset: 0x00424B72
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

		// Token: 0x170060E7 RID: 24807
		// (get) Token: 0x0601CA59 RID: 117337 RVA: 0x0042697B File Offset: 0x00424B7B
		// (set) Token: 0x0601CA5A RID: 117338 RVA: 0x00426983 File Offset: 0x00424B83
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

		// Token: 0x170060E8 RID: 24808
		// (get) Token: 0x0601CA5B RID: 117339 RVA: 0x0042698C File Offset: 0x00424B8C
		// (set) Token: 0x0601CA5C RID: 117340 RVA: 0x00426994 File Offset: 0x00424B94
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

		// Token: 0x170060E9 RID: 24809
		// (get) Token: 0x0601CA5D RID: 117341 RVA: 0x0042699D File Offset: 0x00424B9D
		// (set) Token: 0x0601CA5E RID: 117342 RVA: 0x004269A5 File Offset: 0x00424BA5
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

		// Token: 0x0601CA5F RID: 117343 RVA: 0x004269AE File Offset: 0x00424BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneGroupDataRequest);
		}

		// Token: 0x0601CA60 RID: 117344 RVA: 0x004269BC File Offset: 0x00424BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneGroupDataRequest other)
		{
			return other != null && (other == this || (this.CurEntId == other.CurEntId && this.entityIds_.Equals(other.entityIds_) && this.TargetGroup == other.TargetGroup && this.IsReplace == other.IsReplace && this.NeedReserve == other.NeedReserve && this.ShowTips == other.ShowTips && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA61 RID: 117345 RVA: 0x00426A4C File Offset: 0x00424C4C
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

		// Token: 0x0601CA62 RID: 117346 RVA: 0x00426B03 File Offset: 0x00424D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA63 RID: 117347 RVA: 0x00426B10 File Offset: 0x00424D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA64 RID: 117348 RVA: 0x00426B1C File Offset: 0x00424D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsReplace)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsReplace);
			}
			if (this.NeedReserve)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.NeedReserve);
			}
			if (this.CurEntId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.CurEntId);
			}
			if (this.ShowTips)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.ShowTips);
			}
			this.entityIds_.WriteTo(ref output, UpdateSceneGroupDataRequest._repeated_entityIds_codec);
			if (this.TargetGroup != ESceneRolesGroup.GroupNone)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.TargetGroup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA65 RID: 117349 RVA: 0x00426BDC File Offset: 0x00424DDC
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

		// Token: 0x0601CA66 RID: 117350 RVA: 0x00426C6C File Offset: 0x00424E6C
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

		// Token: 0x0601CA67 RID: 117351 RVA: 0x00426D09 File Offset: 0x00424F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA68 RID: 117352 RVA: 0x00426D14 File Offset: 0x00424F14
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
				if (num > 48U)
				{
					if (num <= 72U)
					{
						if (num == 64U)
						{
							this.ShowTips = input.ReadBool();
							continue;
						}
						if (num != 72U)
						{
							goto IL_3D;
						}
					}
					else if (num != 74U)
					{
						if (num != 80U)
						{
							goto IL_3D;
						}
						this.TargetGroup = (ESceneRolesGroup)input.ReadEnum();
						continue;
					}
					this.entityIds_.AddEntriesFrom(ref input, UpdateSceneGroupDataRequest._repeated_entityIds_codec);
					continue;
				}
				if (num == 24U)
				{
					this.IsReplace = input.ReadBool();
					continue;
				}
				if (num == 32U)
				{
					this.NeedReserve = input.ReadBool();
					continue;
				}
				if (num == 48U)
				{
					this.CurEntId = input.ReadInt64();
					continue;
				}
				IL_3D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A503 RID: 42243
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A504 RID: 42244
		public const int CurEntIdFieldNumber = 6;

		// Token: 0x0400A505 RID: 42245
		private long curEntId_;

		// Token: 0x0400A506 RID: 42246
		public const int EntityIdsFieldNumber = 9;

		// Token: 0x0400A507 RID: 42247
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(74U);

		// Token: 0x0400A508 RID: 42248
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();

		// Token: 0x0400A509 RID: 42249
		public const int TargetGroupFieldNumber = 10;

		// Token: 0x0400A50A RID: 42250
		private ESceneRolesGroup targetGroup_;

		// Token: 0x0400A50B RID: 42251
		public const int IsReplaceFieldNumber = 3;

		// Token: 0x0400A50C RID: 42252
		private bool isReplace_;

		// Token: 0x0400A50D RID: 42253
		public const int NeedReserveFieldNumber = 4;

		// Token: 0x0400A50E RID: 42254
		private bool needReserve_;

		// Token: 0x0400A50F RID: 42255
		public const int ShowTipsFieldNumber = 8;

		// Token: 0x0400A510 RID: 42256
		private bool showTips_;
	}
}

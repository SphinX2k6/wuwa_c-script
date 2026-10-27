using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AB RID: 5291
	[NetMessage(EMessageId.UpdateSceneItemBlackboardRequest)]
	public sealed class UpdateSceneItemBlackboardRequest : IMessage<UpdateSceneItemBlackboardRequest>, IMessage, IEquatable<UpdateSceneItemBlackboardRequest>, IDeepCloneable<UpdateSceneItemBlackboardRequest>, IBufferMessage
	{
		// Token: 0x0601BFB5 RID: 114613 RVA: 0x0040B50D File Offset: 0x0040970D
		[NullableContext(1)]
		public static UpdateSceneItemBlackboardRequest Create()
		{
			return new UpdateSceneItemBlackboardRequest();
		}

		// Token: 0x17005E4C RID: 24140
		// (get) Token: 0x0601BFB6 RID: 114614 RVA: 0x0040B514 File Offset: 0x00409714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E4D RID: 24141
		// (get) Token: 0x0601BFB7 RID: 114615 RVA: 0x0040B517 File Offset: 0x00409717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneItemBlackboardRequest.Descriptor;
			}
		}

		// Token: 0x0601BFB8 RID: 114616 RVA: 0x0040B51E File Offset: 0x0040971E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardRequest()
		{
		}

		// Token: 0x0601BFB9 RID: 114617 RVA: 0x0040B531 File Offset: 0x00409731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardRequest(UpdateSceneItemBlackboardRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BFBA RID: 114618 RVA: 0x0040B567 File Offset: 0x00409767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardRequest Clone()
		{
			return new UpdateSceneItemBlackboardRequest(this);
		}

		// Token: 0x17005E4E RID: 24142
		// (get) Token: 0x0601BFBB RID: 114619 RVA: 0x0040B56F File Offset: 0x0040976F
		// (set) Token: 0x0601BFBC RID: 114620 RVA: 0x0040B577 File Offset: 0x00409777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17005E4F RID: 24143
		// (get) Token: 0x0601BFBD RID: 114621 RVA: 0x0040B580 File Offset: 0x00409780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneItemBlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x0601BFBE RID: 114622 RVA: 0x0040B588 File Offset: 0x00409788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneItemBlackboardRequest);
		}

		// Token: 0x0601BFBF RID: 114623 RVA: 0x0040B598 File Offset: 0x00409798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneItemBlackboardRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFC0 RID: 114624 RVA: 0x0040B5E8 File Offset: 0x004097E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.params_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BFC1 RID: 114625 RVA: 0x0040B635 File Offset: 0x00409835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BFC2 RID: 114626 RVA: 0x0040B642 File Offset: 0x00409842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BFC3 RID: 114627 RVA: 0x0040B64C File Offset: 0x0040984C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.params_.WriteTo(ref output, UpdateSceneItemBlackboardRequest._repeated_params_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BFC4 RID: 114628 RVA: 0x0040B69C File Offset: 0x0040989C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.params_.CalculateSize(UpdateSceneItemBlackboardRequest._repeated_params_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BFC5 RID: 114629 RVA: 0x0040B6F0 File Offset: 0x004098F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneItemBlackboardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.params_.Add(other.params_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BFC6 RID: 114630 RVA: 0x0040B73D File Offset: 0x0040993D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFC7 RID: 114631 RVA: 0x0040B748 File Offset: 0x00409948
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.params_.AddEntriesFrom(ref input, UpdateSceneItemBlackboardRequest._repeated_params_codec);
				}
			}
		}

		// Token: 0x0400A0BB RID: 41147
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0BC RID: 41148
		public const int EntityIdFieldNumber = 6;

		// Token: 0x0400A0BD RID: 41149
		private long entityId_;

		// Token: 0x0400A0BE RID: 41150
		public const int ParamsFieldNumber = 2;

		// Token: 0x0400A0BF RID: 41151
		private static readonly FieldCodec<SceneItemBlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<SceneItemBlackboardParam>(18U, SceneItemBlackboardParam.Parser);

		// Token: 0x0400A0C0 RID: 41152
		private readonly RepeatedField<SceneItemBlackboardParam> params_ = new RepeatedField<SceneItemBlackboardParam>();
	}
}

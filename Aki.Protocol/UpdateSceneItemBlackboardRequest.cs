using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001521 RID: 5409
	[NetMessage(EMessageId.UpdateSceneItemBlackboardRequest)]
	public sealed class UpdateSceneItemBlackboardRequest : IMessage<UpdateSceneItemBlackboardRequest>, IMessage, IEquatable<UpdateSceneItemBlackboardRequest>, IDeepCloneable<UpdateSceneItemBlackboardRequest>, IBufferMessage
	{
		// Token: 0x0601CA7C RID: 117372 RVA: 0x00426FC5 File Offset: 0x004251C5
		[NullableContext(1)]
		public static UpdateSceneItemBlackboardRequest Create()
		{
			return new UpdateSceneItemBlackboardRequest();
		}

		// Token: 0x170060ED RID: 24813
		// (get) Token: 0x0601CA7D RID: 117373 RVA: 0x00426FCC File Offset: 0x004251CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060EE RID: 24814
		// (get) Token: 0x0601CA7E RID: 117374 RVA: 0x00426FCF File Offset: 0x004251CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneItemBlackboardRequest.Descriptor;
			}
		}

		// Token: 0x0601CA7F RID: 117375 RVA: 0x00426FD6 File Offset: 0x004251D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardRequest()
		{
		}

		// Token: 0x0601CA80 RID: 117376 RVA: 0x00426FE9 File Offset: 0x004251E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardRequest(UpdateSceneItemBlackboardRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA81 RID: 117377 RVA: 0x0042701F File Offset: 0x0042521F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneItemBlackboardRequest Clone()
		{
			return new UpdateSceneItemBlackboardRequest(this);
		}

		// Token: 0x170060EF RID: 24815
		// (get) Token: 0x0601CA82 RID: 117378 RVA: 0x00427027 File Offset: 0x00425227
		// (set) Token: 0x0601CA83 RID: 117379 RVA: 0x0042702F File Offset: 0x0042522F
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

		// Token: 0x170060F0 RID: 24816
		// (get) Token: 0x0601CA84 RID: 117380 RVA: 0x00427038 File Offset: 0x00425238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneItemBlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x0601CA85 RID: 117381 RVA: 0x00427040 File Offset: 0x00425240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneItemBlackboardRequest);
		}

		// Token: 0x0601CA86 RID: 117382 RVA: 0x00427050 File Offset: 0x00425250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneItemBlackboardRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA87 RID: 117383 RVA: 0x004270A0 File Offset: 0x004252A0
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

		// Token: 0x0601CA88 RID: 117384 RVA: 0x004270ED File Offset: 0x004252ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA89 RID: 117385 RVA: 0x004270FA File Offset: 0x004252FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA8A RID: 117386 RVA: 0x00427104 File Offset: 0x00425304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.params_.WriteTo(ref output, UpdateSceneItemBlackboardRequest._repeated_params_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA8B RID: 117387 RVA: 0x00427154 File Offset: 0x00425354
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

		// Token: 0x0601CA8C RID: 117388 RVA: 0x004271A8 File Offset: 0x004253A8
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

		// Token: 0x0601CA8D RID: 117389 RVA: 0x004271F5 File Offset: 0x004253F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA8E RID: 117390 RVA: 0x00427200 File Offset: 0x00425400
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
				if (num != 10U)
				{
					if (num != 120U)
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

		// Token: 0x0400A514 RID: 42260
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A515 RID: 42261
		public const int EntityIdFieldNumber = 15;

		// Token: 0x0400A516 RID: 42262
		private long entityId_;

		// Token: 0x0400A517 RID: 42263
		public const int ParamsFieldNumber = 1;

		// Token: 0x0400A518 RID: 42264
		private static readonly FieldCodec<SceneItemBlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<SceneItemBlackboardParam>(10U, SceneItemBlackboardParam.Parser);

		// Token: 0x0400A519 RID: 42265
		private readonly RepeatedField<SceneItemBlackboardParam> params_ = new RepeatedField<SceneItemBlackboardParam>();
	}
}

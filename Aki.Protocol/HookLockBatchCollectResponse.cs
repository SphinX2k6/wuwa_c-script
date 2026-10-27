using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B1 RID: 1969
	[NetMessage(EMessageId.HookLockBatchCollectResponse)]
	public sealed class HookLockBatchCollectResponse : IMessage<HookLockBatchCollectResponse>, IMessage, IEquatable<HookLockBatchCollectResponse>, IDeepCloneable<HookLockBatchCollectResponse>, IBufferMessage
	{
		// Token: 0x0600B15F RID: 45407 RVA: 0x001A933E File Offset: 0x001A753E
		[NullableContext(1)]
		public static HookLockBatchCollectResponse Create()
		{
			return new HookLockBatchCollectResponse();
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x0600B160 RID: 45408 RVA: 0x001A9345 File Offset: 0x001A7545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x0600B161 RID: 45409 RVA: 0x001A9348 File Offset: 0x001A7548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockBatchCollectResponse.Descriptor;
			}
		}

		// Token: 0x0600B162 RID: 45410 RVA: 0x001A934F File Offset: 0x001A754F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectResponse()
		{
		}

		// Token: 0x0600B163 RID: 45411 RVA: 0x001A9364 File Offset: 0x001A7564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectResponse(HookLockBatchCollectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityConfigId_ = other.entityConfigId_;
			this.successConfigIds_ = other.successConfigIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B164 RID: 45412 RVA: 0x001A93B1 File Offset: 0x001A75B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectResponse Clone()
		{
			return new HookLockBatchCollectResponse(this);
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x0600B165 RID: 45413 RVA: 0x001A93B9 File Offset: 0x001A75B9
		// (set) Token: 0x0600B166 RID: 45414 RVA: 0x001A93C1 File Offset: 0x001A75C1
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

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x0600B167 RID: 45415 RVA: 0x001A93CA File Offset: 0x001A75CA
		// (set) Token: 0x0600B168 RID: 45416 RVA: 0x001A93D2 File Offset: 0x001A75D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x0600B169 RID: 45417 RVA: 0x001A93DB File Offset: 0x001A75DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SuccessConfigIds
		{
			get
			{
				return this.successConfigIds_;
			}
		}

		// Token: 0x0600B16A RID: 45418 RVA: 0x001A93E3 File Offset: 0x001A75E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockBatchCollectResponse);
		}

		// Token: 0x0600B16B RID: 45419 RVA: 0x001A93F4 File Offset: 0x001A75F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockBatchCollectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityConfigId == other.EntityConfigId && this.successConfigIds_.Equals(other.successConfigIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B16C RID: 45420 RVA: 0x001A9454 File Offset: 0x001A7654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			num ^= this.successConfigIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B16D RID: 45421 RVA: 0x001A94C0 File Offset: 0x001A76C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B16E RID: 45422 RVA: 0x001A94CD File Offset: 0x001A76CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B16F RID: 45423 RVA: 0x001A94D8 File Offset: 0x001A76D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.successConfigIds_.WriteTo(ref output, HookLockBatchCollectResponse._repeated_successConfigIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x001A9544 File Offset: 0x001A7744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			num += this.successConfigIds_.CalculateSize(HookLockBatchCollectResponse._repeated_successConfigIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x001A95B0 File Offset: 0x001A77B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockBatchCollectResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			this.successConfigIds_.Add(other.successConfigIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B172 RID: 45426 RVA: 0x001A9611 File Offset: 0x001A7811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B173 RID: 45427 RVA: 0x001A961C File Offset: 0x001A781C
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
					if (num == 32U || num == 34U)
					{
						this.successConfigIds_.AddEntriesFrom(ref input, HookLockBatchCollectResponse._repeated_successConfigIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F88 RID: 20360
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F89 RID: 20361
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004F8A RID: 20362
		private ErrorCode errorCode_;

		// Token: 0x04004F8B RID: 20363
		public const int EntityConfigIdFieldNumber = 15;

		// Token: 0x04004F8C RID: 20364
		private int entityConfigId_;

		// Token: 0x04004F8D RID: 20365
		public const int SuccessConfigIdsFieldNumber = 4;

		// Token: 0x04004F8E RID: 20366
		private static readonly FieldCodec<int> _repeated_successConfigIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04004F8F RID: 20367
		private readonly RepeatedField<int> successConfigIds_ = new RepeatedField<int>();
	}
}

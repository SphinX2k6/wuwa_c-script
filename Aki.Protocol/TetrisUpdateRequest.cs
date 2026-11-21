using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C9 RID: 5065
	[NetMessage(EMessageId.TetrisUpdateRequest)]
	public sealed class TetrisUpdateRequest : IMessage<TetrisUpdateRequest>, IMessage, IEquatable<TetrisUpdateRequest>, IDeepCloneable<TetrisUpdateRequest>, IBufferMessage
	{
		// Token: 0x0601AF56 RID: 110422 RVA: 0x003ED4E9 File Offset: 0x003EB6E9
		[NullableContext(1)]
		public static TetrisUpdateRequest Create()
		{
			return new TetrisUpdateRequest();
		}

		// Token: 0x17005B53 RID: 23379
		// (get) Token: 0x0601AF57 RID: 110423 RVA: 0x003ED4F0 File Offset: 0x003EB6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B54 RID: 23380
		// (get) Token: 0x0601AF58 RID: 110424 RVA: 0x003ED4F3 File Offset: 0x003EB6F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601AF59 RID: 110425 RVA: 0x003ED4FA File Offset: 0x003EB6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateRequest()
		{
		}

		// Token: 0x0601AF5A RID: 110426 RVA: 0x003ED504 File Offset: 0x003EB704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateRequest(TetrisUpdateRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.tetrisLevelInfo_ = ((other.tetrisLevelInfo_ != null) ? other.tetrisLevelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF5B RID: 110427 RVA: 0x003ED550 File Offset: 0x003EB750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateRequest Clone()
		{
			return new TetrisUpdateRequest(this);
		}

		// Token: 0x17005B55 RID: 23381
		// (get) Token: 0x0601AF5C RID: 110428 RVA: 0x003ED558 File Offset: 0x003EB758
		// (set) Token: 0x0601AF5D RID: 110429 RVA: 0x003ED560 File Offset: 0x003EB760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17005B56 RID: 23382
		// (get) Token: 0x0601AF5E RID: 110430 RVA: 0x003ED569 File Offset: 0x003EB769
		// (set) Token: 0x0601AF5F RID: 110431 RVA: 0x003ED571 File Offset: 0x003EB771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisLevelInfo TetrisLevelInfo
		{
			get
			{
				return this.tetrisLevelInfo_;
			}
			set
			{
				this.tetrisLevelInfo_ = value;
			}
		}

		// Token: 0x0601AF60 RID: 110432 RVA: 0x003ED57A File Offset: 0x003EB77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisUpdateRequest);
		}

		// Token: 0x0601AF61 RID: 110433 RVA: 0x003ED588 File Offset: 0x003EB788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisUpdateRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.TetrisLevelInfo, other.TetrisLevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF62 RID: 110434 RVA: 0x003ED5D8 File Offset: 0x003EB7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.tetrisLevelInfo_ != null)
			{
				num ^= this.TetrisLevelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AF63 RID: 110435 RVA: 0x003ED62D File Offset: 0x003EB82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF64 RID: 110436 RVA: 0x003ED63A File Offset: 0x003EB83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF65 RID: 110437 RVA: 0x003ED644 File Offset: 0x003EB844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.tetrisLevelInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.TetrisLevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF66 RID: 110438 RVA: 0x003ED6A0 File Offset: 0x003EB8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.tetrisLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TetrisLevelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AF67 RID: 110439 RVA: 0x003ED6F8 File Offset: 0x003EB8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TetrisUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.tetrisLevelInfo_ != null)
			{
				if (this.tetrisLevelInfo_ == null)
				{
					this.TetrisLevelInfo = new TetrisLevelInfo();
				}
				this.TetrisLevelInfo.MergeFrom(other.TetrisLevelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AF68 RID: 110440 RVA: 0x003ED760 File Offset: 0x003EB960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF69 RID: 110441 RVA: 0x003ED76C File Offset: 0x003EB96C
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
				if (num != 24U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.tetrisLevelInfo_ == null)
						{
							this.TetrisLevelInfo = new TetrisLevelInfo();
						}
						input.ReadMessage(this.TetrisLevelInfo);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009DA4 RID: 40356
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DA5 RID: 40357
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04009DA6 RID: 40358
		private int activityId_;

		// Token: 0x04009DA7 RID: 40359
		public const int TetrisLevelInfoFieldNumber = 9;

		// Token: 0x04009DA8 RID: 40360
		private TetrisLevelInfo tetrisLevelInfo_;
	}
}

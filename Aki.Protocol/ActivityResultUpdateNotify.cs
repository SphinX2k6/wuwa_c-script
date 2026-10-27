using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000094 RID: 148
	[NetMessage(EMessageId.ActivityResultUpdateNotify)]
	public sealed class ActivityResultUpdateNotify : IMessage<ActivityResultUpdateNotify>, IMessage, IEquatable<ActivityResultUpdateNotify>, IDeepCloneable<ActivityResultUpdateNotify>, IBufferMessage
	{
		// Token: 0x06001B4E RID: 6990 RVA: 0x0004C794 File Offset: 0x0004A994
		[NullableContext(1)]
		public static ActivityResultUpdateNotify Create()
		{
			return new ActivityResultUpdateNotify();
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x0004C79B File Offset: 0x0004A99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x0004C79E File Offset: 0x0004A99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityResultUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0004C7A5 File Offset: 0x0004A9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultUpdateNotify()
		{
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0004C7B8 File Offset: 0x0004A9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultUpdateNotify(ActivityResultUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.activityResultDatas_ = other.activityResultDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0004C7EE File Offset: 0x0004A9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultUpdateNotify Clone()
		{
			return new ActivityResultUpdateNotify(this);
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0004C7F6 File Offset: 0x0004A9F6
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0004C7FE File Offset: 0x0004A9FE
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

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x0004C807 File Offset: 0x0004AA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaActivityResultPbData> ActivityResultDatas
		{
			get
			{
				return this.activityResultDatas_;
			}
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x0004C80F File Offset: 0x0004AA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityResultUpdateNotify);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0004C820 File Offset: 0x0004AA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityResultUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.activityResultDatas_.Equals(other.activityResultDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0004C870 File Offset: 0x0004AA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.activityResultDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0004C8BD File Offset: 0x0004AABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0004C8CA File Offset: 0x0004AACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0004C8D4 File Offset: 0x0004AAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			this.activityResultDatas_.WriteTo(ref output, ActivityResultUpdateNotify._repeated_activityResultDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0004C924 File Offset: 0x0004AB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.activityResultDatas_.CalculateSize(ActivityResultUpdateNotify._repeated_activityResultDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0004C978 File Offset: 0x0004AB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityResultUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.activityResultDatas_.Add(other.activityResultDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0004C9C5 File Offset: 0x0004ABC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0004C9D0 File Offset: 0x0004ABD0
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
				if (num != 32U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.activityResultDatas_.AddEntriesFrom(ref input, ActivityResultUpdateNotify._repeated_activityResultDatas_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400228E RID: 8846
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400228F RID: 8847
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04002290 RID: 8848
		private int activityId_;

		// Token: 0x04002291 RID: 8849
		public const int ActivityResultDatasFieldNumber = 8;

		// Token: 0x04002292 RID: 8850
		private static readonly FieldCodec<CiacconaActivityResultPbData> _repeated_activityResultDatas_codec = FieldCodec.ForMessage<CiacconaActivityResultPbData>(66U, CiacconaActivityResultPbData.Parser);

		// Token: 0x04002293 RID: 8851
		private readonly RepeatedField<CiacconaActivityResultPbData> activityResultDatas_ = new RepeatedField<CiacconaActivityResultPbData>();
	}
}

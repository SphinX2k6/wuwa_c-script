using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000095 RID: 149
	[NetMessage(EMessageId.ActivityResultUpdateNotify)]
	public sealed class ActivityResultUpdateNotify : IMessage<ActivityResultUpdateNotify>, IMessage, IEquatable<ActivityResultUpdateNotify>, IDeepCloneable<ActivityResultUpdateNotify>, IBufferMessage
	{
		// Token: 0x06001B95 RID: 7061 RVA: 0x0004D3A4 File Offset: 0x0004B5A4
		[NullableContext(1)]
		public static ActivityResultUpdateNotify Create()
		{
			return new ActivityResultUpdateNotify();
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x0004D3AB File Offset: 0x0004B5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0004D3AE File Offset: 0x0004B5AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityResultUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0004D3B5 File Offset: 0x0004B5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultUpdateNotify()
		{
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0004D3C8 File Offset: 0x0004B5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultUpdateNotify(ActivityResultUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.activityResultDatas_ = other.activityResultDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0004D3FE File Offset: 0x0004B5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultUpdateNotify Clone()
		{
			return new ActivityResultUpdateNotify(this);
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0004D406 File Offset: 0x0004B606
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0004D40E File Offset: 0x0004B60E
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

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x0004D417 File Offset: 0x0004B617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaActivityResultPbData> ActivityResultDatas
		{
			get
			{
				return this.activityResultDatas_;
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0004D41F File Offset: 0x0004B61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityResultUpdateNotify);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0004D430 File Offset: 0x0004B630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityResultUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.activityResultDatas_.Equals(other.activityResultDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0004D480 File Offset: 0x0004B680
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

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0004D4CD File Offset: 0x0004B6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0004D4DA File Offset: 0x0004B6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0004D4E4 File Offset: 0x0004B6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityResultDatas_.WriteTo(ref output, ActivityResultUpdateNotify._repeated_activityResultDatas_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0004D534 File Offset: 0x0004B734
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

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0004D588 File Offset: 0x0004B788
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

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0004D5D5 File Offset: 0x0004B7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0004D5E0 File Offset: 0x0004B7E0
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.activityResultDatas_.AddEntriesFrom(ref input, ActivityResultUpdateNotify._repeated_activityResultDatas_codec);
				}
			}
		}

		// Token: 0x040022EF RID: 8943
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022F0 RID: 8944
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x040022F1 RID: 8945
		private int activityId_;

		// Token: 0x040022F2 RID: 8946
		public const int ActivityResultDatasFieldNumber = 2;

		// Token: 0x040022F3 RID: 8947
		private static readonly FieldCodec<CiacconaActivityResultPbData> _repeated_activityResultDatas_codec = FieldCodec.ForMessage<CiacconaActivityResultPbData>(18U, CiacconaActivityResultPbData.Parser);

		// Token: 0x040022F4 RID: 8948
		private readonly RepeatedField<CiacconaActivityResultPbData> activityResultDatas_ = new RepeatedField<CiacconaActivityResultPbData>();
	}
}

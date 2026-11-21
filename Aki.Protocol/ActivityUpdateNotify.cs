using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000098 RID: 152
	[NetMessage(EMessageId.ActivityUpdateNotify)]
	public sealed class ActivityUpdateNotify : IMessage<ActivityUpdateNotify>, IMessage, IEquatable<ActivityUpdateNotify>, IDeepCloneable<ActivityUpdateNotify>, IBufferMessage
	{
		// Token: 0x06001BD6 RID: 7126 RVA: 0x0004DD05 File Offset: 0x0004BF05
		[NullableContext(1)]
		public static ActivityUpdateNotify Create()
		{
			return new ActivityUpdateNotify();
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x0004DD0C File Offset: 0x0004BF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x0004DD0F File Offset: 0x0004BF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0004DD16 File Offset: 0x0004BF16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityUpdateNotify()
		{
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0004DD29 File Offset: 0x0004BF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityUpdateNotify(ActivityUpdateNotify other) : this()
		{
			this.activities_ = other.activities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0004DD53 File Offset: 0x0004BF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityUpdateNotify Clone()
		{
			return new ActivityUpdateNotify(this);
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x0004DD5B File Offset: 0x0004BF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityData> Activities
		{
			get
			{
				return this.activities_;
			}
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0004DD63 File Offset: 0x0004BF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityUpdateNotify);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0004DD71 File Offset: 0x0004BF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityUpdateNotify other)
		{
			return other != null && (other == this || (this.activities_.Equals(other.activities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0004DDA4 File Offset: 0x0004BFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activities_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0004DDD8 File Offset: 0x0004BFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0004DDE5 File Offset: 0x0004BFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0004DDEE File Offset: 0x0004BFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activities_.WriteTo(ref output, ActivityUpdateNotify._repeated_activities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0004DE18 File Offset: 0x0004C018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activities_.CalculateSize(ActivityUpdateNotify._repeated_activities_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0004DE51 File Offset: 0x0004C051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activities_.Add(other.activities_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0004DE7F File Offset: 0x0004C07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0004DE88 File Offset: 0x0004C088
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
					this.activities_.AddEntriesFrom(ref input, ActivityUpdateNotify._repeated_activities_codec);
				}
			}
		}

		// Token: 0x04002306 RID: 8966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002307 RID: 8967
		public const int ActivitiesFieldNumber = 3;

		// Token: 0x04002308 RID: 8968
		private static readonly FieldCodec<ActivityData> _repeated_activities_codec = FieldCodec.ForMessage<ActivityData>(26U, ActivityData.Parser);

		// Token: 0x04002309 RID: 8969
		private readonly RepeatedField<ActivityData> activities_ = new RepeatedField<ActivityData>();
	}
}

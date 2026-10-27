using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000097 RID: 151
	[NetMessage(EMessageId.ActivityUpdateNotify)]
	public sealed class ActivityUpdateNotify : IMessage<ActivityUpdateNotify>, IMessage, IEquatable<ActivityUpdateNotify>, IDeepCloneable<ActivityUpdateNotify>, IBufferMessage
	{
		// Token: 0x06001B8F RID: 7055 RVA: 0x0004D0F5 File Offset: 0x0004B2F5
		[NullableContext(1)]
		public static ActivityUpdateNotify Create()
		{
			return new ActivityUpdateNotify();
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0004D0FC File Offset: 0x0004B2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x0004D0FF File Offset: 0x0004B2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0004D106 File Offset: 0x0004B306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityUpdateNotify()
		{
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0004D119 File Offset: 0x0004B319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityUpdateNotify(ActivityUpdateNotify other) : this()
		{
			this.activities_ = other.activities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0004D143 File Offset: 0x0004B343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityUpdateNotify Clone()
		{
			return new ActivityUpdateNotify(this);
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x0004D14B File Offset: 0x0004B34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityData> Activities
		{
			get
			{
				return this.activities_;
			}
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0004D153 File Offset: 0x0004B353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityUpdateNotify);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0004D161 File Offset: 0x0004B361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityUpdateNotify other)
		{
			return other != null && (other == this || (this.activities_.Equals(other.activities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0004D194 File Offset: 0x0004B394
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

		// Token: 0x06001B99 RID: 7065 RVA: 0x0004D1C8 File Offset: 0x0004B3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0004D1D5 File Offset: 0x0004B3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0004D1DE File Offset: 0x0004B3DE
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

		// Token: 0x06001B9C RID: 7068 RVA: 0x0004D208 File Offset: 0x0004B408
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

		// Token: 0x06001B9D RID: 7069 RVA: 0x0004D241 File Offset: 0x0004B441
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

		// Token: 0x06001B9E RID: 7070 RVA: 0x0004D26F File Offset: 0x0004B46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0004D278 File Offset: 0x0004B478
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activities_.AddEntriesFrom(ref input, ActivityUpdateNotify._repeated_activities_codec);
				}
			}
		}

		// Token: 0x040022A5 RID: 8869
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022A6 RID: 8870
		public const int ActivitiesFieldNumber = 4;

		// Token: 0x040022A7 RID: 8871
		private static readonly FieldCodec<ActivityData> _repeated_activities_codec = FieldCodec.ForMessage<ActivityData>(34U, ActivityData.Parser);

		// Token: 0x040022A8 RID: 8872
		private readonly RepeatedField<ActivityData> activities_ = new RepeatedField<ActivityData>();
	}
}

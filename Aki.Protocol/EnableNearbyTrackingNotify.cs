using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000435 RID: 1077
	[NetMessage(EMessageId.EnableNearbyTrackingNotify)]
	public sealed class EnableNearbyTrackingNotify : IMessage<EnableNearbyTrackingNotify>, IMessage, IEquatable<EnableNearbyTrackingNotify>, IDeepCloneable<EnableNearbyTrackingNotify>, IBufferMessage
	{
		// Token: 0x0600673F RID: 26431 RVA: 0x000F80D3 File Offset: 0x000F62D3
		[NullableContext(1)]
		public static EnableNearbyTrackingNotify Create()
		{
			return new EnableNearbyTrackingNotify();
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06006740 RID: 26432 RVA: 0x000F80DA File Offset: 0x000F62DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06006741 RID: 26433 RVA: 0x000F80DD File Offset: 0x000F62DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableNearbyTrackingNotify.Descriptor;
			}
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x000F80E4 File Offset: 0x000F62E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableNearbyTrackingNotify()
		{
		}

		// Token: 0x06006743 RID: 26435 RVA: 0x000F80F7 File Offset: 0x000F62F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableNearbyTrackingNotify(EnableNearbyTrackingNotify other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this.isEnable_ = other.isEnable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x000F812D File Offset: 0x000F632D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableNearbyTrackingNotify Clone()
		{
			return new EnableNearbyTrackingNotify(this);
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06006745 RID: 26437 RVA: 0x000F8135 File Offset: 0x000F6335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06006746 RID: 26438 RVA: 0x000F813D File Offset: 0x000F633D
		// (set) Token: 0x06006747 RID: 26439 RVA: 0x000F8145 File Offset: 0x000F6345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnable
		{
			get
			{
				return this.isEnable_;
			}
			set
			{
				this.isEnable_ = value;
			}
		}

		// Token: 0x06006748 RID: 26440 RVA: 0x000F814E File Offset: 0x000F634E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableNearbyTrackingNotify);
		}

		// Token: 0x06006749 RID: 26441 RVA: 0x000F815C File Offset: 0x000F635C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableNearbyTrackingNotify other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && this.IsEnable == other.IsEnable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600674A RID: 26442 RVA: 0x000F81AC File Offset: 0x000F63AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityIds_.GetHashCode();
			if (this.IsEnable)
			{
				num ^= this.IsEnable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x000F81F9 File Offset: 0x000F63F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x000F8206 File Offset: 0x000F6406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x000F8210 File Offset: 0x000F6410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, EnableNearbyTrackingNotify._repeated_entityIds_codec);
			if (this.IsEnable)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsEnable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x000F8260 File Offset: 0x000F6460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityIds_.CalculateSize(EnableNearbyTrackingNotify._repeated_entityIds_codec);
			if (this.IsEnable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x000F82A8 File Offset: 0x000F64A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnableNearbyTrackingNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityIds_.Add(other.entityIds_);
			if (other.IsEnable)
			{
				this.IsEnable = other.IsEnable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006750 RID: 26448 RVA: 0x000F82F5 File Offset: 0x000F64F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006751 RID: 26449 RVA: 0x000F8300 File Offset: 0x000F6500
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
				if (num != 80U && num != 82U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsEnable = input.ReadBool();
					}
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, EnableNearbyTrackingNotify._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x04003959 RID: 14681
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400395A RID: 14682
		public const int EntityIdsFieldNumber = 10;

		// Token: 0x0400395B RID: 14683
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(82U);

		// Token: 0x0400395C RID: 14684
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();

		// Token: 0x0400395D RID: 14685
		public const int IsEnableFieldNumber = 14;

		// Token: 0x0400395E RID: 14686
		private bool isEnable_;
	}
}

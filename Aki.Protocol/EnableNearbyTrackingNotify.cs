using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041E RID: 1054
	[NetMessage(EMessageId.EnableNearbyTrackingNotify)]
	public sealed class EnableNearbyTrackingNotify : IMessage<EnableNearbyTrackingNotify>, IMessage, IEquatable<EnableNearbyTrackingNotify>, IDeepCloneable<EnableNearbyTrackingNotify>, IBufferMessage
	{
		// Token: 0x060065AF RID: 26031 RVA: 0x000F4F57 File Offset: 0x000F3157
		[NullableContext(1)]
		public static EnableNearbyTrackingNotify Create()
		{
			return new EnableNearbyTrackingNotify();
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x060065B0 RID: 26032 RVA: 0x000F4F5E File Offset: 0x000F315E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x060065B1 RID: 26033 RVA: 0x000F4F61 File Offset: 0x000F3161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableNearbyTrackingNotify.Descriptor;
			}
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x000F4F68 File Offset: 0x000F3168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableNearbyTrackingNotify()
		{
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x000F4F7B File Offset: 0x000F317B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableNearbyTrackingNotify(EnableNearbyTrackingNotify other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this.isEnable_ = other.isEnable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065B4 RID: 26036 RVA: 0x000F4FB1 File Offset: 0x000F31B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableNearbyTrackingNotify Clone()
		{
			return new EnableNearbyTrackingNotify(this);
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x060065B5 RID: 26037 RVA: 0x000F4FB9 File Offset: 0x000F31B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x060065B6 RID: 26038 RVA: 0x000F4FC1 File Offset: 0x000F31C1
		// (set) Token: 0x060065B7 RID: 26039 RVA: 0x000F4FC9 File Offset: 0x000F31C9
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

		// Token: 0x060065B8 RID: 26040 RVA: 0x000F4FD2 File Offset: 0x000F31D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableNearbyTrackingNotify);
		}

		// Token: 0x060065B9 RID: 26041 RVA: 0x000F4FE0 File Offset: 0x000F31E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableNearbyTrackingNotify other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && this.IsEnable == other.IsEnable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065BA RID: 26042 RVA: 0x000F5030 File Offset: 0x000F3230
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

		// Token: 0x060065BB RID: 26043 RVA: 0x000F507D File Offset: 0x000F327D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x000F508A File Offset: 0x000F328A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065BD RID: 26045 RVA: 0x000F5094 File Offset: 0x000F3294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, EnableNearbyTrackingNotify._repeated_entityIds_codec);
			if (this.IsEnable)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsEnable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x000F50E4 File Offset: 0x000F32E4
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

		// Token: 0x060065BF RID: 26047 RVA: 0x000F512C File Offset: 0x000F332C
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

		// Token: 0x060065C0 RID: 26048 RVA: 0x000F5179 File Offset: 0x000F3379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x000F5184 File Offset: 0x000F3384
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
				if (num != 40U && num != 42U)
				{
					if (num != 64U)
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

		// Token: 0x04003946 RID: 14662
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003947 RID: 14663
		public const int EntityIdsFieldNumber = 5;

		// Token: 0x04003948 RID: 14664
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(42U);

		// Token: 0x04003949 RID: 14665
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();

		// Token: 0x0400394A RID: 14666
		public const int IsEnableFieldNumber = 8;

		// Token: 0x0400394B RID: 14667
		private bool isEnable_;
	}
}

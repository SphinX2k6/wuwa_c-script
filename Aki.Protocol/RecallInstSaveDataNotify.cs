using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9A RID: 3738
	[NetMessage(EMessageId.RecallInstSaveDataNotify)]
	public sealed class RecallInstSaveDataNotify : IMessage<RecallInstSaveDataNotify>, IMessage, IEquatable<RecallInstSaveDataNotify>, IDeepCloneable<RecallInstSaveDataNotify>, IBufferMessage
	{
		// Token: 0x06014170 RID: 82288 RVA: 0x002ED03E File Offset: 0x002EB23E
		[NullableContext(1)]
		public static RecallInstSaveDataNotify Create()
		{
			return new RecallInstSaveDataNotify();
		}

		// Token: 0x170042D7 RID: 17111
		// (get) Token: 0x06014171 RID: 82289 RVA: 0x002ED045 File Offset: 0x002EB245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042D8 RID: 17112
		// (get) Token: 0x06014172 RID: 82290 RVA: 0x002ED048 File Offset: 0x002EB248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallInstSaveDataNotify.Descriptor;
			}
		}

		// Token: 0x06014173 RID: 82291 RVA: 0x002ED04F File Offset: 0x002EB24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInstSaveDataNotify()
		{
		}

		// Token: 0x06014174 RID: 82292 RVA: 0x002ED062 File Offset: 0x002EB262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInstSaveDataNotify(RecallInstSaveDataNotify other) : this()
		{
			this.recallId_ = other.recallId_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014175 RID: 82293 RVA: 0x002ED098 File Offset: 0x002EB298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInstSaveDataNotify Clone()
		{
			return new RecallInstSaveDataNotify(this);
		}

		// Token: 0x170042D9 RID: 17113
		// (get) Token: 0x06014176 RID: 82294 RVA: 0x002ED0A0 File Offset: 0x002EB2A0
		// (set) Token: 0x06014177 RID: 82295 RVA: 0x002ED0A8 File Offset: 0x002EB2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallId
		{
			get
			{
				return this.recallId_;
			}
			set
			{
				this.recallId_ = value;
			}
		}

		// Token: 0x170042DA RID: 17114
		// (get) Token: 0x06014178 RID: 82296 RVA: 0x002ED0B1 File Offset: 0x002EB2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06014179 RID: 82297 RVA: 0x002ED0B9 File Offset: 0x002EB2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallInstSaveDataNotify);
		}

		// Token: 0x0601417A RID: 82298 RVA: 0x002ED0C8 File Offset: 0x002EB2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallInstSaveDataNotify other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601417B RID: 82299 RVA: 0x002ED118 File Offset: 0x002EB318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallId != 0)
			{
				num ^= this.RecallId.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601417C RID: 82300 RVA: 0x002ED165 File Offset: 0x002EB365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601417D RID: 82301 RVA: 0x002ED172 File Offset: 0x002EB372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601417E RID: 82302 RVA: 0x002ED17C File Offset: 0x002EB37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, RecallInstSaveDataNotify._repeated_ids_codec);
			if (this.RecallId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RecallId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601417F RID: 82303 RVA: 0x002ED1CC File Offset: 0x002EB3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			num += this.ids_.CalculateSize(RecallInstSaveDataNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014180 RID: 82304 RVA: 0x002ED220 File Offset: 0x002EB420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallInstSaveDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallId != 0)
			{
				this.RecallId = other.RecallId;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014181 RID: 82305 RVA: 0x002ED26D File Offset: 0x002EB46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014182 RID: 82306 RVA: 0x002ED278 File Offset: 0x002EB478
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
				if (num != 48U && num != 50U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RecallId = input.ReadInt32();
					}
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, RecallInstSaveDataNotify._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04007AE0 RID: 31456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AE1 RID: 31457
		public const int RecallIdFieldNumber = 14;

		// Token: 0x04007AE2 RID: 31458
		private int recallId_;

		// Token: 0x04007AE3 RID: 31459
		public const int IdsFieldNumber = 6;

		// Token: 0x04007AE4 RID: 31460
		private static readonly FieldCodec<long> _repeated_ids_codec = FieldCodec.ForInt64(50U);

		// Token: 0x04007AE5 RID: 31461
		private readonly RepeatedField<long> ids_ = new RepeatedField<long>();
	}
}

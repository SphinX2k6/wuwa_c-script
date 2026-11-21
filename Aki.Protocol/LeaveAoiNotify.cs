using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D7 RID: 2263
	[NetMessage(EMessageId.LeaveAoiNotify)]
	public sealed class LeaveAoiNotify : IMessage<LeaveAoiNotify>, IMessage, IEquatable<LeaveAoiNotify>, IDeepCloneable<LeaveAoiNotify>, IBufferMessage
	{
		// Token: 0x0600C898 RID: 51352 RVA: 0x001DA897 File Offset: 0x001D8A97
		[NullableContext(1)]
		public static LeaveAoiNotify Create()
		{
			return new LeaveAoiNotify();
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x0600C899 RID: 51353 RVA: 0x001DA89E File Offset: 0x001D8A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x0600C89A RID: 51354 RVA: 0x001DA8A1 File Offset: 0x001D8AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveAoiNotify.Descriptor;
			}
		}

		// Token: 0x0600C89B RID: 51355 RVA: 0x001DA8A8 File Offset: 0x001D8AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAoiNotify()
		{
		}

		// Token: 0x0600C89C RID: 51356 RVA: 0x001DA8BB File Offset: 0x001D8ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAoiNotify(LeaveAoiNotify other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C89D RID: 51357 RVA: 0x001DA8E5 File Offset: 0x001D8AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveAoiNotify Clone()
		{
			return new LeaveAoiNotify(this);
		}

		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x0600C89E RID: 51358 RVA: 0x001DA8ED File Offset: 0x001D8AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0600C89F RID: 51359 RVA: 0x001DA8F5 File Offset: 0x001D8AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveAoiNotify);
		}

		// Token: 0x0600C8A0 RID: 51360 RVA: 0x001DA903 File Offset: 0x001D8B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveAoiNotify other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8A1 RID: 51361 RVA: 0x001DA938 File Offset: 0x001D8B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C8A2 RID: 51362 RVA: 0x001DA96C File Offset: 0x001D8B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C8A3 RID: 51363 RVA: 0x001DA979 File Offset: 0x001D8B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8A4 RID: 51364 RVA: 0x001DA982 File Offset: 0x001D8B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, LeaveAoiNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C8A5 RID: 51365 RVA: 0x001DA9AC File Offset: 0x001D8BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityIds_.CalculateSize(LeaveAoiNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C8A6 RID: 51366 RVA: 0x001DA9E5 File Offset: 0x001D8BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveAoiNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C8A7 RID: 51367 RVA: 0x001DAA13 File Offset: 0x001D8C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8A8 RID: 51368 RVA: 0x001DAA1C File Offset: 0x001D8C1C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, LeaveAoiNotify._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x04005607 RID: 22023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005608 RID: 22024
		public const int EntityIdsFieldNumber = 10;

		// Token: 0x04005609 RID: 22025
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(82U);

		// Token: 0x0400560A RID: 22026
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A8 RID: 168
	[NetMessage(EMessageId.AddOccupationInfoNotify)]
	public sealed class AddOccupationInfoNotify : IMessage<AddOccupationInfoNotify>, IMessage, IEquatable<AddOccupationInfoNotify>, IDeepCloneable<AddOccupationInfoNotify>, IBufferMessage
	{
		// Token: 0x06001CE1 RID: 7393 RVA: 0x0004FD0A File Offset: 0x0004DF0A
		[NullableContext(1)]
		public static AddOccupationInfoNotify Create()
		{
			return new AddOccupationInfoNotify();
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x0004FD11 File Offset: 0x0004DF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0004FD14 File Offset: 0x0004DF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddOccupationInfoNotify.Descriptor;
			}
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0004FD1B File Offset: 0x0004DF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddOccupationInfoNotify()
		{
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0004FD2E File Offset: 0x0004DF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddOccupationInfoNotify(AddOccupationInfoNotify other) : this()
		{
			this.occupationInfo_ = other.occupationInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0004FD58 File Offset: 0x0004DF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddOccupationInfoNotify Clone()
		{
			return new AddOccupationInfoNotify(this);
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x0004FD60 File Offset: 0x0004DF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OccupationPbInfo> OccupationInfo
		{
			get
			{
				return this.occupationInfo_;
			}
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x0004FD68 File Offset: 0x0004DF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddOccupationInfoNotify);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0004FD76 File Offset: 0x0004DF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddOccupationInfoNotify other)
		{
			return other != null && (other == this || (this.occupationInfo_.Equals(other.occupationInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0004FDAC File Offset: 0x0004DFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.occupationInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0004FDE0 File Offset: 0x0004DFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0004FDED File Offset: 0x0004DFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0004FDF6 File Offset: 0x0004DFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.occupationInfo_.WriteTo(ref output, AddOccupationInfoNotify._repeated_occupationInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0004FE20 File Offset: 0x0004E020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.occupationInfo_.CalculateSize(AddOccupationInfoNotify._repeated_occupationInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0004FE59 File Offset: 0x0004E059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddOccupationInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.occupationInfo_.Add(other.occupationInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0004FE87 File Offset: 0x0004E087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0004FE90 File Offset: 0x0004E090
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.occupationInfo_.AddEntriesFrom(ref input, AddOccupationInfoNotify._repeated_occupationInfo_codec);
				}
			}
		}

		// Token: 0x040022FA RID: 8954
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022FB RID: 8955
		public const int OccupationInfoFieldNumber = 2;

		// Token: 0x040022FC RID: 8956
		private static readonly FieldCodec<OccupationPbInfo> _repeated_occupationInfo_codec = FieldCodec.ForMessage<OccupationPbInfo>(18U, OccupationPbInfo.Parser);

		// Token: 0x040022FD RID: 8957
		private readonly RepeatedField<OccupationPbInfo> occupationInfo_ = new RepeatedField<OccupationPbInfo>();
	}
}

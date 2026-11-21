using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150C RID: 5388
	[NetMessage(EMessageId.UpdateFormationRequest)]
	public sealed class UpdateFormationRequest : IMessage<UpdateFormationRequest>, IMessage, IEquatable<UpdateFormationRequest>, IDeepCloneable<UpdateFormationRequest>, IBufferMessage
	{
		// Token: 0x0601C8D2 RID: 116946 RVA: 0x004235A1 File Offset: 0x004217A1
		[NullableContext(1)]
		public static UpdateFormationRequest Create()
		{
			return new UpdateFormationRequest();
		}

		// Token: 0x17006096 RID: 24726
		// (get) Token: 0x0601C8D3 RID: 116947 RVA: 0x004235A8 File Offset: 0x004217A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006097 RID: 24727
		// (get) Token: 0x0601C8D4 RID: 116948 RVA: 0x004235AB File Offset: 0x004217AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFormationRequest.Descriptor;
			}
		}

		// Token: 0x0601C8D5 RID: 116949 RVA: 0x004235B2 File Offset: 0x004217B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationRequest()
		{
		}

		// Token: 0x0601C8D6 RID: 116950 RVA: 0x004235C5 File Offset: 0x004217C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationRequest(UpdateFormationRequest other) : this()
		{
			this.formations_ = other.formations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C8D7 RID: 116951 RVA: 0x004235EF File Offset: 0x004217EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationRequest Clone()
		{
			return new UpdateFormationRequest(this);
		}

		// Token: 0x17006098 RID: 24728
		// (get) Token: 0x0601C8D8 RID: 116952 RVA: 0x004235F7 File Offset: 0x004217F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightFormation> Formations
		{
			get
			{
				return this.formations_;
			}
		}

		// Token: 0x0601C8D9 RID: 116953 RVA: 0x004235FF File Offset: 0x004217FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFormationRequest);
		}

		// Token: 0x0601C8DA RID: 116954 RVA: 0x0042360D File Offset: 0x0042180D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFormationRequest other)
		{
			return other != null && (other == this || (this.formations_.Equals(other.formations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C8DB RID: 116955 RVA: 0x00423640 File Offset: 0x00421840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.formations_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C8DC RID: 116956 RVA: 0x00423674 File Offset: 0x00421874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C8DD RID: 116957 RVA: 0x00423681 File Offset: 0x00421881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C8DE RID: 116958 RVA: 0x0042368A File Offset: 0x0042188A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.formations_.WriteTo(ref output, UpdateFormationRequest._repeated_formations_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C8DF RID: 116959 RVA: 0x004236B4 File Offset: 0x004218B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.formations_.CalculateSize(UpdateFormationRequest._repeated_formations_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C8E0 RID: 116960 RVA: 0x004236ED File Offset: 0x004218ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateFormationRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.formations_.Add(other.formations_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C8E1 RID: 116961 RVA: 0x0042371B File Offset: 0x0042191B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C8E2 RID: 116962 RVA: 0x00423724 File Offset: 0x00421924
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.formations_.AddEntriesFrom(ref input, UpdateFormationRequest._repeated_formations_codec);
				}
			}
		}

		// Token: 0x0400A49C RID: 42140
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A49D RID: 42141
		public const int FormationsFieldNumber = 11;

		// Token: 0x0400A49E RID: 42142
		private static readonly FieldCodec<FightFormation> _repeated_formations_codec = FieldCodec.ForMessage<FightFormation>(90U, FightFormation.Parser);

		// Token: 0x0400A49F RID: 42143
		private readonly RepeatedField<FightFormation> formations_ = new RepeatedField<FightFormation>();
	}
}

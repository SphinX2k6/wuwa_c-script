using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B70 RID: 2928
	[NetMessage(EMessageId.OccupyRewardRequest)]
	public sealed class OccupyRewardRequest : IMessage<OccupyRewardRequest>, IMessage, IEquatable<OccupyRewardRequest>, IDeepCloneable<OccupyRewardRequest>, IBufferMessage
	{
		// Token: 0x0600FE26 RID: 65062 RVA: 0x002517A6 File Offset: 0x0024F9A6
		[NullableContext(1)]
		public static OccupyRewardRequest Create()
		{
			return new OccupyRewardRequest();
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600FE27 RID: 65063 RVA: 0x002517AD File Offset: 0x0024F9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600FE28 RID: 65064 RVA: 0x002517B0 File Offset: 0x0024F9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OccupyRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600FE29 RID: 65065 RVA: 0x002517B7 File Offset: 0x0024F9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardRequest()
		{
		}

		// Token: 0x0600FE2A RID: 65066 RVA: 0x002517CA File Offset: 0x0024F9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardRequest(OccupyRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE2B RID: 65067 RVA: 0x002517F4 File Offset: 0x0024F9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardRequest Clone()
		{
			return new OccupyRewardRequest(this);
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600FE2C RID: 65068 RVA: 0x002517FC File Offset: 0x0024F9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600FE2D RID: 65069 RVA: 0x00251804 File Offset: 0x0024FA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OccupyRewardRequest);
		}

		// Token: 0x0600FE2E RID: 65070 RVA: 0x00251812 File Offset: 0x0024FA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OccupyRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE2F RID: 65071 RVA: 0x00251848 File Offset: 0x0024FA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FE30 RID: 65072 RVA: 0x0025187C File Offset: 0x0024FA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE31 RID: 65073 RVA: 0x00251889 File Offset: 0x0024FA89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE32 RID: 65074 RVA: 0x00251892 File Offset: 0x0024FA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, OccupyRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FE33 RID: 65075 RVA: 0x002518BC File Offset: 0x0024FABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(OccupyRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FE34 RID: 65076 RVA: 0x002518F5 File Offset: 0x0024FAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OccupyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FE35 RID: 65077 RVA: 0x00251923 File Offset: 0x0024FB23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE36 RID: 65078 RVA: 0x0025192C File Offset: 0x0024FB2C
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, OccupyRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x040065B4 RID: 26036
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065B5 RID: 26037
		public const int IdsFieldNumber = 14;

		// Token: 0x040065B6 RID: 26038
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040065B7 RID: 26039
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}

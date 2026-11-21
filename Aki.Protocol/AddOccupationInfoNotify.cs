using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A9 RID: 169
	[NetMessage(EMessageId.AddOccupationInfoNotify)]
	public sealed class AddOccupationInfoNotify : IMessage<AddOccupationInfoNotify>, IMessage, IEquatable<AddOccupationInfoNotify>, IDeepCloneable<AddOccupationInfoNotify>, IBufferMessage
	{
		// Token: 0x06001D28 RID: 7464 RVA: 0x00050922 File Offset: 0x0004EB22
		[NullableContext(1)]
		public static AddOccupationInfoNotify Create()
		{
			return new AddOccupationInfoNotify();
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00050929 File Offset: 0x0004EB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0005092C File Offset: 0x0004EB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddOccupationInfoNotify.Descriptor;
			}
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00050933 File Offset: 0x0004EB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddOccupationInfoNotify()
		{
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x00050946 File Offset: 0x0004EB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddOccupationInfoNotify(AddOccupationInfoNotify other) : this()
		{
			this.occupationInfo_ = other.occupationInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x00050970 File Offset: 0x0004EB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddOccupationInfoNotify Clone()
		{
			return new AddOccupationInfoNotify(this);
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00050978 File Offset: 0x0004EB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OccupationPbInfo> OccupationInfo
		{
			get
			{
				return this.occupationInfo_;
			}
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00050980 File Offset: 0x0004EB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddOccupationInfoNotify);
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x0005098E File Offset: 0x0004EB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddOccupationInfoNotify other)
		{
			return other != null && (other == this || (this.occupationInfo_.Equals(other.occupationInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x000509C4 File Offset: 0x0004EBC4
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

		// Token: 0x06001D32 RID: 7474 RVA: 0x000509F8 File Offset: 0x0004EBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00050A05 File Offset: 0x0004EC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00050A0E File Offset: 0x0004EC0E
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

		// Token: 0x06001D35 RID: 7477 RVA: 0x00050A38 File Offset: 0x0004EC38
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

		// Token: 0x06001D36 RID: 7478 RVA: 0x00050A71 File Offset: 0x0004EC71
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

		// Token: 0x06001D37 RID: 7479 RVA: 0x00050A9F File Offset: 0x0004EC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x00050AA8 File Offset: 0x0004ECA8
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.occupationInfo_.AddEntriesFrom(ref input, AddOccupationInfoNotify._repeated_occupationInfo_codec);
				}
			}
		}

		// Token: 0x0400235B RID: 9051
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400235C RID: 9052
		public const int OccupationInfoFieldNumber = 9;

		// Token: 0x0400235D RID: 9053
		private static readonly FieldCodec<OccupationPbInfo> _repeated_occupationInfo_codec = FieldCodec.ForMessage<OccupationPbInfo>(74U, OccupationPbInfo.Parser);

		// Token: 0x0400235E RID: 9054
		private readonly RepeatedField<OccupationPbInfo> occupationInfo_ = new RepeatedField<OccupationPbInfo>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2A RID: 2858
	[NetMessage(EMessageId.NewTowerMedalInfoResponse)]
	public sealed class NewTowerMedalInfoResponse : IMessage<NewTowerMedalInfoResponse>, IMessage, IEquatable<NewTowerMedalInfoResponse>, IDeepCloneable<NewTowerMedalInfoResponse>, IBufferMessage
	{
		// Token: 0x0600F862 RID: 63586 RVA: 0x00243FD6 File Offset: 0x002421D6
		[NullableContext(1)]
		public static NewTowerMedalInfoResponse Create()
		{
			return new NewTowerMedalInfoResponse();
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600F863 RID: 63587 RVA: 0x00243FDD File Offset: 0x002421DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600F864 RID: 63588 RVA: 0x00243FE0 File Offset: 0x002421E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerMedalInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600F865 RID: 63589 RVA: 0x00243FE7 File Offset: 0x002421E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoResponse()
		{
		}

		// Token: 0x0600F866 RID: 63590 RVA: 0x00243FFA File Offset: 0x002421FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoResponse(NewTowerMedalInfoResponse other) : this()
		{
			this.newTowerMedalInfos_ = other.newTowerMedalInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F867 RID: 63591 RVA: 0x00244024 File Offset: 0x00242224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoResponse Clone()
		{
			return new NewTowerMedalInfoResponse(this);
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600F868 RID: 63592 RVA: 0x0024402C File Offset: 0x0024222C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerMedalInfo> NewTowerMedalInfos
		{
			get
			{
				return this.newTowerMedalInfos_;
			}
		}

		// Token: 0x0600F869 RID: 63593 RVA: 0x00244034 File Offset: 0x00242234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerMedalInfoResponse);
		}

		// Token: 0x0600F86A RID: 63594 RVA: 0x00244042 File Offset: 0x00242242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerMedalInfoResponse other)
		{
			return other != null && (other == this || (this.newTowerMedalInfos_.Equals(other.newTowerMedalInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F86B RID: 63595 RVA: 0x00244078 File Offset: 0x00242278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.newTowerMedalInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F86C RID: 63596 RVA: 0x002440AC File Offset: 0x002422AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F86D RID: 63597 RVA: 0x002440B9 File Offset: 0x002422B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F86E RID: 63598 RVA: 0x002440C2 File Offset: 0x002422C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.newTowerMedalInfos_.WriteTo(ref output, NewTowerMedalInfoResponse._repeated_newTowerMedalInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F86F RID: 63599 RVA: 0x002440EC File Offset: 0x002422EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.newTowerMedalInfos_.CalculateSize(NewTowerMedalInfoResponse._repeated_newTowerMedalInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F870 RID: 63600 RVA: 0x00244125 File Offset: 0x00242325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerMedalInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.newTowerMedalInfos_.Add(other.newTowerMedalInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F871 RID: 63601 RVA: 0x00244153 File Offset: 0x00242353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F872 RID: 63602 RVA: 0x0024415C File Offset: 0x0024235C
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.newTowerMedalInfos_.AddEntriesFrom(ref input, NewTowerMedalInfoResponse._repeated_newTowerMedalInfos_codec);
				}
			}
		}

		// Token: 0x040063FC RID: 25596
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063FD RID: 25597
		public const int NewTowerMedalInfosFieldNumber = 13;

		// Token: 0x040063FE RID: 25598
		private static readonly FieldCodec<NewTowerMedalInfo> _repeated_newTowerMedalInfos_codec = FieldCodec.ForMessage<NewTowerMedalInfo>(106U, NewTowerMedalInfo.Parser);

		// Token: 0x040063FF RID: 25599
		private readonly RepeatedField<NewTowerMedalInfo> newTowerMedalInfos_ = new RepeatedField<NewTowerMedalInfo>();
	}
}

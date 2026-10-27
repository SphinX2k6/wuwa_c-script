using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3B RID: 2875
	[NetMessage(EMessageId.NewTowerMedalInfoResponse)]
	public sealed class NewTowerMedalInfoResponse : IMessage<NewTowerMedalInfoResponse>, IMessage, IEquatable<NewTowerMedalInfoResponse>, IDeepCloneable<NewTowerMedalInfoResponse>, IBufferMessage
	{
		// Token: 0x0600F97C RID: 63868 RVA: 0x002461F2 File Offset: 0x002443F2
		[NullableContext(1)]
		public static NewTowerMedalInfoResponse Create()
		{
			return new NewTowerMedalInfoResponse();
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x0600F97D RID: 63869 RVA: 0x002461F9 File Offset: 0x002443F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0600F97E RID: 63870 RVA: 0x002461FC File Offset: 0x002443FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerMedalInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600F97F RID: 63871 RVA: 0x00246203 File Offset: 0x00244403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoResponse()
		{
		}

		// Token: 0x0600F980 RID: 63872 RVA: 0x00246216 File Offset: 0x00244416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoResponse(NewTowerMedalInfoResponse other) : this()
		{
			this.newTowerMedalInfos_ = other.newTowerMedalInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F981 RID: 63873 RVA: 0x00246240 File Offset: 0x00244440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoResponse Clone()
		{
			return new NewTowerMedalInfoResponse(this);
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x0600F982 RID: 63874 RVA: 0x00246248 File Offset: 0x00244448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerMedalInfo> NewTowerMedalInfos
		{
			get
			{
				return this.newTowerMedalInfos_;
			}
		}

		// Token: 0x0600F983 RID: 63875 RVA: 0x00246250 File Offset: 0x00244450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerMedalInfoResponse);
		}

		// Token: 0x0600F984 RID: 63876 RVA: 0x0024625E File Offset: 0x0024445E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerMedalInfoResponse other)
		{
			return other != null && (other == this || (this.newTowerMedalInfos_.Equals(other.newTowerMedalInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F985 RID: 63877 RVA: 0x00246294 File Offset: 0x00244494
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

		// Token: 0x0600F986 RID: 63878 RVA: 0x002462C8 File Offset: 0x002444C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F987 RID: 63879 RVA: 0x002462D5 File Offset: 0x002444D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F988 RID: 63880 RVA: 0x002462DE File Offset: 0x002444DE
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

		// Token: 0x0600F989 RID: 63881 RVA: 0x00246308 File Offset: 0x00244508
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

		// Token: 0x0600F98A RID: 63882 RVA: 0x00246341 File Offset: 0x00244541
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

		// Token: 0x0600F98B RID: 63883 RVA: 0x0024636F File Offset: 0x0024456F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F98C RID: 63884 RVA: 0x00246378 File Offset: 0x00244578
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.newTowerMedalInfos_.AddEntriesFrom(ref input, NewTowerMedalInfoResponse._repeated_newTowerMedalInfos_codec);
				}
			}
		}

		// Token: 0x040063F3 RID: 25587
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063F4 RID: 25588
		public const int NewTowerMedalInfosFieldNumber = 3;

		// Token: 0x040063F5 RID: 25589
		private static readonly FieldCodec<NewTowerMedalInfo> _repeated_newTowerMedalInfos_codec = FieldCodec.ForMessage<NewTowerMedalInfo>(26U, NewTowerMedalInfo.Parser);

		// Token: 0x040063F6 RID: 25590
		private readonly RepeatedField<NewTowerMedalInfo> newTowerMedalInfos_ = new RepeatedField<NewTowerMedalInfo>();
	}
}

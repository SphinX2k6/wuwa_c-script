using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C3 RID: 195
	[NetMessage(EMessageId.AdventureUpdateNotify)]
	public sealed class AdventureUpdateNotify : IMessage<AdventureUpdateNotify>, IMessage, IEquatable<AdventureUpdateNotify>, IDeepCloneable<AdventureUpdateNotify>, IBufferMessage
	{
		// Token: 0x06001F03 RID: 7939 RVA: 0x00054954 File Offset: 0x00052B54
		[NullableContext(1)]
		public static AdventureUpdateNotify Create()
		{
			return new AdventureUpdateNotify();
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x0005495B File Offset: 0x00052B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x0005495E File Offset: 0x00052B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00054965 File Offset: 0x00052B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureUpdateNotify()
		{
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00054978 File Offset: 0x00052B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureUpdateNotify(AdventureUpdateNotify other) : this()
		{
			this.adventureManualData_ = other.adventureManualData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x000549A2 File Offset: 0x00052BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureUpdateNotify Clone()
		{
			return new AdventureUpdateNotify(this);
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x000549AA File Offset: 0x00052BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventureManualData> AdventureManualData
		{
			get
			{
				return this.adventureManualData_;
			}
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x000549B2 File Offset: 0x00052BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureUpdateNotify);
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x000549C0 File Offset: 0x00052BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureUpdateNotify other)
		{
			return other != null && (other == this || (this.adventureManualData_.Equals(other.adventureManualData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x000549F4 File Offset: 0x00052BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.adventureManualData_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00054A28 File Offset: 0x00052C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00054A35 File Offset: 0x00052C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00054A3E File Offset: 0x00052C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.adventureManualData_.WriteTo(ref output, AdventureUpdateNotify._repeated_adventureManualData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00054A68 File Offset: 0x00052C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adventureManualData_.CalculateSize(AdventureUpdateNotify._repeated_adventureManualData_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00054AA1 File Offset: 0x00052CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.adventureManualData_.Add(other.adventureManualData_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00054ACF File Offset: 0x00052CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00054AD8 File Offset: 0x00052CD8
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.adventureManualData_.AddEntriesFrom(ref input, AdventureUpdateNotify._repeated_adventureManualData_codec);
				}
			}
		}

		// Token: 0x0400239D RID: 9117
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400239E RID: 9118
		public const int AdventureManualDataFieldNumber = 7;

		// Token: 0x0400239F RID: 9119
		private static readonly FieldCodec<AdventureManualData> _repeated_adventureManualData_codec = FieldCodec.ForMessage<AdventureManualData>(58U, Aki.Protocol.AdventureManualData.Parser);

		// Token: 0x040023A0 RID: 9120
		private readonly RepeatedField<AdventureManualData> adventureManualData_ = new RepeatedField<AdventureManualData>();
	}
}

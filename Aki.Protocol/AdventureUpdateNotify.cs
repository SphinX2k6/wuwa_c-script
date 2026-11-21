using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C4 RID: 196
	[NetMessage(EMessageId.AdventureUpdateNotify)]
	public sealed class AdventureUpdateNotify : IMessage<AdventureUpdateNotify>, IMessage, IEquatable<AdventureUpdateNotify>, IDeepCloneable<AdventureUpdateNotify>, IBufferMessage
	{
		// Token: 0x06001F4C RID: 8012 RVA: 0x00055608 File Offset: 0x00053808
		[NullableContext(1)]
		public static AdventureUpdateNotify Create()
		{
			return new AdventureUpdateNotify();
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x0005560F File Offset: 0x0005380F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00055612 File Offset: 0x00053812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00055619 File Offset: 0x00053819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureUpdateNotify()
		{
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x0005562C File Offset: 0x0005382C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureUpdateNotify(AdventureUpdateNotify other) : this()
		{
			this.adventureManualData_ = other.adventureManualData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x00055656 File Offset: 0x00053856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureUpdateNotify Clone()
		{
			return new AdventureUpdateNotify(this);
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x0005565E File Offset: 0x0005385E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventureManualData> AdventureManualData
		{
			get
			{
				return this.adventureManualData_;
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00055666 File Offset: 0x00053866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureUpdateNotify);
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00055674 File Offset: 0x00053874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureUpdateNotify other)
		{
			return other != null && (other == this || (this.adventureManualData_.Equals(other.adventureManualData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x000556A8 File Offset: 0x000538A8
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

		// Token: 0x06001F56 RID: 8022 RVA: 0x000556DC File Offset: 0x000538DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x000556E9 File Offset: 0x000538E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x000556F2 File Offset: 0x000538F2
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

		// Token: 0x06001F59 RID: 8025 RVA: 0x0005571C File Offset: 0x0005391C
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

		// Token: 0x06001F5A RID: 8026 RVA: 0x00055755 File Offset: 0x00053955
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

		// Token: 0x06001F5B RID: 8027 RVA: 0x00055783 File Offset: 0x00053983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0005578C File Offset: 0x0005398C
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.adventureManualData_.AddEntriesFrom(ref input, AdventureUpdateNotify._repeated_adventureManualData_codec);
				}
			}
		}

		// Token: 0x04002400 RID: 9216
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002401 RID: 9217
		public const int AdventureManualDataFieldNumber = 12;

		// Token: 0x04002402 RID: 9218
		private static readonly FieldCodec<AdventureManualData> _repeated_adventureManualData_codec = FieldCodec.ForMessage<AdventureManualData>(98U, Aki.Protocol.AdventureManualData.Parser);

		// Token: 0x04002403 RID: 9219
		private readonly RepeatedField<AdventureManualData> adventureManualData_ = new RepeatedField<AdventureManualData>();
	}
}

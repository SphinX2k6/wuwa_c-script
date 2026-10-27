using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB0 RID: 2992
	[NetMessage(EMessageId.OrnamentDressInfoUpdateNotify)]
	public sealed class OrnamentDressInfoUpdateNotify : IMessage<OrnamentDressInfoUpdateNotify>, IMessage, IEquatable<OrnamentDressInfoUpdateNotify>, IDeepCloneable<OrnamentDressInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06010395 RID: 66453 RVA: 0x0025E609 File Offset: 0x0025C809
		[NullableContext(1)]
		public static OrnamentDressInfoUpdateNotify Create()
		{
			return new OrnamentDressInfoUpdateNotify();
		}

		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x06010396 RID: 66454 RVA: 0x0025E610 File Offset: 0x0025C810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x06010397 RID: 66455 RVA: 0x0025E613 File Offset: 0x0025C813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentDressInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06010398 RID: 66456 RVA: 0x0025E61A File Offset: 0x0025C81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfoUpdateNotify()
		{
		}

		// Token: 0x06010399 RID: 66457 RVA: 0x0025E62D File Offset: 0x0025C82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfoUpdateNotify(OrnamentDressInfoUpdateNotify other) : this()
		{
			this.ornamentDressInfos_ = other.ornamentDressInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601039A RID: 66458 RVA: 0x0025E657 File Offset: 0x0025C857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfoUpdateNotify Clone()
		{
			return new OrnamentDressInfoUpdateNotify(this);
		}

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x0601039B RID: 66459 RVA: 0x0025E65F File Offset: 0x0025C85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OrnamentDressInfo> OrnamentDressInfos
		{
			get
			{
				return this.ornamentDressInfos_;
			}
		}

		// Token: 0x0601039C RID: 66460 RVA: 0x0025E667 File Offset: 0x0025C867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentDressInfoUpdateNotify);
		}

		// Token: 0x0601039D RID: 66461 RVA: 0x0025E675 File Offset: 0x0025C875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentDressInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.ornamentDressInfos_.Equals(other.ornamentDressInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601039E RID: 66462 RVA: 0x0025E6A8 File Offset: 0x0025C8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ornamentDressInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601039F RID: 66463 RVA: 0x0025E6DC File Offset: 0x0025C8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060103A0 RID: 66464 RVA: 0x0025E6E9 File Offset: 0x0025C8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060103A1 RID: 66465 RVA: 0x0025E6F2 File Offset: 0x0025C8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ornamentDressInfos_.WriteTo(ref output, OrnamentDressInfoUpdateNotify._repeated_ornamentDressInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060103A2 RID: 66466 RVA: 0x0025E71C File Offset: 0x0025C91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ornamentDressInfos_.CalculateSize(OrnamentDressInfoUpdateNotify._repeated_ornamentDressInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060103A3 RID: 66467 RVA: 0x0025E755 File Offset: 0x0025C955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrnamentDressInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.ornamentDressInfos_.Add(other.ornamentDressInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060103A4 RID: 66468 RVA: 0x0025E783 File Offset: 0x0025C983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060103A5 RID: 66469 RVA: 0x0025E78C File Offset: 0x0025C98C
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ornamentDressInfos_.AddEntriesFrom(ref input, OrnamentDressInfoUpdateNotify._repeated_ornamentDressInfos_codec);
				}
			}
		}

		// Token: 0x0400674C RID: 26444
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400674D RID: 26445
		public const int OrnamentDressInfosFieldNumber = 15;

		// Token: 0x0400674E RID: 26446
		private static readonly FieldCodec<OrnamentDressInfo> _repeated_ornamentDressInfos_codec = FieldCodec.ForMessage<OrnamentDressInfo>(122U, OrnamentDressInfo.Parser);

		// Token: 0x0400674F RID: 26447
		private readonly RepeatedField<OrnamentDressInfo> ornamentDressInfos_ = new RepeatedField<OrnamentDressInfo>();
	}
}

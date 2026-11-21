using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071E RID: 1822
	public sealed class HackingComponentPb : IMessage<HackingComponentPb>, IMessage, IEquatable<HackingComponentPb>, IDeepCloneable<HackingComponentPb>, IBufferMessage
	{
		// Token: 0x0600A5BE RID: 42430 RVA: 0x0018FAF2 File Offset: 0x0018DCF2
		[NullableContext(1)]
		public static HackingComponentPb Create()
		{
			return new HackingComponentPb();
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x0600A5BF RID: 42431 RVA: 0x0018FAF9 File Offset: 0x0018DCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x0600A5C0 RID: 42432 RVA: 0x0018FAFC File Offset: 0x0018DCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HackingComponentPb.Descriptor;
			}
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x0018FB03 File Offset: 0x0018DD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackingComponentPb()
		{
		}

		// Token: 0x0600A5C2 RID: 42434 RVA: 0x0018FB16 File Offset: 0x0018DD16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackingComponentPb(HackingComponentPb other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x0018FB40 File Offset: 0x0018DD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackingComponentPb Clone()
		{
			return new HackingComponentPb(this);
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x0600A5C4 RID: 42436 RVA: 0x0018FB48 File Offset: 0x0018DD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x0018FB50 File Offset: 0x0018DD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HackingComponentPb);
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x0018FB5E File Offset: 0x0018DD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HackingComponentPb other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x0018FB94 File Offset: 0x0018DD94
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

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x0018FBC8 File Offset: 0x0018DDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x0018FBD5 File Offset: 0x0018DDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5CA RID: 42442 RVA: 0x0018FBDE File Offset: 0x0018DDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, HackingComponentPb._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5CB RID: 42443 RVA: 0x0018FC08 File Offset: 0x0018DE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityIds_.CalculateSize(HackingComponentPb._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x0018FC41 File Offset: 0x0018DE41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HackingComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A5CD RID: 42445 RVA: 0x0018FC6F File Offset: 0x0018DE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5CE RID: 42446 RVA: 0x0018FC78 File Offset: 0x0018DE78
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, HackingComponentPb._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x04004C6E RID: 19566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C6F RID: 19567
		public const int EntityIdsFieldNumber = 1;

		// Token: 0x04004C70 RID: 19568
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x04004C71 RID: 19569
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}

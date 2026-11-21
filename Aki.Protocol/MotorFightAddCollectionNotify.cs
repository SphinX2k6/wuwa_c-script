using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A26 RID: 2598
	[NetMessage(EMessageId.MotorFightAddCollectionNotify)]
	public sealed class MotorFightAddCollectionNotify : IMessage<MotorFightAddCollectionNotify>, IMessage, IEquatable<MotorFightAddCollectionNotify>, IDeepCloneable<MotorFightAddCollectionNotify>, IBufferMessage
	{
		// Token: 0x0600E343 RID: 58179 RVA: 0x002144C1 File Offset: 0x002126C1
		[NullableContext(1)]
		public static MotorFightAddCollectionNotify Create()
		{
			return new MotorFightAddCollectionNotify();
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x0600E344 RID: 58180 RVA: 0x002144C8 File Offset: 0x002126C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x0600E345 RID: 58181 RVA: 0x002144CB File Offset: 0x002126CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightAddCollectionNotify.Descriptor;
			}
		}

		// Token: 0x0600E346 RID: 58182 RVA: 0x002144D2 File Offset: 0x002126D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddCollectionNotify()
		{
		}

		// Token: 0x0600E347 RID: 58183 RVA: 0x002144E5 File Offset: 0x002126E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddCollectionNotify(MotorFightAddCollectionNotify other) : this()
		{
			this.collections_ = other.collections_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E348 RID: 58184 RVA: 0x0021450F File Offset: 0x0021270F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddCollectionNotify Clone()
		{
			return new MotorFightAddCollectionNotify(this);
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x0600E349 RID: 58185 RVA: 0x00214517 File Offset: 0x00212717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundCollectionPb> Collections
		{
			get
			{
				return this.collections_;
			}
		}

		// Token: 0x0600E34A RID: 58186 RVA: 0x0021451F File Offset: 0x0021271F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightAddCollectionNotify);
		}

		// Token: 0x0600E34B RID: 58187 RVA: 0x0021452D File Offset: 0x0021272D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightAddCollectionNotify other)
		{
			return other != null && (other == this || (this.collections_.Equals(other.collections_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E34C RID: 58188 RVA: 0x00214560 File Offset: 0x00212760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.collections_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E34D RID: 58189 RVA: 0x00214594 File Offset: 0x00212794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E34E RID: 58190 RVA: 0x002145A1 File Offset: 0x002127A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E34F RID: 58191 RVA: 0x002145AA File Offset: 0x002127AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.collections_.WriteTo(ref output, MotorFightAddCollectionNotify._repeated_collections_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E350 RID: 58192 RVA: 0x002145D4 File Offset: 0x002127D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.collections_.CalculateSize(MotorFightAddCollectionNotify._repeated_collections_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E351 RID: 58193 RVA: 0x0021460D File Offset: 0x0021280D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightAddCollectionNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.collections_.Add(other.collections_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E352 RID: 58194 RVA: 0x0021463B File Offset: 0x0021283B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E353 RID: 58195 RVA: 0x00214644 File Offset: 0x00212844
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
					this.collections_.AddEntriesFrom(ref input, MotorFightAddCollectionNotify._repeated_collections_codec);
				}
			}
		}

		// Token: 0x04005D7D RID: 23933
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D7E RID: 23934
		public const int CollectionsFieldNumber = 12;

		// Token: 0x04005D7F RID: 23935
		private static readonly FieldCodec<MotorFightRoundCollectionPb> _repeated_collections_codec = FieldCodec.ForMessage<MotorFightRoundCollectionPb>(98U, MotorFightRoundCollectionPb.Parser);

		// Token: 0x04005D80 RID: 23936
		private readonly RepeatedField<MotorFightRoundCollectionPb> collections_ = new RepeatedField<MotorFightRoundCollectionPb>();
	}
}

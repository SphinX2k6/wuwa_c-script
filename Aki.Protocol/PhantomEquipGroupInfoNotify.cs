using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCC RID: 3276
	[NetMessage(EMessageId.PhantomEquipGroupInfoNotify)]
	public sealed class PhantomEquipGroupInfoNotify : IMessage<PhantomEquipGroupInfoNotify>, IMessage, IEquatable<PhantomEquipGroupInfoNotify>, IDeepCloneable<PhantomEquipGroupInfoNotify>, IBufferMessage
	{
		// Token: 0x06011BC6 RID: 72646 RVA: 0x002988B5 File Offset: 0x00296AB5
		[NullableContext(1)]
		public static PhantomEquipGroupInfoNotify Create()
		{
			return new PhantomEquipGroupInfoNotify();
		}

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x06011BC7 RID: 72647 RVA: 0x002988BC File Offset: 0x00296ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x06011BC8 RID: 72648 RVA: 0x002988BF File Offset: 0x00296ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomEquipGroupInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011BC9 RID: 72649 RVA: 0x002988C6 File Offset: 0x00296AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfoNotify()
		{
		}

		// Token: 0x06011BCA RID: 72650 RVA: 0x002988D9 File Offset: 0x00296AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfoNotify(PhantomEquipGroupInfoNotify other) : this()
		{
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011BCB RID: 72651 RVA: 0x00298903 File Offset: 0x00296B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfoNotify Clone()
		{
			return new PhantomEquipGroupInfoNotify(this);
		}

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x06011BCC RID: 72652 RVA: 0x0029890B File Offset: 0x00296B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x06011BCD RID: 72653 RVA: 0x00298913 File Offset: 0x00296B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomEquipGroupInfoNotify);
		}

		// Token: 0x06011BCE RID: 72654 RVA: 0x00298921 File Offset: 0x00296B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomEquipGroupInfoNotify other)
		{
			return other != null && (other == this || (this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011BCF RID: 72655 RVA: 0x00298954 File Offset: 0x00296B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomEquipGroupInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011BD0 RID: 72656 RVA: 0x00298988 File Offset: 0x00296B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011BD1 RID: 72657 RVA: 0x00298995 File Offset: 0x00296B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011BD2 RID: 72658 RVA: 0x0029899E File Offset: 0x00296B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomEquipGroupInfos_.WriteTo(ref output, PhantomEquipGroupInfoNotify._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011BD3 RID: 72659 RVA: 0x002989C8 File Offset: 0x00296BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomEquipGroupInfos_.CalculateSize(PhantomEquipGroupInfoNotify._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011BD4 RID: 72660 RVA: 0x00298A01 File Offset: 0x00296C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomEquipGroupInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomEquipGroupInfos_.Add(other.phantomEquipGroupInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011BD5 RID: 72661 RVA: 0x00298A2F File Offset: 0x00296C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011BD6 RID: 72662 RVA: 0x00298A38 File Offset: 0x00296C38
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
					this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, PhantomEquipGroupInfoNotify._repeated_phantomEquipGroupInfos_codec);
				}
			}
		}

		// Token: 0x04006F7D RID: 28541
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F7E RID: 28542
		public const int PhantomEquipGroupInfosFieldNumber = 15;

		// Token: 0x04006F7F RID: 28543
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(122U, PhantomEquipGroupInfo.Parser);

		// Token: 0x04006F80 RID: 28544
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();
	}
}

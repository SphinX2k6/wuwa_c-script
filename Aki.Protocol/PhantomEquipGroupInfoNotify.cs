using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBC RID: 3260
	[NetMessage(EMessageId.PhantomEquipGroupInfoNotify)]
	public sealed class PhantomEquipGroupInfoNotify : IMessage<PhantomEquipGroupInfoNotify>, IMessage, IEquatable<PhantomEquipGroupInfoNotify>, IDeepCloneable<PhantomEquipGroupInfoNotify>, IBufferMessage
	{
		// Token: 0x06011AC6 RID: 72390 RVA: 0x00296B55 File Offset: 0x00294D55
		[NullableContext(1)]
		public static PhantomEquipGroupInfoNotify Create()
		{
			return new PhantomEquipGroupInfoNotify();
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x06011AC7 RID: 72391 RVA: 0x00296B5C File Offset: 0x00294D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x06011AC8 RID: 72392 RVA: 0x00296B5F File Offset: 0x00294D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomEquipGroupInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011AC9 RID: 72393 RVA: 0x00296B66 File Offset: 0x00294D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfoNotify()
		{
		}

		// Token: 0x06011ACA RID: 72394 RVA: 0x00296B79 File Offset: 0x00294D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfoNotify(PhantomEquipGroupInfoNotify other) : this()
		{
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011ACB RID: 72395 RVA: 0x00296BA3 File Offset: 0x00294DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfoNotify Clone()
		{
			return new PhantomEquipGroupInfoNotify(this);
		}

		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x06011ACC RID: 72396 RVA: 0x00296BAB File Offset: 0x00294DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x06011ACD RID: 72397 RVA: 0x00296BB3 File Offset: 0x00294DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomEquipGroupInfoNotify);
		}

		// Token: 0x06011ACE RID: 72398 RVA: 0x00296BC1 File Offset: 0x00294DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomEquipGroupInfoNotify other)
		{
			return other != null && (other == this || (this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011ACF RID: 72399 RVA: 0x00296BF4 File Offset: 0x00294DF4
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

		// Token: 0x06011AD0 RID: 72400 RVA: 0x00296C28 File Offset: 0x00294E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011AD1 RID: 72401 RVA: 0x00296C35 File Offset: 0x00294E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011AD2 RID: 72402 RVA: 0x00296C3E File Offset: 0x00294E3E
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

		// Token: 0x06011AD3 RID: 72403 RVA: 0x00296C68 File Offset: 0x00294E68
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

		// Token: 0x06011AD4 RID: 72404 RVA: 0x00296CA1 File Offset: 0x00294EA1
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

		// Token: 0x06011AD5 RID: 72405 RVA: 0x00296CCF File Offset: 0x00294ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011AD6 RID: 72406 RVA: 0x00296CD8 File Offset: 0x00294ED8
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, PhantomEquipGroupInfoNotify._repeated_phantomEquipGroupInfos_codec);
				}
			}
		}

		// Token: 0x04006F91 RID: 28561
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F92 RID: 28562
		public const int PhantomEquipGroupInfosFieldNumber = 8;

		// Token: 0x04006F93 RID: 28563
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(66U, PhantomEquipGroupInfo.Parser);

		// Token: 0x04006F94 RID: 28564
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();
	}
}

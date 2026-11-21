using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001228 RID: 4648
	[NetMessage(EMessageId.ShieldUpdateNotify)]
	public sealed class ShieldUpdateNotify : IMessage<ShieldUpdateNotify>, IMessage, IEquatable<ShieldUpdateNotify>, IDeepCloneable<ShieldUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018D2C RID: 101676 RVA: 0x0039E440 File Offset: 0x0039C640
		[NullableContext(1)]
		public static ShieldUpdateNotify Create()
		{
			return new ShieldUpdateNotify();
		}

		// Token: 0x170053D7 RID: 21463
		// (get) Token: 0x06018D2D RID: 101677 RVA: 0x0039E447 File Offset: 0x0039C647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053D8 RID: 21464
		// (get) Token: 0x06018D2E RID: 101678 RVA: 0x0039E44A File Offset: 0x0039C64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShieldUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018D2F RID: 101679 RVA: 0x0039E451 File Offset: 0x0039C651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateNotify()
		{
		}

		// Token: 0x06018D30 RID: 101680 RVA: 0x0039E464 File Offset: 0x0039C664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateNotify(ShieldUpdateNotify other) : this()
		{
			this.shields_ = other.shields_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D31 RID: 101681 RVA: 0x0039E48E File Offset: 0x0039C68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateNotify Clone()
		{
			return new ShieldUpdateNotify(this);
		}

		// Token: 0x170053D9 RID: 21465
		// (get) Token: 0x06018D32 RID: 101682 RVA: 0x0039E496 File Offset: 0x0039C696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShieldUpdateInfo> Shields
		{
			get
			{
				return this.shields_;
			}
		}

		// Token: 0x06018D33 RID: 101683 RVA: 0x0039E49E File Offset: 0x0039C69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShieldUpdateNotify);
		}

		// Token: 0x06018D34 RID: 101684 RVA: 0x0039E4AC File Offset: 0x0039C6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShieldUpdateNotify other)
		{
			return other != null && (other == this || (this.shields_.Equals(other.shields_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D35 RID: 101685 RVA: 0x0039E4E0 File Offset: 0x0039C6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.shields_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D36 RID: 101686 RVA: 0x0039E514 File Offset: 0x0039C714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D37 RID: 101687 RVA: 0x0039E521 File Offset: 0x0039C721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D38 RID: 101688 RVA: 0x0039E52A File Offset: 0x0039C72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shields_.WriteTo(ref output, ShieldUpdateNotify._repeated_shields_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D39 RID: 101689 RVA: 0x0039E554 File Offset: 0x0039C754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.shields_.CalculateSize(ShieldUpdateNotify._repeated_shields_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D3A RID: 101690 RVA: 0x0039E58D File Offset: 0x0039C78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShieldUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.shields_.Add(other.shields_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D3B RID: 101691 RVA: 0x0039E5BB File Offset: 0x0039C7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D3C RID: 101692 RVA: 0x0039E5C4 File Offset: 0x0039C7C4
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.shields_.AddEntriesFrom(ref input, ShieldUpdateNotify._repeated_shields_codec);
				}
			}
		}

		// Token: 0x04009348 RID: 37704
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009349 RID: 37705
		public const int ShieldsFieldNumber = 11;

		// Token: 0x0400934A RID: 37706
		private static readonly FieldCodec<ShieldUpdateInfo> _repeated_shields_codec = FieldCodec.ForMessage<ShieldUpdateInfo>(90U, ShieldUpdateInfo.Parser);

		// Token: 0x0400934B RID: 37707
		private readonly RepeatedField<ShieldUpdateInfo> shields_ = new RepeatedField<ShieldUpdateInfo>();
	}
}

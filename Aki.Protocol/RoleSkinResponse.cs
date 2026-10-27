using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BE RID: 4286
	[NetMessage(EMessageId.RoleSkinResponse)]
	public sealed class RoleSkinResponse : IMessage<RoleSkinResponse>, IMessage, IEquatable<RoleSkinResponse>, IDeepCloneable<RoleSkinResponse>, IBufferMessage
	{
		// Token: 0x06016E0B RID: 93707 RVA: 0x00352A2A File Offset: 0x00350C2A
		[NullableContext(1)]
		public static RoleSkinResponse Create()
		{
			return new RoleSkinResponse();
		}

		// Token: 0x17004CA5 RID: 19621
		// (get) Token: 0x06016E0C RID: 93708 RVA: 0x00352A31 File Offset: 0x00350C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CA6 RID: 19622
		// (get) Token: 0x06016E0D RID: 93709 RVA: 0x00352A34 File Offset: 0x00350C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinResponse.Descriptor;
			}
		}

		// Token: 0x06016E0E RID: 93710 RVA: 0x00352A3B File Offset: 0x00350C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinResponse()
		{
		}

		// Token: 0x06016E0F RID: 93711 RVA: 0x00352A4E File Offset: 0x00350C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinResponse(RoleSkinResponse other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E10 RID: 93712 RVA: 0x00352A78 File Offset: 0x00350C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinResponse Clone()
		{
			return new RoleSkinResponse(this);
		}

		// Token: 0x17004CA7 RID: 19623
		// (get) Token: 0x06016E11 RID: 93713 RVA: 0x00352A80 File Offset: 0x00350C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x06016E12 RID: 93714 RVA: 0x00352A88 File Offset: 0x00350C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinResponse);
		}

		// Token: 0x06016E13 RID: 93715 RVA: 0x00352A96 File Offset: 0x00350C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinResponse other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E14 RID: 93716 RVA: 0x00352ACC File Offset: 0x00350CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016E15 RID: 93717 RVA: 0x00352B00 File Offset: 0x00350D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E16 RID: 93718 RVA: 0x00352B0D File Offset: 0x00350D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E17 RID: 93719 RVA: 0x00352B16 File Offset: 0x00350D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, RoleSkinResponse._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E18 RID: 93720 RVA: 0x00352B40 File Offset: 0x00350D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(RoleSkinResponse._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016E19 RID: 93721 RVA: 0x00352B79 File Offset: 0x00350D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E1A RID: 93722 RVA: 0x00352BA7 File Offset: 0x00350DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E1B RID: 93723 RVA: 0x00352BB0 File Offset: 0x00350DB0
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, RoleSkinResponse._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x0400886D RID: 34925
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400886E RID: 34926
		public const int SkinIdsFieldNumber = 14;

		// Token: 0x0400886F RID: 34927
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04008870 RID: 34928
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}

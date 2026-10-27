using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D80 RID: 3456
	[NetMessage(EMessageId.PlayerAttrNotify)]
	public sealed class PlayerAttrNotify : IMessage<PlayerAttrNotify>, IMessage, IEquatable<PlayerAttrNotify>, IDeepCloneable<PlayerAttrNotify>, IBufferMessage
	{
		// Token: 0x06012A1C RID: 76316 RVA: 0x002B7CDC File Offset: 0x002B5EDC
		[NullableContext(1)]
		public static PlayerAttrNotify Create()
		{
			return new PlayerAttrNotify();
		}

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x06012A1D RID: 76317 RVA: 0x002B7CE3 File Offset: 0x002B5EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x06012A1E RID: 76318 RVA: 0x002B7CE6 File Offset: 0x002B5EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAttrNotify.Descriptor;
			}
		}

		// Token: 0x06012A1F RID: 76319 RVA: 0x002B7CED File Offset: 0x002B5EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttrNotify()
		{
		}

		// Token: 0x06012A20 RID: 76320 RVA: 0x002B7D00 File Offset: 0x002B5F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttrNotify(PlayerAttrNotify other) : this()
		{
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A21 RID: 76321 RVA: 0x002B7D2A File Offset: 0x002B5F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttrNotify Clone()
		{
			return new PlayerAttrNotify(this);
		}

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x06012A22 RID: 76322 RVA: 0x002B7D32 File Offset: 0x002B5F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerAttr> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x06012A23 RID: 76323 RVA: 0x002B7D3A File Offset: 0x002B5F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAttrNotify);
		}

		// Token: 0x06012A24 RID: 76324 RVA: 0x002B7D48 File Offset: 0x002B5F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAttrNotify other)
		{
			return other != null && (other == this || (this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A25 RID: 76325 RVA: 0x002B7D7C File Offset: 0x002B5F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attributes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012A26 RID: 76326 RVA: 0x002B7DB0 File Offset: 0x002B5FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A27 RID: 76327 RVA: 0x002B7DBD File Offset: 0x002B5FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A28 RID: 76328 RVA: 0x002B7DC6 File Offset: 0x002B5FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributes_.WriteTo(ref output, PlayerAttrNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A29 RID: 76329 RVA: 0x002B7DF0 File Offset: 0x002B5FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributes_.CalculateSize(PlayerAttrNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012A2A RID: 76330 RVA: 0x002B7E29 File Offset: 0x002B6029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAttrNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.attributes_.Add(other.attributes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012A2B RID: 76331 RVA: 0x002B7E57 File Offset: 0x002B6057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A2C RID: 76332 RVA: 0x002B7E60 File Offset: 0x002B6060
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.attributes_.AddEntriesFrom(ref input, PlayerAttrNotify._repeated_attributes_codec);
				}
			}
		}

		// Token: 0x0400739C RID: 29596
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400739D RID: 29597
		public const int AttributesFieldNumber = 2;

		// Token: 0x0400739E RID: 29598
		private static readonly FieldCodec<PlayerAttr> _repeated_attributes_codec = FieldCodec.ForMessage<PlayerAttr>(18U, PlayerAttr.Parser);

		// Token: 0x0400739F RID: 29599
		private readonly RepeatedField<PlayerAttr> attributes_ = new RepeatedField<PlayerAttr>();
	}
}

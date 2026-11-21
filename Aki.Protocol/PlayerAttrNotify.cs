using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D70 RID: 3440
	[NetMessage(EMessageId.PlayerAttrNotify)]
	public sealed class PlayerAttrNotify : IMessage<PlayerAttrNotify>, IMessage, IEquatable<PlayerAttrNotify>, IDeepCloneable<PlayerAttrNotify>, IBufferMessage
	{
		// Token: 0x06012920 RID: 76064 RVA: 0x002B60BC File Offset: 0x002B42BC
		[NullableContext(1)]
		public static PlayerAttrNotify Create()
		{
			return new PlayerAttrNotify();
		}

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x06012921 RID: 76065 RVA: 0x002B60C3 File Offset: 0x002B42C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x06012922 RID: 76066 RVA: 0x002B60C6 File Offset: 0x002B42C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAttrNotify.Descriptor;
			}
		}

		// Token: 0x06012923 RID: 76067 RVA: 0x002B60CD File Offset: 0x002B42CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttrNotify()
		{
		}

		// Token: 0x06012924 RID: 76068 RVA: 0x002B60E0 File Offset: 0x002B42E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttrNotify(PlayerAttrNotify other) : this()
		{
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012925 RID: 76069 RVA: 0x002B610A File Offset: 0x002B430A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAttrNotify Clone()
		{
			return new PlayerAttrNotify(this);
		}

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x06012926 RID: 76070 RVA: 0x002B6112 File Offset: 0x002B4312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerAttr> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x06012927 RID: 76071 RVA: 0x002B611A File Offset: 0x002B431A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAttrNotify);
		}

		// Token: 0x06012928 RID: 76072 RVA: 0x002B6128 File Offset: 0x002B4328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAttrNotify other)
		{
			return other != null && (other == this || (this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012929 RID: 76073 RVA: 0x002B615C File Offset: 0x002B435C
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

		// Token: 0x0601292A RID: 76074 RVA: 0x002B6190 File Offset: 0x002B4390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601292B RID: 76075 RVA: 0x002B619D File Offset: 0x002B439D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601292C RID: 76076 RVA: 0x002B61A6 File Offset: 0x002B43A6
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

		// Token: 0x0601292D RID: 76077 RVA: 0x002B61D0 File Offset: 0x002B43D0
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

		// Token: 0x0601292E RID: 76078 RVA: 0x002B6209 File Offset: 0x002B4409
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

		// Token: 0x0601292F RID: 76079 RVA: 0x002B6237 File Offset: 0x002B4437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012930 RID: 76080 RVA: 0x002B6240 File Offset: 0x002B4440
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

		// Token: 0x040073B4 RID: 29620
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073B5 RID: 29621
		public const int AttributesFieldNumber = 2;

		// Token: 0x040073B6 RID: 29622
		private static readonly FieldCodec<PlayerAttr> _repeated_attributes_codec = FieldCodec.ForMessage<PlayerAttr>(18U, PlayerAttr.Parser);

		// Token: 0x040073B7 RID: 29623
		private readonly RepeatedField<PlayerAttr> attributes_ = new RepeatedField<PlayerAttr>();
	}
}

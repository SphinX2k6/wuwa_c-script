using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021B RID: 539
	[NetMessage(EMessageId.ButtonIsEnableRequest)]
	public sealed class ButtonIsEnableRequest : IMessage<ButtonIsEnableRequest>, IMessage, IEquatable<ButtonIsEnableRequest>, IDeepCloneable<ButtonIsEnableRequest>, IBufferMessage
	{
		// Token: 0x06003B3A RID: 15162 RVA: 0x0009398C File Offset: 0x00091B8C
		[NullableContext(1)]
		public static ButtonIsEnableRequest Create()
		{
			return new ButtonIsEnableRequest();
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06003B3B RID: 15163 RVA: 0x00093993 File Offset: 0x00091B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x00093996 File Offset: 0x00091B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ButtonIsEnableRequest.Descriptor;
			}
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x0009399D File Offset: 0x00091B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonIsEnableRequest()
		{
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x000939B0 File Offset: 0x00091BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonIsEnableRequest(ButtonIsEnableRequest other) : this()
		{
			this.type_ = other.type_;
			this.types_ = other.types_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x000939E6 File Offset: 0x00091BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonIsEnableRequest Clone()
		{
			return new ButtonIsEnableRequest(this);
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06003B40 RID: 15168 RVA: 0x000939EE File Offset: 0x00091BEE
		// (set) Token: 0x06003B41 RID: 15169 RVA: 0x000939F6 File Offset: 0x00091BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06003B42 RID: 15170 RVA: 0x000939FF File Offset: 0x00091BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ButtonType> Types_
		{
			get
			{
				return this.types_;
			}
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x00093A07 File Offset: 0x00091C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ButtonIsEnableRequest);
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x00093A18 File Offset: 0x00091C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ButtonIsEnableRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.types_.Equals(other.types_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x00093A68 File Offset: 0x00091C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != ButtonType.Home)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.types_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x00093ABB File Offset: 0x00091CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00093AC8 File Offset: 0x00091CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x00093AD4 File Offset: 0x00091CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.types_.WriteTo(ref output, ButtonIsEnableRequest._repeated_types_codec);
			if (this.Type != ButtonType.Home)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x00093B24 File Offset: 0x00091D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != ButtonType.Home)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			num += this.types_.CalculateSize(ButtonIsEnableRequest._repeated_types_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x00093B78 File Offset: 0x00091D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ButtonIsEnableRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != ButtonType.Home)
			{
				this.Type = other.Type;
			}
			this.types_.Add(other.types_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x00093BC5 File Offset: 0x00091DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x00093BD0 File Offset: 0x00091DD0
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (ButtonType)input.ReadEnum();
					}
				}
				else
				{
					this.types_.AddEntriesFrom(ref input, ButtonIsEnableRequest._repeated_types_codec);
				}
			}
		}

		// Token: 0x04002C5C RID: 11356
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C5D RID: 11357
		public const int TypeFieldNumber = 9;

		// Token: 0x04002C5E RID: 11358
		private ButtonType type_;

		// Token: 0x04002C5F RID: 11359
		public const int Types_FieldNumber = 1;

		// Token: 0x04002C60 RID: 11360
		private static readonly FieldCodec<ButtonType> _repeated_types_codec = FieldCodec.ForEnum<ButtonType>(10U, (ButtonType x) => (int)x, (int x) => (ButtonType)x);

		// Token: 0x04002C61 RID: 11361
		private readonly RepeatedField<ButtonType> types_ = new RepeatedField<ButtonType>();
	}
}

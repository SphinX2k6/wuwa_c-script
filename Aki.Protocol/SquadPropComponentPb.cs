using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F7 RID: 4855
	public sealed class SquadPropComponentPb : IMessage<SquadPropComponentPb>, IMessage, IEquatable<SquadPropComponentPb>, IDeepCloneable<SquadPropComponentPb>, IBufferMessage
	{
		// Token: 0x06019E65 RID: 106085 RVA: 0x003C6F35 File Offset: 0x003C5135
		[NullableContext(1)]
		public static SquadPropComponentPb Create()
		{
			return new SquadPropComponentPb();
		}

		// Token: 0x170057B6 RID: 22454
		// (get) Token: 0x06019E66 RID: 106086 RVA: 0x003C6F3C File Offset: 0x003C513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057B7 RID: 22455
		// (get) Token: 0x06019E67 RID: 106087 RVA: 0x003C6F3F File Offset: 0x003C513F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SquadPropComponentPb.Descriptor;
			}
		}

		// Token: 0x06019E68 RID: 106088 RVA: 0x003C6F46 File Offset: 0x003C5146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropComponentPb()
		{
		}

		// Token: 0x06019E69 RID: 106089 RVA: 0x003C6F59 File Offset: 0x003C5159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropComponentPb(SquadPropComponentPb other) : this()
		{
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E6A RID: 106090 RVA: 0x003C6F83 File Offset: 0x003C5183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropComponentPb Clone()
		{
			return new SquadPropComponentPb(this);
		}

		// Token: 0x170057B8 RID: 22456
		// (get) Token: 0x06019E6B RID: 106091 RVA: 0x003C6F8B File Offset: 0x003C518B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x06019E6C RID: 106092 RVA: 0x003C6F93 File Offset: 0x003C5193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SquadPropComponentPb);
		}

		// Token: 0x06019E6D RID: 106093 RVA: 0x003C6FA1 File Offset: 0x003C51A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SquadPropComponentPb other)
		{
			return other != null && (other == this || (this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E6E RID: 106094 RVA: 0x003C6FD4 File Offset: 0x003C51D4
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

		// Token: 0x06019E6F RID: 106095 RVA: 0x003C7008 File Offset: 0x003C5208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E70 RID: 106096 RVA: 0x003C7015 File Offset: 0x003C5215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E71 RID: 106097 RVA: 0x003C701E File Offset: 0x003C521E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributes_.WriteTo(ref output, SquadPropComponentPb._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E72 RID: 106098 RVA: 0x003C7048 File Offset: 0x003C5248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributes_.CalculateSize(SquadPropComponentPb._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019E73 RID: 106099 RVA: 0x003C7081 File Offset: 0x003C5281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SquadPropComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.attributes_.Add(other.attributes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019E74 RID: 106100 RVA: 0x003C70AF File Offset: 0x003C52AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E75 RID: 106101 RVA: 0x003C70B8 File Offset: 0x003C52B8
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.attributes_.AddEntriesFrom(ref input, SquadPropComponentPb._repeated_attributes_codec);
				}
			}
		}

		// Token: 0x040098B7 RID: 39095
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098B8 RID: 39096
		public const int AttributesFieldNumber = 1;

		// Token: 0x040098B9 RID: 39097
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(10U, GameplayAttributeData.Parser);

		// Token: 0x040098BA RID: 39098
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}

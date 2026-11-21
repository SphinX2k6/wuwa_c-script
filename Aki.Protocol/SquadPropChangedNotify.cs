using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F6 RID: 4854
	[NetMessage(EMessageId.SquadPropChangedNotify)]
	public sealed class SquadPropChangedNotify : IMessage<SquadPropChangedNotify>, IMessage, IEquatable<SquadPropChangedNotify>, IDeepCloneable<SquadPropChangedNotify>, IBufferMessage
	{
		// Token: 0x06019E53 RID: 106067 RVA: 0x003C6D52 File Offset: 0x003C4F52
		[NullableContext(1)]
		public static SquadPropChangedNotify Create()
		{
			return new SquadPropChangedNotify();
		}

		// Token: 0x170057B3 RID: 22451
		// (get) Token: 0x06019E54 RID: 106068 RVA: 0x003C6D59 File Offset: 0x003C4F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057B4 RID: 22452
		// (get) Token: 0x06019E55 RID: 106069 RVA: 0x003C6D5C File Offset: 0x003C4F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SquadPropChangedNotify.Descriptor;
			}
		}

		// Token: 0x06019E56 RID: 106070 RVA: 0x003C6D63 File Offset: 0x003C4F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropChangedNotify()
		{
		}

		// Token: 0x06019E57 RID: 106071 RVA: 0x003C6D76 File Offset: 0x003C4F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropChangedNotify(SquadPropChangedNotify other) : this()
		{
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E58 RID: 106072 RVA: 0x003C6DA0 File Offset: 0x003C4FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropChangedNotify Clone()
		{
			return new SquadPropChangedNotify(this);
		}

		// Token: 0x170057B5 RID: 22453
		// (get) Token: 0x06019E59 RID: 106073 RVA: 0x003C6DA8 File Offset: 0x003C4FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x06019E5A RID: 106074 RVA: 0x003C6DB0 File Offset: 0x003C4FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SquadPropChangedNotify);
		}

		// Token: 0x06019E5B RID: 106075 RVA: 0x003C6DBE File Offset: 0x003C4FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SquadPropChangedNotify other)
		{
			return other != null && (other == this || (this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E5C RID: 106076 RVA: 0x003C6DF4 File Offset: 0x003C4FF4
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

		// Token: 0x06019E5D RID: 106077 RVA: 0x003C6E28 File Offset: 0x003C5028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E5E RID: 106078 RVA: 0x003C6E35 File Offset: 0x003C5035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E5F RID: 106079 RVA: 0x003C6E3E File Offset: 0x003C503E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributes_.WriteTo(ref output, SquadPropChangedNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E60 RID: 106080 RVA: 0x003C6E68 File Offset: 0x003C5068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributes_.CalculateSize(SquadPropChangedNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019E61 RID: 106081 RVA: 0x003C6EA1 File Offset: 0x003C50A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SquadPropChangedNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.attributes_.Add(other.attributes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019E62 RID: 106082 RVA: 0x003C6ECF File Offset: 0x003C50CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E63 RID: 106083 RVA: 0x003C6ED8 File Offset: 0x003C50D8
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
					this.attributes_.AddEntriesFrom(ref input, SquadPropChangedNotify._repeated_attributes_codec);
				}
			}
		}

		// Token: 0x040098B3 RID: 39091
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098B4 RID: 39092
		public const int AttributesFieldNumber = 2;

		// Token: 0x040098B5 RID: 39093
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(18U, GameplayAttributeData.Parser);

		// Token: 0x040098B6 RID: 39094
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}

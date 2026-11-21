using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147B RID: 5243
	public sealed class TrapDefenseAuxiliaryPbData : IMessage<TrapDefenseAuxiliaryPbData>, IMessage, IEquatable<TrapDefenseAuxiliaryPbData>, IDeepCloneable<TrapDefenseAuxiliaryPbData>, IBufferMessage
	{
		// Token: 0x0601BD84 RID: 114052 RVA: 0x0040BF24 File Offset: 0x0040A124
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryPbData Create()
		{
			return new TrapDefenseAuxiliaryPbData();
		}

		// Token: 0x17005E49 RID: 24137
		// (get) Token: 0x0601BD85 RID: 114053 RVA: 0x0040BF2B File Offset: 0x0040A12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E4A RID: 24138
		// (get) Token: 0x0601BD86 RID: 114054 RVA: 0x0040BF2E File Offset: 0x0040A12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryPbData.Descriptor;
			}
		}

		// Token: 0x0601BD87 RID: 114055 RVA: 0x0040BF35 File Offset: 0x0040A135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryPbData()
		{
		}

		// Token: 0x0601BD88 RID: 114056 RVA: 0x0040BF48 File Offset: 0x0040A148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryPbData(TrapDefenseAuxiliaryPbData other) : this()
		{
			this.configIds_ = other.configIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD89 RID: 114057 RVA: 0x0040BF72 File Offset: 0x0040A172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryPbData Clone()
		{
			return new TrapDefenseAuxiliaryPbData(this);
		}

		// Token: 0x17005E4B RID: 24139
		// (get) Token: 0x0601BD8A RID: 114058 RVA: 0x0040BF7A File Offset: 0x0040A17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConfigIds
		{
			get
			{
				return this.configIds_;
			}
		}

		// Token: 0x0601BD8B RID: 114059 RVA: 0x0040BF82 File Offset: 0x0040A182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryPbData);
		}

		// Token: 0x0601BD8C RID: 114060 RVA: 0x0040BF90 File Offset: 0x0040A190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryPbData other)
		{
			return other != null && (other == this || (this.configIds_.Equals(other.configIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD8D RID: 114061 RVA: 0x0040BFC4 File Offset: 0x0040A1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.configIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BD8E RID: 114062 RVA: 0x0040BFF8 File Offset: 0x0040A1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD8F RID: 114063 RVA: 0x0040C005 File Offset: 0x0040A205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD90 RID: 114064 RVA: 0x0040C00E File Offset: 0x0040A20E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.configIds_.WriteTo(ref output, TrapDefenseAuxiliaryPbData._repeated_configIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BD91 RID: 114065 RVA: 0x0040C038 File Offset: 0x0040A238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.configIds_.CalculateSize(TrapDefenseAuxiliaryPbData._repeated_configIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BD92 RID: 114066 RVA: 0x0040C071 File Offset: 0x0040A271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseAuxiliaryPbData other)
		{
			if (other == null)
			{
				return;
			}
			this.configIds_.Add(other.configIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BD93 RID: 114067 RVA: 0x0040C09F File Offset: 0x0040A29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD94 RID: 114068 RVA: 0x0040C0A8 File Offset: 0x0040A2A8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.configIds_.AddEntriesFrom(ref input, TrapDefenseAuxiliaryPbData._repeated_configIds_codec);
				}
			}
		}

		// Token: 0x0400A199 RID: 41369
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A19A RID: 41370
		public const int ConfigIdsFieldNumber = 1;

		// Token: 0x0400A19B RID: 41371
		private static readonly FieldCodec<int> _repeated_configIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400A19C RID: 41372
		private readonly RepeatedField<int> configIds_ = new RepeatedField<int>();
	}
}

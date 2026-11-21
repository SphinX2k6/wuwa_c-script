using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2D RID: 2861
	public sealed class NewTowerRecommendData : IMessage<NewTowerRecommendData>, IMessage, IEquatable<NewTowerRecommendData>, IDeepCloneable<NewTowerRecommendData>, IBufferMessage
	{
		// Token: 0x0600F8A0 RID: 63648 RVA: 0x002447B5 File Offset: 0x002429B5
		[NullableContext(1)]
		public static NewTowerRecommendData Create()
		{
			return new NewTowerRecommendData();
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600F8A1 RID: 63649 RVA: 0x002447BC File Offset: 0x002429BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600F8A2 RID: 63650 RVA: 0x002447BF File Offset: 0x002429BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRecommendData.Descriptor;
			}
		}

		// Token: 0x0600F8A3 RID: 63651 RVA: 0x002447C6 File Offset: 0x002429C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendData()
		{
		}

		// Token: 0x0600F8A4 RID: 63652 RVA: 0x002447D9 File Offset: 0x002429D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendData(NewTowerRecommendData other) : this()
		{
			this.recommendLevels_ = other.recommendLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F8A5 RID: 63653 RVA: 0x00244803 File Offset: 0x00242A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendData Clone()
		{
			return new NewTowerRecommendData(this);
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600F8A6 RID: 63654 RVA: 0x0024480B File Offset: 0x00242A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerRecommendLevel> RecommendLevels
		{
			get
			{
				return this.recommendLevels_;
			}
		}

		// Token: 0x0600F8A7 RID: 63655 RVA: 0x00244813 File Offset: 0x00242A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRecommendData);
		}

		// Token: 0x0600F8A8 RID: 63656 RVA: 0x00244821 File Offset: 0x00242A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRecommendData other)
		{
			return other != null && (other == this || (this.recommendLevels_.Equals(other.recommendLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F8A9 RID: 63657 RVA: 0x00244854 File Offset: 0x00242A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.recommendLevels_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F8AA RID: 63658 RVA: 0x00244888 File Offset: 0x00242A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F8AB RID: 63659 RVA: 0x00244895 File Offset: 0x00242A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F8AC RID: 63660 RVA: 0x0024489E File Offset: 0x00242A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recommendLevels_.WriteTo(ref output, NewTowerRecommendData._repeated_recommendLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F8AD RID: 63661 RVA: 0x002448C8 File Offset: 0x00242AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.recommendLevels_.CalculateSize(NewTowerRecommendData._repeated_recommendLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F8AE RID: 63662 RVA: 0x00244901 File Offset: 0x00242B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRecommendData other)
		{
			if (other == null)
			{
				return;
			}
			this.recommendLevels_.Add(other.recommendLevels_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F8AF RID: 63663 RVA: 0x0024492F File Offset: 0x00242B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F8B0 RID: 63664 RVA: 0x00244938 File Offset: 0x00242B38
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
					this.recommendLevels_.AddEntriesFrom(ref input, NewTowerRecommendData._repeated_recommendLevels_codec);
				}
			}
		}

		// Token: 0x0400640E RID: 25614
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400640F RID: 25615
		public const int RecommendLevelsFieldNumber = 1;

		// Token: 0x04006410 RID: 25616
		private static readonly FieldCodec<NewTowerRecommendLevel> _repeated_recommendLevels_codec = FieldCodec.ForMessage<NewTowerRecommendLevel>(10U, NewTowerRecommendLevel.Parser);

		// Token: 0x04006411 RID: 25617
		private readonly RepeatedField<NewTowerRecommendLevel> recommendLevels_ = new RepeatedField<NewTowerRecommendLevel>();
	}
}

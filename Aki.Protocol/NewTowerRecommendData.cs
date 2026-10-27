using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3E RID: 2878
	public sealed class NewTowerRecommendData : IMessage<NewTowerRecommendData>, IMessage, IEquatable<NewTowerRecommendData>, IDeepCloneable<NewTowerRecommendData>, IBufferMessage
	{
		// Token: 0x0600F9BA RID: 63930 RVA: 0x002469D1 File Offset: 0x00244BD1
		[NullableContext(1)]
		public static NewTowerRecommendData Create()
		{
			return new NewTowerRecommendData();
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600F9BB RID: 63931 RVA: 0x002469D8 File Offset: 0x00244BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600F9BC RID: 63932 RVA: 0x002469DB File Offset: 0x00244BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRecommendData.Descriptor;
			}
		}

		// Token: 0x0600F9BD RID: 63933 RVA: 0x002469E2 File Offset: 0x00244BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendData()
		{
		}

		// Token: 0x0600F9BE RID: 63934 RVA: 0x002469F5 File Offset: 0x00244BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendData(NewTowerRecommendData other) : this()
		{
			this.recommendLevels_ = other.recommendLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F9BF RID: 63935 RVA: 0x00246A1F File Offset: 0x00244C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendData Clone()
		{
			return new NewTowerRecommendData(this);
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600F9C0 RID: 63936 RVA: 0x00246A27 File Offset: 0x00244C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerRecommendLevel> RecommendLevels
		{
			get
			{
				return this.recommendLevels_;
			}
		}

		// Token: 0x0600F9C1 RID: 63937 RVA: 0x00246A2F File Offset: 0x00244C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRecommendData);
		}

		// Token: 0x0600F9C2 RID: 63938 RVA: 0x00246A3D File Offset: 0x00244C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRecommendData other)
		{
			return other != null && (other == this || (this.recommendLevels_.Equals(other.recommendLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F9C3 RID: 63939 RVA: 0x00246A70 File Offset: 0x00244C70
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

		// Token: 0x0600F9C4 RID: 63940 RVA: 0x00246AA4 File Offset: 0x00244CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F9C5 RID: 63941 RVA: 0x00246AB1 File Offset: 0x00244CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F9C6 RID: 63942 RVA: 0x00246ABA File Offset: 0x00244CBA
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

		// Token: 0x0600F9C7 RID: 63943 RVA: 0x00246AE4 File Offset: 0x00244CE4
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

		// Token: 0x0600F9C8 RID: 63944 RVA: 0x00246B1D File Offset: 0x00244D1D
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

		// Token: 0x0600F9C9 RID: 63945 RVA: 0x00246B4B File Offset: 0x00244D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F9CA RID: 63946 RVA: 0x00246B54 File Offset: 0x00244D54
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

		// Token: 0x04006405 RID: 25605
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006406 RID: 25606
		public const int RecommendLevelsFieldNumber = 1;

		// Token: 0x04006407 RID: 25607
		private static readonly FieldCodec<NewTowerRecommendLevel> _repeated_recommendLevels_codec = FieldCodec.ForMessage<NewTowerRecommendLevel>(10U, NewTowerRecommendLevel.Parser);

		// Token: 0x04006408 RID: 25608
		private readonly RepeatedField<NewTowerRecommendLevel> recommendLevels_ = new RepeatedField<NewTowerRecommendLevel>();
	}
}

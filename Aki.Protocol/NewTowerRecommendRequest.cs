using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B40 RID: 2880
	[NetMessage(EMessageId.NewTowerRecommendRequest)]
	public sealed class NewTowerRecommendRequest : IMessage<NewTowerRecommendRequest>, IMessage, IEquatable<NewTowerRecommendRequest>, IDeepCloneable<NewTowerRecommendRequest>, IBufferMessage
	{
		// Token: 0x0600F9E3 RID: 63971 RVA: 0x00246F28 File Offset: 0x00245128
		[NullableContext(1)]
		public static NewTowerRecommendRequest Create()
		{
			return new NewTowerRecommendRequest();
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600F9E4 RID: 63972 RVA: 0x00246F2F File Offset: 0x0024512F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600F9E5 RID: 63973 RVA: 0x00246F32 File Offset: 0x00245132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRecommendRequest.Descriptor;
			}
		}

		// Token: 0x0600F9E6 RID: 63974 RVA: 0x00246F39 File Offset: 0x00245139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendRequest()
		{
		}

		// Token: 0x0600F9E7 RID: 63975 RVA: 0x00246F41 File Offset: 0x00245141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendRequest(NewTowerRecommendRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F9E8 RID: 63976 RVA: 0x00246F5A File Offset: 0x0024515A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendRequest Clone()
		{
			return new NewTowerRecommendRequest(this);
		}

		// Token: 0x0600F9E9 RID: 63977 RVA: 0x00246F62 File Offset: 0x00245162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRecommendRequest);
		}

		// Token: 0x0600F9EA RID: 63978 RVA: 0x00246F70 File Offset: 0x00245170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRecommendRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F9EB RID: 63979 RVA: 0x00246F90 File Offset: 0x00245190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F9EC RID: 63980 RVA: 0x00246FB6 File Offset: 0x002451B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F9ED RID: 63981 RVA: 0x00246FC3 File Offset: 0x002451C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F9EE RID: 63982 RVA: 0x00246FCC File Offset: 0x002451CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F9EF RID: 63983 RVA: 0x00246FE4 File Offset: 0x002451E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F9F0 RID: 63984 RVA: 0x0024700A File Offset: 0x0024520A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRecommendRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F9F1 RID: 63985 RVA: 0x00247027 File Offset: 0x00245227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F9F2 RID: 63986 RVA: 0x00247030 File Offset: 0x00245230
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006412 RID: 25618
		private UnknownFieldSet _unknownFields;
	}
}
